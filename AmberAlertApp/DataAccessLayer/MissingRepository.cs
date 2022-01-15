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
    public class MissingRepository : IMissingRepository
    {
        private string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AmberAlertDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Missing> GetAllMissing()
        {
            List<Missing> listOfMissing = new List<Missing>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM MissingPeople";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Missing m = new Missing();
                    m.IdMiss = sqlDataReader.GetInt32(0);
                    m.FirstName = sqlDataReader.GetString(1);
                    m.SurName = sqlDataReader.GetString(2);
                    m.DateOfBirth = sqlDataReader.GetDateTime(3);
                    m.Address = sqlDataReader.GetString(4);
                    m.Gender = sqlDataReader.GetString(5);
                    m.DateOfDisappearance = sqlDataReader.GetDateTime(6);
                    m.ImageOfPerson = sqlDataReader.GetBoolean(7);

                    listOfMissing.Add(m);
                }
            }
            return listOfMissing;

        }

        public int InsertMissing(Missing m)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO MissingPeople VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", m.FirstName, m.SurName,  m.DateOfBirth, m.Address, m.Gender, m.DateOfDisappearance, m.ImageOfPerson);

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int UpdateMissing(Missing m)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("UPDATE MissingPeople SET FirstName='{0}', SurName='{1}',  DateOfBirth={2}, Address={3},Gender={4},DateOfDisappearance={5},ImageOfPerson={6}" +
                    "WHERE IdMiss={2}", m.FirstName, m.SurName,  m.DateOfBirth, m.Address, m.Gender, m.DateOfDisappearance, m.ImageOfPerson);

                return command.ExecuteNonQuery();

            }

        }
     public int DeleteMissing(Missing m)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                {
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = string.Format("DELETE FROM MissingPeople WHERE IdMiss = {0}", m.IdMiss);

                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
