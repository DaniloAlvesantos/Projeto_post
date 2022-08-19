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
    public partial class testes : Form
    {
        public testes()
        {
            InitializeComponent();
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servicoDataSet);

        }

        private void testes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'servicoDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.servicoDataSet.tbUsuario);

        }
    }
}
