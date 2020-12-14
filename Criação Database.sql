create database if not exists faculdade;
use faculdade;

create table if not exists instituicao (
id numeric primary key not null,
nome varchar(200) not null,
endereco varchar(200) not null,
cidade varchar(100) not null,
uf varchar(2) not null,
credenciamento_mec varchar(50) not null,
mantenedora varchar(100) not null,
principal bool not null,
acesso_liberado bool not null
);

create table if not exists usuario (
id numeric primary key not null,
login varchar(50) not null,
nome varchar(50)  not null,
sobrenome varchar(200) not null,
cpf varchar(11) not null, 
telefone varchar(11) not null, 
email varchar(150) not null,
senha varchar(30) not null,
funcao char not null,
ativo bool not null,
id_instituicao numeric not null,
codigo_recupera_senha int null,
foreign key (id_instituicao) references instituicao (id)
);

create table if not exists curso (
id numeric primary key not null,
nome varchar(200) not null,
grau varchar(50) not null,
codigo_MEC varchar(30) not null,
autorização_DOU varchar(30) not null,
data_autorizacao_DOU date not null,
reconhecimento_DOU varchar(30) not null,
data_reconhecimento_DOU date not null, 
renovacao_DOU varchar(30) not null,
data_renovacao_DOU date not null, 
observação varchar(300) null
);

create table if not exists auditoria_operacao (
id numeric primary key not null,
login_usuario varchar(50) not null,
operacao char not null,
data_operacao date not null,
valor_antigo varchar(300) null,
valor_novo varchar(300) null,
id_registro_alterado numeric null,
nome_registro_alterado varchar(200),
coluna_alterada varchar(50)
);

create table if not exists diploma (
id numeric primary key not null,
nome_aluno varchar(250) not null,
cpf_aluno varchar(11) not null,
data_emissao date not null,
validado bool not null,
id_usuario_validacao numeric null,
id_instituicao numeric not null,
foreign key (id_usuario_validacao) references usuario (id),
foreign key (id_instituicao) references instituicao (id)
);

ALTER TABLE instituicao
ALTER acesso_liberado SET DEFAULT false; 

ALTER TABLE usuario
ALTER ativo SET DEFAULT false; 

use faculdade;
INSERT IGNORE INTO instituicao
VALUES('1','instituicao','instituicao','endereco','uf','2021', 'instituicao', '1', '1');
INSERT IGNORE INTO usuario 
VALUES('1','admin','admin','admin','00000000000','99999999999','admin@admin.com.br','admin','S','1','1',null);