using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalsınavıhazırlık
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JonSnow j = new JonSnow("olmak");
            MessageBox.Show(j.unvan);
            Rheagar r = new JonSnow("king");
            MessageBox.Show(r.yas.ToString());
            MessageBox.Show(r.unvan);
            MadKing m = new Rheagar();
            MadKing a = new Viserys(12);
            MessageBox.Show(m.kat.ToString());
            MessageBox.Show(a.kat.ToString());
            SevenKingdooms(r);
            SevenKingdooms(m);
            SevenKingdooms(a);
        }
        public void SevenKingdooms(MadKing m)
        {
            if(m is MadKing)
            {
                MessageBox.Show("MadKing soyundan");
            }
            if (m is Rheagar)
            {
                MessageBox.Show("Rheagar soyundan");
            }
            if (m is Viserys)
            {
                MessageBox.Show("Viserys soyundan");
            }
            if (m is JonSnow)
            {
                MessageBox.Show("JonSnow soyundan");
            }
        }
    }
}
