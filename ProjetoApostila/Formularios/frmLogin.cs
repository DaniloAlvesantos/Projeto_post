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
using System.Threading;
namespace ProjetoApostila
{
    public partial class frmLogin : Form
    {
        public static string nivelAcesso;
        public static string usuarioConectado;
        // Conexão com o banco
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ServicoConnectionString);
        public frmLogin()
        {
            Thread load = new Thread(new ThreadStart(SplashScreen));
            load.Start();
            Thread.Sleep(5000);
            load.Abort();
            InitializeComponent();
        }
        public void SplashScreen()
        {
            Application.Run(new Formularios.frmSplash());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((usuarioComboBox.Text != "") && (nivelAcessoComboBox.Text != "") && (senhaTextBox.Text != ""))
                {
                    SqlCommand comm = new SqlCommand("Select * From tbUsuario where usuario = @usuario and " + "senha = @senha and nivelAcesso = @nivel", conn);
                    comm.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuarioComboBox.Text;
                    comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senhaTextBox.Text;
                    comm.Parameters.Add("@nivel", SqlDbType.VarChar).Value = nivelAcessoComboBox.Text;
                    // Abrir conexão
                    conn.Open();
                    SqlDataReader reader = null;
                    // Lê as linhas de uma base de dados SQL Server
                    reader = comm.ExecuteReader();
                    if (reader.Read()) // Se tiver algo para lê faça...
                    {
                        usuarioConectado = usuarioComboBox.Text; // usuarioConectado recebe o valor do usuario
                        nivelAcesso = nivelAcessoComboBox.Text; // var recebe o tipo de user
                        Formularios.frmTelaPrincipal main = new Formularios.frmTelaPrincipal();
                        this.Hide();
                        main.Show();
                    } else
                    {
                        // Se ele não retornou nem um dado...
                        MessageBox.Show(
                            "Usuario e/ou senha incorretas",
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
                        "Todos os campos obrigatórios",
                        "Aviso de Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
            // Erro
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Etapa final, fechar conexão com o banco...
            finally
            {
                conn.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'servicoDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.servicoDataSet.tbUsuario);
            // TODO: esta linha de código carrega dados na tabela 'servicoDataSet.tbOrdemServico'. Você pode movê-la ou removê-la conforme necessário.
            this.tbOrdemServicoTableAdapter.Fill(this.servicoDataSet.tbOrdemServico);
            usuarioComboBox.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.testes test = new Formularios.testes();
            this.Hide();
            test.Show();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
