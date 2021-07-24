
create database [SNEAKERSHOP]

-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SNEAKERSHOP];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BINHLUAN_SANPHAM]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BINHLUAN] DROP CONSTRAINT [FK_BINHLUAN_SANPHAM];
GO
IF OBJECT_ID(N'[dbo].[FK_CTDH_DATHANG]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_DATHANG] DROP CONSTRAINT [FK_CTDH_DATHANG];
GO
IF OBJECT_ID(N'[dbo].[FK_CTDH_SANPHAM]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_DATHANG] DROP CONSTRAINT [FK_CTDH_SANPHAM];
GO
IF OBJECT_ID(N'[dbo].[FK_DINHLUAN_USERS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BINHLUAN] DROP CONSTRAINT [FK_DINHLUAN_USERS];
GO
IF OBJECT_ID(N'[dbo].[FK_Product_CATALOGY]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SANPHAM] DROP CONSTRAINT [FK_Product_CATALOGY];
GO
IF OBJECT_ID(N'[dbo].[FK_Product_NHASX]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SANPHAM] DROP CONSTRAINT [FK_Product_NHASX];
GO
IF OBJECT_ID(N'[dbo].[FK_Product_SIZE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SANPHAM] DROP CONSTRAINT [FK_Product_SIZE];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BINHLUAN]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BINHLUAN];
GO
IF OBJECT_ID(N'[dbo].[CATALOGY]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CATALOGY];
GO
IF OBJECT_ID(N'[dbo].[CT_DATHANG]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CT_DATHANG];
GO
IF OBJECT_ID(N'[dbo].[DATHANG]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DATHANG];
GO
IF OBJECT_ID(N'[dbo].[GIOITHIEU]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GIOITHIEU];
GO
IF OBJECT_ID(N'[dbo].[LIEN_HE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LIEN_HE];
GO
IF OBJECT_ID(N'[dbo].[MANAGER]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MANAGER];
GO
IF OBJECT_ID(N'[dbo].[NHASX]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NHASX];
GO
IF OBJECT_ID(N'[dbo].[PHANHOI_GOPY]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PHANHOI_GOPY];
GO
IF OBJECT_ID(N'[dbo].[QUANGCAO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QUANGCAO];
GO
IF OBJECT_ID(N'[dbo].[SANPHAM]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SANPHAM];
GO
IF OBJECT_ID(N'[dbo].[SEO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SEO];
GO
IF OBJECT_ID(N'[dbo].[SIZE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIZE];
GO
IF OBJECT_ID(N'[dbo].[SLIDEPHOTO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SLIDEPHOTO];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TINTUC]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TINTUC];
GO
IF OBJECT_ID(N'[dbo].[USERS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USERS];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BINHLUAN'
CREATE TABLE [dbo].[BINHLUAN] (
    [ID_BINHLUAN] int IDENTITY(1,1) NOT NULL,
    [ID_USER] int  NOT NULL,
    [ID_SANPHAM] int  NOT NULL,
    [NGAY] datetime  NOT NULL,
    [NOIDUNG] nvarchar(max)  NULL
);
GO

-- Creating table 'CATALOGY'
CREATE TABLE [dbo].[CATALOGY] (
    [ID_CATALOGY] int IDENTITY(1,1) NOT NULL,
    [NAME] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MANAGER'
CREATE TABLE [dbo].[MANAGER] (
    [ID_MANAGER] int IDENTITY(1,1) NOT NULL,
    [LOGINNAME] nvarchar(50)  NOT NULL,
    [PASS] nvarchar(255)  NOT NULL,
    [USERNAME] nvarchar(255)  NOT NULL,
    [IMAGE1] nvarchar(max)  NULL,
    [EMAIL] nvarchar(255)  NOT NULL,
    [ISACTIVE] bit  NULL,
    [ISADMIN] bit  NULL
);
GO

-- Creating table 'NHASX'
CREATE TABLE [dbo].[NHASX] (
    [ID_NHASX] int IDENTITY(1,1) NOT NULL,
    [NAME] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'QUANGCAO'
CREATE TABLE [dbo].[QUANGCAO] (
    [ID_QC] int IDENTITY(1,1) NOT NULL,
    [TIEUDE] nvarchar(200)  NULL,
    [LINKIMAGES] nvarchar(max)  NULL,
    [NGAY] datetime  NOT NULL,
    [ThuTu] int  NOT NULL,
    [LienKet] nvarchar(max)  NULL
);
GO

-- Creating table 'SANPHAM'
CREATE TABLE [dbo].[SANPHAM] (
    [ID_SANPHAM] int IDENTITY(1,1) NOT NULL,
    [ID_CATALOGY] int  NOT NULL,
    [ID_NHASX] int  NOT NULL,
    [TENSP] nvarchar(100)  NULL,
    [ID_SIZE] int  NOT NULL,
    [GIA] decimal(18,0)  NOT NULL,
    [SALE] decimal(18,0)  NOT NULL,
    [MAUSAC] nvarchar(150)  NULL,
    [MOTA] nvarchar(max)  NULL,
    [IMAGE1] nvarchar(max)  NULL,
    [IMAGE2] nvarchar(max)  NULL,
    [IMAGE3] nvarchar(max)  NULL,
    [IMAGE4] nvarchar(max)  NULL,
    [SOLUONG] int  NOT NULL,
    [NGAY] datetime  NOT NULL,
    [TAGS] nvarchar(max)  NULL
);
GO

-- Creating table 'SEO'
CREATE TABLE [dbo].[SEO] (
    [ID_SEO] int IDENTITY(1,1) NOT NULL,
    [TITLES] nvarchar(200)  NULL,
    [DESCRIPTIONS] nvarchar(max)  NULL,
    [KEYWORDS] datetime  NOT NULL
);
GO

-- Creating table 'SIZE'
CREATE TABLE [dbo].[SIZE] (
    [ID_SIZE] int IDENTITY(1,1) NOT NULL,
    [SIZE1] nvarchar(5)  NULL,
    [NAME] nvarchar(max)  NULL
);
GO

-- Creating table 'SLIDEPHOTO'
CREATE TABLE [dbo].[SLIDEPHOTO] (
    [ID_SLIDE] int IDENTITY(1,1) NOT NULL,
    [TIEUDE] nvarchar(200)  NULL,
    [LINKIMAGES] nvarchar(200)  NULL,
    [LienKet] nvarchar(200)  NULL,
    [MOTA] nvarchar(max)  NULL
);
GO

-- Creating table 'USERS'
CREATE TABLE [dbo].[USERS] (
    [ID_USER] int IDENTITY(1,1) NOT NULL,
    [LOGINNAME] varchar(50)  NOT NULL,
    [PASS] nvarchar(255)  NOT NULL,
    [USERNAME] nvarchar(255)  NOT NULL,
    [DT] nvarchar(11)  NOT NULL,
    [DIACHI] nvarchar(max)  NOT NULL,
    [EMAIL] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'GIOITHIEU'
CREATE TABLE [dbo].[GIOITHIEU] (
    [ID_GT] int IDENTITY(1,1) NOT NULL,
    [TIEUDE] nvarchar(200)  NOT NULL,
    [NOIDUNG] nvarchar(max)  NULL
);
GO

-- Creating table 'LIEN_HE'
CREATE TABLE [dbo].[LIEN_HE] (
    [ID_LH] int IDENTITY(1,1) NOT NULL,
    [INFO_1] nvarchar(max)  NULL,
    [INFO_2] nvarchar(max)  NULL,
    [INFO_3] nvarchar(max)  NULL,
    [OURADDRESS] varchar(100)  NOT NULL,
    [EMAIL] varchar(100)  NOT NULL,
    [PHONE1] nvarchar(11)  NOT NULL,
    [PHONE2] nvarchar(11)  NOT NULL
);
GO

-- Creating table 'PHANHOI_GOPY'
CREATE TABLE [dbo].[PHANHOI_GOPY] (
    [ID_PH_GOPY] int IDENTITY(1,1) NOT NULL,
    [NAME] nvarchar(200)  NULL,
    [EMAIL] nvarchar(100)  NULL,
    [WEBSITE] nvarchar(50)  NOT NULL,
    [NOIDUNG] nvarchar(max)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'TINTUC'
CREATE TABLE [dbo].[TINTUC] (
    [ID_TT] int IDENTITY(1,1) NOT NULL,
    [TIEUDE] nvarchar(200)  NOT NULL,
    [IMAGES] nvarchar(200)  NULL,
    [NOIDUNGTOMTAT] nvarchar(200)  NULL,
    [NOIDUNG] nvarchar(max)  NULL
);
GO

-- Creating table 'CT_DATHANG'
CREATE TABLE [dbo].[CT_DATHANG] (
    [ID_CTDH] int IDENTITY(1,1) NOT NULL,
    [ID_ODER] int  NOT NULL,
    [ID_SANPHAM] int  NOT NULL,
    [SOLUONG] int  NOT NULL
);
GO

-- Creating table 'DATHANG'
CREATE TABLE [dbo].[DATHANG] (
    [ID_ODER] int IDENTITY(1,1) NOT NULL,
    [USRERNAME] nvarchar(50)  NOT NULL,
    [ADDRESS] nvarchar(100)  NOT NULL,
    [PHONE] nvarchar(11)  NOT NULL,
    [EMAIL] nvarchar(100)  NULL,
    [ISACTIVE] bit  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID_BINHLUAN] in table 'BINHLUAN'
ALTER TABLE [dbo].[BINHLUAN]
ADD CONSTRAINT [PK_BINHLUAN]
    PRIMARY KEY CLUSTERED ([ID_BINHLUAN] ASC);
GO

-- Creating primary key on [ID_CATALOGY] in table 'CATALOGY'
ALTER TABLE [dbo].[CATALOGY]
ADD CONSTRAINT [PK_CATALOGY]
    PRIMARY KEY CLUSTERED ([ID_CATALOGY] ASC);
GO

-- Creating primary key on [ID_MANAGER] in table 'MANAGER'
ALTER TABLE [dbo].[MANAGER]
ADD CONSTRAINT [PK_MANAGER]
    PRIMARY KEY CLUSTERED ([ID_MANAGER] ASC);
GO

-- Creating primary key on [ID_NHASX] in table 'NHASX'
ALTER TABLE [dbo].[NHASX]
ADD CONSTRAINT [PK_NHASX]
    PRIMARY KEY CLUSTERED ([ID_NHASX] ASC);
GO

-- Creating primary key on [ID_QC] in table 'QUANGCAO'
ALTER TABLE [dbo].[QUANGCAO]
ADD CONSTRAINT [PK_QUANGCAO]
    PRIMARY KEY CLUSTERED ([ID_QC] ASC);
GO

-- Creating primary key on [ID_SANPHAM] in table 'SANPHAM'
ALTER TABLE [dbo].[SANPHAM]
ADD CONSTRAINT [PK_SANPHAM]
    PRIMARY KEY CLUSTERED ([ID_SANPHAM] ASC);
GO

-- Creating primary key on [ID_SEO] in table 'SEO'
ALTER TABLE [dbo].[SEO]
ADD CONSTRAINT [PK_SEO]
    PRIMARY KEY CLUSTERED ([ID_SEO] ASC);
GO

-- Creating primary key on [ID_SIZE] in table 'SIZE'
ALTER TABLE [dbo].[SIZE]
ADD CONSTRAINT [PK_SIZE]
    PRIMARY KEY CLUSTERED ([ID_SIZE] ASC);
GO

-- Creating primary key on [ID_SLIDE] in table 'SLIDEPHOTO'
ALTER TABLE [dbo].[SLIDEPHOTO]
ADD CONSTRAINT [PK_SLIDEPHOTO]
    PRIMARY KEY CLUSTERED ([ID_SLIDE] ASC);
GO

-- Creating primary key on [ID_USER] in table 'USERS'
ALTER TABLE [dbo].[USERS]
ADD CONSTRAINT [PK_USERS]
    PRIMARY KEY CLUSTERED ([ID_USER] ASC);
GO

-- Creating primary key on [ID_GT] in table 'GIOITHIEU'
ALTER TABLE [dbo].[GIOITHIEU]
ADD CONSTRAINT [PK_GIOITHIEU]
    PRIMARY KEY CLUSTERED ([ID_GT] ASC);
GO

-- Creating primary key on [ID_LH] in table 'LIEN_HE'
ALTER TABLE [dbo].[LIEN_HE]
ADD CONSTRAINT [PK_LIEN_HE]
    PRIMARY KEY CLUSTERED ([ID_LH] ASC);
GO

-- Creating primary key on [ID_PH_GOPY] in table 'PHANHOI_GOPY'
ALTER TABLE [dbo].[PHANHOI_GOPY]
ADD CONSTRAINT [PK_PHANHOI_GOPY]
    PRIMARY KEY CLUSTERED ([ID_PH_GOPY] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [ID_TT] in table 'TINTUC'
ALTER TABLE [dbo].[TINTUC]
ADD CONSTRAINT [PK_TINTUC]
    PRIMARY KEY CLUSTERED ([ID_TT] ASC);
GO

-- Creating primary key on [ID_CTDH] in table 'CT_DATHANG'
ALTER TABLE [dbo].[CT_DATHANG]
ADD CONSTRAINT [PK_CT_DATHANG]
    PRIMARY KEY CLUSTERED ([ID_CTDH] ASC);
GO

-- Creating primary key on [ID_ODER] in table 'DATHANG'
ALTER TABLE [dbo].[DATHANG]
ADD CONSTRAINT [PK_DATHANG]
    PRIMARY KEY CLUSTERED ([ID_ODER] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ID_SANPHAM] in table 'BINHLUAN'
ALTER TABLE [dbo].[BINHLUAN]
ADD CONSTRAINT [FK_BINHLUAN_SANPHAM]
    FOREIGN KEY ([ID_SANPHAM])
    REFERENCES [dbo].[SANPHAM]
        ([ID_SANPHAM])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BINHLUAN_SANPHAM'
CREATE INDEX [IX_FK_BINHLUAN_SANPHAM]
ON [dbo].[BINHLUAN]
    ([ID_SANPHAM]);
GO

-- Creating foreign key on [ID_USER] in table 'BINHLUAN'
ALTER TABLE [dbo].[BINHLUAN]
ADD CONSTRAINT [FK_DINHLUAN_USERS]
    FOREIGN KEY ([ID_USER])
    REFERENCES [dbo].[USERS]
        ([ID_USER])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DINHLUAN_USERS'
CREATE INDEX [IX_FK_DINHLUAN_USERS]
ON [dbo].[BINHLUAN]
    ([ID_USER]);
GO

-- Creating foreign key on [ID_CATALOGY] in table 'SANPHAM'
ALTER TABLE [dbo].[SANPHAM]
ADD CONSTRAINT [FK_Product_CATALOGY]
    FOREIGN KEY ([ID_CATALOGY])
    REFERENCES [dbo].[CATALOGY]
        ([ID_CATALOGY])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Product_CATALOGY'
CREATE INDEX [IX_FK_Product_CATALOGY]
ON [dbo].[SANPHAM]
    ([ID_CATALOGY]);
GO

-- Creating foreign key on [ID_NHASX] in table 'SANPHAM'
ALTER TABLE [dbo].[SANPHAM]
ADD CONSTRAINT [FK_Product_NHASX]
    FOREIGN KEY ([ID_NHASX])
    REFERENCES [dbo].[NHASX]
        ([ID_NHASX])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Product_NHASX'
CREATE INDEX [IX_FK_Product_NHASX]
ON [dbo].[SANPHAM]
    ([ID_NHASX]);
GO

-- Creating foreign key on [ID_SIZE] in table 'SANPHAM'
ALTER TABLE [dbo].[SANPHAM]
ADD CONSTRAINT [FK_Product_SIZE]
    FOREIGN KEY ([ID_SIZE])
    REFERENCES [dbo].[SIZE]
        ([ID_SIZE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Product_SIZE'
CREATE INDEX [IX_FK_Product_SIZE]
ON [dbo].[SANPHAM]
    ([ID_SIZE]);
GO

-- Creating foreign key on [ID_ODER] in table 'CT_DATHANG'
ALTER TABLE [dbo].[CT_DATHANG]
ADD CONSTRAINT [FK_CTDH_DATHANG]
    FOREIGN KEY ([ID_ODER])
    REFERENCES [dbo].[DATHANG]
        ([ID_ODER])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CTDH_DATHANG'
CREATE INDEX [IX_FK_CTDH_DATHANG]
ON [dbo].[CT_DATHANG]
    ([ID_ODER]);
GO

-- Creating foreign key on [ID_SANPHAM] in table 'CT_DATHANG'
ALTER TABLE [dbo].[CT_DATHANG]
ADD CONSTRAINT [FK_CTDH_SANPHAM]
    FOREIGN KEY ([ID_SANPHAM])
    REFERENCES [dbo].[SANPHAM]
        ([ID_SANPHAM])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CTDH_SANPHAM'
CREATE INDEX [IX_FK_CTDH_SANPHAM]
ON [dbo].[CT_DATHANG]
    ([ID_SANPHAM]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------