using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Security.Policy;

namespace Kr3G
{
    public interface IMainForm : IView
    {
        string LeftBorder { get; set; }
        string RightBorder { get; set; }
        string Step { get; set; }
        string R { get; set; }


        string FilePath { get; }


        string LogPath { get; set; }
        Image Image { get; }

        bool ShowGreetings { get; set; }
        Color TextColor { get; set; }

        Color BackGroundColor { get; set; }

        void Draw(GraphData graphData, string _label);

        void ClearFields();


        event EventHandler TryDraw;
        event EventHandler Clear;
        event EventHandler Removelast;
        event EventHandler OpenFile;
        event EventHandler SaveInitialData;
        event EventHandler SaveData;
        event EventHandler NoData;
        event EventHandler SettingsChanged;
        event EventHandler? Invalid—olors;


    }

    public partial class MainForm : Form, IMainForm
    {
        [Required]
        public string LeftBorder
        {
            get => textBoxLeftBorder.Text;
            set
            {
                textBoxLeftBorder.Text = value;
                this.Refresh();
            }
        }

        public string RightBorder
        {
            get => textBoxRightBorder.Text;
            set
            {
                textBoxRightBorder.Text = value;
                this.Refresh();
            }
        }

        public string Step
        {
            get => textBoxStep.Text;
            set
            {
                textBoxStep.Text = value;
                this.Refresh();
            }
        }

        public string R
        {
            get => textBoxR.Text;
            set
            {
                textBoxR.Text = value;
                this.Refresh();
            }
        }

        public string FilePath
        {
            get;
            private set;
        }

        public Image Image
        {
            get
            {
                using var ms = new MemoryStream(chart.Plot.GetImageBytes(), 0, chart.Plot.GetImageBytes().Length);
                Image image = Image.FromStream(ms, true);

                return image;
            }

        }

        public bool ShowGreetings { get; set; }

        public Color TextColor
        {
            get => this.ForeColor;
            set
            {
                //TextColor = value;
                this.ForeColor = value;
                menuStrip.ForeColor = value;
            }
        }

        public Color BackGroundColor
        {
            get => this.BackColor;
            set
            {
                this.BackColor = value;
                menuStrip.BackColor = value;
            }
        }

        public string LogPath
        {
            get;
            set;
        }



        public MainForm()
        {
            //ShowGreetings = showGreetings;
            FilePath = "";
            LogPath = "";
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();

            //  BackGroundColor = Color.FromName(ConfigurationManager.AppSettings["BackColor"]);
            //TextColor = Color.FromName(ConfigurationManager.AppSettings["TextColor"]);





        }



        public event EventHandler? TryDraw;

        public event EventHandler? Clear;

        public event EventHandler? Removelast;

        public event EventHandler? OpenFile;

        public event EventHandler? SaveInitialData;

        public event EventHandler? SaveData;

        public event EventHandler? NoData;

        public event EventHandler? SettingsChanged;

        public event EventHandler? Invalid—olors;


        public new void Show()
        {
            Application.Run(this);
        }

        private void SayHi()
        {
            MessageBox.Show("Good day 3 kr var 6 Task:*** ", "Greatings", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void ClearFields()
        {
            textBoxLeftBorder.Text = "";
            textBoxRightBorder.Text = "";
            textBoxStep.Text = "";
            textBoxR.Text = "";
            this.Refresh();

        }
        private void drawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TryDraw?.Invoke(this, EventArgs.Empty);


        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart.Plot.Clear();
            ClearFields();
            chart.Refresh();
            Clear?.Invoke(this, EventArgs.Empty);
        }
        private void removeLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chart.Plot.GetPlottables().Length > 0)
            {

                chart.Plot.RemoveAt(chart.Plot.GetPlottables().Length - 1);
                chart.Refresh();

                Removelast?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                NoData?.Invoke(this, EventArgs.Empty);
            }

        }

        public void Draw(GraphData graphData, string _label)
        {
            var scatter = chart.Plot.AddScatter(graphData.xs, graphData.ys, label: _label);

            chart.Plot.Legend();

            chart.Refresh();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text file|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = dialog.FileName;
            }
            else
            {
                FilePath = "";
            }



            if (FilePath != "") OpenFile?.Invoke(this, EventArgs.Empty);
        }

        private void initialToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (chart.Plot.GetPlottables().Length == 0)
            {
                NoData?.Invoke(this, EventArgs.Empty);
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.OverwritePrompt = true;
            dialog.Filter = "Text file|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = dialog.FileName;
            }
            else
            {
                FilePath = "";
            }

            if (FilePath != "") SaveInitialData?.Invoke(this, EventArgs.Empty);
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (chart.Plot.GetPlottables().Length == 0)
            {
                NoData?.Invoke(this, EventArgs.Empty);
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.OverwritePrompt = true;
            dialog.Filter = "Xlsx|*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = dialog.FileName;
            }
            else
            {
                FilePath = "";
            }
            if (FilePath != "") SaveData?.Invoke(this, EventArgs.Empty);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart.Plot.AxisZoom(0, 0, 1500, 15000);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (ShowGreetings)
                SayHi();
            onToolStripMenuItem.Checked = ShowGreetings;
            if(LogPath == "")
                defaultToolStripMenuItem.Checked = true;
            else
            {
                anotherToolStripMenuItem.Checked = true; 
            }
        }

        private void themeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Refresh();
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            var q = colorDialog.Color;
            if (colorDialog.Color == TextColor)
            {
                Invalid—olors?.Invoke(this, EventArgs.Empty);
                return;
            }


            BackGroundColor = Color.FromArgb(255, colorDialog.Color);

            SettingsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.SolidColorOnly = true;
            colorDialog.ShowDialog();
            var q = colorDialog.Color;
            if (colorDialog.Color == BackColor)
            {
                Invalid—olors?.Invoke(this, EventArgs.Empty);
                return;
            }
            TextColor = Color.FromArgb(255, colorDialog.Color);
            SettingsChanged?.Invoke(this, EventArgs.Empty);

        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGreetings = onToolStripMenuItem.Checked;
            SettingsChanged?.Invoke(this, EventArgs.Empty);
        }

       

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogPath = "";
            defaultToolStripMenuItem.Checked = true;
            anotherToolStripMenuItem.Checked = false;
            SettingsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void anotherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LogPath = dialog.SelectedPath;
                defaultToolStripMenuItem.Checked = false;
                anotherToolStripMenuItem.Checked = true;
            }
            SettingsChanged?.Invoke(this, EventArgs.Empty);
        }
    }

}