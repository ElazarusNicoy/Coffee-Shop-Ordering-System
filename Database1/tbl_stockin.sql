CREATE TABLE [dbo].[tbl_stockin]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ReferenceNo] VARCHAR(50) NULL, 
    [Pcode] VARCHAR(50) NULL, 
    [Qty] INT NULL DEFAULT 0, 
    [StockDate] DATETIME NULL, 
    [StockInBy] VARCHAR(50) NULL, 
    [Status] VARCHAR(50) NULL DEFAULT 'Pending'
)
