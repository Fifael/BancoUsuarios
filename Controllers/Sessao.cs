using System;
using System.Collections.Generic;
using Models;
using Repository;
using System.Collections;
using System.Linq;

namespace Controller {
    public class SessaoCollection : IEnumerable<Sessao>{

        public static void login (int id, string email, string senha){
            try {
                using (Context db = new Context()) {
                    if(UsuarioCollection.getUsuarioByEmailAndSenha(email, senha) == null) {
                        throw new Exception("Usuario não encontrado");
                    } else {
                        Usuario usuario = UsuarioCollection.getUsuarioByEmailAndSenha(email, senha)[0];
                        int idUsuario = usuario.Id;
                        string token = Guid.NewGuid().ToString();
                        DateTime dataCriacao = DateTime.Now;
                        DateTime dataExpiracao = DateTime.Now.AddHours(1);
                        Sessao sessao = new Sessao(id, idUsuario, token, dataCriacao, dataExpiracao);
                        db.Sessoes.Add(sessao);
                        db.SaveChanges();
                    }
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
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
}