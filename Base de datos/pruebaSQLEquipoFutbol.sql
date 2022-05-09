/*SHOW DATABASES es para mostrar todas las bases de datos*/
/*USE + nombre de base de datos, es para usar la base de datos o seleccionarla*/
/*DROP DATABASE + nombre de base de datos permite elimar esquemas o base de datos*/
/*CREATE TABLE crear tablas*/
/*PRIMARY KEY es la llave y AUTO_INCREMENTABLE es patra ir incrementando a medida de que agregas datos*/
/*NOT NULL no puede venir sin valor*/

/*USE STGO_RC_CMATUS;*/

CREATE TABLE EQUIPOFUTBOL (
ID_JUGADOR INT PRIMARY KEY AUTO_INCREMENT,
RUT VARCHAR(10) NOT NULL,
NOMBRE VARCHAR(50) NOT NULL,
EDAD INT NOT NULL,
CAMISETA INT NOT NULL
);

hibernatehibernateCATEGORIA