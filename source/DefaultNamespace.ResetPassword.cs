//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Limnor Studio.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DefaultNamespace
{
    using System;
    using System.Xml;
    using System.Text;
    using System.Collections.Generic;
    using Limnor.Drawing2D;
    using System.Drawing;
    using System.Windows.Forms;
    using LimnorDatabase;
    
    public class ResetPassword : Limnor.Drawing2D.DrawingPage
    {
        protected internal System.Windows.Forms.Label LabelHEAD;
        protected internal System.Windows.Forms.Label LabelRSCODE;
        protected internal System.Windows.Forms.Label LabelNEWPASS;
        protected internal System.Windows.Forms.Label LabelCONFPASS;
        protected internal System.Windows.Forms.Label LabelLOGINNM;
        protected internal System.Windows.Forms.TextBox TextBoxRSCODE;
        protected internal System.Windows.Forms.TextBox TextBoxNEWPASS;
        protected internal System.Windows.Forms.TextBox TextBoxCONFPASS;
        protected internal System.Windows.Forms.TextBox TextBoxLOGINNM;
        protected internal System.Windows.Forms.Label LabelMSG;
        protected internal System.Windows.Forms.Button ButtonSUBMIT;
        protected internal LimnorDatabase.WebLoginManager WebLoginManager1;
        private System.ComponentModel.IContainer components;
        private static ResetPassword _DefaultForm;
        private bool valueOfPasswordChanged = false;
        /// <summary>
        /// </summary>
        public ResetPassword()
        {
            this.InitializeComponent();
        }
        public static ResetPassword DefaultForm
        {
            get
            {
                if (((_DefaultForm == null) 
                            || (_DefaultForm.IsDisposed || _DefaultForm.Disposing)))
                {
                    _DefaultForm = new ResetPassword();
                }
                return _DefaultForm;
            }
        }
        public virtual bool PasswordChanged
        {
            get
            {
                return this.valueOfPasswordChanged;
            }
            set
            {
                this.valueOfPasswordChanged = value;
            }
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.LabelHEAD = new System.Windows.Forms.Label();
            this.LabelRSCODE = new System.Windows.Forms.Label();
            this.LabelNEWPASS = new System.Windows.Forms.Label();
            this.LabelCONFPASS = new System.Windows.Forms.Label();
            this.LabelLOGINNM = new System.Windows.Forms.Label();
            this.TextBoxRSCODE = new System.Windows.Forms.TextBox();
            this.TextBoxNEWPASS = new System.Windows.Forms.TextBox();
            this.TextBoxCONFPASS = new System.Windows.Forms.TextBox();
            this.TextBoxLOGINNM = new System.Windows.Forms.TextBox();
            this.LabelMSG = new System.Windows.Forms.Label();
            this.ButtonSUBMIT = new System.Windows.Forms.Button();
            this.components = new System.ComponentModel.Container();
            this.WebLoginManager1 = new LimnorDatabase.WebLoginManager(this.components);
            this.SuspendLayout();
            // 
            // LabelHEAD
            // 
            this.LabelHEAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LabelHEAD.ForeColor = System.Drawing.Color.Navy;
            this.LabelHEAD.Location = new System.Drawing.Point(105, 48);
            this.LabelHEAD.Name = "LabelHEAD";
            this.LabelHEAD.Size = new System.Drawing.Size(184, 27);
            this.LabelHEAD.TabIndex = 0;
            this.LabelHEAD.Text = "RESET PASSWORD";
            // 
            // LabelRSCODE
            // 
            this.LabelRSCODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.LabelRSCODE.ForeColor = System.Drawing.Color.Navy;
            this.LabelRSCODE.Location = new System.Drawing.Point(96, 155);
            this.LabelRSCODE.Name = "LabelRSCODE";
            this.LabelRSCODE.Size = new System.Drawing.Size(117, 23);
            this.LabelRSCODE.TabIndex = 1;
            this.LabelRSCODE.Text = "RESET CODE";
            // 
            // LabelNEWPASS
            // 
            this.LabelNEWPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.LabelNEWPASS.ForeColor = System.Drawing.Color.Navy;
            this.LabelNEWPASS.Location = new System.Drawing.Point(64, 197);
            this.LabelNEWPASS.Name = "LabelNEWPASS";
            this.LabelNEWPASS.Size = new System.Drawing.Size(149, 23);
            this.LabelNEWPASS.TabIndex = 1;
            this.LabelNEWPASS.Text = "NEW PASSWORD";
            // 
            // LabelCONFPASS
            // 
            this.LabelCONFPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.LabelCONFPASS.ForeColor = System.Drawing.Color.Navy;
            this.LabelCONFPASS.Location = new System.Drawing.Point(25, 235);
            this.LabelCONFPASS.Name = "LabelCONFPASS";
            this.LabelCONFPASS.Size = new System.Drawing.Size(188, 23);
            this.LabelCONFPASS.TabIndex = 1;
            this.LabelCONFPASS.Text = "CONFIRM PASSWORD";
            // 
            // LabelLOGINNM
            // 
            this.LabelLOGINNM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.LabelLOGINNM.ForeColor = System.Drawing.Color.Navy;
            this.LabelLOGINNM.Location = new System.Drawing.Point(102, 121);
            this.LabelLOGINNM.Name = "LabelLOGINNM";
            this.LabelLOGINNM.Size = new System.Drawing.Size(111, 23);
            this.LabelLOGINNM.TabIndex = 1;
            this.LabelLOGINNM.Text = "LOGIN NAME";
            // 
            // TextBoxRSCODE
            // 
            this.TextBoxRSCODE.Location = new System.Drawing.Point(219, 156);
            this.TextBoxRSCODE.Name = "TextBoxRSCODE";
            this.TextBoxRSCODE.Size = new System.Drawing.Size(183, 20);
            this.TextBoxRSCODE.TabIndex = 2;
            // 
            // TextBoxNEWPASS
            // 
            this.TextBoxNEWPASS.Location = new System.Drawing.Point(219, 197);
            this.TextBoxNEWPASS.Name = "TextBoxNEWPASS";
            this.TextBoxNEWPASS.Size = new System.Drawing.Size(183, 20);
            this.TextBoxNEWPASS.TabIndex = 2;
            // 
            // TextBoxCONFPASS
            // 
            this.TextBoxCONFPASS.Location = new System.Drawing.Point(219, 236);
            this.TextBoxCONFPASS.Name = "TextBoxCONFPASS";
            this.TextBoxCONFPASS.Size = new System.Drawing.Size(183, 20);
            this.TextBoxCONFPASS.TabIndex = 2;
            // 
            // TextBoxLOGINNM
            // 
            this.TextBoxLOGINNM.Location = new System.Drawing.Point(219, 122);
            this.TextBoxLOGINNM.Name = "TextBoxLOGINNM";
            this.TextBoxLOGINNM.Size = new System.Drawing.Size(183, 20);
            this.TextBoxLOGINNM.TabIndex = 2;
            // 
            // LabelMSG
            // 
            this.LabelMSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.LabelMSG.Location = new System.Drawing.Point(219, 341);
            this.LabelMSG.Name = "LabelMSG";
            this.LabelMSG.Size = new System.Drawing.Size(89, 23);
            this.LabelMSG.TabIndex = 3;
            this.LabelMSG.Text = "MESSAGE";
            // 
            // ButtonSUBMIT
            // 
            this.ButtonSUBMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ButtonSUBMIT.Location = new System.Drawing.Point(219, 289);
            this.ButtonSUBMIT.Name = "ButtonSUBMIT";
            this.ButtonSUBMIT.Size = new System.Drawing.Size(89, 38);
            this.ButtonSUBMIT.TabIndex = 4;
            this.ButtonSUBMIT.Text = "SUBMIT";
            this.ButtonSUBMIT.UseVisualStyleBackColor = true;
            this.ButtonSUBMIT.Click += new System.EventHandler(this.Click_5737c658);
            // 
            // WebLoginManager1
            // 
            this.WebLoginManager1.ComponentName = "WebLoginManager1";
            this.WebLoginManager1.ConnectionID = new System.Guid("1a3e6d80-9bb0-4583-8429-2967b832ae28");
            this.WebLoginManager1.DefaultConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\rishabh\\OneDrive\\Documents\\" +
                "SOFTWAREMERCHANT.mdb;Mode=ReadWrite;";
            this.WebLoginManager1.DefaultConnectionType = typeof(System.Data.OleDb.OleDbConnection);
            this.WebLoginManager1.FailedMessageLableId = "LabelMSG";
            this.WebLoginManager1.ID = new System.Guid("2d0d28b4-73a0-445c-a552-804358ca8ae4");
            this.WebLoginManager1.InactivityMinutes = 10;
            this.WebLoginManager1.LabelToShowLoginFailedMessage = this.LabelMSG;
            this.WebLoginManager1.LoginFailedMessage = null;
            this.WebLoginManager1.LoginPermissionFailedMessage = null;
            this.WebLoginManager1.PasswordHash = WindowsUtility.EnumPasswordHash.SHA256;
            this.WebLoginManager1.UserAccountIdFieldName = "USERiD";
            this.WebLoginManager1.UserAccountLevelFieldName = "USER LEVEL";
            this.WebLoginManager1.UserAccountLoginFieldName = "E-MAIL";
            this.WebLoginManager1.UserAccountPasswordFieldName = "PASSWORD";
            this.WebLoginManager1.UserAccountResetCodeFieldName = "RESET CODE";
            this.WebLoginManager1.UserAccountResetCodeTimeFieldName = "RESET CODE EXPIRE";
            this.WebLoginManager1.UserAccountSaltFieldName = "SALT";
            this.WebLoginManager1.UserAccountTableName = "GLASS";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(414, 404);
            this.Controls.Add(this.LabelHEAD);
            this.Controls.Add(this.LabelRSCODE);
            this.Controls.Add(this.LabelNEWPASS);
            this.Controls.Add(this.LabelCONFPASS);
            this.Controls.Add(this.LabelLOGINNM);
            this.Controls.Add(this.TextBoxRSCODE);
            this.Controls.Add(this.TextBoxNEWPASS);
            this.Controls.Add(this.TextBoxCONFPASS);
            this.Controls.Add(this.TextBoxLOGINNM);
            this.Controls.Add(this.LabelMSG);
            this.Controls.Add(this.ButtonSUBMIT);
            this.DrawingLayerList = ((Limnor.Drawing2D.DrawingLayerHeaderList)(resources.GetObject("$this.DrawingLayerList")));
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            WebLoginManager1.CreateDataTable();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void Click_5737c658(object sender, System.EventArgs e)
        {
            if ((string.IsNullOrEmpty(this.TextBoxNEWPASS.Text) 
                        || (string.CompareOrdinal(this.TextBoxNEWPASS.Text, this.TextBoxCONFPASS.Text) != 0)))
            {
                System.Windows.Forms.MessageBox.Show(this, "New password cannot be empty and must match with confirm password.");
            }
            if ((string.IsNullOrEmpty(this.TextBoxNEWPASS.Text) 
                        || (string.CompareOrdinal(this.TextBoxNEWPASS.Text, this.TextBoxCONFPASS.Text) != 0)))
            {
                return;
            }
            this.PasswordChanged = this.WebLoginManager1.ResetPasswordByUser(this.TextBoxLOGINNM.Text, this.TextBoxRSCODE.Text, this.TextBoxNEWPASS.Text);
            if ((this.PasswordChanged == false))
            {
                System.Windows.Forms.MessageBox.Show(this, "Invalid login name and reset code");
            }
            if (this.PasswordChanged)
            {
                System.Windows.Forms.MessageBox.Show(this, "Password Changed");
            }
        }
        protected override void Dispose(bool disposing)
        {
            if ((disposing 
                        && (components != null)))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
