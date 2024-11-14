CREATE TABLE [dbo].[tbl_product]
(
	[Pcode] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Barcode] VARCHAR(50) NULL, 
    [Pdesc] VARCHAR(MAX) NULL, 
    [BrandID] INT NULL, 
    [CategoryID] INT NULL, 
    [Price] DECIMAL(18, 2) NULL, 
    [Qty] INT NULL DEFAULT 0
)
