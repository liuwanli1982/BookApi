CREATE TABLE [dbo].[Book](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [Author] [nvarchar](max) NULL,
    [Name] [nvarchar](50) NOT NULL,
    [Price] [decimal](18, 2) NOT NULL,
    [ReleaseDate] [datetime2](7) NOT NULL,
    [Publishing] [nvarchar](max) NOT NULL,
    [RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED
(
    [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]