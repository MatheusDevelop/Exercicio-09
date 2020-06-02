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
            // Chamando um metodo instanciado passando como argumento uma STRING que usuario vai digitar
            // É usado uma abstraçao de 4 niveis
            // A classe abstrata é INPUTS e seus niveis sao Soma , Sub , Div e Mult
            Calcular.Conta(Console.ReadLine());

        }
    }
}
