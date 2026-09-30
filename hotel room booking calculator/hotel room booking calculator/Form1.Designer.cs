namespace hotel_room_booking_calculator
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
            this.lblGuestName = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblNamberOfNight = new System.Windows.Forms.Label();
            this.lblPricePerNight = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtPriceNight = new System.Windows.Forms.TextBox();
            this.lblServiceTaxt = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtServiceTaxt = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(107, 46);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(255, 36);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "Enter guest name:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(188, 268);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(185, 63);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGuestName
            // 
            this.txtGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.Location = new System.Drawing.Point(432, 46);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(272, 41);
            this.txtGuestName.TabIndex = 2;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(107, 95);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(233, 36);
            this.lblRoomType.TabIndex = 3;
            this.lblRoomType.Text = "Enter room type:";
            // 
            // lblNamberOfNight
            // 
            this.lblNamberOfNight.AutoSize = true;
            this.lblNamberOfNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamberOfNight.Location = new System.Drawing.Point(107, 142);
            this.lblNamberOfNight.Name = "lblNamberOfNight";
            this.lblNamberOfNight.Size = new System.Drawing.Size(327, 36);
            this.lblNamberOfNight.TabIndex = 4;
            this.lblNamberOfNight.Text = "Enter numbar per night:";
            // 
            // lblPricePerNight
            // 
            this.lblPricePerNight.AutoSize = true;
            this.lblPricePerNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerNight.Location = new System.Drawing.Point(107, 196);
            this.lblPricePerNight.Name = "lblPricePerNight";
            this.lblPricePerNight.Size = new System.Drawing.Size(292, 36);
            this.lblPricePerNight.TabIndex = 5;
            this.lblPricePerNight.Text = "Enter price per night:";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.Location = new System.Drawing.Point(432, 95);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(272, 41);
            this.txtRoomType.TabIndex = 6;
            // 
            // txtNights
            // 
            this.txtNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNights.Location = new System.Drawing.Point(432, 142);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(272, 41);
            this.txtNights.TabIndex = 7;
            this.txtNights.TextChanged += new System.EventHandler(this.txtNights_TextChanged);
            // 
            // txtPriceNight
            // 
            this.txtPriceNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceNight.Location = new System.Drawing.Point(432, 196);
            this.txtPriceNight.Name = "txtPriceNight";
            this.txtPriceNight.Size = new System.Drawing.Size(272, 41);
            this.txtPriceNight.TabIndex = 8;
            // 
            // lblServiceTaxt
            // 
            this.lblServiceTaxt.AutoSize = true;
            this.lblServiceTaxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceTaxt.Location = new System.Drawing.Point(107, 367);
            this.lblServiceTaxt.Name = "lblServiceTaxt";
            this.lblServiceTaxt.Size = new System.Drawing.Size(156, 36);
            this.lblServiceTaxt.TabIndex = 9;
            this.lblServiceTaxt.Text = "service tax";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountAmount.Location = new System.Drawing.Point(107, 424);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(234, 36);
            this.lblDiscountAmount.TabIndex = 10;
            this.lblDiscountAmount.Text = "discount amount";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(107, 479);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(203, 36);
            this.lblTotalAmount.TabIndex = 11;
            this.lblTotalAmount.Text = "Total amount :";
            // 
            // txtServiceTaxt
            // 
            this.txtServiceTaxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceTaxt.Location = new System.Drawing.Point(368, 362);
            this.txtServiceTaxt.Name = "txtServiceTaxt";
            this.txtServiceTaxt.Size = new System.Drawing.Size(272, 41);
            this.txtServiceTaxt.TabIndex = 12;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountAmount.Location = new System.Drawing.Point(368, 424);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Size = new System.Drawing.Size(272, 41);
            this.txtDiscountAmount.TabIndex = 13;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(368, 479);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(272, 41);
            this.txtTotalAmount.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(438, 268);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(210, 62);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 601);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtServiceTaxt);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblServiceTaxt);
            this.Controls.Add(this.txtPriceNight);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.lblPricePerNight);
            this.Controls.Add(this.lblNamberOfNight);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblGuestName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblNamberOfNight;
        private System.Windows.Forms.Label lblPricePerNight;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtPriceNight;
        private System.Windows.Forms.Label lblServiceTaxt;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtServiceTaxt;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btnClear;
    }
}

