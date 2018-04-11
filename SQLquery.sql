CREATE TABLE [dbo].[Customers]
(
	[CustomerId] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [CustomerName] VARCHAR(50) NULL, 
    [CustomerAddress] VARCHAR(50) NULL, 
    [CustomerEMail] VARCHAR(50) NULL, 
    [CustomerPassword] VARCHAR(50) NULL
)
