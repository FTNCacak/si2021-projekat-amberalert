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
    public class FinidingBusinessTest
    {
        private Mock<IFindingRepository> mockRepo = new Mock<IFindingRepository>();

        private List<Find> listOfFindings = new List<Find>();


        Find find1 = new Find
        {
            DateOfFinding = new DateTime(1985, 01, 05),
            Location = "Kraljevo",
            Dead = false,
            PoliceId = 256,
            IdMis = 894
        };

        Find find2 = new Find
        {
            DateOfFinding = new DateTime(1978, 11, 15),
            Location = "Valjevo",
            Dead = false,
            PoliceId = 698,
            IdMis = 425
        };

        public FinidingBusinessTest()
        {
            listOfFindings.Add(find1);
            listOfFindings.Add(find2);
        }

        private FinidingBusiness findingBussiness;

        [TestMethod]
        public void AreAllFindingssReturned()
        {
            // Arrange
            mockRepo.Setup(item => item.GetAllFinding()).Returns(listOfFindings);
            this.findingBussiness = new FinidingBusiness(mockRepo.Object);

            //Act
            var result = findingBussiness.GetFindings();

            //Assert
            Assert.AreEqual(2, result.Count);
        }
    }
}