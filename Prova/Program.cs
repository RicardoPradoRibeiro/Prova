using Prova;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ProgramaPrincipal
{
    class program
    {
        static List<CadastroAluno> AlunosCadastrados = new List<CadastroAluno>();
        public static void Main(string[] args)
        {

            

            int opcao2 = 1;
            while (opcao2 == 1 || opcao2 == 2)
            {
                Console.WriteLine("---------Menu Principal---------");
                Console.WriteLine("1. Cadastro Novo: ");
                Console.WriteLine("2. Listas alunos: ");
                Console.WriteLine("3. Sair");
                
                
                var opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        var aluno = new CadastroAluno();
                        aluno.Notas();
                        AlunosCadastrados.Add(aluno);
                        Console.WriteLine();
                        break;
                    case "2":
                        ListarAlunos();
                        Console.WriteLine();
                        break;
                    default:
                            Console.WriteLine("Para sair, tecle Enter. ");
                        int.TryParse(Console.ReadLine(), out opcao2);
                        break;
                            

                            
                    
                        
                        


                }
                
            }

        }



        private static void ListarAlunos()
        {
            foreach(var aluno in AlunosCadastrados)
            {
                Console.WriteLine(aluno.Nome + " " + aluno.Idade + " " + aluno.Escola +" " + aluno.Media.ToString("F1"));
                

                if (aluno.Media >= 7.0)
                {
                    Console.WriteLine("Aprovado");
                }
                else if(aluno.Media > 2.0)
                {
                    Console.WriteLine("Recuperação");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }

            }
        }

















          












    }

}
































