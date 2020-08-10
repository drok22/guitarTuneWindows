using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace guitarBro
{
    public partial class GuitarBro : DevExpress.XtraEditors.XtraForm
    {
        #region class properties

        private BarButtonItem[] keyButtons = new BarButtonItem[12];
        private BarButtonItem[] guitarKeyButtons = new BarButtonItem[12];

        // still need to find a way to add these to an array when there's more tunings/scales.
        private BarButtonItem pentatonicScaleButton;
        private BarButtonItem majorScaleButton;
        private BarButtonItem minorScaleButton;
        private BarButtonItem bluesScaleButton;

        private BarButtonItem standardTuningTypeButton;
        private BarButtonItem dropTuningTypeButton;
        private BarButtonItem openTuningTypeButton;

        private BarManager keyBarManager;
        private BarManager scaleBarManager;
        private BarManager guitarKeyBarManager;
        private BarManager tuningTypeBarManager;

        private PopupMenu keyPopupMenu;
        private PopupMenu scalePopupMenu;
        private PopupMenu guitarKeyPopupMenu;
        private PopupMenu tuningTypePopupMenu;

        #endregion

        #region Loading

        public GuitarBro()
        {
            InitializeComponent();
        }

        private void LoadGuitarBro(object sender, EventArgs e)
        {
            SetupFretBoardGrid();
            minorMajorToggleSwitch.IsOn = false;
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
            ChromaticScale[] scalePattern = FullChromaticScale(); // Put every note in an array just to catch errors if they happen.

            switch(scaleDropDown.Text)
            {
                case "Pentatonic":
                    scalePattern = PentatonicScalePatternForKey(ScaleValue(keyDropDown.Text));
                    break;
                case "Minor":
                    scalePattern = MinorScalePatternForKey(ScaleValue(keyDropDown.Text));
                    break;
                case "Major":
                    scalePattern = MajorScalePatternForKey(ScaleValue(keyDropDown.Text));
                    break;
                case "Blues":
                    scalePattern = BluesScalePatternForKey(ScaleValue(keyDropDown.Text));
                    break;
                default: break;
            }

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

            UpdateScalePatternInstruction(scalePattern);
        }

        private void UpdateScalePatternInstruction(ChromaticScale[] scalePattern)
        {
            string keyString = "";
            string noteList = "";

            keyString += NoteStringValue(scalePattern[0]) + " ";

            if(minorMajorToggleSwitch.IsOn)
                keyString += "Major ";
            else
                keyString += "Minor ";

            if((!scaleDropDown.Text.Contains("Major")) && (!scaleDropDown.Text.Contains("Minor")))
                keyString += scaleDropDown.Text;

            foreach (ChromaticScale note in scalePattern)
                noteList += NoteStringValue(note) + " ";

            keyDisplayLabel.Text = keyString;
            scalePatternDisplayLabel.Text = noteList;
        }

        private void UpdateGuitarTuningInstruction( )
        {
            string tuneGuitarToString = "";

            for(int i = 5; i >= 0; i--)
                tuneGuitarToString += fretBoardGrid.Rows[i].HeaderCell.Value + " ";

            guitarStringTuningDisplayLabel.Text = tuneGuitarToString;
        }

        #endregion

        #region UI Setup
        private void SetupBarManagers()
        {
            SetupKeyBarManager();
            SetupScaleBarManager();
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

        private void SetupScaleBarManager()
        {
            scaleBarManager = new BarManager { Form = this };
            scalePopupMenu = new PopupMenu();

            minorScaleButton = new BarButtonItem(scaleBarManager, "Minor") { Tag = "Minor" };
            minorScaleButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ScaleSelected);
            scalePopupMenu.AddItem(minorScaleButton);
            majorScaleButton = new BarButtonItem(scaleBarManager, "Major") { Tag = "Major" };
            majorScaleButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ScaleSelected);
            scalePopupMenu.AddItem(majorScaleButton);
            pentatonicScaleButton = new BarButtonItem(scaleBarManager, "Pentatonic") { Tag = "Pentatonic" };
            pentatonicScaleButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ScaleSelected);
            scalePopupMenu.AddItem(pentatonicScaleButton);
            bluesScaleButton = new BarButtonItem(scaleBarManager, "Blues") { Tag = "Blues" };
            bluesScaleButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ScaleSelected);
            scalePopupMenu.AddItem(bluesScaleButton);

            scaleDropDown.Parent = this;
            scaleDropDown.DropDownControl = scalePopupMenu;

            ItemClickEventArgs scaleSetupArgs = new ItemClickEventArgs(minorScaleButton, null);
            ScaleSelected(scaleBarManager, scaleSetupArgs);
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

            UpdateGuitarTuningInstruction();
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

        private void MinorMajorToggleSwitch_Toggled(object sender, EventArgs e)
        {
            if(scaleDropDown.Text.Equals("Minor") && minorMajorToggleSwitch.IsOn)
                scaleDropDown.Text = "Major";
            else if (scaleDropDown.Text.Equals("Major") && !minorMajorToggleSwitch.IsOn)
                scaleDropDown.Text = "Minor";

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

        private void ScaleSelected(object sender, ItemClickEventArgs clickedItem)
        {
            scaleDropDown.Text = clickedItem.Item.Caption;

            if (clickedItem.Item.Caption.Equals("Minor"))
                minorMajorToggleSwitch.IsOn = false;
            else if (clickedItem.Item.Caption.Equals("Major"))
                minorMajorToggleSwitch.IsOn = true;

            UpdateMeBro();
        }

        #endregion
    }
}
