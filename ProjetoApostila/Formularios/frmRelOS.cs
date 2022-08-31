using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoApostila.Formularios
{
    public partial class frmRelOS : Form
    {
        public frmRelOS()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(Properties.Settings.Default.ServicoConnectionString);
        SqlCommand cmd = null;

        private void LimparCampo()
        {
            idOrdemTextBox.Clear();
            idServicoComboBox.SelectedIndex = -1;
            idClienteComboBox.SelectedIndex = -1;
            dataDiaTextBox.Clear();
            cadastradoPorTextBox.Clear();
        }

        private void tbOrdemServicoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (frmLogin.nivelAcesso == "Operador")
                {
                    bindingNavigatorDeleteItem.Enabled = false;
                }
                if ((idClienteComboBox.Text != "") && (idServicoComboBox.Text != ""))
                {
                    if (dataDiaTextBox.Text == "")
                        dataDiaTextBox.Text = DateTime.Now.ToString();
                    if (cadastradoPorTextBox.Text == "")
                        cadastradoPorTextBox.Text = frmLogin.usuarioConectado;
                    this.Validate();
                    this.tbOrdemServicoBindingSource.EndEdit();
                    this.tbOrdemServicoTableAdapter.Update(this.servicoDataSet.tbOrdemServico);
                    MessageBox.Show("Cadastro realaizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Todos os campos são obrigatorio");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void frmRelOS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'servicoDataSet.tbServiso'. Você pode movê-la ou removê-la conforme necessário.
            this.tbServisoTableAdapter.Fill(this.servicoDataSet.tbServiso);
            // TODO: esta linha de código carrega dados na tabela 'servicoDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.servicoDataSet.tbCliente);
            // TODO: esta linha de código carrega dados na tabela 'servicoDataSet.tbOrdemServico'. Você pode movê-la ou removê-la conforme necessário.
            this.tbOrdemServicoTableAdapter.Fill(this.servicoDataSet.tbOrdemServico);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código OS")
                {
                    string sql = "SELECT * FROM tbOrdemServico WHERE idOrdem =" + txtPesquisar.Text + "";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable os = new DataTable();
                    da.Fill(os);
                    tbOrdemServicoDataGridView.DataSource = os;
                }
                if (cbmFiltrar.Text == "Código Cliente")
                {
                    string sql = "SELECT * FROM tbOrdemServico WHERE idOrdem =" + txtPesquisar.Text + "";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable os = new DataTable();
                    da.Fill(os);
                    tbOrdemServicoDataGridView.DataSource = os;
                }
                if (cbmFiltrar.Text == "Código Serviço")
                {
                    string sql = "SELECT * FROM tbOrdemServico WHERE idOrdem =" + txtPesquisar.Text + "";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable os = new DataTable();
                    da.Fill(os);
                    tbOrdemServicoDataGridView.DataSource = os;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if(frmLogin.nivelAcesso == "Operador")
                bindingNavigatorDeleteItem.Enabled = false;
        }

        private void tbOrdemServicoDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idOrdemTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[0].Value.ToString();
            idClienteComboBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[1].Value.ToString();
            idServicoComboBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[2].Value.ToString();
            dataDiaTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[3].Value.ToString();
            cadastradoPorTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[4].Value.ToString();

        }
    }
}
