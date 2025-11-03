using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace zad1
{
    public partial class Form1 : Form
    {
        Random r = new Random((int)DateTime.Now.Ticks);
        int counter = 0;
        DateTime start;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.btn.Text = "Skacz";
            this.start = DateTime.Now;
            this.timer4.Start();
            
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            if (this.btn.Text == "Start")
                
                return;
            int a = r.Next(0, this.Size.Width - this.btn.Size.Width);
            int b = r.Next(0, this.Size.Height - this.btn.Size.Height - 40);
            if (counter >9)
            {
                this.timer4.Stop();
                MessageBox.Show("Koniec");
                this.btn.Text = "Start";
                counter = 0;
            }
            else
            btn.Location = new Point(a, b);
            counter++;

            lbl.Text = counter.ToString();
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            lblczas.Text = (DateTime.Now - start).ToString().Split('.').First();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}