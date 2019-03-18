using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaCarManagement.Data
{
    class Rent
    {
        //----------------------------------------------------------------------------------------------
        //Const
        //----------------------------------------------------------------------------------------------
        #region const
        private const string TABLE = "InstaCar.rent";
        private const string COLUMN = "rent_id, customer_id, car_id, datebegin, dateend, sumprice, units";
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
        public Rent()
        {

        }

        public Rent(NpgsqlConnection connection)
        {
            this.connection = connection;
        }
        #endregion
        //----------------------------------------------------------------------------------------------
        //Property
        //----------------------------------------------------------------------------------------------
        #region property
        public long? RentId { get; set; }
        public long? CustomerId { get; set; }
        public long? CarId { get; set; }
        public DateTime? Begin { get; set; }
        public DateTime? End { get; set; }
        public double? SumPrice { get; set; }
        public long? Units { get; set; }
        #endregion
        //----------------------------------------------------------------------------------------------
        //Static
        //----------------------------------------------------------------------------------------------
        #region static
        static List<Rent> GetAllRents(NpgsqlConnection connection)
        {
            List<Rent> allRents = new List<Rent>();
            Rent Rent = null;
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = $"Select * from {TABLE};";

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                allRents.Add(
                    Rent = new Rent(connection)
                    {
                        RentId = reader.GetInt64(0),
                        CustomerId = reader.GetInt64(1),
                        CarId = reader.GetInt64(2),
                        Begin = reader.IsDBNull(3) ? null : (DateTime?)reader.GetDateTime(3),
                        End = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4),
                        SumPrice = reader.IsDBNull(5) ? 0 : (double?)reader.GetDouble(5),
                        Units = reader.IsDBNull(6) ? 0 : (long?)reader.GetInt64(6)
                    }
                );
            }
            reader.Close();
            return allRents;
        }

        static List<Rent> GetCurrentRents(NpgsqlConnection connection)
        {
            List<Rent> currentRents = new List<Rent>();
            Rent Rent = null;
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = $"Select * from {TABLE} where dateend > current_timespan or dateend = null;";

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                currentRents.Add(
                    Rent = new Rent(connection)
                    {
                        RentId = reader.GetInt64(0),
                        CustomerId = reader.GetInt64(1),
                        CarId = reader.GetInt64(2),
                        Begin = reader.IsDBNull(3) ? null : (DateTime?)reader.GetDateTime(3),
                        End = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4),
                        SumPrice = reader.IsDBNull(5) ? 0 : (double?)reader.GetDouble(5),
                        Units = reader.IsDBNull(6) ? 0 : (long?)reader.GetInt64(6)
                    }
                );
            }
            reader.Close();
            return currentRents;
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
            if (this.CarId.HasValue)
            {

                command.CommandText =
                $"update {TABLE} set datebegin = :db, dateend = :de, sumprice = :sp, units = :un";


            }
            else
            {
                command.CommandText = $"select nextval('{TABLE}_seq')";
                this.RentId = (long?)command.ExecuteScalar();
                command.CommandText = $" insert into {TABLE} (rent_id, customer_id, car_id, datebegin, dateend, sumprice, units)" +
                    $" values(:rid, :cid, :caid, :db, :de, :sp, :un)";
            }
            command.Parameters.AddWithValue("rid", this.RentId.Value);
            command.Parameters.AddWithValue("cid", this.CustomerId.Value);
            command.Parameters.AddWithValue("caid", this.CarId.Value);
            command.Parameters.AddWithValue("db", this.Begin.HasValue ? (object)this.Begin.Value : (object)DBNull.Value);
            command.Parameters.AddWithValue("db", this.End.HasValue ? (object)this.End.Value : (object)DBNull.Value);
            command.Parameters.AddWithValue("sp", this.SumPrice.HasValue ? (object)this.SumPrice.Value : 0);
            command.Parameters.AddWithValue("un", this.Units.HasValue ? (object)this.Units.Value : 0);

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
