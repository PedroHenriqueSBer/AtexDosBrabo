#criar schema
CREATE SCHEMA bd_atex;
use bd_atex;

#criar tabelas
CREATE TABLE cliente(
  id_Cliente INT NOT NULL,
  idade INT NOT NULL,
  nome VARCHAR(50) NOT NULL,
  nome_Escola VARCHAR(60)NOT NULL,
  anoEscolar INT NOT NULL,
  PRIMARY KEY(id_Cliente)
);

CREATE TABLE moderador(
  id_Moderador INT NOT NULL,
  email VARCHAR(255) NOT NULL,
  senha VARCHAR(15) NOT NULL,
  nome VARCHAR(50) NOT NULL,
  PRIMARY KEY(id_Moderador)
);

CREATE TABLE app(
  id_App INT NOT NULL,
  jogo_ou_rede BOOLEAN NOT NULL,
  nome VARCHAR(60) NOT NULL,
  id_Moderador INT NOT NULL,
  PRIMARY KEY(id_App),
  FOREIGN KEY (id_Moderador) REFERENCES moderador (id_Moderador)
);

CREATE TABLE perguntas(
  id_Pergunta INT NOT NULL,
  pergunta TEXT NOT NULL,
  id_App INT NOT NULL,
  PRIMARY KEY(id_Pergunta),
  FOREIGN KEY(id_App) REFERENCES app (id_App)
);
CREATE TABLE respostas(
  id_Resposta INT NOT NULL,
  resposta TEXT NOT NULL,
  id_Cliente INT NOT NULL,
  id_Pergunta INT NOT NULL,
  PRIMARY KEY(id_Resposta),
  Foreign Key (id_Cliente) REFERENCES cliente(id_Cliente),
  Foreign Key (id_Pergunta) REFERENCES perguntas(id_Pergunta)
);

INSERT INTO moderador
VALUE(1,'mod@gmail.com','senha123','Moderador 1');
#popular banco
#app
INSERT INTO app
VALUE(1,0,'Free Fire',1);

INSERT INTO app
VALUE(3,0,'Minecraft',1);

INSERT INTO app
VALUE(4,0,'Stumble Guys',1);
INSERT INTO app
VALUE(6,0,'Subway Surfs',1);
INSERT INTO app
VALUE(7,0,'Roblox',1);

#Redes Sociais
INSERT INTO app
VALUE(2,1,'YouTube',1);

INSERT INTO app
VALUE(5,1,'TikTok',1);
#perguntas
#FF
INSERT INTO perguntas
VALUE(1,'Por qual motivo você joga esse jogo?',1);
INSERT INTO perguntas
VALUE(2,'Em qual nível você está?',1);
INSERT INTO perguntas
VALUE(3,'Você joga com algum amigo? Digite seu nome',1);
INSERT INTO perguntas
VALUE(4,'Qual o objetivo do jogo?',1);
INSERT INTO perguntas
VALUE(5,'Voce recomendaria esse jogo para outra pessoa?',1);
INSERT INTO perguntas
VALUE(6,'Qual modo de jogo voce prefere?',1);
INSERT INTO perguntas
VALUE(7,'qunato tempo voce joga por dia?',1);
INSERT INTO perguntas
VALUE(8,'ha quanto tempo você joga?',1);

#Minezão

INSERT INTO perguntas
VALUE(9,'Quanto tempo você joga por dia?',3);
INSERT INTO perguntas
VALUE(10,'como voce conheceu minecraft?',3);
INSERT INTO perguntas
VALUE(11,'voce joga com algum amigo? digite seu nick',3);
INSERT INTO perguntas
VALUE(12,'Qual o objetivo do jogo?',3);

#Stumble guys

INSERT INTO perguntas
VALUE(13,'Quanto tempo você joga por dia?',4);
INSERT INTO perguntas
VALUE(14,'Em qual nível você está?',4);
VALUE(15,'Qual o objetivo do jogo?',4);
INSERT INTO perguntas
VALUE(16,'Já ganhou alguma vez? Se sim quantas vezes mais ou menos?',4);
#subway Surf
INSERT INTO perguntas
VALUE(17,'Voce joga quanto tempo por dia?',6);
INSERT INTO perguntas
VALUE(18,'Voce compete com seus amigos para ver quem faz mais pontos?',6);
INSERT INTO perguntas
VALUE(19,'Voce joga com amigo? Digite seu nome',6);
INSERT INTO perguntas
VALUE(20,'Qual objuetivo do jogo?',6);
INSERT INTO perguntas
VALUE(21,'Voce joga todos os dias? se nao quantas vezes por semana?',6);
INSERT INTO perguntas
VALUE(22,'qual o seu recorde de pontos? quanto tempo demorou para chegar nesse recorde?',6);
INSERT INTO perguntas
VALUE(23,'seus pais sabem que voce joga esse jogo?',6);
INSERT INTO perguntas
VALUE(24,'seus pais compram itens do jogo?',6);

#Roblox
INSERT INTO perguntas
VALUE(17,'Voce joga quanto tempo por dia?',7);
INSERT INTO perguntas
VALUE(18,'Qual seu jogo favorito no roblox?',7);
INSERT INTO perguntas
VALUE(19,'Voce joga com amigo? como se conheceram',7);
INSERT INTO perguntas
VALUE(20,'como é a sua comunicação com outros jogadores?',7);
INSERT INTO perguntas
VALUE(21,'algum jogador foi desrespeitoso com voce? se sim como reagiu?',7);
INSERT INTO perguntas
VALUE(22,'o que voce fez de mais legal no roblox?',7);
INSERT INTO perguntas
VALUE(23,'quais sao os itens ou acessorios que voce mais usa?',7);
INSERT INTO perguntas
VALUE(24,'como voce se sente no roblox, o que voce mais gosta de fazer no jogo?',7);
#Redes sociais
#YouTube
INSERT INTO perguntas
VALUE(14,'Quanto tempo por dia você fica no YouTube?',2);
INSERT INTO perguntas
VALUE(15,'Cite o canal que você mais gosta',2);
INSERT INTO perguntas
VALUE(16,'Qual o conteúdo desse canal?',2);
INSERT INTO perguntas
VALUE(17,'Recomende um vídeo',2);

#TikTok
INSERT INTO perguntas
VALUE(18,'Quanto tempo por dia você fica no TikTok?',5);
INSERT INTO perguntas
VALUE(19,'Vídeos de quem mais aparecem para você?',5);
INSERT INTO perguntas
VALUE(20,'Qual o conteúdo desse canal?',5);
INSERT INTO perguntas
VALUE(21,'Recomende um vídeo',5);