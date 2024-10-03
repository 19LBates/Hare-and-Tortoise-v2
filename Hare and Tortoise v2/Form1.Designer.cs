namespace Hare_and_Tortoise_v2 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            startRaceButton = new Button();
            loadFIleButton = new Button();
            resetButton = new Button();
            numberRacesNumUD = new NumericUpDown();
            raceDistanceNumUD = new NumericUpDown();
            staticRaceLabel1 = new Label();
            staticRaceLabel2 = new Label();
            staticRaceLabel3 = new Label();
            outputList = new ListBox();
            outputDescLabel = new Label();
            raceOutputRadioButton = new RadioButton();
            leagueOutputRadioButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numberRacesNumUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)raceDistanceNumUD).BeginInit();
            SuspendLayout();
            // 
            // startRaceButton
            // 
            startRaceButton.Location = new Point(12, 159);
            startRaceButton.Name = "startRaceButton";
            startRaceButton.Size = new Size(94, 29);
            startRaceButton.TabIndex = 0;
            startRaceButton.Text = "Start Races";
            startRaceButton.UseVisualStyleBackColor = true;
            startRaceButton.Click += startRaceButton_Click;
            // 
            // loadFIleButton
            // 
            loadFIleButton.Location = new Point(12, 12);
            loadFIleButton.Name = "loadFIleButton";
            loadFIleButton.Size = new Size(94, 29);
            loadFIleButton.TabIndex = 2;
            loadFIleButton.Text = "Load File";
            loadFIleButton.UseVisualStyleBackColor = true;
            loadFIleButton.Click += loadFileButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(12, 47);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 3;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // numberRacesNumUD
            // 
            numberRacesNumUD.Location = new Point(86, 126);
            numberRacesNumUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberRacesNumUD.Name = "numberRacesNumUD";
            numberRacesNumUD.Size = new Size(55, 27);
            numberRacesNumUD.TabIndex = 4;
            numberRacesNumUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // raceDistanceNumUD
            // 
            raceDistanceNumUD.Location = new Point(228, 126);
            raceDistanceNumUD.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            raceDistanceNumUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            raceDistanceNumUD.Name = "raceDistanceNumUD";
            raceDistanceNumUD.Size = new Size(72, 27);
            raceDistanceNumUD.TabIndex = 5;
            raceDistanceNumUD.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // staticRaceLabel1
            // 
            staticRaceLabel1.AutoSize = true;
            staticRaceLabel1.Location = new Point(12, 128);
            staticRaceLabel1.Name = "staticRaceLabel1";
            staticRaceLabel1.Size = new Size(67, 20);
            staticRaceLabel1.TabIndex = 6;
            staticRaceLabel1.Text = "Simulate";
            // 
            // staticRaceLabel2
            // 
            staticRaceLabel2.AutoSize = true;
            staticRaceLabel2.Location = new Point(148, 128);
            staticRaceLabel2.Name = "staticRaceLabel2";
            staticRaceLabel2.Size = new Size(70, 20);
            staticRaceLabel2.TabIndex = 7;
            staticRaceLabel2.Text = "race(s) at";
            // 
            // staticRaceLabel3
            // 
            staticRaceLabel3.AutoSize = true;
            staticRaceLabel3.Location = new Point(306, 128);
            staticRaceLabel3.Name = "staticRaceLabel3";
            staticRaceLabel3.Size = new Size(89, 20);
            staticRaceLabel3.TabIndex = 8;
            staticRaceLabel3.Text = "metres each";
            // 
            // outputList
            // 
            outputList.FormattingEnabled = true;
            outputList.Location = new Point(440, 47);
            outputList.Name = "outputList";
            outputList.Size = new Size(382, 464);
            outputList.TabIndex = 9;
            // 
            // outputDescLabel
            // 
            outputDescLabel.AutoSize = true;
            outputDescLabel.Location = new Point(440, 16);
            outputDescLabel.Name = "outputDescLabel";
            outputDescLabel.Size = new Size(94, 20);
            outputDescLabel.TabIndex = 10;
            outputDescLabel.Text = "Race Output:";
            // 
            // raceOutputRadioButton
            // 
            raceOutputRadioButton.AutoSize = true;
            raceOutputRadioButton.Location = new Point(841, 49);
            raceOutputRadioButton.Name = "raceOutputRadioButton";
            raceOutputRadioButton.Size = new Size(112, 24);
            raceOutputRadioButton.TabIndex = 11;
            raceOutputRadioButton.TabStop = true;
            raceOutputRadioButton.Text = "Race Output";
            raceOutputRadioButton.UseVisualStyleBackColor = true;
            raceOutputRadioButton.CheckedChanged += raceOutputRadioButton_CheckedChanged;
            // 
            // leagueOutputRadioButton
            // 
            leagueOutputRadioButton.AutoSize = true;
            leagueOutputRadioButton.Location = new Point(841, 79);
            leagueOutputRadioButton.Name = "leagueOutputRadioButton";
            leagueOutputRadioButton.Size = new Size(117, 24);
            leagueOutputRadioButton.TabIndex = 12;
            leagueOutputRadioButton.TabStop = true;
            leagueOutputRadioButton.Text = "League Table";
            leagueOutputRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(leagueOutputRadioButton);
            Controls.Add(raceOutputRadioButton);
            Controls.Add(outputDescLabel);
            Controls.Add(outputList);
            Controls.Add(staticRaceLabel3);
            Controls.Add(staticRaceLabel2);
            Controls.Add(staticRaceLabel1);
            Controls.Add(raceDistanceNumUD);
            Controls.Add(numberRacesNumUD);
            Controls.Add(resetButton);
            Controls.Add(loadFIleButton);
            Controls.Add(startRaceButton);
            MinimumSize = new Size(1000, 600);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numberRacesNumUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)raceDistanceNumUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startRaceButton;
        private Button loadFIleButton;
        private Button resetButton;
        private NumericUpDown numberRacesNumUD;
        private NumericUpDown raceDistanceNumUD;
        private Label staticRaceLabel1;
        private Label staticRaceLabel2;
        private Label staticRaceLabel3;
        private ListBox outputList;
        private Label outputDescLabel;
        private RadioButton raceOutputRadioButton;
        private RadioButton leagueOutputRadioButton;
    }
}
