create database Policia;

Use Policia;

create table Persona(
id_persona int identity(1,1) not null primary key,
nombre varchar (50),
apellido varchar (50),
direccion varchar (50)
);

create table Policia(
id_policia int identity(1,1) not null primary key,
nombre varchar(50),
apellido varchar(50),
ONI varchar(50)
);

create table Vehiculo(
id_vehiculo int identity(1,1) not null primary key,
id_persona int not null,
placa varchar(15),
modelo varchar(30)
);

create table Multa(
id_multa int identity(1,1) not null primary key,
id_vehiculo int not null,
id_policia int not null,
fecha datetime
);

Alter table Vehiculo add Foreign key (id_persona) references Persona(id_persona);
Go
Alter table Multa add Foreign key (id_vehiculo) references Vehiculo(id_vehiculo);
Go
Alter table Multa add Foreign key (id_policia) references Policia(id_policia);
Go


