namespace Models {
    public class Sessao {
        public int Id { get; set; }
        public Usuario usuario { get; set; }
        public int UsuarioId { get; set; }
        public string token { get; set; }
        public DateTime dataCricao { get; set; }
        public DateTime dataExpiracao { get; set; }
        public Sessao(int id, int usuarioId, string token, DateTime dataCricao, DateTime dataExpiracao) {
            this.Id = id;
            this.UsuarioId = usuarioId;
            this.token = token;
            this.dataCricao = dataCricao;
            this.dataExpiracao = dataExpiracao;
        }
    }
}