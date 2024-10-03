namespace Hare_and_Tortoise_v2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            outputList.ScrollAlwaysVisible = true;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void startRaceButton_Click(object sender, EventArgs e) {
            outputList.Items.Add("Test");
        }

        private void loadFileButton_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            LoadFile(file);
        }

        private List<Animal> LoadFile(string file) {
            string fileExt = Path.GetExtension(file);

            try {
                if (fileExt != ".txt") { throw new Exception("Incorrect file type"); } //Only allows .txt files to be loaded
                StreamReader streamReader = new StreamReader(file);
                outputList.Items.Add(file);
            }

            catch {
                outputList.Items.Add("Error opening file");
                return null; //TEMPORARY
            }

            return null; //TEMPORARY
        }

        private void CreateAnimalList() {

        }

        private void resetButton_Click(object sender, EventArgs e) {

        }

        private void raceOutputRadioButton_CheckedChanged(object sender, EventArgs e) {

        }

        private void leagueOutputRadioButton_CheckedChanged(object sender, EventArgs e) {

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
