using System;
namespace PPOO
{
    public class Contas
    {
       
       // Este metodo é chamado por outra classe , por isso public
       public void Conta(string cases){
            Soma Somar = new Soma();
            Sub Subtrair = new Sub();
            Mult Multiplicar = new Mult();
            Div Dividir = new Div();
            // Instancia todas as operaçoes

            // As operaçoes usam uma classe abstrata chamada INPUT
            

            switch(cases){
                case "SOMA":
                    
                    Somar.Somcount();
                    break;
                case "SUB":
                    
                    Subtrair.Subcount();
                    break;
                case "DIV":
                    Dividir.Divcount();
                    break;
                case "MULT":
                    Multiplicar.Multcount();
                    break;
                default:
                    Console.WriteLine("Comando invalido , desligando...");
                    break;


            }

       }


    }
}