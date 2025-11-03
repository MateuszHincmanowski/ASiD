using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Lista
    {
        public Element head;
        public Element tail;
        public int liczbaelem;

        public void DodajPo(int liczba)
        {
            this.DodajPo(this.tail, liczba);
        }
        public void DodajPo(Element e, int liczba)
        {
            Element nowy = new Element(liczba);
            if (e == this.tail)
            {
                tail.next = nowy;
                nowy.prev = tail;
                tail = nowy;
            }
            else if (e == null)
            {
                head = tail = nowy;


            }
            else
            {
                nowy.next = e.next;
                nowy.prev = e;
                if (e.next != null)
                {
                    e.next.prev = nowy;
                    e.next = nowy;

                }

                
            }
            
            liczbaelem++;
            
        }
        public void DodajPrzed(Element e, int liczba)
        {

        }
    }
}
