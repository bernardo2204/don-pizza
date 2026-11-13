using System.Data;

namespace DonPizza
{
    internal class Fornecedor
    {
        private int id;
        private string nome, cnpj, telefone, email, produtoFornecido;

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

        public void SetCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public string GetCnpj()
        {
            return this.cnpj;
        }

        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string GetTelefone()
        {
            return this.telefone;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public void SetProdutoFornecido(string produtoFornecido)
        {
            this.produtoFornecido = produtoFornecido;
        }

        public string GetProdutoFornecido()
        {
            return this.produtoFornecido;
        }

        Conexao db = new Conexao();

        public void InserirFornecedor()
        {
            string inserir = $"INSERT INTO tblFornecedores (nome, cnpj, telefone, email, produto_fornecido) VALUES ('{nome}', '{cnpj}', '{telefone}', '{email}', '{produtoFornecido}');";
            db.ExecutarComando(inserir);
        }

        public void AlterarFornecedor()
        {
            string alterar = $"UPDATE tblFornecedores SET nome = '{nome}', cnpj = '{cnpj}', telefone = '{telefone}', email = '{email}', produto_fornecido = '{produtoFornecido}' WHERE id = {this.id};";
            db.ExecutarComando(alterar);
        }

        public void ExcluirFornecedor()
        {
            string deletar = $"DELETE FROM tblFornecedores WHERE id = {this.id};";
            db.ExecutarComando(deletar);
        }

        public DataTable ListarFornecedores()
        {
            string consulta = "SELECT * FROM tblFornecedores ORDER BY nome;";
            return db.ExecutarConsulta(consulta);
        }
    }
}
