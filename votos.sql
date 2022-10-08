create database urna_eletronica;

use urna_eletronica;

create table voto(
cod int auto_increment not null primary key,
nome_candidato varchar(80) not null,
partido varchar(80) not null,
numero int not null
)engine=INNODB;

