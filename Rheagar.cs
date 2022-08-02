using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace finalsınavıhazırlık
{
    public class Rheagar:MadKing
    {
        public string unvan;
        public int yas = 34;
        Westeros e = new Westeros("otuzluk");
        public Rheagar():this(6)
        {
            MessageBox.Show("Rheagar 1");
        }
        public Rheagar(int a):this("lastdragon")
        {
            yas = 35;
            MessageBox.Show("Rheagar 2");
        }
        Westeros w = new Westeros(14);
        public Rheagar(string c):base("mad")
        {
            yas = 36;
            MessageBox.Show("Rheagar 3");
        }
    }
}
