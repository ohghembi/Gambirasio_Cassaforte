namespace Gambirasio_Cassaforte
{
    public partial class Form1 : Form
    {
        private Cassaforte cassaforte1;
        public Form1()
        {
            cassaforte1 = new Cassaforte(1111, "o123456789ab", "Gambirasio", "skibidi");
            InitializeComponent();
        }

        private void Apri_Click(object sender, EventArgs e)
        {
            cassaforte1.Apri((int)PIN.Value);
            Cassaforte.Text = cassaforte1.Stato.ToString();
        }

        private void Imposta_Click(object sender, EventArgs e)
        {
            cassaforte1.Imposta((int)PIN.Value);
            Imposta.Enabled = false;

        }

        private void Chiudi_Click(object sender, EventArgs e)
        {
            cassaforte1.Chiudi();
            Cassaforte.Text = cassaforte1.Stato.ToString();
        }

        private void Sblocca_Click(object sender, EventArgs e)
        {
            cassaforte1.Sblocca(CodiceDiSblocco.Text);
            Cassaforte.Text = cassaforte1.Stato.ToString();
        }
    }
}