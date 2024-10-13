using System.Windows.Forms;

namespace Hare_and_Tortoise_v2 {
    public partial class Form1 : Form {

        //A enum for the Log() function
        //Describes what type of log is being made
        //Public so that it can be accessed from anywhere
        public enum LogType {
            programLog,
            raceOutput,
            leagueTable
        }

        public LogType currentOutputLogType = LogType.programLog;

        private List<Animal> animalList = new List<Animal>();

        //Lists to store the different types of logged messages


        public Form1() {
            InitializeComponent();
            programLogLstBox.ScrollAlwaysVisible = true;
            raceOutputLstBox.ScrollAlwaysVisible = true;
            leagueTableLstBox.ScrollAlwaysVisible = true;
            raceOutputLstBox.Visible = false;
            leagueTableLstBox.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        //When the 'Start Races' button is clicked
        private void startRaceButton_Click(object sender, EventArgs e) {
            List<Animal> animalWinnerList = Race(animalList);

            //TEMPORARY SOLUTION
            Log($"The winner is {animalWinnerList[0].name}", LogType.raceOutput);
            Log($"The winner is {animalWinnerList[0].name}", LogType.programLog);
        }

        //When the 'Load File' button is clicked
        private void loadFileButton_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            TryLoadFile(file, out animalList);
        }

        //When the 'Reset' button is clicked
        private void resetButton_Click(object sender, EventArgs e) {
            clearButton_Click(this, new EventArgs());
            programLogRadioButton.Select();
            ButtonsAfterFileReset();
        }

        //When the Radio Button is changed to 'Program Log'
        private void programLogRadioButton_CheckedChanged(object sender, EventArgs e) {
            programLogLstBox.Visible = true;
            raceOutputLstBox.Visible = false;
            leagueTableLstBox.Visible= false;
            currentOutputLogType = LogType.programLog;
            outputDescLabel.Text = "Program Log";
        }

        //When the Radio Button is changed to 'Race Output'
        private void raceOutputRadioButton_CheckedChanged(object sender, EventArgs e) {
            programLogLstBox.Visible = false;
            raceOutputLstBox.Visible = true;
            leagueTableLstBox.Visible = false;
            currentOutputLogType = LogType.raceOutput;
            outputDescLabel.Text = "Race Output";
        }

        //When the Radio Button is changed to 'League Output'
        private void leagueOutputRadioButton_CheckedChanged(object sender, EventArgs e) {
            programLogLstBox.Visible = false;
            raceOutputLstBox.Visible = false;
            leagueTableLstBox.Visible = true;
            currentOutputLogType = LogType.leagueTable;
            outputDescLabel.Text = "League Table";
        }

        //When the 'Clear' button is clicked
        private void clearButton_Click(object sender, EventArgs e) {
            switch(currentOutputLogType) {
                case LogType.programLog:
                    programLogLstBox.Items.Clear();
                    break;
                case LogType.raceOutput:
                    raceOutputLstBox.Items.Clear();
                    break;
                case LogType.leagueTable:
                    leagueTableLstBox.Items.Clear();
                    break;
            }
            clearButton.Enabled = false;
        }


        //Try to load in a file
        //Returns a boolean depending on whether or not the function succeeded
        //Uses an out variable to return the List of Animals that have been created
        private bool TryLoadFile(string file, out List<Animal> animalListOut) {
            string fileExt = Path.GetExtension(file);
            animalListOut = new List<Animal>();

            StreamReader streamReader = new StreamReader(file);

            try {
                if (fileExt != ".txt") {  //Only allows .txt files to be loaded
                    Log("Incorrect file type - please upload a .txt file", LogType.programLog);
                    throw new Exception("Incorrect file type");
                }

                string fileContents = streamReader.ReadToEnd();

                Log($"Loading File: {file}", LogType.programLog);
                animalListOut = CreateAnimalList(fileContents);
                Log("Finished Loading File", LogType.programLog);

                streamReader.Close();
                ButtonsAfterFileLoad();
                return true;

            } catch {
                streamReader.Close();
                Log("Error opening/reading file", LogType.programLog);
                return false;
            }
        }

        //Create a List of Animals
        //Returns the List of Animals that has been created
        //Further decomposition of the TryLoadFile() Function
        private List<Animal> CreateAnimalList(string fileContents) {
            List<Animal> animalListToReturn = new List<Animal>();
            String[] lines = fileContents.Split(";"); //Separate different animals with a semicolon ";"

            foreach (String line in lines) {
                if (line == "") { break; } //Prevents errors when a semicolon is at the end of the file
                String[] attributes = line.Split(","); //Separate animal attributes with a comma ","
                Animal newAnimal = new Animal(attributes[0], Int32.Parse(attributes[1]), Int32.Parse(attributes[2]), Int32.Parse(attributes[3]), Int32.Parse(attributes[4]), Int32.Parse(attributes[5]), Int32.Parse(attributes[6]));
                animalListToReturn.Add(newAnimal);
                Log($"Added new animal: \"{attributes[0]}\"", LogType.programLog); //Debugging
            }

            return animalListToReturn;
        }

        //Carries out a single round of the Race
        //Calls upon each Animal's Move() function
        //Further decomposition of the Race() function
        private static void Round(List<Animal> animalsToMove) {
            foreach (Animal animal in animalsToMove) {
                animal.Move();
            }
        }

        //Determine if any animal has surpassed the "finish line" of the race
        //Returns a boolean (true/false)
        //Further decomposition of the Race() function
        private bool RaceFinished(List<Animal> animalsToCheck) {
            foreach (Animal animal in animalsToCheck) {
                if (animal.distanceTravelled >= raceDistanceNumUD.Value) {
                    return true;
                }
            }
            return false;
        }

        //Determine which Animal(s) won the race
        //Returns a List of all the Animals that won
        //Further decomposition of the Race() function
        private static List<Animal> DetermineWinner(List<Animal> animalsToCheck) {

            int maxDistance = animalsToCheck[0].distanceTravelled;
            Animal maxAnimal = animalsToCheck[0];

            List<Animal> animalWinnerList = new List<Animal>();

            //Find the Animal that has travelled the greatest distance
            foreach (Animal animal in animalsToCheck) {
                if (animal.distanceTravelled > maxDistance) {
                    maxDistance = animal.distanceTravelled;
                    maxAnimal = animal;
                }
            }

            //Add any animal that has travelled as far as the maximum distance to the List of winners
            //This will usually just be the Animal from the previous loop, but also checks for draws
            foreach (Animal animal in animalsToCheck) {
                if (animal.distanceTravelled == maxDistance) {
                    animalWinnerList.Add(animal);
                }
            }

            return animalWinnerList;
        }

        //Carry out a single race
        //Returns a List of the Animals that won the race
        //Called when the 'Start Races' button is clicked
        private List<Animal> Race(List<Animal> animalList) {
            List<Animal> animalWinnerList = new List<Animal>();

            while (!RaceFinished(animalList)) {
                Round(animalList);
            }

            animalWinnerList = DetermineWinner(animalList);

            //Reset each animal's distance to 0 after the race
            foreach (Animal animal in animalList) {
                animal.distanceTravelled = 0;
            }

            return animalWinnerList;
        }

        //Logs a message to display to the user
        //Takes an input of which type of log it is
        //Public so that it can be called from anywhere
        public void Log(string message, LogType logType) {

            switch(logType) {
                case LogType.programLog:
                    programLogLstBox.Items.Add(message);
                    break;
                case LogType.raceOutput:
                    //raceOutputList.Add(message);
                    if (raceOutputRadioButton.Checked) {
                      //  outputList.Items.Add(message);
                    }
                    break;
                case LogType.leagueTable:
                   // leagueTableList.Add(message);
                    if (leagueOutputRadioButton.Checked) {
                     //   outputList.Items.Add(message);
                    }
                    break;
            }
            
          //  outputList.SelectedIndex = outputList.Items.Count - 1; //Select the newest item in the list (Auto-Scrolling)
            clearButton.Enabled = true;
        }

        //Enables most buttons
        //Disables the 'Load File' button
        //Called after a file has successfully been loaded
        private void ButtonsAfterFileLoad() {
            loadFileButton.Enabled = false;
            resetButton.Enabled = true;
            startRaceButton.Enabled = true;
            numberRacesNumUD.Enabled = true;
            raceDistanceNumUD.Enabled = true;
            raceOutputRadioButton.Enabled = true;
            leagueOutputRadioButton.Enabled = true;
        }

        //Disables most buttons
        //Enables the 'Load File' button
        //Called when the 'Reset' button is clicked
        private void ButtonsAfterFileReset() {
            loadFileButton.Enabled = true;
            resetButton.Enabled = false;
            startRaceButton.Enabled = false;
            numberRacesNumUD.Enabled = false;
            raceDistanceNumUD.Enabled = false;
            raceOutputRadioButton.Enabled = false;
            leagueOutputRadioButton.Enabled = false;
        }
    }

    //A class for the Animals that are in the race
    //Each Animal will be an object of this class
    //Objects are created when a file is loaded
    public class Animal {
        //Animal attributes
        public string name;
        private int minMoveSpeed;
        private int maxMoveSpeed;
        private int baseRestChance;
        private int restChance;
        private int maxRestChance;
        private int increaseRestChance;
        public int distanceTravelled;

        //Allows for accessing functions within the Form1{} class
        private Form1 form1 = Application.OpenForms[0] as Form1;

        //Constructor function
        //When this function is called, an object of type Animal is created
        //Public so that it can be called from anywhere
        public Animal(string name, int minMoveSpeed, int maxMoveSpeed, int restChance = 0, int baseRestChance = 0, int maxRestChance = 100, int increaseRestChance = 0) {
            this.name = name;
            this.minMoveSpeed = minMoveSpeed;
            this.maxMoveSpeed = maxMoveSpeed;
            this.baseRestChance = baseRestChance;
            this.restChance = restChance;
            this.maxRestChance = maxRestChance;
            this.increaseRestChance = increaseRestChance;
        }

        //Moves Animal
        //Animal moves a random amount between their min and max move speeds, unless they are resting
        //Called once for each Animal on each round of a race 
        public void Move() {
            Random rnd = new Random();
            form1.Log($"test", Form1.LogType.raceOutput);
            distanceTravelled += rnd.Next(minMoveSpeed, maxMoveSpeed + 1);
        }
    }

}
