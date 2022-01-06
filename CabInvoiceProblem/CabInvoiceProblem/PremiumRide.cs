using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceProblem
{
   public  class PremiumRide
    {
        public static readonly PremiumRide NORMAL = new PremiumRide(10, 1, 5);
        public static readonly PremiumRide PREMIUM = new PremiumRide(15, 2, 20);

        private double costPerKilometer;
        private int costPerMinute;
        private double minimumFar;

        private PremiumRide(double costPerKilometer, int costPerMinute, double minimumFare)
        {
            this.costPerKilometer = costPerKilometer;
            this.costPerMinute = costPerMinute;
            this.minimumFar = minimumFare;
        }

        public double CalculateCostOfPremiumRide(Summary ride)
        {
            double totalFare;
            totalFare = ride.distance * costPerKilometer + ride.time * costPerMinute;
            if (totalFare < minimumFar)
                return minimumFar;
            return totalFare;
        }
    }
}
