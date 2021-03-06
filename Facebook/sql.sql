USE [Facebook]
GO
/****** Object:  Table [dbo].[account]    Script Date: 8/10/2020 6:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[user id] [int] IDENTITY(1,1) NOT NULL,
	[user_account] [nvarchar](50) NULL,
	[user_pass] [nvarchar](50) NULL,
 CONSTRAINT [PK_account] PRIMARY KEY CLUSTERED 
(
	[user id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[account] ON 

INSERT [dbo].[account] ([user id], [user_account], [user_pass]) VALUES (2, N'tung', N'1')
SET IDENTITY_INSERT [dbo].[account] OFF
