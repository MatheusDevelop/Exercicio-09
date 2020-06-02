using System;
namespace PPOO
{
    // Este metodo é chamado por outra classe , por isso public
    public class Inputs
    {
        public double n1=0;
        public double n2=0;
        // Essa classe armazena os dados e modifica-os ,deixando eles usaveis para as operaçoes
       
        // Este atributo privado é usado para calcular a media e nao aparecer para outras instancias 
        private double media;

        public void Dados(){
            Console.WriteLine("Qual o primeiro valor:");
            n1=double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o segundo valor:");
            n2=double.Parse(Console.ReadLine());
            Media();
        }

        // Esse metodo é privado para nao ser usado por outras classes
        private void Media(){
            media=(n1+n2)/2;
            Console.WriteLine("A media dos valores digitados é : {0}",media);
        }
    }
}