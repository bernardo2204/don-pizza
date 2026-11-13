-- Banco do projeto Don Pizza - Dupla 11 (Bernardo e David)
-- ATENCAO: a linha abaixo apaga o banco inteiro. Rodar de novo apaga todos os dados.
drop database if exists DB_Delivery;

create database DB_Delivery character set utf8mb4 collate utf8mb4_unicode_ci;

use DB_Delivery;

-- Login do app C# (funcionarios da pizzaria)
create table tblUsuarios(
   id int not null primary key auto_increment,
   nome varchar(100) not null,
   email varchar(100) not null unique,
   senha varchar(50) not null
);

-- CRUD 1
create table tblClientes(
   id int not null primary key auto_increment,
   nome varchar(100) not null,
   cpf char(14) not null unique,
   telefone varchar(15) not null,
   email varchar(100) not null unique,
   senha varchar(50) not null,
   cep char(9),
   endereco varchar(150)
);

-- CRUD 2
create table tblFornecedores(
   id int not null primary key auto_increment,
   nome varchar(100) not null,
   cnpj char(18) not null unique,
   telefone varchar(15) not null,
   email varchar(100),
   produto_fornecido varchar(100) not null
);

-- Somente alterar/excluir pelo C#; cadastro so por este script
create table tblProdutos(
   id int not null primary key auto_increment,
   nome varchar(100) not null,
   descricao varchar(255),
   categoria varchar(30) not null,
   preco decimal(8,2) not null,
   imagem varchar(150)
);

-- Somente alterar status/excluir pelo C#; entram pela importacao do JSON
create table tblPedidos(
   id int not null primary key auto_increment,
   cliente_id int not null,
   data_pedido datetime not null,
   status varchar(30) not null default 'Recebido',
   forma_pagamento varchar(30) not null,
   endereco_entrega varchar(150) not null,
   valor_total decimal(8,2) not null,
   foreign key (cliente_id) references tblClientes(id)
);

-- Itens de cada pedido (vem junto no JSON)
create table tblItensPedido(
   id int not null primary key auto_increment,
   pedido_id int not null,
   produto_id int not null,
   quantidade int not null,
   preco_unitario decimal(8,2) not null,
   foreign key (pedido_id) references tblPedidos(id) on delete cascade,
   foreign key (produto_id) references tblProdutos(id)
);

-- Usuario do login do app
insert into tblUsuarios (nome, email, senha) values
('Administrador', 'admin@pizzaria.com', '123456');

-- Cardapio da pizzaria
insert into tblProdutos (nome, descricao, categoria, preco) values
('Pizza Margherita', 'Molho de tomate, mussarela e manjericao', 'Pizza Salgada', 45.90),
('Pizza Calabresa', 'Calabresa fatiada, cebola e mussarela', 'Pizza Salgada', 49.90),
('Pizza Portuguesa', 'Presunto, ovo, cebola, ervilha e mussarela', 'Pizza Salgada', 54.90),
('Pizza Frango com Catupiry', 'Frango desfiado e catupiry', 'Pizza Salgada', 52.90),
('Pizza Quatro Queijos', 'Mussarela, provolone, parmesao e gorgonzola', 'Pizza Salgada', 56.90),
('Pizza Chocolate', 'Chocolate ao leite e granulado', 'Pizza Doce', 44.90),
('Pizza Romeu e Julieta', 'Goiabada e mussarela', 'Pizza Doce', 42.90),
('Refrigerante 2L', 'Coca-Cola 2 litros', 'Bebida', 14.00),
('Suco Natural 500ml', 'Laranja', 'Bebida', 9.00);

-- Clientes de teste (o site cadastra os de verdade)
insert into tblClientes (nome, cpf, telefone, email, senha, cep, endereco) values
('Joao Silva', '123.456.789-00', '(31) 99999-1111', 'joao@email.com', '123456', '30140-000', 'Rua A, 100 - Centro'),
('Maria Souza', '987.654.321-00', '(31) 98888-2222', 'maria@email.com', '123456', '30150-000', 'Av. B, 250 - Funcionarios');

-- Fornecedores de teste
insert into tblFornecedores (nome, cnpj, telefone, email, produto_fornecido) values
('Laticinios Minas', '12.345.678/0001-90', '(31) 3333-4444', 'contato@laticiniosminas.com', 'Queijos'),
('Distribuidora Bebidas BH', '98.765.432/0001-10', '(31) 3555-6666', 'vendas@bebidasbh.com', 'Bebidas');

select * from tblProdutos;
