
using Spire.Xls;


namespace Kr3G
{


    public interface IDataExport
    {
        void ExportData(DataHolder<double>[] dataHolders, GraphData[] graphDatas, Image image,string filePath);
        
    }

    public class ExcelExport : IDataExport
    {
        private string[] colums = { "H", "I", "J", "K", "L" };
        public void ExportData(DataHolder<double>[] dataHolders, GraphData[] graphDatas, Image image, string filePath)
        {

            
            Workbook workbook = new Workbook();
    
            Worksheet sheet = workbook.Worksheets[0];

          
            sheet.Pictures.Add(1, 1, image);

            for (int i = 0; i < dataHolders.Length; i++)
            {
                string selectedColum = colums[i];
                sheet.Range[selectedColum + "1"].Text = "[" + dataHolders[i].GetStringData() +"]";
                sheet.Range[selectedColum + "1"].ColumnWidth = 30;
                for (int j = 0; j < graphDatas[i].xs.Length; j++)
                {
                    sheet.Range[selectedColum + (j + 2)].Text = $"x = {graphDatas[i].xs[j]} | y = {graphDatas[i].ys[j]}";
                }
            }

           
            workbook.SaveToFile(filePath, ExcelVersion.Version2016);

        }

       
    }
}
