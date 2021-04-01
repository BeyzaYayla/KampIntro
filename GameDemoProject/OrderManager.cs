using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class OrderManager : IOrderService
    {
        const double gamePrice = 89.90;

        public void CampaignOrder(Gamer gamer, Campaign campaign)
        {
            double finalPrice = gamePrice - (gamePrice * campaign.DiscountPercentage * 0.01) ;
            Console.WriteLine("Game price: " + finalPrice + "\nOrder completed");
        }

        public void Order(Gamer gamer)
        {
            Console.WriteLine("Game price: "+ gamePrice +"\nOrder completed");
        }
    }
}
