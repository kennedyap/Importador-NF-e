using NFe_SeniorSistemas.Banco;
using NFe_SeniorSistemas.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace NFe_SeniorSistemas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        bool CheckInformations()
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("As informações de Usuário e Senha devem ser preenchidas.", "Preencha as Informações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckInformations())
            {
                string login = txtUsuario.Text;
                string senha = txtSenha.Text;
                DataTable dt = BdDados.SelectUsuarioLogin(login, senha);

                try
                {
                    if (dt.Rows.Count > 0)
                    {
                        this.Hide();
                        Principal pr = new Principal();
                        pr.Show();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum Usuário encontrado com estes parêmetros, tente novamente.", "Nenhum Usuário Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Text = "";
                        txtSenha.Text = "";
                        txtUsuario.Focus();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ops! Ocorreu um erro, tente novamente. " + erro.StackTrace);
                    txtUsuario.Focus();
                };
            }
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro frmCadastro = new Cadastro();
            frmCadastro.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblEsqueciaSenha_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                DataTable dt = BdDados.SelectEmailRecuperacao(txtUsuario.Text);

                if (dt.Rows.Count > 0)
                {
                    try
                    {
                        string senhaBase = "ABCDEFGHIJLMNOPQRSTUVXZabcdefghijlmnopqrstuvxz123456789";
                        Random rnd = new Random();

                        StringBuilder str = new StringBuilder();

                        for (int i = 0; i < 15; i++)
                        {
                            int aleatorio = rnd.Next(0, senhaBase.Length);
                            str.Append(senhaBase[aleatorio].ToString());
                        }

                        MailMessage mensagem = new MailMessage("contatestesup91@gmail.com", dt.Rows[0].ItemArray[0].ToString());
                        {
                            mensagem.Subject = "Recuperação de E-mail";
                            mensagem.IsBodyHtml = true;
                            mensagem.Body = "<table class='blueTable'>" +
                                                "<thead>" +
                                                    "<tr>" +
                                                        "<th>Recuperação de Senha</th>" +
                                                    "</tr>" +
                                                "</thead>" +
                                                "<tbody>" +
                                                    "<tr>" +
                                                        "<td>Olá Usuário, se você recebeu este E-mail quer dizer que você solicitou uma nova senha para acesso ao nosso sistema.<BR></td>" +
                                                    "</tr>" +
                                                    "<tr>" +
                                                        "<td style = 'text-align:center'> Sua nova senha é: <b>" + str + "</b></td>" +
                                                    "</tr>" +
                                                "</tbody>" +
                                            "</table>'";
                            mensagem.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                            mensagem.BodyEncoding = Encoding.GetEncoding("UTF-8");
                        };

                        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = new NetworkCredential(Properties.Settings.Default.ConfiguracoesEmail, Properties.Settings.Default.ConfiguracoesSenha);

                        smtpClient.EnableSsl = true;
                        smtpClient.Send(mensagem);

                        BdDados.UpdateUsuario(txtUsuario.Text, Convert.ToString(str));

                        MessageBox.Show("E-mail enviado com sucesso" + Environment.NewLine + "Você poderá voltar a fazer o login com a sua nova senha.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Houve um erro ao enviar o E-mail, favor verifique:" + error.StackTrace + Environment.NewLine + error.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum usuário encontrado com as informações fornecidas, você tem certeza que digitou tudo corretamente?", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Para recuperar a senha você deve digitar seu usuário.", "Usuário incorreto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Text = "";
                txtUsuario.Focus();
            }
        }
    }
}
