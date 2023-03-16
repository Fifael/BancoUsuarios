using Models;
using Controller;

namespace view{
    public class PerfilView{
        public static void CadastrarPerfil(){
            Console.WriteLine("Informe o Id do perfil:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Id do usuário:");
            int usuarioId = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o perfil:");
            string perfils = Console.ReadLine();
            Perfil perfil = new Perfil(id, usuarioId, perfils);
            PerfilController.AddPerfil(perfil);
        }
        public static void AlterarPerfil(){
            Console.WriteLine("Informe o Id do perfil:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Id do usuário:");
            int usuarioId = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o perfil:");
            string perfil = Console.ReadLine();
            PerfilController.UpdatePerfil(new Perfil(id, usuarioId, perfil));
        }
        public static void Select(){
            var perfis = PerfilController.GetPerfis();
            foreach (var perfil in perfis){
                Console.WriteLine($"Id: {perfil.Id} - Id do usuário: {perfil.UsuarioId} - Perfil: {perfil.perfil}");
            }
        }
        public static void RemoverPerfil(){
            Console.WriteLine("Informe o Id do perfil:");
            int id = int.Parse(Console.ReadLine());
            PerfilController.DeletePerfil(id);
        }
    }
}