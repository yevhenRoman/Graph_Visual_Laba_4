using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Visual_Laba_3
{
   static class  CorectnessChecker
    {
        public static bool CheckT(string min, string max, string stepValue)
        {

            if (String.IsNullOrEmpty(min) || String.IsNullOrEmpty(max) || String.IsNullOrEmpty(stepValue))
            {
                Utils.ShowErrorMessage("Please input all information");
                return false;
            }

            double t_min, t_max, step_value;
            try
            {   // Converting
                t_min = Convert.ToDouble(min);
                t_max = Convert.ToDouble(max);
                step_value = Convert.ToDouble(stepValue);

                // Check input
                if (step_value == 0 || t_min - t_max <= 0 || t_min + step_value > t_max)
                {
                    Utils.ShowErrorMessage("Input string was not in a correct format.");
                    return false;
                }
                return true;
            }
            catch (FormatException ex)
            {
                Utils.ShowErrorMessage(ex.Message);
                return false;
            }
        }
    }
}
