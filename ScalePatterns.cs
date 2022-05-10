using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guitarBro
{
    public class ScalePatterns
    {
        public enum ChromaticScale { A, AS, B, C, CS, D, DS, E, F, FS, G, GS }

        #region Scale Patterns
        // MinorScalePattern - whole, half, whole, whole, half, whole, whole
        public static ChromaticScale[] MinorScalePatternForKey(ChromaticScale note)
        {
            ChromaticScale[] scalePattern = new ChromaticScale[7];
            ChromaticScale nextStep = note;

            for (int i = 0; i < scalePattern.Length; i++)
            {
                if (i == 0) // root
                    scalePattern[i] = note;
                else if ((i == 2) || (i == 5)) // half step
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
        public static ChromaticScale[] MajorScalePatternForKey(ChromaticScale note)
        {
            ChromaticScale[] scalePattern = new ChromaticScale[7];
            ChromaticScale nextStep = note;

            for (int i = 0; i < scalePattern.Length; i++)
            {
                if (i == 0) // root
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

        public static ChromaticScale[] PentatonicScalePatternForKey(ChromaticScale note, bool isMajorKey)
        {
            if (isMajorKey)
                return MajorPentatonicScalePatternForKey(note);
            else
                return MinorPentatonicScalePatternForKey(note);
        }

        // Minor Pentatonic Pattern - 3,2,2,3 (semitones)
        public static ChromaticScale[] MinorPentatonicScalePatternForKey(ChromaticScale note)
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
        public static ChromaticScale[] MajorPentatonicScalePatternForKey(ChromaticScale note)
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

        public static ChromaticScale[] BluesScalePatternForKey(ChromaticScale note, bool isMajorKey)
        {
            if (isMajorKey)
                return MajorBluesScalePatternForKey(note);
            else
                return MinorBluesScalePatternForKey(note);
        }

        // Minor Blues Pattern - 3, 2, 1, 1, 3
        public static ChromaticScale[] MinorBluesScalePatternForKey(ChromaticScale note)
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
        public static ChromaticScale[] MajorBluesScalePatternForKey(ChromaticScale note)
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

        //TODO: put this in guitarBroWindows?
        public static ChromaticScale[] UpdateScalePattern(string scaleName, string keyName, bool isMajorKey)
        {
            ChromaticScale[] scalePattern;

            switch (scaleName)
            {
                case "Pentatonic":
                    scalePattern = PentatonicScalePatternForKey(ScaleValue(keyName), isMajorKey);
                    break;
                case "Minor":
                    scalePattern = MinorScalePatternForKey(ScaleValue(keyName));
                    break;
                case "Major":
                    scalePattern = MajorScalePatternForKey(ScaleValue(keyName));
                    break;
                case "Blues":
                    scalePattern = BluesScalePatternForKey(ScaleValue(keyName), isMajorKey);
                    break;
                default: scalePattern = FullChromaticScale(); break;
            }

            return scalePattern;
        }

        #endregion

        #region Finding Intervals
        // Do not pass an interval > 11
        public static ChromaticScale FindNextInterval(int interval, ChromaticScale note)
        {
            note += interval;
            if (!Enum.IsDefined(typeof(ChromaticScale), note))
                note -= 12;

            return note;
        }

        public static ChromaticScale FindThird(ChromaticScale note) => FindNextInterval(3, note);

        public static ChromaticScale FindFourth(ChromaticScale note) => FindNextInterval(4, note);

        public static ChromaticScale FindFifth(ChromaticScale note) => FindNextInterval(5, note);

        public static ChromaticScale FindSixth(ChromaticScale note) => FindNextInterval(6, note);

        public static ChromaticScale FindSeventh(ChromaticScale note) => FindNextInterval(7, note);
        #endregion

        #region Conversion methods
        public static ChromaticScale ScaleValue(string scaleChar)
        {
            ChromaticScale note = ChromaticScale.A;

            switch (scaleChar)
            {
                case "A": note = ChromaticScale.A; break;
                case "A#": note = ChromaticScale.AS; break;
                case "B": note = ChromaticScale.B; break;
                case "C": note = ChromaticScale.C; break;
                case "C#": note = ChromaticScale.CS; break;
                case "D": note = ChromaticScale.D; break;
                case "D#": note = ChromaticScale.DS; break;
                case "E": note = ChromaticScale.E; break;
                case "F": note = ChromaticScale.F; break;
                case "F#": note = ChromaticScale.FS; break;
                case "G": note = ChromaticScale.G; break;
                case "G#": note = ChromaticScale.GS; break;
                default: break;
            }
            return note; // maybe should have an error but we'll see.
        }

        public static string NoteStringValue(ChromaticScale note)
        {
            string noteString = "";

            switch (note)
            {
                case ChromaticScale.A: noteString = "A"; break;
                case ChromaticScale.AS: noteString = "A#"; break;
                case ChromaticScale.B: noteString = "B"; break;
                case ChromaticScale.C: noteString = "C"; break;
                case ChromaticScale.CS: noteString = "C#"; break;
                case ChromaticScale.D: noteString = "D"; break;
                case ChromaticScale.DS: noteString = "D#"; break;
                case ChromaticScale.E: noteString = "E"; break;
                case ChromaticScale.F: noteString = "F"; break;
                case ChromaticScale.FS: noteString = "F#"; break;
                case ChromaticScale.G: noteString = "G"; break;
                case ChromaticScale.GS: noteString = "G#"; break;
                default: break;
            }

            return noteString;
        }
        #endregion

        #region Pre-Made Scale Patterns

        public static ChromaticScale[] FullChromaticScale()
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
