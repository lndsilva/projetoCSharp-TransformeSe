drop database dbTransforme;

create database dbTransforme;

use dbTransforme;

create table tbFuncionarios(
codFunc int not null auto_increment,
nome varchar(100),
email varchar(100),
cpf char(14) not null unique,
dataNasc date,
telCel char(10),
sexo char(1),
logradouro varchar(100),
cep char(9),
numero char(10),
complemento varchar(100),
bairro varchar(100),
cidade varchar(100),
uf char(2),
primary key(codFunc)
);

create table tbUsuarios(
codUsu int not null auto_increment,
nome varchar(30) unique,
senha varchar(12),
codFunc int not null,
primary key(codUsu),
foreign key(codFunc) references tbFuncionarios(codFunc)
);

insert into tbUsuarios(nome,senha,codFunc)values();

-- cadastrando funcionarios

-- insert into tbFuncionarios(nome,email,cpf,dataNasc,telCel,sexo,logradouro,cep,numero,complemento,bairro,cidade,uf)values();

-- busca por código

select nome from tbFuncionarios where codFunc = 1;

-- busca por nome

select nome from tbFuncionarios where nome like '%a%';

-- alterar funcionarios

-- update tbFuncionarios set nome = 'Maria da silva', email = 'maria',cpf = '1331313', dataNasc = '2025/04/10', telCel = '15241', sexo = 'F', logradouro='teste',  cep = '04750-000', numero = '10',   complemento = 'casa',    bairro = 'sp', cidade = 'sp', uf = 'sp'   where codFunc = 2;

-- excluir funcionarios

-- delete from tbFuncionarios where codFunc = codFunc;