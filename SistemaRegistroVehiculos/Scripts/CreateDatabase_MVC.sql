CREATE DATABASE RegistroVehiculosMVC;
GO

USE RegistroVehiculosMVC;
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
('ABC123', 'Toyota', 2020, 1),
('DEF456', 'Honda', 2019, 1),
('GHI789', 'Nissan', 2021, 0),
('JKL012', 'Chevrolet', 2018, 1);
GO
