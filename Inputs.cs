using System;
namespace PPOO
{
    public class Inputs
    {
        public double n1=0;
        public double n2=0;

       

        public void Dados(){
            Console.WriteLine("Qual o primeiro valor:");
            n1=double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o segundo valor:");
            n2=double.Parse(Console.ReadLine());
        }
    }
}