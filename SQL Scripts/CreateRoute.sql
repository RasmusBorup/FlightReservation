USE [dmab0913_4]
GO

/****** Object:  Table [dbo].[Route]    Script Date: 02-12-2014 19:33:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Route](
	[StartAirport] [varchar](10) NOT NULL,
	[EndAirport] [varchar](10) NOT NULL,
	[RouteNo] [int] IDENTITY(1,1) NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_Route] PRIMARY KEY CLUSTERED 
(
	[RouteNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Route]  WITH CHECK ADD  CONSTRAINT [FK_Route_Airport_End] FOREIGN KEY([EndAirport])
REFERENCES [dbo].[Airport] ([AirportCode])
GO

ALTER TABLE [dbo].[Route] CHECK CONSTRAINT [FK_Route_Airport_End]
GO

ALTER TABLE [dbo].[Route]  WITH CHECK ADD  CONSTRAINT [FK_Route_Airport_Start] FOREIGN KEY([StartAirport])
REFERENCES [dbo].[Airport] ([AirportCode])
GO

ALTER TABLE [dbo].[Route] CHECK CONSTRAINT [FK_Route_Airport_Start]
GO


