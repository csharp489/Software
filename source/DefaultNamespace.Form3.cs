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
    
    public class Form3 : Limnor.Drawing2D.DrawingPage
    {
        protected internal System.Windows.Forms.ComboBox ComboBoxCHOOSE;
        protected internal System.Windows.Forms.Label LabelHEAD;
        protected internal System.Windows.Forms.Label LabeLOTHER;
        protected internal System.Windows.Forms.Button BTNSUBMIT;
        protected internal System.Windows.Forms.TextBox TextBoxOTHER;
        private static Form3 _DefaultForm;
        /// <summary>
        /// </summary>
        public Form3()
        {
            this.InitializeComponent();
        }
        public static Form3 DefaultForm
        {
            get
            {
                if (((_DefaultForm == null) 
                            || (_DefaultForm.IsDisposed || _DefaultForm.Disposing)))
                {
                    _DefaultForm = new Form3();
                }
                return _DefaultForm;
            }
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.ComboBoxCHOOSE = new System.Windows.Forms.ComboBox();
            this.LabelHEAD = new System.Windows.Forms.Label();
            this.LabeLOTHER = new System.Windows.Forms.Label();
            this.BTNSUBMIT = new System.Windows.Forms.Button();
            this.TextBoxOTHER = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComboBoxCHOOSE
            // 
            this.ComboBoxCHOOSE.FormattingEnabled = true;
            this.ComboBoxCHOOSE.Items.AddRange(new object[] {
                        "1-3 INCHES",
                        "3-6 INCHES",
                        "6-9 INCHES",
                        "9-12 INCHES",
                        "12-36 INCHES",
                        "36-48 INCHES",
                        "OTHER"});
            this.ComboBoxCHOOSE.Location = new System.Drawing.Point(97, 108);
            this.ComboBoxCHOOSE.Name = "ComboBoxCHOOSE";
            this.ComboBoxCHOOSE.Size = new System.Drawing.Size(233, 21);
            this.ComboBoxCHOOSE.TabIndex = 0;
            this.ComboBoxCHOOSE.Text = "CHOOSE THE DIMENSIONS YOU WANT";
            // 
            // LabelHEAD
            // 
            this.LabelHEAD.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.LabelHEAD.Location = new System.Drawing.Point(114, 52);
            this.LabelHEAD.Name = "LabelHEAD";
            this.LabelHEAD.Size = new System.Drawing.Size(204, 23);
            this.LabelHEAD.TabIndex = 1;
            this.LabelHEAD.Text = "DIMENSIONS OF GLASS";
            // 
            // LabeLOTHER
            // 
            this.LabeLOTHER.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.LabeLOTHER.Location = new System.Drawing.Point(12, 160);
            this.LabeLOTHER.Name = "LabeLOTHER";
            this.LabeLOTHER.Size = new System.Drawing.Size(197, 23);
            this.LabeLOTHER.TabIndex = 2;
            this.LabeLOTHER.Text = "IF OTHER THEN THAT..";
            // 
            // BTNSUBMIT
            // 
            this.BTNSUBMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BTNSUBMIT.Location = new System.Drawing.Point(150, 224);
            this.BTNSUBMIT.Name = "BTNSUBMIT";
            this.BTNSUBMIT.Size = new System.Drawing.Size(119, 38);
            this.BTNSUBMIT.TabIndex = 3;
            this.BTNSUBMIT.Text = "SUBMIT";
            this.BTNSUBMIT.UseVisualStyleBackColor = true;
            this.BTNSUBMIT.Click += new System.EventHandler(this.Click_b6b2e01c);
            // 
            // TextBoxOTHER
            // 
            this.TextBoxOTHER.Location = new System.Drawing.Point(255, 161);
            this.TextBoxOTHER.Name = "TextBoxOTHER";
            this.TextBoxOTHER.Size = new System.Drawing.Size(127, 20);
            this.TextBoxOTHER.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(448, 369);
            this.Controls.Add(this.ComboBoxCHOOSE);
            this.Controls.Add(this.LabelHEAD);
            this.Controls.Add(this.LabeLOTHER);
            this.Controls.Add(this.BTNSUBMIT);
            this.Controls.Add(this.TextBoxOTHER);
            this.DrawingLayerList = ((Limnor.Drawing2D.DrawingLayerHeaderList)(resources.GetObject("$this.DrawingLayerList")));
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void Click_b6b2e01c(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(this, "DIMENSIONS ADDED SUCCESSFULLY");
        }
    }
}
