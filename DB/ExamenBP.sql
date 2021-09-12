
CREATE DATABASE TestBP
GO
USE TestBP

CREATE TABLE [Lista] (
[listaId] int NOT NULL IDENTITY(1,1),
[fechaCreacion] datetime default GETDATE(),
[fechaUpdate] datetime NULL,
[descripcion] varchar(255) NULL,
PRIMARY KEY ([listaId]) 
)
GO
CREATE TABLE [Producto] (
[productoId] int NOT NULL IDENTITY(1,1),
[nombre] varchar(255) NULL,
[descripcion] varchar(255) NULL,
[valor] numeric(16,4) NOT NULL,
PRIMARY KEY ([productoId]) 
)
GO
CREATE TABLE [detLista] (
[detListaId] int NOT NULL IDENTITY(1,1),
[listaId] int NULL,
[productoId] int NULL,
[valorUnitario] numeric(16,4) NULL,
[cantidad] numeric(5) NULL,
[subTotal] numeric(16,4) NULL,
PRIMARY KEY ([detListaId]) 
)
GO

ALTER TABLE [detLista] ADD CONSTRAINT [FK_detLista_Lista] FOREIGN KEY ([listaId]) REFERENCES [Lista] ([listaId])
GO
ALTER TABLE [detLista] ADD CONSTRAINT [FK_detLista_producto] FOREIGN KEY ([productoId]) REFERENCES [Producto] ([productoId])
GO

CREATE PROCEDURE updateList @descripcion nvarchar(250), @listaId int
AS
UPDATE Lista SET descripcion = @descripcion,fechaUpdate = GETDATE() WHERE listaId = @listaId
GO

CREATE PROCEDURE insertList @descripcion nvarchar(250)
AS
INSERT INTO Lista (descripcion,fechaUpdate) VALUES (@descripcion,GETDATE())
GO

CREATE PROCEDURE insertDetLista @listaId int,@productoId int,
@valorUnitario numeric(16,4),@cantidad int,@subTotal numeric(16,4)
AS
INSERT INTO detLista (listaId,productoId,valorUnitario,cantidad,subTotal) 
VALUES (@listaId,@productoId,@valorUnitario,@cantidad,@subTotal);
GO

CREATE PROCEDURE updateDetLista @detListaId int,
@valorUnitario numeric(16,4),@cantidad int,@subTotal numeric(16,4)
AS
UPDATE detLista SET valorUnitario = @valorUnitario, cantidad = @cantidad,
subTotal = @subTotal WHERE detListaId = @detListaId;
GO

CREATE PROCEDURE deleteDetLista @detListaId int
AS
DELETE FROM detLista WHERE detListaId = @detListaId;
GO

Insert into Producto (nombre,descripcion,valor)
Values 
('Arroz','Alimento',1.50),('Frijoles','Alimento',2.50),('Azucar','Alimento',3.50),
('Huevos','Alimento',4.50),('Pollo','Alimento',5.50);
GO
EXEC insertList @descripcion = "Lista Uno";
GO
EXEC insertList @descripcion = "Lista Dos";
GO
EXEC insertList @descripcion = "Lista Tres";
GO
EXEC insertList @descripcion = "Lista Cuatro";
GO

INSERT INTO detLista (listaId,productoId,valorUnitario,cantidad,subTotal)
Values
(1,1,1.50,2,3),(2,1,1.50,2,3),(3,1,1.50,2,3),(4,1,1.50,2,3),
(1,2,2.50,2,5),(2,2,2.50,2,5),(3,2,2.50,2,5),(4,2,2.50,2,5),
(1,3,3.50,2,7),(2,3,3.50,2,7),(3,3,3.50,2,7),(4,3,3.50,2,7),
(1,4,4.50,2,9),(2,4,4.50,2,9),(3,4,4.50,2,9),(4,4,4.50,2,9),
(1,5,5.50,2,11),(2,5,5.50,2,11),(3,5,5.50,2,11),(4,5,5.50,2,11);
GO
