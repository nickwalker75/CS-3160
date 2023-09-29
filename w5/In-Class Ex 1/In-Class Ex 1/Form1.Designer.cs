
namespace In_Class_Ex_1
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
            this.picCats = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCats)).BeginInit();
            this.SuspendLayout();
            // 
            // picCats
            // 
            this.picCats.Image = ((System.Drawing.Image)(resources.GetObject("picCats.Image")));
            this.picCats.Location = new System.Drawing.Point(28, 126);
            this.picCats.Name = "picCats";
            this.picCats.Size = new System.Drawing.Size(321, 245);
            this.picCats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCats.TabIndex = 0;
            this.picCats.TabStop = false;
            this.picCats.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(129, 39);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 40);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "button1";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 405);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picCats);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCats;
        private System.Windows.Forms.Button btnNext;
    }
}

