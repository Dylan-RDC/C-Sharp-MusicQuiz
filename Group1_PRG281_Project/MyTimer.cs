using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Group1_PRG281_Project
{
    class MyTimer
    {
        Label label1;
        Button btn;
        Form frm;
        public static bool end = false;

        public MyTimer() { }

        public delegate void TDel();
        public event TDel OnTimeFinish;

        event TDel OnTick;

        public MyTimer(Form frm ,Label label1, Button btn)
        {
            this.frm = frm;
            this.Label1 = label1;
            this.Btn = btn;
        }

        public Label Label1 { get => label1; set => label1 = value; }
        public Button Btn { get => btn; set => btn = value; }
        public Form Frm { get => frm; set => frm = value; }

        public void CountDown(int time)
        {

            while (time > 0 && end == false)
            {
                OnTick = () => { frm.Invoke(new MethodInvoker(delegate () { Label1.Text = string.Format("{0}", time); })); };
                OnTick += () => { time--; };
                OnTick.Invoke();
                Thread.Sleep(1000);
            }

            if (end == true)
            {
                OnTimeFinish = () => { frm.Invoke(new MethodInvoker(delegate () { btn.Enabled = false; })); };
                OnTimeFinish += () => { frm.Invoke(new MethodInvoker(delegate () { btn.Visible = false; })); };
               
                OnTimeFinish.Invoke();

            }
            else
            {
                OnTimeFinish = () => { frm.Invoke(new MethodInvoker(delegate () { btn.Enabled = false; })); };
                OnTimeFinish += () => { frm.Invoke(new MethodInvoker(delegate () { btn.Visible = false; })); };


                OnTimeFinish += () => frm.Invoke(new MethodInvoker(delegate () { Label1.Text = "0"; }));
                OnTimeFinish += () => frm.Invoke(new MethodInvoker(delegate () { Label1.ForeColor = Color.Red; }));
                OnTimeFinish += () => Thread.Sleep(500);
                OnTimeFinish += () => frm.Invoke(new MethodInvoker(delegate () { Label1.ForeColor = Color.White; }));
                OnTimeFinish += () => Thread.Sleep(500);
                OnTimeFinish += () => frm.Invoke(new MethodInvoker(delegate () { Label1.ForeColor = Color.Red; ; }));
                OnTimeFinish += () => Thread.Sleep(500);
                OnTimeFinish += () => frm.Invoke(new MethodInvoker(delegate () { Label1.ForeColor = Color.White; }));
                OnTimeFinish += () => Thread.Sleep(500);
                OnTimeFinish += () => frm.Invoke(new MethodInvoker(delegate () { Label1.ForeColor = Color.Red; }));


                OnTimeFinish.Invoke();
            }
        }
    }
}
