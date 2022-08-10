
namespace Hotel.Cliente
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTipoUh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUh = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIposDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConsultaReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNovaReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnWalkIn = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConsultaOcupacao = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.checkInToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.checkOutToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTipoUh,
            this.mnUh});
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.hotelToolStripMenuItem.Text = "&Hotel";
            // 
            // mnTipoUh
            // 
            this.mnTipoUh.Name = "mnTipoUh";
            this.mnTipoUh.Size = new System.Drawing.Size(138, 22);
            this.mnTipoUh.Text = "&Tipos de UH";
            this.mnTipoUh.Click += new System.EventHandler(this.mnTipoUh_Click);
            // 
            // mnUh
            // 
            this.mnUh.Name = "mnUh";
            this.mnUh.Size = new System.Drawing.Size(138, 22);
            this.mnUh.Text = "&UH";
            this.mnUh.Click += new System.EventHandler(this.mnUh_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tIposDePagamentoToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.financeiroToolStripMenuItem.Text = "&Financeiro";
            // 
            // tIposDePagamentoToolStripMenuItem
            // 
            this.tIposDePagamentoToolStripMenuItem.Name = "tIposDePagamentoToolStripMenuItem";
            this.tIposDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tIposDePagamentoToolStripMenuItem.Text = "Tipos de &Pagamento";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnConsultaReserva,
            this.mnNovaReserva});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reservasToolStripMenuItem.Text = "&Reservas";
            // 
            // mnConsultaReserva
            // 
            this.mnConsultaReserva.Name = "mnConsultaReserva";
            this.mnConsultaReserva.Size = new System.Drawing.Size(145, 22);
            this.mnConsultaReserva.Text = "&Consulta";
            // 
            // mnNovaReserva
            // 
            this.mnNovaReserva.Name = "mnNovaReserva";
            this.mnNovaReserva.Size = new System.Drawing.Size(145, 22);
            this.mnNovaReserva.Text = "&Nova Reserva";
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCheckIn,
            this.mnWalkIn});
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.checkInToolStripMenuItem.Text = "Check&In";
            // 
            // mnCheckIn
            // 
            this.mnCheckIn.Name = "mnCheckIn";
            this.mnCheckIn.Size = new System.Drawing.Size(117, 22);
            this.mnCheckIn.Text = "&Checkin";
            // 
            // mnWalkIn
            // 
            this.mnWalkIn.Name = "mnWalkIn";
            this.mnWalkIn.Size = new System.Drawing.Size(117, 22);
            this.mnWalkIn.Text = "&Walkin";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnConsultaOcupacao});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "C&onsultas";
            // 
            // mnConsultaOcupacao
            // 
            this.mnConsultaOcupacao.Name = "mnConsultaOcupacao";
            this.mnConsultaOcupacao.Size = new System.Drawing.Size(128, 22);
            this.mnConsultaOcupacao.Text = "&Ocupação";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCheckOut});
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.checkOutToolStripMenuItem.Text = "Check&Out";
            // 
            // mnCheckOut
            // 
            this.mnCheckOut.Name = "mnCheckOut";
            this.mnCheckOut.Size = new System.Drawing.Size(127, 22);
            this.mnCheckOut.Text = "&CheckOut";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSobre});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // mnSobre
            // 
            this.mnSobre.Name = "mnSobre";
            this.mnSobre.Size = new System.Drawing.Size(104, 22);
            this.mnSobre.Text = "&Sobre";
            this.mnSobre.Click += new System.EventHandler(this.mnSobre_Click);
            // 
            // tabForms
            // 
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabForms.Location = new System.Drawing.Point(0, 24);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(800, 426);
            this.tabForms.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabForms);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Hotel Engegraph";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnTipoUh;
        private System.Windows.Forms.ToolStripMenuItem mnUh;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIposDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnConsultaReserva;
        private System.Windows.Forms.ToolStripMenuItem mnNovaReserva;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnCheckIn;
        private System.Windows.Forms.ToolStripMenuItem mnWalkIn;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnConsultaOcupacao;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnCheckOut;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnSobre;
        private System.Windows.Forms.TabControl tabForms;
    }
}

