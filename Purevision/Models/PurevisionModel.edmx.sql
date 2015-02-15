
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/11/2015 17:11:48
-- Generated from EDMX file: E:\Purevision\1.0\Purevision\Purevision\Models\PurevisionModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Purevision];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MeetingAttendee_Meeting]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MeetingAttendees] DROP CONSTRAINT [FK_MeetingAttendee_Meeting];
GO
IF OBJECT_ID(N'[dbo].[FK_Meetings_Meetings]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Meetings] DROP CONSTRAINT [FK_Meetings_Meetings];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_AspNetUserRoles_AspNetRole]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetRole];
GO
IF OBJECT_ID(N'[dbo].[FK_AspNetUserRoles_AspNetUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetUser];
GO
IF OBJECT_ID(N'[dbo].[FK_BusinessProfiles_Businesses]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BusinessProfiles] DROP CONSTRAINT [FK_BusinessProfiles_Businesses];
GO
IF OBJECT_ID(N'[dbo].[FK_BusinessProfiles_ProfileProperties]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BusinessProfiles] DROP CONSTRAINT [FK_BusinessProfiles_ProfileProperties];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientProfiles_Clients]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientProfiles] DROP CONSTRAINT [FK_ClientProfiles_Clients];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientProfiles_ProfileProperties]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientProfiles] DROP CONSTRAINT [FK_ClientProfiles_ProfileProperties];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProfiles_ProfileProperties]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserProfiles] DROP CONSTRAINT [FK_UserProfiles_ProfileProperties];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProfiles_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserProfiles] DROP CONSTRAINT [FK_UserProfiles_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clients] DROP CONSTRAINT [FK_ClientUser];
GO
IF OBJECT_ID(N'[dbo].[FK_CompanyClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clients] DROP CONSTRAINT [FK_CompanyClient];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO
IF OBJECT_ID(N'[dbo].[MeetingAttendees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MeetingAttendees];
GO
IF OBJECT_ID(N'[dbo].[Meetings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Meetings];
GO
IF OBJECT_ID(N'[dbo].[AspNetRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserClaims];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserLogins];
GO
IF OBJECT_ID(N'[dbo].[AspNetUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[Tasks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tasks];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Businesses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Businesses];
GO
IF OBJECT_ID(N'[dbo].[BusinessProfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BusinessProfiles];
GO
IF OBJECT_ID(N'[dbo].[ClientProfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientProfiles];
GO
IF OBJECT_ID(N'[dbo].[Lists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lists];
GO
IF OBJECT_ID(N'[dbo].[ProfileProperties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfileProperties];
GO
IF OBJECT_ID(N'[dbo].[UserProfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserProfiles];
GO
IF OBJECT_ID(N'[dbo].[Organizations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Organizations];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserRoles];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nchar(10)  NULL,
    [UserId] int  NULL,
    [CompanyId] int  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'MeetingAttendees'
CREATE TABLE [dbo].[MeetingAttendees] (
    [MeetingID] int  NOT NULL,
    [AttendeeID] int  NOT NULL
);
GO

-- Creating table 'Meetings'
CREATE TABLE [dbo].[Meetings] (
    [MeetingID] int IDENTITY(1,1) NOT NULL,
    [Start] datetime  NOT NULL,
    [End] datetime  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [RoomID] int  NULL,
    [IsAllDay] bit  NOT NULL,
    [RecurrenceRule] nvarchar(max)  NULL,
    [RecurrenceID] int  NULL,
    [RecurrenceException] nvarchar(max)  NULL,
    [StartTimezone] nvarchar(max)  NULL,
    [EndTimezone] nvarchar(max)  NULL
);
GO

-- Creating table 'AspNetRoles'
CREATE TABLE [dbo].[AspNetRoles] (
    [Id] nvarchar(128)  NOT NULL,
    [Name] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'AspNetUserClaims'
CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(128)  NOT NULL,
    [ClaimType] nvarchar(max)  NULL,
    [ClaimValue] nvarchar(max)  NULL
);
GO

-- Creating table 'AspNetUserLogins'
CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider] nvarchar(128)  NOT NULL,
    [ProviderKey] nvarchar(128)  NOT NULL,
    [UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'AspNetUsers'
CREATE TABLE [dbo].[AspNetUsers] (
    [Id] nvarchar(128)  NOT NULL,
    [Email] nvarchar(256)  NULL,
    [EmailConfirmed] bit  NOT NULL,
    [PasswordHash] nvarchar(max)  NULL,
    [SecurityStamp] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [PhoneNumberConfirmed] bit  NOT NULL,
    [TwoFactorEnabled] bit  NOT NULL,
    [LockoutEndDateUtc] datetime  NULL,
    [LockoutEnabled] bit  NOT NULL,
    [AccessFailedCount] int  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'Tasks'
CREATE TABLE [dbo].[Tasks] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AspNetUserId] nvarchar(128)  NOT NULL,
    [FirstName] nvarchar(50)  NULL,
    [LastName] nvarchar(50)  NULL,
    [DisplayName] nvarchar(256)  NOT NULL,
    [Email] nvarchar(256)  NOT NULL,
    [CreatedByUserId] int  NOT NULL,
    [CreatedOnDate] datetime  NOT NULL,
    [LastModifiedByUserId] int  NULL,
    [LastModifiedOnDate] datetime  NULL,
    [IsAdmin] bit  NOT NULL,
    [IsDeleted] bit  NOT NULL
);
GO

-- Creating table 'Businesses'
CREATE TABLE [dbo].[Businesses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PrincipleOwnerUserId] int  NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Number] nchar(10)  NULL
);
GO

-- Creating table 'BusinessProfiles'
CREATE TABLE [dbo].[BusinessProfiles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BusinessId] int  NOT NULL,
    [PropertyId] int  NOT NULL,
    [PropertyValue] nvarchar(3750)  NULL,
    [PropertyText] nvarchar(max)  NULL,
    [Visibility] int  NOT NULL,
    [CreatedOnDate] datetime  NOT NULL,
    [CreatedByUserId] int  NOT NULL,
    [UpdatedOnDate] datetime  NOT NULL,
    [UpdatedByUserId] int  NOT NULL,
    [ArchivedOnDate] datetime  NOT NULL,
    [ArchivedByUserId] int  NOT NULL,
    [ExtendedVisibility] varchar(400)  NULL
);
GO

-- Creating table 'ClientProfiles'
CREATE TABLE [dbo].[ClientProfiles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClientId] int  NOT NULL,
    [PropertyId] int  NOT NULL,
    [PropertyValue] nvarchar(3750)  NULL,
    [PropertyText] nvarchar(max)  NULL,
    [Visibility] int  NOT NULL,
    [CreatedOnDate] datetime  NOT NULL,
    [CreatedByUserId] int  NOT NULL,
    [UpdatedOnDate] datetime  NOT NULL,
    [UpdatedByUserId] int  NOT NULL,
    [ArchivedOnDate] datetime  NOT NULL,
    [ArchivedByUserId] int  NOT NULL,
    [ExtendedVisibility] varchar(400)  NULL
);
GO

-- Creating table 'Lists'
CREATE TABLE [dbo].[Lists] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Value] nvarchar(100)  NOT NULL,
    [Text] nvarchar(150)  NOT NULL,
    [ParentId] int  NOT NULL,
    [Level] int  NOT NULL,
    [SortOrder] int  NOT NULL,
    [DefinitionId] int  NOT NULL,
    [Description] nvarchar(500)  NULL,
    [IsSystem] bit  NOT NULL,
    [CreatedOnDate] datetime  NULL,
    [CreatedByUserId] int  NULL,
    [UpdatedOnDate] datetime  NULL,
    [UpdatedByUserId] int  NULL,
    [ArchivedOnDate] datetime  NULL,
    [ArchivedByUserId] int  NULL
);
GO

-- Creating table 'ProfileProperties'
CREATE TABLE [dbo].[ProfileProperties] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataType] int  NOT NULL,
    [Default] nvarchar(max)  NULL,
    [Category] nvarchar(50)  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Length] int  NOT NULL,
    [Required] bit  NOT NULL,
    [Validation] nvarchar(2000)  NULL,
    [Order] int  NOT NULL,
    [Visible] bit  NOT NULL,
    [CreatedOnDate] datetime  NULL,
    [CreatedByUserID] int  NULL,
    [UpdatedOnDate] datetime  NULL,
    [UpdatedByUserID] int  NULL,
    [ArchivedOnDate] datetime  NULL,
    [ArchivedByUserID] int  NULL,
    [DefaultVisibility] int  NULL,
    [ReadOnly] bit  NOT NULL
);
GO

-- Creating table 'UserProfiles'
CREATE TABLE [dbo].[UserProfiles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL,
    [PropertyId] int  NOT NULL,
    [PropertyValue] nvarchar(3750)  NULL,
    [PropertyText] nvarchar(max)  NULL,
    [Visibility] int  NOT NULL,
    [CreatedOnDate] datetime  NOT NULL,
    [CreatedByUserId] int  NOT NULL,
    [UpdatedOnDate] datetime  NOT NULL,
    [UpdatedByUserId] int  NOT NULL,
    [ArchivedOnDate] datetime  NOT NULL,
    [ArchivedByUserId] int  NOT NULL,
    [ExtendedVisibility] varchar(400)  NULL
);
GO

-- Creating table 'Organizations'
CREATE TABLE [dbo].[Organizations] (
    [Id] int  NOT NULL,
    [ParentId] int  NULL,
    [ClientId] int  NULL,
    [BusinessId] int  NULL,
    [SortOrder] int  NULL,
    [Level] int  NULL,
    [CreatedOnDate] datetime  NULL,
    [CreatedByUserId] int  NULL,
    [UpdatedOnDate] datetime  NULL,
    [UpdatedByUserId] int  NULL,
    [ArchivedOnDate] datetime  NULL,
    [ArchivedByUserId] int  NULL
);
GO

-- Creating table 'AspNetUserRoles'
CREATE TABLE [dbo].[AspNetUserRoles] (
    [AspNetRoles_Id] nvarchar(128)  NOT NULL,
    [AspNetUsers_Id] nvarchar(128)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [MeetingID], [AttendeeID] in table 'MeetingAttendees'
ALTER TABLE [dbo].[MeetingAttendees]
ADD CONSTRAINT [PK_MeetingAttendees]
    PRIMARY KEY CLUSTERED ([MeetingID], [AttendeeID] ASC);
GO

-- Creating primary key on [MeetingID] in table 'Meetings'
ALTER TABLE [dbo].[Meetings]
ADD CONSTRAINT [PK_Meetings]
    PRIMARY KEY CLUSTERED ([MeetingID] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetRoles'
ALTER TABLE [dbo].[AspNetRoles]
ADD CONSTRAINT [PK_AspNetRoles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [PK_AspNetUserClaims]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [LoginProvider], [ProviderKey], [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [PK_AspNetUserLogins]
    PRIMARY KEY CLUSTERED ([LoginProvider], [ProviderKey], [UserId] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUsers'
ALTER TABLE [dbo].[AspNetUsers]
ADD CONSTRAINT [PK_AspNetUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [PK_Tasks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Businesses'
ALTER TABLE [dbo].[Businesses]
ADD CONSTRAINT [PK_Businesses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BusinessProfiles'
ALTER TABLE [dbo].[BusinessProfiles]
ADD CONSTRAINT [PK_BusinessProfiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientProfiles'
ALTER TABLE [dbo].[ClientProfiles]
ADD CONSTRAINT [PK_ClientProfiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Lists'
ALTER TABLE [dbo].[Lists]
ADD CONSTRAINT [PK_Lists]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProfileProperties'
ALTER TABLE [dbo].[ProfileProperties]
ADD CONSTRAINT [PK_ProfileProperties]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserProfiles'
ALTER TABLE [dbo].[UserProfiles]
ADD CONSTRAINT [PK_UserProfiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Organizations'
ALTER TABLE [dbo].[Organizations]
ADD CONSTRAINT [PK_Organizations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [AspNetRoles_Id], [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [PK_AspNetUserRoles]
    PRIMARY KEY CLUSTERED ([AspNetRoles_Id], [AspNetUsers_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MeetingID] in table 'MeetingAttendees'
ALTER TABLE [dbo].[MeetingAttendees]
ADD CONSTRAINT [FK_MeetingAttendee_Meeting]
    FOREIGN KEY ([MeetingID])
    REFERENCES [dbo].[Meetings]
        ([MeetingID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RecurrenceID] in table 'Meetings'
ALTER TABLE [dbo].[Meetings]
ADD CONSTRAINT [FK_Meetings_Meetings]
    FOREIGN KEY ([RecurrenceID])
    REFERENCES [dbo].[Meetings]
        ([MeetingID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Meetings_Meetings'
CREATE INDEX [IX_FK_Meetings_Meetings]
ON [dbo].[Meetings]
    ([RecurrenceID]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserClaims]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserLogins]
    ([UserId]);
GO

-- Creating foreign key on [AspNetRoles_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetRole]
    FOREIGN KEY ([AspNetRoles_Id])
    REFERENCES [dbo].[AspNetRoles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetUser]
    FOREIGN KEY ([AspNetUsers_Id])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AspNetUserRoles_AspNetUser'
CREATE INDEX [IX_FK_AspNetUserRoles_AspNetUser]
ON [dbo].[AspNetUserRoles]
    ([AspNetUsers_Id]);
GO

-- Creating foreign key on [BusinessId] in table 'BusinessProfiles'
ALTER TABLE [dbo].[BusinessProfiles]
ADD CONSTRAINT [FK_BusinessProfiles_Businesses]
    FOREIGN KEY ([BusinessId])
    REFERENCES [dbo].[Businesses]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BusinessProfiles_Businesses'
CREATE INDEX [IX_FK_BusinessProfiles_Businesses]
ON [dbo].[BusinessProfiles]
    ([BusinessId]);
GO

-- Creating foreign key on [PropertyId] in table 'BusinessProfiles'
ALTER TABLE [dbo].[BusinessProfiles]
ADD CONSTRAINT [FK_BusinessProfiles_ProfileProperties]
    FOREIGN KEY ([PropertyId])
    REFERENCES [dbo].[ProfileProperties]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BusinessProfiles_ProfileProperties'
CREATE INDEX [IX_FK_BusinessProfiles_ProfileProperties]
ON [dbo].[BusinessProfiles]
    ([PropertyId]);
GO

-- Creating foreign key on [ClientId] in table 'ClientProfiles'
ALTER TABLE [dbo].[ClientProfiles]
ADD CONSTRAINT [FK_ClientProfiles_Clients]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientProfiles_Clients'
CREATE INDEX [IX_FK_ClientProfiles_Clients]
ON [dbo].[ClientProfiles]
    ([ClientId]);
GO

-- Creating foreign key on [PropertyId] in table 'ClientProfiles'
ALTER TABLE [dbo].[ClientProfiles]
ADD CONSTRAINT [FK_ClientProfiles_ProfileProperties]
    FOREIGN KEY ([PropertyId])
    REFERENCES [dbo].[ProfileProperties]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientProfiles_ProfileProperties'
CREATE INDEX [IX_FK_ClientProfiles_ProfileProperties]
ON [dbo].[ClientProfiles]
    ([PropertyId]);
GO

-- Creating foreign key on [PropertyId] in table 'UserProfiles'
ALTER TABLE [dbo].[UserProfiles]
ADD CONSTRAINT [FK_UserProfiles_ProfileProperties]
    FOREIGN KEY ([PropertyId])
    REFERENCES [dbo].[ProfileProperties]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProfiles_ProfileProperties'
CREATE INDEX [IX_FK_UserProfiles_ProfileProperties]
ON [dbo].[UserProfiles]
    ([PropertyId]);
GO

-- Creating foreign key on [UserId] in table 'UserProfiles'
ALTER TABLE [dbo].[UserProfiles]
ADD CONSTRAINT [FK_UserProfiles_Users]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProfiles_Users'
CREATE INDEX [IX_FK_UserProfiles_Users]
ON [dbo].[UserProfiles]
    ([UserId]);
GO

-- Creating foreign key on [User_Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [FK_ClientUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientUser'
CREATE INDEX [IX_FK_ClientUser]
ON [dbo].[Clients]
    ([User_Id]);
GO

-- Creating foreign key on [CompanyId] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [FK_CompanyClient]
    FOREIGN KEY ([CompanyId])
    REFERENCES [dbo].[Organizations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyClient'
CREATE INDEX [IX_FK_CompanyClient]
ON [dbo].[Clients]
    ([CompanyId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------