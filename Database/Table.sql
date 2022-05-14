USE [ajax]
GO

CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[StudentName] [varchar](20) NOT NULL,
	[StudentAddress] [varchar](20) NOT NULL,
) 

GO


