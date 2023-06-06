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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form14 : Form
    {
        string[] dbsetings;
        string[] texts;
        int[] idpgts;
        public Form14(string host, string username, string table, string password, string[] texts, int[] idpgts)
        {
            InitializeComponent();
            dbsetings = new string[4] { host, username, table, password };
            WorkBench w = new WorkBench(host, username, table, password);
            db = new DataBase(w);
            app = db.resgatarApp(1);
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
            for(int i = 0;  i < texts.Length; i++) {
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
            string[] textac = new string[]{ textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text };
            for (int i = 0; i < 4; i++)
            {
                r = new resposta();
                r.cl = cl;
                r.resp = textac[i];
                r.id_perg = app.pergunts[i+4].id_Pergunta;
                rl.Add(r);
            }
            foreach(var i in rl)
                db.Responder(i);
            Form2 f2 = new Form2(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f2.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
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

        private void label12_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(dbsetings[0], dbsetings[1], dbsetings[2], dbsetings[3]);
            f4.CL(cl.id, cl.nome, cl.escola, cl.idade, cl.ano);
            this.Hide();
            f4.ShowDialog();
            Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }
    }
}
