using System;

namespace CursoMsDev
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* string nome = readField("Nome");
 
            string sobrenome = readField("Sobrenome");

            Console.WriteLine($"Hey, {nome} {sobrenome}");
            */

            // conta();

            catapulta();

        }

        public static string readField(string input){
            Console.WriteLine($"Informe seu {input}:");
            return Console.ReadLine();
        }

        public static void conta(){
            double valorConta = 45.35;
            double taxaGarcon = 10.0;
            double totalConta;

            totalConta = valorConta*(1 + (taxaGarcon/100));

            Console.WriteLine($"O valor da conta foi, {totalConta:C}");
        }

        public static void catapulta(){
            Console.Write("Informe o numero de baterias: ");
            var baterias = int.Parse(Console.ReadLine());

            Console.Write("Informe a duracao: ");
            var duracao = int.Parse(Console.ReadLine());

            var qtdPedras = (baterias * duracao * 300) / 75;

            Console.WriteLine($"A quantidade de pedras lancadas em {baterias} baterias de {duracao} minutos foi {qtdPedras}");
        }
    }
}