USE [workdbs]
GO
/****** Object:  Table [dbo].[Conferences]    Script Date: 06.10.2023 19:23:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conferences](
	[ConfId] [int] IDENTITY(1,1) NOT NULL,
	[ConfName] [varchar](50) NOT NULL,
	[ConfDate] [date] NOT NULL,
	[ConfPlace] [varchar](150) NOT NULL,
 CONSTRAINT [PK_Conferences] PRIMARY KEY CLUSTERED 
(
	[ConfId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reports]    Script Date: 06.10.2023 19:23:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reports](
	[RepId] [int] IDENTITY(1,1) NOT NULL,
	[RepTheme] [varchar](140) NOT NULL,
	[RepAuthor] [int] NOT NULL,
	[RepConf] [int] NOT NULL,
 CONSTRAINT [PK_Reports] PRIMARY KEY CLUSTERED 
(
	[RepId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Scientists]    Script Date: 06.10.2023 19:23:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Scientists](
	[ScId] [int] IDENTITY(1,1) NOT NULL,
	[ScFIO] [varchar](100) NOT NULL,
	[ScDeg] [varchar](15) NOT NULL,
	[ScCountry] [varchar](50) NOT NULL,
	[ScOrg] [varchar](70) NOT NULL,
 CONSTRAINT [PK_Scientists] PRIMARY KEY CLUSTERED 
(
	[ScId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Conferences] ON 

INSERT [dbo].[Conferences] ([ConfId], [ConfName], [ConfDate], [ConfPlace]) VALUES (1, N'Международная экономическая конференция', CAST(N'2023-03-04' AS Date), N'Республика Беларусь, Минск')
INSERT [dbo].[Conferences] ([ConfId], [ConfName], [ConfDate], [ConfPlace]) VALUES (2, N'Международная физико-математическая конференция', CAST(N'2023-06-06' AS Date), N'Российская Федерация, Санкт-Петербург')
INSERT [dbo].[Conferences] ([ConfId], [ConfName], [ConfDate], [ConfPlace]) VALUES (5, N'dasdad', CAST(N'0001-01-01' AS Date), N'dasda')
INSERT [dbo].[Conferences] ([ConfId], [ConfName], [ConfDate], [ConfPlace]) VALUES (6, N'xdxd', CAST(N'0001-01-01' AS Date), N'xdxd')
SET IDENTITY_INSERT [dbo].[Conferences] OFF
GO
SET IDENTITY_INSERT [dbo].[Reports] ON 

INSERT [dbo].[Reports] ([RepId], [RepTheme], [RepAuthor], [RepConf]) VALUES (3, N'Голограмма и ее применение', 1, 2)
INSERT [dbo].[Reports] ([RepId], [RepTheme], [RepAuthor], [RepConf]) VALUES (4, N'Экономика предприятия пищевой промышленности и ее специфика в области инвестиций', 2, 1)
INSERT [dbo].[Reports] ([RepId], [RepTheme], [RepAuthor], [RepConf]) VALUES (5, N'Большой адронный коллайдер — путь к апокалипсису или прогрессу?', 3, 2)
INSERT [dbo].[Reports] ([RepId], [RepTheme], [RepAuthor], [RepConf]) VALUES (6, N'Еда из микроволновки: польза или вред?', 4, 2)
INSERT [dbo].[Reports] ([RepId], [RepTheme], [RepAuthor], [RepConf]) VALUES (7, N'Комплексная жилая застройка городских территорий: этапы управления и их основные характеристики', 5, 1)
INSERT [dbo].[Reports] ([RepId], [RepTheme], [RepAuthor], [RepConf]) VALUES (8, N'Матричная алгебра в экономике', 6, 2)
INSERT [dbo].[Reports] ([RepId], [RepTheme], [RepAuthor], [RepConf]) VALUES (9, N'Правовое обеспечение экономической безопасности в условиях построения цифровой экономики', 7, 1)
INSERT [dbo].[Reports] ([RepId], [RepTheme], [RepAuthor], [RepConf]) VALUES (10, N'Теория общественного выбора и анализ принятия решений в современной экономике', 8, 1)
INSERT [dbo].[Reports] ([RepId], [RepTheme], [RepAuthor], [RepConf]) VALUES (11, N'Оптимизация источников финансирования долгосрочных инвестиционных проектов', 9, 1)
INSERT [dbo].[Reports] ([RepId], [RepTheme], [RepAuthor], [RepConf]) VALUES (12, N'Вероятностно-статистический подход к компьютерной обработке данных', 10, 2)
SET IDENTITY_INSERT [dbo].[Reports] OFF
GO
SET IDENTITY_INSERT [dbo].[Scientists] ON 

INSERT [dbo].[Scientists] ([ScId], [ScFIO], [ScDeg], [ScCountry], [ScOrg]) VALUES (1, N'Ульянов Дмитрий Даниилович', N'д.ф.-м.н.', N'Российская Федерация', N'Москоовский госудаарственный университеет иимени М. В. Ломоноосова')
INSERT [dbo].[Scientists] ([ScId], [ScFIO], [ScDeg], [ScCountry], [ScOrg]) VALUES (2, N'Волошин Руслан Игоревич', N'д.э.н.', N'Российская Федерация', N'Государственный гуманитарно-технологический университет')
INSERT [dbo].[Scientists] ([ScId], [ScFIO], [ScDeg], [ScCountry], [ScOrg]) VALUES (3, N'Васильева Анастасия Егоровна', N'д.ф.-м.н.', N'Республика Беларусь', N'Барановичский государственный университет')
INSERT [dbo].[Scientists] ([ScId], [ScFIO], [ScDeg], [ScCountry], [ScOrg]) VALUES (4, N'Киселев Михаил Данилович', N'к.ф.-м.н.', N'Российская Федерация', N'Московский физико-технический институт')
INSERT [dbo].[Scientists] ([ScId], [ScFIO], [ScDeg], [ScCountry], [ScOrg]) VALUES (5, N'Вдовин Артём Макарович', N'д.э.н.', N'Республика Беларусь', N'Барановичский государственный университет')
INSERT [dbo].[Scientists] ([ScId], [ScFIO], [ScDeg], [ScCountry], [ScOrg]) VALUES (6, N'Новикова Анна Максимовна', N'д.ф.-м.н.', N'Республика Беларусь', N'Белорусский государственный университет')
INSERT [dbo].[Scientists] ([ScId], [ScFIO], [ScDeg], [ScCountry], [ScOrg]) VALUES (7, N'Козлов Артём Иванович', N'д.э.н.', N'Российская Федерация', N'Государственный гуманитарно-технологический университет')
INSERT [dbo].[Scientists] ([ScId], [ScFIO], [ScDeg], [ScCountry], [ScOrg]) VALUES (8, N'Королев Артур Адамович', N'к.э.н. ', N'Российская Федерация', N'Государственный гуманитарно-технологический университет')
INSERT [dbo].[Scientists] ([ScId], [ScFIO], [ScDeg], [ScCountry], [ScOrg]) VALUES (9, N'Соболев Артём Михайлович', N'д.э.н.', N'Республика Беларусь', N'Белорусский государственный университет')
INSERT [dbo].[Scientists] ([ScId], [ScFIO], [ScDeg], [ScCountry], [ScOrg]) VALUES (10, N'Борисова Арина Владимировна', N'д.ф.-м.н.', N'Российская Федерация', N'Государственный гуманитарно-технологический университет')
INSERT [dbo].[Scientists] ([ScId], [ScFIO], [ScDeg], [ScCountry], [ScOrg]) VALUES (14, N'dsada', N'asda', N'dasda', N'adsda')
INSERT [dbo].[Scientists] ([ScId], [ScFIO], [ScDeg], [ScCountry], [ScOrg]) VALUES (15, N'xdxd', N'xdxd', N'xdxd', N'xdxd')
SET IDENTITY_INSERT [dbo].[Scientists] OFF
GO
ALTER TABLE [dbo].[Reports]  WITH CHECK ADD  CONSTRAINT [FK_Reports_Conferences] FOREIGN KEY([RepConf])
REFERENCES [dbo].[Conferences] ([ConfId])
GO
ALTER TABLE [dbo].[Reports] CHECK CONSTRAINT [FK_Reports_Conferences]
GO
ALTER TABLE [dbo].[Reports]  WITH CHECK ADD  CONSTRAINT [FK_Reports_Scientists] FOREIGN KEY([RepAuthor])
REFERENCES [dbo].[Scientists] ([ScId])
GO
ALTER TABLE [dbo].[Reports] CHECK CONSTRAINT [FK_Reports_Scientists]
GO
