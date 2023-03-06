using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Kr3G
{
    public interface IMainForm
    { 
        string LeftBorder { get; set; }
        string RightBorder { get; set; }
        string Step { get; set; }
        string R { get; set; }

        string FilePath { get; }

        string Image { get; }

        void Draw(GraphData graphData, string _label);

        void ClearFields();

        event EventHandler TryDraw;
        event EventHandler Clear;
        event EventHandler Removelast;
        event EventHandler OpenFile;
        event EventHandler SaveInitialData;
        event EventHandler SaveData;


    }

    public partial class MainForm : Form, IMainForm
    {
        int scatterCounter = 0;
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

        public string Image 
        {
            get
            {
                return chart.Plot.GetImageBase64();
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
            if (TryDraw != null) TryDraw(this, EventArgs.Empty);


        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart.Plot.Clear();
            ClearFields();
            scatterCounter = 0;
            chart.Refresh();
            if (Clear != null) Clear(this, EventArgs.Empty);
        }
        private void removeLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scatterCounter > 0)
            {
                chart.Plot.RemoveAt(scatterCounter - 1);
                scatterCounter--;
                chart.Refresh();
            }
            if(Removelast != null) Removelast(this, EventArgs.Empty);
           
        }

        public void Draw(GraphData graphData, string _label)
        {
            var scatter = chart.Plot.AddScatter(graphData.xs, graphData.ys, label: _label) ;

            scatterCounter++;
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
            if (OpenFile != null ) OpenFile(this, EventArgs.Empty);
        }

        private void initialToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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

            if (SaveInitialData != null) SaveInitialData(this, EventArgs.Empty);
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            if (SaveData != null) SaveData(this, EventArgs.Empty);
        }
    }

 }