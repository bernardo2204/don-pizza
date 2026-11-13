# Don Pizza — Projeto Integrador (COTEMIG, 2º ano)

Dupla 11: Bernardo Pimenta + David. Pizzaria "Don Pizza".

## Estrutura

- `site/` — site do cliente (HTML/CSS/JS puro). Gera um JSON de pedido.
- `app-csharp/DonPizza/` — app de gestão (C# WinForms + MySQL). Importa o JSON.
- `banco/db_delivery.sql` — script do banco `DB_Delivery` (MySQL 8.0).
- `docs/` — diagramas de arquitetura e documentação de uso de IA (PDFs).
- `assets/` — logo e fotos dos produtos.

## Como rodar o app C#

1. Rodar `banco/db_delivery.sql` num MySQL 8.0 local (serviço `MySQL80`).
   ⚠️ O script começa com `DROP DATABASE` — roda limpo, mas apaga dados antigos se já existir.
2. Abrir `app-csharp/DonPizza/DonPizza.sln` no Visual Studio 2022.
3. Clicar com o botão direito no projeto → **Restaurar Pacotes NuGet** (baixa o `MySql.Data`, precisa de internet).
4. Em `Conexao.cs`, trocar `SENHA_AQUI` pela senha do seu usuário `root` do MySQL local.
5. Rodar (F5). Login de teste em `tblUsuarios` (ver `banco/db_delivery.sql`).

## Como rodar o site

Abrir `site/index.html` direto no navegador (ou servir a pasta `site/` com qualquer servidor estático).
