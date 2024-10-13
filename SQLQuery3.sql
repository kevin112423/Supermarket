use Supermarket
 DROP TABLE IF EXISTS Categories;

CREATE TABLE Categories
(
    Categories_Id INT IDENTITY(1,1) PRIMARY KEY,
    Categories_Name NVARCHAR(80) NOT NULL,
    Categories_Description NVARCHAR(80) NOT NULL
);
GO

 