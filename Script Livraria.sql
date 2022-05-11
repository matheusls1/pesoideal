create database BancoDeDadosTI13N;
use BancoDeDadosTI13N;
create table Livros(			
codigo int not null primary key auto_increment,
titulo varchar(100) not null,	
ano varchar (4) not null,
editora varchar(120) not null,
quantidade int  not null
)Engine = InnoDB; 

create table Cliente(
cpf bigint (11) not null primary key,
nome varchar(100) not null,
endereco varchar (150) not null,
telefone varchar (15) not null,
dataDeNascimento varchar (15)  not null,
login varchar (150) not null,
senha varchar (20) not null 
)Engine = InnoDB; 



create table FormaDePagamento(
codigo int not null primary key auto_increment,
valorTotal decimal (10,2) not null
)Engine = InnoDB; 

drop table Livros;

describe livros;

select * from cliente;
insert into Livros (codigo, titulo, ano, editora, quantidade) values ('10', 'Tulipa Negra', '2005', 'kid benga', '23')


