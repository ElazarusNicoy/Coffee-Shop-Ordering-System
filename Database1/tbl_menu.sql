CREATE TABLE [dbo].[tbl_menu]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Pcode] VARCHAR(50) NULL, 
    [Pdesc] VARCHAR(MAX) NULL, 
    [CategoryID] INT NULL, 
    [Qty] INT NULL DEFAULT 0, 
    [Price] DECIMAL(18, 2) NULL
)
