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
    public partial class frmServico : Form
    {
        public frmServico()
        {
            InitializeComponent();
        }

        private void tbServisoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbServisoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servicoDataSet);

        }

        private void frmServico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'servicoDataSet.tbServiso'. Você pode movê-la ou removê-la conforme necessário.
            this.tbServisoTableAdapter.Fill(this.servicoDataSet.tbServiso);

        }
    }
}
