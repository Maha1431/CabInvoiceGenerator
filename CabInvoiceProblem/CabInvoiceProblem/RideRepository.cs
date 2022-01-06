using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceProblem
{
   public  class RideRepository
    {
        public Dictionary<string, List<Summary>> userRideObject;

        public RideRepository()
        {
            this.userRideObject = new Dictionary<string, List<Summary>>();
        }

        public void AddRides(string UserID, Summary[] rides)
        {
            if (UserID == null)
                throw new CustomException(ExceptionType.NULL_EXCEPTION + "");
            bool checkRide = userRideObject.ContainsKey(UserID);
            List<Summary> list = new List<Summary>();
            if (checkRide == false)
            {
                list.AddRange(rides);
                userRideObject.Add(UserID, list);
            }
        }
    }
}
