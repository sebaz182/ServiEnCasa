
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/17/2016 17:16:49
-- Generated from EDMX file: C:\Users\Sebastian\Google Drive\Facultad\5to\SAP TFI\2 - Desarrollo\00 - Código\ServiEnCasa_v01\ServiEnCasa\ServiEnCasa_v01\Models\Modelo.edmx
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

IF OBJECT_ID(N'[dbo].[FK_ServisProfesiones_Profesiones]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServisProfesiones] DROP CONSTRAINT [FK_ServisProfesiones_Profesiones];
GO
IF OBJECT_ID(N'[dbo].[FK_ServisProfesiones_Servis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServisProfesiones] DROP CONSTRAINT [FK_ServisProfesiones_Servis];
GO
IF OBJECT_ID(N'[dbo].[FK_ServisPresupuestos_Servis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServisPresupuestos] DROP CONSTRAINT [FK_ServisPresupuestos_Servis];
GO
IF OBJECT_ID(N'[dbo].[FK_ServisPresupuestos_Presupuestos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServisPresupuestos] DROP CONSTRAINT [FK_ServisPresupuestos_Presupuestos];
GO
IF OBJECT_ID(N'[dbo].[FK_TareasSolicitudes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Solicitudes] DROP CONSTRAINT [FK_TareasSolicitudes];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfesionesSolicitudes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Solicitudes] DROP CONSTRAINT [FK_ProfesionesSolicitudes];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuariosPerfiles_Usuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuariosPerfiles] DROP CONSTRAINT [FK_UsuariosPerfiles_Usuarios];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuariosPerfiles_Perfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuariosPerfiles] DROP CONSTRAINT [FK_UsuariosPerfiles_Perfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_AdministradoresPerfiles_Administradores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AdministradoresPerfiles] DROP CONSTRAINT [FK_AdministradoresPerfiles_Administradores];
GO
IF OBJECT_ID(N'[dbo].[FK_AdministradoresPerfiles_Perfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AdministradoresPerfiles] DROP CONSTRAINT [FK_AdministradoresPerfiles_Perfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_ServisPerfiles_Servis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServisPerfiles] DROP CONSTRAINT [FK_ServisPerfiles_Servis];
GO
IF OBJECT_ID(N'[dbo].[FK_ServisPerfiles_Perfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServisPerfiles] DROP CONSTRAINT [FK_ServisPerfiles_Perfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_TareasServis_Tareas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TareasServis] DROP CONSTRAINT [FK_TareasServis_Tareas];
GO
IF OBJECT_ID(N'[dbo].[FK_TareasServis_Servis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TareasServis] DROP CONSTRAINT [FK_TareasServis_Servis];
GO
IF OBJECT_ID(N'[dbo].[FK_SolicitudesPresupuestos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Presupuestos] DROP CONSTRAINT [FK_SolicitudesPresupuestos];
GO
IF OBJECT_ID(N'[dbo].[FK_ZonasSolicitudes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Solicitudes] DROP CONSTRAINT [FK_ZonasSolicitudes];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuariosSolicitudes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Solicitudes] DROP CONSTRAINT [FK_UsuariosSolicitudes];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfesionesTareas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tareas] DROP CONSTRAINT [FK_ProfesionesTareas];
GO
IF OBJECT_ID(N'[dbo].[FK_HorariosSolicitudes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Solicitudes] DROP CONSTRAINT [FK_HorariosSolicitudes];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Presupuestos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Presupuestos];
GO
IF OBJECT_ID(N'[dbo].[Profesiones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Profesiones];
GO
IF OBJECT_ID(N'[dbo].[Servis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Servis];
GO
IF OBJECT_ID(N'[dbo].[Solicitudes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Solicitudes];
GO
IF OBJECT_ID(N'[dbo].[Tareas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tareas];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO
IF OBJECT_ID(N'[dbo].[Administradores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Administradores];
GO
IF OBJECT_ID(N'[dbo].[Perfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Perfiles];
GO
IF OBJECT_ID(N'[dbo].[Zonas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zonas];
GO
IF OBJECT_ID(N'[dbo].[Horarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Horarios];
GO
IF OBJECT_ID(N'[dbo].[ServisProfesiones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServisProfesiones];
GO
IF OBJECT_ID(N'[dbo].[ServisPresupuestos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServisPresupuestos];
GO
IF OBJECT_ID(N'[dbo].[UsuariosPerfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuariosPerfiles];
GO
IF OBJECT_ID(N'[dbo].[AdministradoresPerfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AdministradoresPerfiles];
GO
IF OBJECT_ID(N'[dbo].[ServisPerfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServisPerfiles];
GO
IF OBJECT_ID(N'[dbo].[TareasServis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TareasServis];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Presupuestos'
CREATE TABLE [dbo].[Presupuestos] (
    [Id_Presupuesto] int IDENTITY(1,1) NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Fecha_Vencimiento] datetime  NOT NULL,
    [Precio] decimal(18,0)  NOT NULL,
    [Observacion] nvarchar(max)  NOT NULL,
    [Solicitudes_Id_Solicitud] int  NOT NULL
);
GO

-- Creating table 'Profesiones'
CREATE TABLE [dbo].[Profesiones] (
    [Id_Profesion] int IDENTITY(1,1) NOT NULL,
    [Desc_Profesion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Servis'
CREATE TABLE [dbo].[Servis] (
    [Id_Servi] int IDENTITY(1,1) NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [DNI] nvarchar(max)  NOT NULL,
    [Matricula] nvarchar(max)  NOT NULL,
    [Pass] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL,
    [Foto] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Solicitudes'
CREATE TABLE [dbo].[Solicitudes] (
    [Id_Solicitud] int IDENTITY(1,1) NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Contador] int  NOT NULL,
    [Foto] nvarchar(max)  NULL,
    [Fecha] datetime  NOT NULL,
    [Desc_Solicitud] nvarchar(max)  NOT NULL,
    [Tareas_Id_Tarea] int  NOT NULL,
    [Profesiones_Id_Profesion] int  NOT NULL,
    [Zonas_Id_Zona] int  NOT NULL,
    [Usuarios_Id_Usuario] int  NOT NULL,
    [Horarios_Id_Horario] int  NOT NULL
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

-- Creating table 'Administradores'
CREATE TABLE [dbo].[Administradores] (
    [Id_Administrador] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL,
    [Pass] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Perfiles'
CREATE TABLE [dbo].[Perfiles] (
    [Id_Perfil] int IDENTITY(1,1) NOT NULL,
    [Perfil] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'Zonas'
CREATE TABLE [dbo].[Zonas] (
    [Id_Zona] int IDENTITY(1,1) NOT NULL,
    [Zona] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Horarios'
CREATE TABLE [dbo].[Horarios] (
    [Id_Horario] int IDENTITY(1,1) NOT NULL,
    [Horario] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ServisProfesiones'
CREATE TABLE [dbo].[ServisProfesiones] (
    [Profesiones_Id_Profesion] int  NOT NULL,
    [Servis_Id_Servi] int  NOT NULL
);
GO

-- Creating table 'ServisPresupuestos'
CREATE TABLE [dbo].[ServisPresupuestos] (
    [Servis_Id_Servi] int  NOT NULL,
    [Presupuestos_Id_Presupuesto] int  NOT NULL
);
GO

-- Creating table 'UsuariosPerfiles'
CREATE TABLE [dbo].[UsuariosPerfiles] (
    [Usuarios_Id_Usuario] int  NOT NULL,
    [Perfiles_Id_Perfil] int  NOT NULL
);
GO

-- Creating table 'AdministradoresPerfiles'
CREATE TABLE [dbo].[AdministradoresPerfiles] (
    [Administradores_Id_Administrador] int  NOT NULL,
    [Perfiles_Id_Perfil] int  NOT NULL
);
GO

-- Creating table 'ServisPerfiles'
CREATE TABLE [dbo].[ServisPerfiles] (
    [Servis_Id_Servi] int  NOT NULL,
    [Perfiles_Id_Perfil] int  NOT NULL
);
GO

-- Creating table 'TareasServis'
CREATE TABLE [dbo].[TareasServis] (
    [Tareas_Id_Tarea] int  NOT NULL,
    [Servis_Id_Servi] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_Presupuesto] in table 'Presupuestos'
ALTER TABLE [dbo].[Presupuestos]
ADD CONSTRAINT [PK_Presupuestos]
    PRIMARY KEY CLUSTERED ([Id_Presupuesto] ASC);
GO

-- Creating primary key on [Id_Profesion] in table 'Profesiones'
ALTER TABLE [dbo].[Profesiones]
ADD CONSTRAINT [PK_Profesiones]
    PRIMARY KEY CLUSTERED ([Id_Profesion] ASC);
GO

-- Creating primary key on [Id_Servi] in table 'Servis'
ALTER TABLE [dbo].[Servis]
ADD CONSTRAINT [PK_Servis]
    PRIMARY KEY CLUSTERED ([Id_Servi] ASC);
GO

-- Creating primary key on [Id_Solicitud] in table 'Solicitudes'
ALTER TABLE [dbo].[Solicitudes]
ADD CONSTRAINT [PK_Solicitudes]
    PRIMARY KEY CLUSTERED ([Id_Solicitud] ASC);
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

-- Creating primary key on [Id_Administrador] in table 'Administradores'
ALTER TABLE [dbo].[Administradores]
ADD CONSTRAINT [PK_Administradores]
    PRIMARY KEY CLUSTERED ([Id_Administrador] ASC);
GO

-- Creating primary key on [Id_Perfil] in table 'Perfiles'
ALTER TABLE [dbo].[Perfiles]
ADD CONSTRAINT [PK_Perfiles]
    PRIMARY KEY CLUSTERED ([Id_Perfil] ASC);
GO

-- Creating primary key on [Id_Zona] in table 'Zonas'
ALTER TABLE [dbo].[Zonas]
ADD CONSTRAINT [PK_Zonas]
    PRIMARY KEY CLUSTERED ([Id_Zona] ASC);
GO

-- Creating primary key on [Id_Horario] in table 'Horarios'
ALTER TABLE [dbo].[Horarios]
ADD CONSTRAINT [PK_Horarios]
    PRIMARY KEY CLUSTERED ([Id_Horario] ASC);
GO

-- Creating primary key on [Profesiones_Id_Profesion], [Servis_Id_Servi] in table 'ServisProfesiones'
ALTER TABLE [dbo].[ServisProfesiones]
ADD CONSTRAINT [PK_ServisProfesiones]
    PRIMARY KEY CLUSTERED ([Profesiones_Id_Profesion], [Servis_Id_Servi] ASC);
GO

-- Creating primary key on [Servis_Id_Servi], [Presupuestos_Id_Presupuesto] in table 'ServisPresupuestos'
ALTER TABLE [dbo].[ServisPresupuestos]
ADD CONSTRAINT [PK_ServisPresupuestos]
    PRIMARY KEY CLUSTERED ([Servis_Id_Servi], [Presupuestos_Id_Presupuesto] ASC);
GO

-- Creating primary key on [Usuarios_Id_Usuario], [Perfiles_Id_Perfil] in table 'UsuariosPerfiles'
ALTER TABLE [dbo].[UsuariosPerfiles]
ADD CONSTRAINT [PK_UsuariosPerfiles]
    PRIMARY KEY CLUSTERED ([Usuarios_Id_Usuario], [Perfiles_Id_Perfil] ASC);
GO

-- Creating primary key on [Administradores_Id_Administrador], [Perfiles_Id_Perfil] in table 'AdministradoresPerfiles'
ALTER TABLE [dbo].[AdministradoresPerfiles]
ADD CONSTRAINT [PK_AdministradoresPerfiles]
    PRIMARY KEY CLUSTERED ([Administradores_Id_Administrador], [Perfiles_Id_Perfil] ASC);
GO

-- Creating primary key on [Servis_Id_Servi], [Perfiles_Id_Perfil] in table 'ServisPerfiles'
ALTER TABLE [dbo].[ServisPerfiles]
ADD CONSTRAINT [PK_ServisPerfiles]
    PRIMARY KEY CLUSTERED ([Servis_Id_Servi], [Perfiles_Id_Perfil] ASC);
GO

-- Creating primary key on [Tareas_Id_Tarea], [Servis_Id_Servi] in table 'TareasServis'
ALTER TABLE [dbo].[TareasServis]
ADD CONSTRAINT [PK_TareasServis]
    PRIMARY KEY CLUSTERED ([Tareas_Id_Tarea], [Servis_Id_Servi] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Profesiones_Id_Profesion] in table 'ServisProfesiones'
ALTER TABLE [dbo].[ServisProfesiones]
ADD CONSTRAINT [FK_ServisProfesiones_Profesiones]
    FOREIGN KEY ([Profesiones_Id_Profesion])
    REFERENCES [dbo].[Profesiones]
        ([Id_Profesion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Servis_Id_Servi] in table 'ServisProfesiones'
ALTER TABLE [dbo].[ServisProfesiones]
ADD CONSTRAINT [FK_ServisProfesiones_Servis]
    FOREIGN KEY ([Servis_Id_Servi])
    REFERENCES [dbo].[Servis]
        ([Id_Servi])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServisProfesiones_Servis'
CREATE INDEX [IX_FK_ServisProfesiones_Servis]
ON [dbo].[ServisProfesiones]
    ([Servis_Id_Servi]);
GO

-- Creating foreign key on [Servis_Id_Servi] in table 'ServisPresupuestos'
ALTER TABLE [dbo].[ServisPresupuestos]
ADD CONSTRAINT [FK_ServisPresupuestos_Servis]
    FOREIGN KEY ([Servis_Id_Servi])
    REFERENCES [dbo].[Servis]
        ([Id_Servi])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Presupuestos_Id_Presupuesto] in table 'ServisPresupuestos'
ALTER TABLE [dbo].[ServisPresupuestos]
ADD CONSTRAINT [FK_ServisPresupuestos_Presupuestos]
    FOREIGN KEY ([Presupuestos_Id_Presupuesto])
    REFERENCES [dbo].[Presupuestos]
        ([Id_Presupuesto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServisPresupuestos_Presupuestos'
CREATE INDEX [IX_FK_ServisPresupuestos_Presupuestos]
ON [dbo].[ServisPresupuestos]
    ([Presupuestos_Id_Presupuesto]);
GO

-- Creating foreign key on [Tareas_Id_Tarea] in table 'Solicitudes'
ALTER TABLE [dbo].[Solicitudes]
ADD CONSTRAINT [FK_TareasSolicitudes]
    FOREIGN KEY ([Tareas_Id_Tarea])
    REFERENCES [dbo].[Tareas]
        ([Id_Tarea])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TareasSolicitudes'
CREATE INDEX [IX_FK_TareasSolicitudes]
ON [dbo].[Solicitudes]
    ([Tareas_Id_Tarea]);
GO

-- Creating foreign key on [Profesiones_Id_Profesion] in table 'Solicitudes'
ALTER TABLE [dbo].[Solicitudes]
ADD CONSTRAINT [FK_ProfesionesSolicitudes]
    FOREIGN KEY ([Profesiones_Id_Profesion])
    REFERENCES [dbo].[Profesiones]
        ([Id_Profesion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfesionesSolicitudes'
CREATE INDEX [IX_FK_ProfesionesSolicitudes]
ON [dbo].[Solicitudes]
    ([Profesiones_Id_Profesion]);
GO

-- Creating foreign key on [Usuarios_Id_Usuario] in table 'UsuariosPerfiles'
ALTER TABLE [dbo].[UsuariosPerfiles]
ADD CONSTRAINT [FK_UsuariosPerfiles_Usuarios]
    FOREIGN KEY ([Usuarios_Id_Usuario])
    REFERENCES [dbo].[Usuarios]
        ([Id_Usuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Perfiles_Id_Perfil] in table 'UsuariosPerfiles'
ALTER TABLE [dbo].[UsuariosPerfiles]
ADD CONSTRAINT [FK_UsuariosPerfiles_Perfiles]
    FOREIGN KEY ([Perfiles_Id_Perfil])
    REFERENCES [dbo].[Perfiles]
        ([Id_Perfil])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuariosPerfiles_Perfiles'
CREATE INDEX [IX_FK_UsuariosPerfiles_Perfiles]
ON [dbo].[UsuariosPerfiles]
    ([Perfiles_Id_Perfil]);
GO

-- Creating foreign key on [Administradores_Id_Administrador] in table 'AdministradoresPerfiles'
ALTER TABLE [dbo].[AdministradoresPerfiles]
ADD CONSTRAINT [FK_AdministradoresPerfiles_Administradores]
    FOREIGN KEY ([Administradores_Id_Administrador])
    REFERENCES [dbo].[Administradores]
        ([Id_Administrador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Perfiles_Id_Perfil] in table 'AdministradoresPerfiles'
ALTER TABLE [dbo].[AdministradoresPerfiles]
ADD CONSTRAINT [FK_AdministradoresPerfiles_Perfiles]
    FOREIGN KEY ([Perfiles_Id_Perfil])
    REFERENCES [dbo].[Perfiles]
        ([Id_Perfil])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdministradoresPerfiles_Perfiles'
CREATE INDEX [IX_FK_AdministradoresPerfiles_Perfiles]
ON [dbo].[AdministradoresPerfiles]
    ([Perfiles_Id_Perfil]);
GO

-- Creating foreign key on [Servis_Id_Servi] in table 'ServisPerfiles'
ALTER TABLE [dbo].[ServisPerfiles]
ADD CONSTRAINT [FK_ServisPerfiles_Servis]
    FOREIGN KEY ([Servis_Id_Servi])
    REFERENCES [dbo].[Servis]
        ([Id_Servi])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Perfiles_Id_Perfil] in table 'ServisPerfiles'
ALTER TABLE [dbo].[ServisPerfiles]
ADD CONSTRAINT [FK_ServisPerfiles_Perfiles]
    FOREIGN KEY ([Perfiles_Id_Perfil])
    REFERENCES [dbo].[Perfiles]
        ([Id_Perfil])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServisPerfiles_Perfiles'
CREATE INDEX [IX_FK_ServisPerfiles_Perfiles]
ON [dbo].[ServisPerfiles]
    ([Perfiles_Id_Perfil]);
GO

-- Creating foreign key on [Tareas_Id_Tarea] in table 'TareasServis'
ALTER TABLE [dbo].[TareasServis]
ADD CONSTRAINT [FK_TareasServis_Tareas]
    FOREIGN KEY ([Tareas_Id_Tarea])
    REFERENCES [dbo].[Tareas]
        ([Id_Tarea])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Servis_Id_Servi] in table 'TareasServis'
ALTER TABLE [dbo].[TareasServis]
ADD CONSTRAINT [FK_TareasServis_Servis]
    FOREIGN KEY ([Servis_Id_Servi])
    REFERENCES [dbo].[Servis]
        ([Id_Servi])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TareasServis_Servis'
CREATE INDEX [IX_FK_TareasServis_Servis]
ON [dbo].[TareasServis]
    ([Servis_Id_Servi]);
GO

-- Creating foreign key on [Solicitudes_Id_Solicitud] in table 'Presupuestos'
ALTER TABLE [dbo].[Presupuestos]
ADD CONSTRAINT [FK_SolicitudesPresupuestos]
    FOREIGN KEY ([Solicitudes_Id_Solicitud])
    REFERENCES [dbo].[Solicitudes]
        ([Id_Solicitud])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SolicitudesPresupuestos'
CREATE INDEX [IX_FK_SolicitudesPresupuestos]
ON [dbo].[Presupuestos]
    ([Solicitudes_Id_Solicitud]);
GO

-- Creating foreign key on [Zonas_Id_Zona] in table 'Solicitudes'
ALTER TABLE [dbo].[Solicitudes]
ADD CONSTRAINT [FK_ZonasSolicitudes]
    FOREIGN KEY ([Zonas_Id_Zona])
    REFERENCES [dbo].[Zonas]
        ([Id_Zona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZonasSolicitudes'
CREATE INDEX [IX_FK_ZonasSolicitudes]
ON [dbo].[Solicitudes]
    ([Zonas_Id_Zona]);
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

-- Creating foreign key on [Horarios_Id_Horario] in table 'Solicitudes'
ALTER TABLE [dbo].[Solicitudes]
ADD CONSTRAINT [FK_HorariosSolicitudes]
    FOREIGN KEY ([Horarios_Id_Horario])
    REFERENCES [dbo].[Horarios]
        ([Id_Horario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HorariosSolicitudes'
CREATE INDEX [IX_FK_HorariosSolicitudes]
ON [dbo].[Solicitudes]
    ([Horarios_Id_Horario]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------