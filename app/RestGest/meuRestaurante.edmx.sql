
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/18/2022 09:09:43
-- Generated from EDMX file: E:\IPL\S2\DA\projeto final\RestGest\meuRestaurante.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RestGest];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MoradaPessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MoradaSet] DROP CONSTRAINT [FK_MoradaPessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_MetodoPagamentoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagamentoSet] DROP CONSTRAINT [FK_MetodoPagamentoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_MoradaRestaurante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MoradaSet] DROP CONSTRAINT [FK_MoradaRestaurante];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteItemMenu_Restaurante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RestauranteItemMenu] DROP CONSTRAINT [FK_RestauranteItemMenu_Restaurante];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteItemMenu_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RestauranteItemMenu] DROP CONSTRAINT [FK_RestauranteItemMenu_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoriaItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuSet] DROP CONSTRAINT [FK_CategoriaItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoEstado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoSet] DROP CONSTRAINT [FK_PedidoEstado];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuPedido_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuPedido] DROP CONSTRAINT [FK_ItemMenuPedido_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuPedido_Pedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuPedido] DROP CONSTRAINT [FK_ItemMenuPedido_Pedido];
GO
IF OBJECT_ID(N'[dbo].[FK_RestaurantePedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoSet] DROP CONSTRAINT [FK_RestaurantePedido];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientePedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoSet] DROP CONSTRAINT [FK_ClientePedido];
GO
IF OBJECT_ID(N'[dbo].[FK_TrabalhadorPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoSet] DROP CONSTRAINT [FK_TrabalhadorPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PagamentoPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagamentoSet] DROP CONSTRAINT [FK_PagamentoPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Trabalhador_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Trabalhador] DROP CONSTRAINT [FK_Trabalhador_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[MoradaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MoradaSet];
GO
IF OBJECT_ID(N'[dbo].[PessoaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet];
GO
IF OBJECT_ID(N'[dbo].[RestauranteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RestauranteSet];
GO
IF OBJECT_ID(N'[dbo].[ItemMenuSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMenuSet];
GO
IF OBJECT_ID(N'[dbo].[CategoriaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategoriaSet];
GO
IF OBJECT_ID(N'[dbo].[PedidoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PedidoSet];
GO
IF OBJECT_ID(N'[dbo].[EstadoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoSet];
GO
IF OBJECT_ID(N'[dbo].[PagamentoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagamentoSet];
GO
IF OBJECT_ID(N'[dbo].[MetodoPagamentoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetodoPagamentoSet];
GO
IF OBJECT_ID(N'[dbo].[PessoaSet_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet_Cliente];
GO
IF OBJECT_ID(N'[dbo].[PessoaSet_Trabalhador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet_Trabalhador];
GO
IF OBJECT_ID(N'[dbo].[RestauranteItemMenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RestauranteItemMenu];
GO
IF OBJECT_ID(N'[dbo].[ItemMenuPedido]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMenuPedido];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MoradaSet'
CREATE TABLE [dbo].[MoradaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL,
    [Pessoa_Id] int  NOT NULL,
    [Restaurante_Id] int  NOT NULL
);
GO

-- Creating table 'PessoaSet'
CREATE TABLE [dbo].[PessoaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [IdMorada] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RestauranteSet'
CREATE TABLE [dbo].[RestauranteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [IdMorada] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ItemMenuSet'
CREATE TABLE [dbo].[ItemMenuSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Fotografia] nvarchar(max)  NOT NULL,
    [Ingredientes] nvarchar(max)  NOT NULL,
    [Preco] nvarchar(max)  NOT NULL,
    [Ativo] nvarchar(max)  NOT NULL,
    [IdCategoria] int  NOT NULL
);
GO

-- Creating table 'CategoriaSet'
CREATE TABLE [dbo].[CategoriaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Ativo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PedidoSet'
CREATE TABLE [dbo].[PedidoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ValorTotal] nvarchar(max)  NOT NULL,
    [IdEstado] int  NOT NULL,
    [IdRestaurante] int  NOT NULL,
    [IdCliente] int  NOT NULL,
    [IdTrabalhador] int  NOT NULL
);
GO

-- Creating table 'EstadoSet'
CREATE TABLE [dbo].[EstadoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EstadoAtual] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PagamentoSet'
CREATE TABLE [dbo].[PagamentoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Valor] nvarchar(max)  NOT NULL,
    [IdMetodoPagamento] int  NOT NULL,
    [IdPedido] int  NOT NULL
);
GO

-- Creating table 'MetodoPagamentoSet'
CREATE TABLE [dbo].[MetodoPagamentoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TipoMetodoPagamento] nvarchar(max)  NOT NULL,
    [Ativo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PessoaSet_Cliente'
CREATE TABLE [dbo].[PessoaSet_Cliente] (
    [TotalGasto] nvarchar(max)  NOT NULL,
    [NumContribuinte] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'PessoaSet_Trabalhador'
CREATE TABLE [dbo].[PessoaSet_Trabalhador] (
    [IdRestaurante] nvarchar(max)  NOT NULL,
    [Salario] nvarchar(max)  NOT NULL,
    [Posicao] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'RestauranteItemMenu'
CREATE TABLE [dbo].[RestauranteItemMenu] (
    [Restaurante_Id] int  NOT NULL,
    [ItemMenu_Id] int  NOT NULL
);
GO

-- Creating table 'ItemMenuPedido'
CREATE TABLE [dbo].[ItemMenuPedido] (
    [ItemMenu_Id] int  NOT NULL,
    [Pedido_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'MoradaSet'
ALTER TABLE [dbo].[MoradaSet]
ADD CONSTRAINT [PK_MoradaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PessoaSet'
ALTER TABLE [dbo].[PessoaSet]
ADD CONSTRAINT [PK_PessoaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RestauranteSet'
ALTER TABLE [dbo].[RestauranteSet]
ADD CONSTRAINT [PK_RestauranteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemMenuSet'
ALTER TABLE [dbo].[ItemMenuSet]
ADD CONSTRAINT [PK_ItemMenuSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CategoriaSet'
ALTER TABLE [dbo].[CategoriaSet]
ADD CONSTRAINT [PK_CategoriaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [PK_PedidoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EstadoSet'
ALTER TABLE [dbo].[EstadoSet]
ADD CONSTRAINT [PK_EstadoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PagamentoSet'
ALTER TABLE [dbo].[PagamentoSet]
ADD CONSTRAINT [PK_PagamentoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MetodoPagamentoSet'
ALTER TABLE [dbo].[MetodoPagamentoSet]
ADD CONSTRAINT [PK_MetodoPagamentoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PessoaSet_Cliente'
ALTER TABLE [dbo].[PessoaSet_Cliente]
ADD CONSTRAINT [PK_PessoaSet_Cliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PessoaSet_Trabalhador'
ALTER TABLE [dbo].[PessoaSet_Trabalhador]
ADD CONSTRAINT [PK_PessoaSet_Trabalhador]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Restaurante_Id], [ItemMenu_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [PK_RestauranteItemMenu]
    PRIMARY KEY CLUSTERED ([Restaurante_Id], [ItemMenu_Id] ASC);
GO

-- Creating primary key on [ItemMenu_Id], [Pedido_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [PK_ItemMenuPedido]
    PRIMARY KEY CLUSTERED ([ItemMenu_Id], [Pedido_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Pessoa_Id] in table 'MoradaSet'
ALTER TABLE [dbo].[MoradaSet]
ADD CONSTRAINT [FK_MoradaPessoa]
    FOREIGN KEY ([Pessoa_Id])
    REFERENCES [dbo].[PessoaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MoradaPessoa'
CREATE INDEX [IX_FK_MoradaPessoa]
ON [dbo].[MoradaSet]
    ([Pessoa_Id]);
GO

-- Creating foreign key on [IdMetodoPagamento] in table 'PagamentoSet'
ALTER TABLE [dbo].[PagamentoSet]
ADD CONSTRAINT [FK_MetodoPagamentoPagamento]
    FOREIGN KEY ([IdMetodoPagamento])
    REFERENCES [dbo].[MetodoPagamentoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MetodoPagamentoPagamento'
CREATE INDEX [IX_FK_MetodoPagamentoPagamento]
ON [dbo].[PagamentoSet]
    ([IdMetodoPagamento]);
GO

-- Creating foreign key on [Restaurante_Id] in table 'MoradaSet'
ALTER TABLE [dbo].[MoradaSet]
ADD CONSTRAINT [FK_MoradaRestaurante]
    FOREIGN KEY ([Restaurante_Id])
    REFERENCES [dbo].[RestauranteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MoradaRestaurante'
CREATE INDEX [IX_FK_MoradaRestaurante]
ON [dbo].[MoradaSet]
    ([Restaurante_Id]);
GO

-- Creating foreign key on [Restaurante_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [FK_RestauranteItemMenu_Restaurante]
    FOREIGN KEY ([Restaurante_Id])
    REFERENCES [dbo].[RestauranteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemMenu_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [FK_RestauranteItemMenu_ItemMenu]
    FOREIGN KEY ([ItemMenu_Id])
    REFERENCES [dbo].[ItemMenuSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteItemMenu_ItemMenu'
CREATE INDEX [IX_FK_RestauranteItemMenu_ItemMenu]
ON [dbo].[RestauranteItemMenu]
    ([ItemMenu_Id]);
GO

-- Creating foreign key on [IdCategoria] in table 'ItemMenuSet'
ALTER TABLE [dbo].[ItemMenuSet]
ADD CONSTRAINT [FK_CategoriaItemMenu]
    FOREIGN KEY ([IdCategoria])
    REFERENCES [dbo].[CategoriaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaItemMenu'
CREATE INDEX [IX_FK_CategoriaItemMenu]
ON [dbo].[ItemMenuSet]
    ([IdCategoria]);
GO

-- Creating foreign key on [IdEstado] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_PedidoEstado]
    FOREIGN KEY ([IdEstado])
    REFERENCES [dbo].[EstadoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoEstado'
CREATE INDEX [IX_FK_PedidoEstado]
ON [dbo].[PedidoSet]
    ([IdEstado]);
GO

-- Creating foreign key on [ItemMenu_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [FK_ItemMenuPedido_ItemMenu]
    FOREIGN KEY ([ItemMenu_Id])
    REFERENCES [dbo].[ItemMenuSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Pedido_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [FK_ItemMenuPedido_Pedido]
    FOREIGN KEY ([Pedido_Id])
    REFERENCES [dbo].[PedidoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuPedido_Pedido'
CREATE INDEX [IX_FK_ItemMenuPedido_Pedido]
ON [dbo].[ItemMenuPedido]
    ([Pedido_Id]);
GO

-- Creating foreign key on [IdRestaurante] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_RestaurantePedido]
    FOREIGN KEY ([IdRestaurante])
    REFERENCES [dbo].[RestauranteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestaurantePedido'
CREATE INDEX [IX_FK_RestaurantePedido]
ON [dbo].[PedidoSet]
    ([IdRestaurante]);
GO

-- Creating foreign key on [IdCliente] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_ClientePedido]
    FOREIGN KEY ([IdCliente])
    REFERENCES [dbo].[PessoaSet_Cliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientePedido'
CREATE INDEX [IX_FK_ClientePedido]
ON [dbo].[PedidoSet]
    ([IdCliente]);
GO

-- Creating foreign key on [IdTrabalhador] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_TrabalhadorPedido]
    FOREIGN KEY ([IdTrabalhador])
    REFERENCES [dbo].[PessoaSet_Trabalhador]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrabalhadorPedido'
CREATE INDEX [IX_FK_TrabalhadorPedido]
ON [dbo].[PedidoSet]
    ([IdTrabalhador]);
GO

-- Creating foreign key on [IdPedido] in table 'PagamentoSet'
ALTER TABLE [dbo].[PagamentoSet]
ADD CONSTRAINT [FK_PagamentoPedido]
    FOREIGN KEY ([IdPedido])
    REFERENCES [dbo].[PedidoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentoPedido'
CREATE INDEX [IX_FK_PagamentoPedido]
ON [dbo].[PagamentoSet]
    ([IdPedido]);
GO

-- Creating foreign key on [Id] in table 'PessoaSet_Cliente'
ALTER TABLE [dbo].[PessoaSet_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PessoaSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'PessoaSet_Trabalhador'
ALTER TABLE [dbo].[PessoaSet_Trabalhador]
ADD CONSTRAINT [FK_Trabalhador_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PessoaSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------