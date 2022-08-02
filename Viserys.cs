using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace finalsınavıhazırlık
{
    public class Viserys:MadKing
    {
        public string yap;
        Westeros w = new Westeros(33);
        public Viserys():this("altı")
        {
            MessageBox.Show("viserys 1");
        }
        public Viserys(int a):this()
        {
            MessageBox.Show("viserys 2");
        }
        public Viserys(string c):base()
        {
            yap = "yapma";
            MessageBox.Show("viserys 3");
            Westeros w = new Westeros("otuzluk");
        }
    }
}
