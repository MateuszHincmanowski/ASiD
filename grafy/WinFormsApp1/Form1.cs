namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Edge> edges = new List<Edge>();
        int vertices = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            Edge edge = new Edge
            {
                From = int.Parse(txtFrom.Text),
                To = int.Parse(txtTo.Text),
                Weight = int.Parse(txtWeight.Text)
            };

            edges.Add(edge);
            listEdges.Items.Add(edge);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (edges.Count == 0)
            {
                MessageBox.Show("Brak krawêdzi!");
                return;
            }

            listResult.Items.Clear();

            Kruskal k = new Kruskal();
            List<Edge> mst = k.Run(edges, vertices);

            foreach (Edge edge in mst)
                listResult.Items.Add(edge);
        }
    }
}