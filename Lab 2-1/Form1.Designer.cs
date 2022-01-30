
namespace Lab_2_1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.areaLabel = new System.Windows.Forms.Label();
            this.carpetChargeLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.laborChargeLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.carpetAreaLabel = new System.Windows.Forms.Label();
            this.carpetCharge = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.lChargeLabel = new System.Windows.Forms.Label();
            this.orderTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(65, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(208, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Carpet Calculator";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lengthLabel
            // 
            this.lengthLabel.Location = new System.Drawing.Point(52, 44);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(82, 33);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Carpet Length \r\n      (feet):\r\n";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(140, 44);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(69, 26);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Carpet Width\r\n      (feet):\r\n";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(232, 44);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(65, 26);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Carpet Price\r\n    ($ / sq.ft.)";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(65, 80);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(38, 20);
            this.lengthTextBox.TabIndex = 2;
            this.lengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(152, 80);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(39, 20);
            this.widthTextBox.TabIndex = 4;
            this.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(248, 80);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(38, 20);
            this.priceTextBox.TabIndex = 6;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // areaLabel
            // 
            this.areaLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.areaLabel.Location = new System.Drawing.Point(194, 144);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(71, 23);
            this.areaLabel.TabIndex = 7;
            this.areaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // carpetChargeLabel
            // 
            this.carpetChargeLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.carpetChargeLabel.Location = new System.Drawing.Point(194, 173);
            this.carpetChargeLabel.Name = "carpetChargeLabel";
            this.carpetChargeLabel.Size = new System.Drawing.Size(71, 23);
            this.carpetChargeLabel.TabIndex = 8;
            this.carpetChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.taxLabel.Location = new System.Drawing.Point(194, 204);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(71, 23);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // laborChargeLabel
            // 
            this.laborChargeLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.laborChargeLabel.Location = new System.Drawing.Point(194, 235);
            this.laborChargeLabel.Name = "laborChargeLabel";
            this.laborChargeLabel.Size = new System.Drawing.Size(71, 23);
            this.laborChargeLabel.TabIndex = 10;
            this.laborChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.orderTotalLabel.Location = new System.Drawing.Point(194, 287);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(71, 23);
            this.orderTotalLabel.TabIndex = 11;
            this.orderTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // carpetAreaLabel
            // 
            this.carpetAreaLabel.AutoSize = true;
            this.carpetAreaLabel.Location = new System.Drawing.Point(76, 144);
            this.carpetAreaLabel.Name = "carpetAreaLabel";
            this.carpetAreaLabel.Size = new System.Drawing.Size(101, 13);
            this.carpetAreaLabel.TabIndex = 12;
            this.carpetAreaLabel.Text = "Carpet Area (sq. ft.):";
            // 
            // carpetCharge
            // 
            this.carpetCharge.AutoSize = true;
            this.carpetCharge.Location = new System.Drawing.Point(99, 178);
            this.carpetCharge.Name = "carpetCharge";
            this.carpetCharge.Size = new System.Drawing.Size(78, 13);
            this.carpetCharge.TabIndex = 13;
            this.carpetCharge.Text = "Carpet Charge:";
            this.carpetCharge.Click += new System.EventHandler(this.carpetCharge_Click);
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(39, 214);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(138, 13);
            this.salesTaxLabel.TabIndex = 14;
            this.salesTaxLabel.Text = "Sales Tax (7.0%) on Carpet:";
            // 
            // lChargeLabel
            // 
            this.lChargeLabel.AutoSize = true;
            this.lChargeLabel.Location = new System.Drawing.Point(30, 245);
            this.lChargeLabel.Name = "lChargeLabel";
            this.lChargeLabel.Size = new System.Drawing.Size(147, 13);
            this.lChargeLabel.TabIndex = 15;
            this.lChargeLabel.Text = "Labor Charge ($0.50 / sq. ft.):";
            // 
            // orderTotal
            // 
            this.orderTotal.AutoSize = true;
            this.orderTotal.Location = new System.Drawing.Point(90, 297);
            this.orderTotal.Name = "orderTotal";
            this.orderTotal.Size = new System.Drawing.Size(87, 13);
            this.orderTotal.TabIndex = 16;
            this.orderTotal.Text = "ORDER TOTAL:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 3);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(9, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 3);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(33, 341);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 19;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(134, 341);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(235, 341);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 378);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.orderTotal);
            this.Controls.Add(this.lChargeLabel);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.carpetCharge);
            this.Controls.Add(this.carpetAreaLabel);
            this.Controls.Add(this.orderTotalLabel);
            this.Controls.Add(this.laborChargeLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.carpetChargeLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carpet Kingdom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label carpetChargeLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label laborChargeLabel;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.Label carpetAreaLabel;
        private System.Windows.Forms.Label carpetCharge;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label lChargeLabel;
        private System.Windows.Forms.Label orderTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

