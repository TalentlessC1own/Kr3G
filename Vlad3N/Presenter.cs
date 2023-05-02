using NLog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kr3G
{

    public interface IPresenter
    {
        void Run();
    }
    public class Presenter:IPresenter
    {
        const int MAX_CHARTS_COUNT = 5;
        const int EXPECTED_AMOUNT_DATA = 4;


        private readonly IMainForm mainForm;
        private readonly ICalculator calculator;
        private readonly IMessageService messageService;
        private readonly IValidator validator;
        private readonly IFileManager fileManager;
        private readonly IDataExport dataExport;

        private List<DataHolder<double>> dataHolders = new List<DataHolder<double>>();
        private List<GraphData> graphDatas = new List<GraphData>();





        public Presenter(IMainForm mainForm, ICalculator calculator, IMessageService messageService, IValidator validator, IFileManager fileManager,IDataExport dataExport)
        {
            this.mainForm = mainForm;
            this.calculator = calculator;
            this.messageService = messageService;
            this.validator = validator;
            this.fileManager = fileManager;
            this.dataExport = dataExport;



            mainForm.TryDraw += MainForm_TryDraw;
            mainForm.Clear += MainForm_Clear;
            mainForm.Removelast += MainForm_RemoveLast;
            mainForm.SaveInitialData += MainForm_SaveInitialData;
            mainForm.SaveData += MainForm_SaveData;
            mainForm.NoData += MainForm_NoData;

            

        }

        public void Run()
        {
            mainForm.Show();
        }

        private void MainForm_SaveData(object? sender, EventArgs e)
        {
            
            try
            {
                dataExport.ExportData(dataHolders.ToArray(), graphDatas.ToArray(), mainForm.Image, mainForm.FilePath);
            }
            catch (Exception ex)
            {
                LogManager.logger.Error(ex);

                messageService.ShowError("Close the file before changing!");
            }
                
        }

        private void MainForm_SaveInitialData(object? sender, EventArgs e)
        {
            string tempData = "";
            foreach (var item in dataHolders)
            {
                tempData += item.GetStringData() + Environment.NewLine;
            }
           
            fileManager.SaveInitialData(tempData,mainForm.FilePath );
        }
         
        //TODO сделать нормально
        private void MainForm_TryDraw(object? sender, EventArgs e)
        {
            Draw();
        }

        private void MainForm_Clear(object? sender, EventArgs e)
        {

            dataHolders.Clear();
            graphDatas.Clear();
        }
        private void MainForm_RemoveLast(object? sender, EventArgs e)
        {

            dataHolders.RemoveAt(dataHolders.Count - 1);
            graphDatas.RemoveAt(graphDatas.Count - 1);

            


            
        }

        private void MainForm_OpenFile(object? sender, EventArgs e)
        {
            string[] fileValue = fileManager.OpenFile(mainForm.FilePath);
            for (int i = 0; i < fileValue.Length; i++)
            {
                string[] chartLine = fileValue[i].Split(" ").Where(x => x != "").ToArray();
                if (chartLine.Length != EXPECTED_AMOUNT_DATA)
                {
                    messageService.ShowError("Wrong file data");
                    return;
                }
                mainForm.ClearFields();
                mainForm.LeftBorder = chartLine[0];
                Thread.Sleep(500);
                mainForm.RightBorder = chartLine[1];
                Thread.Sleep(500);
                mainForm.Step = chartLine[2];
                Thread.Sleep(500);
                mainForm.R = chartLine[3];
                Draw();
            }
            

           
        }

        private void MainForm_NoData(object? sender, EventArgs e)
        {
            messageService.ShowMessage("Сharts missing!!");
        }

        private void Draw()
        {
            if (graphDatas.Count >= MAX_CHARTS_COUNT)
            {
                messageService.ShowMessage("The maximum number of charts has been entered.");
                return;
            }

            string errors = validator.PreValidation(new DataHolder<string>(mainForm.LeftBorder, mainForm.RightBorder, mainForm.Step, mainForm.R));
            if (errors != "")
            {
                messageService.ShowError(errors);
                return;
            }
            dataHolders.Add(new DataHolder<double>(double.Parse(mainForm.LeftBorder), double.Parse(mainForm.RightBorder), double.Parse(mainForm.Step), double.Parse(mainForm.R)));


            if (!validator.AccetableRange(dataHolders[dataHolders.Count - 1]))
            {
                dataHolders.RemoveAt(dataHolders.Count - 1);
                messageService.ShowError("Values does not match accetable range");
                return;
            }
            graphDatas.Add(calculator.GetGraphData(dataHolders[dataHolders.Count - 1]));

            if (!validator.PostValidation(graphDatas[dataHolders.Count - 1].xs))
            {
                messageService.ShowError("Values does not match accetable range");

                dataHolders.RemoveAt(dataHolders.Count - 1);
                graphDatas.RemoveAt(graphDatas.Count - 1);
                return;
            }


            string? label = "[" + dataHolders[dataHolders.Count - 1].LeftBorder.ToString() + "," + dataHolders[dataHolders.Count - 1].RightBorder.ToString() + ","
                + dataHolders[dataHolders.Count - 1].Step.ToString() + "," + dataHolders[dataHolders.Count - 1].R.ToString() + "]";

            mainForm.Draw(graphDatas[graphDatas.Count - 1], label);
        }


       
        
    }
}
