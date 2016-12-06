USE [dmab0913_4]
GO

/****** Object:  Table [dbo].[Airport]    Script Date: 02-12-2014 19:32:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Airport](
	[AirportCode] [varchar](10) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Country] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Airport] PRIMARY KEY CLUSTERED 
(
	[AirportCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

