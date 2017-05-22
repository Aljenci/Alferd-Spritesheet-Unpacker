using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace ASU.UI
{
    partial class GroupForm : System.Windows.Forms.Form
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //Required by the Windows Form Designer

        private System.ComponentModel.IContainer components;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.MainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupsCombo = new System.Windows.Forms.ComboBox();
            this.GroupText = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.Controls.Add(this.GroupsCombo);
            this.MainLayout.Controls.Add(this.GroupText);
            this.MainLayout.Controls.Add(this.OkButton);
            this.MainLayout.Controls.Add(this.CancelButton);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.Size = new System.Drawing.Size(163, 85);
            this.MainLayout.TabIndex = 0;
            // 
            // GroupsCombo
            // 
            this.GroupsCombo.FormattingEnabled = true;
            this.GroupsCombo.Location = new System.Drawing.Point(3, 3);
            this.GroupsCombo.Name = "GroupsCombo";
            this.GroupsCombo.Size = new System.Drawing.Size(156, 21);
            this.GroupsCombo.TabIndex = 0;
            this.GroupsCombo.SelectedIndexChanged += new System.EventHandler(this.GroupsCombo_SelectedIndexChanged);
            // 
            // GroupText
            // 
            this.GroupText.Location = new System.Drawing.Point(3, 30);
            this.GroupText.Name = "GroupText";
            this.GroupText.Size = new System.Drawing.Size(156, 20);
            this.GroupText.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(3, 56);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(84, 56);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // GroupForm
            // 
            this.ClientSize = new System.Drawing.Size(163, 85);
            this.Controls.Add(this.MainLayout);
            this.Name = "GroupForm";
            this.Load += new System.EventHandler(this.GroupForm_Load);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        public GroupForm()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.FlowLayoutPanel MainLayout;
        private System.Windows.Forms.ComboBox GroupsCombo;
        private System.Windows.Forms.TextBox GroupText;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}