using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloMVCApp.DAL;
using HelloMVCApp.Models;

namespace HelloMVCApp.BLL
{
    public class ItemManager
    {
        ItemGateway itemGateway = new ItemGateway();
        public bool Save(Item item)
        {
            return itemGateway.Save(item)>0;
        }

        public List<Item> GettAll(int id)
        {
            return itemGateway.GetAllbyId(id);
        }
    }
}