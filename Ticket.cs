using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ** Name:         James Horton
// ** Date:         10/16/2018
// ** Assignment:   Exam 2 Parking Garage
// ** File:         Exam2

namespace Exam2
{
    class Ticket
    {
        #region --- Private Data Fields ---
        int ticketNumber;
        DateTime timeIn;
        DateTime timeOut;
        #endregion -- Private data --

        #region --- Public Properties ---
        public int TicketNumber { get => ticketNumber; set => ticketNumber = value; }
        public DateTime TimeIn { get => timeIn; set => timeIn = value; }
        public DateTime TimeOut { get => timeOut; set => timeOut = value; }
        #endregion -- Public Props --

        #region --- Constructors ---
        public Ticket(int tktNo, DateTime tmIn, DateTime tmOut)
        {
            this.ticketNumber = tktNo;
            this.timeIn = tmIn;
            this.timeOut = tmOut;
        } // end of constructor
        #endregion -- Constructs --

    } // end of class


    #region --- Methods ---
    
    //public static bool isLotFull(int lwstTktNo, int hghstTkNo)
    //{
    //    if (hghstTkNo - lwstTktNo < 25)
    //        return true;

    //    return false;
    //} // end of isLotFull

    //public static int tmeInLot(int timeIn, int timeOut)
    //{
    //    int totaltime = timeOut - timeIn;   // time need to come in in hrs
    //    return totaltime;                   // time returned should be hrs
    //} // end of timeInLot
#endregion -- methods --

} // end of namespace
