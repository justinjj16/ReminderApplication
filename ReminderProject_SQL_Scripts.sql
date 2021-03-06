USE [Reminders]
GO
/****** Object:  StoredProcedure [dbo].[SaveReminders]    Script Date: 17/04/2018 09:08:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveReminders]
	(@ReminderName varchar(50),
	@ReminderDescription nvarchar(max),
	@ReminderDate Datetime,
	@ShowBefore Int,
	@ReminderPriority Int)
	AS
BEGIN

	SET NOCOUNT ON;

    Insert into [dbo].[Reminder]([ReminderName],[ReminderDescription],[CreateDate],[UpdateDate])
	values(@ReminderName,@ReminderDescription,GetDate(),GetDate())

	declare @lastinsertId int

	Set @lastinsertId = IDENT_CURRENT('[dbo].[Reminder]')

	Insert into [dbo].[ReminderDates]([ReminderId],[ReminderDate],[Priority],[ShowBefore])
	values(@lastinsertId,@ReminderDate,@ReminderPriority,@ShowBefore)
END

GO
/****** Object:  StoredProcedure [dbo].[SelectAllReminders]    Script Date: 17/04/2018 09:08:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SelectAllReminders]
	
	AS
BEGIN

	SET NOCOUNT ON;
	 select a.[ReminderId] as Reminder,[ReminderName],[ReminderDescription],[ReminderDate],[Priority],[ShowBefore]
	 from [dbo].[Reminder] a inner join [dbo].[ReminderDates] b on a.ReminderId=b.ReminderId;

    end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllRemindersOnTime]    Script Date: 17/04/2018 09:08:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SelectAllRemindersOnTime]
	(@CurrentDateTime DateTime)
	AS
BEGIN

	SET NOCOUNT ON;
	 select a.[ReminderId] as Reminder,[ReminderName],[ReminderDescription],[ReminderDate],[Priority],[ShowBefore]
	 from [dbo].[Reminder] a inner join [dbo].[ReminderDates] b on a.ReminderId=b.ReminderId
	 Where DateAdd(MINUTE,-ShowBefore,b.[ReminderDate])< @CurrentDateTime and DateDiff(minute,DateAdd(MINUTE,-ShowBefore,b.[ReminderDate]),@CurrentDateTime) between 0 and 1

    end
GO
/****** Object:  StoredProcedure [dbo].[UpdateReminder]    Script Date: 17/04/2018 09:08:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[UpdateReminder]
(
	@ReminderId int ,
    @ReminderName varchar(50),
	@ReminderDescription nvarchar(max),
	@ReminderDate Datetime,
	@ShowBefore Int,
	@ReminderPriority Int)
	
	AS
BEGIN

	SET NOCOUNT ON;
	

	 update [dbo].[Reminder] set [ReminderName]=@ReminderName,[ReminderDescription]=@ReminderDescription where ReminderId=@ReminderId
	  update[dbo].[ReminderDates] set [ReminderDate]=@ReminderDate,[Priority]=@ReminderPriority,[ShowBefore]=@ShowBefore where ReminderId=@ReminderId

    end
GO
/****** Object:  Table [dbo].[Reminder]    Script Date: 17/04/2018 09:08:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reminder](
	[ReminderId] [int] IDENTITY(1,1) NOT NULL,
	[ReminderName] [varchar](50) NULL,
	[ReminderDescription] [nvarchar](max) NULL,
	[CreateDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReminderDates]    Script Date: 17/04/2018 09:08:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReminderDates](
	[ReminderDateId] [int] IDENTITY(1,1) NOT NULL,
	[ReminderId] [int] NOT NULL,
	[ReminderDate] [datetime] NOT NULL,
	[Priority] [int] NULL,
	[ShowBefore] [int] NULL,
	[ReminderMeAfter] [int] NULL
) ON [PRIMARY]

GO
