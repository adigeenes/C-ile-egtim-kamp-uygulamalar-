﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




     

namespace DERS_10_VERİTANİ_İŞLEMLERİ_CRUD
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("***** Menü Sipariş İşlem Paneli");
                Console.WriteLine();
                Console.WriteLine("----------------------------");

            #region Kategori Ekleme İşlemi
           // Console.Write("Eklemek istediğiniz kategori adı:: ");
            //string categoryName = Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-LKPKUF2A\\SQLEXPRESS;Initial Catalog=EgtimKampiDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",
            //    connection);

            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi");
            #endregion
            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-LKPKUF2A\\SQLEXPRESS;Initial Catalog=EgtimKampiDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Başarıyla Eklendi");
            #endregion
            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-LKPKUF2A\\SQLEXPRESS;Initial Catalog=EgtimKampiDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows) 
            //{

            //    foreach(var item in row.ItemArray)

            //    {
            //        Console.Write(item.ToString() + " ");

            //        Console.WriteLine() ;

            //    }   

            //    }



            //connection.Close();



            #endregion
            #region Ürün Silme İşlemi
            //Console.Write("Silinecek Ürün Id: ");
            //int ProductId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = LAPTOP-LKPKUF2A;initial Catalog = EgtimKampiDb;integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from TblProduct Where ProductId = @ProductId", connection);
            //command.Parameters.AddWithValue("ProductId", ProductId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi tamamlandı");

            #endregion
            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source =LAPTOP-LKPKUF2A\\SQLEXPRESS;initial Catalog = EgtimKampiDb;integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct set ProductName = @productName,ProductPrice=@productPrice where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Güncelleme İşlemi Başarılı");


            #endregion


            Console.Read();



        }
        }
    }



