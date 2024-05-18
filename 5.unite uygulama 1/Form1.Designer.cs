namespace _5.unite_uygulama_1
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnControlbox = new System.Windows.Forms.Button();
            this.btnCenterToScreen = new System.Windows.Forms.Button();
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(249, 100);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnControlbox
            // 
            this.btnControlbox.Location = new System.Drawing.Point(249, 158);
            this.btnControlbox.Name = "btnControlbox";
            this.btnControlbox.Size = new System.Drawing.Size(75, 23);
            this.btnControlbox.TabIndex = 2;
            this.btnControlbox.Text = "Controlbox";
            this.btnControlbox.UseVisualStyleBackColor = true;
            this.btnControlbox.Click += new System.EventHandler(this.btnControlbox_Click);
            // 
            // btnCenterToScreen
            // 
            this.btnCenterToScreen.Location = new System.Drawing.Point(249, 187);
            this.btnCenterToScreen.Name = "btnCenterToScreen";
            this.btnCenterToScreen.Size = new System.Drawing.Size(75, 23);
            this.btnCenterToScreen.TabIndex = 3;
            this.btnCenterToScreen.Text = "CenterToScreen";
            this.btnCenterToScreen.UseVisualStyleBackColor = true;
            this.btnCenterToScreen.Click += new System.EventHandler(this.btnCenterToScreen_Click);
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(249, 245);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(75, 23);
            this.btnShowDialog.TabIndex = 4;
            this.btnShowDialog.Text = "ShowDialog";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(249, 216);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnShowDialog);
            this.Controls.Add(this.btnCenterToScreen);
            this.Controls.Add(this.btnControlbox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnControlbox;
        private System.Windows.Forms.Button btnCenterToScreen;
        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.Button btnShow;
    }
}

