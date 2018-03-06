namespace Graph_Visual_Laba_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametricFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parametricFunctionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printParametricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SetT_button = new System.Windows.Forms.Button();
            this.T_max = new System.Windows.Forms.TextBox();
            this.T_Scope = new System.Windows.Forms.Label();
            this.T_min = new System.Windows.Forms.TextBox();
            this.MinF = new System.Windows.Forms.Label();
            this.MaxF = new System.Windows.Forms.Label();
            this.Function_S = new System.Windows.Forms.Button();
            this.Function_F = new System.Windows.Forms.Button();
            this.SetX_button = new System.Windows.Forms.Button();
            this.Step_Value = new System.Windows.Forms.TextBox();
            this.Step = new System.Windows.Forms.Label();
            this.X_max = new System.Windows.Forms.TextBox();
            this.X_min = new System.Windows.Forms.TextBox();
            this.X_Scope = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readFromFileToolStripMenuItem,
            this.writeToFileToolStripMenuItem,
            this.saveChartToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // readFromFileToolStripMenuItem
            // 
            this.readFromFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionToolStripMenuItem,
            this.parametricFunctionToolStripMenuItem});
            this.readFromFileToolStripMenuItem.Name = "readFromFileToolStripMenuItem";
            this.readFromFileToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.readFromFileToolStripMenuItem.Text = "Read from file";
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.functionToolStripMenuItem.Text = "Function";
            this.functionToolStripMenuItem.Click += new System.EventHandler(this.functionToolStripMenuItem_Click);
            // 
            // parametricFunctionToolStripMenuItem
            // 
            this.parametricFunctionToolStripMenuItem.Name = "parametricFunctionToolStripMenuItem";
            this.parametricFunctionToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.parametricFunctionToolStripMenuItem.Text = "Parametric Function";
            this.parametricFunctionToolStripMenuItem.Click += new System.EventHandler(this.parametricFunctionToolStripMenuItem_Click);
            // 
            // writeToFileToolStripMenuItem
            // 
            this.writeToFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionToolStripMenuItem1,
            this.parametricFunctionToolStripMenuItem1});
            this.writeToFileToolStripMenuItem.Name = "writeToFileToolStripMenuItem";
            this.writeToFileToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.writeToFileToolStripMenuItem.Text = "Write to file";
            // 
            // functionToolStripMenuItem1
            // 
            this.functionToolStripMenuItem1.Name = "functionToolStripMenuItem1";
            this.functionToolStripMenuItem1.Size = new System.Drawing.Size(239, 24);
            this.functionToolStripMenuItem1.Text = "Function";
            this.functionToolStripMenuItem1.Click += new System.EventHandler(this.functionToolStripMenuItem1_Click);
            // 
            // parametricFunctionToolStripMenuItem1
            // 
            this.parametricFunctionToolStripMenuItem1.Name = "parametricFunctionToolStripMenuItem1";
            this.parametricFunctionToolStripMenuItem1.Size = new System.Drawing.Size(239, 24);
            this.parametricFunctionToolStripMenuItem1.Text = "Parametric Function";
            this.parametricFunctionToolStripMenuItem1.Click += new System.EventHandler(this.parametricFunctionToolStripMenuItem1_Click);
            // 
            // saveChartToolStripMenuItem
            // 
            this.saveChartToolStripMenuItem.Name = "saveChartToolStripMenuItem";
            this.saveChartToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.saveChartToolStripMenuItem.Text = "Save Chart";
            this.saveChartToolStripMenuItem.Click += new System.EventHandler(this.saveChartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(191, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withNetToolStripMenuItem,
            this.maximizeToolStripMenuItem,
            this.printToolStripMenuItem,
            this.printParametricToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // withNetToolStripMenuItem
            // 
            this.withNetToolStripMenuItem.Name = "withNetToolStripMenuItem";
            this.withNetToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.withNetToolStripMenuItem.Text = "With Net";
            this.withNetToolStripMenuItem.Click += new System.EventHandler(this.withNetToolStripMenuItem_Click);
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.maximizeToolStripMenuItem.Text = "Maximize";
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.maximizeToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.printToolStripMenuItem.Text = "Build Simple";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // printParametricToolStripMenuItem
            // 
            this.printParametricToolStripMenuItem.Name = "printParametricToolStripMenuItem";
            this.printParametricToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.printParametricToolStripMenuItem.Text = "Build Parametric";
            this.printParametricToolStripMenuItem.Click += new System.EventHandler(this.printParametricToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SetT_button);
            this.splitContainer1.Panel1.Controls.Add(this.T_max);
            this.splitContainer1.Panel1.Controls.Add(this.T_Scope);
            this.splitContainer1.Panel1.Controls.Add(this.T_min);
            this.splitContainer1.Panel1.Controls.Add(this.MinF);
            this.splitContainer1.Panel1.Controls.Add(this.MaxF);
            this.splitContainer1.Panel1.Controls.Add(this.Function_S);
            this.splitContainer1.Panel1.Controls.Add(this.Function_F);
            this.splitContainer1.Panel1.Controls.Add(this.SetX_button);
            this.splitContainer1.Panel1.Controls.Add(this.Step_Value);
            this.splitContainer1.Panel1.Controls.Add(this.Step);
            this.splitContainer1.Panel1.Controls.Add(this.X_max);
            this.splitContainer1.Panel1.Controls.Add(this.X_min);
            this.splitContainer1.Panel1.Controls.Add(this.X_Scope);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(905, 349);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 9;
            // 
            // SetT_button
            // 
            this.SetT_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetT_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SetT_button.Location = new System.Drawing.Point(15, 244);
            this.SetT_button.Name = "SetT_button";
            this.SetT_button.Size = new System.Drawing.Size(177, 27);
            this.SetT_button.TabIndex = 25;
            this.SetT_button.Text = "Set T";
            this.SetT_button.UseVisualStyleBackColor = true;
            this.SetT_button.Click += new System.EventHandler(this.SetT_button_Click);
            // 
            // T_max
            // 
            this.T_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.T_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.T_max.Location = new System.Drawing.Point(133, 86);
            this.T_max.Name = "T_max";
            this.T_max.Size = new System.Drawing.Size(49, 26);
            this.T_max.TabIndex = 24;
            // 
            // T_Scope
            // 
            this.T_Scope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.T_Scope.AutoSize = true;
            this.T_Scope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Scope.Location = new System.Drawing.Point(69, 89);
            this.T_Scope.Name = "T_Scope";
            this.T_Scope.Size = new System.Drawing.Size(45, 20);
            this.T_Scope.TabIndex = 23;
            this.T_Scope.Text = "< t <";
            // 
            // T_min
            // 
            this.T_min.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.T_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.T_min.Location = new System.Drawing.Point(12, 86);
            this.T_min.Name = "T_min";
            this.T_min.Size = new System.Drawing.Size(51, 26);
            this.T_min.TabIndex = 22;
            // 
            // MinF
            // 
            this.MinF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinF.AutoSize = true;
            this.MinF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinF.Location = new System.Drawing.Point(12, 156);
            this.MinF.Name = "MinF";
            this.MinF.Size = new System.Drawing.Size(52, 20);
            this.MinF.TabIndex = 21;
            this.MinF.Text = "Min =";
            // 
            // MaxF
            // 
            this.MaxF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxF.AutoSize = true;
            this.MaxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxF.Location = new System.Drawing.Point(12, 124);
            this.MaxF.Name = "MaxF";
            this.MaxF.Size = new System.Drawing.Size(56, 20);
            this.MaxF.TabIndex = 20;
            this.MaxF.Text = "Max =";
            // 
            // Function_S
            // 
            this.Function_S.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Function_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Function_S.Location = new System.Drawing.Point(15, 310);
            this.Function_S.Name = "Function_S";
            this.Function_S.Size = new System.Drawing.Size(177, 27);
            this.Function_S.TabIndex = 19;
            this.Function_S.Text = "Second Function";
            this.Function_S.UseVisualStyleBackColor = true;
            this.Function_S.Click += new System.EventHandler(this.Function_S_Click);
            // 
            // Function_F
            // 
            this.Function_F.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Function_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Function_F.Location = new System.Drawing.Point(15, 277);
            this.Function_F.Name = "Function_F";
            this.Function_F.Size = new System.Drawing.Size(177, 27);
            this.Function_F.TabIndex = 18;
            this.Function_F.Text = "First Function";
            this.Function_F.UseVisualStyleBackColor = true;
            this.Function_F.Click += new System.EventHandler(this.Function_F_Click);
            // 
            // SetX_button
            // 
            this.SetX_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetX_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SetX_button.Location = new System.Drawing.Point(15, 211);
            this.SetX_button.Name = "SetX_button";
            this.SetX_button.Size = new System.Drawing.Size(177, 27);
            this.SetX_button.TabIndex = 17;
            this.SetX_button.Text = "Set X";
            this.SetX_button.UseVisualStyleBackColor = true;
            this.SetX_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Step_Value
            // 
            this.Step_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Step_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Step_Value.Location = new System.Drawing.Point(96, 50);
            this.Step_Value.Name = "Step_Value";
            this.Step_Value.Size = new System.Drawing.Size(86, 26);
            this.Step_Value.TabIndex = 16;
            // 
            // Step
            // 
            this.Step.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Step.AutoSize = true;
            this.Step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step.Location = new System.Drawing.Point(12, 53);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(67, 20);
            this.Step.TabIndex = 15;
            this.Step.Text = "Step = ";
            // 
            // X_max
            // 
            this.X_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.X_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.X_max.Location = new System.Drawing.Point(133, 16);
            this.X_max.Name = "X_max";
            this.X_max.Size = new System.Drawing.Size(49, 26);
            this.X_max.TabIndex = 11;
            // 
            // X_min
            // 
            this.X_min.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.X_min.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.X_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.X_min.Location = new System.Drawing.Point(15, 16);
            this.X_min.Name = "X_min";
            this.X_min.Size = new System.Drawing.Size(48, 26);
            this.X_min.TabIndex = 10;
            // 
            // X_Scope
            // 
            this.X_Scope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.X_Scope.AutoSize = true;
            this.X_Scope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X_Scope.Location = new System.Drawing.Point(69, 19);
            this.X_Scope.Name = "X_Scope";
            this.X_Scope.Size = new System.Drawing.Size(51, 20);
            this.X_Scope.TabIndex = 9;
            this.X_Scope.Text = "< X <";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(313, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(384, 349);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(132, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(181, 349);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(132, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 377);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToFileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox Step_Value;
        private System.Windows.Forms.Label Step;
        private System.Windows.Forms.TextBox X_max;
        private System.Windows.Forms.TextBox X_min;
        private System.Windows.Forms.Label X_Scope;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SetX_button;
        private System.Windows.Forms.Button Function_S;
        private System.Windows.Forms.Button Function_F;
        private System.Windows.Forms.Label MinF;
        private System.Windows.Forms.Label MaxF;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametricFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parametricFunctionToolStripMenuItem1;
        private System.Windows.Forms.TextBox T_max;
        private System.Windows.Forms.Label T_Scope;
        private System.Windows.Forms.TextBox T_min;
        private System.Windows.Forms.Button SetT_button;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withNetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printParametricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

