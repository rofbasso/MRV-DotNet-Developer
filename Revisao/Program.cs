using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcoes funcao = new Funcoes();

            string opcaoUsuario = funcao.MenuOpcoes();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.Clear();
                        funcao.adicionarAluno();
                        break;
                    case "2":
                        Console.Clear();
                        funcao.listarAlunos();
                        break;
                    case "3":
                        Console.Clear();
                        funcao.calcularMedia();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.Clear();                    

                opcaoUsuario = funcao.MenuOpcoes();
            }
        }

        
    }
}
