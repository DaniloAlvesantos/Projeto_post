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

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            label1.Text = "Olá, " + frmLogin.usuarioConectado;
        }
    }
}
