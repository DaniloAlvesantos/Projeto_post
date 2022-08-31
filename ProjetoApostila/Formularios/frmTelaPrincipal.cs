using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoApostila.Formularios
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }
        Form mdiChildForm = new Form();
        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            mdiChildForm.MdiParent = this;
            if(frmLogin.nivelAcesso == "Operador")
                usuarioToolStripMenuItem.Visible = false;
            tsslUsuario.Text = "Usuário: " + frmLogin.usuarioConectado;
            string myHost = System.Net.Dns.GetHostName();
            tssINomePC.Text = "Nome do PC: " + myHost;
            System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostEntry(myHost);
            foreach(System.Net.IPAddress myIP in myIPs.AddressList)
            {
                tssIIP.Text = "IP: " + myIP;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssIData.Text = DateTime.Now.ToString("HH:mm");
        }

        private void tsbLogoff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }   
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsuarios usuario = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmUsuarios)
                    {
                        usuario = (frmUsuarios)frm;
                        break;
                    }
                }
                if (usuario == null)
                {
                    usuario = new frmUsuarios();
                    usuario.MdiParent = this;
                    usuario.Show();
                }
                usuario.Focus();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente cliente = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCliente)
                    {
                        cliente = (frmCliente)frm;
                        break;
                    }
                }
                if (cliente == null)
                {
                    cliente = new frmCliente();
                    cliente.MdiParent = this;
                    cliente.Show();
                }
                cliente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void servicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmServico servico = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmServico)
                    {
                        servico = (frmServico)frm;
                        break;
                    }
                }
                if (servico == null)
                {
                    servico = new frmServico();
                    servico.MdiParent = this;
                    servico.Show();
                }
                servico.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelOS OS = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmRelOS)
                    {
                        OS = (frmRelOS)frm;
                        break;
                    }
                }
                if (OS == null)
                {
                    OS = new frmRelOS();
                    OS.MdiParent = this;
                    OS.Show();
                }
                OS.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbCliente_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente cliente = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCliente)
                    {
                        cliente = (frmCliente)frm;
                        break;
                    }
                }
                if (cliente == null)
                {
                    cliente = new frmCliente();
                    cliente.MdiParent = this;
                    cliente.Show();
                }
                cliente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbServico_Click(object sender, EventArgs e)
        {
            try
            {
                frmServico servico = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmServico)
                    {
                        servico = (frmServico)frm;
                        break;
                    }
                }
                if (servico == null)
                {
                    servico = new frmServico();
                    servico.MdiParent = this;
                    servico.Show();
                }
                servico.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbOS_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelOS OS = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmRelOS)
                    {
                        OS = (frmRelOS)frm;
                        break;
                    }
                }
                if (OS == null)
                {
                    OS = new frmRelOS();
                    OS.MdiParent = this;
                    OS.Show();
                }
                OS.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
