using System;
namespace PPOO
{
    public class Contas
    {
       
       
       public void Conta(string cases){
            Soma Somar = new Soma();
            Sub Subtrair = new Sub();
            Mult Multiplicar = new Mult();
            Div Dividir = new Div();
            

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