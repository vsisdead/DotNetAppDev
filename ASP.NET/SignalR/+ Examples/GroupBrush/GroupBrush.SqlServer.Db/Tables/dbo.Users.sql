﻿CREATE TABLE [dbo].[Users]
(
	[UserId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] [NVARCHAR](100) NOT NULL,
	[Password] [NVARCHAR](255) NOT NULL
);
