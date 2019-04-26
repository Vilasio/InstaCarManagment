using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaCarManagement.Data
{
    public class Feature
    {
        //----------------------------------------------------------------------------------------------
        //Const
        //----------------------------------------------------------------------------------------------
        #region const
        private const string TABLE = "InstaCar.feature";
        private const string COLUMN = "feature_id, feature";
        #endregion

        //----------------------------------------------------------------------------------------------
        //PrivateMember
        //----------------------------------------------------------------------------------------------
        #region privateMember
        private NpgsqlConnection connection = null;
        public static List<Feature> Features1 = null;
        public static List<Feature> Features2 = null;
        public static List<Feature> Features3 = null;
        public static List<Feature> Features4 = null;

        #endregion

        //----------------------------------------------------------------------------------------------
        //Constructor
        //----------------------------------------------------------------------------------------------
        #region constructor
        public Feature()
        {

        }

        public Feature(NpgsqlConnection connection)
        {
            this.connection = connection;
        }
        #endregion
        //----------------------------------------------------------------------------------------------
        //Property
        //----------------------------------------------------------------------------------------------
        #region property
        public long? FeatureId { get; set; }
        public string FeatureName { get; set; }
       
        #endregion
        //----------------------------------------------------------------------------------------------
        //Static
        //----------------------------------------------------------------------------------------------
        #region static
        public static void GetLists(NpgsqlConnection connection)
        {
           
            NpgsqlCommand command = new NpgsqlCommand($"Select * from {TABLE}", connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            Features1 = new List<Feature>();

            while (reader.Read())
            {
                Features1.Add(new Feature(connection)
                {
                    FeatureId = reader.GetInt64(0),
                    FeatureName = reader.IsDBNull(1) ? null : reader.GetString(1)
                });

            }
            reader.Close();

            Features2 = new List<Feature>(Features1);
            Features3 = new List<Feature>(Features1);
            Features4 = new List<Feature>(Features1);


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

            if (this.FeatureId.HasValue)
            {
                command.CommandText =
                    $"update {TABLE} set feature = :fe";
            }
            else
            {
                command.CommandText = $"select nextval('{TABLE}_seq')";
                this.FeatureId = (long?)command.ExecuteScalar();
                command.CommandText = $" insert into {TABLE} ({COLUMN})" +
                    $" values(:fid, :fe)";
                Features1.Add(this);
            }

            command.Parameters.AddWithValue("fid", this.FeatureId.Value);
            command.Parameters.AddWithValue("de", String.IsNullOrEmpty(this.FeatureName) ? (object)DBNull.Value : this.FeatureName);


            int result = command.ExecuteNonQuery();

            return result;
        }

        public int Delete()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = this.connection;
            if (this.FeatureId.HasValue)
            {
                int result = 0;

                command.CommandText = $"delete from {TABLE} where feature_id = :fid";
                command.Parameters.AddWithValue("fid", this.FeatureId.Value);
                result = command.ExecuteNonQuery();
                Features1.Remove(this);
                return result;
            }
            else
            {
                return 0;
            }
        }

        #endregion
        //----------------------------------------------------------------------------------------------
        //Private
        //----------------------------------------------------------------------------------------------
        #region private

        #endregion
    }
}
