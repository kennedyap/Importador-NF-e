using NFe_SeniorSistemas.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NFe_SeniorSistemas.Forms
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        bool CheckInformations()
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("As informações de Usuário devem ser preenchidas.", "Preencha as Informações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInformations())
                {
                    string login = txtUsuario.Text;
                    string senha = txtSenha.Text;
                    string email = txtEmail.Text;
                    BdDados.InsertUsuario(login, senha, email);

                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    this.Close();

                    Login frmlogin = new Login();
                    frmlogin.Show();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Ocorreu um erro." + erro);
            }
        }

        private void Cadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login frmlogin = new Login();
            frmlogin.Show();
        }
    }
}
