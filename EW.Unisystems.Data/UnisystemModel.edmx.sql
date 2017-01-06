
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/23/2016 16:50:17
-- Generated from EDMX file: D:\UNISYSTEM\EW.Unisystems.Data\UnisystemModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBUnisystem];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Resource__IdCare__08EA5793]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK__Resource__IdCare__08EA5793];
GO
IF OBJECT_ID(N'[dbo].[FK__Resource__TypeRe__1920BF5C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK__Resource__TypeRe__1920BF5C];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Activity]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Activity];
GO
IF OBJECT_ID(N'[dbo].[Career]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Career];
GO
IF OBJECT_ID(N'[dbo].[Gallery]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Gallery];
GO
IF OBJECT_ID(N'[dbo].[News]', 'U') IS NOT NULL
    DROP TABLE [dbo].[News];
GO
IF OBJECT_ID(N'[dbo].[Person]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Person];
GO
IF OBJECT_ID(N'[dbo].[Resource]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Resource];
GO
IF OBJECT_ID(N'[dbo].[TypeResources]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeResources];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Activity'
CREATE TABLE [dbo].[Activity] (
    [IdActivity] int IDENTITY(1,1) NOT NULL,
    [DateActivity] datetime  NOT NULL,
    [Title] varchar(100)  NOT NULL,
    [Description] varchar(200)  NOT NULL,
    [Time] varchar(10)  NOT NULL,
    [Image] varbinary(max)  NOT NULL
);
GO

-- Creating table 'Career'
CREATE TABLE [dbo].[Career] (
    [IdCareer] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(100)  NOT NULL,
    [Description] varchar(200)  NOT NULL
);
GO

-- Creating table 'Gallery'
CREATE TABLE [dbo].[Gallery] (
    [IdImage] int IDENTITY(1,1) NOT NULL,
    [Title] varchar(100)  NOT NULL,
    [Description] varchar(200)  NULL,
    [Image] varbinary(max)  NULL
);
GO

-- Creating table 'News'
CREATE TABLE [dbo].[News] (
    [IdNews] int IDENTITY(1,1) NOT NULL,
    [Title] varchar(100)  NOT NULL,
    [Content] varchar(500)  NOT NULL,
    [DateNews] datetime  NOT NULL,
    [Image] varbinary(max)  NULL
);
GO

-- Creating table 'Person'
CREATE TABLE [dbo].[Person] (
    [IdPerson] int IDENTITY(1,1) NOT NULL,
    [NamePerson] varchar(50)  NOT NULL,
    [LastName] varchar(50)  NOT NULL,
    [UserName] varchar(20)  NOT NULL,
    [Password] varchar(20)  NOT NULL,
    [Phone] varchar(30)  NULL
);
GO

-- Creating table 'Resource'
CREATE TABLE [dbo].[Resource] (
    [IdResource] int IDENTITY(1,1) NOT NULL,
    [IdCareer] int  NOT NULL,
    [Title] varchar(100)  NOT NULL,
    [Description] varchar(200)  NULL,
    [Link] varchar(300)  NOT NULL,
    [TypeResource] int  NOT NULL,
    [Author] varchar(50)  NOT NULL,
    [ResourceImage] varbinary(max)  NULL
);
GO

-- Creating table 'TypeResources'
CREATE TABLE [dbo].[TypeResources] (
    [IdResource] int IDENTITY(1,1) NOT NULL,
    [TypeName] varchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdActivity] in table 'Activity'
ALTER TABLE [dbo].[Activity]
ADD CONSTRAINT [PK_Activity]
    PRIMARY KEY CLUSTERED ([IdActivity] ASC);
GO

-- Creating primary key on [IdCareer] in table 'Career'
ALTER TABLE [dbo].[Career]
ADD CONSTRAINT [PK_Career]
    PRIMARY KEY CLUSTERED ([IdCareer] ASC);
GO

-- Creating primary key on [IdImage] in table 'Gallery'
ALTER TABLE [dbo].[Gallery]
ADD CONSTRAINT [PK_Gallery]
    PRIMARY KEY CLUSTERED ([IdImage] ASC);
GO

-- Creating primary key on [IdNews] in table 'News'
ALTER TABLE [dbo].[News]
ADD CONSTRAINT [PK_News]
    PRIMARY KEY CLUSTERED ([IdNews] ASC);
GO

-- Creating primary key on [IdPerson] in table 'Person'
ALTER TABLE [dbo].[Person]
ADD CONSTRAINT [PK_Person]
    PRIMARY KEY CLUSTERED ([IdPerson] ASC);
GO

-- Creating primary key on [IdResource] in table 'Resource'
ALTER TABLE [dbo].[Resource]
ADD CONSTRAINT [PK_Resource]
    PRIMARY KEY CLUSTERED ([IdResource] ASC);
GO

-- Creating primary key on [IdResource] in table 'TypeResources'
ALTER TABLE [dbo].[TypeResources]
ADD CONSTRAINT [PK_TypeResources]
    PRIMARY KEY CLUSTERED ([IdResource] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdCareer] in table 'Resource'
ALTER TABLE [dbo].[Resource]
ADD CONSTRAINT [FK__Resource__IdCare__08EA5793]
    FOREIGN KEY ([IdCareer])
    REFERENCES [dbo].[Career]
        ([IdCareer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Resource__IdCare__08EA5793'
CREATE INDEX [IX_FK__Resource__IdCare__08EA5793]
ON [dbo].[Resource]
    ([IdCareer]);
GO

-- Creating foreign key on [TypeResource] in table 'Resource'
ALTER TABLE [dbo].[Resource]
ADD CONSTRAINT [FK__Resource__TypeRe__1920BF5C]
    FOREIGN KEY ([TypeResource])
    REFERENCES [dbo].[TypeResources]
        ([IdResource])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Resource__TypeRe__1920BF5C'
CREATE INDEX [IX_FK__Resource__TypeRe__1920BF5C]
ON [dbo].[Resource]
    ([TypeResource]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------