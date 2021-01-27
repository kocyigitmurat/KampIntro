using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService validationService;

        public GamerManager(IUserValidationService validationService)
        {
            this.validationService = validationService;
        }

        public void Add(Gamer gamer)
        {
            if (this.validationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt eklendi");
            } else
            {
                Console.WriteLine("Kullanıcı doğrulanamadı");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
