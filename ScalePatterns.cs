using System;

namespace guitarBro
{
    public partial class GuitarBro
    {
        #region class properties
        private enum ChromaticScale { A, AS, B, C, CS, D, DS, E, F, FS, G, GS }
        #endregion

        #region Scale Patterns
        // MinorScalePattern - whole, half, whole, whole, half, whole, whole
        private ChromaticScale[] MinorScalePatternForKey(ChromaticScale note)
        {
            ChromaticScale[] scalePattern = new ChromaticScale[7];
            ChromaticScale nextStep = note;

            for (int i = 0; i < scalePattern.Length; i++)
            {
                if (i == 0) // root
                    scalePattern[i] = note;
                else if((i == 2) || (i == 5)) // half step
                {
                    nextStep = FindNextInterval(1, nextStep);
                    scalePattern[i] = nextStep;
                }
                else // whole step
                {
                    nextStep = FindNextInterval(2, nextStep);
                    scalePattern[i] = nextStep;
                }
            }

            return scalePattern; 
        }

        // MajorScalePattern - whole, whole, half, whole, whole, whole, half
        private ChromaticScale[] MajorScalePatternForKey(ChromaticScale note)
        {
            ChromaticScale[] scalePattern = new ChromaticScale[7];
            ChromaticScale nextStep = note;

            for (int i = 0; i < scalePattern.Length; i++)
            {
                if(i == 0) // root
                    scalePattern[i] = note;
                else if ((i == 3) || (i == 7)) // half step
                {
                    nextStep = FindNextInterval(1, nextStep);
                    scalePattern[i] = nextStep;
                }
                else // whole step
                {
                    nextStep = FindNextInterval(2, nextStep);
                    scalePattern[i] = nextStep;
                }
            }

            return scalePattern;
        }

        private ChromaticScale[] PentatonicScalePatternForKey(ChromaticScale note)
        {
            if(minorMajorToggleSwitch.IsOn)
                return MajorPentatonicScalePatternForKey(note);
            else
                return MinorPentatonicScalePatternForKey(note);
        }

        // Minor Pentatonic Pattern - 3,2,2,3 (semitones)
        private ChromaticScale[] MinorPentatonicScalePatternForKey(ChromaticScale note)
        {
            ChromaticScale[] scalePattern = new ChromaticScale[5];
            ChromaticScale nextStep = note;

            for (int i = 0; i < scalePattern.Length; i++)
            {
                if (i == 0) // root
                    scalePattern[i] = note;
                else if ((i == 2) || (i == 3)) // 2 semitones
                {
                    nextStep = FindNextInterval(2, nextStep);
                    scalePattern[i] = nextStep;
                }
                else // 3 semitones
                {
                    nextStep = FindNextInterval(3, nextStep);
                    scalePattern[i] = nextStep;
                }
            }

            return scalePattern;
        }

        // Major Pentatonic Pattern - 2,2,3,2 (semitones)
        private ChromaticScale[] MajorPentatonicScalePatternForKey(ChromaticScale note)
        {
            ChromaticScale[] scalePattern = new ChromaticScale[5];
            ChromaticScale nextStep = note;

            for (int i = 0; i < scalePattern.Length; i++)
            {
                if (i == 0) // root
                    scalePattern[i] = note;
                else if (i == 3) // 3 semitones
                {
                    nextStep = FindNextInterval(3, nextStep);
                    scalePattern[i] = nextStep;
                }
                else // 2 semitones
                {
                    nextStep = FindNextInterval(2, nextStep);
                    scalePattern[i] = nextStep;
                }
            }

            return scalePattern;
        }

        private ChromaticScale[] BluesScalePatternForKey(ChromaticScale note)
        {
            if (minorMajorToggleSwitch.IsOn)
                return MajorBluesScalePatternForKey(note);
            else
                return MinorBluesScalePatternForKey(note);
        }

        // Minor Blues Pattern - 3, 2, 1, 1, 3
        private ChromaticScale[] MinorBluesScalePatternForKey(ChromaticScale note)
        {
            ChromaticScale[] scalePattern = new ChromaticScale[6];
            ChromaticScale nextStep = note;

            for (int i = 0; i < scalePattern.Length; i++)
            {
                if (i == 0) // root
                    scalePattern[i] = note;
                else if ((i == 3) || (i == 4)) // 1 semitone
                {
                    nextStep = FindNextInterval(1, nextStep);
                    scalePattern[i] = nextStep;
                }
                else if (i == 2) // 2 semitones
                {
                    nextStep = FindNextInterval(2, nextStep);
                    scalePattern[i] = nextStep;
                }
                else // 3 semitones
                {
                    nextStep = FindNextInterval(3, nextStep);
                    scalePattern[i] = nextStep;
                }
            }

            return scalePattern;
        }

        // Major Blues Pattern - 2, 1, 1, 3, 2
        private ChromaticScale[] MajorBluesScalePatternForKey(ChromaticScale note)
        {
            ChromaticScale[] scalePattern = new ChromaticScale[6];
            ChromaticScale nextStep = note;

            for (int i = 0; i < scalePattern.Length; i++)
            {
                if (i == 0) // root
                    scalePattern[i] = note;
                else if ((i == 2) || (i == 3)) // 1 semitone
                {
                    nextStep = FindNextInterval(1, nextStep);
                    scalePattern[i] = nextStep;
                }
                else if ((i == 1) || (i == 5)) // 2 semitones
                {
                    nextStep = FindNextInterval(2, nextStep);
                    scalePattern[i] = nextStep;
                }
                else // 3 semitones
                {
                    nextStep = FindNextInterval(3, nextStep);
                    scalePattern[i] = nextStep;
                }
            }

            return scalePattern;
        }

        private ChromaticScale[] UpdateScalePattern()
        {
            ChromaticScale[] scalePattern;

            switch (scaleDropDown.Text)
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
                default: scalePattern = FullChromaticScale(); break;
            }

            return scalePattern;
        }

        #endregion

        #region Finding Intervals
        // Do not pass an interval > 11
        private ChromaticScale FindNextInterval(int interval, ChromaticScale note)
        {
            note += interval;
            if (!Enum.IsDefined(typeof(ChromaticScale), note))
                note -= 12;

            return note;
        }

        private ChromaticScale FindThird(ChromaticScale note) => FindNextInterval(3, note);

        private ChromaticScale FindFourth(ChromaticScale note) => FindNextInterval(4, note);

        private ChromaticScale FindFifth(ChromaticScale note) => FindNextInterval(5, note);

        private ChromaticScale FindSixth(ChromaticScale note) => FindNextInterval(6, note);

        private ChromaticScale FindSeventh(ChromaticScale note) => FindNextInterval(7, note);
        #endregion

        #region Conversion methods
        private ChromaticScale ScaleValue(string scaleChar)
        {
            ChromaticScale note = ChromaticScale.A;

            switch (scaleChar)
            {
                case "A":  note = ChromaticScale.A;  break;
                case "A#": note = ChromaticScale.AS; break;
                case "B":  note = ChromaticScale.B;  break;
                case "C":  note = ChromaticScale.C;  break;
                case "C#": note = ChromaticScale.CS; break;
                case "D":  note = ChromaticScale.D;  break;
                case "D#": note = ChromaticScale.DS; break;
                case "E":  note = ChromaticScale.E;  break;
                case "F":  note = ChromaticScale.F;  break;
                case "F#": note = ChromaticScale.FS; break;
                case "G":  note = ChromaticScale.G;  break;
                case "G#": note = ChromaticScale.GS; break;
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
        #endregion

        #region Pre-Made Scale Patterns

        private ChromaticScale[] FullChromaticScale()
        {
            return new ChromaticScale[]
            {   ChromaticScale.A,
                ChromaticScale.AS,
                ChromaticScale.B,
                ChromaticScale.C,
                ChromaticScale.CS,
                ChromaticScale.D,
                ChromaticScale.DS,
                ChromaticScale.E,
                ChromaticScale.F,
                ChromaticScale.FS,
                ChromaticScale.G,
                ChromaticScale.GS   };
        }

        #endregion
    }
}
