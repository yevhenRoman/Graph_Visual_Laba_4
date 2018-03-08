using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Visual_Laba_3
{
    class FunctionCalculation
    {
        private static UIConnector connector;
        // X Scope
        double minX;
        double maxX;
        // T scope
        double minT;
        double maxT;
        // Step
        double step;
        // Amount of points
        double points;
        // MinMax Function
        double maxF;
        double minF;
        
        
        bool checkT = false;
        
        public FunctionCalculation(UIConnector uiConnector)
        {
            connector = uiConnector;
        }

        public void CalculateFunctionF()
        {
            // Check if X used
            if (!Form1.SimpleGraphUsed)
            {
                Utils.ShowErrorMessage("Please set X first!");
                return;
            }
            // Set Visibility of dataGridView
            connector.SetVisibilityForGridView(true, false);
            connector.ClearChart();
            // Check input
            if (minX - maxX == 0 || step == 0)
            {
                Utils.ShowErrorMessage("Wrong input");
                connector.SetMinMaxXValues("", "");
                connector.SetMinMaxFValues("Min = ", "Max = ");
                connector.SetStepValue("");

                return;
            }
            // Need to set maxF and minF
            bool first_iteration = true;
            // Clear dataGridView1
            connector.ClearDataGridView(1);
            // Need to rows iteration
            int j = 0;
            // Building chart and dataGridView
            for (double i = minX; i <= maxX; i += step)
            {
                connector.BuildDataGrid(1, i, j, function_f(i), null);
                connector.BuildChart(i, function_f(i));
                j++;

                // If first iteration set minF and maxF
                if (first_iteration)
                {
                    minF = function_f(i);
                    maxF = function_f(i);
                    first_iteration = false;
                }
                // Looking for minF and maxF
                if (maxF < function_f(i))
                    maxF = function_f(i);
                if (minF > function_f(i))
                    minF = function_f(i);
            }
            // Set MinF and MaxF labels
            connector.SetMinMaxFValues("Min = " + minF.ToString(), "Max = " + maxF.ToString());
        }

        public void ClaculateFunctionS()
        {
             // Check if T used
            if (Form1.SimpleGraphUsed)
            {
                Utils.ShowErrorMessage("Please set T first!");
                return;
            }
            // Set Visibility
            connector.SetVisibilityForGridView(false, true);
            // Check input
            if (minT - maxT == 0 || step == 0)
            {
                Utils.ShowErrorMessage("Wrong input");
                connector.SetMinMaxTValues("", "");
                connector.SetMinMaxFValues("Min = ", "Max = ");
                connector.SetStepValue("");

                return;
            }
            // Need to set maxF and minF
            bool first_iteration = true;
            // Clear dataGridView2 and chart
            connector.ClearDataGridView(2);
            connector.ClearChart();
            
            // Need to rows iteration
            int j = 0;
            // Building chart and dataGridView
            for (double i = minT; i <= maxT; i += step)
            {
                if (checkT)
                {
                    checkT = false;
                }
                double num1 = function_s(i).Item1;
                double num2 = function_s(i).Item2;
                connector.BuildDataGrid(2, i, j, num1, num2);
                connector.BuildChart(num1, num2);
                j++;
                // If first iteration set minF and maxF
                if (first_iteration)
                {
                    minF = num2;
                    maxF = num2;
                    first_iteration = false;
                }
                // Looking for minF and maxF
                if (maxF < num2)
                    maxF = num2;
                if (minF > num2)
                    minF = num2;
            }

            // Set MinF and MaxF labels
            connector.SetMinMaxFValues("Min = " + minF.ToString(), "Max = " + maxF.ToString());
        }

        // First Function
        private double function_f(double x)
        {
            return (Math.Exp(-2 * x) * Math.Pow(Math.Sin(x), 2));
        }

        // Second Function (paramertic)
        private Tuple<double, double> function_s(double t)
        {
            if (t < 0 || t > 1)
            {
                checkT = true;
                return new Tuple<double, double>(Double.NaN, Double.NaN);
            }

            return new Tuple<double, double>(Math.Pow(t, 1.0 / 3.0), Math.Pow((1 - t), 1.0 / 3.0));
        }

        public void parametricFunctionToolStripMenuItem()
        {
            // Set Visibility
            connector.SetVisibilityForGridView(false, true);
            connector.ClearDataGridView(2);
            connector.RemoveGridRows(2);

            bool readX = false, readY = false, readT = false;

            connector.ClearChart();
            // amount of strings (need it, bcs if we 'add-write-add' we 
            // will lose values)
            int count;
            using (StreamReader _sr = new StreamReader(@"C:\Users\WhiteSideOfDarkness\Desktop\Graph_Visual_Laba_3\Graph_Visual_Laba_3\Graph_Visual_Laba_3\ReadGraphParametric.txt", System.Text.Encoding.Default))
            {
                string tmp;
                count = 0;
                while ((tmp = _sr.ReadLine()) != null)
                {
                    count++;
                }
                _sr.Close();
            }

            bool first_read = true;

            using (StreamReader sr = new StreamReader(@"C:\Users\WhiteSideOfDarkness\Desktop\Graph_Visual_Laba_3\Graph_Visual_Laba_3\Graph_Visual_Laba_3\ReadGraphParametric.txt", System.Text.Encoding.Default))
            {
                string line;
                connector.AddRowToGridView(2 ,(int)count / 3);
                int j = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (readX && readY && readT)
                    {
                        readX = false; readY = false; readT = false;
                    }
                    if (!readT)
                    {
                        try
                        {
                            connector.SetValueToGrid(2, 0, j, Convert.ToDouble(line));
                        }
                        catch (FormatException ex)
                        {
                            Utils.ShowErrorMessage(ex.Message);
                            return;
                        }
                        readT = true;
                        continue;
                    }
                    if (!readX)
                    {
                        try
                        {
                            connector.SetValueToGrid(2, 1, j, Convert.ToDouble(line));
                        }
                        catch (FormatException ex)
                        {
                            Utils.ShowErrorMessage(ex.Message);
                            return;
                        }
                        if (first_read)
                        {
                          
                            minX = maxX = connector.GetValueFromGrid(2, 1, j);

                        }
                        double val = connector.GetValueFromGrid(2, 1, j);
                        if (maxX < val)
                            maxX = val;
                        if (minX > val)
                            minX = val;
                        readX = true;
                        continue;
                    }
                    else if (!readY)
                    {
                        try
                        {
                            connector.SetValueToGrid(2, 2, j, Convert.ToDouble(line));    
                        }
                        catch (FormatException ex)
                        {
                            Utils.ShowErrorMessage(ex.Message);
                            return;
                        }
                        if (first_read)
                        {
                            
                            minF = maxF = connector.GetValueFromGrid(2, 2, j);
                            first_read = false;
                        }
                        double val = connector.GetValueFromGrid(2, 2, j);
                        if (maxF < val)
                            maxF = val;
                        if (minF > val)
                            minF = val;

                        readY = true;
                        // We got t, X and Y, so draw it
                        connector.BuildChart(connector.GetValueFromGrid(2, 1, j), connector.GetValueFromGrid(2, 2, j));
                        j++;
                    }

                }
                connector.SetMinMaxFValues("Max = " + maxF.ToString(), "Min = " + minF.ToString());
            }

            connector.SetMinMaxXValues(minX.ToString(), maxX.ToString());
            connector.SetStepValue("");
            
            Form1.SimpleGraphUsed = false;
        }

        public void FunctionToolStripMenuItem()
        {
            connector.SetVisibilityForGridView(true, false);
            connector.ClearDataGridView(1);

            connector.RemoveGridRows(1);
            // To manage what was readed
            bool readX = false, readY = false;
            connector.ClearChart();
            // amount of strings (need it, bcs if we 'add-write-add' we 
            // will lose values)
            int count;
            // read file
            using (StreamReader _sr = new StreamReader(@"C:\Users\WhiteSideOfDarkness\Desktop\Graph_Visual_Laba_3\Graph_Visual_Laba_3\Graph_Visual_Laba_3\ReadGraph.txt", System.Text.Encoding.Default))
            {
                string tmp;
                count = 0;
                while ((tmp = _sr.ReadLine()) != null)
                {
                    count++;
                }
                _sr.Close();
            }
            // Need to set minF maxF
            bool first_read = true;

            using (StreamReader sr = new StreamReader(@"C:\Users\WhiteSideOfDarkness\Desktop\Graph_Visual_Laba_3\Graph_Visual_Laba_3\Graph_Visual_Laba_3\ReadGraph.txt", System.Text.Encoding.Default))
            {
                string line;
                // Add new rows
                connector.AddRowToGridView(1, (int)count / 2);
                // Need for rows iteration
                int j = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (readX && readY)
                    {
                        readX = false; readY = false;
                    }
                    if (!readX)
                    {
                        try
                        {
                            connector.SetValueToGrid(1, 0, j, Convert.ToDouble(line));
                        }
                        catch (FormatException ex)
                        {
                            Utils.ShowErrorMessage(ex.Message);
                            return;
                        }
                        if (first_read)
                        {
                            minX = maxX = connector.GetValueFromGrid(1, 0, j);
                        }
                        double val = connector.GetValueFromGrid(1, 0, j);
                        if (maxX < val)
                            maxX = val;
                        if (minX > val)
                            minX = val;

                        readX = true;
                        continue;
                    }
                    else if (!readY)
                    {
                        try
                        {
                            connector.SetValueToGrid(1, 1, j, Convert.ToDouble(line));
                        }
                        catch (FormatException ex)
                        {
                            Utils.ShowErrorMessage(ex.Message);
                            return;
                        }
                        if (first_read)
                        {
                            minF = maxF = connector.GetValueFromGrid(1, 1, j);
                            first_read = false;
                        }

                        double val = connector.GetValueFromGrid(1, 1, j);
                        if (maxF < val)
                            maxF = val;
                        if (minF > val)
                            minF = val;

                        readY = true;
                        // We got X and Y, so draw it
                        connector.BuildChart(connector.GetValueFromGrid(1, 0, j), connector.GetValueFromGrid(1, 1, j));
                        j++;
                    }
                }
                connector.SetMinMaxFValues("Max = " + maxF.ToString(), "Min = " + minF.ToString());
            }
            connector.SetMinMaxXValues(minX.ToString(), maxX.ToString());
            connector.SetStepValue("");
           
            Form1.SimpleGraphUsed = true;
      
        }
    }
}
