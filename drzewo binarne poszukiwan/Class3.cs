using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drzewo_binarne_poszukiwan
{
    public class Wezel<T> where T : IComparable<T>
    {
        public T wartosc;
        public Wezel<T> lewy;
        public Wezel<T> prawy;

        public Wezel(T wartosc)
        {
            this.wartosc = wartosc;
            this.lewy = null;
            this.prawy = null;
        }
    }
}
