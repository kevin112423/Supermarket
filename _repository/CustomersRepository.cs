using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.model;
using System.Data;

namespace Supermarket_mvp._repository
{
    internal class CustomersRepository : BaseRepository, ICustomersRepository
    {
        public CustomersRepository(string connectionString)
        {
            this.connectString = connectionString;
        }

        public void Add(CustomersModel customersModel)
        {
            using (var connection = new SqlConnection(connectString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customers VALUES (@Lastname, @Firstname, @Doc_num, @Address, @Phone, @Email, @Birtday   )";
                command.Parameters.Add("@Lastname", SqlDbType.NVarChar).Value = customersModel.Last_name;
                command.Parameters.Add("@Firstname", SqlDbType.NVarChar).Value = customersModel.First_name;
                command.Parameters.Add("@Doc_num", SqlDbType.NVarChar).Value = customersModel.Doc_num;
                command.Parameters.Add("@Address" , SqlDbType.NVarChar).Value=customersModel.Address;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value=customersModel.Phone;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = customersModel.Email;
                command.Parameters.Add("@Birtday", SqlDbType.NVarChar).Value = customersModel.Birtday;

                command.ExecuteNonQuery();
            }
        }

        public void Delete(CustomersModel customersModel)
        {

            using (var connection = new SqlConnection(connectString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customers WHERE Customers_id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = customersModel.Id;

                command.ExecuteNonQuery();
            }
        }

        public void Edit(CustomersModel customersModel)
        {
            using (var connection = new SqlConnection(connectString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customers
                                      SET Customers_LastName =@Lastname
                                      Customers_FirstName =@Firstname
                                      Customers_Doc_num  = @Doc_num
                                      Customers_Address =@Address
                                      Customers_Phone =@Phone
                                      Customers_Email = @Email
                                      Customers_Birtday = @Birtday
                                      WHERE Customers_Id = @Id"; 
                command.Parameters.Add("@Lastname", SqlDbType.NVarChar).Value = customersModel.Last_name;
                command.Parameters.Add("@Firstname", SqlDbType.NVarChar).Value = customersModel.First_name;
                command.Parameters.Add("@Doc_num", SqlDbType.NVarChar).Value = customersModel.Doc_num;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = customersModel.Address;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = customersModel.Phone;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = customersModel.Email;
                command.Parameters.Add("@Birtday", SqlDbType.NVarChar).Value = customersModel.Birtday;

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CustomersModel> GetAll()
        {
            var customersList = new List<CustomersModel>();
            using (var connection = new SqlConnection(connectString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customers ORDER BY Customers_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Customers_Id"];
                        customersModel.First_name = reader["Customers_FirstName"].ToString();
                        customersModel.Last_name = reader["Customers_LastName"].ToString();
                        customersModel.Doc_num = reader["Customers_Doc_num"].ToString();
                        customersModel.Address = reader["Customers_Address"].ToString();
                        customersModel.Birtday = reader["Customers_Birtday"].ToString();
                        customersModel.Email = reader["Customers_Email"].ToString();
                        customersModel.Phone = reader["Customers_Phone"].ToString();
                        customersList.Add(customersModel);
                    }
                }
            }
            return customersList;
        }

        public IEnumerable<CustomersModel> GetByValue(string value)
        {
            var customersList = new List<CustomersModel>();
            int customersId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customersLastName = value;
            string customersFirstName = value;
            using (var connection = new SqlConnection(connectString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customers
                WHERE Customers_Id=@id or Customers_LastName LIKE @Lastname+ '%'
                ORDER By Customers_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customersId;
                command.Parameters.Add("@Lastname", SqlDbType.NVarChar).Value = customersLastName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Customers_Id"];
                        customersModel.Last_name = reader["Customers_Lastname"].ToString();
                        customersList.Add(customersModel);
                    }
                }
            }
            return customersList;
    }
    
    }
}
