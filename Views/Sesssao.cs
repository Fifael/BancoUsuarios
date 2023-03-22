/*using Models;
using Controller;
using System;

namespace view
{
    public class SessaoView
    {
        public static void CadastrarSessao()
        {
            Console.WriteLine("Informe o Id da sessão:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Id do usuário:");
            int usuarioId = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Token:");
            string token = Console.ReadLine();
            Console.WriteLine("Informe a data de criação:");
            DateTime dataCriacao = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe a data de expiração:");
            DateTime dataExpiracao = DateTime.Parse(Console.ReadLine());
            Sessao sessao = new Sessao(id, usuarioId, token, dataCriacao, dataExpiracao);
            SessaoCollection.AddSessao(sessao);
        }
        public static void BuscarSessao()
        {
            Console.WriteLine("Informe o Id da sessão:");
            int id = int.Parse(Console.ReadLine());
            Sessao sessao = SessaoCollection.GetSessao(id);
            Console.WriteLine($"Id: {sessao.Id}");
            Console.WriteLine($"Id do usuário: {sessao.UsuarioId}");
            Console.WriteLine($"Token: {sessao.token}");
            Console.WriteLine($"Data de criação: {sessao.dataCriacao}");
            Console.WriteLine($"Data de expiração: {sessao.dataExpiracao}");
        }

        public static void AtualizarSessao()
        {
            Console.WriteLine("Informe o Id da sessão:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Id do usuário:");
            int usuarioId = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Token:");
            string token = Console.ReadLine();
            Console.WriteLine("Informe a data de criação:");
            DateTime dataCriacao = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe a data de expiração:");
            DateTime dataExpiracao = DateTime.Parse(Console.ReadLine());
            Sessao sessao = new Sessao(id, usuarioId, token, dataCriacao, dataExpiracao);
            SessaoCollection.UpdateSessao(sessao);
        }

        public static void DeletarSessao()
        {
            Console.WriteLine("Informe o Id da sessão:");
            int id = int.Parse(Console.ReadLine());
            SessaoCollection.DeleteSessao(id);
        }

        public static void ListarSessao(){

            var sessoes = SessaoCollection.GetSessoes();
            foreach (Sessao sessao in sessoes){
                Console.WriteLine("Id: " + sessao.Id + " Id do usuário: " + sessao.UsuarioId + " Token: " + sessao.token + " Data de criação: " + sessao.dataCriacao + " Data de expiração: " + sessao.dataExpiracao);
            }
        }
    }
}*/