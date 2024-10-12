use Supermarket
DROP TABLE IF EXISTS PayMode;
create table PayMode
(
Pay_Mode_Id int identity (100000,1) primary key,
Pay_Mode_Name nvarchar (40) not null,
Pay_Mode_Observation nvarchar (40) not null,
)
go
insert into PayMode values('Cash', 'Cash mode')
insert into PayMode values('Credit card', 'Credit card
mode')



DROP TABLE IF EXISTS Product; 

CREATE TABLE Product
(
    Product_Id INT IDENTITY(100000, 1) PRIMARY KEY,
    Product_Name NVARCHAR(50) NOT NULL,
    Product_FirstName NVARCHAR(50) NOT NULL,
    Product_LastName NVARCHAR(50) NOT NULL,
    Product_Address NVARCHAR(50) NOT NULL,
    Product_Phone NVARCHAR(15) NOT NULL,  
    Product_Email NVARCHAR(100) NOT NULL
);

GO


INSERT INTO Product (Product_Name, Product_FirstName, Product_LastName, Product_Address, Product_Phone, Product_Email) 
VALUES ('Cash', 'John', 'Doe', '123 Main St', '1234567890', 'john.doe@example.com');

INSERT INTO Product (Product_Name, Product_FirstName, Product_LastName, Product_Address, Product_Phone, Product_Email) 
VALUES ('Credit card', 'Jane', 'Smith', '456 Elm St', '0987654321', 'jane.smith@example.com');