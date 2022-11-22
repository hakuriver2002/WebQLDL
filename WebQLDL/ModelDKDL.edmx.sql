
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/04/2022 23:39:26
-- Generated from EDMX file: E:\WorkSpace\Winform\WebQLDL\WebQLDL\ModelDKDL.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [QLDKDULICH];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_tChiTietTuyenDuLich_MaChuyen]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tChiTietTuyenDuLich] DROP CONSTRAINT [FK_tChiTietTuyenDuLich_MaChuyen];
GO
IF OBJECT_ID(N'[dbo].[FK_tChiTietTuyenDuLich_MaDD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tChiTietTuyenDuLich] DROP CONSTRAINT [FK_tChiTietTuyenDuLich_MaDD];
GO
IF OBJECT_ID(N'[dbo].[FK_tChuyenDuLich_MaTuyen]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tChuyenDuLich] DROP CONSTRAINT [FK_tChuyenDuLich_MaTuyen];
GO
IF OBJECT_ID(N'[dbo].[FK_tDangKy_MaChuyen]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tDangKy] DROP CONSTRAINT [FK_tDangKy_MaChuyen];
GO
IF OBJECT_ID(N'[dbo].[FK_tDangKy_MaKhach]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tDangKy] DROP CONSTRAINT [FK_tDangKy_MaKhach];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tChiTietTuyenDuLich]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tChiTietTuyenDuLich];
GO
IF OBJECT_ID(N'[dbo].[tChuyenDuLich]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tChuyenDuLich];
GO
IF OBJECT_ID(N'[dbo].[tDangKy]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tDangKy];
GO
IF OBJECT_ID(N'[dbo].[tDiaDiemThamQuan]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tDiaDiemThamQuan];
GO
IF OBJECT_ID(N'[dbo].[tKhach]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tKhach];
GO
IF OBJECT_ID(N'[dbo].[tTuyen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tTuyen];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tChuyenDuLich'
CREATE TABLE [dbo].[tChuyenDuLich] (
    [MaChuyen] varchar(10)  NOT NULL,
    [MaTuyen] varchar(10)  NOT NULL,
    [PhuongTien] nvarchar(10)  NULL,
    [TenHDVien] nvarchar(50)  NULL,
    [DonGia] float  NULL
);
GO

-- Creating table 'tDangKy'
CREATE TABLE [dbo].[tDangKy] (
    [MaChuyen] varchar(10)  NOT NULL,
    [MaKhach] varchar(10)  NOT NULL,
    [NgayDKy] datetime  NULL,
    [STDTra] float  NULL
);
GO

-- Creating table 'tDiaDiemThamQuan'
CREATE TABLE [dbo].[tDiaDiemThamQuan] (
    [MaDD] varchar(10)  NOT NULL,
    [TenDD] nvarchar(50)  NULL,
    [TenTinhThanh] nvarchar(30)  NULL
);
GO

-- Creating table 'tKhach'
CREATE TABLE [dbo].[tKhach] (
    [MaKhach] varchar(10)  NOT NULL,
    [TenKhach] nvarchar(50)  NULL,
    [DienThoai] varchar(10)  NULL,
    [DiaChi] nvarchar(100)  NULL
);
GO

-- Creating table 'tTuyen'
CREATE TABLE [dbo].[tTuyen] (
    [MaTuyen] varchar(10)  NOT NULL,
    [TenTuyen] nvarchar(50)  NULL,
    [SoNgay] int  NULL,
    [GhiChu] nvarchar(100)  NULL
);
GO

-- Creating table 'tChiTietTuyenDuLich'
CREATE TABLE [dbo].[tChiTietTuyenDuLich] (
    [tChuyenDuLich_MaChuyen] varchar(10)  NOT NULL,
    [tDiaDiemThamQuan_MaDD] varchar(10)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MaChuyen] in table 'tChuyenDuLich'
ALTER TABLE [dbo].[tChuyenDuLich]
ADD CONSTRAINT [PK_tChuyenDuLich]
    PRIMARY KEY CLUSTERED ([MaChuyen] ASC);
GO

-- Creating primary key on [MaChuyen], [MaKhach] in table 'tDangKy'
ALTER TABLE [dbo].[tDangKy]
ADD CONSTRAINT [PK_tDangKy]
    PRIMARY KEY CLUSTERED ([MaChuyen], [MaKhach] ASC);
GO

-- Creating primary key on [MaDD] in table 'tDiaDiemThamQuan'
ALTER TABLE [dbo].[tDiaDiemThamQuan]
ADD CONSTRAINT [PK_tDiaDiemThamQuan]
    PRIMARY KEY CLUSTERED ([MaDD] ASC);
GO

-- Creating primary key on [MaKhach] in table 'tKhach'
ALTER TABLE [dbo].[tKhach]
ADD CONSTRAINT [PK_tKhach]
    PRIMARY KEY CLUSTERED ([MaKhach] ASC);
GO

-- Creating primary key on [MaTuyen] in table 'tTuyen'
ALTER TABLE [dbo].[tTuyen]
ADD CONSTRAINT [PK_tTuyen]
    PRIMARY KEY CLUSTERED ([MaTuyen] ASC);
GO

-- Creating primary key on [tChuyenDuLich_MaChuyen], [tDiaDiemThamQuan_MaDD] in table 'tChiTietTuyenDuLich'
ALTER TABLE [dbo].[tChiTietTuyenDuLich]
ADD CONSTRAINT [PK_tChiTietTuyenDuLich]
    PRIMARY KEY CLUSTERED ([tChuyenDuLich_MaChuyen], [tDiaDiemThamQuan_MaDD] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MaTuyen] in table 'tChuyenDuLich'
ALTER TABLE [dbo].[tChuyenDuLich]
ADD CONSTRAINT [FK_tChuyenDuLich_MaTuyen]
    FOREIGN KEY ([MaTuyen])
    REFERENCES [dbo].[tTuyen]
        ([MaTuyen])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tChuyenDuLich_MaTuyen'
CREATE INDEX [IX_FK_tChuyenDuLich_MaTuyen]
ON [dbo].[tChuyenDuLich]
    ([MaTuyen]);
GO

-- Creating foreign key on [MaChuyen] in table 'tDangKy'
ALTER TABLE [dbo].[tDangKy]
ADD CONSTRAINT [FK_tDangKy_MaChuyen]
    FOREIGN KEY ([MaChuyen])
    REFERENCES [dbo].[tChuyenDuLich]
        ([MaChuyen])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MaKhach] in table 'tDangKy'
ALTER TABLE [dbo].[tDangKy]
ADD CONSTRAINT [FK_tDangKy_MaKhach]
    FOREIGN KEY ([MaKhach])
    REFERENCES [dbo].[tKhach]
        ([MaKhach])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tDangKy_MaKhach'
CREATE INDEX [IX_FK_tDangKy_MaKhach]
ON [dbo].[tDangKy]
    ([MaKhach]);
GO

-- Creating foreign key on [tChuyenDuLich_MaChuyen] in table 'tChiTietTuyenDuLich'
ALTER TABLE [dbo].[tChiTietTuyenDuLich]
ADD CONSTRAINT [FK_tChiTietTuyenDuLich_tChuyenDuLich]
    FOREIGN KEY ([tChuyenDuLich_MaChuyen])
    REFERENCES [dbo].[tChuyenDuLich]
        ([MaChuyen])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [tDiaDiemThamQuan_MaDD] in table 'tChiTietTuyenDuLich'
ALTER TABLE [dbo].[tChiTietTuyenDuLich]
ADD CONSTRAINT [FK_tChiTietTuyenDuLich_tDiaDiemThamQuan]
    FOREIGN KEY ([tDiaDiemThamQuan_MaDD])
    REFERENCES [dbo].[tDiaDiemThamQuan]
        ([MaDD])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tChiTietTuyenDuLich_tDiaDiemThamQuan'
CREATE INDEX [IX_FK_tChiTietTuyenDuLich_tDiaDiemThamQuan]
ON [dbo].[tChiTietTuyenDuLich]
    ([tDiaDiemThamQuan_MaDD]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------