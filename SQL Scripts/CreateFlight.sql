USE [dmab0913_4]
GO

/****** Object:  Table [dbo].[Flight]    Script Date: 02-12-2014 19:33:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Flight](
	[FlightNo] [int] IDENTITY(1,1) NOT NULL,
	[DepartureTime] [time](7) NOT NULL,
	[ArrivalTime] [time](7) NOT NULL,
	[DepartureDate] [date] NOT NULL,
	[ArrivalDate] [date] NOT NULL,
	[TotalSeats] [int] NOT NULL,
	[ReservedSeats] [int] NOT NULL,
	[RouteNo] [int] NOT NULL,
 CONSTRAINT [PK_Flight] PRIMARY KEY CLUSTERED 
(
	[FlightNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Flight]  WITH CHECK ADD  CONSTRAINT [FK_Route_RouteNo] FOREIGN KEY([RouteNo])
REFERENCES [dbo].[Route] ([RouteNo])
GO

ALTER TABLE [dbo].[Flight] CHECK CONSTRAINT [FK_Route_RouteNo]
GO


