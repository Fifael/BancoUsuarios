/*using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Generic;
using Models;
using Repository;
using System.Collections;
using System.Linq;

namespace Controller {
    public class SessaoCollection : IEnumerable<Sessao>{

        public static Sessao GetSessao(int id) {
            using (Context db = new Context()) {
                return db.Sessoes.Find(id);
            }
        }

        public static List<Sessao> GetSessoes() {
            using (Context db = new Context()) {
                return db.Sessoes.ToList();
            }
        }

        public static void AddSessao(Sessao sessao) {
            using (Context db = new Context()) {
                db.Sessoes.Add(sessao);
                db.SaveChanges();
            }
        }

        public static void UpdateSessao(Sessao sessao) {
            using (Context db = new Context()) {
                db.Sessoes.Update(sessao);
                db.SaveChanges();
            }
        }

        public static void DeleteSessao(int id) {
            using (Context db = new Context()) {
                db.Sessoes.Remove(db.Sessoes.Find(id));
                db.SaveChanges();
            }
        }

        public IEnumerator<Sessao> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}*/