namespace TicketProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboActivity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cboTicketQty = new System.Windows.Forms.ComboBox();
            this.cboPaymentType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtChosenEvent = new System.Windows.Forms.TextBox();
            this.txtPricePerTicket = new System.Windows.Forms.TextBox();
            this.txtPayMethod = new System.Windows.Forms.TextBox();
            this.txtPayMethodCost = new System.Windows.Forms.TextBox();
            this.txtTicketQty = new System.Windows.Forms.TextBox();
            this.txtFinalCost = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.invalidNameLabel1 = new System.Windows.Forms.Label();
            this.invalidNameLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboActivity
            // 
            this.cboActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivity.FormattingEnabled = true;
            this.cboActivity.Location = new System.Drawing.Point(164, 30);
            this.cboActivity.Name = "cboActivity";
            this.cboActivity.Size = new System.Drawing.Size(206, 24);
            this.cboActivity.TabIndex = 0;
            this.cboActivity.SelectedIndexChanged += new System.EventHandler(this.cboActivity_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose an activity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose a region:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose a month:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Choose an event:";
            // 
            // cboRegion
            // 
            this.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(164, 82);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(206, 24);
            this.cboRegion.TabIndex = 1;
            this.cboRegion.SelectedIndexChanged += new System.EventHandler(this.cboRegion_SelectedIndexChanged);
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(164, 136);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(206, 24);
            this.cboMonth.TabIndex = 2;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // cboEvent
            // 
            this.cboEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Location = new System.Drawing.Point(164, 189);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(206, 24);
            this.cboEvent.TabIndex = 3;
            this.cboEvent.SelectedIndexChanged += new System.EventHandler(this.cboEvent_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "First name:";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 2);
            this.label6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Last name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Qty:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Payment type:";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(364, 398);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(170, 32);
            this.btnPurchase.TabIndex = 8;
            this.btnPurchase.Text = "&Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(135, 267);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(152, 22);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(135, 312);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(152, 22);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // cboTicketQty
            // 
            this.cboTicketQty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTicketQty.FormattingEnabled = true;
            this.cboTicketQty.Location = new System.Drawing.Point(135, 353);
            this.cboTicketQty.Name = "cboTicketQty";
            this.cboTicketQty.Size = new System.Drawing.Size(79, 24);
            this.cboTicketQty.TabIndex = 6;
            this.cboTicketQty.SelectedIndexChanged += new System.EventHandler(this.cboTicketQty_SelectedIndexChanged);
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.Location = new System.Drawing.Point(135, 403);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.Size = new System.Drawing.Size(152, 24);
            this.cboPaymentType.TabIndex = 7;
            this.cboPaymentType.SelectedIndexChanged += new System.EventHandler(this.cboPaymentType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Chosen event:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(386, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Price per ticket:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(386, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Method of payment:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(386, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Payment method cost:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(386, 270);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Ticket Quantity:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(386, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Final Cost:";
            // 
            // txtChosenEvent
            // 
            this.txtChosenEvent.Location = new System.Drawing.Point(535, 30);
            this.txtChosenEvent.Name = "txtChosenEvent";
            this.txtChosenEvent.ReadOnly = true;
            this.txtChosenEvent.Size = new System.Drawing.Size(152, 22);
            this.txtChosenEvent.TabIndex = 23;
            this.txtChosenEvent.TabStop = false;
            // 
            // txtPricePerTicket
            // 
            this.txtPricePerTicket.Location = new System.Drawing.Point(535, 82);
            this.txtPricePerTicket.Name = "txtPricePerTicket";
            this.txtPricePerTicket.ReadOnly = true;
            this.txtPricePerTicket.Size = new System.Drawing.Size(152, 22);
            this.txtPricePerTicket.TabIndex = 24;
            // 
            // txtPayMethod
            // 
            this.txtPayMethod.Location = new System.Drawing.Point(535, 136);
            this.txtPayMethod.Name = "txtPayMethod";
            this.txtPayMethod.ReadOnly = true;
            this.txtPayMethod.Size = new System.Drawing.Size(152, 22);
            this.txtPayMethod.TabIndex = 25;
            this.txtPayMethod.TabStop = false;
            // 
            // txtPayMethodCost
            // 
            this.txtPayMethodCost.Location = new System.Drawing.Point(535, 189);
            this.txtPayMethodCost.Name = "txtPayMethodCost";
            this.txtPayMethodCost.ReadOnly = true;
            this.txtPayMethodCost.Size = new System.Drawing.Size(152, 22);
            this.txtPayMethodCost.TabIndex = 26;
            this.txtPayMethodCost.TabStop = false;
            // 
            // txtTicketQty
            // 
            this.txtTicketQty.Location = new System.Drawing.Point(535, 267);
            this.txtTicketQty.Name = "txtTicketQty";
            this.txtTicketQty.ReadOnly = true;
            this.txtTicketQty.Size = new System.Drawing.Size(152, 22);
            this.txtTicketQty.TabIndex = 27;
            this.txtTicketQty.TabStop = false;
            // 
            // txtFinalCost
            // 
            this.txtFinalCost.Location = new System.Drawing.Point(535, 312);
            this.txtFinalCost.Name = "txtFinalCost";
            this.txtFinalCost.ReadOnly = true;
            this.txtFinalCost.Size = new System.Drawing.Size(152, 22);
            this.txtFinalCost.TabIndex = 28;
            this.txtFinalCost.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(560, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 32);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // invalidNameLabel1
            // 
            this.invalidNameLabel1.AutoSize = true;
            this.invalidNameLabel1.ForeColor = System.Drawing.Color.Red;
            this.invalidNameLabel1.Location = new System.Drawing.Point(293, 270);
            this.invalidNameLabel1.Name = "invalidNameLabel1";
            this.invalidNameLabel1.Size = new System.Drawing.Size(91, 17);
            this.invalidNameLabel1.TabIndex = 29;
            this.invalidNameLabel1.Text = "Invalid name.";
            // 
            // invalidNameLabel2
            // 
            this.invalidNameLabel2.AutoSize = true;
            this.invalidNameLabel2.ForeColor = System.Drawing.Color.Red;
            this.invalidNameLabel2.Location = new System.Drawing.Point(293, 312);
            this.invalidNameLabel2.Name = "invalidNameLabel2";
            this.invalidNameLabel2.Size = new System.Drawing.Size(91, 17);
            this.invalidNameLabel2.TabIndex = 30;
            this.invalidNameLabel2.Text = "Invalid name.";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPurchase;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.invalidNameLabel2);
            this.Controls.Add(this.invalidNameLabel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtFinalCost);
            this.Controls.Add(this.txtTicketQty);
            this.Controls.Add(this.txtPayMethodCost);
            this.Controls.Add(this.txtPayMethod);
            this.Controls.Add(this.txtPricePerTicket);
            this.Controls.Add(this.txtChosenEvent);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboPaymentType);
            this.Controls.Add(this.cboTicketQty);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboEvent);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboActivity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ActivSearch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cboTicketQty;
        private System.Windows.Forms.ComboBox cboPaymentType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtChosenEvent;
        private System.Windows.Forms.TextBox txtPricePerTicket;
        private System.Windows.Forms.TextBox txtPayMethod;
        private System.Windows.Forms.TextBox txtPayMethodCost;
        private System.Windows.Forms.TextBox txtTicketQty;
        private System.Windows.Forms.TextBox txtFinalCost;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label invalidNameLabel1;
        private System.Windows.Forms.Label invalidNameLabel2;
    }
}

