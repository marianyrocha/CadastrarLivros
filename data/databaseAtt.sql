CREATE DATABASE Biblioteca;
USE Biblioteca;

CREATE TABLE IF NOT EXISTS Categorias(
	IdCategoria INT PRIMARY KEY AUTO_INCREMENT,
    NomeCategoria VARCHAR(150) NOT NULL UNIQUE
);

CREATE TABLE IF NOT EXISTS Editoras(
	IdEditora INT PRIMARY KEY AUTO_INCREMENT,
    NomeEditora VARCHAR(150) NOT NULL,
    CnpjEditora VARCHAR(20) NOT NULL UNIQUE
);

CREATE TABLE IF NOT EXISTS Autores(
	IdAutor INT PRIMARY KEY AUTO_INCREMENT,
    NomeAutor VARCHAR(150) NOT NULL,
    GeneroLiterario VARCHAR(100),
    Nacionalidade VARCHAR(100)
);

CREATE TABLE IF NOT EXISTS Livros(
	IdLivro INT PRIMARY KEY AUTO_INCREMENT, 
    Titulo VARCHAR(150) NOT NULL, 
    Autor VARCHAR(100) NOT NULL,
    Categoria VARCHAR(50) NOT NULL,
    Ano INT,
    Quantidade INT 
);

CREATE TABLE IF NOT EXISTS Leitores(
	IdLeitor INT PRIMARY KEY AUTO_INCREMENT,
    NomeLeitor VARCHAR(150) NOT NULL,
    EmailLeitor VARCHAR(100) NOT NULL UNIQUE,
    CpfLeitor VARCHAR(15) NOT NULL UNIQUE,
    TelefoneLeitor VARCHAR(20),
    Endereco TEXT,
    DataNascimento DATE
);

CREATE TABLE IF NOT EXISTS Emprestimos(
	IdEmprestimo INT PRIMARY KEY AUTO_INCREMENT,
    DataEmprestimo DATE NOT NULL,
    DataDevolucao DATE,
    Situacao TEXT,
    Fk_IdLeitor INT NOT NULL, 
	Fk_IdLivro INT NOT NULL, 
    FOREIGN KEY (Fk_IdLeitor) REFERENCES Leitores(IdLeitor),
    FOREIGN KEY (Fk_IdLivro) REFERENCES Livros(IdLivro)
);

CREATE TABLE IF NOT EXISTS Reservas(
	IdReserva INT PRIMARY KEY AUTO_INCREMENT,
    DataReserva DATE NOT NULL,
    Situacao TEXT, 
	Fk_IdLeitor INT NOT NULL, 
	Fk_IdLivro INT NOT NULL, 
    FOREIGN KEY (Fk_IdLeitor) REFERENCES Leitores(IdLeitor),
    FOREIGN KEY (Fk_IdLivro) REFERENCES Livros(IdLivro)
);

CREATE TABLE IF NOT EXISTS Multas(
	IdMulta INT PRIMARY KEY AUTO_INCREMENT,
    ValorMulta DOUBLE NOT NULL,
	Situacao TEXT,
    Fk_IdEmprestimo INT NOT NULL,
    FOREIGN KEY (Fk_IdEmprestimo) REFERENCES Emprestimos(IdEmprestimo)
);

CREATE TABLE IF NOT EXISTS Funcionarios(
	IdFuncionario INT PRIMARY KEY AUTO_INCREMENT,
    NomeFuncionario VARCHAR(150) NOT NULL,
    CpfFuncionario VARCHAR(15) NOT NULL UNIQUE,
    Email VARCHAR(150) NOT NULL UNIQUE,
    Cargo VARCHAR(100)
);

CREATE TABLE IF NOT EXISTS Devolucoes(
	IdDevolucao INT PRIMARY KEY AUTO_INCREMENT,
    DataDevolucao DATE NOT NULL,
    Fk_IdEmprestimo INT NOT NULL,
    FOREIGN KEY (Fk_IdEmprestimo) REFERENCES Emprestimos(IdEmprestimo)
);


