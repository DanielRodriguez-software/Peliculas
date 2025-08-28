CREATE DATABASE Ver

-- Tabla de Roles
 CREATE TABLE Roles (
 	Id INT PRIMARY KEY IDENTITY,
 	Nombre NVARCHAR(50) UNIQUE NOT NULL
 );
 GO

 
 
 
-- Tabla de Usuarios con relación a Roles
 CREATE TABLE Usuarios (
 	Id INT PRIMARY KEY IDENTITY,
 	Nombre NVARCHAR(100),
 	Email NVARCHAR(100) UNIQUE,
 	clave NVARCHAR(255),
 	RolId INT,
 	FOREIGN KEY (RolId) REFERENCES Roles(Id)
 );
 GO
 
 
-- Insertar roles en la tabla Roles
 INSERT INTO Roles (Nombre)
 VALUES ('Administrador'), ('Empleado');
 
select Id,Nombre from Roles;
 select * from Usuarios;





CREATE TABLE peliculas(
id INT IDENTITY(1,1) PRIMARY KEY,
nombre VARCHAR(50)NOT NULL,
director VARCHAR(50)NOT NULL,
fechaLanzamiento DATE);

INSERT INTO peliculas VALUES('Jurassic Wordl Rebirth','Gareth Edwards','2025/7/2');
INSERT INTO peliculas VALUES('Superman','James Gun','2025/7/11');
INSERT INTO peliculas VALUES('Los Cuatro Fantasticos','Matt Shakman','2025/7/24');
INSERT INTO peliculas VALUES('Jhon Wick','Chad Stahelski','2014/10/24');
INSERT INTO peliculas VALUES('El Codigo Da Vinci','Ran Howard','2006/5/19');

select *from peliculas
DROP TABLE peliculas