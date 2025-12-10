namespace GrundlagenAusgaben
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

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 42;
            LblAnzeige.Text = $"Wert: {x}";
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int x = 42;
            // Der Typ int kann nicht direkt in eine Zeichenkette umgewandelt werden.
            // LblAnzeige.Text = x;
            LblAnzeige.Text = x.ToString();
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int x = 25, y = 17, z;
            z = x + y;
            LblAnzeige.Text = "Das Ergebnis der " + $"Berechnung: \n{x} + {y} = {z}";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            int x = 25, y = 17, z;
            z = x + y;
            MessageBox.Show("Das Ergebnis der " + $"Berechnung: \n{x} + {y} = {z}", "Ergebnisanzeige");
            LblAnzeige.Text = "Ende";
        }
    }
}
