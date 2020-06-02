using System;

namespace PPOO
{
    public class Div:Inputs
    {
        
        public void Divcount(){
            Dados();
            double result=n1/n2;
            Console.WriteLine("{0} / {1} = {2}",n1,n2,result);
        }
    }
}