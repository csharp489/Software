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
    using System.Windows.Forms;
    using System.Drawing;
    using Limnor.Net;
    using LimnorDatabase;
    using System.Data.OleDb;
    using System.Data;
    
    public class CreateResetCode : Limnor.Drawing2D.DrawingPage
    {
        protected internal System.Windows.Forms.Label LabeLHEAD;
        protected internal System.Windows.Forms.Label LabelLOGIN;
        protected internal System.Windows.Forms.TextBox TextBoxLOGIN;
        protected internal System.Windows.Forms.Button ButtonCREATE;
        protected internal LimnorDatabase.WebLoginManager WebLoginManager1;
        private System.ComponentModel.IContainer components;
        protected internal Limnor.Net.MailSender MailSender1;
        protected internal LimnorDatabase.EasyDataSet EasyDataSet1;
        private static CreateResetCode _DefaultForm;
        private string valueOfResetCode;
        /// <summary>
        /// </summary>
        public CreateResetCode()
        {
            this.InitializeComponent();
        }
        public static CreateResetCode DefaultForm
        {
            get
            {
                if (((_DefaultForm == null) 
                            || (_DefaultForm.IsDisposed || _DefaultForm.Disposing)))
                {
                    _DefaultForm = new CreateResetCode();
                }
                return _DefaultForm;
            }
        }
        public virtual string ResetCode
        {
            get
            {
                return this.valueOfResetCode;
            }
            set
            {
                this.valueOfResetCode = value;
            }
        }
        private void InitializeComponent()
        {
            LimnorDatabase.DbParameterListExt dbparameterlistext1 = new LimnorDatabase.DbParameterListExt();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateResetCode));
            this.LabeLHEAD = new System.Windows.Forms.Label();
            this.LabelLOGIN = new System.Windows.Forms.Label();
            this.TextBoxLOGIN = new System.Windows.Forms.TextBox();
            this.ButtonCREATE = new System.Windows.Forms.Button();
            this.components = new System.ComponentModel.Container();
            this.WebLoginManager1 = new LimnorDatabase.WebLoginManager(this.components);
            this.MailSender1 = new Limnor.Net.MailSender();
            this.EasyDataSet1 = new LimnorDatabase.EasyDataSet();
            ((System.ComponentModel.ISupportInitialize)(EasyDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabeLHEAD
            // 
            this.LabeLHEAD.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LabeLHEAD.ForeColor = System.Drawing.Color.Navy;
            this.LabeLHEAD.Location = new System.Drawing.Point(73, 65);
            this.LabeLHEAD.Name = "LabeLHEAD";
            this.LabeLHEAD.Size = new System.Drawing.Size(283, 23);
            this.LabeLHEAD.TabIndex = 0;
            this.LabeLHEAD.Text = "CREATE PASSWORD RESET CODE";
            // 
            // LabelLOGIN
            // 
            this.LabelLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LabelLOGIN.ForeColor = System.Drawing.Color.Navy;
            this.LabelLOGIN.Location = new System.Drawing.Point(26, 141);
            this.LabelLOGIN.Name = "LabelLOGIN";
            this.LabelLOGIN.Size = new System.Drawing.Size(114, 23);
            this.LabelLOGIN.TabIndex = 1;
            this.LabelLOGIN.Text = "LOGIN NAME";
            // 
            // TextBoxLOGIN
            // 
            this.TextBoxLOGIN.Location = new System.Drawing.Point(160, 144);
            this.TextBoxLOGIN.Name = "TextBoxLOGIN";
            this.TextBoxLOGIN.Size = new System.Drawing.Size(238, 20);
            this.TextBoxLOGIN.TabIndex = 2;
            // 
            // ButtonCREATE
            // 
            this.ButtonCREATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ButtonCREATE.Location = new System.Drawing.Point(160, 192);
            this.ButtonCREATE.Name = "ButtonCREATE";
            this.ButtonCREATE.Size = new System.Drawing.Size(107, 28);
            this.ButtonCREATE.TabIndex = 3;
            this.ButtonCREATE.Text = "CREATE";
            this.ButtonCREATE.UseVisualStyleBackColor = true;
            this.ButtonCREATE.Click += new System.EventHandler(this.Click_618b62c7);
            // 
            // WebLoginManager1
            // 
            this.WebLoginManager1.ComponentName = "WebLoginManager1";
            this.WebLoginManager1.ConnectionID = new System.Guid("1a3e6d80-9bb0-4583-8429-2967b832ae28");
            this.WebLoginManager1.DefaultConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\rishabh\\OneDrive\\Documents\\" +
                "SOFTWAREMERCHANT.mdb;Mode=ReadWrite;";
            this.WebLoginManager1.DefaultConnectionType = typeof(System.Data.OleDb.OleDbConnection);
            this.WebLoginManager1.FailedMessageLableId = null;
            this.WebLoginManager1.ID = new System.Guid("e799cdf3-976e-407d-9d3a-3010d7f826a3");
            this.WebLoginManager1.InactivityMinutes = 0;
            this.WebLoginManager1.LabelToShowLoginFailedMessage = null;
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
            // 
            // EasyDataSet1
            // 
            this.EasyDataSet1.ConnectionID = new System.Guid("1a3e6d80-9bb0-4583-8429-2967b832ae28");
            this.EasyDataSet1.DataSetName = "Data_fa3c1d71-7a61-4a1a-9c36-59a8e5585c91";
            this.EasyDataSet1.DefaultConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\rishabh\\OneDrive\\Documents\\" +
                "SOFTWAREMERCHANT.mdb;Mode=ReadWrite;";
            this.EasyDataSet1.DefaultConnectionType = typeof(System.Data.OleDb.OleDbConnection);
            this.EasyDataSet1.Description = null;
            this.EasyDataSet1.DynamicParameters = dbparameterlistext1;
            this.EasyDataSet1.Field_DataSize = new int[] {
                    255};
            this.EasyDataSet1.Field_FieldCaption = new string[] {
                    null};
            this.EasyDataSet1.Field_FieldText = new string[] {
                    "[GLASS].[E-MAIL]"};
            this.EasyDataSet1.Field_FromTableName = new string[] {
                    "GLASS"};
            this.EasyDataSet1.Field_Indexed = new bool[] {
                    false};
            this.EasyDataSet1.Field_IsIdentity = new bool[] {
                    false};
            this.EasyDataSet1.Field_Name = new string[] {
                    "E-MAIL"};
            this.EasyDataSet1.Field_OleDbType = new System.Data.OleDb.OleDbType[] {
                    System.Data.OleDb.OleDbType.VarWChar};
            this.EasyDataSet1.Field_ReadOnly = new bool[] {
                    false};
            this.EasyDataSet1.From = "[GLASS]";
            this.EasyDataSet1.GroupBy = null;
            this.EasyDataSet1.Having = null;
            this.EasyDataSet1.IsFieldImage = new bool[] {
                    false};
            this.EasyDataSet1.Limit = null;
            this.EasyDataSet1.Name = "EasyDataSet1";
            this.EasyDataSet1.OrderBy = null;
            this.EasyDataSet1.Param_Name = new string[] {
                    "@loginName"};
            this.EasyDataSet1.Param_OleDbType = new System.Data.OleDb.OleDbType[] {
                    System.Data.OleDb.OleDbType.VarWChar};
            this.EasyDataSet1.Param_Value = new string[] {
                    "System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5" +
                        "61934e089|"};
            this.EasyDataSet1.TableName = "Table2873653136";
            this.EasyDataSet1.UpdatableTableName = null;
            this.EasyDataSet1.Where = "[GLASS].[LOGIN NAME] = @loginName";
            // 
            // CreateResetCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(444, 327);
            this.Controls.Add(this.LabeLHEAD);
            this.Controls.Add(this.LabelLOGIN);
            this.Controls.Add(this.TextBoxLOGIN);
            this.Controls.Add(this.ButtonCREATE);
            this.DrawingLayerList = ((Limnor.Drawing2D.DrawingLayerHeaderList)(resources.GetObject("$this.DrawingLayerList")));
            this.Name = "CreateResetCode";
            this.Text = "CreateResetCode";
            WebLoginManager1.CreateDataTable();
            EasyDataSet1.CreateDataTable();
            EasyDataSet1.Query();
            ((System.ComponentModel.ISupportInitialize)(EasyDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void Click_618b62c7(object sender, System.EventArgs e)
        {
            this.ResetCode = this.WebLoginManager1.CreatePasswordResetCode(this.TextBoxLOGIN.Text, 120);
            if (string.IsNullOrEmpty(this.ResetCode))
            {
                System.Windows.Forms.MessageBox.Show(this, "Invalid Login Name");
            }
            if (string.IsNullOrEmpty(this.ResetCode))
            {
                return;
            }
            this.EasyDataSet1.QueryWithParameterValues(this.TextBoxLOGIN.Text);
            this.MailSender1.AddRecipient(this.EasyDataSet1.Fields["E-MAIL"].ValueString, null, Limnor.Net.EnumCharEncode.Default);
            this.MailSender1.Body = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}{1}{2}", new object[] {
                        "Your password reset code is: ",
                        this.ResetCode,
                        ".You need to reset your password in 2 hours."});
            this.MailSender1.Send();
            this.MailSender1.ClearRecipients();
            System.Windows.Forms.MessageBox.Show(this, "Reset code created");
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