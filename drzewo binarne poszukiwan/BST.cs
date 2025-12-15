using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drzewo_binarne_poszukiwan
{
    public class DrzewoBST<T> where T : IComparable<T>
    {
        public Wezel<T> korzen;

        public void Dodaj(T a)
        {
            if (korzen == null)
                korzen = new Wezel<T>(a);
            else
                dodajWartosc(korzen, a);
        }

        public void dodajWartosc(Wezel<T> w, T a)
        {
            if (w.wartosc.CompareTo(a) > 0)
            {
                if (w.lewy == null)
                    w.lewy = new Wezel<T>(a);
                else
                    dodajWartosc(w.lewy, a);
            }
            else
            {
                if (w.prawy == null)
                    w.prawy = new Wezel<T>(a);
                else
                    dodajWartosc(w.prawy, a);
            }
        }
        public string InOrder()
        {
            return InOrder(korzen).Trim();
        }

        private string InOrder(Wezel<T> w)
        {
            if (w == null)
                return "";

            return InOrder(w.lewy) + w.wartosc + " " + InOrder(w.prawy);
        }
        public string WyswietlDrzewo()
        {
            StringBuilder sb = new StringBuilder();
            WyswietlDrzewo(korzen, 0, sb);
            return sb.ToString();
        }

        private void WyswietlDrzewo(Wezel<T> wezel, int poziom, StringBuilder sb)
        {
            if (wezel == null) return;

            WyswietlDrzewo(wezel.prawy, poziom + 1, sb);

            sb.AppendLine(new string(' ', poziom * 4) + wezel.wartosc);

            WyswietlDrzewo(wezel.lewy, poziom + 1, sb);
        }
    }
    

}
