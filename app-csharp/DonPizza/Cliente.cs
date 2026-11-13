using System.Data;

namespace DonPizza
{
    internal class Cliente
    {
        private int id;
        private string nome, cpf, telefone, email, senha, cep, endereco;

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

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string GetCpf()
        {
            return this.cpf;
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

        public void SetSenha(string senha)
        {
            this.senha = senha;
        }

        public string GetSenha()
        {
            return this.senha;
        }

        public void SetCep(string cep)
        {
            this.cep = cep;
        }

        public string GetCep()
        {
            return this.cep;
        }

        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string GetEndereco()
        {
            return this.endereco;
        }

        Conexao db = new Conexao();

        public void InserirCliente()
        {
            string inserir = $"INSERT INTO tblClientes (nome, cpf, telefone, email, senha, cep, endereco) VALUES ('{nome}', '{cpf}', '{telefone}', '{email}', '{senha}', '{cep}', '{endereco}');";
            db.ExecutarComando(inserir);
        }

        public void AlterarCliente()
        {
            string alterar = $"UPDATE tblClientes SET nome = '{nome}', cpf = '{cpf}', telefone = '{telefone}', email = '{email}', senha = '{senha}', cep = '{cep}', endereco = '{endereco}' WHERE id = {this.id};";
            db.ExecutarComando(alterar);
        }

        public void ExcluirCliente()
        {
            string deletar = $"DELETE FROM tblClientes WHERE id = {this.id};";
            db.ExecutarComando(deletar);
        }

        public DataTable ListarClientes()
        {
            string consulta = "SELECT * FROM tblClientes ORDER BY nome;";
            return db.ExecutarConsulta(consulta);
        }
    }
}
