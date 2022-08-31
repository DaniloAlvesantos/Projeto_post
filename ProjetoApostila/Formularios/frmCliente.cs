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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(Properties.Settings.Default.ServicoConnectionString);
        SqlCommand cmd = null;

        private void LimparCampo()
        {
            idClienteTextBox.Clear();
            nomeTextBox.Clear();
            cpfMaskedTextBox.Clear();
            telefoneMaskedTextBox.Clear();
            enderecoTextBox.Clear();
            bairroTextBox.Clear();
            cidadeTextBox.Clear();
            estadoComboBox.SelectedIndex = -1;
            dataDiaTextBox.Clear();
            cadastradoPorTextBox.Clear();
        }
        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmLogin.nivelAcesso == "Operador")
                    bindingNavigatorDeleteItem.Enabled = false;
                if ((nomeTextBox.Text != "") && (cpfMaskedTextBox.Text != ""))
                {
                    if (dataDiaTextBox.Text == "")
                        dataDiaTextBox.Text = DateTime.Now.ToString();
                    if (cadastradoPorTextBox.Text == "")
                        cadastradoPorTextBox.Text = frmLogin.usuarioConectado;
                    if (validarCPF(cpfMaskedTextBox.Text))
                    {
                        this.Validate();
                        this.tbClienteBindingSource.EndEdit();
                        this.tbClienteTableAdapter.Update(this.servicoDataSet.tbCliente);
                    }
                    else
                        MessageBox.Show("CPF incorreto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("O Campo 'Nome' e 'CPF' não podem ficar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                    MessageBox.Show("Não foi possivel salvar pelo seguinte motivo:" + ex.Message);
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'servicoDataSet.tbOrdemServico'. Você pode movê-la ou removê-la conforme necessário.
            this.tbOrdemServicoTableAdapter.Fill(this.servicoDataSet.tbOrdemServico);
            // TODO: esta linha de código carrega dados na tabela 'servicoDataSet.tbOrdemServico'. Você pode movê-la ou removê-la conforme necessário.
            this.tbOrdemServicoTableAdapter.Fill(this.servicoDataSet.tbOrdemServico);
            // TODO: esta linha de código carrega dados na tabela 'servicoDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.servicoDataSet.tbCliente);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbmFiltrar.Text == "Código")
                {
                    string sql = "SELECT * FROM tbCliente WHERE idCliente =" + txtPesquisar.Text + "";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable cliente = new DataTable();
                    da.Fill(cliente);
                    tbClienteDataGridView.DataSource = cliente;
                }
                if (cbmFiltrar.Text == "Nome")
                {
                    string sql = "SELECT * FROM tbCliente WHERE nome LIKE '%" + txtPesquisar.Text + "%'";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable cliente = new DataTable();
                    da.Fill(cliente);
                    tbClienteDataGridView.DataSource = cliente;
                }
                if (cbmFiltrar.Text == "CPF")
                {
                    string sql = "SELECT * FROM tbCliente WHERE cpf = '" + txtPesquisar.Text + "'";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable cliente = new DataTable();
                    da.Fill(cliente);
                    tbClienteDataGridView.DataSource = cliente;
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

        private void cbmFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmFiltrar.Text == "Código")
                txtPesquisar.Mask = "";
            if (cbmFiltrar.Text == "Nome")
                txtPesquisar.Mask = "";
            if (cbmFiltrar.Text == "CPF")
                txtPesquisar.Mask = "000,000,000-00";
            if (cbmFiltrar.Text == "")
                txtPesquisar.Mask = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try 
            {
                string sql = "SELECT * FROM tbOrdemServico WHERE idCliente ='" + txtPesquisar.Text + "'";
                cmd = new SqlCommand(sql, cn);
                cn.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable os = new DataTable();
                da.Fill(os);
                tbOrdemServicoDataGridView.DataSource = os;
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
            if (frmLogin.nivelAcesso == "Operador")
                bindingNavigatorDeleteItem.Enabled = false;
        }

        public static bool validarCPF (string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                return false;
        
    }
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            }
            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) *
               multiplicador2[i];
            }

            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        private void tbClienteDataGridView_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            LimparCampo();
            idClienteTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            cpfMaskedTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[2].Value.ToString();
            telefoneMaskedTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[3].Value.ToString();
            enderecoTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[4].Value.ToString();
            bairroTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[5].Value.ToString();
            cidadeTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[6].Value.ToString();
            estadoComboBox.Text = tbClienteDataGridView.CurrentRow.Cells[7].Value.ToString();
            dataDiaTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[8].Value.ToString();
            cadastradoPorTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
