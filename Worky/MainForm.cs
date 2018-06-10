using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worky.Interfaces;

namespace Worky
{
    public partial class MainForm : Form
    {
        public IActivity Activity { get; private set; }

        public MainForm(IActivity activity)
        {
            InitializeComponent();
            Activity = activity;
        }

        private void CheckBoxWorkingCheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (!cb.Checked)
                return;

            checkBoxPausing.Checked = false;
            Activity.StartWorking();
        }

        private void CheckBoxPausingCheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (!cb.Checked)
                return;

            checkBoxWorking.Checked = false;
            Activity.StartPausing();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkBoxWorking.Checked = true;
            checkBoxPausing.Checked = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Activity.EndWorking();
        }
    }
}
