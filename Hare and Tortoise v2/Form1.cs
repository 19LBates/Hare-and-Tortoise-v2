using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Pkcs;
using System.Xml.Linq;

namespace Hare_and_Tortoise_v2 {
    public partial class Form1 : Form {

        public enum LogType {
            programLog,
            raceOutput,
            leagueTable
        }

        public LogType currentOutputLogType = LogType.programLog;

        private List<Animal> animalList = new List<Animal>();

        public Form1() {
            InitializeComponent();
            outputList.ScrollAlwaysVisible = true;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void startRaceButton_Click(object sender, EventArgs e) {
            Round(animalList);
        }

        private void loadFileButton_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            TryLoadFile(file, out animalList);
        }


        private void resetButton_Click(object sender, EventArgs e) {
            clearButton_Click(this, new EventArgs());
            programLogRadioButton.Select();
            ButtonsAfterFileReset();
        }

        private void programLogRadioButton_CheckedChanged(object sender, EventArgs e) {
            currentOutputLogType = LogType.programLog;
            outputDescLabel.Text = "Program Log";
        }
        private void raceOutputRadioButton_CheckedChanged(object sender, EventArgs e) {
            currentOutputLogType = LogType.raceOutput;
            outputDescLabel.Text = "Race Output";
        }

        private void leagueOutputRadioButton_CheckedChanged(object sender, EventArgs e) {
            currentOutputLogType = LogType.leagueTable;
            outputDescLabel.Text = "League Table";
        }

        private void clearButton_Click(object sender, EventArgs e) {
            outputList.Items.Clear();
            clearButton.Enabled = false;
        }


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
            }
            catch {
                streamReader.Close();
                Log("Error opening/reading file", LogType.programLog);
                return false;
            }
        }

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

        private static void Round(List<Animal> animalsToMove) {
            foreach (Animal animal in animalsToMove) {
                animal.Move();
            }
        }

        public void Log(string message, LogType logType) {
            outputList.Items.Add(message);
            outputList.SelectedIndex = outputList.Items.Count - 1; //Select the newest item in the list (Auto-Scrolling)
            clearButton.Enabled = true;
        }

        private void ButtonsAfterFileLoad() {
            loadFileButton.Enabled = false;
            resetButton.Enabled = true;
            startRaceButton.Enabled = true;
            numberRacesNumUD.Enabled = true;
            raceDistanceNumUD.Enabled = true;
            raceOutputRadioButton.Enabled = true;
            leagueOutputRadioButton.Enabled = true;
        }

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

    public class Animal {
        public string name;
        private int minMoveSpeed;
        private int maxMoveSpeed;
        private int baseRestChance;
        private int restChance;
        private int maxRestChance;
        private int increaseRestChance;
        public int distanceTravelled;

        private Form1 form1 = Application.OpenForms[0] as Form1;

        public Animal(string name, int minMoveSpeed, int maxMoveSpeed, int restChance = 0, int baseRestChance = 0, int maxRestChance = 100, int increaseRestChance = 0) {
            this.name = name;
            this.minMoveSpeed = minMoveSpeed;
            this.maxMoveSpeed = maxMoveSpeed;
            this.baseRestChance = baseRestChance;
            this.restChance = restChance;
            this.maxRestChance = maxRestChance;
            this.increaseRestChance = increaseRestChance;
        }

        public void Move() {
            Random rnd = new Random();

            distanceTravelled += rnd.Next(minMoveSpeed, maxMoveSpeed + 1);
            form1.Log($"Animal: {name}; Distance: {distanceTravelled}; Rest Chance: {restChance}", Form1.LogType.raceOutput);

        }
    }

}
