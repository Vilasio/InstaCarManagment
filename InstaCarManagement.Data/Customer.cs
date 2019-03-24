using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaCarManagement.Data
{
    public class Customer
    {
        //----------------------------------------------------------------------------------------------
        //Const
        //----------------------------------------------------------------------------------------------
        #region const
        private const string TABLE = "InstaCar.customer";
        private const string COLUMN = "customer_id, name, familyname, street, housenr, postcode, city";
        #endregion
        //----------------------------------------------------------------------------------------------
        //PrivateMember
        //----------------------------------------------------------------------------------------------
        #region privateMember
        private NpgsqlConnection connection = null;
        #endregion

        //----------------------------------------------------------------------------------------------
        //Constructor
        //----------------------------------------------------------------------------------------------
        #region constructor
        public Customer()
        {

        }

        public Customer(NpgsqlConnection connection)
        {
            this.connection = connection;
        }
        #endregion
        //----------------------------------------------------------------------------------------------
        //Property
        //----------------------------------------------------------------------------------------------
        #region property
        public long? CustomerId { get; set; }
        public string Name { get; set; }
        public string Familyname { get; set; }
        public string Street { get; set; }
        public long? HouseNr { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }


        #endregion
        //----------------------------------------------------------------------------------------------
        //Static
        //----------------------------------------------------------------------------------------------
        #region static

        public static List<Customer> GetAllCustomer(NpgsqlConnection connection)
        {
            List<Customer> allCustomers = new List<Customer>();
            Customer customer = null;
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = $"Select * from {TABLE};";

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                allCustomers.Add(
                    customer = new Customer(connection)
                    {
                        CustomerId = reader.GetInt64(0),
                        Name = reader.IsDBNull(1) ? null : reader.GetString(1),
                        Familyname = reader.IsDBNull(2) ? null : reader.GetString(2),
                        Street = reader.IsDBNull(3) ? null : reader.GetString(3),
                        HouseNr = reader.IsDBNull(4) ? 0 : reader.GetInt64(4),
                        Postcode = reader.IsDBNull(5) ? null : reader.GetString(5),
                        City = reader.IsDBNull(6) ? null : reader.GetString(6)
                    }
                );
            }
            reader.Close();
            return allCustomers;
        }

        static Customer GetSpecificCustomer(NpgsqlConnection connection, int key)
        { 
            Customer customer = null;
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = $"Select * from {TABLE} where customer_id = :id;";
            command.Parameters.AddWithValue("id", key);
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                customer = new Customer(connection)
                {
                    CustomerId = reader.GetInt64(0),
                    Name = reader.IsDBNull(1) ? null : reader.GetString(1),
                    Familyname = reader.IsDBNull(2) ? null : reader.GetString(2),
                    Street = reader.IsDBNull(3) ? null : reader.GetString(3),
                    HouseNr = reader.IsDBNull(4) ? 0 : reader.GetInt64(4),
                    Postcode = reader.IsDBNull(5) ? null : reader.GetString(5),
                    City = reader.IsDBNull(6) ? null : reader.GetString(6)
                };
            }
            reader.Close();
            return customer;
        }
        #endregion
        //----------------------------------------------------------------------------------------------
        //Public
        //----------------------------------------------------------------------------------------------
        #region public
        public int Save()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = this.connection;
            if (this.CustomerId.HasValue)
            {

                    command.CommandText =
                    $"update {TABLE} set  name = :na, familyname = :fn, street = :st, housenr = :hn, postcode = :pc, city = :ci where customer_id = :cid";
                

            }
            else
            {
                command.CommandText = $"select nextval('{TABLE}_seq')";
                this.CustomerId = (long?)command.ExecuteScalar();
                command.CommandText = $" insert into {TABLE} (customer_id, name, familyname, street, housenr, postcode, city)" +
                    $" values(:cid, :na, :fn, :st, :hn, :pc, :ci)";
            }
            command.Parameters.AddWithValue("cid", this.CustomerId.Value);
            command.Parameters.AddWithValue("na", String.IsNullOrEmpty(this.Name) ? (object)DBNull.Value : this.Name);
            command.Parameters.AddWithValue("fn", String.IsNullOrEmpty(this.Familyname) ? (object)DBNull.Value : this.Familyname);
            command.Parameters.AddWithValue("st", String.IsNullOrEmpty(this.Street) ? (object)DBNull.Value : this.Street);
            command.Parameters.AddWithValue("hn", this.HouseNr.HasValue ? (object)this.HouseNr.Value : 3);
            command.Parameters.AddWithValue("pc", String.IsNullOrEmpty(this.Postcode) ? (object)DBNull.Value : this.Postcode);
            command.Parameters.AddWithValue("ci", String.IsNullOrEmpty(this.City) ? (object)DBNull.Value : this.City);

            return command.ExecuteNonQuery();
        }
        #endregion
        //----------------------------------------------------------------------------------------------
        //Private
        //----------------------------------------------------------------------------------------------
        #region private

        #endregion
    }
}
