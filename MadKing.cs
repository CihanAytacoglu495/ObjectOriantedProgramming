using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace finalsınavıhazırlık
{
   public abstract class MadKing:Deenerys
    {
        public int kat;
        public MadKing():this(12)
        {
            kat = 10;
            MessageBox.Show("MadKing 1");
        }
        Westeros w = new Westeros("yemek");
        public MadKing(int a):base()
        {
            kat = 11;
            MessageBox.Show("MadKing 2");
        }
        public MadKing(string c):this()
        {
            kat = 12;
            MessageBox.Show("MadKing 3");
        }

        public void ejderha()
        {
            throw new NotImplementedException();
        }

        public void targeryan()
        {
            throw new NotImplementedException();
        }
    }
}
