using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Visual_Laba_3
{
    public interface UIConnector
    {
        void SetVisibilityForGridView(bool visibility1, bool visibility2);
        void ClearChart();
        void SetMinMaxTValues(string min, string max);
        void SetMinMaxFValues(string min, string max);
        void SetMinMaxXValues(string min, string max);
        void SetStepValue(string value);

        void ClearDataGridView(int num);

        void BuildChart(double i, double result);

        void BuildDataGrid(int ver, double i, int j, double res1, Nullable<double> res2);

        void RemoveGridRows(int ver);

        void SetValueToGrid(int ver, int i, int j, double value);

        void AddRowToGridView(int ver, int row);

        double GetValueFromGrid(int ver, int i, int j);
    }
}
