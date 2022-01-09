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
    public class PoliceOfficerRepository : IPoliceOfficerRepository
    {
        private string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AmberAlertDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<PoliceOfficer> GetAllPoliceOfficers()
        {
            List<PoliceOfficer> listOfPoliceOfficers = new List<PoliceOfficer>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM PoliceOfficers";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    PoliceOfficer p = new PoliceOfficer();
                    p.PoliceBadgeNumber = sqlDataReader.GetInt32(0);
                    p.FirstName = sqlDataReader.GetString(1);
                    p.SurName = sqlDataReader.GetString(2);
                    p.PoliceDepartment = sqlDataReader.GetString(3);
                    p.Job = sqlDataReader.GetString(4);
                    p.PoliceMotorolaNumber = sqlDataReader.GetInt32(5);
                    p.VehicleRegistrationPlate = sqlDataReader.GetString(6);

                    listOfPoliceOfficers.Add(p);
                }
            }
            return listOfPoliceOfficers;

        }

        public int InsertPoliceOfficers(PoliceOfficer p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO PoliceOfficers VALUES({0},'{1}','{2}','{3}','{4}',{5},'{6}')", p.PoliceBadgeNumber, p.FirstName, p.SurName, p.PoliceDepartment, p.Job, p.PoliceMotorolaNumber, p.VehicleRegistrationPlate);

                return sqlCommand.ExecuteNonQuery();
            }
        }

    }
}
