namespace Polymorphism_with_interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chihuahua chihuahua = new Chihuahua();

            label1.ForeColor = System.Drawing.Color.White;
            label1.BackColor = System.Drawing.Color.Blue;
            label1.Text = ("Chihuahua barks");
            label2.Text = ("Chihuahua sleeps");
            label2.ForeColor = System.Drawing.Color.White;
            label2.BackColor = System.Drawing.Color.Blue;
            label3.Text = ("Chihuahua eating");
            label3.ForeColor = System.Drawing.Color.White;
            label3.BackColor = System.Drawing.Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bulldog bulldog = new Bulldog();

            label4.ForeColor = System.Drawing.Color.White;
            label4.BackColor = System.Drawing.Color.Red;
            label4.Text = ("Bulldog barks");
            label5.ForeColor = System.Drawing.Color.White;
            label5.BackColor = System.Drawing.Color.Red;
            label5.Text = ("Bulldog sleeps");
            label6.ForeColor = System.Drawing.Color.White;
            label6.BackColor = System.Drawing.Color.Red;
            label6.Text = ("Bulldog eating");
        }
    }
}
