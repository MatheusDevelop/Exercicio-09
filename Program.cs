using System;

namespace PPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Contas Calcular = new Contas();
            Console.WriteLine("Iniciando calculadora");
            Console.WriteLine("Qual operaçao voce deseja fazer?\n\nDigite SOMA para somar\n\nDigite SUB para subtrair \n\nDigite MULT para multiplicar \n\nDigite DIV para dividir");
            Calcular.Conta(Console.ReadLine());

        }
    }
}
