using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Form1 : Form { }

    class Edge
    {
        public int From;
        public int To;
        public int Weight;

        public override string ToString()
        {
            return $"{From} - {To} (waga: {Weight})";
        }
    }
}
