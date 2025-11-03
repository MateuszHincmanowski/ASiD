using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        void SC(int[] T, int l, int p)
        {
            if (l < p)
            {
                int ś = (l + p) / 2;
                SC(T, l, ś);
                SC(T, ś + 1, p);
                SCAL(T, l, ś, p);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            int[] T = new int[] { 1,5,7,8,2,3,15 };

            SCAL(T, 0,3, 6);
        }
        private void SCAL(int[] T, int l, int ś, int p)
        {
            
            List<int> posortowane = new List<int>();
            int lewaSzczalka = 0;
            int prawaSzczalka = 6;
            int srodkowaSzczalka = 3;
            while (l<p)
            {
                if (T[lewaSzczalka] < T[lewaSzczalka+1])
                {
                    posortowane.Add(T[l]);
                }
                l++;
            }
      

        }
    }
}
