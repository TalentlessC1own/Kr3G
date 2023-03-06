namespace Kr3G
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            MainForm mainForm = new MainForm();
            MessageService messageService = new MessageService();
            Calculator calculator = new Calculator();
            Validator validator = new Validator();
            FileManager fileManager = new FileManager();
            ExcelExport excelExport = new ExcelExport();

            Presenter presenter = new Presenter(mainForm, calculator, messageService, validator,fileManager,excelExport);

            Application.Run(mainForm);
        }
    }
}