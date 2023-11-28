﻿CREATE TABLE [dbo].[customer]
(
	[userid] INT NOT NULL PRIMARY KEY,
	[nickname] VARCHAR(3)  NOT NULL UNIQUE,
	[debit] DECIMAL NOT NULL DEFAULT 0
)
