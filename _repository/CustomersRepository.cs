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
            throw new NotImplementedException();
        }

        public void Delete(CustomersModel customersModel)
        {
            throw new NotImplementedException();
        }

        public void Edit(CustomersModel customersModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomersModel> GetAll()
        {
            var customersList = new List<CustomersModel>();
            using (var connection = new SqlConnection(connectString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customers ORDER BY Customers DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Pay_Mode_Id"];
                        customersModel.Firt_name = reader["Customers_FirtName"].ToString();
                        customersModel.Last_name = reader["Customers_LastName"].ToString();
                        customersModel.Document = reader["Customers_Document"].ToString();
                        customersModel.Address = reader["Customers_Address"].ToString();
                        customersModel.Bithrday = reader["Customers_Bithrday"].ToString();
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
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = customersFirstName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Pay_Mode_Id"];
                        customersModel.Last_name = reader["Pay_Mode_Name"].ToString();
                        customersModel.Firt_name = reader["Pay_Mode_Observation"].ToString();
                        customersList.Add(customersModel);
                    }
                }
            }
            return customersList;
    }
    
    }
}
