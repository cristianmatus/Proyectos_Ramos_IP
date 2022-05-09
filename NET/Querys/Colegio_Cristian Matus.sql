Create database Colegio
use Colegio


Create table Administradores
(
	id int PRIMARY KEY IDENTITY(1,1) not null,
	nombre varchar(50),
	apellido varchar(20),
	contrasena varchar(20)  
)


Create table Alumnos
(
	id int PRIMARY KEY IDENTITY(1,1) not null,
	nombre varchar(50),
	apellido varchar(20),
	edad varchar (20),
	estado varchar (50),
	situacion varchar (50)
)
