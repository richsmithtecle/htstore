using Project.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Project.Web.DAL
{
    public class StoreSqlDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["electronics-store"].ConnectionString;

        public List<Products_TVModel> GetAllProducts()
        {
            List<Products_TVModel> TV = new List<Products_TVModel>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM products", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Products_TVModel t = new Products_TVModel();
                        t.Id = Convert.ToInt32(reader["id"]);
                        t.Manufacturer = Convert.ToString(reader["manufacturer"]);
                        t.Model = Convert.ToString(reader["model_number"]);
                        t.ShortDesc = Convert.ToString(reader["short_description"]);
                        t.LongDesc = Convert.ToString(reader["long_description"]);
                        t.Price = Convert.ToDecimal(reader["price"]);
                        t.CategoryId = Convert.ToInt32(reader["category_id"]);
                        t.ProductImage = Convert.ToString(reader["image"]);



                        TV.Add(t);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return TV;
       
        }

        public List<Products_TVModel> GetAllAudio()
        {
            List<Products_TVModel> Audio = new List<Products_TVModel>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * from PRODUCTS where category_id = '2' ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Products_TVModel a = new Products_TVModel();
                        a.Id = Convert.ToInt32(reader["id"]);
                        a.Manufacturer = Convert.ToString(reader["manufacturer"]);
                        a.Model = Convert.ToString(reader["model_number"]);
                        a.ShortDesc = Convert.ToString(reader["short_description"]);
                        a.LongDesc = Convert.ToString(reader["long_description"]);
                        a.Price = Convert.ToDecimal(reader["price"]);
                        a.CategoryId = Convert.ToInt32(reader["category_id"]);
                        a.ProductImage = Convert.ToString(reader["image"]);



                        Audio.Add(a);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return Audio;

        }

        public List<Products_TVModel> GetAllTVs()
        {
            List<Products_TVModel> UHDTV = new List<Products_TVModel>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * from PRODUCTS where category_id = '1' ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Products_TVModel uhd = new Products_TVModel();
                        uhd.Id = Convert.ToInt32(reader["id"]);
                        uhd.Manufacturer = Convert.ToString(reader["manufacturer"]);
                        uhd.Model = Convert.ToString(reader["model_number"]);
                        uhd.ShortDesc = Convert.ToString(reader["short_description"]);
                        uhd.LongDesc = Convert.ToString(reader["long_description"]);
                        uhd.Price = Convert.ToDecimal(reader["price"]);
                        uhd.CategoryId = Convert.ToInt32(reader["category_id"]);
                        uhd.ProductImage = Convert.ToString(reader["image"]);



                        UHDTV.Add(uhd);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return UHDTV;

        }

        public List<Products_TVModel> GetAllFurniture()
        {
            List<Products_TVModel> Furniture = new List<Products_TVModel>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * from PRODUCTS where category_id = '4' ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Products_TVModel f = new Products_TVModel();
                        f.Id = Convert.ToInt32(reader["id"]);
                        f.Manufacturer = Convert.ToString(reader["manufacturer"]);
                        f.Model = Convert.ToString(reader["model_number"]);
                        f.ShortDesc = Convert.ToString(reader["short_description"]);
                        f.LongDesc = Convert.ToString(reader["long_description"]);
                        f.Price = Convert.ToDecimal(reader["price"]);
                        f.CategoryId = Convert.ToInt32(reader["category_id"]);
                        f.ProductImage = Convert.ToString(reader["image"]);



                        Furniture.Add(f);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return Furniture;

        }

        public List<Products_TVModel> GetAllSonos()
        {
            List<Products_TVModel> Sonos = new List<Products_TVModel>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * from PRODUCTS where category_id = '5' ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Products_TVModel s = new Products_TVModel();
                        s.Id = Convert.ToInt32(reader["id"]);
                        s.Manufacturer = Convert.ToString(reader["manufacturer"]);
                        s.Model = Convert.ToString(reader["model_number"]);
                        s.ShortDesc = Convert.ToString(reader["short_description"]);
                        s.LongDesc = Convert.ToString(reader["long_description"]);
                        s.Price = Convert.ToDecimal(reader["price"]);
                        s.CategoryId = Convert.ToInt32(reader["category_id"]);
                        s.ProductImage = Convert.ToString(reader["image"]);



                        Sonos.Add(s);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return Sonos;

        }
    }
}