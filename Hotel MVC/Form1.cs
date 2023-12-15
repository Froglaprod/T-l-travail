namespace Hotel_MVC
{
    public partial class Form1 : Form
    {

        private Controller controller;

        public Controller Controller { get => controller; set => controller = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stockage Inscription = new Stockage();
            Inscription.Arrivate = this.dateTimePicker1.Value;
            Inscription.NumberNight = (int)this.numericUpDown1.Value;
            Inscription.Info= this.textBox1.Text;

            Controller.Process(Inscription);
        }
    }
}