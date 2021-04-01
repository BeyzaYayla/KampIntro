using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int DiscountPercentage { get; set; }
    }
}
