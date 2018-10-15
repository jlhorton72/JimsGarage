namespace Exam2
{
    partial class ParkingGarage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.txtBxInfo = new System.Windows.Forms.TextBox();
            this.lblTicketDetails = new System.Windows.Forms.Label();
            this.lblTmIn = new System.Windows.Forms.Label();
            this.lblTcktNo = new System.Windows.Forms.Label();
            this.lblTmOut = new System.Windows.Forms.Label();
            this.lblTicketOut = new System.Windows.Forms.Label();
            this.lblTtlTime = new System.Windows.Forms.Label();
            this.lblAmntDue = new System.Windows.Forms.Label();
            this.lblRates = new System.Windows.Forms.Label();
            this.txtBxTicketNumber = new System.Windows.Forms.TextBox();
            this.txtBxTimeIn = new System.Windows.Forms.TextBox();
            this.txtBxTimeOut = new System.Windows.Forms.TextBox();
            this.txtBxtktNumOut = new System.Windows.Forms.TextBox();
            this.txtBxTotalTime = new System.Windows.Forms.TextBox();
            this.txtBxTotalDue = new System.Windows.Forms.TextBox();
            this.btnPiad = new System.Windows.Forms.Button();
            this.txtBxViewAll = new System.Windows.Forms.TextBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.lblWhatTicket = new System.Windows.Forms.Label();
            this.txtBxInput = new System.Windows.Forms.TextBox();
            this.lblValid = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEnter.Location = new System.Drawing.Point(192, 130);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(160, 46);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter Garage";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLeave.Location = new System.Drawing.Point(427, 130);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(160, 46);
            this.btnLeave.TabIndex = 1;
            this.btnLeave.Text = "Exit Garage";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // txtBxInfo
            // 
            this.txtBxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtBxInfo.Location = new System.Drawing.Point(304, 69);
            this.txtBxInfo.Name = "txtBxInfo";
            this.txtBxInfo.Size = new System.Drawing.Size(416, 40);
            this.txtBxInfo.TabIndex = 2;
            this.txtBxInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTicketDetails
            // 
            this.lblTicketDetails.AutoSize = true;
            this.lblTicketDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTicketDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketDetails.Location = new System.Drawing.Point(188, 225);
            this.lblTicketDetails.Name = "lblTicketDetails";
            this.lblTicketDetails.Size = new System.Drawing.Size(125, 24);
            this.lblTicketDetails.TabIndex = 3;
            this.lblTicketDetails.Text = "Ticket Details:";
            // 
            // lblTmIn
            // 
            this.lblTmIn.AutoSize = true;
            this.lblTmIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTmIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmIn.Location = new System.Drawing.Point(117, 333);
            this.lblTmIn.Name = "lblTmIn";
            this.lblTmIn.Size = new System.Drawing.Size(78, 24);
            this.lblTmIn.TabIndex = 4;
            this.lblTmIn.Text = "Time In:";
            // 
            // lblTcktNo
            // 
            this.lblTcktNo.AutoSize = true;
            this.lblTcktNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTcktNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTcktNo.Location = new System.Drawing.Point(51, 283);
            this.lblTcktNo.Name = "lblTcktNo";
            this.lblTcktNo.Size = new System.Drawing.Size(144, 24);
            this.lblTcktNo.TabIndex = 5;
            this.lblTcktNo.Text = "Ticket Number: ";
            // 
            // lblTmOut
            // 
            this.lblTmOut.AutoSize = true;
            this.lblTmOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTmOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmOut.Location = new System.Drawing.Point(512, 375);
            this.lblTmOut.Name = "lblTmOut";
            this.lblTmOut.Size = new System.Drawing.Size(98, 24);
            this.lblTmOut.TabIndex = 6;
            this.lblTmOut.Text = "Time Out: ";
            // 
            // lblTicketOut
            // 
            this.lblTicketOut.AutoSize = true;
            this.lblTicketOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTicketOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketOut.Location = new System.Drawing.Point(466, 321);
            this.lblTicketOut.Name = "lblTicketOut";
            this.lblTicketOut.Size = new System.Drawing.Size(144, 24);
            this.lblTicketOut.TabIndex = 7;
            this.lblTicketOut.Text = "Ticket Number: ";
            // 
            // lblTtlTime
            // 
            this.lblTtlTime.AutoSize = true;
            this.lblTtlTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTtlTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlTime.Location = new System.Drawing.Point(501, 431);
            this.lblTtlTime.Name = "lblTtlTime";
            this.lblTtlTime.Size = new System.Drawing.Size(109, 24);
            this.lblTtlTime.TabIndex = 8;
            this.lblTtlTime.Text = "Total Time: ";
            // 
            // lblAmntDue
            // 
            this.lblAmntDue.AutoSize = true;
            this.lblAmntDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAmntDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmntDue.Location = new System.Drawing.Point(484, 486);
            this.lblAmntDue.Name = "lblAmntDue";
            this.lblAmntDue.Size = new System.Drawing.Size(126, 24);
            this.lblAmntDue.TabIndex = 9;
            this.lblAmntDue.Text = "Amount Due: ";
            // 
            // lblRates
            // 
            this.lblRates.AutoSize = true;
            this.lblRates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRates.Location = new System.Drawing.Point(90, 486);
            this.lblRates.Name = "lblRates";
            this.lblRates.Size = new System.Drawing.Size(320, 96);
            this.lblRates.TabIndex = 10;
            this.lblRates.Text = "Rates:     $2 minimum up to 3 HRS\r\n                $.50 each hour over 3 HRS\r\n   " +
    "             $10 maximum for any given\r\n                       24 HR period";
            // 
            // txtBxTicketNumber
            // 
            this.txtBxTicketNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBxTicketNumber.ForeColor = System.Drawing.Color.Blue;
            this.txtBxTicketNumber.Location = new System.Drawing.Point(243, 284);
            this.txtBxTicketNumber.Name = "txtBxTicketNumber";
            this.txtBxTicketNumber.Size = new System.Drawing.Size(120, 26);
            this.txtBxTicketNumber.TabIndex = 11;
            // 
            // txtBxTimeIn
            // 
            this.txtBxTimeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBxTimeIn.ForeColor = System.Drawing.Color.Blue;
            this.txtBxTimeIn.Location = new System.Drawing.Point(243, 333);
            this.txtBxTimeIn.Name = "txtBxTimeIn";
            this.txtBxTimeIn.Size = new System.Drawing.Size(120, 26);
            this.txtBxTimeIn.TabIndex = 12;
            // 
            // txtBxTimeOut
            // 
            this.txtBxTimeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBxTimeOut.ForeColor = System.Drawing.Color.Blue;
            this.txtBxTimeOut.Location = new System.Drawing.Point(671, 375);
            this.txtBxTimeOut.Name = "txtBxTimeOut";
            this.txtBxTimeOut.Size = new System.Drawing.Size(120, 26);
            this.txtBxTimeOut.TabIndex = 13;
            // 
            // txtBxtktNumOut
            // 
            this.txtBxtktNumOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBxtktNumOut.ForeColor = System.Drawing.Color.Blue;
            this.txtBxtktNumOut.Location = new System.Drawing.Point(671, 321);
            this.txtBxtktNumOut.Name = "txtBxtktNumOut";
            this.txtBxtktNumOut.Size = new System.Drawing.Size(120, 26);
            this.txtBxtktNumOut.TabIndex = 14;
            // 
            // txtBxTotalTime
            // 
            this.txtBxTotalTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBxTotalTime.ForeColor = System.Drawing.Color.Blue;
            this.txtBxTotalTime.Location = new System.Drawing.Point(671, 431);
            this.txtBxTotalTime.Name = "txtBxTotalTime";
            this.txtBxTotalTime.Size = new System.Drawing.Size(120, 26);
            this.txtBxTotalTime.TabIndex = 15;
            // 
            // txtBxTotalDue
            // 
            this.txtBxTotalDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBxTotalDue.ForeColor = System.Drawing.Color.Blue;
            this.txtBxTotalDue.Location = new System.Drawing.Point(671, 486);
            this.txtBxTotalDue.Name = "txtBxTotalDue";
            this.txtBxTotalDue.Size = new System.Drawing.Size(120, 26);
            this.txtBxTotalDue.TabIndex = 16;
            // 
            // btnPiad
            // 
            this.btnPiad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPiad.Location = new System.Drawing.Point(654, 130);
            this.btnPiad.Name = "btnPiad";
            this.btnPiad.Size = new System.Drawing.Size(160, 46);
            this.btnPiad.TabIndex = 17;
            this.btnPiad.Text = "Paid";
            this.btnPiad.UseVisualStyleBackColor = false;
            this.btnPiad.Click += new System.EventHandler(this.btnPiad_Click);
            // 
            // txtBxViewAll
            // 
            this.txtBxViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBxViewAll.ForeColor = System.Drawing.Color.Blue;
            this.txtBxViewAll.Location = new System.Drawing.Point(866, 135);
            this.txtBxViewAll.Multiline = true;
            this.txtBxViewAll.Name = "txtBxViewAll";
            this.txtBxViewAll.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBxViewAll.Size = new System.Drawing.Size(263, 471);
            this.txtBxViewAll.TabIndex = 18;
            this.txtBxViewAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnViewAll.Location = new System.Drawing.Point(916, 63);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(160, 46);
            this.btnViewAll.TabIndex = 19;
            this.btnViewAll.Text = "View All Tickets";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // lblWhatTicket
            // 
            this.lblWhatTicket.AutoSize = true;
            this.lblWhatTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblWhatTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatTicket.Location = new System.Drawing.Point(410, 208);
            this.lblWhatTicket.Name = "lblWhatTicket";
            this.lblWhatTicket.Size = new System.Drawing.Size(255, 24);
            this.lblWhatTicket.TabIndex = 20;
            this.lblWhatTicket.Text = "What is Your Ticket Number: ";
            // 
            // txtBxInput
            // 
            this.txtBxInput.AcceptsReturn = true;
            this.txtBxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBxInput.ForeColor = System.Drawing.Color.Blue;
            this.txtBxInput.Location = new System.Drawing.Point(696, 206);
            this.txtBxInput.Name = "txtBxInput";
            this.txtBxInput.Size = new System.Drawing.Size(73, 26);
            this.txtBxInput.TabIndex = 21;
            this.txtBxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxInput.TextChanged += new System.EventHandler(this.txtBxInput_TextChanged);
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid.Location = new System.Drawing.Point(536, 558);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(184, 48);
            this.lblValid.TabIndex = 22;
            this.lblValid.Text = "Please Enter a Valid \r\nTicket Number";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAccept.Location = new System.Drawing.Point(602, 252);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(84, 46);
            this.btnAccept.TabIndex = 23;
            this.btnAccept.Text = "Enter";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // ParkingGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1200, 649);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.txtBxInput);
            this.Controls.Add(this.lblWhatTicket);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.txtBxViewAll);
            this.Controls.Add(this.btnPiad);
            this.Controls.Add(this.txtBxTotalDue);
            this.Controls.Add(this.txtBxTotalTime);
            this.Controls.Add(this.txtBxtktNumOut);
            this.Controls.Add(this.txtBxTimeOut);
            this.Controls.Add(this.txtBxTimeIn);
            this.Controls.Add(this.txtBxTicketNumber);
            this.Controls.Add(this.lblRates);
            this.Controls.Add(this.lblAmntDue);
            this.Controls.Add(this.lblTtlTime);
            this.Controls.Add(this.lblTicketOut);
            this.Controls.Add(this.lblTmOut);
            this.Controls.Add(this.lblTcktNo);
            this.Controls.Add(this.lblTmIn);
            this.Controls.Add(this.lblTicketDetails);
            this.Controls.Add(this.txtBxInfo);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnEnter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ParkingGarage";
            this.Text = "Parking Garage";
            this.Load += new System.EventHandler(this.ParkingGarage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.TextBox txtBxInfo;
        private System.Windows.Forms.Label lblTicketDetails;
        private System.Windows.Forms.Label lblTmIn;
        private System.Windows.Forms.Label lblTcktNo;
        private System.Windows.Forms.Label lblTmOut;
        private System.Windows.Forms.Label lblTicketOut;
        private System.Windows.Forms.Label lblTtlTime;
        private System.Windows.Forms.Label lblAmntDue;
        private System.Windows.Forms.Label lblRates;
        private System.Windows.Forms.TextBox txtBxTicketNumber;
        private System.Windows.Forms.TextBox txtBxTimeIn;
        private System.Windows.Forms.TextBox txtBxTimeOut;
        private System.Windows.Forms.TextBox txtBxtktNumOut;
        private System.Windows.Forms.TextBox txtBxTotalTime;
        private System.Windows.Forms.TextBox txtBxTotalDue;
        private System.Windows.Forms.Button btnPiad;
        private System.Windows.Forms.TextBox txtBxViewAll;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Label lblWhatTicket;
        private System.Windows.Forms.TextBox txtBxInput;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Button btnAccept;
    }
}

