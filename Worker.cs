using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace lab1
{
    internal class Worker
    {
        private string fName;
        public string firstName
        {
            get { return fName; }
            set { fName = value; }
        }

        private string lName;
        public string lastName
        {
            get { return lName; }
            set { lName = value; }
        }

        private int rPerDay;
        public int ratePerDay
        {
            get { return rPerDay; }
            set 
            {
                if (value < 0)
                    value = 0;
                else
                    rPerDay = value; 
            }
        }

        private int numOfDaysWorked;
        public int numberOfDaysWorked
        {
            get { return numOfDaysWorked; }
            set 
            {
                if (value < 0)
                    value = 0;
                else
                    numOfDaysWorked = value; 
            }
        }

        public int salary(int ratePerDay, int numberOfDaysWorked)
        {
            return ratePerDay * numberOfDaysWorked;
        }

        
    }
}
