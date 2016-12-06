USE [dmab0913_4]
GO

/****** Object:  Table [dbo].[Seat]    Script Date: 02-12-2014 19:33:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Seat](
	[FlightNo] [int] NOT NULL,
	[Reserved] [bit] NOT NULL,
	[SeatNo] [int] NOT NULL,
	[RowNo] [int] NOT NULL,
 CONSTRAINT [PK_Seat] PRIMARY KEY CLUSTERED 
(
	[FlightNo] ASC,
	[SeatNo] ASC,
	[RowNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Seat]  WITH CHECK ADD  CONSTRAINT [FK_Seat_FlightNo] FOREIGN KEY([FlightNo])
REFERENCES [dbo].[Flight] ([FlightNo])
GO

ALTER TABLE [dbo].[Seat] CHECK CONSTRAINT [FK_Seat_FlightNo]
GO


