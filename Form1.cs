using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace guitarBro
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private BarManager keyBarManager;
        private BarManager guitarKeyBarManager;
        private BarManager tuningTypeBarManager;
        private PopupMenu keyPopupMenu;
        private PopupMenu guitarKeyPopupMenu;
        private PopupMenu tuningTypePopupMenu;
        private BarButtonItem keyOfAButton;
        private BarButtonItem keyOfBButton;
        private BarButtonItem keyOfCButton;
        private BarButtonItem keyOfDButton;
        private BarButtonItem keyOfEButton;
        private BarButtonItem keyOfFButton;
        private BarButtonItem keyOfGButton;
        private BarButtonItem guitarKeyAButton;
        private BarButtonItem guitarKeyBButton;
        private BarButtonItem guitarKeyCButton;
        private BarButtonItem guitarKeyDButton;
        private BarButtonItem guitarKeyEButton;
        private BarButtonItem guitarKeyFButton;
        private BarButtonItem guitarKeyGButton;
        private BarButtonItem standardTuningTypeButton;
        private BarButtonItem dropTuningTypeButton;
        private BarButtonItem openTuningTypeButton;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupFretBoardGrid();
            minorKeyRadioButton.Checked = true;
            SetupBarManagers();
            //UpdateMeBro(); // maybe don't need this line since its being updated when buttons change.
        }

        private void SetupBarManagers()
        {
            SetupKeyBarManager();
            SetupGuitarKeyBarManager();
            SetupTuningTypeBarManager();
        }

        private void SetupKeyBarManager()
        {
            keyBarManager = new BarManager { Form = this };
            keyPopupMenu = new PopupMenu();
            keyOfAButton = new BarButtonItem(keyBarManager, "A") { Tag = "A" };
            keyOfAButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.KeySelected);
            keyPopupMenu.AddItem(keyOfAButton);
            keyOfBButton = new BarButtonItem(keyBarManager, "B") { Tag = "B" };
            keyOfBButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.KeySelected);
            keyPopupMenu.AddItem(keyOfBButton);
            keyOfCButton = new BarButtonItem(keyBarManager, "C") { Tag = "C" };
            keyOfCButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.KeySelected);
            keyPopupMenu.AddItem(keyOfCButton);
            keyOfDButton = new BarButtonItem(keyBarManager, "D") { Tag = "D" };
            keyOfDButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.KeySelected);
            keyPopupMenu.AddItem(keyOfDButton);
            keyOfEButton = new BarButtonItem(keyBarManager, "E") { Tag = "E" };
            keyOfEButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.KeySelected);
            keyPopupMenu.AddItem(keyOfEButton);
            keyOfFButton = new BarButtonItem(keyBarManager, "F") { Tag = "F" };
            keyOfFButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.KeySelected);
            keyPopupMenu.AddItem(keyOfFButton);
            keyOfGButton = new BarButtonItem(keyBarManager, "G") { Tag = "G" };
            keyOfGButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.KeySelected);
            keyPopupMenu.AddItem(keyOfGButton);

            keyDropDown.Parent = this;
            keyDropDown.DropDownControl = keyPopupMenu;

            ItemClickEventArgs keySetupArgs = new ItemClickEventArgs(keyOfEButton, null);
            KeySelected(keyBarManager, keySetupArgs);
        }

        private void SetupGuitarKeyBarManager()
        {
            guitarKeyBarManager = new BarManager { Form = this };
            guitarKeyPopupMenu = new PopupMenu();
            guitarKeyAButton = new BarButtonItem(keyBarManager, "A") { Tag = "A" };
            guitarKeyAButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GuitarKeySelected);
            guitarKeyPopupMenu.AddItem(guitarKeyAButton);
            guitarKeyBButton = new BarButtonItem(keyBarManager, "B") { Tag = "B" };
            guitarKeyBButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GuitarKeySelected);
            guitarKeyPopupMenu.AddItem(guitarKeyBButton);
            guitarKeyCButton = new BarButtonItem(keyBarManager, "C") { Tag = "C" };
            guitarKeyCButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GuitarKeySelected);
            guitarKeyPopupMenu.AddItem(guitarKeyCButton);
            guitarKeyDButton = new BarButtonItem(keyBarManager, "D") { Tag = "D" };
            guitarKeyDButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GuitarKeySelected);
            guitarKeyPopupMenu.AddItem(guitarKeyDButton);
            guitarKeyEButton = new BarButtonItem(keyBarManager, "E") { Tag = "E" };
            guitarKeyEButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GuitarKeySelected);
            guitarKeyPopupMenu.AddItem(guitarKeyEButton);
            guitarKeyFButton = new BarButtonItem(keyBarManager, "F") { Tag = "F" };
            guitarKeyFButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GuitarKeySelected);
            guitarKeyPopupMenu.AddItem(guitarKeyFButton);
            guitarKeyGButton = new BarButtonItem(keyBarManager, "G") { Tag = "G" };
            guitarKeyGButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GuitarKeySelected);
            guitarKeyPopupMenu.AddItem(guitarKeyGButton);

            guitarKeyDropDown.Parent = this;
            guitarKeyDropDown.DropDownControl = guitarKeyPopupMenu;

            ItemClickEventArgs guitarKeySetupArgs = new ItemClickEventArgs(guitarKeyEButton, null);
            GuitarKeySelected(guitarKeyBarManager, guitarKeySetupArgs);
        }

        private void SetupTuningTypeBarManager()
        {
            tuningTypeBarManager = new BarManager { Form = this };
            tuningTypePopupMenu = new PopupMenu();

            standardTuningTypeButton = new BarButtonItem(tuningTypeBarManager, "Standard") { Tag = "Standard" };
            standardTuningTypeButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TuningTypeSelected);
            tuningTypePopupMenu.AddItem(standardTuningTypeButton);
            dropTuningTypeButton = new BarButtonItem(tuningTypeBarManager, "Drop") { Tag = "Drop" };
            dropTuningTypeButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TuningTypeSelected);
            tuningTypePopupMenu.AddItem(dropTuningTypeButton);
            openTuningTypeButton = new BarButtonItem(tuningTypeBarManager, "Open") { Tag = "Open" };
            openTuningTypeButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TuningTypeSelected);
            tuningTypePopupMenu.AddItem(openTuningTypeButton);

            tuningTypeDropDown.Parent = this;
            tuningTypeDropDown.DropDownControl = tuningTypePopupMenu;

            ItemClickEventArgs tuningTypeSetupArgs = new ItemClickEventArgs(standardTuningTypeButton, null);
            TuningTypeSelected(tuningTypeBarManager, tuningTypeSetupArgs);
        }

        private void SetupFretBoardGrid()
        {
            for (int i = 0; i <= 5; i++)
                fretBoardGrid.Rows.Add();
        }

        private void KeySelected(object sender, ItemClickEventArgs clickedItem)
        {
            keyDropDown.Text = clickedItem.Item.Caption;
            UpdateMeBro();
        }

        private void GuitarKeySelected(object sender, ItemClickEventArgs clickedItem)
        {
            guitarKeyDropDown.Text = clickedItem.Item.Caption;
            UpdateMeBro();
        }

        private void TuningTypeSelected(object sender, ItemClickEventArgs clickedItem)
        {
            tuningTypeDropDown.Text = clickedItem.Item.Caption;
            UpdateMeBro();
        }

        private void UpdateMeBro()
        {
            ReStringGuitar();
            FingerNotes();
        }

        private void FingerNotes()
        {
            ChromaticScale[] scalePattern;

            if (minorKeyRadioButton.Checked)
                scalePattern = MinorScalePatternForKey(ScaleValue(keyDropDown.Text));
            else
                scalePattern = MajorScalePatternForKey(ScaleValue(keyDropDown.Text));

            foreach (DataGridViewRow guitarString in fretBoardGrid.Rows)
            {
                ChromaticScale chromaticNote = ScaleValue(guitarString.HeaderCell.Value.ToString());

                for(int i = 0; i < guitarString.Cells.Count; i++)
                {
                    if (scalePattern.Contains(chromaticNote))
                        guitarString.Cells[i].Value = NoteStringValue(chromaticNote);
                    else
                        guitarString.Cells[i].Value = "";

                    chromaticNote++;
                    if (!Enum.IsDefined(typeof(ChromaticScale), chromaticNote))
                        chromaticNote -= 12;
                }
            }
        }

        private void ReStringGuitar()
        {
            ChromaticScale sixthString = TuneSixthString();
            fretBoardGrid.Rows[5].HeaderCell.Value = NoteStringValue(sixthString);
            ChromaticScale fifthString = TuneFifthString(sixthString);
            fretBoardGrid.Rows[4].HeaderCell.Value = NoteStringValue(fifthString);
            ChromaticScale fourthString = TuneFourthString(fifthString);
            fretBoardGrid.Rows[3].HeaderCell.Value = NoteStringValue(fourthString);
            ChromaticScale thirdString = TuneThirdString(fourthString);
            fretBoardGrid.Rows[2].HeaderCell.Value = NoteStringValue(thirdString);
            ChromaticScale secondString = TuneSecondString(thirdString);
            fretBoardGrid.Rows[1].HeaderCell.Value = NoteStringValue(secondString);
            ChromaticScale firstString = TuneFirstString(secondString);
            fretBoardGrid.Rows[0].HeaderCell.Value = NoteStringValue(firstString);
        }

        private ChromaticScale TuneSixthString() // 'E' string(low)
        {
            return ScaleValue(guitarKeyDropDown.Text);
        }

        private ChromaticScale TuneFifthString(ChromaticScale note) // 'A' string
        {
            ChromaticScale fifthString = note;

            if (tuningTypeDropDown.Text.Equals("Standard")) // (E) 5th (A) 5th(D) 5th (G) 4th (B) 5th(E)
                fifthString = FindFifth(note);
            else if (tuningTypeDropDown.Text.Equals("Drop")) // (D) 7th (A) 5th (D) 5th (G) 4th (B) 5th (E)
                fifthString = FindSeventh(note);
            else if (tuningTypeDropDown.Text.Equals("Open")) // (E) 6th (B) 5th (E) 4th (G#) 3rd (B) 5th (E)
                fifthString = FindSixth(note);

            return fifthString;
        }

        private ChromaticScale TuneFourthString(ChromaticScale note) // 'D' string
        {
            return FindFifth(note);
        }

        private ChromaticScale TuneThirdString(ChromaticScale note) // 'G' string
        {
            ChromaticScale thirdString = note;

            if (tuningTypeDropDown.Text.Equals("Standard") || tuningTypeDropDown.Text.Equals("Drop")) // (E) 5th (A) 5th(D) 5th (G) 4th (B) 5th(E)
                thirdString = FindFifth(note);

            else if (tuningTypeDropDown.Text.Equals("Open")) // (E) 6th (B) 5th (E) 4th (G#) 3rd (B) 5th (E)
                thirdString = FindFourth(note);

            return thirdString;
        }

        private ChromaticScale TuneSecondString(ChromaticScale note) // 'B' string
        {
            ChromaticScale secondString = note;

            if (tuningTypeDropDown.Text.Equals("Standard") || tuningTypeDropDown.Text.Equals("Drop")) // (E) 5th (A) 5th(D) 5th (G) 4th (B) 5th(E)
                secondString = FindFourth(note);
            else if (tuningTypeDropDown.Text.Equals("Open")) // (E) 6th (B) 5th (E) 4th (G#) 3rd (B) 5th (E)
                secondString = FindThird(note);

            return secondString;
        }

        private ChromaticScale TuneFirstString(ChromaticScale note) // 'E' string(high)
        {
            return FindFifth(note);
        }

        private ChromaticScale FindThird(ChromaticScale note)
        {
            ChromaticScale third = note + 3;
            if (!Enum.IsDefined(typeof(ChromaticScale), third))
                third -= 12;

            return third;
        }

        private ChromaticScale FindFourth(ChromaticScale note)
        {
            ChromaticScale fourth = note + 4;
            if (!Enum.IsDefined(typeof(ChromaticScale), fourth))
                fourth -= 12;

            return fourth;
        }

        private ChromaticScale FindFifth(ChromaticScale note)
        {
            ChromaticScale fifth = note + 5;
            if (!Enum.IsDefined(typeof(ChromaticScale), fifth))
                fifth -= 12;

            return fifth;
        }

        private ChromaticScale FindSixth(ChromaticScale note)
        {
            ChromaticScale sixth = note + 6;
            if (!Enum.IsDefined(typeof(ChromaticScale), sixth))
                sixth -= 12;

            return sixth;
        }

        private ChromaticScale FindSeventh(ChromaticScale note)
        {
            ChromaticScale seventh = note + 7;
            if (!Enum.IsDefined(typeof(ChromaticScale), seventh))
                seventh -= 12;

            return seventh;
        }

        private ChromaticScale ScaleValue(string scaleChar)
        {
            ChromaticScale note = ChromaticScale.A;

            switch (scaleChar)
            {
                case "A": note = ChromaticScale.A; break;
                case "AS": note = ChromaticScale.AS; break;
                case "B": note = ChromaticScale.B; break;
                case "C": note = ChromaticScale.C; break;
                case "CS": note = ChromaticScale.CS; break;
                case "D": note = ChromaticScale.D; break;
                case "DS": note = ChromaticScale.DS; break;
                case "E": note = ChromaticScale.E; break;
                case "F": note = ChromaticScale.F; break;
                case "FS": note = ChromaticScale.FS; break;
                case "G": note = ChromaticScale.G; break;
                case "GS": note = ChromaticScale.GS; break;
                default: break;
            }
            return note; // maybe should have an error but we'll see.
        }

        private String NoteStringValue(ChromaticScale note)
        {
            String noteString = "";

            switch (note)
            {
                case ChromaticScale.A:  noteString = "A";  break;
                case ChromaticScale.AS: noteString = "A#"; break;
                case ChromaticScale.B:  noteString = "B";  break;
                case ChromaticScale.C:  noteString = "C";  break;
                case ChromaticScale.CS: noteString = "C#"; break;
                case ChromaticScale.D:  noteString = "D";  break;
                case ChromaticScale.DS: noteString = "D#"; break;
                case ChromaticScale.E:  noteString = "E";  break;
                case ChromaticScale.F:  noteString = "F";  break;
                case ChromaticScale.FS: noteString = "F#"; break;
                case ChromaticScale.G:  noteString = "G";  break;
                case ChromaticScale.GS: noteString = "G#"; break;
                default: break;
            }

            return noteString;
        }

        private void MinorMajorKeyChange(object sender, EventArgs e)
        {
            UpdateMeBro();
        }
    }
}
