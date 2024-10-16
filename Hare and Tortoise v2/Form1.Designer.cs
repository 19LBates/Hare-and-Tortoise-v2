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
            startRaceButton.Location = new Point(10, 119);
            startRaceButton.Margin = new Padding(3, 2, 3, 2);
            startRaceButton.Name = "startRaceButton";
            startRaceButton.Size = new Size(82, 22);
            startRaceButton.TabIndex = 4;
            startRaceButton.Text = "Start Races";
            startRaceButton.UseVisualStyleBackColor = true;
            startRaceButton.Click += startRaceButton_Click;
            // 
            // loadFileButton
            // 
            loadFileButton.Location = new Point(10, 9);
            loadFileButton.Margin = new Padding(3, 2, 3, 2);
            loadFileButton.Name = "loadFileButton";
            loadFileButton.Size = new Size(82, 22);
            loadFileButton.TabIndex = 0;
            loadFileButton.Text = "Load File";
            loadFileButton.UseVisualStyleBackColor = true;
            loadFileButton.Click += loadFileButton_Click;
            // 
            // resetButton
            // 
            resetButton.Enabled = false;
            resetButton.Location = new Point(10, 35);
            resetButton.Margin = new Padding(3, 2, 3, 2);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(82, 22);
            resetButton.TabIndex = 1;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // numberRacesNumUD
            // 
            numberRacesNumUD.Enabled = false;
            numberRacesNumUD.Location = new Point(75, 94);
            numberRacesNumUD.Margin = new Padding(3, 2, 3, 2);
            numberRacesNumUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberRacesNumUD.Name = "numberRacesNumUD";
            numberRacesNumUD.Size = new Size(48, 23);
            numberRacesNumUD.TabIndex = 2;
            numberRacesNumUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // raceDistanceNumUD
            // 
            raceDistanceNumUD.Enabled = false;
            raceDistanceNumUD.Location = new Point(200, 94);
            raceDistanceNumUD.Margin = new Padding(3, 2, 3, 2);
            raceDistanceNumUD.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            raceDistanceNumUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            raceDistanceNumUD.Name = "raceDistanceNumUD";
            raceDistanceNumUD.Size = new Size(63, 23);
            raceDistanceNumUD.TabIndex = 3;
            raceDistanceNumUD.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // staticRaceLabel1
            // 
            staticRaceLabel1.AutoSize = true;
            staticRaceLabel1.Location = new Point(13, 96);
            staticRaceLabel1.Name = "staticRaceLabel1";
            staticRaceLabel1.Size = new Size(53, 15);
            staticRaceLabel1.TabIndex = 6;
            staticRaceLabel1.Text = "Simulate";
            // 
            // staticRaceLabel2
            // 
            staticRaceLabel2.AutoSize = true;
            staticRaceLabel2.Location = new Point(133, 96);
            staticRaceLabel2.Name = "staticRaceLabel2";
            staticRaceLabel2.Size = new Size(55, 15);
            staticRaceLabel2.TabIndex = 7;
            staticRaceLabel2.Text = "race(s) at";
            // 
            // staticRaceLabel3
            // 
            staticRaceLabel3.AutoSize = true;
            staticRaceLabel3.Location = new Point(268, 96);
            staticRaceLabel3.Name = "staticRaceLabel3";
            staticRaceLabel3.Size = new Size(71, 15);
            staticRaceLabel3.TabIndex = 8;
            staticRaceLabel3.Text = "metres each";
            // 
            // outputDescLabel
            // 
            outputDescLabel.AutoSize = true;
            outputDescLabel.Location = new Point(385, 12);
            outputDescLabel.Name = "outputDescLabel";
            outputDescLabel.Size = new Size(76, 15);
            outputDescLabel.TabIndex = 10;
            outputDescLabel.Text = "Program Log";
            // 
            // raceOutputRadioButton
            // 
            raceOutputRadioButton.AutoSize = true;
            raceOutputRadioButton.Enabled = false;
            raceOutputRadioButton.Location = new Point(737, 58);
            raceOutputRadioButton.Margin = new Padding(3, 2, 3, 2);
            raceOutputRadioButton.Name = "raceOutputRadioButton";
            raceOutputRadioButton.Size = new Size(91, 19);
            raceOutputRadioButton.TabIndex = 7;
            raceOutputRadioButton.Text = "Race Output";
            raceOutputRadioButton.UseVisualStyleBackColor = true;
            raceOutputRadioButton.CheckedChanged += raceOutputRadioButton_CheckedChanged;
            // 
            // leagueOutputRadioButton
            // 
            leagueOutputRadioButton.AutoSize = true;
            leagueOutputRadioButton.Enabled = false;
            leagueOutputRadioButton.Location = new Point(737, 80);
            leagueOutputRadioButton.Margin = new Padding(3, 2, 3, 2);
            leagueOutputRadioButton.Name = "leagueOutputRadioButton";
            leagueOutputRadioButton.Size = new Size(93, 19);
            leagueOutputRadioButton.TabIndex = 6;
            leagueOutputRadioButton.Text = "League Table";
            leagueOutputRadioButton.UseVisualStyleBackColor = true;
            leagueOutputRadioButton.CheckedChanged += leagueOutputRadioButton_CheckedChanged;
            // 
            // openFileDialog1
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
            programLogRadioButton.Location = new Point(737, 35);
            programLogRadioButton.Margin = new Padding(3, 2, 3, 2);
            programLogRadioButton.Name = "programLogRadioButton";
            programLogRadioButton.Size = new Size(94, 19);
            programLogRadioButton.TabIndex = 5;
            programLogRadioButton.TabStop = true;
            programLogRadioButton.Text = "Program Log";
            programLogRadioButton.UseVisualStyleBackColor = true;
            programLogRadioButton.CheckedChanged += programLogRadioButton_CheckedChanged;
            // 
            // clearButton
            // 
            clearButton.Enabled = false;
            clearButton.Location = new Point(385, 391);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(82, 22);
            clearButton.TabIndex = 11;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // programLogLstBox
            // 
            programLogLstBox.FormattingEnabled = true;
            programLogLstBox.ItemHeight = 15;
            programLogLstBox.Location = new Point(385, 35);
            programLogLstBox.Margin = new Padding(3, 2, 3, 2);
            programLogLstBox.Name = "programLogLstBox";
            programLogLstBox.Size = new Size(332, 334);
            programLogLstBox.TabIndex = 12;
            // 
            // leagueTableLstBox
            // 
            leagueTableLstBox.FormattingEnabled = true;
            leagueTableLstBox.ItemHeight = 15;
            leagueTableLstBox.Location = new Point(385, 35);
            leagueTableLstBox.Margin = new Padding(3, 2, 3, 2);
            leagueTableLstBox.Name = "leagueTableLstBox";
            leagueTableLstBox.Size = new Size(332, 334);
            leagueTableLstBox.TabIndex = 13;
            // 
            // raceOutputLstBox
            // 
            raceOutputLstBox.FormattingEnabled = true;
            raceOutputLstBox.ItemHeight = 15;
            raceOutputLstBox.Location = new Point(385, 35);
            raceOutputLstBox.Margin = new Padding(3, 2, 3, 2);
            raceOutputLstBox.Name = "raceOutputLstBox";
            raceOutputLstBox.Size = new Size(332, 349);
            raceOutputLstBox.TabIndex = 14;
            // 
            // autoScrollChkBox
            // 
            autoScrollChkBox.AutoSize = true;
            autoScrollChkBox.Checked = true;
            autoScrollChkBox.CheckState = CheckState.Checked;
            autoScrollChkBox.Location = new Point(631, 394);
            autoScrollChkBox.Name = "autoScrollChkBox";
            autoScrollChkBox.Size = new Size(86, 19);
            autoScrollChkBox.TabIndex = 15;
            autoScrollChkBox.Text = "Auto-Scroll";
            autoScrollChkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 421);
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
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(877, 456);
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
