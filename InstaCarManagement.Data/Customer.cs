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
        private const string COLUMN = "customer_id, name, familyname, street, housenr, postcode, city, email, telefon, iban, bic, nickname";
        private const string COLUMNPW = "customer_id, name, familyname, street, housenr, postcode, city, email, telefon, iban, bic, password, nickname";
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
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }


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
            command.CommandText = $"Select {COLUMN} from {TABLE};";

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
                        City = reader.IsDBNull(6) ? null : reader.GetString(6),
                        Email = reader.IsDBNull(7) ? null : reader.GetString(7),
                        Telefon = reader.IsDBNull(8) ? null : reader.GetString(8),
                        Iban = reader.IsDBNull(9) ? null : reader.GetString(9),
                        Bic = reader.IsDBNull(10) ? null : reader.GetString(10),
                        Nickname = reader.IsDBNull(11) ? null : reader.GetString(11)
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
            command.CommandText = $"Select {COLUMN} from {TABLE} where customer_id = :id;";
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
                    City = reader.IsDBNull(6) ? null : reader.GetString(6),
                    Email = reader.IsDBNull(7) ? null : reader.GetString(7),
                    Telefon = reader.IsDBNull(8) ? null : reader.GetString(8),
                    Iban = reader.IsDBNull(9) ? null : reader.GetString(9),
                    Bic = reader.IsDBNull(10) ? null : reader.GetString(10),
                    Nickname = reader.IsDBNull(11) ? null : reader.GetString(11)
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
                if (this.Password != null)
                {
                    command.CommandText =
                    $"update {TABLE} set  name = :na, familyname = :fn, street = :st, housenr = :hn, postcode = :pc, city = :ci, iban = :ib, bic = :bi, password = CRYPT(:pa, GEN_SALT('bf')), nickname = :ni where customer_id = :cid";

                }
                else
                {
                    command.CommandText =
                    $"update {TABLE} set  name = :na, familyname = :fn, street = :st, housenr = :hn, postcode = :pc, city = :ci, iban = :ib, bic = :bi, nickname = :ni where customer_id = :cid";
                }
            }
            else
            {
                command.CommandText = $"select nextval('{TABLE}_seq')";
                this.CustomerId = (long?)command.ExecuteScalar();
                command.CommandText = $" insert into {TABLE} {COLUMNPW}" +
                    $" values(:cid, :na, :fn, :st, :hn, :pc, :ci, :ib, :bi, :pa, :ni)";
            }
            command.Parameters.AddWithValue("cid", this.CustomerId.Value);
            command.Parameters.AddWithValue("na", String.IsNullOrEmpty(this.Name) ? (object)DBNull.Value : this.Name);
            command.Parameters.AddWithValue("fn", String.IsNullOrEmpty(this.Familyname) ? (object)DBNull.Value : this.Familyname);
            command.Parameters.AddWithValue("st", String.IsNullOrEmpty(this.Street) ? (object)DBNull.Value : this.Street);
            command.Parameters.AddWithValue("hn", this.HouseNr.HasValue ? (object)this.HouseNr.Value : 3);
            command.Parameters.AddWithValue("pc", String.IsNullOrEmpty(this.Postcode) ? (object)DBNull.Value : this.Postcode);
            command.Parameters.AddWithValue("ci", String.IsNullOrEmpty(this.City) ? (object)DBNull.Value : this.City);
            command.Parameters.AddWithValue("ib", String.IsNullOrEmpty(this.Iban) ? (object)DBNull.Value : this.Iban);
            command.Parameters.AddWithValue("bi", String.IsNullOrEmpty(this.Bic) ? (object)DBNull.Value : this.Bic);
            command.Parameters.AddWithValue("bi", String.IsNullOrEmpty(this.Email) ? (object)DBNull.Value : this.Email);
            command.Parameters.AddWithValue("bi", String.IsNullOrEmpty(this.Telefon) ? (object)DBNull.Value : this.Telefon);
            command.Parameters.AddWithValue("pa", String.IsNullOrEmpty(this.Password) ? (object)DBNull.Value : this.Password);
            command.Parameters.AddWithValue("ni", String.IsNullOrEmpty(this.Nickname) ? (object)DBNull.Value : this.Nickname);

            return command.ExecuteNonQuery();
        }

        public int ChangePassword(string password, string newPassword)
        {
            int result = 0; 
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = this.connection;
            command.CommandText = $"Select {COLUMN} from {TABLE} where nickname = :ni and password = crypt(:pa, password);";
            command.Parameters.AddWithValue(":ni", String.IsNullOrEmpty(this.Nickname) ? "" : this.Nickname);
            command.Parameters.AddWithValue(":pa", String.IsNullOrEmpty(password) ? "" : password);
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows && newPassword != "")
            {
                reader.Close();
                command.CommandText = $"update {TABLE} set password = CRYPT(:npa, GEN_SALT('bf')) where customer_id = :cid";
                command.Parameters.AddWithValue("cid", this.CustomerId.Value);
                command.Parameters.AddWithValue("npa", newPassword);
                result = command.ExecuteNonQuery();
            }
            else
            {
                reader.Close();

            }
            return result;
        }
        #endregion
        //----------------------------------------------------------------------------------------------
        //Private
        //----------------------------------------------------------------------------------------------
        #region private

        #endregion
    }
}
