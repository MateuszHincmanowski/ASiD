using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bubble_sort
{
    public partial class Form1 : Form
    {
        private int[] liczby;
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SortowanieBabelkowe(int[] tab)
        {
            int n = tab.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            }
        }

        private void btnLosuj_Click(object sender, EventArgs e)
        {
            liczby = new int[15];
            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = rand.Next(1, 100);
            }

            txtBefore.Text = string.Join(", ", liczby);
            txtAfter.Clear();
        }

        private void btnSortuj_Click(object sender, EventArgs e)
        {
            if (liczby == null)
            {
                MessageBox.Show("Najpierw wylosuj liczby!");
                return;
            }

            int[] kopia = (int[])liczby.Clone();
            SortowanieBabelkowe(kopia);
            txtAfter.Text = string.Join(", ", kopia);
        }

        private void sortAmount_TextChanged(object sender, EventArgs e)
        {
              
        }
    }
}
