using System;
using System.Windows.Forms;

// ** Name:         James Horton
// ** Date:         10/16/2018
// ** Assignment:   Exam 2 Parking Garage
// ** File:         Exam2

namespace Exam2
{
    static class Driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ParkingGarage());
        } // end of main
    } // end of class Driver
} // end of namespace
