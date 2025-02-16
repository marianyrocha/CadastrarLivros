CREATE DATABASE CadastrarLivros;
USE CadastrarLivros;

CREATE TABLE IF NOT EXISTS Livros(
	Id INT AUTO_INCREMENT PRIMARY KEY, 
    Titulo VARCHAR(150) NOT NULL, 
    Autor VARCHAR(100),
    Categoria VARCHAR(50),
    Ano INT,
    Quantidade INT
);

Select * from Livros;