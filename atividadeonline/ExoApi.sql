--criação banco de dados para ativ. online 02 da UC14

create database ExoApi
GO

use ExoApi
GO

create table Projetos(
	ProjId int primary key identity,
	Titulo varchar(200) not null,
	Estado varchar(50) not null,
	DatadeInicio date not null,
	Tecnologia varchar(200) not null,
	Requisitos varchar(200) not null,
	Área varchar(100) not null
)
GO

insert into Projetos(Titulo, Estado, DatadeInicio, Tecnologia, Requisitos, Área) 
values ('Site e-commerce','Finalizado', '27/07/2021', 'HTML,CSS e JS', 'Site clean', 'Front end')
GO

insert into Projetos (Titulo, Estado, DatadeInicio, Tecnologia, Requisitos, Área) 
values ('BD financeiro','Andamento...', '10/05/2022', 'C# (C-sharp)', 'Monitoramento financeiro', 'Back end')
GO

select * from Projetos

create table Usuarios (
    UsId int primary key identity,
    Email varchar(200) not null unique,
    Senha varchar(120) not null
)
GO

insert into Usuarios (Email, Senha)
values ('frontend@email.br', '1213')
GO

insert into Usuarios (Email, Senha)
values ('backend@email.br', '1415')
GO

select * from Usuarios
