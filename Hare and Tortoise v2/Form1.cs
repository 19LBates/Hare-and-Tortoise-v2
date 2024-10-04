namespace Hare_and_Tortoise_v2 {
    public partial class Form1 : Form {

        private enum LogType {
            programLog,
            raceOutput,
            leagueTable
        }

        private LogType currentOutputLogType = LogType.programLog;

        public Form1() {
            InitializeComponent();
            outputList.ScrollAlwaysVisible = true;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void startRaceButton_Click(object sender, EventArgs e) {
            Log("Test", LogType.programLog);
        }

        private void loadFileButton_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            List<Animal> animalList = new List<Animal>();
            TryLoadFile(file, out animalList);
        }

        private bool TryLoadFile(string file, out List<Animal> animalListOut) {
            string fileExt = Path.GetExtension(file);
            animalListOut = new List<Animal>();

            try {
                if (fileExt != ".txt") { throw new Exception("Incorrect file type"); } //Only allows .txt files to be loaded
                StreamReader streamReader = new StreamReader(file);
                string fileContents = streamReader.ReadToEnd();
                Log($"Loading File: {file}", LogType.programLog);
                animalListOut = CreateAnimalList(fileContents);
                Log("Finished Loading File", LogType.programLog);
                loadFileButton.Enabled = false;
                enableTheButtons();
                return true;
            } catch {
                Log("Error opening file", LogType.programLog);
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

        private void resetButton_Click(object sender, EventArgs e) {
            loadFileButton.Enabled = true;
            disableTheButtons();
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
           //DELETE
        }
        private void leagueOutputRadioButton_CheckedChanged_1(object sender, EventArgs e) {
            currentOutputLogType = LogType.leagueTable;
            outputDescLabel.Text = "League Table";
        }

        private void Log(string message, LogType logType) {
            outputList.Items.Add(message);
            outputList.SelectedIndex = outputList.Items.Count - 1;
            clearButton.Enabled = true;
        }

        private void clearButton_Click(object sender, EventArgs e) {
            outputList.Items.Clear();
            clearButton.Enabled = false;
        }

        private void enableTheButtons() {
            resetButton.Enabled = true;
            startRaceButton.Enabled = true;
            numberRacesNumUD.Enabled = true;
            raceDistanceNumUD.Enabled = true;
        }

        private void disableTheButtons() {
            resetButton.Enabled = false;
            startRaceButton.Enabled = false;
            numberRacesNumUD.Enabled = false;
            raceDistanceNumUD.Enabled = false;
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

        public Animal(string name, int minMoveSpeed, int maxMoveSpeed, int restChance = 0, int baseRestChance = 0, int maxRestChance = 100, int increaseRestChance = 0) {
            this.name = name;
            this.minMoveSpeed = minMoveSpeed;
            this.maxMoveSpeed = maxMoveSpeed;
            this.baseRestChance = baseRestChance;
            this.restChance = restChance;
            this.maxRestChance = maxRestChance;
            this.increaseRestChance = increaseRestChance;
        }

        public void ViewAnimal() {
            Console.WriteLine($"Name: {name}; Min Speed: {minMoveSpeed}; Max Speed: {maxMoveSpeed}; Rest Chance: {restChance}; " +
                $"Max Rest Chance: {maxRestChance}; Rest Chance Increase: {increaseRestChance}; Rest Chance after nap: {baseRestChance}");
        }

        public void Move() {
            Random rnd = new Random();
            if (restChance > 0) {
                if (restChance >= rnd.Next(1, 101)) {
                    Console.WriteLine($"Animal: {name}; Distance: {distanceTravelled}; Resting for this round");
                    restChance = baseRestChance;
                    return;
                }
            }

            distanceTravelled += rnd.Next(minMoveSpeed, maxMoveSpeed + 1);
            Console.WriteLine($"Animal: {name}; Distance: {distanceTravelled}; Rest Chance: {restChance}");

            restChance += increaseRestChance;
            if (restChance > maxRestChance) {
                restChance = maxRestChance;
            }
        }
    }

}
