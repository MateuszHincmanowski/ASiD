using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Kruskal
    {
        private int[] parent;

        private int Find(int x)
        {
            if (parent[x] != x)
                parent[x] = Find(parent[x]);
            return parent[x];
        }

        private void Union(int a, int b)
        {
            parent[Find(a)] = Find(b);
        }

        public List<Edge> Run(List<Edge> edges, int vertices)
        {
            List<Edge> result = new();
            parent = new int[vertices];

            for (int i = 0; i < vertices; i++)
                parent[i] = i;

            edges.Sort((a, b) => a.Weight.CompareTo(b.Weight));

            foreach (Edge e in edges)
            {
                if (Find(e.From) != Find(e.To))
                {
                    result.Add(e);
                    Union(e.From, e.To);
                }
            }
            return result;
        }
    }
}
