using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopBrigeProject;

namespace ShopBrigeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            char s;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("========================================================================================================================");
                Shop.CreateConnection();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t *********************************LOGIN FORM *************************** ");
                Console.Write("\n");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t\t\t\t      Enter UserName: ");
                string username = Console.ReadLine();
                Console.Write("\t\t\t\t      Enter Password:");
                string pass = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;

                if (Shop.Validation(username, pass) == true)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\t\t\t\t=============================MAIN MENU===============================");
                    Console.WriteLine();


                    // -----------CRUD Operation-------


                    Console.WriteLine("\t\t\t\t\t\t1.SEARCH PRODUCT"); //READ
                    Console.WriteLine("\t\t\t\t\t\t2.INSERT PRODUCT"); //CREATE
                    Console.WriteLine("\t\t\t\t\t\t3.UPDATING PRODUCT"); //UPDATE
                    Console.WriteLine("\t\t\t\t\t\t4.DELETING PRODUCT"); //DELETE
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t ENTER YOUR CHOICE:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    int ProductId;
                    string ProductName;
                    string CompanyName;
                    string DescriptionName;
                    float Price;
                    int ProductRate;
                    char ProductStatus;
                    string ProductSize;

                    switch (choice)
                    {
                        //serach
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\t\t ENTER PRODUCT NAME = ");
                            Console.ForegroundColor = ConsoleColor.White;
                            ProductName = Console.ReadLine();
                            Shop.Search(ProductName);
                            break;

                        //insert
                        case 2:
                            Console.WriteLine("Enter the name of ProductName");
                            ProductName = Console.ReadLine();
                            Console.WriteLine("Enter the CompanyName");
                            CompanyName = Console.ReadLine();
                            Console.WriteLine("Enter the DescriptionName");
                            DescriptionName = Console.ReadLine();
                            Console.WriteLine("Enter the Price");
                            Price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the  ProductRate");
                            ProductRate = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the ProductStatus");
                            ProductStatus = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine("Enter the ProductSize");
                            ProductSize = Console.ReadLine();
                            Shop.AddProduct(ProductName, CompanyName, DescriptionName, Price, ProductRate, ProductStatus, ProductSize);
                            break;

                        case 3:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\t\t\t\t*************************************************************************");
                            Console.WriteLine("\t\t\t\t\t\ta.Update ProductName");
                            Console.WriteLine("\t\t\t\t\t\tb.Update CompanyName ");
                            Console.WriteLine("\t\t\t\t\t\tc.Update DescriptionName");
                            Console.WriteLine("\t\t\t\t\t\td.Update Price");
                            Console.WriteLine("\t\t\t\t\t\te.Update ProductRate");
                            Console.WriteLine("\t\t\t\t\t\tf.Update ProductStatus");
                            Console.WriteLine("\t\t\t\t\t\tg.Update ProductSize");

                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t*************************************************************************");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.Write("\t\t\t\tEnter your choice=");
                            char c = Convert.ToChar(Console.ReadLine());
                            switch (c)
                            {
                                //ProductName
                                case 'a':
                                    Console.WriteLine("Enter the new name of Product");
                                    ProductName = Console.ReadLine();
                                    Console.WriteLine("Enter the id Product");
                                    ProductId = Convert.ToInt32(Console.ReadLine());
                                    Shop.UpdateName(ProductName, ProductId);
                                    break;

                                //CompanyName
                                case 'b':
                                    Console.WriteLine("Enter the new CompanyName of Product");
                                    CompanyName = Console.ReadLine();
                                    Console.WriteLine("Enter the id Product");
                                    ProductId = Convert.ToInt32(Console.ReadLine());
                                    Shop.UpdateCompanyName(CompanyName, ProductId);
                                    break;

                                //Description
                                case 'c':
                                    Console.WriteLine("Enter the new Description of Product");
                                    DescriptionName = Console.ReadLine();
                                    Console.WriteLine("Enter the id Product");
                                    ProductId = Convert.ToInt32(Console.ReadLine());
                                    Shop.DescriptionName(DescriptionName, ProductId);
                                    break;

                                // Price
                                case 'd':
                                    Console.WriteLine("Enter the new Price of Product");
                                    Price = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter the id Product");
                                    ProductId = Convert.ToInt32(Console.ReadLine());
                                    Shop.UpdatePrice(Price, ProductId);
                                    break;

                                //ProductRate
                                case 'e':
                                    Console.WriteLine("Enter the new ProductRate of Product");
                                    ProductRate = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter the id Product");
                                    ProductId = Convert.ToInt32(Console.ReadLine());
                                    Shop.UpdateProductRate(ProductRate, ProductId);
                                    break;

                                //productstatus
                                case 'f':
                                    Console.WriteLine("Enter the new ProductStatus of Product");
                                    ProductStatus = Convert.ToChar(Console.ReadLine());
                                    Console.WriteLine("Enter the id Product");
                                    ProductId = Convert.ToInt32(Console.ReadLine());
                                    Shop.UpdateProductStatus(ProductStatus, ProductId);
                                    break;

                                //productSize
                                case 'g':
                                    Console.WriteLine("Enter the new ProductSize of Product");
                                    ProductSize = Console.ReadLine();
                                    Console.WriteLine("Enter the id Product");
                                    ProductId = Convert.ToInt32(Console.ReadLine());
                                    Shop.UpdateProductSize(ProductSize, ProductId);
                                    break;
                                default:
                                    Console.WriteLine("Invalid Choice");
                                    break;

                            }
                            break;

                        //to delete Product
                        case 4:
                            Console.WriteLine("Enter the name of Product");
                            ProductName = Console.ReadLine();
                            Shop.DeleteProduct(ProductName);
                            break;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;

                    }
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to continue press Y or N");
                s = Convert.ToChar(Console.ReadLine());
            } while (s != 'N');

        }
    }

}

