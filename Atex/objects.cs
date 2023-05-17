using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atex
{
    internal class Cliente {
        private int? Id;
        private string nome;
        private int idade;
        private string escola;
        private string ano;
        private List<Resposta> respostas;
    }
    internal class Moderador
    {
        private int? Id;
        private string nome;
        private string senha;
        private string email;

        public bool Post(WorkBench w)
        {
            if (Id == null)
                return w.Quarry($"\r\nUPDATE moderador SET nome = \"{nome}\",senha = \"{senha}\",email = \"{email}\" WHERE id = {Id};");
            return w.Quarry($"INSERT INTO moderador (id,nome,senha,email) VALUES (DEFAULT,\"{nome}\",\"{senha}\",\"{email}\")");
        }
        public bool Get(WorkBench w, int id)
        {
            List<string[]> ls = w.SELECT($"SELECT * FROM moderador WHERE id = {id};", 4);
            if (ls.Count == 0)
                return false;
            Id = int.Parse(ls[0][0]);
            nome = ls[0][1];
            senha = ls[0][2];
            email = ls[0][3];
            return true;
        }
    }
    internal struct Resposta {
        public int IdPergunta;
        public string resposta;
    }
    internal struct Pergunta
    {
        public int? id;
        public string pergunta;
    }
    internal class App
    {
        private int? id;
        private List<Pergunta> perguntas = new List<Pergunta>();
        private string nome;
        private bool jApp;

        public string Nome { get => nome; }
        public bool JApp { get => JApp; }
        internal List<Pergunta> Perguntas { get => perguntas; }

        public void Cadastrar(string nome, bool Japp)
        {
            this.nome = nome;
            this.jApp = Japp;
        }
        public void CadastrarPergunta(string Pergunta)
        {
            Pergunta p = new Pergunta();
            p.id = null;
            p.pergunta = Pergunta;
            perguntas.Add(p);
        }
    }
}
/*
CREATE SCHEMA Atex;

USE Atex;
CREATE Table cliente (
   id int PRIMARY KEY AUTO_INCREMENT NOT NULL,
   nome VARCHAR(100) NOT NULL,
   idade int NOT NULL,
   escola VARCHAR(100) NOT NULL,
   ano VARCHAR(10) NOT NULL
);
CREATE Table moderador (
   id int PRIMARY KEY AUTO_INCREMENT NOT NULL,
   nome VARCHAR(100) NOT NULL,
   senha VARCHAR(100) not NULL,
   email VARCHAR(100) not NULL
);
CREATE Table app(
   id int PRIMARY KEY AUTO_INCREMENT NOT NULL,
   nome VARCHAR(100) NOT NULL,
   Japp BOOLEAN NOT NULL
);
CREATE Table pergunta (
   id int PRIMARY KEY AUTO_INCREMENT NOT NULL,
   nome VARCHAR(100) NOT NULL,
   idApp int not NULL,
   Foreign Key (idApp) REFERENCES app(id)
);
CREATE Table respostas(
   idPergunta int NOT NULL,
   idcliente int NOT NULL,
   resposta VARCHAR(100) NOT NULL,
   PRIMARY KEY(idPergunta,idcliente),
   Foreign Key (idPergunta) REFERENCES pergunta(id),
   Foreign Key (idcliente) REFERENCES cliente(id)
);
 */