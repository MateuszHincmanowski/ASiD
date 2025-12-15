using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using drzewo_binarne_poszukiwan;

namespace drzewo_binarne_poszukiwan
{
    public partial class Form1 : Form
    {
        DrzewoBST<int> drzewo = new DrzewoBST<int>();
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
            textBox1.Font = new Font("Consolas", 10);
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void dw_Click(object sender, EventArgs e)
        {
            int wartosc = (int)numericUpDown1.Value;

            drzewo.Dodaj(wartosc);

            
            textBox1.Text = drzewo.WyswietlDrzewo();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
