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
            loadFileButton = new Button();
            resetButton = new Button();
            numberRacesNumUD = new NumericUpDown();
            raceDistanceNumUD = new NumericUpDown();
            staticRaceLabel1 = new Label();
            staticRaceLabel2 = new Label();
            staticRaceLabel3 = new Label();
            outputDescLabel = new Label();
            raceOutputRadioButton = new RadioButton();
            leagueOutputRadioButton = new RadioButton();
            openFileDialog = new OpenFileDialog();
            programLogRadioButton = new RadioButton();
            clearButton = new Button();
            programLogLstBox = new ListBox();
            leagueTableLstBox = new ListBox();
            raceOutputLstBox = new ListBox();
            autoScrollChkBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numberRacesNumUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)raceDistanceNumUD).BeginInit();
            SuspendLayout();
            // 
            // startRaceButton
            // 
            startRaceButton.Enabled = false;
            startRaceButton.Location = new Point(11, 159);
            startRaceButton.Name = "startRaceButton";
            startRaceButton.Size = new Size(94, 29);
            startRaceButton.TabIndex = 4;
            startRaceButton.Text = "Start Races";
            startRaceButton.UseVisualStyleBackColor = true;
            startRaceButton.Click += startRaceButton_Click;
            // 
            // loadFileButton
            // 
            loadFileButton.Location = new Point(11, 12);
            loadFileButton.Name = "loadFileButton";
            loadFileButton.Size = new Size(94, 29);
            loadFileButton.TabIndex = 0;
            loadFileButton.Text = "Load File";
            loadFileButton.UseVisualStyleBackColor = true;
            loadFileButton.Click += loadFileButton_Click;
            // 
            // resetButton
            // 
            resetButton.Enabled = false;
            resetButton.Location = new Point(11, 47);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 1;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // numberRacesNumUD
            // 
            numberRacesNumUD.Enabled = false;
            numberRacesNumUD.Location = new Point(86, 125);
            numberRacesNumUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberRacesNumUD.Name = "numberRacesNumUD";
            numberRacesNumUD.Size = new Size(55, 27);
            numberRacesNumUD.TabIndex = 2;
            numberRacesNumUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // raceDistanceNumUD
            // 
            raceDistanceNumUD.Enabled = false;
            raceDistanceNumUD.Location = new Point(229, 125);
            raceDistanceNumUD.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            raceDistanceNumUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            raceDistanceNumUD.Name = "raceDistanceNumUD";
            raceDistanceNumUD.Size = new Size(72, 27);
            raceDistanceNumUD.TabIndex = 3;
            raceDistanceNumUD.ThousandsSeparator = true;
            raceDistanceNumUD.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // staticRaceLabel1
            // 
            staticRaceLabel1.AutoSize = true;
            staticRaceLabel1.Location = new Point(15, 128);
            staticRaceLabel1.Name = "staticRaceLabel1";
            staticRaceLabel1.Size = new Size(67, 20);
            staticRaceLabel1.TabIndex = 6;
            staticRaceLabel1.Text = "Simulate";
            // 
            // staticRaceLabel2
            // 
            staticRaceLabel2.AutoSize = true;
            staticRaceLabel2.Location = new Point(152, 128);
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
            // outputDescLabel
            // 
            outputDescLabel.AutoSize = true;
            outputDescLabel.Location = new Point(440, 16);
            outputDescLabel.Name = "outputDescLabel";
            outputDescLabel.Size = new Size(95, 20);
            outputDescLabel.TabIndex = 10;
            outputDescLabel.Text = "Program Log";
            // 
            // raceOutputRadioButton
            // 
            raceOutputRadioButton.AutoSize = true;
            raceOutputRadioButton.Enabled = false;
            raceOutputRadioButton.Location = new Point(842, 77);
            raceOutputRadioButton.Name = "raceOutputRadioButton";
            raceOutputRadioButton.Size = new Size(112, 24);
            raceOutputRadioButton.TabIndex = 7;
            raceOutputRadioButton.Text = "Race Output";
            raceOutputRadioButton.UseVisualStyleBackColor = true;
            raceOutputRadioButton.CheckedChanged += raceOutputRadioButton_CheckedChanged;
            // 
            // leagueOutputRadioButton
            // 
            leagueOutputRadioButton.AutoSize = true;
            leagueOutputRadioButton.Enabled = false;
            leagueOutputRadioButton.Location = new Point(842, 107);
            leagueOutputRadioButton.Name = "leagueOutputRadioButton";
            leagueOutputRadioButton.Size = new Size(117, 24);
            leagueOutputRadioButton.TabIndex = 6;
            leagueOutputRadioButton.Text = "League Table";
            leagueOutputRadioButton.UseVisualStyleBackColor = true;
            leagueOutputRadioButton.CheckedChanged += leagueOutputRadioButton_CheckedChanged;
            // 
            // openFileDialog
            // 
            openFileDialog.DefaultExt = "\".txt\"";
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.Title = "Choose File";
            // 
            // programLogRadioButton
            // 
            programLogRadioButton.AutoSize = true;
            programLogRadioButton.Checked = true;
            programLogRadioButton.Location = new Point(842, 47);
            programLogRadioButton.Name = "programLogRadioButton";
            programLogRadioButton.Size = new Size(116, 24);
            programLogRadioButton.TabIndex = 5;
            programLogRadioButton.TabStop = true;
            programLogRadioButton.Text = "Program Log";
            programLogRadioButton.UseVisualStyleBackColor = true;
            programLogRadioButton.CheckedChanged += programLogRadioButton_CheckedChanged;
            // 
            // clearButton
            // 
            clearButton.Enabled = false;
            clearButton.Location = new Point(440, 521);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 11;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // programLogLstBox
            // 
            programLogLstBox.FormattingEnabled = true;
            programLogLstBox.Location = new Point(440, 47);
            programLogLstBox.Name = "programLogLstBox";
            programLogLstBox.Size = new Size(379, 464);
            programLogLstBox.TabIndex = 12;
            // 
            // leagueTableLstBox
            // 
            leagueTableLstBox.FormattingEnabled = true;
            leagueTableLstBox.Location = new Point(440, 47);
            leagueTableLstBox.Name = "leagueTableLstBox";
            leagueTableLstBox.Size = new Size(379, 464);
            leagueTableLstBox.TabIndex = 13;
            // 
            // raceOutputLstBox
            // 
            raceOutputLstBox.FormattingEnabled = true;
            raceOutputLstBox.Location = new Point(440, 47);
            raceOutputLstBox.Name = "raceOutputLstBox";
            raceOutputLstBox.Size = new Size(379, 464);
            raceOutputLstBox.TabIndex = 14;
            // 
            // autoScrollChkBox
            // 
            autoScrollChkBox.AutoSize = true;
            autoScrollChkBox.Checked = true;
            autoScrollChkBox.CheckState = CheckState.Checked;
            autoScrollChkBox.Location = new Point(721, 525);
            autoScrollChkBox.Margin = new Padding(3, 4, 3, 4);
            autoScrollChkBox.Name = "autoScrollChkBox";
            autoScrollChkBox.Size = new Size(106, 24);
            autoScrollChkBox.TabIndex = 15;
            autoScrollChkBox.Text = "Auto-Scroll";
            autoScrollChkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(autoScrollChkBox);
            Controls.Add(raceOutputLstBox);
            Controls.Add(leagueTableLstBox);
            Controls.Add(programLogLstBox);
            Controls.Add(clearButton);
            Controls.Add(programLogRadioButton);
            Controls.Add(leagueOutputRadioButton);
            Controls.Add(raceOutputRadioButton);
            Controls.Add(outputDescLabel);
            Controls.Add(staticRaceLabel3);
            Controls.Add(staticRaceLabel2);
            Controls.Add(staticRaceLabel1);
            Controls.Add(raceDistanceNumUD);
            Controls.Add(numberRacesNumUD);
            Controls.Add(resetButton);
            Controls.Add(loadFileButton);
            Controls.Add(startRaceButton);
            MinimumSize = new Size(1000, 592);
            Name = "Form1";
            Text = "Hare and Tortoise v2";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numberRacesNumUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)raceDistanceNumUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startRaceButton;
        private Button loadFileButton;
        private Button resetButton;
        private NumericUpDown numberRacesNumUD;
        private NumericUpDown raceDistanceNumUD;
        private Label staticRaceLabel1;
        private Label staticRaceLabel2;
        private Label staticRaceLabel3;
        private Label outputDescLabel;
        private RadioButton raceOutputRadioButton;
        private RadioButton leagueOutputRadioButton;
        private OpenFileDialog openFileDialog;
        private RadioButton programLogRadioButton;
        private Button clearButton;
        private ListBox programLogLstBox;
        private ListBox leagueTableLstBox;
        private ListBox raceOutputLstBox;
        private CheckBox autoScrollChkBox;
    }
}
