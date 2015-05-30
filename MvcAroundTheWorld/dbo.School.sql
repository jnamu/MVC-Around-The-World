CREATE TABLE [dbo].[School] (
    [SchoolID]  INT            IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (50)  NOT NULL,
    [Address]   NVARCHAR (100) NULL,
    [Telephone] NVARCHAR (15)  NULL,
    PRIMARY KEY CLUSTERED ([SchoolID] ASC)
);

