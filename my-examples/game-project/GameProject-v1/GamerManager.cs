using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_v1
{
    class GamerManager:IEdevletService
    {
        public void Adduser()
        {
            CheckUserFromEdevlet();
            Console.WriteLine("Game manager ile site kullanıcısı eklendi");
        }

        public void CheckUserFromEdevlet()
        {
            Console.WriteLine("e devletten kullanıcı kontrol edildi");
        }


    }
}
