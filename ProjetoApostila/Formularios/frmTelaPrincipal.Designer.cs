namespace ProjetoApostila.Formularios
{
    partial class frmTelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCliente = new System.Windows.Forms.ToolStripButton();
            this.tsbServico = new System.Windows.Forms.ToolStripButton();
            this.tsbOS = new System.Windows.Forms.ToolStripButton();
            this.tsbLogoff = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssIIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssINomePC = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssIData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssIHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.servicoToolStripMenuItem,
            this.OSToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.usuarioToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuarioToolStripMenuItem.Text = "Usuário";
            this.usuarioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.clienteToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // servicoToolStripMenuItem
            // 
            this.servicoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.servicoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.servicoToolStripMenuItem.Name = "servicoToolStripMenuItem";
            this.servicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.servicoToolStripMenuItem.Text = "Serviço";
            this.servicoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.servicoToolStripMenuItem.Click += new System.EventHandler(this.servicoToolStripMenuItem_Click);
            // 
            // OSToolStripMenuItem
            // 
            this.OSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.OSToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OSToolStripMenuItem.Name = "OSToolStripMenuItem";
            this.OSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OSToolStripMenuItem.Text = "Ordem de Serviço";
            this.OSToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OSToolStripMenuItem.Click += new System.EventHandler(this.OSToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.serviçoToolStripMenuItem1,
            this.ordemDeServiçoToolStripMenuItem1});
            this.relatórioToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            this.relatórioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.clienteToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // serviçoToolStripMenuItem1
            // 
            this.serviçoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.serviçoToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.serviçoToolStripMenuItem1.Name = "serviçoToolStripMenuItem1";
            this.serviçoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.serviçoToolStripMenuItem1.Text = "Serviço";
            this.serviçoToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ordemDeServiçoToolStripMenuItem1
            // 
            this.ordemDeServiçoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.ordemDeServiçoToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ordemDeServiçoToolStripMenuItem1.Name = "ordemDeServiçoToolStripMenuItem1";
            this.ordemDeServiçoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ordemDeServiçoToolStripMenuItem1.Text = "Ordem de Serviço";
            this.ordemDeServiçoToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCliente,
            this.tsbServico,
            this.tsbOS,
            this.tsbLogoff});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCliente
            // 
            this.tsbCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbCliente.Image")));
            this.tsbCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCliente.Name = "tsbCliente";
            this.tsbCliente.Size = new System.Drawing.Size(48, 35);
            this.tsbCliente.Text = "Cliente";
            this.tsbCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCliente.Click += new System.EventHandler(this.tsbCliente_Click);
            // 
            // tsbServico
            // 
            this.tsbServico.BackColor = System.Drawing.Color.Transparent;
            this.tsbServico.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbServico.Image = ((System.Drawing.Image)(resources.GetObject("tsbServico.Image")));
            this.tsbServico.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsbServico.Name = "tsbServico";
            this.tsbServico.Size = new System.Drawing.Size(49, 35);
            this.tsbServico.Text = "Serviço";
            this.tsbServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbServico.Click += new System.EventHandler(this.tsbServico_Click);
            // 
            // tsbOS
            // 
            this.tsbOS.BackColor = System.Drawing.Color.Transparent;
            this.tsbOS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbOS.Image = ((System.Drawing.Image)(resources.GetObject("tsbOS.Image")));
            this.tsbOS.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsbOS.Name = "tsbOS";
            this.tsbOS.Size = new System.Drawing.Size(105, 35);
            this.tsbOS.Text = "Ordem de Serviço";
            this.tsbOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOS.Click += new System.EventHandler(this.tsbOS_Click);
            // 
            // tsbLogoff
            // 
            this.tsbLogoff.BackColor = System.Drawing.Color.Transparent;
            this.tsbLogoff.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbLogoff.Image = ((System.Drawing.Image)(resources.GetObject("tsbLogoff.Image")));
            this.tsbLogoff.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsbLogoff.Name = "tsbLogoff";
            this.tsbLogoff.Size = new System.Drawing.Size(46, 35);
            this.tsbLogoff.Text = "Logoff";
            this.tsbLogoff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLogoff.Click += new System.EventHandler(this.tsbLogoff_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUsuario,
            this.tssIIP,
            this.tssINomePC,
            this.tssIData,
            this.tssIHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 724);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "status";
            // 
            // tsslUsuario
            // 
            this.tsslUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslUsuario.Name = "tsslUsuario";
            this.tsslUsuario.Size = new System.Drawing.Size(4, 17);
            // 
            // tssIIP
            // 
            this.tssIIP.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssIIP.Name = "tssIIP";
            this.tssIIP.Size = new System.Drawing.Size(4, 17);
            // 
            // tssINomePC
            // 
            this.tssINomePC.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssINomePC.Name = "tssINomePC";
            this.tssINomePC.Size = new System.Drawing.Size(4, 17);
            // 
            // tssIData
            // 
            this.tssIData.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssIData.Name = "tssIData";
            this.tssIData.Size = new System.Drawing.Size(4, 17);
            // 
            // tssIHora
            // 
            this.tssIHora.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssIHora.Name = "tssIHora";
            this.tssIHora.Size = new System.Drawing.Size(4, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1008, 746);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTelaPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmTelaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServiçoToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCliente;
        private System.Windows.Forms.ToolStripButton tsbServico;
        private System.Windows.Forms.ToolStripButton tsbOS;
        private System.Windows.Forms.ToolStripButton tsbLogoff;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tssIIP;
        private System.Windows.Forms.ToolStripStatusLabel tssINomePC;
        private System.Windows.Forms.ToolStripStatusLabel tssIData;
        private System.Windows.Forms.ToolStripStatusLabel tssIHora;
        private System.Windows.Forms.Timer timer1;
    }
}