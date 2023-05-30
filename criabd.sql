-- Active: 1683240226230@@127.0.0.1@3306@atex
#Cria o schema do banco de dados
CREATE SCHEMA Atex;
#Criação das Tabelas
CREATE TABLE Cliente (
  Id_Cliente INT NOT NULL,
  Idade INT NOT NULL,
  Nome VARCHAR(50) NOT NULL,
  Nome_Escola VARCHAR(60) NOT NULL,
  AnoEscolar INT NOT NULL,
  PRIMARY KEY (Id_Cliente)
);

CREATE TABLE Respostas (
  Id_Resposta INT NOT NULL,
  Resposta TEXT NOT NULL,
  PRIMARY KEY (Id_Resposta)
);

CREATE TABLE Perguntas (
  Id_Pergunta INT NOT NULL,
  Pergunta TEXT NOT NULL,
  PRIMARY KEY (Id_Pergunta)
);

CREATE TABLE Contem (
  Id_Resposta INT NOT NULL,
  Id_Pergunta INT NOT NULL,
  FOREIGN KEY (Id_Resposta) REFERENCES Respostas(Id_Resposta),
  FOREIGN KEY (Id_Pergunta) REFERENCES Perguntas(Id_Pergunta)
);

CREATE TABLE App (
  Id_App INT NOT NULL,
  Japp VARCHAR(255) NOT NULL,
  Nome VARCHAR(50) NOT NULL,
  PRIMARY KEY (Id_App)
);

CREATE TABLE Cria (
  Id_App INT NOT NULL,
  Id_Pergunta INT NOT NULL,
  FOREIGN KEY (Id_App) REFERENCES App(Id_App),
  FOREIGN KEY (Id_Pergunta) REFERENCES Perguntas(Id_Pergunta)
);

CREATE TABLE Moderador (
  Id_Moderador INT NOT NULL,
  Email VARCHAR(255) NOT NULL,
  Senha VARCHAR(15) NOT NULL,
  Nome VARCHAR(50) NOT NULL,
  PRIMARY KEY (Id_Moderador)
);