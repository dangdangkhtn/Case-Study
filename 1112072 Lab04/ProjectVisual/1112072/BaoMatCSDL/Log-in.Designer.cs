namespace BaoMatCSDL
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_PWD = new System.Windows.Forms.TextBox();
            this.lab_ID = new System.Windows.Forms.Label();
            this.lab_PWD = new System.Windows.Forms.Label();
            this.but_LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(98, 37);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(219, 20);
            this.txt_ID.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_PWD
            // 
            this.txt_PWD.Location = new System.Drawing.Point(98, 83);
            this.txt_PWD.Name = "txt_PWD";
            this.txt_PWD.Size = new System.Drawing.Size(219, 20);
            this.txt_PWD.TabIndex = 0;
            this.txt_PWD.UseSystemPasswordChar = true;
            // 
            // lab_ID
            // 
            this.lab_ID.AutoSize = true;
            this.lab_ID.Location = new System.Drawing.Point(25, 43);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(18, 13);
            this.lab_ID.TabIndex = 2;
            this.lab_ID.Text = "ID";
            this.lab_ID.UseMnemonic = false;
            // 
            // lab_PWD
            // 
            this.lab_PWD.AutoSize = true;
            this.lab_PWD.Location = new System.Drawing.Point(25, 90);
            this.lab_PWD.Name = "lab_PWD";
            this.lab_PWD.Size = new System.Drawing.Size(53, 13);
            this.lab_PWD.TabIndex = 2;
            this.lab_PWD.Text = "Password";
            // 
            // but_LogIn
            // 
            this.but_LogIn.Location = new System.Drawing.Point(98, 137);
            this.but_LogIn.Name = "but_LogIn";
            this.but_LogIn.Size = new System.Drawing.Size(83, 23);
            this.but_LogIn.TabIndex = 3;
            this.but_LogIn.Text = "Log In";
            this.but_LogIn.UseVisualStyleBackColor = true;
            this.but_LogIn.Click += new System.EventHandler(this.but_LogIn_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 197);
            this.Controls.Add(this.but_LogIn);
            this.Controls.Add(this.lab_PWD);
            this.Controls.Add(this.lab_ID);
            this.Controls.Add(this.txt_PWD);
            this.Controls.Add(this.txt_ID);
            this.Name = "frmLogin";
            this.Text = "Log-in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_PWD;
        private System.Windows.Forms.Label lab_ID;
        private System.Windows.Forms.Label lab_PWD;
        private System.Windows.Forms.Button but_LogIn;
    }
}

