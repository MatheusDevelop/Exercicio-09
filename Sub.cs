using System;

namespace PPOO
{
    public class Sub:Inputs
    {
        // Este metodo é chamado por outra classe , por isso public
        public void Subcount(){
            Dados();
            double r = n1-n2;
            Console.WriteLine("{0} - {1} = {2}",n1,n2,r);
        }
    }
}