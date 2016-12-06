namespace Flight_Reservation_Client
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbCustomerInfo = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCustomer8 = new System.Windows.Forms.Label();
            this.lblCustomer7 = new System.Windows.Forms.Label();
            this.txtSearchPhone = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCustomerSuccess = new System.Windows.Forms.Label();
            this.lblCustomer4 = new System.Windows.Forms.Label();
            this.lblCustomer3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCustomer2 = new System.Windows.Forms.Label();
            this.lblCustomer1 = new System.Windows.Forms.Label();
            this.lblCustomer6 = new System.Windows.Forms.Label();
            this.lblCustomer5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblReservationSuccess = new System.Windows.Forms.Label();
            this.btnReservationBack = new System.Windows.Forms.Button();
            this.btnCreateReservation = new System.Windows.Forms.Button();
            this.gpPartreservations = new System.Windows.Forms.GroupBox();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.lblReservation8 = new System.Windows.Forms.Label();
            this.dgvPartReservations = new System.Windows.Forms.DataGridView();
            this.clmnStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpSearchReservation = new System.Windows.Forms.GroupBox();
            this.btnSearchReservation = new System.Windows.Forms.Button();
            this.tbReservationNo = new System.Windows.Forms.TextBox();
            this.lblReservation7 = new System.Windows.Forms.Label();
            this.gbNewReservation = new System.Windows.Forms.GroupBox();
            this.lblCustomerNo = new System.Windows.Forms.Label();
            this.lblReservation5 = new System.Windows.Forms.Label();
            this.lblReservation4 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbMaxLayovers = new System.Windows.Forms.TextBox();
            this.lblReservation3 = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.btnFindFlights = new System.Windows.Forms.Button();
            this.lblReservation2 = new System.Windows.Forms.Label();
            this.lblReservation1 = new System.Windows.Forms.Label();
            this.tbSeats = new System.Windows.Forms.TextBox();
            this.lblReservation6 = new System.Windows.Forms.Label();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gpPartreservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartReservations)).BeginInit();
            this.gpSearchReservation.SuspendLayout();
            this.gbNewReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(945, 682);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 656);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbCustomerInfo);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.lblCustomer8);
            this.groupBox2.Controls.Add(this.lblCustomer7);
            this.groupBox2.Controls.Add(this.txtSearchPhone);
            this.groupBox2.Location = new System.Drawing.Point(508, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 450);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Customer";
            // 
            // rtbCustomerInfo
            // 
            this.rtbCustomerInfo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.rtbCustomerInfo.Location = new System.Drawing.Point(20, 127);
            this.rtbCustomerInfo.Name = "rtbCustomerInfo";
            this.rtbCustomerInfo.ReadOnly = true;
            this.rtbCustomerInfo.Size = new System.Drawing.Size(305, 306);
            this.rtbCustomerInfo.TabIndex = 3;
            this.rtbCustomerInfo.Text = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(246, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCustomer8
            // 
            this.lblCustomer8.AutoSize = true;
            this.lblCustomer8.Location = new System.Drawing.Point(17, 104);
            this.lblCustomer8.Name = "lblCustomer8";
            this.lblCustomer8.Size = new System.Drawing.Size(108, 20);
            this.lblCustomer8.TabIndex = 1;
            this.lblCustomer8.Text = "Customer info";
            // 
            // lblCustomer7
            // 
            this.lblCustomer7.AutoSize = true;
            this.lblCustomer7.Location = new System.Drawing.Point(17, 34);
            this.lblCustomer7.Name = "lblCustomer7";
            this.lblCustomer7.Size = new System.Drawing.Size(113, 20);
            this.lblCustomer7.TabIndex = 1;
            this.lblCustomer7.Text = "Phone number";
            // 
            // txtSearchPhone
            // 
            this.txtSearchPhone.Location = new System.Drawing.Point(20, 57);
            this.txtSearchPhone.Name = "txtSearchPhone";
            this.txtSearchPhone.Size = new System.Drawing.Size(220, 26);
            this.txtSearchPhone.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCustomerSuccess);
            this.groupBox1.Controls.Add(this.lblCustomer4);
            this.groupBox1.Controls.Add(this.lblCustomer3);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblCustomer2);
            this.groupBox1.Controls.Add(this.lblCustomer1);
            this.groupBox1.Controls.Add(this.lblCustomer6);
            this.groupBox1.Controls.Add(this.lblCustomer5);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtAdd);
            this.groupBox1.Controls.Add(this.txtPost);
            this.groupBox1.Controls.Add(this.txtLast);
            this.groupBox1.Controls.Add(this.txtFirst);
            this.groupBox1.Location = new System.Drawing.Point(64, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 513);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Customer";
            // 
            // lblCustomerSuccess
            // 
            this.lblCustomerSuccess.AutoSize = true;
            this.lblCustomerSuccess.Location = new System.Drawing.Point(17, 471);
            this.lblCustomerSuccess.Name = "lblCustomerSuccess";
            this.lblCustomerSuccess.Size = new System.Drawing.Size(0, 20);
            this.lblCustomerSuccess.TabIndex = 7;
            // 
            // lblCustomer4
            // 
            this.lblCustomer4.AutoSize = true;
            this.lblCustomer4.Location = new System.Drawing.Point(17, 244);
            this.lblCustomer4.Name = "lblCustomer4";
            this.lblCustomer4.Size = new System.Drawing.Size(95, 20);
            this.lblCustomer4.TabIndex = 6;
            this.lblCustomer4.Text = "Postal Code";
            // 
            // lblCustomer3
            // 
            this.lblCustomer3.AutoSize = true;
            this.lblCustomer3.Location = new System.Drawing.Point(17, 174);
            this.lblCustomer3.Name = "lblCustomer3";
            this.lblCustomer3.Size = new System.Drawing.Size(68, 20);
            this.lblCustomer3.TabIndex = 5;
            this.lblCustomer3.Text = "Address";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(282, 465);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 26);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Create";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCustomer2
            // 
            this.lblCustomer2.AutoSize = true;
            this.lblCustomer2.Location = new System.Drawing.Point(17, 104);
            this.lblCustomer2.Name = "lblCustomer2";
            this.lblCustomer2.Size = new System.Drawing.Size(86, 20);
            this.lblCustomer2.TabIndex = 4;
            this.lblCustomer2.Text = "Last Name";
            // 
            // lblCustomer1
            // 
            this.lblCustomer1.AutoSize = true;
            this.lblCustomer1.Location = new System.Drawing.Point(17, 34);
            this.lblCustomer1.Name = "lblCustomer1";
            this.lblCustomer1.Size = new System.Drawing.Size(86, 20);
            this.lblCustomer1.TabIndex = 3;
            this.lblCustomer1.Text = "First Name";
            // 
            // lblCustomer6
            // 
            this.lblCustomer6.AutoSize = true;
            this.lblCustomer6.Location = new System.Drawing.Point(17, 384);
            this.lblCustomer6.Name = "lblCustomer6";
            this.lblCustomer6.Size = new System.Drawing.Size(48, 20);
            this.lblCustomer6.TabIndex = 1;
            this.lblCustomer6.Text = "Email";
            // 
            // lblCustomer5
            // 
            this.lblCustomer5.AutoSize = true;
            this.lblCustomer5.Location = new System.Drawing.Point(17, 314);
            this.lblCustomer5.Name = "lblCustomer5";
            this.lblCustomer5.Size = new System.Drawing.Size(113, 20);
            this.lblCustomer5.TabIndex = 1;
            this.lblCustomer5.Text = "Phone number";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(20, 407);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(337, 26);
            this.txtMail.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(20, 337);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(337, 26);
            this.txtPhone.TabIndex = 4;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(20, 197);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(337, 26);
            this.txtAdd.TabIndex = 2;
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(20, 267);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(337, 26);
            this.txtPost.TabIndex = 3;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(20, 127);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(337, 26);
            this.txtLast.TabIndex = 1;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(20, 57);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(337, 26);
            this.txtFirst.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(783, 493);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 26);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblReservationSuccess);
            this.tabPage2.Controls.Add(this.btnReservationBack);
            this.tabPage2.Controls.Add(this.btnCreateReservation);
            this.tabPage2.Controls.Add(this.gpPartreservations);
            this.tabPage2.Controls.Add(this.gpSearchReservation);
            this.tabPage2.Controls.Add(this.gbNewReservation);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 656);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblReservationSuccess
            // 
            this.lblReservationSuccess.AutoSize = true;
            this.lblReservationSuccess.Location = new System.Drawing.Point(273, 623);
            this.lblReservationSuccess.Name = "lblReservationSuccess";
            this.lblReservationSuccess.Size = new System.Drawing.Size(0, 20);
            this.lblReservationSuccess.TabIndex = 19;
            // 
            // btnReservationBack
            // 
            this.btnReservationBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationBack.Location = new System.Drawing.Point(18, 619);
            this.btnReservationBack.Name = "btnReservationBack";
            this.btnReservationBack.Size = new System.Drawing.Size(170, 29);
            this.btnReservationBack.TabIndex = 4;
            this.btnReservationBack.Text = "Back";
            this.btnReservationBack.UseVisualStyleBackColor = true;
            this.btnReservationBack.Click += new System.EventHandler(this.btnReservationBack_Click);
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReservation.Location = new System.Drawing.Point(748, 619);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(170, 29);
            this.btnCreateReservation.TabIndex = 3;
            this.btnCreateReservation.Text = "Create Reservation";
            this.btnCreateReservation.UseVisualStyleBackColor = true;
            this.btnCreateReservation.Click += new System.EventHandler(this.btnCreateReservation_Click);
            // 
            // gpPartreservations
            // 
            this.gpPartreservations.Controls.Add(this.tbTotalPrice);
            this.gpPartreservations.Controls.Add(this.lblReservation8);
            this.gpPartreservations.Controls.Add(this.dgvPartReservations);
            this.gpPartreservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPartreservations.Location = new System.Drawing.Point(8, 247);
            this.gpPartreservations.Name = "gpPartreservations";
            this.gpPartreservations.Size = new System.Drawing.Size(920, 359);
            this.gpPartreservations.TabIndex = 0;
            this.gpPartreservations.TabStop = false;
            this.gpPartreservations.Text = "Part Reservations";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(806, 327);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(108, 26);
            this.tbTotalPrice.TabIndex = 2;
            // 
            // lblReservation8
            // 
            this.lblReservation8.AutoSize = true;
            this.lblReservation8.Location = new System.Drawing.Point(712, 328);
            this.lblReservation8.Name = "lblReservation8";
            this.lblReservation8.Size = new System.Drawing.Size(87, 20);
            this.lblReservation8.TabIndex = 1;
            this.lblReservation8.Text = "Total Price:";
            // 
            // dgvPartReservations
            // 
            this.dgvPartReservations.AllowUserToAddRows = false;
            this.dgvPartReservations.AllowUserToDeleteRows = false;
            this.dgvPartReservations.AllowUserToResizeRows = false;
            this.dgvPartReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnStart,
            this.clmnEnd,
            this.clmnDepartureDate,
            this.clmnDepartureTime,
            this.clmnArrivalDate,
            this.clmnArrivalTime,
            this.clmnFlightNo,
            this.clmnPrice});
            this.dgvPartReservations.Location = new System.Drawing.Point(10, 25);
            this.dgvPartReservations.Name = "dgvPartReservations";
            this.dgvPartReservations.ReadOnly = true;
            this.dgvPartReservations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvPartReservations.Size = new System.Drawing.Size(904, 295);
            this.dgvPartReservations.TabIndex = 0;
            // 
            // clmnStart
            // 
            this.clmnStart.Frozen = true;
            this.clmnStart.HeaderText = "Starting Point";
            this.clmnStart.Name = "clmnStart";
            this.clmnStart.ReadOnly = true;
            this.clmnStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnStart.Width = 185;
            // 
            // clmnEnd
            // 
            this.clmnEnd.Frozen = true;
            this.clmnEnd.HeaderText = "Destination";
            this.clmnEnd.Name = "clmnEnd";
            this.clmnEnd.ReadOnly = true;
            this.clmnEnd.Width = 185;
            // 
            // clmnDepartureDate
            // 
            this.clmnDepartureDate.HeaderText = "Departure Date";
            this.clmnDepartureDate.Name = "clmnDepartureDate";
            this.clmnDepartureDate.ReadOnly = true;
            this.clmnDepartureDate.Width = 95;
            // 
            // clmnDepartureTime
            // 
            this.clmnDepartureTime.HeaderText = "Departure Time";
            this.clmnDepartureTime.Name = "clmnDepartureTime";
            this.clmnDepartureTime.ReadOnly = true;
            this.clmnDepartureTime.Width = 90;
            // 
            // clmnArrivalDate
            // 
            this.clmnArrivalDate.HeaderText = "Arrival Date";
            this.clmnArrivalDate.Name = "clmnArrivalDate";
            this.clmnArrivalDate.ReadOnly = true;
            this.clmnArrivalDate.Width = 95;
            // 
            // clmnArrivalTime
            // 
            this.clmnArrivalTime.HeaderText = "Arrival Time";
            this.clmnArrivalTime.Name = "clmnArrivalTime";
            this.clmnArrivalTime.ReadOnly = true;
            this.clmnArrivalTime.Width = 90;
            // 
            // clmnFlightNo
            // 
            this.clmnFlightNo.HeaderText = "Flight No.";
            this.clmnFlightNo.Name = "clmnFlightNo";
            this.clmnFlightNo.ReadOnly = true;
            this.clmnFlightNo.Width = 50;
            // 
            // clmnPrice
            // 
            this.clmnPrice.HeaderText = "Price";
            this.clmnPrice.Name = "clmnPrice";
            this.clmnPrice.ReadOnly = true;
            this.clmnPrice.Width = 70;
            // 
            // gpSearchReservation
            // 
            this.gpSearchReservation.Controls.Add(this.btnSearchReservation);
            this.gpSearchReservation.Controls.Add(this.tbReservationNo);
            this.gpSearchReservation.Controls.Add(this.lblReservation7);
            this.gpSearchReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSearchReservation.Location = new System.Drawing.Point(550, 6);
            this.gpSearchReservation.Name = "gpSearchReservation";
            this.gpSearchReservation.Size = new System.Drawing.Size(378, 235);
            this.gpSearchReservation.TabIndex = 1;
            this.gpSearchReservation.TabStop = false;
            this.gpSearchReservation.Text = "Search Reservation";
            // 
            // btnSearchReservation
            // 
            this.btnSearchReservation.Location = new System.Drawing.Point(293, 200);
            this.btnSearchReservation.Name = "btnSearchReservation";
            this.btnSearchReservation.Size = new System.Drawing.Size(75, 29);
            this.btnSearchReservation.TabIndex = 18;
            this.btnSearchReservation.Text = "Search";
            this.btnSearchReservation.UseVisualStyleBackColor = true;
            this.btnSearchReservation.Click += new System.EventHandler(this.btnSearchReservation_Click);
            // 
            // tbReservationNo
            // 
            this.tbReservationNo.Location = new System.Drawing.Point(15, 74);
            this.tbReservationNo.Name = "tbReservationNo";
            this.tbReservationNo.Size = new System.Drawing.Size(353, 26);
            this.tbReservationNo.TabIndex = 17;
            // 
            // lblReservation7
            // 
            this.lblReservation7.AutoSize = true;
            this.lblReservation7.Location = new System.Drawing.Point(11, 51);
            this.lblReservation7.Name = "lblReservation7";
            this.lblReservation7.Size = new System.Drawing.Size(152, 20);
            this.lblReservation7.TabIndex = 0;
            this.lblReservation7.Text = "Reservation number";
            // 
            // gbNewReservation
            // 
            this.gbNewReservation.Controls.Add(this.lblCustomerNo);
            this.gbNewReservation.Controls.Add(this.lblReservation5);
            this.gbNewReservation.Controls.Add(this.lblReservation4);
            this.gbNewReservation.Controls.Add(this.tbDate);
            this.gbNewReservation.Controls.Add(this.tbTime);
            this.gbNewReservation.Controls.Add(this.tbMaxLayovers);
            this.gbNewReservation.Controls.Add(this.lblReservation3);
            this.gbNewReservation.Controls.Add(this.tbStart);
            this.gbNewReservation.Controls.Add(this.tbDestination);
            this.gbNewReservation.Controls.Add(this.btnFindFlights);
            this.gbNewReservation.Controls.Add(this.lblReservation2);
            this.gbNewReservation.Controls.Add(this.lblReservation1);
            this.gbNewReservation.Controls.Add(this.tbSeats);
            this.gbNewReservation.Controls.Add(this.lblReservation6);
            this.gbNewReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewReservation.Location = new System.Drawing.Point(8, 6);
            this.gbNewReservation.Name = "gbNewReservation";
            this.gbNewReservation.Size = new System.Drawing.Size(536, 235);
            this.gbNewReservation.TabIndex = 0;
            this.gbNewReservation.TabStop = false;
            this.gbNewReservation.Text = "New Reservation";
            // 
            // lblCustomerNo
            // 
            this.lblCustomerNo.AutoSize = true;
            this.lblCustomerNo.Location = new System.Drawing.Point(6, 204);
            this.lblCustomerNo.Name = "lblCustomerNo";
            this.lblCustomerNo.Size = new System.Drawing.Size(163, 20);
            this.lblCustomerNo.TabIndex = 18;
            this.lblCustomerNo.Text = "No customer selected";
            // 
            // lblReservation5
            // 
            this.lblReservation5.AutoSize = true;
            this.lblReservation5.Location = new System.Drawing.Point(271, 124);
            this.lblReservation5.Name = "lblReservation5";
            this.lblReservation5.Size = new System.Drawing.Size(47, 20);
            this.lblReservation5.TabIndex = 17;
            this.lblReservation5.Text = "Time:";
            // 
            // lblReservation4
            // 
            this.lblReservation4.AutoSize = true;
            this.lblReservation4.Location = new System.Drawing.Point(6, 124);
            this.lblReservation4.Name = "lblReservation4";
            this.lblReservation4.Size = new System.Drawing.Size(48, 20);
            this.lblReservation4.TabIndex = 16;
            this.lblReservation4.Text = "Date:";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(60, 121);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(205, 26);
            this.tbDate.TabIndex = 13;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(324, 121);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(205, 26);
            this.tbTime.TabIndex = 14;
            // 
            // tbMaxLayovers
            // 
            this.tbMaxLayovers.Location = new System.Drawing.Point(176, 89);
            this.tbMaxLayovers.Name = "tbMaxLayovers";
            this.tbMaxLayovers.Size = new System.Drawing.Size(354, 26);
            this.tbMaxLayovers.TabIndex = 12;
            // 
            // lblReservation3
            // 
            this.lblReservation3.AutoSize = true;
            this.lblReservation3.Location = new System.Drawing.Point(6, 92);
            this.lblReservation3.Name = "lblReservation3";
            this.lblReservation3.Size = new System.Drawing.Size(147, 20);
            this.lblReservation3.TabIndex = 12;
            this.lblReservation3.Text = "Maximum Layovers:";
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(176, 57);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(354, 26);
            this.tbStart.TabIndex = 11;
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(176, 25);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(354, 26);
            this.tbDestination.TabIndex = 10;
            // 
            // btnFindFlights
            // 
            this.btnFindFlights.Location = new System.Drawing.Point(386, 200);
            this.btnFindFlights.Name = "btnFindFlights";
            this.btnFindFlights.Size = new System.Drawing.Size(144, 29);
            this.btnFindFlights.TabIndex = 16;
            this.btnFindFlights.Text = "Find Flights";
            this.btnFindFlights.UseVisualStyleBackColor = true;
            this.btnFindFlights.Click += new System.EventHandler(this.btnFindFlights_Click);
            // 
            // lblReservation2
            // 
            this.lblReservation2.AutoSize = true;
            this.lblReservation2.Location = new System.Drawing.Point(6, 60);
            this.lblReservation2.Name = "lblReservation2";
            this.lblReservation2.Size = new System.Drawing.Size(120, 20);
            this.lblReservation2.TabIndex = 4;
            this.lblReservation2.Text = "Starting Airport:";
            // 
            // lblReservation1
            // 
            this.lblReservation1.AutoSize = true;
            this.lblReservation1.Location = new System.Drawing.Point(6, 28);
            this.lblReservation1.Name = "lblReservation1";
            this.lblReservation1.Size = new System.Drawing.Size(94, 20);
            this.lblReservation1.TabIndex = 2;
            this.lblReservation1.Text = "Destination:";
            // 
            // tbSeats
            // 
            this.tbSeats.Location = new System.Drawing.Point(176, 153);
            this.tbSeats.Name = "tbSeats";
            this.tbSeats.Size = new System.Drawing.Size(354, 26);
            this.tbSeats.TabIndex = 15;
            // 
            // lblReservation6
            // 
            this.lblReservation6.AutoSize = true;
            this.lblReservation6.Location = new System.Drawing.Point(6, 156);
            this.lblReservation6.Name = "lblReservation6";
            this.lblReservation6.Size = new System.Drawing.Size(55, 20);
            this.lblReservation6.TabIndex = 0;
            this.lblReservation6.Text = "Seats:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 682);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Flight Reservation";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gpPartreservations.ResumeLayout(false);
            this.gpPartreservations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartReservations)).EndInit();
            this.gpSearchReservation.ResumeLayout(false);
            this.gpSearchReservation.PerformLayout();
            this.gbNewReservation.ResumeLayout(false);
            this.gbNewReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gpPartreservations;
        private System.Windows.Forms.GroupBox gpSearchReservation;
        private System.Windows.Forms.GroupBox gbNewReservation;
        private System.Windows.Forms.Button btnFindFlights;
        private System.Windows.Forms.Button btnSearchReservation;
        private System.Windows.Forms.TextBox tbReservationNo;
        private System.Windows.Forms.DataGridView dgvPartReservations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCustomer1;
        private System.Windows.Forms.Label lblCustomer2;
        private System.Windows.Forms.Label lblCustomer3;
        private System.Windows.Forms.Label lblCustomer4;
        private System.Windows.Forms.Label lblCustomer5;
        private System.Windows.Forms.Label lblCustomer6;
        private System.Windows.Forms.Label lblCustomer7;
        private System.Windows.Forms.Label lblCustomer8;
        private System.Windows.Forms.Label lblReservation1;
        private System.Windows.Forms.Label lblReservation2;
        private System.Windows.Forms.Label lblReservation3;
        private System.Windows.Forms.Label lblReservation4;
        private System.Windows.Forms.Label lblReservation5;
        private System.Windows.Forms.Label lblReservation6;
        private System.Windows.Forms.Label lblReservation7;
        private System.Windows.Forms.Label lblCustomerNo;
        private System.Windows.Forms.Label lblCustomerSuccess;
        private System.Windows.Forms.Label lblReservationSuccess;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchPhone;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.TextBox tbMaxLayovers;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbSeats;
        private System.Windows.Forms.Button btnCreateReservation;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private System.Windows.Forms.RichTextBox rtbCustomerInfo;
        private System.Windows.Forms.Button btnReservationBack;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label lblReservation8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnArrivalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFlightNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPrice;
    }
}

