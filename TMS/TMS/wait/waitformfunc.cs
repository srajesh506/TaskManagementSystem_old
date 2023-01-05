using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.Home.wait
{
    class waitformfunc
    {
        waitfrm wait;
        Thread loadthread;
        public void Show()
        {
            //loadthread
            loadthread = new Thread(new ThreadStart(LoadingProcess));
            loadthread.Start();
        }
        public void Show(Form parent)
        {
            loadthread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            loadthread.Start(parent);
        }
        public void Close()
        {
            if(wait!=null)
            {
                wait.BeginInvoke(new System.Threading.ThreadStart(wait.closewaitform));
                wait = null;
                loadthread = null;
            }

        }
        private void LoadingProcess()
        {
            wait = new Home.wait.waitfrm();
            wait.ShowDialog();
        }
        private void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            wait = new Home.wait.waitfrm(parent1);
            wait.ShowDialog(); 
        }
    }
   
}
