using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enginLİB
{
    class Program
    {
        static void Main(string[] args)
        {
            int kacinciSiradakiHarf;
            List<string> donenBuyuk = new List<string>();
            string[] kucuk = { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z" };
            string[] buyuk = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
            Console.WriteLine("lütfen parçalanacak metni girin");
            string Metin = Console.ReadLine();//metinimiz


            for (int count = 0; count <Metin.Length; count++)
            {
                for (int j = 0; j < 29; j++)
                {
                    if (Metin[count].ToString()== kucuk[j])
                    {
                        donenBuyuk.Add(buyuk[j]);
                    }
                }

            }
            foreach (var item in donenBuyuk)
            {
                Console.Write(item);
                
            }
            Console.WriteLine();
        }
    }
}

