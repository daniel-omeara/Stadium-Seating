namespace Stadium_Seating
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
            this.groupBoxTicketsSold = new System.Windows.Forms.GroupBox();
            this.textBoxClassC = new System.Windows.Forms.TextBox();
            this.textBoxClassB = new System.Windows.Forms.TextBox();
            this.textBoxClassA = new System.Windows.Forms.TextBox();
            this.labelClassC = new System.Windows.Forms.Label();
            this.labelClassB = new System.Windows.Forms.Label();
            this.labelClassA = new System.Windows.Forms.Label();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.groupBoxRevenueGenerated = new System.Windows.Forms.GroupBox();
            this.labelTotalRevenue = new System.Windows.Forms.Label();
            this.labelClassCRevenue = new System.Windows.Forms.Label();
            this.labelClassBRevenue = new System.Windows.Forms.Label();
            this.labelClassARevenue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCalculateRevenue = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxTicketsSold.SuspendLayout();
            this.groupBoxRevenueGenerated.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTicketsSold
            // 
            this.groupBoxTicketsSold.Controls.Add(this.textBoxClassC);
            this.groupBoxTicketsSold.Controls.Add(this.textBoxClassB);
            this.groupBoxTicketsSold.Controls.Add(this.textBoxClassA);
            this.groupBoxTicketsSold.Controls.Add(this.labelClassC);
            this.groupBoxTicketsSold.Controls.Add(this.labelClassB);
            this.groupBoxTicketsSold.Controls.Add(this.labelClassA);
            this.groupBoxTicketsSold.Controls.Add(this.labelInstructions);
            this.groupBoxTicketsSold.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTicketsSold.Name = "groupBoxTicketsSold";
            this.groupBoxTicketsSold.Size = new System.Drawing.Size(266, 176);
            this.groupBoxTicketsSold.TabIndex = 0;
            this.groupBoxTicketsSold.TabStop = false;
            this.groupBoxTicketsSold.Text = "Tickets Sold";
            // 
            // textBoxClassC
            // 
            this.textBoxClassC.Location = new System.Drawing.Point(127, 129);
            this.textBoxClassC.Name = "textBoxClassC";
            this.textBoxClassC.Size = new System.Drawing.Size(100, 23);
            this.textBoxClassC.TabIndex = 6;
            // 
            // textBoxClassB
            // 
            this.textBoxClassB.Location = new System.Drawing.Point(127, 100);
            this.textBoxClassB.Name = "textBoxClassB";
            this.textBoxClassB.Size = new System.Drawing.Size(100, 23);
            this.textBoxClassB.TabIndex = 5;
            // 
            // textBoxClassA
            // 
            this.textBoxClassA.Location = new System.Drawing.Point(127, 71);
            this.textBoxClassA.Name = "textBoxClassA";
            this.textBoxClassA.Size = new System.Drawing.Size(100, 23);
            this.textBoxClassA.TabIndex = 4;
            // 
            // labelClassC
            // 
            this.labelClassC.AutoSize = true;
            this.labelClassC.Location = new System.Drawing.Point(73, 132);
            this.labelClassC.Name = "labelClassC";
            this.labelClassC.Size = new System.Drawing.Size(48, 15);
            this.labelClassC.TabIndex = 3;
            this.labelClassC.Text = "Class C:";
            // 
            // labelClassB
            // 
            this.labelClassB.AutoSize = true;
            this.labelClassB.Location = new System.Drawing.Point(74, 103);
            this.labelClassB.Name = "labelClassB";
            this.labelClassB.Size = new System.Drawing.Size(47, 15);
            this.labelClassB.TabIndex = 2;
            this.labelClassB.Text = "Class B:";
            // 
            // labelClassA
            // 
            this.labelClassA.AutoSize = true;
            this.labelClassA.Location = new System.Drawing.Point(73, 74);
            this.labelClassA.Name = "labelClassA";
            this.labelClassA.Size = new System.Drawing.Size(48, 15);
            this.labelClassA.TabIndex = 1;
            this.labelClassA.Text = "Class A:";
            // 
            // labelInstructions
            // 
            this.labelInstructions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInstructions.Location = new System.Drawing.Point(6, 19);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(210, 31);
            this.labelInstructions.TabIndex = 0;
            this.labelInstructions.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // groupBoxRevenueGenerated
            // 
            this.groupBoxRevenueGenerated.Controls.Add(this.labelTotalRevenue);
            this.groupBoxRevenueGenerated.Controls.Add(this.labelClassCRevenue);
            this.groupBoxRevenueGenerated.Controls.Add(this.labelClassBRevenue);
            this.groupBoxRevenueGenerated.Controls.Add(this.labelClassARevenue);
            this.groupBoxRevenueGenerated.Controls.Add(this.label4);
            this.groupBoxRevenueGenerated.Controls.Add(this.label3);
            this.groupBoxRevenueGenerated.Controls.Add(this.label2);
            this.groupBoxRevenueGenerated.Controls.Add(this.label1);
            this.groupBoxRevenueGenerated.Location = new System.Drawing.Point(284, 12);
            this.groupBoxRevenueGenerated.Name = "groupBoxRevenueGenerated";
            this.groupBoxRevenueGenerated.Size = new System.Drawing.Size(266, 176);
            this.groupBoxRevenueGenerated.TabIndex = 1;
            this.groupBoxRevenueGenerated.TabStop = false;
            this.groupBoxRevenueGenerated.Text = "Revenue Generated";
            // 
            // labelTotalRevenue
            // 
            this.labelTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalRevenue.Location = new System.Drawing.Point(113, 125);
            this.labelTotalRevenue.Name = "labelTotalRevenue";
            this.labelTotalRevenue.Size = new System.Drawing.Size(100, 23);
            this.labelTotalRevenue.TabIndex = 7;
            // 
            // labelClassCRevenue
            // 
            this.labelClassCRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelClassCRevenue.Location = new System.Drawing.Point(113, 96);
            this.labelClassCRevenue.Name = "labelClassCRevenue";
            this.labelClassCRevenue.Size = new System.Drawing.Size(100, 23);
            this.labelClassCRevenue.TabIndex = 6;
            // 
            // labelClassBRevenue
            // 
            this.labelClassBRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelClassBRevenue.Location = new System.Drawing.Point(113, 66);
            this.labelClassBRevenue.Name = "labelClassBRevenue";
            this.labelClassBRevenue.Size = new System.Drawing.Size(100, 23);
            this.labelClassBRevenue.TabIndex = 5;
            // 
            // labelClassARevenue
            // 
            this.labelClassARevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelClassARevenue.Location = new System.Drawing.Point(113, 38);
            this.labelClassARevenue.Name = "labelClassARevenue";
            this.labelClassARevenue.Size = new System.Drawing.Size(100, 23);
            this.labelClassARevenue.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class A:";
            // 
            // buttonCalculateRevenue
            // 
            this.buttonCalculateRevenue.Location = new System.Drawing.Point(146, 208);
            this.buttonCalculateRevenue.Name = "buttonCalculateRevenue";
            this.buttonCalculateRevenue.Size = new System.Drawing.Size(75, 40);
            this.buttonCalculateRevenue.TabIndex = 2;
            this.buttonCalculateRevenue.Text = "Calculate Revenue";
            this.buttonCalculateRevenue.UseVisualStyleBackColor = true;
            this.buttonCalculateRevenue.Click += new System.EventHandler(this.buttonCalculateRevenue_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(242, 208);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 40);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(334, 208);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 40);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 259);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculateRevenue);
            this.Controls.Add(this.groupBoxRevenueGenerated);
            this.Controls.Add(this.groupBoxTicketsSold);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxTicketsSold.ResumeLayout(false);
            this.groupBoxTicketsSold.PerformLayout();
            this.groupBoxRevenueGenerated.ResumeLayout(false);
            this.groupBoxRevenueGenerated.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxTicketsSold;
        private TextBox textBoxClassC;
        private TextBox textBoxClassB;
        private TextBox textBoxClassA;
        private Label labelClassC;
        private Label labelClassB;
        private Label labelClassA;
        private Label labelInstructions;
        private GroupBox groupBoxRevenueGenerated;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonCalculateRevenue;
        private Button buttonClear;
        private Button buttonExit;
        private Label labelTotalRevenue;
        private Label labelClassCRevenue;
        private Label labelClassBRevenue;
        private Label labelClassARevenue;
    }
}