using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form9 : Form
    {
        string[] dbsetings;
        public Form9(string host, string username, string table, string password)
        {
            InitializeComponent();
            dbsetings = new string[4] { host, username, table, password };
            WorkBench w = new WorkBench(host, username, table, password);
            db = new DataBase(w);
        }
        cliente cl = new cliente();
        DataBase db;
        public void CL(int id, string nome, string escola, int idade, int ano)
        {
            cl = new cliente();
            cl.id = id;
            cl.nome = nome;
            cl.escola = escola;
            cl.idade = idade;
            cl.ano = ano;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f11.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide();
            f11.ShowDialog();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f10.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide();
            f10.ShowDialog();
            Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f2.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide(); f2.ShowDialog();
            Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f12.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide(); f12.ShowDialog();
            Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
