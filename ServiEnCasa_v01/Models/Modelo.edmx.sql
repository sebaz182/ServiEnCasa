
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/05/2016 14:54:37
-- Generated from EDMX file: C:\Users\Sebastian\Google Drive\Facultad\5to\SAP TFI\2 - Desarrollo\00 - Código\ServiEnCasa_v01\ServiEnCasa_v01\Models\Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ServiEnCasa_v01];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Servis'
CREATE TABLE [dbo].[Servis] (
    [Id_Servi] int IDENTITY(1,1) NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [DNI] nvarchar(max)  NOT NULL,
    [Matricula] nvarchar(max)  NOT NULL,
    [Pass] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'Profesiones'
CREATE TABLE [dbo].[Profesiones] (
    [Id_Profesion] int IDENTITY(1,1) NOT NULL,
    [Desc_Profesion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tareas'
CREATE TABLE [dbo].[Tareas] (
    [Id_Tarea] int IDENTITY(1,1) NOT NULL,
    [Desc_Tarea] nvarchar(max)  NOT NULL,
    [Profesiones_Id_Profesion] int  NOT NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id_Usuario] int IDENTITY(1,1) NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Pass] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'Solicitudes'
CREATE TABLE [dbo].[Solicitudes] (
    [Id_Ssolisitud] int IDENTITY(1,1) NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Contador] int  NOT NULL,
    [Foto] nvarchar(max)  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Zona] nvarchar(max)  NOT NULL,
    [Desc_Solicitud] nvarchar(max)  NOT NULL,
    [Usuarios_Id_Usuario] int  NOT NULL
);
GO

-- Creating table 'Presupuestos'
CREATE TABLE [dbo].[Presupuestos] (
    [Id_Presupuesto] int IDENTITY(1,1) NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Fecha_Vencimiento] datetime  NOT NULL,
    [Precio] decimal(18,0)  NOT NULL,
    [Observacion] nvarchar(max)  NOT NULL,
    [Solicitudes_Id_Ssolisitud] int  NOT NULL
);
GO

-- Creating table 'ServisProfesiones'
CREATE TABLE [dbo].[ServisProfesiones] (
    [Servis_Id_Servi] int  NOT NULL,
    [Profesiones_Id_Profesion] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_Servi] in table 'Servis'
ALTER TABLE [dbo].[Servis]
ADD CONSTRAINT [PK_Servis]
    PRIMARY KEY CLUSTERED ([Id_Servi] ASC);
GO

-- Creating primary key on [Id_Profesion] in table 'Profesiones'
ALTER TABLE [dbo].[Profesiones]
ADD CONSTRAINT [PK_Profesiones]
    PRIMARY KEY CLUSTERED ([Id_Profesion] ASC);
GO

-- Creating primary key on [Id_Tarea] in table 'Tareas'
ALTER TABLE [dbo].[Tareas]
ADD CONSTRAINT [PK_Tareas]
    PRIMARY KEY CLUSTERED ([Id_Tarea] ASC);
GO

-- Creating primary key on [Id_Usuario] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id_Usuario] ASC);
GO

-- Creating primary key on [Id_Ssolisitud] in table 'Solicitudes'
ALTER TABLE [dbo].[Solicitudes]
ADD CONSTRAINT [PK_Solicitudes]
    PRIMARY KEY CLUSTERED ([Id_Ssolisitud] ASC);
GO

-- Creating primary key on [Id_Presupuesto] in table 'Presupuestos'
ALTER TABLE [dbo].[Presupuestos]
ADD CONSTRAINT [PK_Presupuestos]
    PRIMARY KEY CLUSTERED ([Id_Presupuesto] ASC);
GO

-- Creating primary key on [Servis_Id_Servi], [Profesiones_Id_Profesion] in table 'ServisProfesiones'
ALTER TABLE [dbo].[ServisProfesiones]
ADD CONSTRAINT [PK_ServisProfesiones]
    PRIMARY KEY CLUSTERED ([Servis_Id_Servi], [Profesiones_Id_Profesion] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Solicitudes_Id_Ssolisitud] in table 'Presupuestos'
ALTER TABLE [dbo].[Presupuestos]
ADD CONSTRAINT [FK_SolicitudesPresupuestos]
    FOREIGN KEY ([Solicitudes_Id_Ssolisitud])
    REFERENCES [dbo].[Solicitudes]
        ([Id_Ssolisitud])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SolicitudesPresupuestos'
CREATE INDEX [IX_FK_SolicitudesPresupuestos]
ON [dbo].[Presupuestos]
    ([Solicitudes_Id_Ssolisitud]);
GO

-- Creating foreign key on [Usuarios_Id_Usuario] in table 'Solicitudes'
ALTER TABLE [dbo].[Solicitudes]
ADD CONSTRAINT [FK_UsuariosSolicitudes]
    FOREIGN KEY ([Usuarios_Id_Usuario])
    REFERENCES [dbo].[Usuarios]
        ([Id_Usuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuariosSolicitudes'
CREATE INDEX [IX_FK_UsuariosSolicitudes]
ON [dbo].[Solicitudes]
    ([Usuarios_Id_Usuario]);
GO

-- Creating foreign key on [Servis_Id_Servi] in table 'ServisProfesiones'
ALTER TABLE [dbo].[ServisProfesiones]
ADD CONSTRAINT [FK_ServisProfesiones_Servis]
    FOREIGN KEY ([Servis_Id_Servi])
    REFERENCES [dbo].[Servis]
        ([Id_Servi])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Profesiones_Id_Profesion] in table 'ServisProfesiones'
ALTER TABLE [dbo].[ServisProfesiones]
ADD CONSTRAINT [FK_ServisProfesiones_Profesiones]
    FOREIGN KEY ([Profesiones_Id_Profesion])
    REFERENCES [dbo].[Profesiones]
        ([Id_Profesion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServisProfesiones_Profesiones'
CREATE INDEX [IX_FK_ServisProfesiones_Profesiones]
ON [dbo].[ServisProfesiones]
    ([Profesiones_Id_Profesion]);
GO

-- Creating foreign key on [Profesiones_Id_Profesion] in table 'Tareas'
ALTER TABLE [dbo].[Tareas]
ADD CONSTRAINT [FK_ProfesionesTareas]
    FOREIGN KEY ([Profesiones_Id_Profesion])
    REFERENCES [dbo].[Profesiones]
        ([Id_Profesion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfesionesTareas'
CREATE INDEX [IX_FK_ProfesionesTareas]
ON [dbo].[Tareas]
    ([Profesiones_Id_Profesion]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------