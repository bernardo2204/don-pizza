using System.Data;

namespace DonPizza
{
    internal class Pedido
    {
        private int id;
        private string status;

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetStatus(string status)
        {
            this.status = status;
        }

        public string GetStatus()
        {
            return this.status;
        }

        Conexao db = new Conexao();

        public void AlterarStatusPedido()
        {
            string alterar = $"UPDATE tblPedidos SET status = '{status}' WHERE id = {this.id};";
            db.ExecutarComando(alterar);
        }

        public void ExcluirPedido()
        {
            string deletar = $"DELETE FROM tblPedidos WHERE id = {this.id};";
            db.ExecutarComando(deletar);
        }

        public DataTable ListarPedidos()
        {
            string consulta = "SELECT p.id, c.nome AS cliente, p.data_pedido, p.status, p.forma_pagamento, p.endereco_entrega, p.valor_total FROM tblPedidos p INNER JOIN tblClientes c ON c.id = p.cliente_id ORDER BY p.data_pedido DESC;";
            return db.ExecutarConsulta(consulta);
        }
    }
}
