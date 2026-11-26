IF DB_ID('MyBigasanDB') IS NULL
    CREATE DATABASE MyBigasanDB;
GO
USE MyBigasanDB;
GO

IF OBJECT_ID('dbo.SaleItems') IS NOT NULL DROP TABLE dbo.SaleItems;
IF OBJECT_ID('dbo.Sales')     IS NOT NULL DROP TABLE dbo.Sales;
IF OBJECT_ID('dbo.Products')  IS NOT NULL DROP TABLE dbo.Products;
GO

CREATE TABLE dbo.Products (
    ProductID   INT IDENTITY(1,1) PRIMARY KEY,
    RiceName    NVARCHAR(100) NOT NULL,
    Category    NVARCHAR(50)  NOT NULL,
    SellingUnit NVARCHAR(20)  NOT NULL,
    Price       DECIMAL(10,2) NOT NULL,
    Stock       INT           NOT NULL,
    CONSTRAINT CK_Products_Name  CHECK (LEN(LTRIM(RTRIM(RiceName))) > 0),
    CONSTRAINT CK_Products_Cat   CHECK (LEN(LTRIM(RTRIM(Category))) > 0),
    CONSTRAINT CK_Products_Unit  CHECK (SellingUnit IN ('per kg','5 kg sack','10 kg sack','25 kg sack','50 kg sack')),
    CONSTRAINT CK_Products_Price CHECK (Price > 0),
    CONSTRAINT CK_Products_Stock CHECK (Stock >= 0),
    CONSTRAINT UQ_Products_NameUnit UNIQUE (RiceName, SellingUnit)
);

CREATE TABLE dbo.Sales (
    SaleID          INT IDENTITY(1,1) PRIMARY KEY,
    SaleDate        DATETIME      NOT NULL DEFAULT GETDATE(),
    CustomerName    NVARCHAR(100) NOT NULL,
    CustomerAddress NVARCHAR(200) NOT NULL,
    Subtotal        DECIMAL(10,2) NOT NULL,
    Discount        DECIMAL(10,2) NOT NULL DEFAULT 0,
    TotalAmount     DECIMAL(10,2) NOT NULL,
    CashReceived    DECIMAL(10,2) NOT NULL,
    ChangeAmount    DECIMAL(10,2) NOT NULL,
    CONSTRAINT CK_Sales_Cust  CHECK (LEN(LTRIM(RTRIM(CustomerName))) > 0 AND LEN(LTRIM(RTRIM(CustomerAddress))) > 0),
    CONSTRAINT CK_Sales_Money CHECK (Subtotal >= 0 AND Discount >= 0 AND TotalAmount >= 0 AND ChangeAmount >= 0),
    CONSTRAINT CK_Sales_Cash  CHECK (CashReceived >= TotalAmount)
);

CREATE TABLE dbo.SaleItems (
    SaleItemID  INT IDENTITY(1,1) PRIMARY KEY,
    SaleID      INT           NOT NULL,
    ProductID   INT           NOT NULL,
    ProductName NVARCHAR(100) NOT NULL,
    Quantity    INT           NOT NULL,
    UnitPrice   DECIMAL(10,2) NOT NULL,
    LineTotal   DECIMAL(10,2) NOT NULL,
    SellingUnit NVARCHAR(20)  NOT NULL,
    CONSTRAINT CK_SaleItems_Qty   CHECK (Quantity > 0),
    CONSTRAINT CK_SaleItems_Money CHECK (UnitPrice >= 0 AND LineTotal >= 0),
    CONSTRAINT FK_SaleItems_Sales    FOREIGN KEY (SaleID)    REFERENCES dbo.Sales(SaleID) ON DELETE CASCADE,
    CONSTRAINT FK_SaleItems_Products FOREIGN KEY (ProductID) REFERENCES dbo.Products(ProductID)
);

CREATE INDEX IX_SaleItems_SaleID    ON dbo.SaleItems(SaleID);
CREATE INDEX IX_SaleItems_ProductID ON dbo.SaleItems(ProductID);
CREATE INDEX IX_Sales_SaleDate      ON dbo.Sales(SaleDate);
GO

INSERT INTO dbo.Products (RiceName, Category, SellingUnit, Price, Stock) VALUES
('Sinandomeng','Premium','per kg',55.00,100),
('Sinandomeng','Premium','25 kg sack',1375.00,10),
('Dinorado','Premium','per kg',60.00,80),
('Dinorado','Premium','25 kg sack',1500.00,8),
('Jasmine','Special Rice','per kg',65.00,70),
('Jasmine','Special Rice','5 kg sack',325.00,20),
('Brown Rice','Special Rice','per kg',70.00,40),
('Well-Milled Rice','Well-Milled','per kg',48.00,120),
('Regular-Milled Rice','Regular-Milled','per kg',42.00,150),
('Japonica','Special Rice','10 kg sack',780.00,12);
GO

SELECT * FROM dbo.Products;