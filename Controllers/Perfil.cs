using Models;
using Repository;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Collections;
using Controller;

namespace Controller {
    public class PerfilCollection : IEnumerable<Perfil>{
        public static Perfil GetPerfil(int id) {
            try {
                using (Context db = new Context()) {
                return db.Perfis.Find(id);
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Perfil> GetPerfis() {
            try {
                using (Context db = new Context()) {
                    return db.Perfis.ToList();
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static void AddPerfil(Perfil perfil) {
            try {
                using (Context db = new Context()) {
                    if(UsuarioCollection.GetUsuario(perfil.UsuarioId) == null){
                        Console.WriteLine("Usuario não encontrado");
                    }
                    else{
                        Console.WriteLine("Usuario encontrado");
                        //perfil.usuario = UsuarioCollection.GetUsuario(perfil.UsuarioId);
                        db.Perfis.Add(perfil);
                        db.SaveChanges();
                        }
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void UpdatePerfil(Perfil perfil) {
            try {
                using (Context db = new Context()) {
                    db.Perfis.Update(perfil);
                    db.SaveChanges();
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeletePerfil(int id) {
            try {
                using (Context db = new Context()) {
                    Perfil perfil = db.Perfis.Find(id);
                    db.Perfis.Remove(perfil);
                    db.SaveChanges();
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public IEnumerator<Perfil> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}