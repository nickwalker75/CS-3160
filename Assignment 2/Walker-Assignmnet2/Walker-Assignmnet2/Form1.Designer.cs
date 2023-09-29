
namespace Walker_Assignmnet2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddtoOrd = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.imgBurger = new System.Windows.Forms.PictureBox();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.radBurger = new System.Windows.Forms.RadioButton();
            this.radWater = new System.Windows.Forms.RadioButton();
            this.radSoftDrink = new System.Windows.Forms.RadioButton();
            this.radFries = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cboQuantity = new System.Windows.Forms.ComboBox();
            this.lstOrderSummary = new System.Windows.Forms.ListBox();
            this.grpSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBurger)).BeginInit();
            this.grpItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddtoOrd
            // 
            this.btnAddtoOrd.Enabled = false;
            this.btnAddtoOrd.Location = new System.Drawing.Point(533, 126);
            this.btnAddtoOrd.Name = "btnAddtoOrd";
            this.btnAddtoOrd.Size = new System.Drawing.Size(147, 39);
            this.btnAddtoOrd.TabIndex = 9;
            this.btnAddtoOrd.Text = "Add to Order";
            this.btnAddtoOrd.UseVisualStyleBackColor = true;
            this.btnAddtoOrd.Click += new System.EventHandler(this.btnAddtoOrd_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(636, 200);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 19);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(533, 200);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(88, 19);
            this.lblOrderTotal.TabIndex = 14;
            this.lblOrderTotal.Text = "Order Total -";
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radLarge);
            this.grpSize.Controls.Add(this.radMedium);
            this.grpSize.Controls.Add(this.radSmall);
            this.grpSize.Location = new System.Drawing.Point(271, 17);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(200, 202);
            this.grpSize.TabIndex = 9;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            this.grpSize.Enter += new System.EventHandler(this.grpSize_Enter);
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Enabled = false;
            this.radLarge.Location = new System.Drawing.Point(15, 100);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(61, 23);
            this.radLarge.TabIndex = 7;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge1_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Enabled = false;
            this.radMedium.Location = new System.Drawing.Point(15, 71);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(78, 23);
            this.radMedium.TabIndex = 6;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radMedium_CheckedChanged);
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Enabled = false;
            this.radSmall.Location = new System.Drawing.Point(15, 42);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(59, 23);
            this.radSmall.TabIndex = 5;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Enabled = false;
            this.btnPlaceOrder.Location = new System.Drawing.Point(523, 447);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(167, 50);
            this.btnPlaceOrder.TabIndex = 11;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(271, 446);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 50);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // imgBurger
            // 
            this.imgBurger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgBurger.Image = ((System.Drawing.Image)(resources.GetObject("imgBurger.Image")));
            this.imgBurger.InitialImage = null;
            this.imgBurger.Location = new System.Drawing.Point(29, 266);
            this.imgBurger.Name = "imgBurger";
            this.imgBurger.Size = new System.Drawing.Size(200, 174);
            this.imgBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBurger.TabIndex = 11;
            this.imgBurger.TabStop = false;
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.radBurger);
            this.grpItem.Controls.Add(this.radWater);
            this.grpItem.Controls.Add(this.radSoftDrink);
            this.grpItem.Controls.Add(this.radFries);
            this.grpItem.Location = new System.Drawing.Point(29, 17);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(200, 202);
            this.grpItem.TabIndex = 8;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Item";
            this.grpItem.Enter += new System.EventHandler(this.grpItem_Enter);
            // 
            // radBurger
            // 
            this.radBurger.AutoSize = true;
            this.radBurger.Location = new System.Drawing.Point(19, 42);
            this.radBurger.Name = "radBurger";
            this.radBurger.Size = new System.Drawing.Size(68, 23);
            this.radBurger.TabIndex = 1;
            this.radBurger.Text = "Burger";
            this.radBurger.UseVisualStyleBackColor = true;
            this.radBurger.CheckedChanged += new System.EventHandler(this.radBurger_CheckedChanged);
            // 
            // radWater
            // 
            this.radWater.AutoSize = true;
            this.radWater.Location = new System.Drawing.Point(19, 129);
            this.radWater.Name = "radWater";
            this.radWater.Size = new System.Drawing.Size(63, 23);
            this.radWater.TabIndex = 4;
            this.radWater.Text = "Water";
            this.radWater.UseVisualStyleBackColor = true;
            this.radWater.CheckedChanged += new System.EventHandler(this.radWater_CheckedChanged);
            // 
            // radSoftDrink
            // 
            this.radSoftDrink.AutoSize = true;
            this.radSoftDrink.Location = new System.Drawing.Point(19, 100);
            this.radSoftDrink.Name = "radSoftDrink";
            this.radSoftDrink.Size = new System.Drawing.Size(88, 23);
            this.radSoftDrink.TabIndex = 3;
            this.radSoftDrink.Text = "Soft Drink";
            this.radSoftDrink.UseVisualStyleBackColor = true;
            this.radSoftDrink.CheckedChanged += new System.EventHandler(this.radSoftDrink_CheckedChanged);
            // 
            // radFries
            // 
            this.radFries.AutoSize = true;
            this.radFries.Location = new System.Drawing.Point(19, 71);
            this.radFries.Name = "radFries";
            this.radFries.Size = new System.Drawing.Size(55, 23);
            this.radFries.TabIndex = 1;
            this.radFries.Text = "Fries";
            this.radFries.UseVisualStyleBackColor = true;
            this.radFries.CheckedChanged += new System.EventHandler(this.radFries_CheckedChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(533, 17);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(63, 19);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.Text = "Quantity";
            // 
            // cboQuantity
            // 
            this.cboQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuantity.Enabled = false;
            this.cboQuantity.FormattingEnabled = true;
            this.cboQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboQuantity.Location = new System.Drawing.Point(533, 40);
            this.cboQuantity.Name = "cboQuantity";
            this.cboQuantity.Size = new System.Drawing.Size(63, 25);
            this.cboQuantity.TabIndex = 8;
            // 
            // lstOrderSummary
            // 
            this.lstOrderSummary.FormattingEnabled = true;
            this.lstOrderSummary.ItemHeight = 17;
            this.lstOrderSummary.Location = new System.Drawing.Point(271, 266);
            this.lstOrderSummary.Name = "lstOrderSummary";
            this.lstOrderSummary.Size = new System.Drawing.Size(419, 174);
            this.lstOrderSummary.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(746, 509);
            this.Controls.Add(this.lstOrderSummary);
            this.Controls.Add(this.cboQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAddtoOrd);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.imgBurger);
            this.Controls.Add(this.grpItem);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Five Guys Burger Joint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBurger)).EndInit();
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddtoOrd;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox imgBurger;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.RadioButton radWater;
        private System.Windows.Forms.RadioButton radSoftDrink;
        private System.Windows.Forms.RadioButton radFries;
        private System.Windows.Forms.RadioButton radLarge1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cboQuantity;
        private System.Windows.Forms.RadioButton radBurger;
        private System.Windows.Forms.ListBox lstOrderSummary;
    }
}

