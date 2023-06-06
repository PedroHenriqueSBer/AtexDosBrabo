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
    public partial class Form3 : Form
    {
        string[] dbsetings;
        public Form3(string host, string username, string table, string password)
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
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            MessageBox.Show("Volta para o início.");
            this.Hide();
            f1.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f4.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide();
            f4.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f5.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide();
            f5.ShowDialog();
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f6.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide();
            f6.ShowDialog();
            Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f8.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide();
            f8.ShowDialog();
            Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f7.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide();
            f7.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f2.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide();
            f2.ShowDialog();
            Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f12.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide();
            f12.ShowDialog();
            Close();
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Cursor = null;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
