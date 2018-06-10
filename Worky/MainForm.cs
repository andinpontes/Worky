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
        public IActivity Activity { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void CheckBoxWorkingCheckedChanged(object sender, EventArgs e)
        {
            Activity.StartWorking();
        }

        private void CheckBoxPausingCheckedChanged(object sender, EventArgs e)
        {
            Activity.StartPausing();
        }
    }
}
