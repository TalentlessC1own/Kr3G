namespace Kr3G
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formula = new System.Windows.Forms.PictureBox();
            this.chart = new ScottPlot.FormsPlot();
            this.parametrs = new System.Windows.Forms.GroupBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxRightBorder = new System.Windows.Forms.TextBox();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.textBoxLeftBorder = new System.Windows.Forms.TextBox();
            this.labelRightBorder = new System.Windows.Forms.Label();
            this.labelStep = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelLeftBorder = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formula)).BeginInit();
            this.parametrs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.removeLastToolStripMenuItem});
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.drawToolStripMenuItem.Text = "Draw";
            this.drawToolStripMenuItem.Click += new System.EventHandler(this.drawToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // removeLastToolStripMenuItem
            // 
            this.removeLastToolStripMenuItem.Name = "removeLastToolStripMenuItem";
            this.removeLastToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.removeLastToolStripMenuItem.Text = "Remove last";
            this.removeLastToolStripMenuItem.Click += new System.EventHandler(this.removeLastToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initialToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // initialToolStripMenuItem
            // 
            this.initialToolStripMenuItem.Name = "initialToolStripMenuItem";
            this.initialToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.initialToolStripMenuItem.Text = "Initial";
            this.initialToolStripMenuItem.Click += new System.EventHandler(this.initialToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.dataToolStripMenuItem.Text = "Data";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formula
            // 
            this.formula.Image = ((System.Drawing.Image)(resources.GetObject("formula.Image")));
            this.formula.Location = new System.Drawing.Point(3, 87);
            this.formula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(471, 103);
            this.formula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.formula.TabIndex = 1;
            this.formula.TabStop = false;
            // 
            // chart
            // 
            this.chart.AutoSize = true;
            this.chart.Location = new System.Drawing.Point(476, 45);
            this.chart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(667, 705);
            this.chart.TabIndex = 2;
            // 
            // parametrs
            // 
            this.parametrs.AutoSize = true;
            this.parametrs.Controls.Add(this.textBoxR);
            this.parametrs.Controls.Add(this.textBoxRightBorder);
            this.parametrs.Controls.Add(this.textBoxStep);
            this.parametrs.Controls.Add(this.textBoxLeftBorder);
            this.parametrs.Controls.Add(this.labelRightBorder);
            this.parametrs.Controls.Add(this.labelStep);
            this.parametrs.Controls.Add(this.labelR);
            this.parametrs.Controls.Add(this.labelLeftBorder);
            this.parametrs.Location = new System.Drawing.Point(0, 247);
            this.parametrs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parametrs.MaximumSize = new System.Drawing.Size(1428570, 16666665);
            this.parametrs.Name = "parametrs";
            this.parametrs.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parametrs.Size = new System.Drawing.Size(474, 510);
            this.parametrs.TabIndex = 3;
            this.parametrs.TabStop = false;
            this.parametrs.Text = "Parametrs";
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(289, 402);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(141, 31);
            this.textBoxR.TabIndex = 11;
            // 
            // textBoxRightBorder
            // 
            this.textBoxRightBorder.Location = new System.Drawing.Point(289, 185);
            this.textBoxRightBorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRightBorder.Name = "textBoxRightBorder";
            this.textBoxRightBorder.Size = new System.Drawing.Size(141, 31);
            this.textBoxRightBorder.TabIndex = 10;
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(289, 297);
            this.textBoxStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(141, 31);
            this.textBoxStep.TabIndex = 9;
            // 
            // textBoxLeftBorder
            // 
            this.textBoxLeftBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLeftBorder.Location = new System.Drawing.Point(289, 77);
            this.textBoxLeftBorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLeftBorder.Name = "textBoxLeftBorder";
            this.textBoxLeftBorder.Size = new System.Drawing.Size(141, 31);
            this.textBoxLeftBorder.TabIndex = 8;
            // 
            // labelRightBorder
            // 
            this.labelRightBorder.AutoSize = true;
            this.labelRightBorder.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelRightBorder.Location = new System.Drawing.Point(34, 170);
            this.labelRightBorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRightBorder.Name = "labelRightBorder";
            this.labelRightBorder.Size = new System.Drawing.Size(251, 51);
            this.labelRightBorder.TabIndex = 7;
            this.labelRightBorder.Text = "right border ";
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelStep.Location = new System.Drawing.Point(34, 280);
            this.labelStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(93, 51);
            this.labelStep.TabIndex = 6;
            this.labelStep.Text = "step";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelR.Location = new System.Drawing.Point(34, 385);
            this.labelR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(39, 51);
            this.labelR.TabIndex = 5;
            this.labelR.Text = "r";
            // 
            // labelLeftBorder
            // 
            this.labelLeftBorder.AutoSize = true;
            this.labelLeftBorder.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelLeftBorder.Location = new System.Drawing.Point(34, 60);
            this.labelLeftBorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLeftBorder.Name = "labelLeftBorder";
            this.labelLeftBorder.Size = new System.Drawing.Size(223, 51);
            this.labelLeftBorder.TabIndex = 4;
            this.labelLeftBorder.Text = "left border ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1143, 783);
            this.Controls.Add(this.parametrs);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.formula);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1428561, 16666627);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formula)).EndInit();
            this.parametrs.ResumeLayout(false);
            this.parametrs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chartToolStripMenuItem;
        private ToolStripMenuItem drawToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem initialToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private PictureBox formula;
        private ScottPlot.FormsPlot chart;
        private GroupBox parametrs;
        private Label labelLeftBorder;
        private Label labelRightBorder;
        private Label labelStep;
        private Label labelR;
        private TextBox textBoxR;
        private TextBox textBoxRightBorder;
        private TextBox textBoxStep;
        private TextBox textBoxLeftBorder;
        private ToolStripMenuItem removeLastToolStripMenuItem;
        private ToolStripMenuItem dataToolStripMenuItem;
       
    }
}