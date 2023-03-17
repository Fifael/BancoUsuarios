using System;
namespace Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    
        public Usuario(int id, string nome, string email, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        public override string ToString() {
            return "Id: " + this.Id + " Nome: " + this.Nome + " Email: " + this.Email + " Senha: " + this.Senha;
        }

    }
}