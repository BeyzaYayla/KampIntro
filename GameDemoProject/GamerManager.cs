using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Succesfully registered");
            }
            else
            {
                Console.WriteLine("Validation failed. Registeration failed");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Succesfully deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Succesfully updated");
        }
    }
}
