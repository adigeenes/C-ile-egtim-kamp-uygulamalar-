using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DERS9_VERİTANANIİSLEMLERİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///ADO.net
            Console.WriteLine("***** c# Veri Tabanlı Ürün-Kategori Bilgi Sistemi ****");
            Console.WriteLine();
            Console.WriteLine();
            string tableNumber;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-ÇıkışYap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz");
            tableNumber=Console.ReadLine();
            Console.WriteLine("-----------------------------------------------");

   SqlConnection connection = new SqlConnection("Data Source=LAPTOP-LKPKUF2A\\SQLEXPRESS;Initial Catalog=EgtimKampiDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            

            connection.Open();
            SqlCommand command = new SqlCommand("select * from TblCategory",connection);
             SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray) 
                { 
                 Console.Write(item.ToString());
                
                }
                    
            Console.WriteLine();
                    
            }

            Console.Read();



        }
    }
}
