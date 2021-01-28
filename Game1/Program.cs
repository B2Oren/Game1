using System;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { 
                FirstName = "Büşra",
                LastName = "ÖREN", 
                Id = 1,
                IdentityNumber = 112233,
                BirthYear=1993
            });

           
        }
    }
}
