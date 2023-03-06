using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kr3G
{
    public interface IMessageService
    {
        void ShowMessage(string message);

        void ShowError(string error);

    }


    public class MessageService : IMessageService
    {
        public  void ShowMessage(string message)
        {
            MessageBox.Show(message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
