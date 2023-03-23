using Models;
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
            Console.WriteLine("Infome o email do usuário:");
            string email = Console.ReadLine();
            Console.WriteLine("Informe a senha do usuário:");
            string senha = Console.ReadLine();
            SessaoCollection.login(id, email, senha);
        }

        public static void ExcluirSessao()
        {
            Console.WriteLine("Informe o Id da sessão que deseja excluir:");
            int id = int.Parse(Console.ReadLine());
            SessaoCollection.logout(id);
        }

       public static void BuscarSessao(){
            Console.WriteLine("Informe o Id do Login:");
            int id = int.Parse(Console.ReadLine());
            Sessao sessao = SessaoCollection.GetSessao(id);
            Console.WriteLine($"Id: {sessao.Id} ainda esta logado");
        }
    }
}