using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    interface IOrderService
    {
        void Order(Gamer gamer);
        void CampaignOrder(Gamer gamer, Campaign campaign);
    }
}
