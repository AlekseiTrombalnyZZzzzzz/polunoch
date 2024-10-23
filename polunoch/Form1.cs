namespace polunoch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long totaltime = (int.Parse(textBox1.Text) * 3600) + (int.Parse(textBox2.Text) * 60) + int.Parse(textBox3.Text);
            MessageBox.Show(totaltime.ToString());
        }
    }
}
