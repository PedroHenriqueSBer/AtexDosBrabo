using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Class1
    {
        public partial class FormRegistro : Form
        {
            public FormRegistro()
            {
                InitializeComponent();
            }

            private void btnRegistrar_Click(object sender, EventArgs e)
            {
                // Instancia um novo objeto de registro com os dados informados
                Registro novoRegistro = new Registro(txtNome.Text, txtEmail.Text, txtTelefone.Text);

                // Exibe uma mensagem de confirmação com os dados registrados
                MessageBox.Show("Registro efetuado com sucesso!" + Environment.NewLine +
                    "Nome: " + novoRegistro.Nome + Environment.NewLine +
                    "E-mail: " + novoRegistro.Email + Environment.NewLine +
                    "Telefone: " + novoRegistro.Telefone);
            }
        }

        public class Registro
        {
            // Propriedades para armazenar os dados do registro
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }

            // Construtor que recebe os dados do registro
            public Registro(string nome, string email, string telefone)
            {
                this.Nome = nome;
                this.Email = email;
                this.Telefone = telefone;
            }
        }
    }
}
}
