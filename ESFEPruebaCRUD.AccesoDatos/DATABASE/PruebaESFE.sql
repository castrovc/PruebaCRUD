CREATE DATABASE PruebaTecnica2023CRUD;
GO

USE PruebaTecnica2023CRUD;
GO

CREATE TABLE Roles(
Id INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Descripcion VARCHAR (50),
)

CREATE TABLE Usuarios(
Id INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
CorreoElectronico VARCHAR (50) NOT  NULL,
Contraseņa VARCHAR (50) NOT NULL,
RolId INT NOT NULL,
FOREIGN KEY (RolId) REFERENCES Roles(Id),
)

