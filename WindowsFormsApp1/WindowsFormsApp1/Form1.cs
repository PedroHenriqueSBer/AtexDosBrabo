using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string[] dbsetings;
        public Form1(string host, string username, string table, string password)
        {
            InitializeComponent();
            dbsetings = new string[4] { host, username, table, password  };
            WorkBench w = new WorkBench(host,username,table,password);
            db = new DataBase(w);
        }
        cliente cl = new cliente();
        DataBase db;
        private void button1_Click_1(object sender, EventArgs e)
        {
            cl.nome = txtNome.Text;
            cl.escola = txtEscola.Text;
            cl.idade = int.Parse(txtIdade.Text);
            cl.ano = int.Parse(txtSerie.Text);
            db.CriarCliente(ref cl);
            MessageBox.Show($"Bem vindo, {txtNome.Text}");

            Form2 f2 = new Form2(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f2.CL(cl.id,cl.nome,cl.escola, cl.idade, cl.ano);
            this.Hide();
            f2.ShowDialog();
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form13 f13 = new Form13(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            this.Hide();
            f13.ShowDialog();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
