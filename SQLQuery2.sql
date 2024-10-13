

DROP TABLE IF EXISTS Product


DROP TABLE IF EXISTS Product; 

CREATE TABLE Product
(
    Product_Id INT IDENTITY(100000, 1) PRIMARY KEY,
    Product_Name NVARCHAR(50) NOT NULL,
    Product_Price DECIMAL(18, 2) NOT NULL,  -- Cambié el tipo a DECIMAL para manejar precios
    Product_Stock INT NOT NULL,              -- Cambié el tipo a INT para el stock
    Product_Categoria NVARCHAR(50) NOT NULL
);

GO

-- Agregar algunas inserciones de ejemplo
INSERT INTO Product (Product_Name, Product_Price, Product_Stock, Product_Categoria) 
VALUES ('Product A', 10.99, 100, 'Category 1');

INSERT INTO Product (Product_Name, Product_Price, Product_Stock, Product_Categoria) 
VALUES ('Product B', 15.50, 50, 'Category 2');