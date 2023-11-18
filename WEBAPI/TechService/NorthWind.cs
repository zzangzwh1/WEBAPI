using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;
using System.Data;
using WEBAPI.Models;
namespace WEBAPI.TechService
{
    public class NorthWind
    {
        public string connectionString = @"Persist Security Info=False; Server=dev1.baist.ca; Database=Northwind; User Id=wcho2; password=Whdnjsgur1!; ";
        public List<GetNorthwindCustomers> GetCustomers()
        {
            List<GetNorthwindCustomers> getCustomers = new List<GetNorthwindCustomers>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("wcho2.GetNorthwindCustomers", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    GetNorthwindCustomers customers = new GetNorthwindCustomers();
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {

                                        string columnValue = reader[i].ToString();
                                        //string result =

                                        // Check if the value is DBNull.Value or an empty string, and replace it with "NULL"
                                        if (DBNull.Value.Equals(reader[i]) || string.IsNullOrEmpty(columnValue))
                                        {
                                            columnValue = "NULL";
                                        }


                                        switch (i)
                                        {
                                            case 0:
                                                customers.CustomerID = columnValue;
                                                break;
                                            case 1:
                                                customers.CompanyName = columnValue;
                                                break;
                                            case 2:
                                                customers.ContactName = columnValue;
                                                break;
                                            case 3:
                                                customers.ContactTitle = columnValue;
                                                break;
                                            case 4:
                                                customers.Address = columnValue;
                                                break;
                                            case 5:
                                                customers.City = columnValue;
                                                break;
                                            case 6:
                                                customers.Region = columnValue;
                                                break;
                                            case 7:
                                                customers.PostalCode = columnValue;
                                                break;
                                            case 8:
                                                customers.Country = columnValue;
                                                break;
                                            case 9:
                                                customers.Phone = columnValue;
                                                break;
                                            case 10:
                                                customers.Fax = columnValue;
                                                break;


                                        }
                                        getCustomers.Add(customers);
                                    }




                                }

                            }
                            else
                            {
                                //getCustomers = null;
                                Console.WriteLine("No Items Exists!");
                            }
                            reader.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Occurred {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }

            return getCustomers;
        }


        public GetNorthwindCustomers GetCustomer(string customerID)
        {
            GetNorthwindCustomers getCustomer = new GetNorthwindCustomers();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("wcho2.GetNorthwindCustomer", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CustomerID", customerID).SqlDbType = SqlDbType.NChar;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {

                                        string columnValue = reader[i].ToString();
                                        //string result =

                                        // Check if the value is DBNull.Value or an empty string, and replace it with "NULL"
                                        if (DBNull.Value.Equals(reader[i]) || string.IsNullOrEmpty(columnValue))
                                        {
                                            columnValue = "NULL";
                                        }


                                        switch (i)
                                        {
                                            case 0:
                                                getCustomer.CustomerID = columnValue;
                                                break;
                                            case 1:
                                                getCustomer.CompanyName = columnValue;
                                                break;
                                            case 2:
                                                getCustomer.ContactName = columnValue;
                                                break;
                                            case 3:
                                                getCustomer.ContactTitle = columnValue;
                                                break;
                                            case 4:
                                                getCustomer.Address = columnValue;
                                                break;
                                            case 5:
                                                getCustomer.City = columnValue;
                                                break;
                                            case 6:
                                                getCustomer.Region = columnValue;
                                                break;
                                            case 7:
                                                getCustomer.PostalCode = columnValue;
                                                break;
                                            case 8:
                                                getCustomer.Country = columnValue;
                                                break;
                                            case 9:
                                                getCustomer.Phone = columnValue;
                                                break;
                                            case 10:
                                                getCustomer.Fax = columnValue;
                                                break;


                                        }
                                    }



                                }

                            }
                            else
                            {
                               // getCustomer = null;
                                Console.WriteLine("No Items Exists!");
                            }
                            reader.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Occurred {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }

            return getCustomer;
        }

    }
}
