using System;
using System.Threading;

namespace Delaporte
{
    class Program
    {
        static void Main(string[] args)
        {

            double sommeTotal = 100;
            int flag = 0;
            double p = 0;
            double f = 0;
            double n = 0;
            double minMise = 0;
            double ftot = 0;

            Console.WriteLine("Indiquer la probabilité de gagner");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indiquer la valeur de la mise");
            minMise = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indiquer le pourcentage que vous voulez garder");
            f = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.WriteLine("Indiquer les nombres de fois à jouer");
            n = Convert.ToDouble(Console.ReadLine());

            while (minMise > sommeTotal || n != flag  ) 
            {
                
                Random rd = new Random();
                flag += 1;
                int rand_num = rd.Next(1, 100);
                if (p >= rand_num)
                {
                    sommeTotal = sommeTotal + minMise;
                    sommeTotal = sommeTotal - ((1-f) * 100);
                    ftot += f;
                    Console.WriteLine("vous avez gagné " + sommeTotal);
                }
                else
                {
                    sommeTotal = sommeTotal - minMise;
                    Console.WriteLine("vous avez perdu BRUH " + sommeTotal);
                }

                Thread.Sleep(1);
                if(sommeTotal == 0)
                {
                    break;
                }

                

            } 
            Console.WriteLine("nombre de jeu " + flag + " montant gagné " + sommeTotal + " Montant de côter" + ftot);
            Console.ReadLine();

        }
    }
}
