CREATE DATABASE RegistroVehiculosAPI;
GO

USE RegistroVehiculosAPI;
GO

CREATE TABLE Vehiculos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Placa NVARCHAR(10) NOT NULL UNIQUE,
    Marca NVARCHAR(50) NOT NULL,
    Modelo INT NOT NULL CHECK (Modelo BETWEEN 1900 AND 2025),
    Activo BIT NOT NULL DEFAULT 1
);
GO

-- Insertar datos de prueba
INSERT INTO Vehiculos (Placa, Marca, Modelo, Activo) VALUES
('MNO345', 'Ford', 2022, 1),
('PQR678', 'Mazda', 2020, 1),
('STU901', 'Hyundai', 2019, 0);
GO
