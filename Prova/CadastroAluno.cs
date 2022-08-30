using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class CadastroAluno
    {

        public string Nome;
        public int Idade;
        public string Escola;
        public double Media;

        public CadastroAluno()
        {
        }

        public CadastroAluno(string nome, int idade, string escola)
        {
            Nome = nome;
            Idade = idade;
            Escola = escola;
        }



        public double Notas()
        {

            Console.WriteLine("Informe o nome do aluno ");
            string nome = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Informe a idade do aluno ");
            int.TryParse(Console.ReadLine(), out int idade);

            Console.WriteLine("Informe o nome da escola ");
            string escola = Console.ReadLine() ?? string.Empty;
            Nome = nome;
            Idade = idade;
            Escola = escola;

            Console.WriteLine("________________________________");
            Console.WriteLine("Agora informe as notas do aluno:");
            Console.WriteLine("________________________________");

            Console.WriteLine("Informe a nota do aluno em Matemática: ");
            double notaMat = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Informe a nota do aluno em Português: ");
            double notaPort = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Informe a nota do aluno em Ciências: ");
            double notaCiencias = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Informe a nota do aluno em Geografia: ");
            double notaGeo = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Informe a nota do aluno em História: ");
            double notaHist = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Informe a nota do aluno em Educação Física: ");
            double notaEdFisica = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Informe a nota do aluno em Ensino Religioso: ");
            double notaEnsReligioso = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Informe a nota do aluno em Inglês: ");
            double notaIngles = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Informe a nota do aluno em Artes: ");
            double notaArtes = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("________________________________");

            Media = ((notaMat + notaPort + notaCiencias + notaGeo + notaHist + notaEdFisica + notaEnsReligioso + notaIngles + notaArtes) / 9.0) / 10.0;

            return Media;

        }


        





    }
}
