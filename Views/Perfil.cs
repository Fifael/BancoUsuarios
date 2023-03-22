using Models;
using Controller;
using System;

namespace view{
    public class PerfilView{
        public static void CadastrarPerfil(){
            try {
            Console.WriteLine("Informe o Id do perfil:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Id do usuário:");
            int usuarioId = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o status:");
            string status = Console.ReadLine();
            PerfilCollection.AddPerfil(new Models.Perfil(id, usuarioId, status));

            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void ListarPerfil(){
            var perfils = PerfilCollection.GetPerfis();
            foreach (Perfil perfil in perfils){
                Console.WriteLine($"Id: {perfil.Id} Id do usuário: {perfil.UsuarioId} Perfil: {perfil.Status}");
            }
        }

        public static void BuscarPerfil(){
            Console.WriteLine("Informe o Id do perfil:");
            int id = int.Parse(Console.ReadLine());
            Perfil perfil = PerfilCollection.GetPerfil(id);
            Console.WriteLine($"Id: {perfil.Id} Id do usuário: {perfil.UsuarioId} Perfil: {perfil.Status}");
        }

        public static void AtualizarPerfil(){
            Console.WriteLine("Informe o Id do perfil:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Id do usuário:");
            int usuarioId = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o status:");
            string status = Console.ReadLine();
            Perfil perfil = new Perfil(id, usuarioId, status);
            PerfilCollection.UpdatePerfil(perfil);
        }

        public static void DeletarPerfil(){
            Console.WriteLine("Informe o Id do perfil:");
            int id = int.Parse(Console.ReadLine());
            PerfilCollection.DeletePerfil(id);
        }
    }
}