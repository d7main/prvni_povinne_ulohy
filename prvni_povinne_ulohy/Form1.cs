namespace prvni_povinne_ulohy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            double delkaHrany = (double)numericUpDown1.Value;

            Utvar vybUtvar = null;

            if (radioButton1.Checked)
            {
                vybUtvar = new Ctverec(delkaHrany);
            }
            else if (radioButton2.Checked)
            {
                vybUtvar = new Trojuhelnik(delkaHrany);
            }
            else if (radioButton3.Checked)
            {
                vybUtvar = new Kruh(delkaHrany);
            }

            if (vybUtvar != null)
            {
                label2.Text = "Plocha: " + vybUtvar.Plocha().ToString("F3");
                label3.Text = "Obvod: " + vybUtvar.Obvod().ToString("F3");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label4.Text = "Polomìr";
            }
            else
            {
                label4.Text = "Delka hrany";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label4.Text = "Delka hrany";
            }
            else
            {
                label4.Text = "Delka hrany";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                label4.Text = "Delka hrany";
            }
            else
            {
                label4.Text = "Delka hrany";
            }
        }


    }
}
    

