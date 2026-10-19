namespace hotel_bookin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBookingDetails = new System.Windows.Forms.ListBox();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuestAge = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoHight = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.chkBreakfast);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.rdoHight);
            this.groupBox1.Controls.Add(this.rdoNormal);
            this.groupBox1.Controls.Add(this.txtGuests);
            this.groupBox1.Controls.Add(this.txtNights);
            this.groupBox1.Controls.Add(this.txtGuestAge);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGuestName);
            this.groupBox1.Controls.Add(this.rdoStandard);
            this.groupBox1.Controls.Add(this.lstBookingDetails);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 550);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(24, 466);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(153, 53);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guest Name :";
            // 
            // lstBookingDetails
            // 
            this.lstBookingDetails.FormattingEnabled = true;
            this.lstBookingDetails.ItemHeight = 20;
            this.lstBookingDetails.Location = new System.Drawing.Point(625, 38);
            this.lstBookingDetails.Name = "lstBookingDetails";
            this.lstBookingDetails.Size = new System.Drawing.Size(281, 404);
            this.lstBookingDetails.TabIndex = 3;
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStandard.Location = new System.Drawing.Point(12, 276);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(150, 36);
            this.rdoStandard.TabIndex = 4;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "standred";
            this.rdoStandard.UseVisualStyleBackColor = true;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.Location = new System.Drawing.Point(254, 38);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(272, 39);
            this.txtGuestName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Guest Age :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number Of Nights :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number Of Guests:";
            // 
            // txtGuestAge
            // 
            this.txtGuestAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestAge.Location = new System.Drawing.Point(254, 93);
            this.txtGuestAge.Name = "txtGuestAge";
            this.txtGuestAge.Size = new System.Drawing.Size(272, 39);
            this.txtGuestAge.TabIndex = 9;
            // 
            // txtNights
            // 
            this.txtNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNights.Location = new System.Drawing.Point(254, 138);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(272, 39);
            this.txtNights.TabIndex = 10;
            // 
            // txtGuests
            // 
            this.txtGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuests.Location = new System.Drawing.Point(254, 185);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(272, 39);
            this.txtGuests.TabIndex = 11;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormal.Location = new System.Drawing.Point(220, 276);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(130, 36);
            this.rdoNormal.TabIndex = 12;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoHight
            // 
            this.rdoHight.AutoSize = true;
            this.rdoHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHight.Location = new System.Drawing.Point(428, 276);
            this.rdoHight.Name = "rdoHight";
            this.rdoHight.Size = new System.Drawing.Size(106, 36);
            this.rdoHight.TabIndex = 13;
            this.rdoHight.TabStop = true;
            this.rdoHight.Text = "Hight";
            this.rdoHight.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(201, 466);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 53);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(402, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 53);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exite";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Room Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Additional Option";
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBreakfast.Location = new System.Drawing.Point(24, 385);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(487, 36);
            this.chkBreakfast.TabIndex = 18;
            this.chkBreakfast.Text = "Break Fast (10 per Guast Per Night ";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 565);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoHight;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtGuestAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.ListBox lstBookingDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkBreakfast;
    }
}

