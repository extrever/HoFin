namespace HoFin_WF_NetCore.Forms
{
    partial class FormForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgotPass));
            this.labelForgotPassHint = new System.Windows.Forms.Label();
            this.buttonForgotPassSubmit = new System.Windows.Forms.Button();
            this.buttonForgotPassCancel = new System.Windows.Forms.Button();
            this.textBoxForgotPassEmail = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelForgotPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelForgotPassHint
            // 
            this.labelForgotPassHint.AutoSize = true;
            this.labelForgotPassHint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelForgotPassHint.Location = new System.Drawing.Point(51, 56);
            this.labelForgotPassHint.Name = "labelForgotPassHint";
            this.labelForgotPassHint.Size = new System.Drawing.Size(435, 21);
            this.labelForgotPassHint.TabIndex = 1;
            this.labelForgotPassHint.Text = "To reset your password, enter email you have used on signup:";
            // 
            // buttonForgotPassSubmit
            // 
            this.buttonForgotPassSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonForgotPassSubmit.Location = new System.Drawing.Point(273, 137);
            this.buttonForgotPassSubmit.Name = "buttonForgotPassSubmit";
            this.buttonForgotPassSubmit.Size = new System.Drawing.Size(104, 34);
            this.buttonForgotPassSubmit.TabIndex = 2;
            this.buttonForgotPassSubmit.Text = "Submit";
            this.buttonForgotPassSubmit.UseVisualStyleBackColor = true;
            this.buttonForgotPassSubmit.Click += new System.EventHandler(this.buttonForgotPassSubmit_Click);
            // 
            // buttonForgotPassCancel
            // 
            this.buttonForgotPassCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonForgotPassCancel.Location = new System.Drawing.Point(152, 137);
            this.buttonForgotPassCancel.Name = "buttonForgotPassCancel";
            this.buttonForgotPassCancel.Size = new System.Drawing.Size(104, 34);
            this.buttonForgotPassCancel.TabIndex = 3;
            this.buttonForgotPassCancel.Text = "Cancel";
            this.buttonForgotPassCancel.UseVisualStyleBackColor = true;
            this.buttonForgotPassCancel.Click += new System.EventHandler(this.buttonForgotPassCancel_Click);
            // 
            // textBoxForgotPassEmail
            // 
            this.textBoxForgotPassEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxForgotPassEmail.Location = new System.Drawing.Point(51, 88);
            this.textBoxForgotPassEmail.Name = "textBoxForgotPassEmail";
            this.textBoxForgotPassEmail.Size = new System.Drawing.Size(434, 29);
            this.textBoxForgotPassEmail.TabIndex = 5;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(512, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(29, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelForgotPass
            // 
            this.labelForgotPass.AutoSize = true;
            this.labelForgotPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelForgotPass.Location = new System.Drawing.Point(12, 9);
            this.labelForgotPass.Name = "labelForgotPass";
            this.labelForgotPass.Size = new System.Drawing.Size(185, 21);
            this.labelForgotPass.TabIndex = 7;
            this.labelForgotPass.Text = "HoFin | Reset password";
            // 
            // FormForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 200);
            this.Controls.Add(this.labelForgotPass);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxForgotPassEmail);
            this.Controls.Add(this.buttonForgotPassCancel);
            this.Controls.Add(this.buttonForgotPassSubmit);
            this.Controls.Add(this.labelForgotPassHint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForgotPassHint;
        private System.Windows.Forms.Button buttonForgotPassSubmit;
        private System.Windows.Forms.Button buttonForgotPassCancel;
        private System.Windows.Forms.TextBox textBoxForgotPassEmail;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelForgotPass;
    }
}