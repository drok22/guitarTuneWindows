namespace guitarBro
{
    partial class GuitarBroWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scaleLabel = new System.Windows.Forms.Label();
            this.guitarTuningLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyCombo = new System.Windows.Forms.ComboBox();
            this.guitarKeyCombo = new System.Windows.Forms.ComboBox();
            this.scaleCombo = new System.Windows.Forms.ComboBox();
            this.tuningTypeCombo = new System.Windows.Forms.ComboBox();
            this.keyDisplayLabel = new System.Windows.Forms.Label();
            this.guitarStringTuningDisplayLabel = new System.Windows.Forms.Label();
            this.guitarTuningDisplayLabel = new System.Windows.Forms.Label();
            this.scalePatternDisplayLabel = new System.Windows.Forms.Label();
            this.csvButton = new System.Windows.Forms.Button();
            this.fretBoardGrid = new System.Windows.Forms.DataGridView();
            this.fret0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fret24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorMinorCombo = new System.Windows.Forms.ComboBox();
            this.fretboardDisplayLabel = new System.Windows.Forms.Label();
            this.fretboardDisplayCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fretBoardGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(12, 51);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(34, 13);
            this.scaleLabel.TabIndex = 19;
            this.scaleLabel.Text = "Scale";
            // 
            // guitarTuningLabel
            // 
            this.guitarTuningLabel.AutoSize = true;
            this.guitarTuningLabel.Location = new System.Drawing.Point(153, 9);
            this.guitarTuningLabel.Name = "guitarTuningLabel";
            this.guitarTuningLabel.Size = new System.Drawing.Size(40, 13);
            this.guitarTuningLabel.TabIndex = 17;
            this.guitarTuningLabel.Text = "Tuning";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(12, 9);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(25, 13);
            this.keyLabel.TabIndex = 16;
            this.keyLabel.Text = "Key";
            // 
            // keyCombo
            // 
            this.keyCombo.FormattingEnabled = true;
            this.keyCombo.Items.AddRange(new object[] {
            "A",
            "A#",
            "B",
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#"});
            this.keyCombo.Location = new System.Drawing.Point(15, 25);
            this.keyCombo.Name = "keyCombo";
            this.keyCombo.Size = new System.Drawing.Size(41, 21);
            this.keyCombo.TabIndex = 20;
            this.keyCombo.SelectedIndexChanged += new System.EventHandler(this.KeyCombo_SelectedIndexChanged);
            // 
            // guitarKeyCombo
            // 
            this.guitarKeyCombo.FormattingEnabled = true;
            this.guitarKeyCombo.Items.AddRange(new object[] {
            "A",
            "A#",
            "B",
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#"});
            this.guitarKeyCombo.Location = new System.Drawing.Point(156, 25);
            this.guitarKeyCombo.Name = "guitarKeyCombo";
            this.guitarKeyCombo.Size = new System.Drawing.Size(37, 21);
            this.guitarKeyCombo.TabIndex = 21;
            this.guitarKeyCombo.SelectedIndexChanged += new System.EventHandler(this.GuitarKeyCombo_SelectedIndexChanged);
            // 
            // scaleCombo
            // 
            this.scaleCombo.FormattingEnabled = true;
            this.scaleCombo.Items.AddRange(new object[] {
            "Major",
            "Minor",
            "Pentatonic",
            "Blues"});
            this.scaleCombo.Location = new System.Drawing.Point(15, 67);
            this.scaleCombo.Name = "scaleCombo";
            this.scaleCombo.Size = new System.Drawing.Size(121, 21);
            this.scaleCombo.TabIndex = 22;
            this.scaleCombo.SelectedIndexChanged += new System.EventHandler(this.ScaleCombo_SelectedIndexChanged);
            // 
            // tuningTypeCombo
            // 
            this.tuningTypeCombo.FormattingEnabled = true;
            this.tuningTypeCombo.Items.AddRange(new object[] {
            "Standard",
            "Drop",
            "Open"});
            this.tuningTypeCombo.Location = new System.Drawing.Point(199, 25);
            this.tuningTypeCombo.Name = "tuningTypeCombo";
            this.tuningTypeCombo.Size = new System.Drawing.Size(74, 21);
            this.tuningTypeCombo.TabIndex = 23;
            this.tuningTypeCombo.SelectedIndexChanged += new System.EventHandler(this.TuningTypeCombo_SelectedIndexChanged);
            // 
            // keyDisplayLabel
            // 
            this.keyDisplayLabel.AutoSize = true;
            this.keyDisplayLabel.Location = new System.Drawing.Point(492, 9);
            this.keyDisplayLabel.Name = "keyDisplayLabel";
            this.keyDisplayLabel.Size = new System.Drawing.Size(43, 13);
            this.keyDisplayLabel.TabIndex = 24;
            this.keyDisplayLabel.Text = "E Minor";
            // 
            // guitarStringTuningDisplayLabel
            // 
            this.guitarStringTuningDisplayLabel.AutoSize = true;
            this.guitarStringTuningDisplayLabel.Location = new System.Drawing.Point(492, 76);
            this.guitarStringTuningDisplayLabel.Name = "guitarStringTuningDisplayLabel";
            this.guitarStringTuningDisplayLabel.Size = new System.Drawing.Size(66, 13);
            this.guitarStringTuningDisplayLabel.TabIndex = 26;
            this.guitarStringTuningDisplayLabel.Text = "E A D G B E";
            // 
            // guitarTuningDisplayLabel
            // 
            this.guitarTuningDisplayLabel.AutoSize = true;
            this.guitarTuningDisplayLabel.Location = new System.Drawing.Point(492, 56);
            this.guitarTuningDisplayLabel.Name = "guitarTuningDisplayLabel";
            this.guitarTuningDisplayLabel.Size = new System.Drawing.Size(88, 13);
            this.guitarTuningDisplayLabel.TabIndex = 25;
            this.guitarTuningDisplayLabel.Text = "Tune Guitar To...";
            // 
            // scalePatternDisplayLabel
            // 
            this.scalePatternDisplayLabel.AutoSize = true;
            this.scalePatternDisplayLabel.Location = new System.Drawing.Point(492, 31);
            this.scalePatternDisplayLabel.Name = "scalePatternDisplayLabel";
            this.scalePatternDisplayLabel.Size = new System.Drawing.Size(82, 13);
            this.scalePatternDisplayLabel.TabIndex = 27;
            this.scalePatternDisplayLabel.Text = "E F# G A B C D";
            // 
            // csvButton
            // 
            this.csvButton.Location = new System.Drawing.Point(618, 71);
            this.csvButton.Name = "csvButton";
            this.csvButton.Size = new System.Drawing.Size(75, 23);
            this.csvButton.TabIndex = 28;
            this.csvButton.Text = "save to CSV";
            this.csvButton.UseVisualStyleBackColor = true;
            this.csvButton.Click += new System.EventHandler(this.CsvButton_Click);
            // 
            // fretBoardGrid
            // 
            this.fretBoardGrid.AllowUserToAddRows = false;
            this.fretBoardGrid.AllowUserToDeleteRows = false;
            this.fretBoardGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fretBoardGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fretBoardGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fret0,
            this.fret1,
            this.fret2,
            this.fret3,
            this.fret4,
            this.fret5,
            this.fret6,
            this.fret7,
            this.fret8,
            this.fret9,
            this.fret10,
            this.fret11,
            this.fret12,
            this.fret13,
            this.fret14,
            this.fret15,
            this.fret16,
            this.fret17,
            this.fret18,
            this.fret19,
            this.fret20,
            this.fret21,
            this.fret22,
            this.fret23,
            this.fret24});
            this.fretBoardGrid.Location = new System.Drawing.Point(15, 100);
            this.fretBoardGrid.Name = "fretBoardGrid";
            this.fretBoardGrid.ReadOnly = true;
            this.fretBoardGrid.RowHeadersWidth = 50;
            this.fretBoardGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fretBoardGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.fretBoardGrid.Size = new System.Drawing.Size(678, 154);
            this.fretBoardGrid.TabIndex = 29;
            // 
            // fret0
            // 
            this.fret0.HeaderText = "0";
            this.fret0.Name = "fret0";
            this.fret0.ReadOnly = true;
            this.fret0.Width = 25;
            // 
            // fret1
            // 
            this.fret1.HeaderText = "1";
            this.fret1.Name = "fret1";
            this.fret1.ReadOnly = true;
            this.fret1.Width = 25;
            // 
            // fret2
            // 
            this.fret2.HeaderText = "2";
            this.fret2.Name = "fret2";
            this.fret2.ReadOnly = true;
            this.fret2.Width = 25;
            // 
            // fret3
            // 
            this.fret3.HeaderText = "3";
            this.fret3.Name = "fret3";
            this.fret3.ReadOnly = true;
            this.fret3.Width = 25;
            // 
            // fret4
            // 
            this.fret4.HeaderText = "4";
            this.fret4.Name = "fret4";
            this.fret4.ReadOnly = true;
            this.fret4.Width = 25;
            // 
            // fret5
            // 
            this.fret5.HeaderText = "5";
            this.fret5.Name = "fret5";
            this.fret5.ReadOnly = true;
            this.fret5.Width = 25;
            // 
            // fret6
            // 
            this.fret6.HeaderText = "6";
            this.fret6.Name = "fret6";
            this.fret6.ReadOnly = true;
            this.fret6.Width = 25;
            // 
            // fret7
            // 
            this.fret7.HeaderText = "7";
            this.fret7.Name = "fret7";
            this.fret7.ReadOnly = true;
            this.fret7.Width = 25;
            // 
            // fret8
            // 
            this.fret8.HeaderText = "8";
            this.fret8.Name = "fret8";
            this.fret8.ReadOnly = true;
            this.fret8.Width = 25;
            // 
            // fret9
            // 
            this.fret9.HeaderText = "9";
            this.fret9.Name = "fret9";
            this.fret9.ReadOnly = true;
            this.fret9.Width = 25;
            // 
            // fret10
            // 
            this.fret10.HeaderText = "10";
            this.fret10.Name = "fret10";
            this.fret10.ReadOnly = true;
            this.fret10.Width = 25;
            // 
            // fret11
            // 
            this.fret11.HeaderText = "11";
            this.fret11.Name = "fret11";
            this.fret11.ReadOnly = true;
            this.fret11.Width = 25;
            // 
            // fret12
            // 
            this.fret12.HeaderText = "12";
            this.fret12.Name = "fret12";
            this.fret12.ReadOnly = true;
            this.fret12.Width = 25;
            // 
            // fret13
            // 
            this.fret13.HeaderText = "13";
            this.fret13.Name = "fret13";
            this.fret13.ReadOnly = true;
            this.fret13.Width = 25;
            // 
            // fret14
            // 
            this.fret14.HeaderText = "14";
            this.fret14.Name = "fret14";
            this.fret14.ReadOnly = true;
            this.fret14.Width = 25;
            // 
            // fret15
            // 
            this.fret15.HeaderText = "15";
            this.fret15.Name = "fret15";
            this.fret15.ReadOnly = true;
            this.fret15.Width = 25;
            // 
            // fret16
            // 
            this.fret16.HeaderText = "16";
            this.fret16.Name = "fret16";
            this.fret16.ReadOnly = true;
            this.fret16.Width = 25;
            // 
            // fret17
            // 
            this.fret17.HeaderText = "17";
            this.fret17.Name = "fret17";
            this.fret17.ReadOnly = true;
            this.fret17.Width = 25;
            // 
            // fret18
            // 
            this.fret18.HeaderText = "18";
            this.fret18.Name = "fret18";
            this.fret18.ReadOnly = true;
            this.fret18.Width = 25;
            // 
            // fret19
            // 
            this.fret19.HeaderText = "19";
            this.fret19.Name = "fret19";
            this.fret19.ReadOnly = true;
            this.fret19.Width = 25;
            // 
            // fret20
            // 
            this.fret20.HeaderText = "20";
            this.fret20.Name = "fret20";
            this.fret20.ReadOnly = true;
            this.fret20.Width = 25;
            // 
            // fret21
            // 
            this.fret21.HeaderText = "21";
            this.fret21.Name = "fret21";
            this.fret21.ReadOnly = true;
            this.fret21.Width = 25;
            // 
            // fret22
            // 
            this.fret22.HeaderText = "22";
            this.fret22.Name = "fret22";
            this.fret22.ReadOnly = true;
            this.fret22.Width = 25;
            // 
            // fret23
            // 
            this.fret23.HeaderText = "23";
            this.fret23.Name = "fret23";
            this.fret23.ReadOnly = true;
            this.fret23.Width = 25;
            // 
            // fret24
            // 
            this.fret24.HeaderText = "24";
            this.fret24.Name = "fret24";
            this.fret24.ReadOnly = true;
            this.fret24.Width = 25;
            // 
            // majorMinorCombo
            // 
            this.majorMinorCombo.FormattingEnabled = true;
            this.majorMinorCombo.Items.AddRange(new object[] {
            "Major",
            "Minor"});
            this.majorMinorCombo.Location = new System.Drawing.Point(62, 25);
            this.majorMinorCombo.Name = "majorMinorCombo";
            this.majorMinorCombo.Size = new System.Drawing.Size(74, 21);
            this.majorMinorCombo.TabIndex = 30;
            this.majorMinorCombo.SelectedIndexChanged += new System.EventHandler(this.MajorMinorCombo_SelectedIndexChanged);
            // 
            // fretboardDisplayLabel
            // 
            this.fretboardDisplayLabel.AutoSize = true;
            this.fretboardDisplayLabel.Location = new System.Drawing.Point(153, 51);
            this.fretboardDisplayLabel.Name = "fretboardDisplayLabel";
            this.fretboardDisplayLabel.Size = new System.Drawing.Size(40, 13);
            this.fretboardDisplayLabel.TabIndex = 31;
            this.fretboardDisplayLabel.Text = "Tuning";
            // 
            // fretboardDisplayCombo
            // 
            this.fretboardDisplayCombo.FormattingEnabled = true;
            this.fretboardDisplayCombo.Items.AddRange(new object[] {
            "Notes",
            "Frets",
            "Dots"});
            this.fretboardDisplayCombo.Location = new System.Drawing.Point(156, 67);
            this.fretboardDisplayCombo.Name = "fretboardDisplayCombo";
            this.fretboardDisplayCombo.Size = new System.Drawing.Size(121, 21);
            this.fretboardDisplayCombo.TabIndex = 32;
            this.fretboardDisplayCombo.SelectedIndexChanged += new System.EventHandler(this.FretboardDisplayCombo_SelectedIndexChanged);
            // 
            // GuitarBroWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 316);
            this.Controls.Add(this.fretboardDisplayCombo);
            this.Controls.Add(this.fretboardDisplayLabel);
            this.Controls.Add(this.majorMinorCombo);
            this.Controls.Add(this.fretBoardGrid);
            this.Controls.Add(this.csvButton);
            this.Controls.Add(this.scalePatternDisplayLabel);
            this.Controls.Add(this.guitarStringTuningDisplayLabel);
            this.Controls.Add(this.guitarTuningDisplayLabel);
            this.Controls.Add(this.keyDisplayLabel);
            this.Controls.Add(this.tuningTypeCombo);
            this.Controls.Add(this.scaleCombo);
            this.Controls.Add(this.guitarKeyCombo);
            this.Controls.Add(this.keyCombo);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.guitarTuningLabel);
            this.Controls.Add(this.keyLabel);
            this.Name = "GuitarBroWindows";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoadGuitarBro);
            ((System.ComponentModel.ISupportInitialize)(this.fretBoardGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.Label guitarTuningLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.ComboBox keyCombo;
        private System.Windows.Forms.ComboBox guitarKeyCombo;
        private System.Windows.Forms.ComboBox scaleCombo;
        private System.Windows.Forms.ComboBox tuningTypeCombo;
        private System.Windows.Forms.Label keyDisplayLabel;
        private System.Windows.Forms.Label guitarStringTuningDisplayLabel;
        private System.Windows.Forms.Label guitarTuningDisplayLabel;
        private System.Windows.Forms.Label scalePatternDisplayLabel;
        private System.Windows.Forms.Button csvButton;
        private System.Windows.Forms.DataGridView fretBoardGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret0;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret5;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret6;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret7;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret8;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret9;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret10;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret11;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret12;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret13;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret14;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret15;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret16;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret17;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret18;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret19;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret20;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret21;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret22;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret23;
        private System.Windows.Forms.DataGridViewTextBoxColumn fret24;
        private System.Windows.Forms.ComboBox majorMinorCombo;
        private System.Windows.Forms.Label fretboardDisplayLabel;
        private System.Windows.Forms.ComboBox fretboardDisplayCombo;
    }
}