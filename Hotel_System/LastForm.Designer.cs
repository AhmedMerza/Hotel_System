namespace Hotel_System
{
    partial class LastForm
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
            this.dataL = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.TypeL = new System.Windows.Forms.Label();
            this.CheckInL = new System.Windows.Forms.Label();
            this.CheckOutL = new System.Windows.Forms.Label();
            this.DishL = new System.Windows.Forms.Label();
            this.RTL = new System.Windows.Forms.Label();
            this.PriceL = new System.Windows.Forms.Label();
            this.DrinkL = new System.Windows.Forms.Label();
            this.RTPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataL
            // 
            this.dataL.AutoSize = true;
            this.dataL.Location = new System.Drawing.Point(13, 13);
            this.dataL.Name = "dataL";
            this.dataL.Size = new System.Drawing.Size(97, 13);
            this.dataL.TabIndex = 0;
            this.dataL.Text = "454564564564564";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(63, 328);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // TypeL
            // 
            this.TypeL.AutoSize = true;
            this.TypeL.Location = new System.Drawing.Point(13, 64);
            this.TypeL.Name = "TypeL";
            this.TypeL.Size = new System.Drawing.Size(64, 13);
            this.TypeL.TabIndex = 2;
            this.TypeL.Text = "Room type: ";
            // 
            // CheckInL
            // 
            this.CheckInL.AutoSize = true;
            this.CheckInL.Location = new System.Drawing.Point(13, 106);
            this.CheckInL.Name = "CheckInL";
            this.CheckInL.Size = new System.Drawing.Size(79, 13);
            this.CheckInL.TabIndex = 3;
            this.CheckInL.Text = "Check in date: ";
            // 
            // CheckOutL
            // 
            this.CheckOutL.AutoSize = true;
            this.CheckOutL.Location = new System.Drawing.Point(13, 153);
            this.CheckOutL.Name = "CheckOutL";
            this.CheckOutL.Size = new System.Drawing.Size(86, 13);
            this.CheckOutL.TabIndex = 4;
            this.CheckOutL.Text = "Check out date: ";
            // 
            // DishL
            // 
            this.DishL.AutoSize = true;
            this.DishL.Location = new System.Drawing.Point(13, 201);
            this.DishL.Name = "DishL";
            this.DishL.Size = new System.Drawing.Size(34, 13);
            this.DishL.TabIndex = 5;
            this.DishL.Text = "Dish: ";
            // 
            // RTL
            // 
            this.RTL.AutoSize = true;
            this.RTL.Location = new System.Drawing.Point(13, 235);
            this.RTL.Name = "RTL";
            this.RTL.Size = new System.Drawing.Size(36, 13);
            this.RTL.TabIndex = 6;
            this.RTL.Text = "From: ";
            // 
            // PriceL
            // 
            this.PriceL.AutoSize = true;
            this.PriceL.Location = new System.Drawing.Point(13, 290);
            this.PriceL.Name = "PriceL";
            this.PriceL.Size = new System.Drawing.Size(63, 13);
            this.PriceL.TabIndex = 7;
            this.PriceL.Text = "Total price: ";
            // 
            // DrinkL
            // 
            this.DrinkL.AutoSize = true;
            this.DrinkL.Location = new System.Drawing.Point(128, 201);
            this.DrinkL.Name = "DrinkL";
            this.DrinkL.Size = new System.Drawing.Size(35, 13);
            this.DrinkL.TabIndex = 8;
            this.DrinkL.Text = "Drink:";
            // 
            // RTPrice
            // 
            this.RTPrice.AutoSize = true;
            this.RTPrice.Location = new System.Drawing.Point(131, 235);
            this.RTPrice.Name = "RTPrice";
            this.RTPrice.Size = new System.Drawing.Size(0, 13);
            this.RTPrice.TabIndex = 9;
            // 
            // LastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 363);
            this.Controls.Add(this.RTPrice);
            this.Controls.Add(this.DrinkL);
            this.Controls.Add(this.PriceL);
            this.Controls.Add(this.RTL);
            this.Controls.Add(this.DishL);
            this.Controls.Add(this.CheckOutL);
            this.Controls.Add(this.CheckInL);
            this.Controls.Add(this.TypeL);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dataL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LastForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.LastForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dataL;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label TypeL;
        private System.Windows.Forms.Label CheckInL;
        private System.Windows.Forms.Label CheckOutL;
        private System.Windows.Forms.Label DishL;
        private System.Windows.Forms.Label RTL;
        private System.Windows.Forms.Label PriceL;
        private System.Windows.Forms.Label DrinkL;
        private System.Windows.Forms.Label RTPrice;
    }
}