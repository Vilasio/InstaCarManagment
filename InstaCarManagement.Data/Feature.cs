using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaCarManagement.Data
{
    class Feature
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
        private static List<Feature> Features = null;
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
        public static List<Feature> GetList(NpgsqlConnection connection)
        {
            NpgsqlCommand command = new NpgsqlCommand($"Select image_id, picture, kind, main, description from {TABLE} where car_id = :cid", connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            Features = new List<Feature>();

            while (reader.Read())
            {
                Features.Add(new Feature(connection)
                {
                    FeatureId = reader.GetInt64(0),
                    FeatureName = reader.IsDBNull(1) ? null : reader.GetString(1)
                });

            }
            reader.Close();
            return Features;
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
                Features.Add(this);
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
                Features.Remove(this);
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
