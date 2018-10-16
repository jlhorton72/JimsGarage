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
        //int index;
        DateTime timeIn;
        DateTime timeOut;
        #endregion -- Private data --

        #region --- Public Properties ---
        public int TicketNumber { get => ticketNumber; set => ticketNumber = value; }
        //public int Index { get => index; set => index = value; }
        public DateTime TimeIn { get => timeIn; set => timeIn = value; }
        public DateTime TimeOut { get => timeOut; set => timeOut = value; }
        #endregion -- Public Props --

        #region --- Constructors ---
        /// <summary>
        ///builds each ticket 
        /// </summary>
        /// <param name="tktNo"></param>
        /// <param name="tmIn"></param>
        /// <param name="tmOut"></param>
        public Ticket(int tktNo, DateTime tmIn, DateTime tmOut)
        {
            this.ticketNumber = tktNo;
            //this.index = idx;
            this.timeIn = tmIn;
            this.timeOut = tmOut;
        } // end of constructor
        #endregion -- Constructs --

        #region --- Methods ---

        /// <summary>
        ///  returns bool as to whether or not lot is full
        /// </summary>
        /// <param name="inside"></param>
        /// <returns></returns>
        public static bool LtFll(int inside)
        {
            if (inside > 0)
            {
                return false;
            } // end of if                

            return true;
        } // end of isLotFull

        /// <summary>
        /// determines time in lot
        /// </summary>
        /// <param name="timeIn"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public static TimeSpan tmeInLot(DateTime timeIn, DateTime timeOut)
        {
            TimeSpan totaltime = timeOut.Subtract(timeIn);   // time need to come in in hrs
            return totaltime;                   // time returned should be hrs
        } // end of timeInLot

        /// <summary>
        /// figures how much is due per ticket
        /// </summary>
        /// <param name="hrs"></param>
        /// <returns></returns>
        public static double AmountDue(TimeSpan hrs)
        {
            double amount;
            int hours = hrs.Hours;
            if (hours <= 3)         // if less than3 hours, $2
            {
                amount = 2.00;
                return amount;
            } // end of if < 3
            else if (hours > 3 && hours < 20 )          // if between 3 and 20 hours, fee is calc'd
            {
                amount = (((hours - 3) * .5) + 2.00);
                return amount;
            } // end of else if 
                // lastly otherwise charge $10
            else
            {
                amount = 10;
                return amount;
            }
        } // end of AmountDue

        #endregion -- methods --

    } // end of class

} // end of namespace
