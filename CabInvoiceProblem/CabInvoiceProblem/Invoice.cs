﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceProblem
{
   public  class Invoice
    {
        public double CalculateFare(double distance, int time)
        {
            int costPerKilometer = 10;
            int costPerMinute = 1;
            int minimumFare = 5;
            double totalFare = distance * costPerKilometer + time * costPerMinute;
            if (totalFare < minimumFare)
                return minimumFare;
            return totalFare;
        }
    }
}
