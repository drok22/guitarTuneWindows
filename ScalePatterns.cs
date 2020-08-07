using System;

namespace guitarBro
{
    public partial class GuitarBro
    {
        #region class properties
        private enum ChromaticScale { A, AS, B, C, CS, D, DS, E, F, FS, G, GS }

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
    }
}
