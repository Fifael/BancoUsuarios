using System;
using System.Collections.Generic;
using Models;
using Repository;
using System.Collections;
using System.Linq;

namespace Controller
{
    public class SessaoCollection : IEnumerable<Sessao>
    {

        public static void login(int id, string email, string senha)
        {
            try
            {
                using (Context db = new Context())
                {
                    if (UsuarioCollection.getUsuarioByEmailAndSenha(email, senha) == null)
                    {
                        throw new Exception("Usuario não encontrado");
                    }
                    else
                    {
                        Usuario usuario = UsuarioCollection.getUsuarioByEmailAndSenha(email, senha)[0];
                        int idUsuario = usuario.Id;
                        string token = Guid.NewGuid().ToString();
                        DateTime dataCriacao = DateTime.Now;
                        DateTime dataExpiracao = DateTime.Now.AddHours(10);
                        Sessao sessao = new Sessao(id, idUsuario, token, dataCriacao, dataExpiracao);
                        db.Sessoes.Add(sessao);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao logar: " + e.Message);
            }
        }

        public static void logout(int id)
        {
            try
            {
                using (Context db = new Context())
                {
                    Sessao sessao = db.Sessoes.Find(id);
                    db.Sessoes.Remove(sessao);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao fazer" + e.Message);
            }
        }


        public static Sessao GetSessao(int id)
        {
            using (Context db = new Context())
            {
                if (DateTime.Now > db.Sessoes.Find(id).dataExpiracao)
                {
                    db.Sessoes.Remove(db.Sessoes.Find(id));
                    Console.WriteLine("Sessão expirada");
                    return null; 
                }
                else
                {
                    return db.Sessoes.Find(id);
                }
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