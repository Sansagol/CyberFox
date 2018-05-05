/* ---------------------------------------------------- */
/*  Created On : 21-апр-2018 20:27:52 					*/
/*  DBMS       : SQL Server 2012 						*/
/* ---------------------------------------------------- */

/* Drop Foreign Key Constraints */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Sn_Group_Social_Network]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Sn_Group] DROP CONSTRAINT [FK_Sn_Group_Social_Network]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Sn_User_Social_Network]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Sn_User] DROP CONSTRAINT [FK_Sn_User_Social_Network]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Sn_Group]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Sn_Group]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Sn_User]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Sn_User]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Social_Network]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Social_Network]
GO

/* Create Tables */

CREATE TABLE [Sn_Group]
(
	[Id_Sn_Group] bigint NOT NULL IDENTITY (1, 1),
	[Id_Social_Network] int NOT NULL,
	[Sn_Group_Id] nvarchar(256) NOT NULL,
	[Name] nvarchar(512) NULL
)
GO

CREATE TABLE [Sn_User]
(
	[Id_Sn_User] bigint NOT NULL IDENTITY (1, 1),
	[Sn_User_Id] nvarchar(50) NOT NULL,    -- Id user in the soc.net
	[Name] nvarchar(256) NULL,
	[Surname] nvarchar(256) NULL,
	[Id_Social_Network] int NOT NULL DEFAULT 0
)
GO

CREATE TABLE [Social_Network]
(
	[Id_Social_Network] int NOT NULL,
	[Name] nvarchar(256) NOT NULL,
	[Target_Site] nvarchar(256) NOT NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [Sn_Group] 
 ADD CONSTRAINT [PK_Sn_Group]
	PRIMARY KEY CLUSTERED ([Id_Sn_Group] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Sn_Group_Social_Network] 
 ON [Sn_Group] ([Id_Social_Network] ASC)
GO

ALTER TABLE [Sn_User] 
 ADD CONSTRAINT [PK_SnUser]
	PRIMARY KEY CLUSTERED ([Id_Sn_User] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Sn_User_Social_Network] 
 ON [Sn_User] ([Id_Social_Network] ASC)
GO

ALTER TABLE [Social_Network] 
 ADD CONSTRAINT [PK_Social_Network]
	PRIMARY KEY CLUSTERED ([Id_Social_Network] ASC)
GO

/* Create Foreign Key Constraints */

ALTER TABLE [Sn_Group] ADD CONSTRAINT [FK_Sn_Group_Social_Network]
	FOREIGN KEY ([Id_Social_Network]) REFERENCES [Social_Network] ([Id_Social_Network]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Sn_User] ADD CONSTRAINT [FK_Sn_User_Social_Network]
	FOREIGN KEY ([Id_Social_Network]) REFERENCES [Social_Network] ([Id_Social_Network]) ON DELETE No Action ON UPDATE No Action
GO

/* Create Table Comments */

EXEC sp_addextendedproperty 'MS_Description', 'Id user in the soc.net', 'Schema', [dbo], 'table', [Sn_User], 'column', [Sn_User_Id]
GO
