using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace guitarBro
{
    public partial class GuitarBro : DevExpress.XtraEditors.XtraForm
    {
        #region class properties
        private BarManager keyBarManager;
        private BarManager guitarKeyBarManager;
        private BarManager tuningTypeBarManager;
        private PopupMenu keyPopupMenu;
        private PopupMenu guitarKeyPopupMenu;
        private PopupMenu tuningTypePopupMenu;
        private BarButtonItem[] keyButtons = new BarButtonItem[12];
        private BarButtonItem[] guitarKeyButtons = new BarButtonItem[12];

        // still need to find a way to add these to an array when there's more tunings.
        private BarButtonItem standardTuningTypeButton;
        private BarButtonItem dropTuningTypeButton;
        private BarButtonItem openTuningTypeButton;
        #endregion

        #region Loading
        public GuitarBro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupFretBoardGrid();
            minorKeyRadioButton.Checked = true;
            SetupBarManagers();
        }
        #endregion

        #region UI Update

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

                for (int i = 0; i < guitarString.Cells.Count; i++)
                {
                    if (scalePattern.Contains(chromaticNote))
                        guitarString.Cells[i].Value = NoteStringValue(chromaticNote);
                    else
                        guitarString.Cells[i].Value = "";

                    chromaticNote = FindNextInterval(1, chromaticNote);
                }
            }
        }
        #endregion

        #region UI Setup
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
            ChromaticScale key = ChromaticScale.A;
            string noteString = NoteStringValue(key);

            for (int i = 0; i < keyButtons.Length; i++)
            {
                keyButtons[i] = new BarButtonItem(keyBarManager, noteString) { Tag = noteString };
                keyButtons[i].ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.KeySelected);
                keyPopupMenu.AddItem(keyButtons[i]);

                key = FindNextInterval(1, key);
                noteString = NoteStringValue(key);
            }

            keyDropDown.Parent = this;
            keyDropDown.DropDownControl = keyPopupMenu;
            ItemClickEventArgs keySetupArgs = new ItemClickEventArgs(keyButtons[7], null);
            KeySelected(keyBarManager, keySetupArgs);
        }

        private void SetupGuitarKeyBarManager()
        {
            guitarKeyBarManager = new BarManager { Form = this };
            guitarKeyPopupMenu = new PopupMenu();
            ChromaticScale key = ChromaticScale.A;
            string noteString = NoteStringValue(key);

            for (int i = 0; i < guitarKeyButtons.Length; i++)
            {
                guitarKeyButtons[i] = new BarButtonItem(keyBarManager, noteString) { Tag = noteString };
                guitarKeyButtons[i].ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GuitarKeySelected);
                guitarKeyPopupMenu.AddItem(guitarKeyButtons[i]);

                key = FindNextInterval(1, key);
                noteString = NoteStringValue(key);
            }

            guitarKeyDropDown.Parent = this;
            guitarKeyDropDown.DropDownControl = guitarKeyPopupMenu;
            ItemClickEventArgs guitarKeySetupArgs = new ItemClickEventArgs(guitarKeyButtons[7], null);
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
        #endregion

        #region Tune Guitar
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

        #endregion

        #region UI actions

        private void MinorMajorKeyChange(object sender, EventArgs e)
        {
            UpdateMeBro();
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

        #endregion
    }
}
