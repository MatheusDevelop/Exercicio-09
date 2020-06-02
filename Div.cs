using System;

namespace PPOO
{
    public class Div:Inputs
    {
        
        // Este metodo é chamado por outra classe , por isso public
        public void Divcount(){
            Dados();
            double result=n1/n2;
            Console.WriteLine("{0} / {1} = {2}",n1,n2,result);
        }
    }
}