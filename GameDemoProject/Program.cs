using System;

namespace GameDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer { Id = 1, FName = "BEYZA", LName = "YAYLA", BirthYear = 1999, IdentityNumber = 1234567890 };
            gamerManager.Add(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign { Id = 1, CampaignName = "Spring Sale", DiscountPercentage = 35 };
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign1);
            campaignManager.Update(campaign1);

            OrderManager orderManager = new OrderManager();
            orderManager.Order(gamer1);
            orderManager.CampaignOrder(gamer1, campaign1);
        }
    }
}
