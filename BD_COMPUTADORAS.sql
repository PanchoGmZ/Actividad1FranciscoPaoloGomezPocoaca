CREATE DATABASE COMPUTADORABD
CREATE TABLE COMPUTADORA (
IDPC INT IDENTITY (1,1) NOT NULL,
NOMBRE NVARCHAR (50) NOT NULL,
DESCRIPCION NVARCHAR (50) NOT NULL,
PRECIO MONEY NOT NULL,
FECHAFAB DATETIME NOT NULL,
PRIMARY KEY (IDPC),
);

insert into COMPUTADORA values ('Asus Rog','Nueva, teclado ingles','799','2022-06-08');
INSERT INTO COMPUTADORA
VALUES ('Gamer PC', 'Tarjeta gr�fica NVIDIA RTX 3080', '1999.99', '2024-03-04');
INSERT INTO COMPUTADORA
VALUES ('MacBook Air', 'Laptop ultraligera pantalla Retina', '1299.99', '2024-09-10 ');
select * from COMPUTADORA