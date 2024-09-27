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

                MessageBox.Show("Boþ Alan Býrakmayýn!");

            }

            else

            {

                if (textBox1.Text == "batumrgz@gmail.com")

                {

                    if (textBox2.Text == "batu1234")

                    {

                        MessageBox.Show("Giriþ Baþarýlý!");

                    }

                    else

                    {

                        MessageBox.Show("Þifre Yanlýþ!");

                    }

                }

                else

                {

                    MessageBox.Show("Kullanýcý Adý Yanlýþ!");

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
