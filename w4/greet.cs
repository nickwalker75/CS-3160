using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUIdemo
{
    public class Greet : Form
    {
        //  Controls 
        private Button btnSay;
        private TextBox txtName;

        public Greet()
        {
            // Form
            this.Text = "Enter your name";
            this.Height = 129;
            this.AcceptButton = btnSay;

            // Button: btnSay
            btnSay = new Button();
            btnSay.Text = "Say Hello";
            btnSay.Location = new Point(105,47);
            Controls.Add(btnSay);

            // Textbox: txtName
            txtName = new TextBox();
            txtName.Location = new Point(168, 20);
            txtName.Size = new Size(208, 20);
            Controls.Add(txtName);

            btnSay.Click += new EventHandler(btnSay_Click);
        }

        void btnSay_Click(Object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)                  
                MessageBox.Show("Hello, anonymous!");         
            else                  
                MessageBox.Show("Hello, " + txtName.Text + "!");   

            txtName.Clear();
        }

        public static void Main()
        {
            Application.Run(new Greet());
        }//Main
    }// Greet:form
}// namespace
