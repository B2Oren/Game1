using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager()
        {
        }

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldunuz:");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız:");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kaydınız silindi:");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine( "Kayıt güncellendi: ");
        }
    }
}
