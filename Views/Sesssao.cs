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
    }
}