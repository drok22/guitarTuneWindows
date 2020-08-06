using System;

namespace guitarBro
{
    public partial class Form1
    {
        private enum ChromaticScale { A, AS, B, C, CS, D, DS, E, F, FS, G, GS }

        // MinorScalePattern - whole, half, whole, whole, half, whole, whole
        private ChromaticScale[] MinorScalePatternForKey(ChromaticScale note)
        {
            ChromaticScale[] scalePattern = new ChromaticScale[7];
            ChromaticScale nextStep = note;

            for (int i = 0; i < scalePattern.Length; i++)
            {
                if (i == 0) // root
                {
                    scalePattern[i] = note;
                }
                else if((i == 2) || (i == 5)) // half step
                {
                    nextStep += 1;
                    if (!Enum.IsDefined(typeof(ChromaticScale), nextStep))
                        nextStep -= 12;

                    scalePattern[i] = nextStep;
                }
                else // whole step
                {
                    nextStep += 2;
                    if (!Enum.IsDefined(typeof(ChromaticScale), nextStep))
                        nextStep -= 12;

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
                {
                    scalePattern[i] = note;
                }
                else if ((i == 3) || (i == 7)) // half step
                {
                    nextStep += 1;
                    if (!Enum.IsDefined(typeof(ChromaticScale), nextStep))
                        nextStep -= 12;

                    scalePattern[i] = nextStep;
                }
                else // whole step
                {
                    nextStep += 2;
                    if (!Enum.IsDefined(typeof(ChromaticScale), nextStep))
                        nextStep -= 12;

                    scalePattern[i] = nextStep;
                }
            }

            return scalePattern;
        }
    }
}
