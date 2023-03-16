using Models;
using Repository;

namespace Controller {
    public class PerfilController{
        public static Perfil GetPerfil(int id) {
            using (Context db = new Context()) {
                return db.Perfis.Find(id);
            }
        }

        public static List<Perfil> GetPerfis() {
            using (Context db = new Context()) {
                return db.Perfis.ToList();
            }
        }

        public static void AddPerfil(Perfil perfil) {
            using (Context db = new Context()) {
                db.Perfis.Add(perfil);
                db.SaveChanges();
            }
        }

        public static void UpdatePerfil(Perfil perfil) {
            using (Context db = new Context()) {
                db.Perfis.Update(perfil);
                db.SaveChanges();
            }
        }

        public static void DeletePerfil(int id) {
            using (Context db = new Context()) {
                db.Perfis.Remove(db.Perfis.Find(id));
                db.SaveChanges();
            }
        }
    }
}