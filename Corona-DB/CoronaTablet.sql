
CREATE TABLE [dbo].[Members]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [FirstName] NVARCHAR(20) NOT NULL, 
    [LastName] NVARCHAR(20) NOT NULL, 
    [Tz] NCHAR(10) NOT NULL, 
    [City] NVARCHAR(20) NOT NULL, 
    [Street] NVARCHAR(20) NOT NULL, 
    [Number] INT NOT NULL, 
    [BirthDate] DATE NOT NULL, 
    [Phone] NCHAR(10) NULL, 
    [MobilePhone] NCHAR(10) NULL, 
    [Picture] TEXT NULL, 
    [PositiveAnswerDate] DATE NULL, 
    [RecoveryDate] DATE NULL
)
CREATE TABLE [dbo].[Manufacturers]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [ManufacturerName] NVARCHAR(30) NOT NULL
)
CREATE TABLE [dbo].[Vaccinations]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [MemberId] INT NOT NULL, 
    [ReceivedDate] DATE NOT NULL, 
    [ManufacturerId] INT NOT NULL,
    foreign key ([memberId]) references Members([Id]), 
	foreign key ([manufacturerId]) references Manufacturers([Id])
)