namespace DependencieInjectionCsharp
{
    public class TasitKredisi : ICreditManager
    {
        public void BasvuruYap()
        {
            System.Console.WriteLine("tasit kreedisi basvurusu yapıldı");
        }
    }
}