namespace Arline_ticket_booking_system_kan_saxda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxPersonalInformation = new GroupBox();
            txtBaggageWeight = new TextBox();
            txtNumberOfTickets = new TextBox();
            txtPassengerAge = new TextBox();
            lblBaggageWeight = new Label();
            lblNumberOfTickets = new Label();
            lblPassengerAge = new Label();
            txtPassengerName = new TextBox();
            lblPassengerName = new Label();
            lstBookingDetails = new ListBox();
            chkTravelInsurance = new CheckBox();
            rdoFirstClass = new RadioButton();
            rdoBusinessClass = new RadioButton();
            rdoNormalClass = new RadioButton();
            lblTravalClass = new Label();
            lblAdditionalOptions = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxPersonalInformation.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPersonalInformation
            // 
            groupBoxPersonalInformation.BackColor = SystemColors.GradientActiveCaption;
            groupBoxPersonalInformation.Controls.Add(txtBaggageWeight);
            groupBoxPersonalInformation.Controls.Add(txtNumberOfTickets);
            groupBoxPersonalInformation.Controls.Add(txtPassengerAge);
            groupBoxPersonalInformation.Controls.Add(lblBaggageWeight);
            groupBoxPersonalInformation.Controls.Add(lblNumberOfTickets);
            groupBoxPersonalInformation.Controls.Add(lblPassengerAge);
            groupBoxPersonalInformation.Controls.Add(txtPassengerName);
            groupBoxPersonalInformation.Controls.Add(lblPassengerName);
            groupBoxPersonalInformation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxPersonalInformation.ForeColor = SystemColors.ActiveCaptionText;
            groupBoxPersonalInformation.Location = new Point(6, 6);
            groupBoxPersonalInformation.Name = "groupBoxPersonalInformation";
            groupBoxPersonalInformation.Size = new Size(508, 337);
            groupBoxPersonalInformation.TabIndex = 0;
            groupBoxPersonalInformation.TabStop = false;
            groupBoxPersonalInformation.Text = "personal information";
            // 
            // txtBaggageWeight
            // 
            txtBaggageWeight.Location = new Point(270, 226);
            txtBaggageWeight.Name = "txtBaggageWeight";
            txtBaggageWeight.Size = new Size(232, 45);
            txtBaggageWeight.TabIndex = 8;
            // 
            // txtNumberOfTickets
            // 
            txtNumberOfTickets.Location = new Point(270, 162);
            txtNumberOfTickets.Name = "txtNumberOfTickets";
            txtNumberOfTickets.Size = new Size(232, 45);
            txtNumberOfTickets.TabIndex = 7;
            // 
            // txtPassengerAge
            // 
            txtPassengerAge.Location = new Point(270, 95);
            txtPassengerAge.Name = "txtPassengerAge";
            txtPassengerAge.Size = new Size(232, 45);
            txtPassengerAge.TabIndex = 6;
            // 
            // lblBaggageWeight
            // 
            lblBaggageWeight.AutoSize = true;
            lblBaggageWeight.Location = new Point(26, 226);
            lblBaggageWeight.Name = "lblBaggageWeight";
            lblBaggageWeight.Size = new Size(217, 38);
            lblBaggageWeight.TabIndex = 5;
            lblBaggageWeight.Text = "bagaaga weigh :";
            // 
            // lblNumberOfTickets
            // 
            lblNumberOfTickets.AutoSize = true;
            lblNumberOfTickets.Location = new Point(28, 162);
            lblNumberOfTickets.Name = "lblNumberOfTickets";
            lblNumberOfTickets.Size = new Size(236, 38);
            lblNumberOfTickets.TabIndex = 4;
            lblNumberOfTickets.Text = "number of ticket :";
            // 
            // lblPassengerAge
            // 
            lblPassengerAge.AutoSize = true;
            lblPassengerAge.Location = new Point(33, 95);
            lblPassengerAge.Name = "lblPassengerAge";
            lblPassengerAge.Size = new Size(210, 38);
            lblPassengerAge.TabIndex = 3;
            lblPassengerAge.Text = "passenger age :";
            // 
            // txtPassengerName
            // 
            txtPassengerName.Location = new Point(270, 42);
            txtPassengerName.Name = "txtPassengerName";
            txtPassengerName.Size = new Size(232, 45);
            txtPassengerName.TabIndex = 1;
            // 
            // lblPassengerName
            // 
            lblPassengerName.AutoSize = true;
            lblPassengerName.Location = new Point(33, 45);
            lblPassengerName.Name = "lblPassengerName";
            lblPassengerName.Size = new Size(234, 38);
            lblPassengerName.TabIndex = 0;
            lblPassengerName.Text = "passenger name :";
            // 
            // lstBookingDetails
            // 
            lstBookingDetails.FormattingEnabled = true;
            lstBookingDetails.ItemHeight = 25;
            lstBookingDetails.Location = new Point(692, 48);
            lstBookingDetails.Name = "lstBookingDetails";
            lstBookingDetails.Size = new Size(320, 454);
            lstBookingDetails.TabIndex = 1;
            // 
            // chkTravelInsurance
            // 
            chkTravelInsurance.AutoSize = true;
            chkTravelInsurance.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTravelInsurance.Location = new Point(21, 556);
            chkTravelInsurance.Name = "chkTravelInsurance";
            chkTravelInsurance.Size = new Size(477, 42);
            chkTravelInsurance.TabIndex = 2;
            chkTravelInsurance.Text = "add travel insurance ($25 pre ticket";
            chkTravelInsurance.UseVisualStyleBackColor = true;
            // 
            // rdoFirstClass
            // 
            rdoFirstClass.AutoSize = true;
            rdoFirstClass.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoFirstClass.Location = new Point(6, 404);
            rdoFirstClass.Name = "rdoFirstClass";
            rdoFirstClass.Size = new Size(164, 42);
            rdoFirstClass.TabIndex = 2;
            rdoFirstClass.TabStop = true;
            rdoFirstClass.Text = "Frist Class";
            rdoFirstClass.UseVisualStyleBackColor = true;
            // 
            // rdoBusinessClass
            // 
            rdoBusinessClass.AutoSize = true;
            rdoBusinessClass.Font = new Font("Segoe UI", 14F);
            rdoBusinessClass.Location = new Point(395, 404);
            rdoBusinessClass.Name = "rdoBusinessClass";
            rdoBusinessClass.Size = new Size(242, 42);
            rdoBusinessClass.TabIndex = 3;
            rdoBusinessClass.TabStop = true;
            rdoBusinessClass.Text = "Bussinness class";
            rdoBusinessClass.UseVisualStyleBackColor = true;
            // 
            // rdoNormalClass
            // 
            rdoNormalClass.AutoSize = true;
            rdoNormalClass.Font = new Font("Segoe UI", 14F);
            rdoNormalClass.Location = new Point(191, 404);
            rdoNormalClass.Name = "rdoNormalClass";
            rdoNormalClass.Size = new Size(200, 42);
            rdoNormalClass.TabIndex = 4;
            rdoNormalClass.TabStop = true;
            rdoNormalClass.Text = "Normal class";
            rdoNormalClass.UseVisualStyleBackColor = true;
            // 
            // lblTravalClass
            // 
            lblTravalClass.AutoSize = true;
            lblTravalClass.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTravalClass.Location = new Point(21, 346);
            lblTravalClass.Name = "lblTravalClass";
            lblTravalClass.Size = new Size(177, 45);
            lblTravalClass.TabIndex = 5;
            lblTravalClass.Text = "Travel class";
            lblTravalClass.Click += label5_Click;
            // 
            // lblAdditionalOptions
            // 
            lblAdditionalOptions.AutoSize = true;
            lblAdditionalOptions.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdditionalOptions.Location = new Point(21, 475);
            lblAdditionalOptions.Name = "lblAdditionalOptions";
            lblAdditionalOptions.Size = new Size(227, 38);
            lblAdditionalOptions.TabIndex = 6;
            lblAdditionalOptions.Text = "additional option";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(69, 615);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(129, 43);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(335, 615);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 43);
            btnClear.TabIndex = 8;
            btnClear.Text = "clear ";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(604, 615);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 43);
            btnExit.TabIndex = 9;
            btnExit.Text = "exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 670);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblAdditionalOptions);
            Controls.Add(lblTravalClass);
            Controls.Add(rdoNormalClass);
            Controls.Add(rdoBusinessClass);
            Controls.Add(chkTravelInsurance);
            Controls.Add(lstBookingDetails);
            Controls.Add(rdoFirstClass);
            Controls.Add(groupBoxPersonalInformation);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxPersonalInformation.ResumeLayout(false);
            groupBoxPersonalInformation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxPersonalInformation;
        private Label lblNumberOfTickets;
        private Label lblPassengerAge;
        private TextBox txtPassengerName;
        private Label lblPassengerName;
        private ListBox lstBookingDetails;
        private CheckBox chkTravelInsurance;
        private RadioButton rdoFirstClass;
        private TextBox txtBaggageWeight;
        private TextBox txtNumberOfTickets;
        private TextBox txtPassengerAge;
        private Label lblBaggageWeight;
        private RadioButton rdoBusinessClass;
        private RadioButton rdoNormalClass;
        private Label lblTravalClass;
        private Label lblAdditionalOptions;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
