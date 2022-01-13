using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Moq;

using Shared.Models;
using Shared.Interfaces.Repository;
using Shared.Interfaces.Business;
using AmberAlertBusiness;

namespace AmberAlertBusinessTest
{
    [TestClass]
    public class PoliceOfficerBusinessTest
    {
        private Mock<IPoliceOfficerRepository> mockRepo = new Mock<IPoliceOfficerRepository>();

        PoliceOfficer officer = new PoliceOfficer
        {
            PoliceBadgeNumber = 6589,
            FirstName = "Milan",
            SurName = "Pandurovic",
            UserName = "PUB23",
            Password = "Stanica432",
            Job = "Komandir",
            PoliceMotorolaNumber = 852,
            VehicleRegistrationPlate = "P-458-RT"
        };

        PoliceOfficer officer2 = new PoliceOfficer
        {
            PoliceBadgeNumber = 5698,
            FirstName = "Marko",
            SurName = "Markovic",
            UserName = "Klasad321",
            Password = "Pass892",
            Job = "Pozornik",
            PoliceMotorolaNumber = 822,
            VehicleRegistrationPlate = "P-869-FF"
        };

        PoliceOfficer officer3 = new PoliceOfficer
        {
            PoliceBadgeNumber = 3684,
            FirstName = "Filip",
            SurName = "Filipovic",
            UserName = "FF06",
            Password = "Cetvrtak3",
            Job = "Zamenik",
            PoliceMotorolaNumber = 4682,
            VehicleRegistrationPlate = "P-144-SW"
        };

        private List<PoliceOfficer> listOfOfficers = new List<PoliceOfficer>();
        private PoliceOfficerBusiness officerBusiness;

        public PoliceOfficerBusinessTest()
        {
            listOfOfficers.Add(officer);
            listOfOfficers.Add(officer2);
            listOfOfficers.Add(officer3);
        }

        [TestMethod]
        public void IsOfficerInserted()
        {
            // Arrange
            mockRepo.Setup(item => item.InsertPoliceOfficers(officer)).Returns(1);
            this.officerBusiness = new PoliceOfficerBusiness(mockRepo.Object);

            //Act
            var result = officerBusiness.PoliceIn(officer);

            //Assert
            Assert.AreEqual(result, "Uspešno ste uneli novog službenika");
        }

        [TestMethod]
        public void AreAllOfficersReturned()
        {
            // Arrange
            mockRepo.Setup(item => item.GetAllPoliceOfficers()).Returns(listOfOfficers);
            this.officerBusiness = new PoliceOfficerBusiness(mockRepo.Object);

            //Act
            var result = officerBusiness.PoliceAll();

            //Assert
            Assert.AreEqual(3, result.Count);
        }
    }
}
