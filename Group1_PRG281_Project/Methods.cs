using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group1_PRG281_Project
{
    class Methods
    {
        public static void ChangeLabel(string msg, Label label)
        {
            if (label.InvokeRequired)
                label.Invoke(new MethodInvoker(delegate {
                    label.Text = msg;
                }));
            else
                label.Text = msg;
        }
    }
}
