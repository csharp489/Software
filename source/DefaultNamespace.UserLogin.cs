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
    
    public class UserLogin : Limnor.Drawing2D.DrawingPage
    {
        protected internal System.Windows.Forms.Label LabelPASS;
        protected internal System.Windows.Forms.Label Label2147483646;
        protected internal System.Windows.Forms.PictureBox PictureBox1;
        protected internal System.Windows.Forms.Label LabelLOGIN;
        protected internal System.Windows.Forms.TextBox TextBoxPASS;
        protected internal System.Windows.Forms.TextBox TEXTBOXLOGIN;
        protected internal System.Windows.Forms.Button BTNSUBMIT;
        protected internal System.Windows.Forms.Label LABELMSG;
        protected internal LimnorDatabase.WebLoginManager WebLoginManager1;
        private System.ComponentModel.IContainer components;
        private static UserLogin _DefaultForm;
        /// <summary>
        /// </summary>
        public UserLogin()
        {
            this.InitializeComponent();
        }
        public static UserLogin DefaultForm
        {
            get
            {
                if (((_DefaultForm == null) 
                            || (_DefaultForm.IsDisposed || _DefaultForm.Disposing)))
                {
                    _DefaultForm = new UserLogin();
                }
                return _DefaultForm;
            }
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.LabelPASS = new System.Windows.Forms.Label();
            this.Label2147483646 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelLOGIN = new System.Windows.Forms.Label();
            this.TextBoxPASS = new System.Windows.Forms.TextBox();
            this.TEXTBOXLOGIN = new System.Windows.Forms.TextBox();
            this.BTNSUBMIT = new System.Windows.Forms.Button();
            this.LABELMSG = new System.Windows.Forms.Label();
            this.components = new System.ComponentModel.Container();
            this.WebLoginManager1 = new LimnorDatabase.WebLoginManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelPASS
            // 
            this.LabelPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LabelPASS.ForeColor = System.Drawing.Color.Navy;
            this.LabelPASS.Location = new System.Drawing.Point(52, 177);
            this.LabelPASS.Name = "LabelPASS";
            this.LabelPASS.Size = new System.Drawing.Size(111, 23);
            this.LabelPASS.TabIndex = 0;
            this.LabelPASS.Text = "PASSWORD";
            // 
            // Label2147483646
            // 
            this.Label2147483646.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Label2147483646.ForeColor = System.Drawing.Color.Navy;
            this.Label2147483646.Location = new System.Drawing.Point(147, 31);
            this.Label2147483646.Name = "Label2147483646";
            this.Label2147483646.Size = new System.Drawing.Size(113, 23);
            this.Label2147483646.TabIndex = 1;
            this.Label2147483646.Text = "LOGIN PAGE";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(175, 57);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(51, 50);
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            // 
            // LabelLOGIN
            // 
            this.LabelLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LabelLOGIN.ForeColor = System.Drawing.Color.Navy;
            this.LabelLOGIN.Location = new System.Drawing.Point(42, 131);
            this.LabelLOGIN.Name = "LabelLOGIN";
            this.LabelLOGIN.Size = new System.Drawing.Size(121, 23);
            this.LabelLOGIN.TabIndex = 0;
            this.LabelLOGIN.Text = "LOGIN NAME";
            // 
            // TextBoxPASS
            // 
            this.TextBoxPASS.Location = new System.Drawing.Point(202, 179);
            this.TextBoxPASS.Name = "TextBoxPASS";
            this.TextBoxPASS.Size = new System.Drawing.Size(181, 20);
            this.TextBoxPASS.TabIndex = 3;
            // 
            // TEXTBOXLOGIN
            // 
            this.TEXTBOXLOGIN.Location = new System.Drawing.Point(202, 134);
            this.TEXTBOXLOGIN.Name = "TEXTBOXLOGIN";
            this.TEXTBOXLOGIN.Size = new System.Drawing.Size(181, 20);
            this.TEXTBOXLOGIN.TabIndex = 3;
            // 
            // BTNSUBMIT
            // 
            this.BTNSUBMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTNSUBMIT.ForeColor = System.Drawing.Color.Navy;
            this.BTNSUBMIT.Location = new System.Drawing.Point(144, 234);
            this.BTNSUBMIT.Name = "BTNSUBMIT";
            this.BTNSUBMIT.Size = new System.Drawing.Size(116, 34);
            this.BTNSUBMIT.TabIndex = 4;
            this.BTNSUBMIT.Text = "SUBMIT";
            this.BTNSUBMIT.UseVisualStyleBackColor = true;
            this.BTNSUBMIT.Click += new System.EventHandler(this.Click_9b033231);
            // 
            // LABELMSG
            // 
            this.LABELMSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LABELMSG.ForeColor = System.Drawing.Color.Navy;
            this.LABELMSG.Location = new System.Drawing.Point(144, 282);
            this.LABELMSG.Name = "LABELMSG";
            this.LABELMSG.Size = new System.Drawing.Size(116, 23);
            this.LABELMSG.TabIndex = 5;
            this.LABELMSG.Text = "   MESSAGE";
            // 
            // WebLoginManager1
            // 
            this.WebLoginManager1.ComponentName = "WebLoginManager1";
            this.WebLoginManager1.ConnectionID = new System.Guid("1a3e6d80-9bb0-4583-8429-2967b832ae28");
            this.WebLoginManager1.DefaultConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\rishabh\\OneDrive\\Documents\\" +
                "SOFTWAREMERCHANT.mdb;Mode=ReadWrite;";
            this.WebLoginManager1.DefaultConnectionType = typeof(System.Data.OleDb.OleDbConnection);
            this.WebLoginManager1.FailedMessageLableId = "LABELMSG";
            this.WebLoginManager1.ID = new System.Guid("dfc298bb-0960-49bf-b1ec-eb260632a388");
            this.WebLoginManager1.InactivityMinutes = 10;
            this.WebLoginManager1.LabelToShowLoginFailedMessage = this.LABELMSG;
            this.WebLoginManager1.LoginFailedMessage = null;
            this.WebLoginManager1.LoginPermissionFailedMessage = null;
            this.WebLoginManager1.PasswordHash = WindowsUtility.EnumPasswordHash.SHA256;
            this.WebLoginManager1.UserAccountIdFieldName = "USERiD";
            this.WebLoginManager1.UserAccountLevelFieldName = "USER LEVEL";
            this.WebLoginManager1.UserAccountLoginFieldName = "LOGIN NAME";
            this.WebLoginManager1.UserAccountPasswordFieldName = "PASSWORD";
            this.WebLoginManager1.UserAccountResetCodeFieldName = "RESET CODE";
            this.WebLoginManager1.UserAccountResetCodeTimeFieldName = "RESET CODE EXPIRE";
            this.WebLoginManager1.UserAccountSaltFieldName = "SALT";
            this.WebLoginManager1.UserAccountTableName = "GLASS";
            this.WebLoginManager1.UserLogin += new Limnor.WebBuilder.SimpleCall(this.UserLogin_7783a68c);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(424, 348);
            this.Controls.Add(this.LabelPASS);
            this.Controls.Add(this.Label2147483646);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.LabelLOGIN);
            this.Controls.Add(this.TextBoxPASS);
            this.Controls.Add(this.TEXTBOXLOGIN);
            this.Controls.Add(this.BTNSUBMIT);
            this.Controls.Add(this.LABELMSG);
            this.DrawingLayerList = ((Limnor.Drawing2D.DrawingLayerHeaderList)(resources.GetObject("$this.DrawingLayerList")));
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            WebLoginManager1.CreateDataTable();
            ((System.ComponentModel.ISupportInitialize)(PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void Click_9b033231(object sender, System.EventArgs e)
        {
            this.WebLoginManager1.Login(this.TEXTBOXLOGIN.Text, this.TextBoxPASS.Text);
        }
        private void UserLogin_7783a68c()
        {
            this.Close();
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
