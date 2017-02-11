
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/09/2017 23:39:59
-- Generated from EDMX file: F:\LuobaoDemo\AnQuanSys\ZhuGuan.AnQuan\ZhuGuan.AnQuan.Model\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AnQuan];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UnitInfoUserInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserInfo] DROP CONSTRAINT [FK_UnitInfoUserInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_UnitInfoTeamInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamInfo] DROP CONSTRAINT [FK_UnitInfoTeamInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_UserInfoRoleInfo_UserInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserInfoRoleInfo] DROP CONSTRAINT [FK_UserInfoRoleInfo_UserInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_UserInfoRoleInfo_RoleInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserInfoRoleInfo] DROP CONSTRAINT [FK_UserInfoRoleInfo_RoleInfo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UnitInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UnitInfo];
GO
IF OBJECT_ID(N'[dbo].[UserInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserInfo];
GO
IF OBJECT_ID(N'[dbo].[TeamInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeamInfo];
GO
IF OBJECT_ID(N'[dbo].[AccidentInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccidentInfo];
GO
IF OBJECT_ID(N'[dbo].[HiddenDangerInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HiddenDangerInfo];
GO
IF OBJECT_ID(N'[dbo].[RoleInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RoleInfo];
GO
IF OBJECT_ID(N'[dbo].[UserInfoRoleInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserInfoRoleInfo];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UnitInfo'
CREATE TABLE [dbo].[UnitInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UnitName] nvarchar(32)  NOT NULL,
    [IsInspUnit] smallint  NOT NULL,
    [IsZrdw] smallint  NOT NULL,
    [DelFlag] smallint  NOT NULL,
    [UnitProperty] nvarchar(32)  NOT NULL,
    [Remark] nvarchar(64)  NULL
);
GO

-- Creating table 'UserInfo'
CREATE TABLE [dbo].[UserInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(32)  NOT NULL,
    [Pwd] nvarchar(32)  NOT NULL,
    [DelFlag] smallint  NOT NULL,
    [Remark] nvarchar(64)  NULL,
    [IsVerified] smallint  NOT NULL,
    [UnitInfoId] int  NOT NULL
);
GO

-- Creating table 'TeamInfo'
CREATE TABLE [dbo].[TeamInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TeamName] nvarchar(32)  NOT NULL,
    [DelFlag] smallint  NOT NULL,
    [Remark] nvarchar(64)  NULL,
    [UnitInfoId] int  NOT NULL
);
GO

-- Creating table 'AccidentInfo'
CREATE TABLE [dbo].[AccidentInfo] (
    [AId] int IDENTITY(1,1) NOT NULL,
    [HappenDate] datetime  NOT NULL,
    [Unit] nvarchar(32)  NULL,
    [AcciType] nvarchar(32)  NULL,
    [AcciDesp] nvarchar(256)  NULL,
    [AcciAnalysis] nvarchar(256)  NULL,
    [Class2] nvarchar(32)  NULL,
    [Remark] nvarchar(64)  NULL,
    [DelFlag] smallint  NOT NULL
);
GO

-- Creating table 'HiddenDangerInfo'
CREATE TABLE [dbo].[HiddenDangerInfo] (
    [HDId] int IDENTITY(1,1) NOT NULL,
    [InspDate] datetime  NOT NULL,
    [InspUnit] nvarchar(32)  NOT NULL,
    [Zrdw] nvarchar(32)  NULL,
    [Zrbz] nvarchar(32)  NULL,
    [HidProblem] nvarchar(128)  NULL,
    [ReformMeasure] nvarchar(128)  NULL,
    [PreTime] datetime  NULL,
    [AchievedDesp] nvarchar(128)  NULL,
    [ReasonNotCompleted] nvarchar(128)  NULL,
    [TraceMan] nvarchar(32)  NULL,
    [Class2] nvarchar(32)  NULL,
    [Level2] nvarchar(32)  NULL,
    [Remark] nvarchar(64)  NULL,
    [DelFlag] smallint  NULL
);
GO

-- Creating table 'RoleInfo'
CREATE TABLE [dbo].[RoleInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RoleName] nvarchar(32)  NOT NULL,
    [DelFlag] smallint  NOT NULL,
    [Remark] nvarchar(64)  NULL
);
GO

-- Creating table 'CaseAnalysisInfo'
CREATE TABLE [dbo].[CaseAnalysisInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(128)  NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [SubTime] datetime  NOT NULL,
    [DelFlag] smallint  NOT NULL,
    [Remark] nvarchar(128)  NULL
);
GO

-- Creating table 'UserInfoRoleInfo'
CREATE TABLE [dbo].[UserInfoRoleInfo] (
    [UserInfo_Id] int  NOT NULL,
    [RoleInfo_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UnitInfo'
ALTER TABLE [dbo].[UnitInfo]
ADD CONSTRAINT [PK_UnitInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserInfo'
ALTER TABLE [dbo].[UserInfo]
ADD CONSTRAINT [PK_UserInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TeamInfo'
ALTER TABLE [dbo].[TeamInfo]
ADD CONSTRAINT [PK_TeamInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [AId] in table 'AccidentInfo'
ALTER TABLE [dbo].[AccidentInfo]
ADD CONSTRAINT [PK_AccidentInfo]
    PRIMARY KEY CLUSTERED ([AId] ASC);
GO

-- Creating primary key on [HDId] in table 'HiddenDangerInfo'
ALTER TABLE [dbo].[HiddenDangerInfo]
ADD CONSTRAINT [PK_HiddenDangerInfo]
    PRIMARY KEY CLUSTERED ([HDId] ASC);
GO

-- Creating primary key on [Id] in table 'RoleInfo'
ALTER TABLE [dbo].[RoleInfo]
ADD CONSTRAINT [PK_RoleInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CaseAnalysisInfo'
ALTER TABLE [dbo].[CaseAnalysisInfo]
ADD CONSTRAINT [PK_CaseAnalysisInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [UserInfo_Id], [RoleInfo_Id] in table 'UserInfoRoleInfo'
ALTER TABLE [dbo].[UserInfoRoleInfo]
ADD CONSTRAINT [PK_UserInfoRoleInfo]
    PRIMARY KEY CLUSTERED ([UserInfo_Id], [RoleInfo_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UnitInfoId] in table 'UserInfo'
ALTER TABLE [dbo].[UserInfo]
ADD CONSTRAINT [FK_UnitInfoUserInfo]
    FOREIGN KEY ([UnitInfoId])
    REFERENCES [dbo].[UnitInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UnitInfoUserInfo'
CREATE INDEX [IX_FK_UnitInfoUserInfo]
ON [dbo].[UserInfo]
    ([UnitInfoId]);
GO

-- Creating foreign key on [UnitInfoId] in table 'TeamInfo'
ALTER TABLE [dbo].[TeamInfo]
ADD CONSTRAINT [FK_UnitInfoTeamInfo]
    FOREIGN KEY ([UnitInfoId])
    REFERENCES [dbo].[UnitInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UnitInfoTeamInfo'
CREATE INDEX [IX_FK_UnitInfoTeamInfo]
ON [dbo].[TeamInfo]
    ([UnitInfoId]);
GO

-- Creating foreign key on [UserInfo_Id] in table 'UserInfoRoleInfo'
ALTER TABLE [dbo].[UserInfoRoleInfo]
ADD CONSTRAINT [FK_UserInfoRoleInfo_UserInfo]
    FOREIGN KEY ([UserInfo_Id])
    REFERENCES [dbo].[UserInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RoleInfo_Id] in table 'UserInfoRoleInfo'
ALTER TABLE [dbo].[UserInfoRoleInfo]
ADD CONSTRAINT [FK_UserInfoRoleInfo_RoleInfo]
    FOREIGN KEY ([RoleInfo_Id])
    REFERENCES [dbo].[RoleInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserInfoRoleInfo_RoleInfo'
CREATE INDEX [IX_FK_UserInfoRoleInfo_RoleInfo]
ON [dbo].[UserInfoRoleInfo]
    ([RoleInfo_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------