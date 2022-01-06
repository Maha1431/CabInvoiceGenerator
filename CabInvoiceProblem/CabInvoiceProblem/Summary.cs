using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceProblem
{
   public class Summary
    {
        public double distance;
        public int time;

        public Summary(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
