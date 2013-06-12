using System;

using System.Collections.Generic;

using System.Text;

using System.Windows.Forms;

namespace randfip
{

    /// <summary>

    /// Static class permitting access to static FadeForm function

    /// </summary>

    public static class FadeEffect
    {


        /// <summary>

        /// Function used to fade out a form using a user defined number

        /// of steps

        /// </summary>

        /// <param name="f">The Windows form to fade out</param>

        /// <param name="NumberOfSteps">The number of steps used to fade the

        /// form</param>

        public static void FadeForm(System.Windows.Forms.Form f, byte NumberOfSteps)
        {

            float StepVal = (float)(100f / NumberOfSteps);

            float fOpacity = 100f;

            for (byte b = 0; b < NumberOfSteps; b++)
            {

                f.Opacity = fOpacity / 100;

                f.Refresh();

                fOpacity -= StepVal;

            }

        }

        public static void FadePartialForm(System.Windows.Forms.Form f, byte NumberOfSteps)
        {

            float StepVal = (float)(100f / NumberOfSteps);

            float fOpacity = 100f;

            for (byte b = 0; b < NumberOfSteps-10; b++)
            {

                f.Opacity = fOpacity / 100;

                f.Refresh();

                fOpacity -= StepVal;

            }

        }

    }

}