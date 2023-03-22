using System;
using view;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 16)
            {
                Console.WriteLine("1 - Cadastra Usuario");
                Console.WriteLine("2 - Alterar Usuario");
                Console.WriteLine("3 - Mostar Usuario");
                Console.WriteLine("4 - Remover Usuario");
                Console.WriteLine("5 - Cadastra Perfil");
                Console.WriteLine("6 - Alterar Perfil");
                Console.WriteLine("7 - Mostar Perfil");
                Console.WriteLine("8 - Remover Perfil");
                Console.WriteLine("9 - Cadastra Sessao");
                Console.WriteLine("10 - Alterar Sessao");
                Console.WriteLine("11 - Mostar Sessao");
                Console.WriteLine("12 - Remover Sessao");
                Console.WriteLine("13 - Mostar todos Usuario");
                Console.WriteLine("14 - Mostar todos Perfil");
                Console.WriteLine("15 - Mostar todos Sessao");
                Console.WriteLine("16 - Sair");

                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        UsuarioView.CadastrarUsuario();
                        break;
                    case 2:
                        UsuarioView.AlterarUsuario();
                        break;
                    case 3:
                        UsuarioView.SelectById();
                        break;
                    case 4:
                        UsuarioView.RemoverUsuario();
                        break;
                    case 5:
                        PerfilView.CadastrarPerfil();
                        break;
                    case 6:
                        PerfilView.AtualizarPerfil();
                        break;
                    case 7:
                        PerfilView.BuscarPerfil();
                        break;
                    case 8:
                        PerfilView.DeletarPerfil();
                        break;
                    /* case 9:
                        SessaoView.CadastrarSessao();
                        break;
                    case 10:
                        SessaoView.AtualizarSessao();
                        break;
                    case 11:
                        SessaoView.BuscarSessao();
                        break;
                    case 12:
                        SessaoView.DeletarSessao();
                        break;*/
                    case 13:
                        UsuarioView.Select();
                        break;
                    case 14:
                        PerfilView.ListarPerfil();
                        break;
                    /*case 15:
                        SessaoView.ListarSessao();
                        break;*/
                    case 16:
                        Sair();
                    break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
        public static void Sair()
        {
            Console.WriteLine("Saindo...");
            Environment.Exit(0);
        }
    }
}