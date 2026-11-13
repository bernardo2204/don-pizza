# Prompts de IA — Etapa 6 (importação do JSON em C#)

IA usada: **Claude (Claude Code)**.

---

## 11/11/2026

**Prompt exato (reaproveitado nas etapas do checklist, numa única sessão):**
> continua

**O que foi gerado:**
- `PedidoJson.cs` e `ItemPedidoJson` — classes pra desserializar o `pedidos.json` com
  `System.Web.Script.Serialization.JavaScriptSerializer` (já vem no .NET Framework, sem pacote novo).
- `ImportadorPedidos.cs` — lê o arquivo, acha o cliente pelo `cliente_email`, insere em
  `tblPedidos` (status `"Recebido"`) e os itens em `tblItensPedido`.
- Menu **"Importar Pedidos"** no `FrmPrincipal`.
- `pedidos.json` de exemplo, na raiz do projeto.

**Reflexão (adaptação do código):**
O acesso a banco seguiu o padrão da professora (`Conexao.ExecutarComando`/`ExecutarConsulta`,
sem Entity Framework). A única peça fora desse padrão é o `JavaScriptSerializer` pra ler o JSON
— não tem equivalente em SQL puro, então usei uma classe pronta do próprio .NET Framework.
Testado de ponta a ponta contra o banco antes de entrar no projeto: pedido criado, cliente achado
pelo email, itens batendo certinho.
