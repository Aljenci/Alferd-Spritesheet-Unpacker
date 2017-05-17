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

        private void GroupForm_Load(object sender, System.EventArgs e)
        {
            foreach (string value in ComboValues)
                this.GroupsCombo.Items.Add(value);
        }
    }
}
