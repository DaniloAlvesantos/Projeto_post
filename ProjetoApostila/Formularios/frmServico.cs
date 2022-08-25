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
    public partial class frmServico : Form
    {
        SqlConnection cn = new
        SqlConnection(Properties.Settings.Default.ServicoConnectionString);
        SqlCommand cmd = null;

        private void LimparCampo()
        {
            idServicoTextBox.Clear();
            nomeTextBox.Clear();
            descricaoTextBox.Clear();
            valorTextBox.Clear();
            dataDiaTextBox.Clear();
            cadastradoPorTextBox.Clear();
        }

        public frmServico()
        {
            InitializeComponent();
        }

        private void tbServisoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        { 
            try
            {
                if(frmLogin.nivelAcesso == "")
                {
                    bindingNavigatorDeleteItem.Enabled = false;
                }
                if(nomeTextBox.Text != "")
                {
                    if(dataDiaTextBox.Text == "")
                    {
                        dataDiaTextBox.Text = DateTime.Now.ToString();
                    }
                    if(cadastradoPorTextBox.Text == "")
                    {
                        cadastradoPorTextBox.Text = frmLogin.usuarioConectado;
                    }
                    this.Validate();
                    this.tbServisoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.servicoDataSet);
                    MessageBox.Show("Cadastro Realizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O Campo nome não pode ficar vazio", "Algo de errado...",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possível salvalr pelos seguinte motivo: " + ex.Message);
            }
        }

        private void frmServico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'servicoDataSet.tbServiso'. Você pode movê-la ou removê-la conforme necessário.
            this.tbServisoTableAdapter.Fill(this.servicoDataSet.tbServiso);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbmFiltrar.Text == "Código")
                {
                    // Instrução da var SQL e conecar no cn
                    string Sql = "SELECT * FROM tbServico WHERE idServico =" + txtPesquisar.Text + "";
                    // Lê os dados da Sql e conecta no cn
                    cmd = new SqlCommand(Sql, cn);
                    cn.Open();
                    // Define o valor da commandType para cmd
                    cmd.CommandType = CommandType.Text;
                    /* Representa um conjunto de comandos de dados e uma conexão de banco de dados
                     que são usados para preencher o Dataset e atualizar um banco de dados SQL Server */
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    // Representa uma tabela de dados na memória
                    DataTable servico = new DataTable();
                    // Adiciona ou atualiz linhas em um DataTable para que correspondam na fonte de dados usando o DataTable
                    da.Fill(servico);
                    // A tbUsuaripDtaGridView recebe o Datatable usuario
                    tbServisoDataGridView.DataSource = servico;
                }
                if(cbmFiltrar.Text == "Nome")
                {
                    string sql = "SELECT * FROM tbUsuario WHERE usuario LIKE '%" + txtPesquisar.Text + "%'";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable servico = new DataTable();
                    da.Fill(servico);
                    tbServisoDataGridView.DataSource = servico;
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if(frmLogin.nivelAcesso == "")
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void tbServisoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LimparCampo();
            idServicoTextBox.Text = tbServisoDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = tbServisoDataGridView.CurrentRow.Cells[1].Value.ToString();
            descricaoTextBox.Text = tbServisoDataGridView.CurrentRow.Cells[2].Value.ToString();
            observacaoTextBox.Text = tbServisoDataGridView.CurrentRow.Cells[3].Value.ToString();
            valorTextBox.Text = tbServisoDataGridView.CurrentRow.Cells[4].Value.ToString();
            dataDiaTextBox.Text = tbServisoDataGridView.CurrentRow.Cells[5].Value.ToString();
            cadastradoPorTextBox.Text = tbServisoDataGridView.CurrentRow.Cells[6].Value.ToString();

        }
    }
}
