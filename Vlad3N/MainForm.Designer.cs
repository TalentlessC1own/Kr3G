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
            menuStrip = new MenuStrip();
            chartToolStripMenuItem = new ToolStripMenuItem();
            drawToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            removeLastToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            initialToolStripMenuItem = new ToolStripMenuItem();
            dataToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            logPathToolStripMenuItem = new ToolStripMenuItem();
            defaultToolStripMenuItem = new ToolStripMenuItem();
            anotherToolStripMenuItem = new ToolStripMenuItem();
            greatingsToolStripMenuItem = new ToolStripMenuItem();
            onToolStripMenuItem = new ToolStripMenuItem();
            backColorToolStripMenuItem = new ToolStripMenuItem();
            textColorToolStripMenuItem = new ToolStripMenuItem();
            formula = new PictureBox();
            chart = new ScottPlot.FormsPlot();
            parametrs = new GroupBox();
            textBoxR = new TextBox();
            textBoxRightBorder = new TextBox();
            textBoxStep = new TextBox();
            textBoxLeftBorder = new TextBox();
            labelRightBorder = new Label();
            labelStep = new Label();
            labelR = new Label();
            labelLeftBorder = new Label();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)formula).BeginInit();
            parametrs.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { chartToolStripMenuItem, fileToolStripMenuItem, exitToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // chartToolStripMenuItem
            // 
            chartToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drawToolStripMenuItem, clearToolStripMenuItem, removeLastToolStripMenuItem });
            chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            chartToolStripMenuItem.Size = new Size(48, 20);
            chartToolStripMenuItem.Text = "Chart";
            // 
            // drawToolStripMenuItem
            // 
            drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            drawToolStripMenuItem.Size = new Size(138, 22);
            drawToolStripMenuItem.Text = "Draw";
            drawToolStripMenuItem.Click += drawToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(138, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // removeLastToolStripMenuItem
            // 
            removeLastToolStripMenuItem.Name = "removeLastToolStripMenuItem";
            removeLastToolStripMenuItem.Size = new Size(138, 22);
            removeLastToolStripMenuItem.Text = "Remove last";
            removeLastToolStripMenuItem.Click += removeLastToolStripMenuItem_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { initialToolStripMenuItem, dataToolStripMenuItem });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // initialToolStripMenuItem
            // 
            initialToolStripMenuItem.Name = "initialToolStripMenuItem";
            initialToolStripMenuItem.Size = new Size(103, 22);
            initialToolStripMenuItem.Text = "Initial";
            initialToolStripMenuItem.Click += initialToolStripMenuItem_Click;
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(103, 22);
            dataToolStripMenuItem.Text = "Data";
            dataToolStripMenuItem.Click += dataToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logPathToolStripMenuItem, greatingsToolStripMenuItem, backColorToolStripMenuItem, textColorToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // logPathToolStripMenuItem
            // 
            logPathToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { defaultToolStripMenuItem, anotherToolStripMenuItem });
            logPathToolStripMenuItem.Name = "logPathToolStripMenuItem";
            logPathToolStripMenuItem.Size = new Size(180, 22);
            logPathToolStripMenuItem.Text = "Log Path";
            
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.CheckOnClick = true;
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(180, 22);
            defaultToolStripMenuItem.Text = "default";
            defaultToolStripMenuItem.Click += defaultToolStripMenuItem_Click;
            // 
            // anotherToolStripMenuItem
            // 
            anotherToolStripMenuItem.CheckOnClick = true;
            anotherToolStripMenuItem.Name = "anotherToolStripMenuItem";
            anotherToolStripMenuItem.Size = new Size(180, 22);
            anotherToolStripMenuItem.Text = "another";
            anotherToolStripMenuItem.Click += anotherToolStripMenuItem_Click;
            // 
            // greatingsToolStripMenuItem
            // 
            greatingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { onToolStripMenuItem });
            greatingsToolStripMenuItem.Name = "greatingsToolStripMenuItem";
            greatingsToolStripMenuItem.Size = new Size(180, 22);
            greatingsToolStripMenuItem.Text = "Greetings";
            // 
            // onToolStripMenuItem
            // 
            onToolStripMenuItem.Checked = true;
            onToolStripMenuItem.CheckOnClick = true;
            onToolStripMenuItem.CheckState = CheckState.Checked;
            onToolStripMenuItem.Name = "onToolStripMenuItem";
            onToolStripMenuItem.Size = new Size(90, 22);
            onToolStripMenuItem.Text = "On";
            onToolStripMenuItem.Click += onToolStripMenuItem_Click;
            // 
            // backColorToolStripMenuItem
            // 
            backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            backColorToolStripMenuItem.Size = new Size(180, 22);
            backColorToolStripMenuItem.Text = "Back Color";
            backColorToolStripMenuItem.Click += backColorToolStripMenuItem_Click;
            // 
            // textColorToolStripMenuItem
            // 
            textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            textColorToolStripMenuItem.Size = new Size(180, 22);
            textColorToolStripMenuItem.Text = "Text Color";
            textColorToolStripMenuItem.Click += textColorToolStripMenuItem_Click;
            // 
            // formula
            // 
            formula.Image = (Image)resources.GetObject("formula.Image");
            formula.Location = new Point(2, 52);
            formula.Name = "formula";
            formula.Size = new Size(330, 62);
            formula.SizeMode = PictureBoxSizeMode.Zoom;
            formula.TabIndex = 1;
            formula.TabStop = false;
            // 
            // chart
            // 
            chart.AutoSize = true;
            chart.Location = new Point(333, 27);
            chart.Margin = new Padding(4, 3, 4, 3);
            chart.Name = "chart";
            chart.Size = new Size(467, 423);
            chart.TabIndex = 2;
            // 
            // parametrs
            // 
            parametrs.AutoSize = true;
            parametrs.Controls.Add(textBoxR);
            parametrs.Controls.Add(textBoxRightBorder);
            parametrs.Controls.Add(textBoxStep);
            parametrs.Controls.Add(textBoxLeftBorder);
            parametrs.Controls.Add(labelRightBorder);
            parametrs.Controls.Add(labelStep);
            parametrs.Controls.Add(labelR);
            parametrs.Controls.Add(labelLeftBorder);
            parametrs.Location = new Point(0, 148);
            parametrs.MaximumSize = new Size(999999, 9999999);
            parametrs.Name = "parametrs";
            parametrs.Size = new Size(332, 306);
            parametrs.TabIndex = 3;
            parametrs.TabStop = false;
            parametrs.Text = "Parametrs";
            // 
            // textBoxR
            // 
            textBoxR.Location = new Point(202, 241);
            textBoxR.Name = "textBoxR";
            textBoxR.Size = new Size(100, 23);
            textBoxR.TabIndex = 11;
            // 
            // textBoxRightBorder
            // 
            textBoxRightBorder.Location = new Point(202, 111);
            textBoxRightBorder.Name = "textBoxRightBorder";
            textBoxRightBorder.Size = new Size(100, 23);
            textBoxRightBorder.TabIndex = 10;
            // 
            // textBoxStep
            // 
            textBoxStep.Location = new Point(202, 178);
            textBoxStep.Name = "textBoxStep";
            textBoxStep.Size = new Size(100, 23);
            textBoxStep.TabIndex = 9;
            // 
            // textBoxLeftBorder
            // 
            textBoxLeftBorder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLeftBorder.Location = new Point(202, 46);
            textBoxLeftBorder.Name = "textBoxLeftBorder";
            textBoxLeftBorder.Size = new Size(100, 23);
            textBoxLeftBorder.TabIndex = 8;
            // 
            // labelRightBorder
            // 
            labelRightBorder.AutoSize = true;
            labelRightBorder.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelRightBorder.Location = new Point(24, 102);
            labelRightBorder.Name = "labelRightBorder";
            labelRightBorder.Size = new Size(167, 33);
            labelRightBorder.TabIndex = 7;
            labelRightBorder.Text = "right border ";
            // 
            // labelStep
            // 
            labelStep.AutoSize = true;
            labelStep.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelStep.Location = new Point(24, 168);
            labelStep.Name = "labelStep";
            labelStep.Size = new Size(62, 33);
            labelStep.TabIndex = 6;
            labelStep.Text = "step";
            // 
            // labelR
            // 
            labelR.AutoSize = true;
            labelR.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelR.Location = new Point(24, 231);
            labelR.Name = "labelR";
            labelR.Size = new Size(26, 33);
            labelR.TabIndex = 5;
            labelR.Text = "r";
            // 
            // labelLeftBorder
            // 
            labelLeftBorder.AutoSize = true;
            labelLeftBorder.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelLeftBorder.Location = new Point(24, 36);
            labelLeftBorder.Name = "labelLeftBorder";
            labelLeftBorder.Size = new Size(148, 33);
            labelLeftBorder.TabIndex = 4;
            labelLeftBorder.Text = "left border ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 470);
            Controls.Add(parametrs);
            Controls.Add(chart);
            Controls.Add(formula);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MaximumSize = new Size(999998, 9999992);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "MainForm";
            RightToLeftLayout = true;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)formula).EndInit();
            parametrs.ResumeLayout(false);
            parametrs.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
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
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem logPathToolStripMenuItem;
        private ToolStripMenuItem greatingsToolStripMenuItem;
        private ToolStripMenuItem onToolStripMenuItem;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private ToolStripMenuItem anotherToolStripMenuItem;
        private ToolStripMenuItem backColorToolStripMenuItem;
        private ToolStripMenuItem textColorToolStripMenuItem;
    }
}