using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Generic;
using Models;
using Repository;

namespace Controller
{
    public class UsuarioController{
        public static Usuario GetUsuario(int id)
        {
            using (Context db = new Context())
            {
                return db.Usuarios.Find(id);
            }
        }

        public static List<Usuario> GetUsuarios()
        {
            using (Context db = new Context())
            {
                return db.Usuarios.ToList();
            }
        }

        public static void AddUsuario(Usuario usuario)
        {
            using (Context db = new Context())
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }
        }

        public static void UpdateUsuario(Usuario usuario)
        {
            using (Context db = new Context())
            {
                db.Usuarios.Update(usuario);
                db.SaveChanges();
            }
        }

        public static void DeleteUsuario(int id)
        {
            using (Context db = new Context())
            {
                db.Usuarios.Remove(db.Usuarios.Find(id));
                db.SaveChanges();
            }
        }





    }
}
