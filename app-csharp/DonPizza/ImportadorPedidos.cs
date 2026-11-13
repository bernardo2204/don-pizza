using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Web.Script.Serialization;

namespace DonPizza
{
    internal class ImportadorPedidos
    {
        Conexao db = new Conexao();

        public string Importar(string caminhoArquivo)
        {
            string textoJson = File.ReadAllText(caminhoArquivo);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<PedidoJson> pedidos = serializer.Deserialize<List<PedidoJson>>(textoJson);

            int importados = 0;
            int ignorados = 0;
            string erros = "";

            foreach (PedidoJson pedido in pedidos)
            {
                string consultaCliente = $"SELECT id FROM tblClientes WHERE email = '{pedido.cliente_email}';";
                DataTable dtCliente = db.ExecutarConsulta(consultaCliente);

                if (dtCliente.Rows.Count == 0)
                {
                    ignorados++;
                    erros += $"- {pedido.cliente_email}: cliente não encontrado\n";
                    continue;
                }

                int clienteId = Convert.ToInt32(dtCliente.Rows[0]["id"]);

                string inserirPedido = $"INSERT INTO tblPedidos (cliente_id, data_pedido, status, forma_pagamento, endereco_entrega, valor_total) VALUES ({clienteId}, '{pedido.data_pedido}', 'Recebido', '{pedido.forma_pagamento}', '{pedido.endereco_entrega}', {pedido.valor_total.ToString(System.Globalization.CultureInfo.InvariantCulture)});";
                db.ExecutarComando(inserirPedido);

                string consultaPedido = $"SELECT id FROM tblPedidos WHERE cliente_id = {clienteId} AND data_pedido = '{pedido.data_pedido}' ORDER BY id DESC LIMIT 1;";
                DataTable dtPedido = db.ExecutarConsulta(consultaPedido);
                int pedidoId = Convert.ToInt32(dtPedido.Rows[0]["id"]);

                foreach (ItemPedidoJson item in pedido.itens)
                {
                    string inserirItem = $"INSERT INTO tblItensPedido (pedido_id, produto_id, quantidade, preco_unitario) VALUES ({pedidoId}, {item.produto_id}, {item.quantidade}, {item.preco_unitario.ToString(System.Globalization.CultureInfo.InvariantCulture)});";
                    db.ExecutarComando(inserirItem);
                }

                importados++;
            }

            string resumo = $"{importados} pedido(s) importado(s) com sucesso.";
            if (ignorados > 0)
                resumo += $"\n{ignorados} pedido(s) ignorado(s):\n{erros}";

            return resumo;
        }
    }
}
