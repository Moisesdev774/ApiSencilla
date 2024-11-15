CREATE TABLE [dbo].[Book]
(

	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(200) NOT NULL, 
    [Author] NVARCHAR(100) NOT NULL, 
    [Pages] INT NULL
)
