using System;
using System.Collections.Generic;
using System.Text;

namespace DependencieInjectionCsharp
{
    public class BasvuruManager
    {
        public void BasvuruYap(ICreditManager kredi)
        {
            kredi.BasvuruYap();
        }
        public void KrediGetir(List<ICreditManager> credits)
        {
            foreach (var item in credits)
            {
                item.BasvuruYap();
            }

        }
    }
}
