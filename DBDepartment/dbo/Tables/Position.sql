CREATE TABLE [dbo].[Positions]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PositionName] NCHAR(50) NOT NULL, 
    [PositionSalary] MONEY NOT NULL
)
