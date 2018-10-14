using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

// ** Name:         James Horton
// ** Date:         10/16/2018
// ** Assignment:   Exam 2 Parking Garage
// ** File:         Exam2

namespace Exam2
{
    public partial class ParkingGarage : Form
    {
        public ParkingGarage()
        {
            InitializeComponent();
        } // end of ParkingGarage

        private void ParkingGarage_Load(object sender, EventArgs e)
        {
            txtBxInfo.Text = "Welcome to Jimmy's Garage";
            #region --- hide stuffs ---
            lblTmIn.Visible = false;
            lblTmOut.Visible = false;
            lblTcktNo.Visible = false;
            lblTicketOut.Visible = false;
            lblTtlTime.Visible = false;
            lblTicketDetails.Visible = false;
            lblAmntDue.Visible = false;
            #endregion -- hide stuffs --

            // create the xml file here with no info
            Ticket[] tickets = new Ticket[1];
            tickets[0] = new Ticket(0, DateTime.Now, DateTime.Now);
            using (XmlWriter writer = XmlWriter.Create("tickets.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("tickets");
                foreach (Ticket tk in tickets)
                {
                    writer.WriteStartElement("Ticket");
                    writer.WriteElementString("tktNumber", tk.TicketNumber.ToString());
                    writer.WriteElementString("timeIn", tk.TimeIn.ToString());
                    writer.WriteElementString("timeOut", tk.TimeOut.ToString());
                    writer.WriteEndElement();
                } // end of foreach loop that builds xml file
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            } // end of using


        } // end of formLoad

        #region --- unused/deleted txtbxRates ---
        private void txtBxRates_TextChanged(object sender, EventArgs e)
        {
            //txtBxRates.Text = "Rates:\t$2 minimum up to 3 HRS\n" +
            //                "\t\t$.50 each hour over 3 HRS\n" +
            //                "\t\t$10 maximum for any given 24 HR period";
        } // end of txtbxRates
        #endregion -- unused / deleted --

    } // end of class ParkingGarage : Form
} // end of namespace
