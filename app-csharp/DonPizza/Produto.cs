using System.Data;

namespace DonPizza
{
    internal class Produto
    {
        private int id;
        private string nome, descricao, categoria, imagem;
        private decimal preco;

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public string GetDescricao()
        {
            return this.descricao;
        }

        public void SetCategoria(string categoria)
        {
            this.categoria = categoria;
        }

        public string GetCategoria()
        {
            return this.categoria;
        }

        public void SetPreco(decimal preco)
        {
            this.preco = preco;
        }

        public decimal GetPreco()
        {
            return this.preco;
        }

        public void SetImagem(string imagem)
        {
            this.imagem = imagem;
        }

        public string GetImagem()
        {
            return this.imagem;
        }

        Conexao db = new Conexao();

        public void AlterarProduto()
        {
            string alterar = $"UPDATE tblProdutos SET nome = '{nome}', descricao = '{descricao}', categoria = '{categoria}', preco = {preco.ToString(System.Globalization.CultureInfo.InvariantCulture)}, imagem = '{imagem}' WHERE id = {this.id};";
            db.ExecutarComando(alterar);
        }

        public void ExcluirProduto()
        {
            string deletar = $"DELETE FROM tblProdutos WHERE id = {this.id};";
            db.ExecutarComando(deletar);
        }

        public DataTable ListarProdutos()
        {
            string consulta = "SELECT * FROM tblProdutos ORDER BY categoria, nome;";
            return db.ExecutarConsulta(consulta);
        }
    }
}
