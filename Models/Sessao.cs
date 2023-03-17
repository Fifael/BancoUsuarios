namespace Models {
    public class Sessao {
        public int Id { get; set; }
        public Usuario usuario { get; set; }
        public int UsuarioId { get; set; }
        public string token { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataExpiracao { get; set; }
        public Sessao(int id, int usuarioId, string token, DateTime dataCricao, DateTime dataExpiracao) {
            this.Id = id;
            this.UsuarioId = usuarioId;
            this.token = token;
            this.dataCriacao = dataCriacao;
            this.dataExpiracao = dataExpiracao;
        }

        public override string ToString()
        {
            return "Id: " + this.Id + " UsuarioId: " + this.UsuarioId + " Token: " + this.token + " Data de Criação: " + this.dataCriacao + " Data de Expiração: " + this.dataExpiracao;
        }
    }
}