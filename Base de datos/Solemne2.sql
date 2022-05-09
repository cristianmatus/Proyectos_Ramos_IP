/*CREATE TABLE PERSONA(
ID_PERSONA INT PRIMARY KEY AUTO_INCREMENT,
NOMBRE VARCHAR (20) NOT NULL,
APELLIDO_PA VARCHAR (20) NOT NULL,
APELLIDO_MA VARCHAR (20) NOT NULL,
EDAD INT NOT NULL,
HOBBY VARCHAR (50) 
);*/

/*CREATE TABLE TIPO_DIRECCION(
ID_TIPO_DIRECCION INT PRIMARY KEY AUTO_INCREMENT,
TIPO_DIRECCION VARCHAR (10) NOT NULL 
);*/

/*CREATE TABLE DIRECCION(
ID_DIRECCION INT PRIMARY KEY AUTO_INCREMENT,
DIRECCION VARCHAR (10) NOT NULL,
TIPO_DIRECCION_FK INT NOT NULL,
ID_PERSONA_FK INT NOT NULL,
FOREIGN KEY (ID_PERSONA_FK) REFERENCES PERSONA(ID_PERSONA),
FOREIGN KEY (TIPO_DIRECCION_FK) REFERENCES TIPO_DIRECCION(ID_TIPO_DIRECCION)
);*/

/*TRANSACCIONES DE MANIPULACION DE DATOS - OML*/

/*INSERCION DE DATOS - ACTUALIZACION DATOS - ELIMINACION - EXTRACCION*/
/*
INSERT  INSERTAR DATOS
UPDATE  ACTUALIZAR DATOS  
DELETE  ELIMINAR DATOS
SELECT  EXTRAER DATOS
*/

/*AGREGAR REGISTROS A UNA TABLA - INSERT*/

/*INSERT INTO PERSONA (NOMBRE,APELLIDO_PA,APELLIDO_MA,EDAD,HOBBY)
VALUES ('CRISTIAN','MATUS','MALLORGA',29,'FUTBOL');

INSERT INTO PERSONA (NOMBRE,APELLIDO_PA,APELLIDO_MA,EDAD,HOBBY)
VALUES ('ALEX','MA','MALL',33,'MUSICA');*/

/*SELECT * FROM PERSONA;*/

/*
INSERT INTO TIPO_DIRECCION (TIPO_DIRECCION) VALUES ('COMERCIAL');
INSERT INTO TIPO_DIRECCION (TIPO_DIRECCION) VALUES ('LABORAL');
INSERT INTO TIPO_DIRECCION (TIPO_DIRECCION) VALUES ('DEPORTE');
*/

/*SELECT * FROM TIPO_DIRECCION;*/

/*INSERT INTO DIRECCION (DIRECCION,TIPO_DIRECCION_FK,ID_PERSONA_FK) 
VALUES ('COMERCIAL',1,1);

INSERT INTO DIRECCION (DIRECCION,TIPO_DIRECCION_FK,ID_PERSONA_FK) 
VALUES ('LABORAL',2,2);*/

/*SELECT * FROM DIRECCION;*/

/*UPDATE PERSONA SET HOBBY = 'BAILAR'; Actualizas toda la columna hobby con bailar*/

/*SELECT * FROM PERSONA;*/

/*UPDATE PERSONA SET HOBBY = 'FUTBOL' WHERE ID_PERSONA = 2; el WHERE te permite ingresar una condicion*/

/*SELECT * FROM PERSONA;*/

/*ALTER TABLE TIPO_DIRECCION MODIFY TIPO_DIRECCION VARCHAR(15); Con esto se modifica el rango del dato*/

/*UPDATE PERSONA SET HOBBY = 'DORMIR' WHERE ID_PERSONA = 1 AND ID_PERSONA = 2;* Para modificar dos filas/

/*DELETE FROM PERSONA; asi borraras todos los registros de la tabla persona

DELETE FROM PERSONA WHERE ID_PERSONA = 2; solo borraras el dato de la persona con ese ID

/*SELECT * FROM PERSONA; trae todos los campos de la tabla PERSONA*/

/*SELECT NOMBRE, APELLIDO_PA FROM PERSONA; trae solo esos campos de la tabla PERSONA*/

/*SELECT NOMBRE AS NOMBRE_PERSONA, APELLIDO_PA AS APELLIDO FROM PERSONA; modifica los nombres de la tabla PERSONA*/

/*SELECT COUNT(*) FROM PERSONA; ver cuantos registros tiene, en este caso 2*/






/*CREATE TABLE CATEGORIA(
ID_CATEGORIA INT PRIMARY KEY AUTO_INCREMENT,
NOMBRE_CATEGORIA VARCHAR (20) NOT NULL,
DESCRIPCION VARCHAR (50)
);*/

/*CREATE TABLE PRODUCTO(
ID_PRODUCTO INT PRIMARY KEY AUTO_INCREMENT,
NOMBRE_PRODUCTO VARCHAR (20) NOT NULL,
PRECIO INT NOT NULL,
STOCK_PRODUCTO INT NOT NULL
);*/

/*CREATE TABLE VENTA(
ID_VENTA INT PRIMARY KEY AUTO_INCREMENT,
FECHA VARCHAR (20) NOT NULL,
MONTO INT NOT NULL,
DESCUENTO INT NOT NULL
);*/

/*CREATE TABLE CLIENTE(
RUT_CLIENTE INT PRIMARY KEY AUTO_INCREMENT,
DIRECCION_CLIENTE VARCHAR (20),
NOMBRE_CLIEN VARCHAR (20) NOT NULL,
APELLIDO_P VARCHAR (20) NOT NULL,
APELLIDO_M VARCHAR (20) NOT NULL,
TELEFONO VARCHAR (10) NOT NULL
);*/

/*CREATE TABLE DIRECCON_CLIENTE(
RUT_CLIENTE INT PRIMARY KEY AUTO_INCREMENT,
CIUDAD VARCHAR (20) NOT NULL,
COMUNA VARCHAR (20) NOT NULL,
CALLE VARCHAR (20) NOT NULL,
NUMERO INT NOT NULL
);*/

/*CREATE TABLE PROVEEDOR(
RUT_PROVEEDOR INT PRIMARY KEY AUTO_INCREMENT,
DIRECCION_PROVEEDOR VARCHAR (20) NOT NULL,
NOMBRE VARCHAR (20) NOT NULL,
WEB VARCHAR (20) NOT NULL,
TELEFONO VARCHAR (20) NOT NULL
);*/

/*CREATE TABLE DIRECCON_PROVEEDOR(
RUT_PROVEEDOR INT PRIMARY KEY AUTO_INCREMENT,
CIUDAD VARCHAR (20) NOT NULL,
COMUNA VARCHAR (20) NOT NULL,
CALLE VARCHAR (20) NOT NULL,
NUMERO INT NOT NULL
);*/



/*INSERT INTO CATEGORIA(NOMBRE_CATEGORIA,DESCRIPCION)
VALUES ('ZAPATOS','Zapatos de cuero');*/

/*INSERT INTO CATEGORIA(NOMBRE_CATEGORIA,DESCRIPCION)
VALUES ('DEPORTES','Ropa deportiva');

INSERT INTO CATEGORIA(NOMBRE_CATEGORIA,DESCRIPCION)
VALUES ('MUEBLES','Muebles de todo tipo');*/

/*INSERT INTO PRODUCTO(NOMBRE_PRODUCTO,PRECIO,STOCK_PRODUCTO)
VALUES ('ZAPATOS DE FUTBOL',20000,10);*/

/*INSERT INTO PRODUCTO(NOMBRE_PRODUCTO,PRECIO,STOCK_PRODUCTO)
VALUES ('ZAPATOS DE FUTBOL',20000,10);*/

/*INSERT INTO VENTA(FECHA,MONTO,DESCUENTO)
VALUES ('10-11-2020',50000,10000);*/

/*INSERT INTO CLIENTE(DIRECCION_CLIENTE,NOMBRE_CLIEN,APELLIDO_P,APELLIDO_M,TELEFONO)
VALUES ('RODRIGO DE ARAYA','CRISTIAN','MATUS','MALLORGA','996501277');*/

/*INSERT INTO PROVEEDOR(DIRECCION_PROVEEDOR,NOMBRE,WEB,TELEFONO)
VALUES ('SANTA JULIA 3729','SOCCER','WWW.SOCCER.CL','22222322');*/

/*SELECT * FROM CATEGORIA;*/

/*SELECT * FROM PRODUCTO;*/

/*SELECT * FROM VENTA;*/

/*SELECT * FROM CLIENTE;*/

/*SELECT * FROM PROVEEDOR;*/

