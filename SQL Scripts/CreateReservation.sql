USE [dmab0913_4]
GO

/****** Object:  Table [dbo].[Reservation]    Script Date: 02-12-2014 19:30:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reservation](
	[ReservationNo] [int] IDENTITY(1,1) NOT NULL,
	[TotalPrice] [float] NOT NULL,
	[CustomerNo] [int] NOT NULL,
	[Amount] [int] NOT NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[ReservationNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Customer] FOREIGN KEY([CustomerNo])
REFERENCES [dbo].[Customer] ([CustomerNo])
GO

ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Customer]
GO


