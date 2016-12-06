USE [dmab0913_4]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 02-12-2014 19:32:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Customer](
	[FName] [varchar](30) NOT NULL,
	[LName] [varchar](30) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[PostalCode] [int] NOT NULL,
	[PhoneNo] [varchar](12) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[CustomerNo] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


