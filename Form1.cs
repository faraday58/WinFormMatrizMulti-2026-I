namespace WinFormMatrizMulti_2026_I
{
    public partial class Form1 : Form
    {
        Multidimensional m1, m2, m3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            m1 = Multidimensional.Read(txtbMatrix1.Text);
            m2 = Multidimensional.Read(txtbMatrix2.Text);

            lbMatrix1.Text = m1.ToString();
            lbMatrix2.Text = m2.ToString();


            m3 = m1 + m2;
            lbResult.Text = m3.ToString();

        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (rdbDeg.Checked)
            {
                MessageBox.Show("Está en Sexagésimales");
            }
            else if(rdbRad.Checked)
            {
                MessageBox.Show("Está en Radianes");
            }
        }
    }
}
