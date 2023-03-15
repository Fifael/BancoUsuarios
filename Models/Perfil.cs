namespace Models {
    public class Perfil {
        public int Id { get; set; }
        public Usuario usuario { get; set; }
        public int UsuarioId { get; set; }
        public string perfil { get; set; }

        public Perfil(int id, int usuarioId, string perfil) {
            this.Id = id;
            this.UsuarioId = usuarioId;
            this.perfil = perfil;
        }
    }
}