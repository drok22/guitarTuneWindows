using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static guitarBro.ScalePatterns;

namespace guitarBro
{
    public partial class GuitarBroWindows : Form
    {
        #region Loading
        public GuitarBroWindows()
        {
            InitializeComponent();
        }
        private void LoadGuitarBro(object sender, EventArgs e)
        {
            SetupFretBoardGrid();
            majorMinorCombo.SelectedIndex = majorMinorCombo.Items.IndexOf("Minor");
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
            ChromaticScale[] scalePattern = UpdateScalePattern(scaleCombo.Text, keyCombo.Text, majorMinorCombo.Text == "Major");

            foreach (DataGridViewRow guitarString in fretBoardGrid.Rows)
            {
                // Get the first scale note available on the string from the header.
                ChromaticScale chromaticNote = ScaleValue(guitarString.HeaderCell.Value.ToString());

                for (int i = 0; i < guitarString.Cells.Count; i++)
                {
                    // if this note is contained in our scale pattern,
                    // we mark it with a note or number based on toggle switch value.
                    if (scalePattern.Contains(chromaticNote))
                    {
                        switch(fretboardDisplayCombo.Text)
                        {
                            case "Frets":
                                guitarString.Cells[i].Value = i.ToString();
                                break;
                            case "Notes":
                                guitarString.Cells[i].Value = NoteStringValue(chromaticNote);
                                break;
                            case "Dots": break;
                            default: break;
                        }
                    }
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

            if (majorMinorCombo.Text == "Major")
                keyString += "Major ";
            else
                keyString += "Minor ";

            if ((!scaleCombo.Text.Contains("Major")) && (!scaleCombo.Text.Contains("Minor")))
                keyString += scaleCombo.Text;

            foreach (ChromaticScale note in scalePattern)
                noteList += NoteStringValue(note) + " ";

            keyDisplayLabel.Text = keyString;
            scalePatternDisplayLabel.Text = noteList;
        }

        private void UpdateGuitarTuningInstruction()
        {
            string tuneGuitarToString = "";

            for (int i = 5; i >= 0; i--)
                tuneGuitarToString += fretBoardGrid.Rows[i].HeaderCell.Value + " ";

            guitarStringTuningDisplayLabel.Text = tuneGuitarToString;
        }

        #endregion
        #region UI Setup

        private void SetupFretBoardGrid()
        {
            // FIXME: What if we want to add strings to the fretboard?
            for (int i = 0; i <= 5; i++)
                fretBoardGrid.Rows.Add();

            keyCombo.SelectedIndex = keyCombo.Items.IndexOf("E");
            majorMinorCombo.SelectedIndex = majorMinorCombo.Items.IndexOf("Minor");
            guitarKeyCombo.SelectedIndex = guitarKeyCombo.Items.IndexOf("E");
            tuningTypeCombo.SelectedIndex = tuningTypeCombo.Items.IndexOf("Standard");
            scaleCombo.SelectedIndex = scaleCombo.Items.IndexOf("Minor");
            fretboardDisplayCombo.SelectedIndex = fretboardDisplayCombo.Items.IndexOf("Notes");
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
            return ScaleValue(guitarKeyCombo.Text);
        }

        private ChromaticScale TuneFifthString(ChromaticScale note) // 'A' string
        {
            ChromaticScale fifthString = note;

            if (tuningTypeCombo.Text.Equals("Standard")) // (E) 5th (A) 5th(D) 5th (G) 4th (B) 5th(E)
                fifthString = FindFifth(note);
            else if (tuningTypeCombo.Text.Equals("Drop")) // (D) 7th (A) 5th (D) 5th (G) 4th (B) 5th (E)
                fifthString = FindSeventh(note);
            else if (tuningTypeCombo.Text.Equals("Open")) // (E) 6th (B) 5th (E) 4th (G#) 3rd (B) 5th (E)
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

            if (tuningTypeCombo.Text.Equals("Standard") || tuningTypeCombo.Text.Equals("Drop")) // (E) 5th (A) 5th(D) 5th (G) 4th (B) 5th(E)
                thirdString = FindFifth(note);

            else if (tuningTypeCombo.Text.Equals("Open")) // (E) 6th (B) 5th (E) 4th (G#) 3rd (B) 5th (E)
                thirdString = FindFourth(note);

            return thirdString;
        }

        private ChromaticScale TuneSecondString(ChromaticScale note) // 'B' string
        {
            ChromaticScale secondString = note;

            if (tuningTypeCombo.Text.Equals("Standard") || tuningTypeCombo.Text.Equals("Drop")) // (E) 5th (A) 5th(D) 5th (G) 4th (B) 5th(E)
                secondString = FindFourth(note);
            else if (tuningTypeCombo.Text.Equals("Open")) // (E) 6th (B) 5th (E) 4th (G#) 3rd (B) 5th (E)
                secondString = FindThird(note);

            return secondString;
        }

        private ChromaticScale TuneFirstString(ChromaticScale note) // 'E' string(high)
        {
            return FindFifth(note);
        }

        #endregion
        #region UI actions
        //
        private void KeyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMeBro();
        }
        private void GuitarKeyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMeBro();
        }
        private void TuningTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMeBro();
        }
        private void MajorMinorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (scaleCombo.Text == "Minor" && majorMinorCombo.Text == "Major")
                scaleCombo.SelectedIndex = scaleCombo.Items.IndexOf("Major");
            else if (scaleCombo.Text == "Major" && majorMinorCombo.Text == "Minor")
                scaleCombo.SelectedIndex = scaleCombo.Items.IndexOf("Minor");

            UpdateMeBro();
        }
        private void ScaleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.Text == "Major")
                majorMinorCombo.SelectedIndex = majorMinorCombo.Items.IndexOf("Major");
            else
                majorMinorCombo.SelectedIndex = majorMinorCombo.Items.IndexOf("Minor");

            UpdateMeBro();
        }
        private void FretboardDisplayCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FingerNotes();
        }
        //
        
        private void CsvButton_Click(object sender, EventArgs e)
        {
            SaveCSVFileWithText(CSVTextForCurrentScreen());
        }

        #endregion

        #region Save CSV

        private string CSVTextForCurrentScreen()
        {
            string csvText = "";

            foreach (DataGridViewRow guitarString in fretBoardGrid.Rows)
            {
                for (int i = 0; i < guitarString.Cells.Count; i++)
                {
                    csvText += guitarString.Cells[i].Value;

                    if (i < guitarString.Cells.Count)
                        csvText += ",";
                }

                csvText += "\n";
            }

            // add a label so the guitar fret numbers are visible in the sheet export.
            csvText += CSVTextForGuitarFrets();

            return csvText;
        }

        private void SaveCSVFileWithText(string csvText)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName += GenerateFileNameForCSVExport();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog.FileName, csvText);
        }

        private string GenerateFileNameForCSVExport()
        {
            string fileName = keyCombo.Text + " " + scaleCombo.Text + " " + tuningTypeCombo.Text + " " + guitarKeyCombo.Text + ".csv";

            return fileName;
        }

        private string CSVTextForGuitarFrets()
        {
            string guitarFretCountCSV = "";

            for (int i = 0; i < fretBoardGrid.ColumnCount; i++)
            {
                guitarFretCountCSV += i.ToString();
                guitarFretCountCSV += ",";
            }

            guitarFretCountCSV += "\n";

            return guitarFretCountCSV;
        }

        private string CSVTextForEmptyRow()
        {
            string emptyRowCSVString = "";
            for (int i = 0; i < fretBoardGrid.ColumnCount; i++)
                emptyRowCSVString += ",";

            emptyRowCSVString += "\n";

            return emptyRowCSVString;
        }
        #endregion
    }
}
