using System;
using System.Windows.Forms;

namespace Hotel.Cliente
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text += string.Concat(SistemaInfo.NomeSistema, " ", SistemaInfo.Versao);
            this.Width = SistemaInfo.LarguraDaTela;
            //O this não precisa ser utilizado
            Height = SistemaInfo.AlturaDaTela;
            this.CenterToScreen();
        }

        private void mnSobre_Click(object sender, EventArgs e)
        {
            new FrmSobre().ShowDialog();
        }

        private void mnTipoUh_Click(object sender, EventArgs e)
        {
            AdicionarFormularioNaTabControl(new FrmCadTipoUh());
        }

        private void mnUh_Click(object sender, EventArgs e)
        {
            AdicionarFormularioNaTabControl(new FrmCadUh());
        }

        private void AdicionarFormularioNaTabControl(Form pForm)
        {
            if(tabForms.TabPages.Count > 5)
            {
                MessageBox.Show("Máximo de 6 formulários abertos atingidos", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            pForm.FormBorderStyle = FormBorderStyle.None;
            pForm.WindowState = FormWindowState.Maximized;
            pForm.TopLevel = false;
            var page = new TabPage();
            page.Controls.Add(pForm);
            page.Text = pForm.Text;
            tabForms.Controls.Add(page);
            pForm.Parent = page;
            pForm.Show();
        }
    }
}
