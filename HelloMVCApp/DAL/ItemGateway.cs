using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using HelloMVCApp.Models;

namespace HelloMVCApp.DAL
{
    public class ItemGateway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["DBdemo"].ConnectionString;
        public int Save(Item item)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            int rowAffected = 0;
            string query = "INSERT INTO t_ItemEntry(ItemName,UnitPrice) VALUES('" +item.ItemName + "','" + item.UnitPrice + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        internal List<Item> GetAllbyId(int Id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT *FROM t_ItemEntry WHERE Id='" +Id + "'";
            SqlCommand command = new SqlCommand(query, connection);
            Item aItem = null;
            List<Item> aiteList=new List<Item>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    aItem = new Item();
                    aItem.ItemName = reader["ItemName"].ToString();
                    aItem.UnitPrice = Convert.ToDecimal(reader["UnitPrice"].ToString());
                    aiteList.Add(aItem);
                }
                reader.Close();
            }
            connection.Close();
            return aiteList;
        }
    }
}