using System;

namespace PPOO
{
    public class Soma:Inputs
    {
        
        public void Somcount(){
            Dados();
            double result=n1+n2;
            Console.WriteLine("{0} + {1} = {2}",n1,n2,result);
        }
    }
}