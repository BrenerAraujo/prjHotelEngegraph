using System;
using System.Windows.Forms;

namespace Hotel.Cliente
{
    public partial class FrmSobre : Form
    {
        public FrmSobre()
        {
            InitializeComponent();
        }

        private void FrmSobre_Load(object sender, EventArgs e)
        {
            lblNomeProduto.Text = SistemaInfo.NomeSistema;
            lblVersao.Text = SistemaInfo.Versao;
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
