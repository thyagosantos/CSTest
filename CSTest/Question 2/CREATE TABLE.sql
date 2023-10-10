CREATE TABLE Trade (
    TradeID INT IDENTITY(1,1) PRIMARY KEY,
    Value DECIMAL(18, 2),
    ClientSector NVARCHAR(50)
);

CREATE TABLE CategorizedTrade (
    TradeID INT,
    Category NVARCHAR(50)
);