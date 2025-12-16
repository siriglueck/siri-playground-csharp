namespace UName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnName_Click(object sender, EventArgs e)
        {
            LblName.Text = "Freut mich!, Max Mustermann :)";
        }

        private void BtnEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
