using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioLogin.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        List<string> usuarios = new List<string>()
        {
            "jorgin",
            "cleitin",
            "paulin",
            "fabiozin",
            "robertozin",
        };
        
        List<string> senhas = new List<string>()
        {
            "senha123",
            "senha124",
            "senha125",
            "senha126",
            "senha127",
        };

        private void textBoxNome_enter(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "Usuario")
            {
                textBoxNome.Text = "";
            }
        }
        private void textBoxNome_leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                textBoxNome.Text = "Usuario";
            }
        }

        private void textBoxSenha_enter(object sender, EventArgs e)
        {
            if (textBoxSenha.Text == "Senha")
            {
                textBoxSenha.Text = "";
                textBoxSenha.PasswordChar = '*';
            }
        }
        private void textBoxSenha_leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSenha.Text))
            {
                textBoxSenha.PasswordChar = '\u0000';
                textBoxSenha.Text = "Senha";
            }
        }

        private void bntLogar_click(object sender, EventArgs e)
        {
            if (usuarios.Contains(textBoxNome.Text) && senhas.Contains(textBoxSenha.Text))
            {
                int posicaoNome = usuarios.IndexOf(textBoxNome.Text);
                int posicaoSenha = senhas.IndexOf(textBoxSenha.Text);

                if (posicaoNome == posicaoSenha)
                {
                    MessageBox.Show("Logado com sucesso!", "Valorant", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Tabela novaTela = new Tabela();
                    this.Hide();
                    novaTela.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Dados incorretos", "Valorant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Dados incorretos", "Valorant", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
