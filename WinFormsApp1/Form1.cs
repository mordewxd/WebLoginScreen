namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")

            {

                MessageBox.Show("Bo� Alan B�rakmay�n!");

            }

            else

            {

                if (textBox1.Text == "batumrgz@gmail.com")

                {

                    if (textBox2.Text == "batu1234")

                    {

                        MessageBox.Show("Giri� Ba�ar�l�!");

                    }

                    else

                    {

                        MessageBox.Show("�ifre Yanl��!");

                    }

                }

                else

                {

                    MessageBox.Show("Kullan�c� Ad� Yanl��!");

                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
