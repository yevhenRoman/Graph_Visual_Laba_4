using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Visual_Laba_3
{
    static class Utils
    {
        public static void ShowErrorMessage(String errorDescription)
        {
            System.Windows.Forms.MessageBox.Show(errorDescription, "Error",
                System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        // Amount of points
        public static int GetCountOfPoints(string min, string max, string step)
        {
            return (int)((Convert.ToDouble(max) - Convert.ToDouble(min)) / Convert.ToDouble(step));
        }
    }
}
