using CabInvoiceProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceTest
{
    [TestClass]
    public class UnitTest1
    {
        Invoice invoice = new Invoice();
        [TestMethod]
        public void GivenDistanceAndTime_CalculateFareMethodShould_ReturnTotalFare()
        {
            double distance = 20;
            int time = 45;

            // Calculating fare by passing the values of distance = 20km and time = 45 minutes
            double actualFare = invoice.CalculateFare(distance, time);
            double expectedFare = 245;

            // Checking if the test case passes
            Assert.AreEqual(expectedFare, actualFare);
        }
        [TestMethod]
        public void GivenMultipleRides_ThenCalculateFare_ShouldReturnTotalFare()
        {
            Summary[] rides = { new Summary(2.0, 5), new Summary(3.0, 6) };
            double fare = invoice.CalculateMultipleFare(rides);
            //Assert.AreEqual(61.0, fare);
        }
        [TestMethod]
        public void GivenMultipleRides_ThenCalculateFare_ShouldReturnInvoiceSummary()
        {
            Invoice invoice = new Invoice();
            Summary[] rides = { new Summary(2.0, 5), new Summary(3.0, 6) };
            double invoiceSummary = invoice.CalculateMultipleFare(rides);
            EnhancedInvoice expected = new EnhancedInvoice(2, 61);
            object.Equals(expected, invoiceSummary);
        }
        [TestMethod]
        public void GivenUserIdAndMultipleRides_ThenCalculateFare_shouldReturnNullUserException()
        {
            string userId = null;
            Summary[] rides = { new Summary(2, 5), new Summary(3, 6) };
            RideRepository rideRepository = new RideRepository();
            CustomException exception = Assert.ThrowsException<CustomException>(() => rideRepository.AddRides(userId, rides));
            Assert.AreEqual("NULL_EXCEPTION", exception.message);
        }


    }
}

