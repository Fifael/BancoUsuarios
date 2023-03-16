using System;
using System.Collections.Generic;
using System.Linq;
using Controller;
using Models;


namespace view
{
    public class UsuarioView
    {
        public static void CadastrarUsuario()
        {
            Console.WriteLine("Informe o Id do usuário:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do usuário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o email do usuário: ");
            string email = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuário: ");
            string senha = Console.ReadLine();
            Usuario usuario = new Usuario(id, nome, email, senha);
            UsuarioController.AddUsuario(usuario);

        }

        public static void AlterarUsuario()
        {
            /*Console.WriteLine("Informe o Id do usuário:");
            int id = int.Parse(Console.ReadLine());
            UsuarioController.UpdateUsuario(id);*/

        }

        public static void Select()
        {
            var usuarios = UsuarioController.GetUsuarios();
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"Id: {usuario.Id} - Nome: {usuario.Nome} - Email: {usuario.Email} - Senha: {usuario.Senha}");
            }

        }
        public static void RemoverUsuario()
        {
            Console.WriteLine("Informe o Id do usuário:");
            int id = int.Parse(Console.ReadLine());
            UsuarioController.DeleteUsuario(id);
        }
    }
}