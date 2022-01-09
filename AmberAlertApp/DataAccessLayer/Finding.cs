using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Interfaces.Repository;
using Shared.Models;

namespace DataAccessLayer
{
    class FindingRepository : IFindingRepository
    {
        private string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AmberAlertDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Find> GetAllFinding()
        {
            List<Find> listOfFinds = new List<Find>();
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Finding";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Find f = new Find();
                    f.DateOfFinding = sqlDataReader.GetDateTime(0);
                    f.Location = sqlDataReader.GetString(1);
                    f.Dead = sqlDataReader.GetBoolean(2);
                    f.PoliceId = sqlDataReader.GetInt32(3);
                    f.IdMis = sqlDataReader.GetInt32(4);

                    listOfFinds.Add(f);
                }
            }
            return listOfFinds;
        }

        public int InsertFinding(Find f)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Finding VALUES('{0}','{1}',{2},{3},{4})", f.DateOfFinding, f.Location, f.Dead, f.PoliceId, f.IdMis);

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
