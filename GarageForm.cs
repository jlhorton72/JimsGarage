using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;

// ** Name:         James Horton
// ** Date:         10/16/2018
// ** Assignment:   Exam 2 Parking Garage
// ** File:         Exam2

namespace Exam2
{
    public partial class ParkingGarage : Form
    {
        int numberTicket = 5;
        int full = 20;
        XmlDocument doc = new XmlDocument();
        public ParkingGarage()
        {
            InitializeComponent();
        } // end of ParkingGarage

        /// <summary>
        ///  loads the form and creates the initial xml file...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            txtBxTicketNumber.Visible = false;
            txtBxTimeIn.Visible = false;
            txtBxTimeOut.Visible = false;
            txtBxtktNumOut.Visible = false;
            txtBxTotalDue.Visible = false;
            txtBxTotalTime.Visible = false;
            btnPiad.Visible = false;
            btnPiad.Enabled = false;
            txtBxViewAll.Visible = false;
            lblValid.Visible = false;
            lblWhatTicket.Visible = false;
            txtBxInput.Visible = false;
            txtBxInput.Enabled = false;
            #endregion -- hide stuffs --

            // create the xml file here with no info
            Ticket[] tickets = new Ticket[5];
            tickets[0] = new Ticket(1, DateTime.Now.AddHours(-1), DateTime.Now);
            tickets[1] = new Ticket(2, DateTime.Now.AddHours(-3), DateTime.Now);
            tickets[2] = new Ticket(3, DateTime.Now.AddHours(-7), DateTime.Now);
            tickets[3] = new Ticket(4, DateTime.Now.AddHours(-15), DateTime.Now);
            tickets[4] = new Ticket(5, DateTime.Now.AddHours(-22), DateTime.Now);
            using (XmlWriter writer = XmlWriter.Create("tickets.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("tickets");
                foreach (Ticket tk in tickets)
                {
                    writer.WriteStartElement("Ticket");
                    //writer.WriteAttributeString("index", tk.Index.ToString());
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

        /// <summary>
        /// this btn click event will test if lot is full,
        /// if full display message as such,
        /// if not, increments the ticket number, writes another ticket
        /// with the tktNumber, timein and no time out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            #region --- hide stuffs ---
            btnPiad.Visible = false;
            lblTicketOut.Visible = false;
            lblTmOut.Visible = false;
            txtBxTimeOut.Visible = false;
            txtBxTimeOut.Visible = false;
            txtBxtktNumOut.Visible = false;
            txtBxTotalDue.Visible = false;
            txtBxTotalTime.Visible = false;
            btnPiad.Visible = false;
            btnPiad.Enabled = false;
            txtBxViewAll.Visible = false;
            #endregion -- hides stuffs --

            #region --- reveals ---
            lblTicketDetails.Visible = true;
            lblTcktNo.Visible = true;
            lblTmIn.Visible = true;
            txtBxTimeIn.Visible = true;
            txtBxTicketNumber.Visible = true;
            #endregion -- reveals --
            full--;                                 // decrements the lot full counter
            numberTicket++;                         // increases the ticketnumber

            bool lotFull;
            XDocument xdoc = XDocument.Load("tickets.xml");
            //high = doc.SelectNodes("//tickets/ticket/tktNumber").Cast<XmlElement>()
            //    .Max(c => Int32.Parse(c.Attributes["tktNumber"].Value));
            //low = doc.SelectNodes("//tickets/ticket/tktNumber").Cast<XmlElement>()
            //    .Min(c => Int32.Parse(c.Attributes["tktNumber"].Value));
            lotFull = Ticket.LtFll(full);          // calls the lotfull to see if its full

            if (lotFull == false)                   // lot has room
            {

                #region did not work
                //Ticket[] tickets2 = new Ticket[1];
                //tickets2[0] = new Ticket(numberTicket, numberTicket, DateTime.Now, DateTime.Now);

                //using (XmlWriter writer = XmlWriter.Create("tickets.xml"))
                //{
                //    writer.WriteStartDocument();
                //    writer.WriteStartElement("tickets");
                //    foreach (Ticket tk in tickets2)
                //    {
                //        writer.WriteStartElement("Ticket");
                //        writer.WriteAttributeString("index", tk.Index.ToString());
                //        writer.WriteElementString("tktNumber", tk.TicketNumber.ToString());
                //        writer.WriteElementString("timeIn", tk.TimeIn.ToString());
                //        writer.WriteElementString("timeOut", tk.TimeOut.ToString());
                //        writer.WriteEndElement();
                //    } // end of foreach loop that builds xml file
                //    writer.WriteEndElement();
                //    writer.WriteEndDocument();
                //    writer.Close();
                //} // end of using
                #endregion did not work

                DateTime current = DateTime.Now;        // sets the timein
                XElement tckt = xdoc.Element("tickets");
                tckt.Add(new XElement("ticket",
                    new XAttribute("index", numberTicket),
                    new XElement("tktNumber", numberTicket),
                    new XElement("timeIn", current.ToString()),
                    new XElement("timeOut", current.ToString())));       // this should have added the new ticket with no out time
                txtBxTimeIn.Visible = true;             // reveals the time in
                txtBxTicketNumber.Visible = true;       // reveals the ticket number
                txtBxTicketNumber.Text = numberTicket.ToString();   // populates the text
                txtBxTimeIn.Text = current.ToString();              // populates the text

            } // end of if false / room to park
                // else is for the lot is fulll
            else
            {
                txtBxInfo.Text = "Garage is Full";
            } // end of else lo is full

            xdoc.Save("tickets.xml");        // saves the xml changes if made before going back
        } // end of btnEnterClick

        /// <summary>
        /// this begins to start the leave process
        /// first reveals lbl and txtbx to get ticket number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeave_Click(object sender, EventArgs e)
        {
           // btnPiad.Visible = true;
            //btnPiad.Enabled = true;
            //lblTmOut.Visible = true;
            lblWhatTicket.Visible = true;
            txtBxInput.Visible = true;
            txtBxInput.Clear();
            txtBxInput.Enabled = true;
        } // end of ExitGarage

        /// <summary>
        /// made moot.  Wasn't giving consistent results
        /// moved contents to btnAccept
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxInput_TextChanged(object sender, EventArgs e)
        {
            
        } // end of txtbXInput text changed

        /// <summary>
        /// this btn should denumberate the full count and 
        /// clear the necessary fields from view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPiad_Click(object sender, EventArgs e)
        {

            #region --- hide stuff ---
            txtBxInput.Enabled = false;
            txtBxInput.Clear();         // clear fields in txtboxes
            txtBxtktNumOut.Clear();     // 5 txtbxs to clear
            txtBxTimeOut.Clear();
            txtBxTotalTime.Clear();
            txtBxTotalDue.Clear();
            txtBxTotalDue.Visible = false;       // make the right stuff invisible
            txtBxTotalTime.Visible = false;     // 10 items to go invisible
            txtBxTimeOut.Visible = false;
            txtBxtktNumOut.Visible = false;
            txtBxInput.Visible = false;
            lblWhatTicket.Visible = false;
            lblTicketOut.Visible = false;
            lblTmOut.Visible = false;
            lblTtlTime.Visible = false;
            lblAmntDue.Visible = false;
            #endregion -- hide --

            // return to basic form & denumerat the ticketcount
            full++;

        } // end of paid

        /// <summary>
        /// this should display all tickets in the xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            txtBxViewAll.Visible = true;
            txtBxViewAll.Text = File.ReadAllText("tickets.xml");
        } // end of btnViewAll

        /// <summary>
        /// this will accept the ticket number and 
        /// finish the stuff for leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            #region --- hide stuffs ---
            lblValid.Visible = false;
            lblTicketDetails.Visible = false;
            lblTcktNo.Visible = false;
            lblTmIn.Visible = false;
            txtBxTicketNumber.Clear();
            txtBxTicketNumber.Visible = false;
            txtBxTimeIn.Clear();
            txtBxTimeIn.Visible = false;
            #endregion -- hide --

            #region --- reveals ---
            lblTicketOut.Visible = true;
            lblTmOut.Visible = true;
            lblTtlTime.Visible = true;
            lblAmntDue.Visible = true;
            btnPiad.Visible = true;
            btnPiad.Enabled = true;
            #endregion -- reveals --

            //string number = txtBxInput.Text;
            int number = Convert.ToInt32(txtBxInput.Text);            // sets the value for tkt number to search
            //DateTime leave = DateTime.Now;
            string leave = DateTime.Now.ToString();     // sets the datetime of leaving
            // make stuff visible
            txtBxtktNumOut.Visible = true;
            txtBxTimeOut.Visible = true;
            txtBxTotalTime.Visible = true;
            txtBxTotalDue.Visible = true;                       //  /tktNumber[text()='  for 2 lines down
            //var doc = XElement.Load("tickets.xml");
            //var saveLeave = doc.Element("tickets")
            //    .Element("ticket")
            //    .where(e => e.Elements("index").Value == number)
            //    .Single();


            XDocument doc = XDocument.Load("tickets.xml");          // loads the xml doc


            doc.XPathSelectElement("//tickets/ticket[" + number + "]/timeOut").Value = leave;                            // reads the doc and updates necessary fields based on ticket number
            string ventry = doc.XPathSelectElement("//tickets/ticket[" + number + "]/timeIn").Value;
            doc.Save("tickets.xml");                        // saves the xml file

            DateTime entry = DateTime.Parse(ventry);
            //DateTime entry = DateTime.Parse(doc.XPathSelectElement("//tktNumber[" + number + "]/timeIn").Value);
            string vexit = doc.XPathSelectElement("//tickets/ticket[" + number + "]/timeOut").Value;
            DateTime exit = DateTime.Parse(vexit);

            //DateTime exit = DateTime.Parse(doc.XPathSelectElement("//tktNumber[" + number + "]/timeOut").Value);

            TimeSpan timeInLot = Ticket.tmeInLot(entry, exit);      // calls the tmeinlot method for calculating time in lot
            // calculate the money due
            double due;                                     // establishes the variable
            due = Ticket.AmountDue(timeInLot);              // calls the amount due method 
            // need to populate all fields
            txtBxTimeIn.Visible = true;
            lblTmIn.Visible = true;
            txtBxTicketNumber.Visible = true;
            txtBxTicketNumber.Text = doc.XPathSelectElement("//tickets/ticket[" + number + "]/tktNumber").Value;
            txtBxTimeIn.Text = doc.XPathSelectElement("//tickets/ticket[" + number + "]/timeIn").Value;
            txtBxtktNumOut.Text = number.ToString(); //doc.XPathSelectElement("//tktNumber[text()='" + number + "']").Value;
            txtBxTimeOut.Text = exit.ToString();    //doc.XPathSelectElement("//tktNumber[text()='" + number + "']/timeOut").Value;
            txtBxTotalDue.Text = due.ToString("C0");                // stes the total due 
            txtBxTotalTime.Text = timeInLot.Hours.ToString();       // sets the time in lot
            
            txtBxInput.Enabled = false;
        } // end of btnAccept


    } // end of class ParkingGarage : Form
} // end of namespace
