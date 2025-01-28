using System;
using System.Collections.Generic;
using System.Text;

namespace DependencieInjectionCsharp
{
    public class IhtiyacKredisi : ICreditManager
    {
        public void BasvuruYap()
        {
            Console.WriteLine("ihtiyaç kredisi basvuru yap fonksyonundan hesaplandı.");
        }
        
    }
}
