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

        }

        private void resetButton_Click(object sender, EventArgs e) {

        }

        private void raceOutputRadioButton_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
