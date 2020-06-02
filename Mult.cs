using System;
namespace PPOO
{
    public class Mult:Inputs
    {
        public void Multcount(){
            Dados();
            double r = n1*n2;
            Console.WriteLine("{0} x {1} = {2}",n1,n2,r);
        } 
    }
}