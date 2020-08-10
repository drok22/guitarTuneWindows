namespace guitarBro
{
    partial class GuitarBro
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
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.keyLabel = new System.Windows.Forms.Label();
            this.tuningLabel = new System.Windows.Forms.Label();
            this.keyDropDown = new DevExpress.XtraEditors.DropDownButton();
            this.guitarKeyDropDown = new DevExpress.XtraEditors.DropDownButton();
            this.tuningTypeDropDown = new DevExpress.XtraEditors.DropDownButton();
            this.tuningTypeLabel = new System.Windows.Forms.Label();
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
            this.scaleDropDown = new DevExpress.XtraEditors.DropDownButton();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.minorMajorToggleSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.keyDisplayLabel = new System.Windows.Forms.Label();
            this.guitarTuningDisplayLabel = new System.Windows.Forms.Label();
            this.scalePatternDisplayLabel = new System.Windows.Forms.Label();
            this.guitarStringTuningDisplayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fretBoardGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorMajorToggleSwitch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(12, 9);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(25, 13);
            this.keyLabel.TabIndex = 2;
            this.keyLabel.Text = "Key";
            // 
            // tuningLabel
            // 
            this.tuningLabel.AutoSize = true;
            this.tuningLabel.Location = new System.Drawing.Point(153, 9);
            this.tuningLabel.Name = "tuningLabel";
            this.tuningLabel.Size = new System.Drawing.Size(39, 13);
            this.tuningLabel.TabIndex = 3;
            this.tuningLabel.Text = "Tuning";
            // 
            // keyDropDown
            // 
            this.keyDropDown.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.keyDropDown.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.keyDropDown.Location = new System.Drawing.Point(12, 25);
            this.keyDropDown.Name = "keyDropDown";
            this.keyDropDown.Size = new System.Drawing.Size(135, 23);
            this.keyDropDown.TabIndex = 4;
            this.keyDropDown.Text = "Select A Key";
            // 
            // guitarKeyDropDown
            // 
            this.guitarKeyDropDown.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.guitarKeyDropDown.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.guitarKeyDropDown.Location = new System.Drawing.Point(156, 25);
            this.guitarKeyDropDown.Name = "guitarKeyDropDown";
            this.guitarKeyDropDown.Size = new System.Drawing.Size(135, 23);
            this.guitarKeyDropDown.TabIndex = 10;
            this.guitarKeyDropDown.Text = "Tune Guitar To...";
            // 
            // tuningTypeDropDown
            // 
            this.tuningTypeDropDown.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tuningTypeDropDown.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.tuningTypeDropDown.Location = new System.Drawing.Point(156, 67);
            this.tuningTypeDropDown.Name = "tuningTypeDropDown";
            this.tuningTypeDropDown.Size = new System.Drawing.Size(135, 23);
            this.tuningTypeDropDown.TabIndex = 11;
            this.tuningTypeDropDown.Text = "Select A Tuning Type";
            // 
            // tuningTypeLabel
            // 
            this.tuningTypeLabel.AutoSize = true;
            this.tuningTypeLabel.Location = new System.Drawing.Point(153, 51);
            this.tuningTypeLabel.Name = "tuningTypeLabel";
            this.tuningTypeLabel.Size = new System.Drawing.Size(66, 13);
            this.tuningTypeLabel.TabIndex = 12;
            this.tuningTypeLabel.Text = "Tuning Type";
            // 
            // fretBoardGrid
            // 
            this.fretBoardGrid.AllowUserToAddRows = false;
            this.fretBoardGrid.AllowUserToDeleteRows = false;
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
            this.fretBoardGrid.Location = new System.Drawing.Point(0, 138);
            this.fretBoardGrid.Name = "fretBoardGrid";
            this.fretBoardGrid.ReadOnly = true;
            this.fretBoardGrid.RowHeadersWidth = 50;
            this.fretBoardGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fretBoardGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.fretBoardGrid.Size = new System.Drawing.Size(678, 154);
            this.fretBoardGrid.TabIndex = 13;
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
            // scaleDropDown
            // 
            this.scaleDropDown.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.scaleDropDown.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.scaleDropDown.Location = new System.Drawing.Point(15, 67);
            this.scaleDropDown.Name = "scaleDropDown";
            this.scaleDropDown.Size = new System.Drawing.Size(135, 23);
            this.scaleDropDown.TabIndex = 14;
            this.scaleDropDown.Text = "Select A Scale...";
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(12, 51);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(32, 13);
            this.scaleLabel.TabIndex = 15;
            this.scaleLabel.Text = "Scale";
            // 
            // minorMajorToggleSwitch
            // 
            this.minorMajorToggleSwitch.Location = new System.Drawing.Point(15, 99);
            this.minorMajorToggleSwitch.Name = "minorMajorToggleSwitch";
            this.minorMajorToggleSwitch.Properties.OffText = "Minor";
            this.minorMajorToggleSwitch.Properties.OnText = "Major";
            this.minorMajorToggleSwitch.Size = new System.Drawing.Size(101, 24);
            this.minorMajorToggleSwitch.TabIndex = 16;
            this.minorMajorToggleSwitch.Toggled += new System.EventHandler(this.MinorMajorToggleSwitch_Toggled);
            // 
            // keyDisplayLabel
            // 
            this.keyDisplayLabel.AutoSize = true;
            this.keyDisplayLabel.Location = new System.Drawing.Point(392, 25);
            this.keyDisplayLabel.Name = "keyDisplayLabel";
            this.keyDisplayLabel.Size = new System.Drawing.Size(42, 13);
            this.keyDisplayLabel.TabIndex = 17;
            this.keyDisplayLabel.Text = "E Minor";
            // 
            // guitarTuningDisplayLabel
            // 
            this.guitarTuningDisplayLabel.AutoSize = true;
            this.guitarTuningDisplayLabel.Location = new System.Drawing.Point(392, 72);
            this.guitarTuningDisplayLabel.Name = "guitarTuningDisplayLabel";
            this.guitarTuningDisplayLabel.Size = new System.Drawing.Size(90, 13);
            this.guitarTuningDisplayLabel.TabIndex = 19;
            this.guitarTuningDisplayLabel.Text = "Tune Guitar To...";
            // 
            // scalePatternDisplayLabel
            // 
            this.scalePatternDisplayLabel.AutoSize = true;
            this.scalePatternDisplayLabel.Location = new System.Drawing.Point(392, 47);
            this.scalePatternDisplayLabel.Name = "scalePatternDisplayLabel";
            this.scalePatternDisplayLabel.Size = new System.Drawing.Size(79, 13);
            this.scalePatternDisplayLabel.TabIndex = 20;
            this.scalePatternDisplayLabel.Text = "E F# G A B C D";
            // 
            // guitarStringTuningDisplayLabel
            // 
            this.guitarStringTuningDisplayLabel.AutoSize = true;
            this.guitarStringTuningDisplayLabel.Location = new System.Drawing.Point(392, 92);
            this.guitarStringTuningDisplayLabel.Name = "guitarStringTuningDisplayLabel";
            this.guitarStringTuningDisplayLabel.Size = new System.Drawing.Size(61, 13);
            this.guitarStringTuningDisplayLabel.TabIndex = 21;
            this.guitarStringTuningDisplayLabel.Text = "E A D G B E";
            // 
            // GuitarBro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 293);
            this.Controls.Add(this.guitarStringTuningDisplayLabel);
            this.Controls.Add(this.scalePatternDisplayLabel);
            this.Controls.Add(this.guitarTuningDisplayLabel);
            this.Controls.Add(this.keyDisplayLabel);
            this.Controls.Add(this.minorMajorToggleSwitch);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.scaleDropDown);
            this.Controls.Add(this.fretBoardGrid);
            this.Controls.Add(this.tuningTypeLabel);
            this.Controls.Add(this.tuningTypeDropDown);
            this.Controls.Add(this.guitarKeyDropDown);
            this.Controls.Add(this.keyDropDown);
            this.Controls.Add(this.tuningLabel);
            this.Controls.Add(this.keyLabel);
            this.Name = "GuitarBro";
            this.Text = "GuitarBro";
            this.Load += new System.EventHandler(this.LoadGuitarBro);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fretBoardGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorMajorToggleSwitch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label tuningLabel;
        private DevExpress.XtraEditors.DropDownButton keyDropDown;
        private DevExpress.XtraEditors.DropDownButton guitarKeyDropDown;
        private DevExpress.XtraEditors.DropDownButton tuningTypeDropDown;
        private System.Windows.Forms.Label tuningTypeLabel;
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
        private DevExpress.XtraEditors.DropDownButton scaleDropDown;
        private System.Windows.Forms.Label scaleLabel;
        private DevExpress.XtraEditors.ToggleSwitch minorMajorToggleSwitch;
        private System.Windows.Forms.Label keyDisplayLabel;
        private System.Windows.Forms.Label guitarTuningDisplayLabel;
        private System.Windows.Forms.Label scalePatternDisplayLabel;
        private System.Windows.Forms.Label guitarStringTuningDisplayLabel;
    }


}

