using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloMVCApp.BLL;
using HelloMVCApp.Models;

namespace HelloMVCApp.Controllers
{
    public class ItemController : Controller
    {
        ItemManager itemManager = new ItemManager();
        public string Save(Item item)
        {

            string message = "";

            if ( SaveItem(item))
            {
                message = "Saved Successfully!" +" Item Name:" +item.ItemName+" Unit Price: "+item.UnitPrice;
            }

            return message;
        }


        public string Find(int id)
        {
            var item = GetAll(id).FirstOrDefault(i=> i.Id == id);

            string itemMessage = "No Item Found!";
            if (item!=null)
            {
                itemMessage = "Item Name: " + item.ItemName + " , Unit Price: " + item.UnitPrice;
            }

            return itemMessage;

        }



        private bool SaveItem(Item item)
        {
            if (item.ItemName!=null && item.UnitPrice!=null)
            {
                return itemManager.Save(item);
            }
            else
            {
                return false;
            }
           
        }


        public List<Item> GetAll(int id)
        {

            return itemManager.GettAll(id);
            //return new List<Item>()
            //{
            //    new Item() {Id = 1, ItemName = "Laptop", UnitPrice = 15454},
            //    new Item() {Id = 2, ItemName = "Monitor", UnitPrice = 9000},
            //    new Item() {Id = 3, ItemName = "CPU", UnitPrice = 25000},
            //    new Item() {Id = 4, ItemName = "Mouse", UnitPrice = 400},
            //    new Item() {Id = 5, ItemName = "KeyBoard", UnitPrice = 450},
            //    new Item() {Id = 6, ItemName = "Smartphone", UnitPrice = 8000}

            //};
        }
    }
}