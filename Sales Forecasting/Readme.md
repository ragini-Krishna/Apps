# Sales Forecasting Application

This Sales Forecasting Application is built using VB.NET. It allows users to query sales data by year, apply individual percentage increases for each state,
and export the forecasted sales data to a CSV file. Additionally, the application can display the sales data in a pie chart.

Create Tables in SSMS


# Orders table

USE [rag]
GO

/****** Object:  Table [dbo].[Orders]    Script Date: 17-07-2024 11:24:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Orders](
	[OrderId] [nvarchar](50) NOT NULL,
	[OrderDate] [date] NULL,
	[ShipDate] [date] NULL,
	[ShipMode] [nvarchar](150) NULL,
	[CustomerId] [nvarchar](50) NULL,
	[CustomerName] [nvarchar](max) NULL,
	[Segment] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[PostalCode] [int] NULL,
	[Region] [nvarchar](50) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


# Products Table

USE [rag]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 17-07-2024 11:26:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[OrderId] [nvarchar](50) NULL,
	[ProductId] [nvarchar](50) NOT NULL,
	[Category] [nvarchar](50) NULL,
	[SubCategory] [nvarchar](50) NULL,
	[ProductName] [nvarchar](250) NULL,
	[Sales] [float] NULL,
	[Quantity] [float] NULL,
	[Discount] [float] NULL,
	[Profit] [float] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Orders]
GO


# Orders Return Table

USE [rag]
GO

/****** Object:  Table [dbo].[OrdersReturns]    Script Date: 17-07-2024 11:27:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrdersReturns](
	[ReturnId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [nvarchar](50) NOT NULL,
	[Comments] [nvarchar](max) NULL,
 CONSTRAINT [PK_OrdersReturns] PRIMARY KEY CLUSTERED 
(
	[ReturnId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[OrdersReturns]  WITH CHECK ADD  CONSTRAINT [FK_OrdersReturns_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO

ALTER TABLE [dbo].[OrdersReturns] CHECK CONSTRAINT [FK_OrdersReturns_Orders]
GO


