using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class DataBase {
        WorkBench w;
        public DataBase(WorkBench w)
        {
            this.w = w;
        }

        public App resgatarApp(int id)
        {
            App aux = new App();
            aux.pergunts = new List<Pergunt>();
            Pergunt p;
            List<string[]> ls = w.SELECT($"SELECT DISTINCT a.jogo_ou_rede,a.nome FROM perguntas p INNER JOIN app a ON p.`id_App` = a.`id_App` WHERE a.`id_App` = {id};", 2);
            aux.jogo_ou_rede = (ls[0][0] == "1")? true : false;
            aux.nome = ls[0][1];
            ls = w.SELECT($"SELECT DISTINCT p.`id_Pergunta`, p.pergunta FROM perguntas p INNER JOIN app a ON p.`id_App` = a.`id_App` WHERE a.`id_App` = {id};", 2);
            for(int i = 0; i < ls.Count; i++)
            {
                p = new Pergunt();
                p.id_Pergunta = int.Parse(ls[i][0]);
                p.pergunta = ls[i][1];
                aux.pergunts.Add(p);
            }
            return aux;
        }
        public bool Responder(resposta r) => 
            w.Quarry($"INSERT INTO respostas VALUES(DEFAULT,\"{r.resp}\",{r.cl.id},{r.id_perg})");    
        public bool DeleteCliente(cliente cl) =>
            w.Quarry($"DELETE FROM cliente WHERE `id_Cliente` = {cl.id};");
        public bool CriarCliente(ref cliente cl)
        {
            List<string[]> s = w.SELECT($"SELECT `id_Cliente` from cliente ORDER BY `id_Cliente` DESC;",1);
            if (s.Count > 0)
                cl.id = int.Parse(s[0][0])+1;
            else
                cl.id = 1;
            return w.Quarry($"INSERT INTO cliente VALUE({cl.id},{cl.idade},\"{cl.nome}\",\"{cl.escola}\",{cl.ano});");
        }

    }
    internal struct cliente
    {
        public int id;
        public string nome;
        public string escola;
        public int idade;
        public int ano;
    }
    internal struct resposta {
        public cliente cl;
        public int id_perg;
        public string resp;
    }
    internal struct Pergunt {
        public int id_Pergunta;
        public string pergunta;
    }
    internal struct App
    {
        public bool jogo_ou_rede { get; set; }
        public string nome { get; set; }
        public List<Pergunt> pergunts { get; set; }

    }
}