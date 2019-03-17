using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace InstaCarManagement.Data
{
    public class Account
    {
        #region const
        private const string TABLE = "InstaCar.account";
        private const string COLUMN = "account_id, username, password, role, tried, blocked";
        #endregion

        //------------------------------------------
        #region private properties

        private NpgsqlConnection connection = null;

        #endregion
        //------------------------------------------

        #region constructor

        public Account()
        {

        }

        public Account(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        #endregion

        //------------------------------------------

        #region properties

        public long? AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long? Role { get; set; }
        public long? Tried { get; set; }
        public bool Blocked { get; set; }
        private bool admin;

        public bool Admin
        {
            get { return admin; }
        }

        private List<Account> allUsers;

        public List<Account> AllUsers
        {
            get
            {
                if (allUsers == null)
                {
                    this.allUsers = this.GetAllUsers();
                    return this.allUsers;
                }
                else
                {
                    return allUsers;
                } }
            //set { allUsers = value; }
        }


        #endregion

        //------------------------------------------

        #region static


        public static Account LoginCheck(NpgsqlConnection connection ,string username, string password)
        {
            Account actualUser = null;
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = $"Select {COLUMN} from {TABLE} where username = :us and password = crypt(:pa, password);";
            command.Parameters.AddWithValue(":us", String.IsNullOrEmpty(username) ? "" : username);
            command.Parameters.AddWithValue(":pa", String.IsNullOrEmpty(password) ? "" : password);
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                actualUser = new Account(connection)
                {
                    AccountId = reader.GetInt64(0),
                    Username = reader.IsDBNull(1) ? null : reader.GetString(1),
                    Role = reader.IsDBNull(3) ? 3 : reader.GetInt64(3),
                    Tried = reader.IsDBNull(4) ? null : (long?)reader.GetInt64(4),
                    Blocked = reader.IsDBNull(5) ? true : reader.GetBoolean(5)
                };
                if (actualUser.Role == 1)
                {
                    actualUser.admin = true;
                }

            }
            reader.Close();
            return actualUser;

        }


        #endregion
        //------------------------------------------

        #region public

        public bool IsAllreadyRegistered(string user)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = this.connection;
            command.CommandText = $"Select username from {TABLE} where username = :us";
            command.Parameters.AddWithValue("us", String.IsNullOrEmpty(user) ? "" : user);
            string result = (string)command.ExecuteScalar();
            if (result != null || result != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int Save()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = this.connection;
            if (this.AccountId.HasValue)
            {
                if (this.Password != null)
                {
                    command.CommandText =
                    $"update {TABLE} set username = :us, password = CRYPT(:pa, GEN_SALT('bf')), role = :ro, tried = :tr, blocked = :bl where account_id = :aid";
                }
                else
                {
                    command.CommandText =
                    $"update {TABLE} set username = :us, role = :ro, tried = :tr, blocked = :bl where account_id = :aid";
                }
                
            }
            else
            {
                command.CommandText = $"select nextval('{TABLE}_seq')";
                this.AccountId = (long?)command.ExecuteScalar();
                command.CommandText = $" insert into {TABLE} (account_id, username, password, role, tried, blocked)" +
                    $" values(:aid, :us, CRYPT(:pa, GEN_SALT('bf')), :ro, :tr, :bl)";
            }
            command.Parameters.AddWithValue("aid", this.AccountId.Value);
            command.Parameters.AddWithValue("us", String.IsNullOrEmpty(this.Username) ? (object)DBNull.Value : this.Username);
            command.Parameters.AddWithValue("pa", String.IsNullOrEmpty(this.Password) ? (object)DBNull.Value : this.Password);
            command.Parameters.AddWithValue("ro", this.Role.HasValue ? (object)this.Role.Value : 3);
            command.Parameters.AddWithValue("tr", this.Tried.HasValue ? (object)this.Tried.Value : 0);
            command.Parameters.AddWithValue("bl", this.Blocked);

            return command.ExecuteNonQuery();
        }

        #endregion
        //------------------------------------------
        private List<Account> GetAllUsers()
        {
            List<Account> allUsers = null;
            if (this.admin)
            {
                allUsers = new List<Account>();
                Account user = null;
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = this.connection;
                command.CommandText = $"Select * from {TABLE};";

                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    allUsers.Add(
                        user = new Account(this.connection)
                        {
                            AccountId = reader.GetInt64(0),
                            Username = reader.IsDBNull(1) ? null : reader.GetString(1),
                            Password = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Role = reader.IsDBNull(3) ? 3 : reader.GetInt64(3),
                            Tried = reader.IsDBNull(4) ? null : (long?)reader.GetInt64(4),
                            Blocked = reader.IsDBNull(5) ? true : reader.GetBoolean(5)
                        }
                    );
                }
                reader.Close();
                return allUsers;
            }
            return allUsers;
        }


      
    }
}
