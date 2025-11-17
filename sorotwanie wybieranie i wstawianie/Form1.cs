using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorotwanie_wybieranie_i_wstawianie
{
    public partial class Form1 : Form
    {
        private int[] doSort;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void SortWyb_Click(object sender, EventArgs e)
        {
            int k = doSort.Length;
            for(int i=0;i<k - 1; i++)
            {
                int minId = i;
                for(int j=i+1; j < k; j++)
                {
                    if (doSort[j] < doSort[minId])
                    {
                        minId = j;
                    }
                   
                }
                int temp = doSort[i];
                doSort[i] = doSort[minId];
                doSort[minId] = temp;
            }
            
            label2.Text = String.Join(", ", doSort);
        }

        private void generowanie_Click(object sender, EventArgs e)
        {
            doSort = new int[10];
            int n = 0;
            while (n < 10)
            {
                doSort[n] = random.Next(1, 10);
                n++;
            }
            label1.Text = String.Join(", ", doSort);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void SortWs_Click(object sender, EventArgs e)
        {
            for(int i=1; i < doSort.Length; i++)
            {
                int curr = doSort[i];
                int j = i - 1;
                while(j>=0 && doSort[j] > curr)
                {
                    doSort[j + 1] = doSort[j];
                    j = j - 1;
                }
                doSort[j + 1] = curr;
            }
            label2.Text = String.Join(", ", doSort);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
