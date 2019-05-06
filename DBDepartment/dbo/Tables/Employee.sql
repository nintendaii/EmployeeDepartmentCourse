CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NCHAR(50) NOT NULL, 
    [LastName] NCHAR(50) NOT NULL, 
    [Age] INT NULL, 
    [Email] NCHAR(50) NULL, 
    [SpecialityId] INT NOT NULL, 
    [PositionId] INT NOT NULL
)
