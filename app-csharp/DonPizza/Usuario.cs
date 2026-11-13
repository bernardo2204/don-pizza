using System.Data;

namespace DonPizza
{
    internal class Usuario
    {
        private string email, senha;

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

        Conexao db = new Conexao();

        public bool ValidarLogin()
        {
            string consulta = $"SELECT * FROM tblUsuarios WHERE email = '{email}' AND senha = '{senha}';";
            DataTable dt = db.ExecutarConsulta(consulta);
            return dt.Rows.Count > 0;
        }
    }
}
