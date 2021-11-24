using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBrigeProject
{
    public class Shop
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;

        public static void CreateConnection()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*******************************************CONNECTED TO THE DATABASE*************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=====================================================================================================================");
            Console.WriteLine("\n");
            string constr = "Data source=LAPTOP-RL6IFAP1;initial catalog=Product;user=sa;password=Pooja@2708";
            con = new SqlConnection();

            con.ConnectionString = constr;
            //  con.Open();

        }
        public static bool Validation(string username, string password)
        {
            if (username == "Pooja" && password == "Pass@123")
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n");
                Console.WriteLine("\t\t\t\t      Login Successfull!!!!!!!!");
                return true;
            }
            else
            {
                return false;

            }

        }
        //search method
        public static void Search(string ProductName)
        {
            con.Open();

            string query = "select * from Product where Productname='" + ProductName + "'";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            Console.WriteLine("====================================================================");
            Console.WriteLine();
            Console.Write(" Product Deatails");
            while (dr.Read())
            {
                Console.WriteLine();
                Console.WriteLine("{0}", dr[0]);
                // Console.Write("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n", dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7]);
            }
            Console.WriteLine();
            Console.WriteLine("=====================================================================");
            con.Close();

        }
        //insert method
        public static void AddProduct(string ProductName, string CompanyName, string DescriptionName, float Price, int ProductRate, char ProductStatus, string ProductSize)
        {
            // con.Open();
            string query = "insert into Product values ('" + ProductName + "','" + CompanyName + "','" + DescriptionName + "','" + Price + "','" + ProductRate + "','" + ProductStatus + "','" + ProductSize + "')";
            cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error";
                msg += ex.Message;

            }
            finally
            {
                Console.WriteLine("Your Data Inserted Successfully");
                con.Close();
            }

        }
        //update method
        public static void UpdateName(string ProductName, int Productid)
        {
            con.Open();
            string query = "Update Product set  ProductName ='" + ProductName + "'where ProductID = " + Productid + "";
            cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Update Error";
                msg += ex.Message;
            }
            finally
            {
                Console.WriteLine("Your ProductName updated Successfully");
                con.Close();
            }
        }

        public static void UpdateCompanyName(string CompanyName, int Productid)
        {
            con.Open();
            string query = "Update Product set  CompanyName ='" + CompanyName + "'where ProductID = " + Productid + "";
            cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Update Error";
                msg += ex.Message;
            }
            finally
            {
                Console.WriteLine("Your CompanyName updated Successfully");
                con.Close();
            }
        }

        public static void DescriptionName(string DescriptionName, int Productid)
        {
            con.Open();
            string query = "Update Product set  DescriptionName ='" + DescriptionName + "'where ProductID = " + Productid + "";
            cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Update Error";
                msg += ex.Message;
            }
            finally
            {
                Console.WriteLine("Your DescriptionName updated Successfully");
                con.Close();
            }
        }

        public static void UpdatePrice(float Price, int Productid)
        {
            con.Open();
            string query = "Update Product set  Price = " + Price + "where ProductID = " + Productid + "";
            cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Update Error";
                msg += ex.Message;
            }
            finally
            {
                Console.WriteLine("Your Price updated Successfully");
                con.Close();
            }
        }

        public static void UpdateProductRate(int ProductRate, int Productid)
        {
            con.Open();
            string query = "Update Product set  ProductRate = " + ProductRate + "where ProductID = " + Productid + "";
            cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Update Error";
                msg += ex.Message;
            }
            finally
            {
                Console.WriteLine("Your ProductRate updated Successfully");
                con.Close();
            }
        }
        public static void UpdateProductStatus(char ProductStatus, int Productid)
        {
            con.Open();
            string query = "Update Product set  ProductStatus ='" + ProductStatus + "'where ProductID = " + Productid + "";
            cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Update Error";
                msg += ex.Message;
            }
            finally
            {
                Console.WriteLine("Your ProductStatus updated Successfully");
                con.Close();
            }
        }

        public static void UpdateProductSize(string ProductSize, int Productid)
        {
            con.Open();
            string query = "Update Product set  ProductSize ='" + ProductSize + "'where ProductID = " + Productid + "";
            cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Update Error";
                msg += ex.Message;
            }
            finally
            {
                Console.WriteLine("Your ProductSize updated Successfully");
                con.Close();
            }
        }
        //delete
        public static void DeleteProduct(string ProductName)
        {
            con.Open();
            string query = "delete from Product where ProductName=" + ProductName + "";
            cmd = new SqlCommand(query, con);
            // cmd.ExecuteNonQuery();

            try
            {

                cmd.ExecuteNonQuery();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Delete Error";
                msg += ex.Message;

            }
            finally
            {
                Console.WriteLine(" Product Deleted Successfully");
                con.Close();
            }

        }
    }
}
