using System;

namespace lab3ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Ex 5
            Arpsod adoră două lucruri: matematica și clătitele bunicii sale. 
            Într-o zi, aceasta s-a apucat să prepare clătite. 
            Arpsod mănâncă toate clătitele începând de la a N-a clătită preparată,
            până la a M-a clătită preparată (inclusiv N și M). 
            Pentru că el vrea să mănânce clătite cu diferite umpluturi și-a făcut 
            următoarea regulă:
            - Dacă numărul de ordine al clătitei este prim atunci aceasta va fi cu ciocolată.
            - Dacă numărul de ordine este pătrat perfect sau cub perfect aceasta va fi cu gem.
            - Dacă suma divizorilor numărului este egală cu însuși numărul de ordine atunci aceasta va fi cu
            înghețată. (se iau în considerare toți divizorii în afară de numărul în sine, inclusiv 1).
            - Dacă niciuna dintre condițiile de mai sus nu este îndeplinită, pentru cele cu numărul de ordine
            par, clătita va fi cu zahar, iar pentru numărul de ordine impar, clătita va fi simplă.”
            • Cerința
            - Cunoscându-se N și M, numere naturale, să se determine câte clătite a mâncat Arpsod în total și
            numărul de clătite din fiecare tip. A
            • Indicii
            1. iteratorul unui for nu incepe neaparat de la 1 ☺
            2. folositi functii: extrageti operatiile matematice complicate asupra intregilor in functii. Veti
            simplifica astfel partea de logica.
             */

            Console.WriteLine("Numerul n=");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Numerul m=");
            int m = int.Parse(Console.ReadLine());

            int chocolate = 0;
            static bool numberIsPrim(int n)
            {
                if (n < 2)
                {
                    return false;
                }

                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            int jam = 0;
            // Console.WriteLine($"Numerul {n} este patrat perfect: {isPerfectSquare(n)}");
            static bool isPerfectSquare(int n)
            {
                var restNumber = Math.Sqrt(n) % 1;
                if (restNumber != 0)
                {
                    return false;
                }
                return true;
            }

           // Console.WriteLine($"Numerul {n} este cub perfect: {isPerfectCube(n)}");

            static bool isPerfectCube(int n)
            {
                for (int i = 2; i <= n; i++)
                {
                    var valuePow = Math.Pow(i, 3);
                    if (valuePow == n)
                    {
                        return true;
                    }
                }
                return false;
            }
            int iceCream = 0;
            static int sumDivisors(int n)
            {
                var sumDiv = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        sumDiv += i;
                    }
                }
                return sumDiv;
            }

            int simple = 0;
            int sugar = 0;//pt par
            //Console.WriteLine($"Numerul {n} este par: {isEvenNumber(n)}");
            static bool isEvenNumber(int n)
            {
                if (n % 2 == 0)
                {
                    return true;
                }
                return false;
            }

            for (int i = n; i <= m; i++)
            {
                if (numberIsPrim(i))
                {
                    chocolate++;
                }
                else if (isPerfectSquare(i) || isPerfectCube(i))
                {
                    jam++;
                }
                else if (sumDivisors(n) == i)
                {
                    iceCream++;
                }
                else if (isEvenNumber(i) == true)
                {
                    sugar++;
                }
                else if (isEvenNumber(i) == false)
                {
                    simple++;
                }
            }

            Console.WriteLine($"Total clatite cu ciocolata: {chocolate}");
            Console.WriteLine($"Total clatite cu gem: {jam}");
            Console.WriteLine($"Total clatite cu înghețată: {iceCream}");
            Console.WriteLine($"Total clatite cu zahar: {sugar}");
            Console.WriteLine($"Total clatite simple: {simple}");
            var totalPanks = chocolate + jam + iceCream + sugar + simple;
            Console.WriteLine($"Total clatite: {totalPanks}");
        }
    }
}
