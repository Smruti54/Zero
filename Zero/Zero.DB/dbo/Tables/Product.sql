CREATE TABLE [dbo].[Product] (
    [ProductId]     INT           IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50) NULL,
    [ProductTypeId] INT           NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([ProductId] ASC)
);

