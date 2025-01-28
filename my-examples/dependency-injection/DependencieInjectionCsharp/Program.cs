using System;
using System.Collections.Generic;

namespace DependencieInjectionCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ICreditManager ihtiyacKredisi = new IhtiyacKredisi();

            ICreditManager tasitKredisi = new TasitKredisi();

            BasvuruManager basvuruManager = new BasvuruManager();

            //basvuruManager.BasvuruYap(ihtiyacKredisi);
            basvuruManager.KrediGetir(new List<ICreditManager> { ihtiyacKredisi, tasitKredisi });
        }
    }
}
