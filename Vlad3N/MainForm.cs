using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Kr3G
{
    public interface IMainForm:IView
    { 
        string LeftBorder { get; set; }
        string RightBorder { get; set; }
        string Step { get; set; }
        string R { get; set; }

        string FilePath { get; }

        Image Image { get; }

        void Draw(GraphData graphData, string _label);

        void ClearFields();


        event EventHandler TryDraw;
        event EventHandler Clear;
        event EventHandler Removelast;
        event EventHandler OpenFile;
        event EventHandler SaveInitialData;
        event EventHandler SaveData;
        event EventHandler NoData;


    }

    public partial class MainForm : Form, IMainForm
    {
        [Required]
        public string LeftBorder
        {
            get { return textBoxLeftBorder.Text; }
            set 
            {
                textBoxLeftBorder.Text = value;
                this.Refresh(); 
            }
        }

        public string RightBorder
        {
            get { return textBoxRightBorder.Text; }
            set 
            {
                textBoxRightBorder.Text = value;
                this.Refresh();
            }
        }

        public string Step
        {
            get { return textBoxStep.Text; }
            set 
            { 
                textBoxStep.Text = value;
                this.Refresh(); 
            }
        }

        public string R
        {
            get { return textBoxR.Text; }
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
                using (var ms = new MemoryStream(chart.Plot.GetImageBytes(), 0, chart.Plot.GetImageBytes().Length))
                {
                    Image image = Image.FromStream(ms, true);

                    return image;
                }
            }

        }

        public MainForm()
        {
            FilePath = "";
            InitializeComponent();
            
            

        }



        public event EventHandler? TryDraw;
        
        public event EventHandler? Clear;

        public event EventHandler? Removelast;

        public event EventHandler? OpenFile;

        public event EventHandler? SaveInitialData;

        public event EventHandler? SaveData;

        public event EventHandler? NoData;

        public new void Show()
        {
            Application.Run(this);
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
            var scatter = chart.Plot.AddScatter(graphData.xs, graphData.ys, label: _label) ;

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
    }

 }