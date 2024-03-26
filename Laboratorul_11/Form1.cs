namespace Laboratorul_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile("C:\\Asisitenta Pentru Programarea Web\\Laboratorul_11\\Laboratorul_11\\Primavara.jpg");
            this.BackgroundImage = img;
        }

        private void vara_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile("C:\\Asisitenta Pentru Programarea Web\\Laboratorul_11\\Laboratorul_11\\Vara.jpg");
            this.BackgroundImage = img;
        }

        private void toamna_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile("C:\\Asisitenta Pentru Programarea Web\\Laboratorul_11\\Laboratorul_11\\Toamna.jpg");
            this.BackgroundImage = img;
        }

        private void iarna_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile("C:\\Asisitenta Pentru Programarea Web\\Laboratorul_11\\Laboratorul_11\\Iarna.jpg");
            this.BackgroundImage = img;
        }
    }
}
