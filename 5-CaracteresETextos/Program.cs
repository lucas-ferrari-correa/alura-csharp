using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Caracteres e textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);
            Console.WriteLine((int)primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)((int)primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2021;
            string cursosProgramacao = @" - .NET
                 - Java
                 - Javascript";
                
            Console.WriteLine(titulo + cursosProgramacao);

            Console.ReadLine();
        }
    }
}
