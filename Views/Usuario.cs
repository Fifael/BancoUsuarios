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
            UsuarioCollection.AddUsuario(usuario);

        }

        public static void AlterarUsuario()
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
            UsuarioCollection.UpdateUsuario(new Models.Usuario(id, nome, email, senha));
        }

        public static void Select()
        {
            var usuarios = UsuarioCollection.GetUsuarios();
            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine($"Id: {usuario.Id} Nome: {usuario.Nome} Email: {usuario.Email} Senha: {usuario.Senha}");
            }
        }

        public static void SelectById()
        {
            Console.WriteLine("Informe o Id do usuário:");
            int id = int.Parse(Console.ReadLine());
            Usuario usuario = UsuarioCollection.GetUsuario(id);
            Console.WriteLine($"Id: {usuario.Id} Nome: {usuario.Nome} Email: {usuario.Email} Senha: {usuario.Senha}");
        }

        public static void RemoverUsuario()
        {
            Console.WriteLine("Informe o Id do usuário:");
            int id = int.Parse(Console.ReadLine());
            UsuarioCollection.DeleteUsuario(id);
        }
    }
}