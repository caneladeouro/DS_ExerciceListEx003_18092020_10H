namespace DS_ExerciceListEx003_18092020_10H
{
    partial class fmrCashier
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
            this.gpbClerk = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gpbClerk.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbClerk
            // 
            this.gpbClerk.Controls.Add(this.btnCancel);
            this.gpbClerk.Controls.Add(this.btnConfirm);
            this.gpbClerk.Controls.Add(this.lblInformation);
            this.gpbClerk.Controls.Add(this.txtPassword);
            this.gpbClerk.Controls.Add(this.lblPassword);
            this.gpbClerk.Location = new System.Drawing.Point(12, 12);
            this.gpbClerk.Name = "gpbClerk";
            this.gpbClerk.Size = new System.Drawing.Size(200, 100);
            this.gpbClerk.TabIndex = 0;
            this.gpbClerk.TabStop = false;
            this.gpbClerk.Text = "Atendente";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(38, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(119, 71);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Enabled = false;
            this.lblInformation.Location = new System.Drawing.Point(6, 55);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(60, 13);
            this.lblInformation.TabIndex = 2;
            this.lblInformation.Text = "Informação";
            this.lblInformation.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(9, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(185, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 16);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(38, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Senha";
            // 
            // fmrCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 116);
            this.Controls.Add(this.gpbClerk);
            this.Name = "fmrCashier";
            this.Text = "Atendente";
            this.gpbClerk.ResumeLayout(false);
            this.gpbClerk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbClerk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}