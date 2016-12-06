USE [dmab0913_4]
GO

/****** Object:  Table [dbo].[PartReservation]    Script Date: 02-12-2014 19:26:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PartReservation](
	[FlightNo] [int] NOT NULL,
	[ReservationNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReservationNo] ASC,
	[FlightNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[PartReservation]  WITH CHECK ADD  CONSTRAINT [FK_PartReservation_FlightNo] FOREIGN KEY([FlightNo])
REFERENCES [dbo].[Flight] ([FlightNo])
GO

ALTER TABLE [dbo].[PartReservation] CHECK CONSTRAINT [FK_PartReservation_FlightNo]
GO

ALTER TABLE [dbo].[PartReservation]  WITH CHECK ADD  CONSTRAINT [FK_PartReservation_Reservation] FOREIGN KEY([ReservationNo])
REFERENCES [dbo].[Reservation] ([ReservationNo])
GO

ALTER TABLE [dbo].[PartReservation] CHECK CONSTRAINT [FK_PartReservation_Reservation]
GO


