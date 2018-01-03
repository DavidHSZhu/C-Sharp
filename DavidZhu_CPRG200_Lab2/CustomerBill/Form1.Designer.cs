namespace CustomerBill
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
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.lblChargeRes = new System.Windows.Forms.Label();
            this.lblChargeComm = new System.Windows.Forms.Label();
            this.lblChargeInd = new System.Windows.Forms.Label();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.lblCustList = new System.Windows.Forms.Label();
            this.txtCustNum = new System.Windows.Forms.TextBox();
            this.txtResCharge = new System.Windows.Forms.TextBox();
            this.txtCommCharge = new System.Windows.Forms.TextBox();
            this.txtIndCharge = new System.Windows.Forms.TextBox();
            this.txtTotalCharge = new System.Windows.Forms.TextBox();
            this.cmbCustTye = new System.Windows.Forms.ComboBox();
            this.lblCusType = new System.Windows.Forms.Label();
            this.txtGenPower = new System.Windows.Forms.TextBox();
            this.txtPowerHour = new System.Windows.Forms.TextBox();
            this.txtPowerOff = new System.Windows.Forms.TextBox();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblAccunt = new System.Windows.Forms.Label();
            this.txtAccuntNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPowerOff = new System.Windows.Forms.Label();
            this.lblPowerHours = new System.Windows.Forms.Label();
            this.lblGernPower = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(492, 43);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(422, 368);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.AutoSize = true;
            this.lblCustomerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNumber.Location = new System.Drawing.Point(499, 441);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(171, 16);
            this.lblCustomerNumber.TabIndex = 1;
            this.lblCustomerNumber.Text = "Total Number of Customers";
            this.lblCustomerNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblChargeRes
            // 
            this.lblChargeRes.AutoSize = true;
            this.lblChargeRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChargeRes.Location = new System.Drawing.Point(499, 483);
            this.lblChargeRes.Name = "lblChargeRes";
            this.lblChargeRes.Size = new System.Drawing.Size(215, 16);
            this.lblChargeRes.TabIndex = 2;
            this.lblChargeRes.Text = "Charges for Residential Customers";
            this.lblChargeRes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblChargeComm
            // 
            this.lblChargeComm.AutoSize = true;
            this.lblChargeComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChargeComm.Location = new System.Drawing.Point(499, 525);
            this.lblChargeComm.Name = "lblChargeComm";
            this.lblChargeComm.Size = new System.Drawing.Size(219, 16);
            this.lblChargeComm.TabIndex = 3;
            this.lblChargeComm.Text = "Charges for Commercial Customers";
            this.lblChargeComm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblChargeInd
            // 
            this.lblChargeInd.AutoSize = true;
            this.lblChargeInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChargeInd.Location = new System.Drawing.Point(499, 556);
            this.lblChargeInd.Name = "lblChargeInd";
            this.lblChargeInd.Size = new System.Drawing.Size(200, 16);
            this.lblChargeInd.TabIndex = 4;
            this.lblChargeInd.Text = "Charges for Industrial Customers";
            this.lblChargeInd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.AutoSize = true;
            this.lblTotalCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCharge.Location = new System.Drawing.Point(498, 593);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(196, 16);
            this.lblTotalCharge.TabIndex = 5;
            this.lblTotalCharge.Text = "Total Charges for All Customers";
            this.lblTotalCharge.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCustList
            // 
            this.lblCustList.AutoSize = true;
            this.lblCustList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustList.ForeColor = System.Drawing.Color.Green;
            this.lblCustList.Location = new System.Drawing.Point(627, 9);
            this.lblCustList.Name = "lblCustList";
            this.lblCustList.Size = new System.Drawing.Size(115, 18);
            this.lblCustList.TabIndex = 6;
            this.lblCustList.Text = "Customer Info";
            this.lblCustList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCustNum
            // 
            this.txtCustNum.Location = new System.Drawing.Point(758, 437);
            this.txtCustNum.Name = "txtCustNum";
            this.txtCustNum.Size = new System.Drawing.Size(156, 20);
            this.txtCustNum.TabIndex = 7;
            // 
            // txtResCharge
            // 
            this.txtResCharge.Location = new System.Drawing.Point(758, 479);
            this.txtResCharge.Name = "txtResCharge";
            this.txtResCharge.Size = new System.Drawing.Size(156, 20);
            this.txtResCharge.TabIndex = 8;
            // 
            // txtCommCharge
            // 
            this.txtCommCharge.Location = new System.Drawing.Point(758, 521);
            this.txtCommCharge.Name = "txtCommCharge";
            this.txtCommCharge.Size = new System.Drawing.Size(156, 20);
            this.txtCommCharge.TabIndex = 9;
            // 
            // txtIndCharge
            // 
            this.txtIndCharge.Location = new System.Drawing.Point(758, 556);
            this.txtIndCharge.Name = "txtIndCharge";
            this.txtIndCharge.Size = new System.Drawing.Size(156, 20);
            this.txtIndCharge.TabIndex = 10;
            // 
            // txtTotalCharge
            // 
            this.txtTotalCharge.Location = new System.Drawing.Point(758, 589);
            this.txtTotalCharge.Name = "txtTotalCharge";
            this.txtTotalCharge.Size = new System.Drawing.Size(156, 20);
            this.txtTotalCharge.TabIndex = 11;
            // 
            // cmbCustTye
            // 
            this.cmbCustTye.FormattingEnabled = true;
            this.cmbCustTye.Location = new System.Drawing.Point(185, 34);
            this.cmbCustTye.Name = "cmbCustTye";
            this.cmbCustTye.Size = new System.Drawing.Size(188, 24);
            this.cmbCustTye.TabIndex = 12;
            this.cmbCustTye.SelectedIndexChanged += new System.EventHandler(this.cmbCustTye_SelectedIndexChanged);
            // 
            // lblCusType
            // 
            this.lblCusType.AutoSize = true;
            this.lblCusType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusType.Location = new System.Drawing.Point(41, 34);
            this.lblCusType.Name = "lblCusType";
            this.lblCusType.Size = new System.Drawing.Size(100, 16);
            this.lblCusType.TabIndex = 13;
            this.lblCusType.Text = "Customer Type";
            this.lblCusType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGenPower
            // 
            this.txtGenPower.Location = new System.Drawing.Point(185, 185);
            this.txtGenPower.Name = "txtGenPower";
            this.txtGenPower.Size = new System.Drawing.Size(188, 22);
            this.txtGenPower.TabIndex = 14;
            // 
            // txtPowerHour
            // 
            this.txtPowerHour.Location = new System.Drawing.Point(185, 239);
            this.txtPowerHour.Name = "txtPowerHour";
            this.txtPowerHour.Size = new System.Drawing.Size(188, 22);
            this.txtPowerHour.TabIndex = 15;
            // 
            // txtPowerOff
            // 
            this.txtPowerOff.Location = new System.Drawing.Point(185, 291);
            this.txtPowerOff.Name = "txtPowerOff";
            this.txtPowerOff.Size = new System.Drawing.Size(188, 22);
            this.txtPowerOff.TabIndex = 16;
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(185, 341);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(188, 22);
            this.txtBill.TabIndex = 17;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.lblCustName);
            this.grpInput.Controls.Add(this.txtCustName);
            this.grpInput.Controls.Add(this.lblAccunt);
            this.grpInput.Controls.Add(this.txtAccuntNo);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Controls.Add(this.lblPowerOff);
            this.grpInput.Controls.Add(this.lblPowerHours);
            this.grpInput.Controls.Add(this.lblGernPower);
            this.grpInput.Controls.Add(this.lblCusType);
            this.grpInput.Controls.Add(this.txtBill);
            this.grpInput.Controls.Add(this.cmbCustTye);
            this.grpInput.Controls.Add(this.txtPowerOff);
            this.grpInput.Controls.Add(this.txtGenPower);
            this.grpInput.Controls.Add(this.txtPowerHour);
            this.grpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.Location = new System.Drawing.Point(23, 30);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(450, 381);
            this.grpInput.TabIndex = 18;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Custmer Input Info";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(36, 143);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(105, 16);
            this.lblCustName.TabIndex = 25;
            this.lblCustName.Text = "Customer Name";
            this.lblCustName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(185, 137);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(188, 22);
            this.txtCustName.TabIndex = 24;
            // 
            // lblAccunt
            // 
            this.lblAccunt.AutoSize = true;
            this.lblAccunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccunt.Location = new System.Drawing.Point(53, 89);
            this.lblAccunt.Name = "lblAccunt";
            this.lblAccunt.Size = new System.Drawing.Size(77, 16);
            this.lblAccunt.TabIndex = 23;
            this.lblAccunt.Text = "Account No";
            this.lblAccunt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAccuntNo
            // 
            this.txtAccuntNo.Location = new System.Drawing.Point(185, 86);
            this.txtAccuntNo.Name = "txtAccuntNo";
            this.txtAccuntNo.Size = new System.Drawing.Size(188, 22);
            this.txtAccuntNo.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Bills of Power";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPowerOff
            // 
            this.lblPowerOff.AutoSize = true;
            this.lblPowerOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerOff.Location = new System.Drawing.Point(36, 297);
            this.lblPowerOff.Name = "lblPowerOff";
            this.lblPowerOff.Size = new System.Drawing.Size(110, 16);
            this.lblPowerOff.TabIndex = 20;
            this.lblPowerOff.Text = "KWH of PowerOff";
            this.lblPowerOff.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPowerHours
            // 
            this.lblPowerHours.AutoSize = true;
            this.lblPowerHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerHours.Location = new System.Drawing.Point(21, 239);
            this.lblPowerHours.Name = "lblPowerHours";
            this.lblPowerHours.Size = new System.Drawing.Size(130, 16);
            this.lblPowerHours.TabIndex = 19;
            this.lblPowerHours.Text = "KWH of PowerHours";
            this.lblPowerHours.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGernPower
            // 
            this.lblGernPower.AutoSize = true;
            this.lblGernPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGernPower.Location = new System.Drawing.Point(6, 191);
            this.lblGernPower.Name = "lblGernPower";
            this.lblGernPower.Size = new System.Drawing.Size(145, 16);
            this.lblGernPower.TabIndex = 18;
            this.lblGernPower.Text = "KWH of General Power";
            this.lblGernPower.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 54);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 58);
            this.button1.TabIndex = 20;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(310, 466);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(130, 57);
            this.butExit.TabIndex = 21;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 648);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.txtTotalCharge);
            this.Controls.Add(this.txtIndCharge);
            this.Controls.Add(this.txtCommCharge);
            this.Controls.Add(this.txtResCharge);
            this.Controls.Add(this.txtCustNum);
            this.Controls.Add(this.lblCustList);
            this.Controls.Add(this.lblTotalCharge);
            this.Controls.Add(this.lblChargeInd);
            this.Controls.Add(this.lblChargeComm);
            this.Controls.Add(this.lblChargeRes);
            this.Controls.Add(this.lblCustomerNumber);
            this.Controls.Add(this.lstCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.Label lblChargeRes;
        private System.Windows.Forms.Label lblChargeComm;
        private System.Windows.Forms.Label lblChargeInd;
        private System.Windows.Forms.Label lblTotalCharge;
        private System.Windows.Forms.Label lblCustList;
        private System.Windows.Forms.TextBox txtCustNum;
        private System.Windows.Forms.TextBox txtResCharge;
        private System.Windows.Forms.TextBox txtCommCharge;
        private System.Windows.Forms.TextBox txtIndCharge;
        private System.Windows.Forms.TextBox txtTotalCharge;
        private System.Windows.Forms.ComboBox cmbCustTye;
        private System.Windows.Forms.Label lblCusType;
        private System.Windows.Forms.TextBox txtGenPower;
        private System.Windows.Forms.TextBox txtPowerHour;
        private System.Windows.Forms.TextBox txtPowerOff;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPowerOff;
        private System.Windows.Forms.Label lblPowerHours;
        private System.Windows.Forms.Label lblGernPower;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblAccunt;
        private System.Windows.Forms.TextBox txtAccuntNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butExit;
    }
}

