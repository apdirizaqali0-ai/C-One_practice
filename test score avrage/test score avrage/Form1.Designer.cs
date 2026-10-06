namespace test_score_avrage
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
            this.txtTestScore1 = new System.Windows.Forms.TextBox();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.lblTextScore1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTextScore2 = new System.Windows.Forms.Label();
            this.lblTextScore3 = new System.Windows.Forms.Label();
            this.lblAvrage = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtTestScore3 = new System.Windows.Forms.TextBox();
            this.txtTestScore2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTestScore1
            // 
            this.txtTestScore1.Location = new System.Drawing.Point(395, 70);
            this.txtTestScore1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTestScore1.Name = "txtTestScore1";
            this.txtTestScore1.Size = new System.Drawing.Size(249, 30);
            this.txtTestScore1.TabIndex = 0;
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(186, 400);
            this.btnCalculateAverage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(137, 71);
            this.btnCalculateAverage.TabIndex = 1;
            this.btnCalculateAverage.Text = "caculate average";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // lblTextScore1
            // 
            this.lblTextScore1.AutoSize = true;
            this.lblTextScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextScore1.Location = new System.Drawing.Point(155, 58);
            this.lblTextScore1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextScore1.Name = "lblTextScore1";
            this.lblTextScore1.Size = new System.Drawing.Size(232, 42);
            this.lblTextScore1.TabIndex = 2;
            this.lblTextScore1.Text = "test score #1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(384, 391);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 42);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(384, 458);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 36);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTextScore2
            // 
            this.lblTextScore2.AutoSize = true;
            this.lblTextScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextScore2.Location = new System.Drawing.Point(150, 128);
            this.lblTextScore2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextScore2.Name = "lblTextScore2";
            this.lblTextScore2.Size = new System.Drawing.Size(232, 42);
            this.lblTextScore2.TabIndex = 6;
            this.lblTextScore2.Text = "test score #2";
            // 
            // lblTextScore3
            // 
            this.lblTextScore3.AutoSize = true;
            this.lblTextScore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextScore3.Location = new System.Drawing.Point(150, 197);
            this.lblTextScore3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextScore3.Name = "lblTextScore3";
            this.lblTextScore3.Size = new System.Drawing.Size(232, 42);
            this.lblTextScore3.TabIndex = 7;
            this.lblTextScore3.Text = "test score #3";
            // 
            // lblAvrage
            // 
            this.lblAvrage.AutoSize = true;
            this.lblAvrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvrage.Location = new System.Drawing.Point(224, 284);
            this.lblAvrage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvrage.Name = "lblAvrage";
            this.lblAvrage.Size = new System.Drawing.Size(158, 42);
            this.lblAvrage.TabIndex = 8;
            this.lblAvrage.Text = "Average";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(395, 296);
            this.txtAverage.Margin = new System.Windows.Forms.Padding(4);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(249, 30);
            this.txtAverage.TabIndex = 9;
            this.txtAverage.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTestScore3
            // 
            this.txtTestScore3.Location = new System.Drawing.Point(395, 209);
            this.txtTestScore3.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestScore3.Name = "txtTestScore3";
            this.txtTestScore3.Size = new System.Drawing.Size(249, 30);
            this.txtTestScore3.TabIndex = 10;
            // 
            // txtTestScore2
            // 
            this.txtTestScore2.Location = new System.Drawing.Point(395, 140);
            this.txtTestScore2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestScore2.Name = "txtTestScore2";
            this.txtTestScore2.Size = new System.Drawing.Size(249, 30);
            this.txtTestScore2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 580);
            this.Controls.Add(this.txtTestScore2);
            this.Controls.Add(this.txtTestScore3);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.lblAvrage);
            this.Controls.Add(this.lblTextScore3);
            this.Controls.Add(this.lblTextScore2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTextScore1);
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.txtTestScore1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTestScore1;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.Label lblTextScore1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTextScore2;
        private System.Windows.Forms.Label lblTextScore3;
        private System.Windows.Forms.Label lblAvrage;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtTestScore3;
        private System.Windows.Forms.TextBox txtTestScore2;
    }
}

