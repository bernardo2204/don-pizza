using System.Collections.Generic;

namespace DonPizza
{
    public class ItemPedidoJson
    {
        public int produto_id { get; set; }
        public int quantidade { get; set; }
        public decimal preco_unitario { get; set; }
    }

    public class PedidoJson
    {
        public string cliente_email { get; set; }
        public string data_pedido { get; set; }
        public string forma_pagamento { get; set; }
        public string endereco_entrega { get; set; }
        public decimal valor_total { get; set; }
        public List<ItemPedidoJson> itens { get; set; }
    }
}
