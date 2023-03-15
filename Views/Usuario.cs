using System;
using Controller;
using Models;


namespace view {
    public class Usuario{
        public static void CadastrarUsuario() {
            Console.WriteLine("Informe o Id do usuário:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do usuário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o email do usuário: ");
            string email = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuário: ");
            string senha = Console.ReadLine();
            Console.WriteLine("Digite o perfil do usuário: ");
            string perfil = Console.ReadLine();
            Usuario usuario = new Usuario(id, nome, email, senha);
            UsuarioController.AddUsuario(usuario);
    }
}
}