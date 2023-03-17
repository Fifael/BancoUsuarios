using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Generic;
using Models;
using Repository;
using System.Linq;
using System.Collections;

namespace Controller
{
    public class UsuarioCollection : IEnumerable<Usuario>{
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
                return (from usuario in db.Usuarios select usuario).ToList();
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

        public IEnumerator<Usuario> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
