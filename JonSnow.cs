using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace finalsınavıhazırlık
{
    public class JonSnow:Rheagar
    {
        public string unvan;
        Westeros w = new Westeros(13);
        public JonSnow():this(7)
        {
            base.yas = 39;
            unvan = "Lord Komander";
            MessageBox.Show("JonSnow 1");
        }
        public JonSnow(int a):base()
        {
            unvan = "Busterd";
            MessageBox.Show("JonSnow 2");
        }
        Westeros e = new Westeros("ben");
        public JonSnow(string c):this()
        {
            unvan = "The King in The North";
            MessageBox.Show("JonSnow 3");
        }
    }
}
