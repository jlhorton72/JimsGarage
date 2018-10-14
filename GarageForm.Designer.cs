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
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLeave.Location = new System.Drawing.Point(800, 130);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(160, 46);
            this.btnLeave.TabIndex = 1;
            this.btnLeave.Text = "Exit Garage";
            this.btnLeave.UseVisualStyleBackColor = false;
            // 
            // txtBxInfo
            // 
            this.txtBxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtBxInfo.Location = new System.Drawing.Point(374, 66);
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
            this.lblTicketDetails.Location = new System.Drawing.Point(434, 213);
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
            this.lblTmOut.Location = new System.Drawing.Point(796, 333);
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
            this.lblTicketOut.Location = new System.Drawing.Point(750, 283);
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
            this.lblTtlTime.Location = new System.Drawing.Point(326, 387);
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
            this.lblAmntDue.Location = new System.Drawing.Point(309, 433);
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
            this.lblRates.Location = new System.Drawing.Point(434, 509);
            this.lblRates.Name = "lblRates";
            this.lblRates.Size = new System.Drawing.Size(320, 96);
            this.lblRates.TabIndex = 10;
            this.lblRates.Text = "Rates:     $2 minimum up to 3 HRS\r\n                $.50 each hour over 3 HRS\r\n   " +
    "             $10 maximum for any given\r\n                       24 HR period";
            // 
            // ParkingGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1200, 649);
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
    }
}

