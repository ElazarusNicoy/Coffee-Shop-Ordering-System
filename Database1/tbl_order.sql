CREATE TABLE [dbo].[tbl_order]
(
	[TransactionNo] VARCHAR(50) NOT NULL PRIMARY KEY IDENTITY, 
    [Pcode] VARCHAR(50) NULL, 
    [Request] VARCHAR(MAX) NULL, 
    [MenuID] INT NULL, 
    [Total] DECIMAL(18, 2) NULL, 
    [SDate] DATE NULL, 
    [Status] VARCHAR(50) NULL DEFAULT 'Pending'
)
