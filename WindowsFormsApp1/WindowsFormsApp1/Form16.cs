using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form16 : Form
    {
        string[] dbsetings;
        string[] texts;
        int[] idpgts;
        public Form16(string host, string username, string table, string password, string[] texts, int[] idpgts)
        {
            InitializeComponent();
            dbsetings = new string[4] { host, username, table, password };
            WorkBench w = new WorkBench(host, username, table, password);
            db = new DataBase(w);
            app = db.resgatarApp(7);
            this.texts = texts;
            this.idpgts = idpgts;
        }
        List<resposta> rl = new List<resposta>();
        cliente cl = new cliente();
        DataBase db;
        App app;
        public void CL(int id, string nome, string escola, int idade, int ano)
        {
            cl = new cliente();
            cl.id = id;
            cl.nome = nome;
            cl.escola = escola;
            cl.idade = idade;
            cl.ano = ano;
            resposta r;
            for (int i = 0; i < texts.Length; i++)
            {
                r = new resposta();
                r.cl = cl;
                r.resp = texts[i];
                r.id_perg = idpgts[i];
                rl.Add(r);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            resposta r;
            string[] textac = new string[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text };
            for (int i = 0; i < 3; i++)
            {
                r = new resposta();
                r.cl = cl;
                r.resp = textac[i];
                r.id_perg = app.pergunts[i+4].id_Pergunta;
                rl.Add(r);
            }
            foreach (var i in rl)
                db.Responder(i);

            Form2 f2 = new Form2(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            this.Hide();
            f2.ShowDialog();
            Close();
        }

        public string Mostra()
        {
            string aux = "";
            aux = $"5. {textBox1.Text}\n6. {textBox2.Text}" +
                $"\n7. {textBox3.Text}\n8. {textBox4.Text}";
            return aux;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f2.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide();
            f2.ShowDialog();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f3.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide();
            f3.ShowDialog();
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f9.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide();
            f9.ShowDialog();
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

        private void label11_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f8.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide();
            f8.ShowDialog();
            Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
