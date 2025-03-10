CREATE DATABASE Biblioteca;
Use Biblioteca;

CREATE TABLE Livro (
    ID int NOT NULL AUTO_INCREMENT,
    isbn varchar(255) NOT NULL,
    titulo varchar(255) NOT NULL,
    autor varchar(255) NOT NULL,
    ano int,
    genero varchar(255) NOT NULL,
    edicao int,
    quantidade int,
    PRIMARY KEY (ID)
);

CREATE TABLE Aluno(
	ID int NOT NULL AUTO_INCREMENT,
    cpf varchar(255) NOT NULL,
    nome varchar(255) NOT NULL,
    nascimento varchar(255) NOT NULL,
    PRIMARY KEY (ID)
);

DROP TABLE Livro;

SELECT * FROM Livro;

SELECT * FROM Aluno;