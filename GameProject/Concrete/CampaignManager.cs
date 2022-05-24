using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign Added : " + campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Deleted : " + campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign Updated : " + campaign.Name);
        }
    }
}
