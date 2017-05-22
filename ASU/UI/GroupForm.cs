using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ASU.UI
{
    public partial class GroupForm : Form
    {
        public MainForm Main;

        private List<string> _ComboValues = new List<string>();
        public List<string> ComboValues
        {
            get { return this._ComboValues;  }
            set { this._ComboValues = value; }
        }

        public string GroupName { get; set; }

        public bool Correct { get; set; }

        private void GroupForm_Load(object sender, System.EventArgs e)
        {
            Correct = false;
            foreach (string value in ComboValues)
            {
                if (!this.GroupsCombo.Items.Contains(value))
                    this.GroupsCombo.Items.Add(value);
            }
            this.GroupsCombo.SelectedIndex = this.GroupsCombo.FindString(this.GroupName);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Correct = false;
            this.Hide();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Correct = true;
            GroupName = this.GroupText.Text;
            this.Hide();
        }

        private void GroupsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GroupText.Text = this.GroupsCombo.Text;
        }
    }
}
