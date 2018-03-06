using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graph_Visual_Laba_3
{
    public partial class Form1 : Form, UIConnector
    {
        // Using at the moment simple or parametric
        public static bool SimpleGraphUsed = false;     
        // Without Net  pressed
        bool NetUsed = false;
        // Maximized pressed
        bool Maximized = false;
        FunctionCalculation calculator;
        public Form1()
        {
            InitializeComponent();
            // Maximized Window
            WindowState = FormWindowState.Maximized;
            // Hide dataGredView2
            dataGridView2.Visible = false;
            dataGridView1.Columns.Add("", "");
            dataGridView2.Columns.Add("", "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculator = new FunctionCalculation(this);
            // Add columns for simple graph
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "X";
            dataGridView1.Columns[0].HeaderText = "X";
            dataGridView1.Columns[1].Name = "Y";
            dataGridView1.Columns[1].HeaderText = "Y";
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 40;
            // Add columns for parametric graph
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "t";
            dataGridView2.Columns[0].HeaderText = "t";
            dataGridView2.Columns[1].Name = "X";
            dataGridView2.Columns[1].HeaderText = "X";
            dataGridView2.Columns[2].Name = "Y";
            dataGridView2.Columns[2].HeaderText = "Y";
            dataGridView2.Columns[0].Width = 35;
            dataGridView2.Columns[1].Width = 50;
            dataGridView2.Columns[2].Width = 50;
            // Settins chart
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
        }

        private void Function_F_Click(object sender, EventArgs e)
        {
            calculator.CalculateFunctionF();
        }

        private void Function_S_Click(object sender, EventArgs e)
        {
            calculator.CalculateFunctionF();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            // Set Visibility
            SetVisibilityForGridView(true, false);

            // Set Visibility
            SetVisibilityForGridView(false, true);
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;

            // Check input
            if (CorectnessChecker.CheckT(T_min.Text, T_max.Text, Step_Value.Text))
            {
                SetMinMaxXValues("", "");
                SetStepValue("");
                return;
            }
           
            // Clear chart
            chart1.Series[0].Points.Clear();
            // Remove rows
            while(dataGridView1.Rows.Count != 1) dataGridView1.Rows.RemoveAt(0);

            // Add new rows
            dataGridView1.Rows.Add(Utils.GetCountOfPoints(X_min.Text, X_max.Text, Step_Value.Text));
            // Set graph
            SimpleGraphUsed = true;       
        }

        private void SetT_button_Click(object sender, EventArgs e)
        {
            // Set Visibility
            SetVisibilityForGridView(false, true);
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;

            // Check input
            if (CorectnessChecker.CheckT(T_min.Text, T_max.Text, Step_Value.Text))
            {
                SetMinMaxTValues("", "");
                SetStepValue("");
                return;
            }
           
            // Clear chart
            chart1.Series[0].Points.Clear();
            // Remove rows
            while (dataGridView2.Rows.Count != 1) dataGridView2.Rows.RemoveAt(0);
            // Add new rows
            dataGridView2.Rows.Add(Utils.GetCountOfPoints(X_min.Text, X_max.Text, Step_Value.Text));
            // Set graph
            SimpleGraphUsed = false;
        }



        private void functionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculator.FunctionToolStripMenuItem();
        }

        private void functionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!SimpleGraphUsed)
            {
                Utils.ShowErrorMessage("Please set X first!");
                return;
            }
            // Write dataGridView
            using (StreamWriter sw = new StreamWriter(@"D:\Visual Studio\Visual Studio C# Projects\Graph_Visual_Laba_3\Graph_Visual_Laba_3\GraphResults.txt", true, System.Text.Encoding.Default))
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    sw.WriteLine("X = " + dataGridView1[0, i].Value.ToString() + " Y = " + dataGridView1[1, i].Value.ToString());
                }
                sw.WriteLine("-----------------------------------------------------------");
            }
        }

        private void parametricFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculator.parametricFunctionToolStripMenuItem();
        }

        private void parametricFunctionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (SimpleGraphUsed)
            {
                Utils.ShowErrorMessage("Please set T first!");
                return;
            }
            // Writing
            using (StreamWriter sw = new StreamWriter(@"C:\Users\WhiteSideOfDarkness\Desktop\Graph_Visual_Laba_3\Graph_Visual_Laba_3\Graph_Visual_Laba_3\GraphResultsParametric.txt", true, System.Text.Encoding.Default))
            {
                for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                {
                    sw.WriteLine("T = " + dataGridView2[0,i].Value.ToString() + " X = " + dataGridView2[1, i].Value.ToString() + " Y = " + dataGridView2[2, i].Value.ToString());
                }
                sw.WriteLine("-----------------------------------------------------------");
            }
            MessageBox.Show("Data added to file!", "Complete!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void withNetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!NetUsed)
            {
                // Show net
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                withNetToolStripMenuItem.Text = "Without net";
                NetUsed = true;
            }
            else
            {
                // Hide net
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                withNetToolStripMenuItem.Text = "With net";
                NetUsed = false;
            }
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Maximized)
            {
                // Maximize
                chart1.ChartAreas[0].AxisX.ScaleView.Zoom(1, 2);
                chart1.ChartAreas[0].AxisY.ScaleView.Zoom(1, 2);
                chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                Maximized = true;
                maximizeToolStripMenuItem.Text = "Minimize";
            }
            else
            {
                // Minimize
                chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = false;
                Maximized = false;
                maximizeToolStripMenuItem.Text = "Maximize";
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!SimpleGraphUsed)
            {
                Utils.ShowErrorMessage("Please set X first!");
                return;
            }
            // Clear chart
            chart1.Series[0].Points.Clear();
            // Check count of cells
            if (dataGridView1.SelectedCells.Count % 2 != 0)
            {
                Utils.ShowErrorMessage("Wrong select, try again!");
                return;
            }
            double x = 0;
            double y = 0;
            bool readX = false, readY = false;
            // Same algorithm like reading
            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            {
                if (readX && readY)
                {
                    readX = false; readY = false;
                }
                if (!readX)
                {
                    x = (double)dataGridView1.SelectedCells[i].Value;
                    readX = true;
                    continue;
                }
                else if(!readY)
                {
                    y = (double)dataGridView1.SelectedCells[i].Value;

                    chart1.Series[0].Points.AddXY(x, y);
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                    readY = true;
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Graph \nVersion 3.2.2351 Update 1 \n(c) My Corporation. \nAll rights reserved.", "About GRAPH", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void printParametricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SimpleGraphUsed)
            {
                Utils.ShowErrorMessage("Please set T first!");
                return;
            }
            chart1.Series[0].Points.Clear();
            // Check count
            if(dataGridView2.SelectedCells.Count%3 != 0)
            {
                Utils.ShowErrorMessage("Wrong select, try again!");
                return;
            }

            double x = 0;
            double y = 0;
            bool readX = false, readY = false, readT =false;
            // Same algorithm like reading parametric
            for (int i = 0; i < dataGridView2.SelectedCells.Count; i++)
            {
                if (readX && readY && readT)
                {
                    readX = false; readY = false; readT = false;
                }
                if(!readT)
                {
                    readT = true;
                    continue;
                }
                if (!readX)
                {
                    x = (double)dataGridView2.SelectedCells[i].Value;
                    readX = true;
                    continue;
                }
                else if (!readY)
                {
                    y = (double)dataGridView2.SelectedCells[i].Value;

                    chart1.Series[0].Points.AddXY(x, y);
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                    readY = true;
                }
            }

        }

        private void saveChartToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            // Saving Image
            chart1.SaveImage("C:\\Users\\WhiteSideOfDarkness\\Desktop\\Graph_Visual_Laba_3\\Graph_Visual_Laba_3\\Charts\\" + DateTime.Now.ToString("dd/MM/yyyy HH_mm_ss tt") + ".png", ChartImageFormat.Png);
            MessageBox.Show("Chart was saved!", "Chart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetVisibilityForGridView(bool visibility1, bool visibility2)
        {
            dataGridView1.Visible = visibility1;
            dataGridView2.Visible = visibility2;
        }

        public void ClearChart()
        {
            chart1.Series[0].Points.Clear();
        }

        public void SetMinMaxTValues(string min, string max)
        {
            T_min.Text = min;
            T_max.Text = max;
        }

        public void SetMinMaxFValues(string min, string max)
        {
            MinF.Text = min;
            MaxF.Text = max;
        }

        public void SetStepValue(string value)
        {
            Step_Value.Text = value;
        }

        public void SetMinMaxXValues(string min, string max)
        {
            X_min.Text = min;
            X_max.Text = max;
        }

        public void ClearDataGridView(int num)
        {
           if (num == 1)
           {
                dataGridView1.ClearSelection();
           }
           else if (num == 2)
           {
                dataGridView2.ClearSelection();
           }
        }

        public void BuildChart(double i, double result)
        {
            chart1.Series[0].Points.AddXY(i,result);
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        public void BuildDataGrid(int ver, double i, int j, double res1, double? res2)
        {
            if (ver == 1)
            {
                dataGridView1[0, j].Value = i;
                dataGridView1[1, j].Value = res1;

            }
            else if (ver == 2)
            {
                dataGridView2[0, j].Value = i;
                dataGridView2[1, j].Value = res1;
                dataGridView2[2, j].Value = res2;
            }
        }

        public void RemoveGridRows(int ver)
        {
            if (ver == 1)
            {
                while (dataGridView1.Rows.Count != 1) dataGridView1.Rows.RemoveAt(0);
            }
            else if (ver == 2)
            {
                while (dataGridView2.Rows.Count != 1) dataGridView2.Rows.RemoveAt(0);
            }
        }

        public void SetValueToGrid(int ver, int i, int j, double value)
        {
            if (ver == 1)
            {

            }
            else if (ver == 2)
            {
                dataGridView2[i, j].Value = value;
            }
        }

        public void AddRowToGridView(int ver, int row)
        {
            if (ver == 1)
            {
                dataGridView1.Rows.Add(row);
            }
            else if (ver == 2)
            {
                dataGridView2.Rows.Add(row);
            }
        }

        public double GetValueFromGrid(int ver, int i, int j)
        {
            if (ver == 1)
            {
                return (double)dataGridView1[i, j].Value;
            }
            else 
            {
                return (double)dataGridView2[i, j].Value;
            }
        }
    }
}
