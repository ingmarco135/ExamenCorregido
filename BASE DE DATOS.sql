CREATE DATABASE BD_EMPLEADOS_GMDRA
USE BD_EMPLEADOS_GMDRA

CREATE TABLE Trabajadores (
    ID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Apellidos NVARCHAR(100),
    SueldoBruto DECIMAL(10, 2),
    Categoria CHAR(1)
);