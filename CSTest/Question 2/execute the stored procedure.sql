-- Insert some sample trades
INSERT INTO Trade (Value, ClientSector)
VALUES
    (2000000, 'Private'),
    (400000, 'Public'),
    (500000, 'Public'),
    (3000000, 'Public');

-- Execute the categorization stored procedure
EXEC CategorizeTrades;

-- Query the categorized trades
SELECT * FROM CategorizedTrade;
