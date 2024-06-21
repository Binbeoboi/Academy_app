namespace doAn2.View
{
    partial class FormGmail
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
            this.webViewGmail = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webViewGmail)).BeginInit();
            this.SuspendLayout();
            // 
            // webViewGmail
            // 
            this.webViewGmail.AllowExternalDrop = true;
            this.webViewGmail.CreationProperties = null;
            this.webViewGmail.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewGmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewGmail.Location = new System.Drawing.Point(0, 0);
            this.webViewGmail.Name = "webViewGmail";
            this.webViewGmail.Size = new System.Drawing.Size(1466, 712);
            this.webViewGmail.TabIndex = 0;
            this.webViewGmail.ZoomFactor = 1D;
            // 
            // FormGmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1466, 712);
            this.Controls.Add(this.webViewGmail);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGmail";
            this.Text = "FormGmail";
            this.Load += new System.EventHandler(this.FormGmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webViewGmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewGmail;
    }
}