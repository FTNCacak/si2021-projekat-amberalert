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
    public class MissingBusinessTest
    {

        private Mock<IMissingRepository> mockRepo = new Mock<IMissingRepository>();


        private List<Missing> listOfMissing = new List<Missing>();

        Missing miss1 = new Missing
        {
            IdMiss = 6589,
            FirstName = "Marko",
            SurName = "Markovic",
            JMBG = 344132,
            DateOfBirth = new DateTime(1985, 01, 05),
            Address = "Akacija 29",
            Gender = "Male",
            DateOfDisappearance = new DateTime(2000, 08, 03),
            ImageOfPerson = true
        };

        Missing miss2 = new Missing
        {
            IdMiss = 6589,
            FirstName = "Mila",
            SurName = "Marinkovic",
            JMBG = 56854782,
            DateOfBirth = new DateTime(1998, 03, 15),
            Address = "Masarikova 9",
            Gender = "Female",
            DateOfDisappearance = new DateTime(2008, 05, 31),
            ImageOfPerson = true
        };

        Missing miss3 = new Missing
        {
            IdMiss = 0383,
            FirstName = "Marina",
            SurName = "Colovic",
            JMBG = 020605478,
            DateOfBirth = new DateTime(2001, 01, 22),
            Address = "Beogradska 125",
            Gender = "Female",
            DateOfDisappearance = new DateTime(2018, 12, 03),
            ImageOfPerson = false
        };

        public MissingBusinessTest()
        {
            listOfMissing.Add(miss1);
            listOfMissing.Add(miss2);
            listOfMissing.Add(miss3);
        }

        private MissingBusiness missingBussiness;

        [TestMethod]
        public void IsMissingAdded()
        {
            // Arrange
            mockRepo.Setup(item => item.InsertMissing(miss1)).Returns(1);
            this.missingBussiness = new MissingBusiness(mockRepo.Object);

            //Act
            var result = missingBussiness.MissingIn(miss1);

            //Assert
            Assert.AreEqual(result, "Uspešno ste uneli nestalu osobu");
        }

        [TestMethod]
        public void AreAllOfficersReturned()
        {
            // Arrange
            mockRepo.Setup(item => item.GetAllMissing()).Returns(listOfMissing);
            this.missingBussiness = new MissingBusiness(mockRepo.Object);

            //Act
            var result = missingBussiness.MissingAll();

            //Assert
            Assert.AreEqual(3, result.Count);
        }
    }
}