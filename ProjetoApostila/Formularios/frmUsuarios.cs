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
    public partial class frmUsuarios : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.ServicoConnectionString);
        SqlCommand cmd;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();

        }

        private void tbUsuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();

        }
        private void LimparCampo()
        {
            idUsuarioTextBox.Clear();
            usuarioTextBox.Clear();
            senhaTextBox.Clear();
            repitaSenhaTextBox.Clear();
            nivelAcesso.SelectedIndex = -1;
            dataDiaTextBox.Clear();
            cadastradoPorTextBox.Clear();
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servicoDataSet);
            try
            {
                if ((usuarioTextBox.Text != "") && (senhaTextBox.Text != "") && (repitaSenhaTextBox.Text != "") && (dataDiaTextBox.Text != ""))
                {
                    if(senhaTextBox.Text == repitaSenhaTextBox.Text)
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
                        this.tbUsuarioBindingSource.EndEdit();
                        MessageBox.Show("Cadastrodo realizado com sucesso");
                        this.tbUsuarioTableAdapter.Update(this.servicoDataSet.tbUsuario);
                    }
                    else
                    {
                        // Se ele não retornou nem um dado...
                        MessageBox.Show(
                            "As senhas estão diferentes",
                            "Aviso de Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                }
                else
                {
                    // Se os campos tiverem vazios...
                    MessageBox.Show(
                        "Todos não podem ficar vazios",
                        "Aviso de Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
            // Erro
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível salvar pelo seguinte motivo: " + ex.Message);
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'servicoDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.servicoDataSet.tbUsuario);

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbmFiltrar.Text == "Código")
                {
                    string sql = "SELECT * FROM tbUsuario WHERE idUsuario = " + txtPesquisar.Text + "";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable usuario = new DataTable();
                    da.Fill(usuario);
                    tbUsuarioDataGridView.DataSource = usuario;
                }
                if (cbmFiltrar.Text == "Usuário") {
                    string sql = "SELECT * FROM tbUsuario WHERE usuario LIKE '%" + txtPesquisar.Text + "%'";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable usuario = new DataTable();
                    da.Fill(usuario);
                    tbUsuarioDataGridView.DataSource = usuario;
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

        private void tbUsuarioDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idUsuarioTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[0].Value.ToString();
            usuarioTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[1].Value.ToString();
            senhaTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[2].Value.ToString();
            repitaSenhaTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[3].Value.ToString();
            nivelAcesso.Text = tbUsuarioDataGridView.CurrentRow.Cells[4].Value.ToString();
            dataDiaTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[5].Value.ToString();
            cadastradoPorTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmServico serv = new frmServico();
            serv.Show();
        }

        private void frmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
