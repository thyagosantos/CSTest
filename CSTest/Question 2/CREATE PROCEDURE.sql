CREATE PROCEDURE CategorizeTrades
AS
BEGIN
    -- Insert categorized trades into the CategorizedTrade table
    INSERT INTO CategorizedTrade (TradeID, Category)
    SELECT
        t.TradeID,
        CASE
            WHEN t.Value < 1000000 AND t.ClientSector = 'Public' THEN 'LOWRISK'
            WHEN t.Value >= 1000000 AND t.ClientSector = 'Public' THEN 'MEDIUMRISK'
            WHEN t.Value >= 1000000 AND t.ClientSector = 'Private' THEN 'HIGHRISK'
            ELSE 'UNKNOWN' -- You can define a default category if needed
        END AS Category
    FROM Trade AS t;
END;