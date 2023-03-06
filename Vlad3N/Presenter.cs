﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kr3G
{
    public class Presenter
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



            mainForm.TryDraw += new EventHandler(MainForm_TryDraw);
            mainForm.Clear += new EventHandler(MainForm_Clear);
            mainForm.Removelast += new EventHandler(MainForm_RemoveLast);
            mainForm.OpenFile += new EventHandler(MainForm_OpenFile);
            mainForm.SaveInitialData += new EventHandler(MainForm_SaveInitialData);
            mainForm.SaveData += new EventHandler(MainForm_SaveData);
        }

        private void MainForm_SaveData(object? sender, EventArgs e)
        {
            if (mainForm.FilePath == "")
                return;
            try
            {
                dataExport.ExportData(dataHolders.ToArray(), graphDatas.ToArray(), Base64ToImage(mainForm.Image), mainForm.FilePath);
            }
            catch (Exception)
            {

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
            if (mainForm.FilePath != "")
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
            if (dataHolders.Count > 0)
            {
                dataHolders.RemoveAt(dataHolders.Count - 1);
                graphDatas.RemoveAt(graphDatas.Count - 1);
            }
            else
            {
                messageService.ShowMessage("Сharts missing!!");
            }
        }

        private void MainForm_OpenFile(object? sender, EventArgs e)
        {
            if (mainForm.FilePath == "")
                return;
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


        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);

            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);

                return image;
            }
        }
    }
}
