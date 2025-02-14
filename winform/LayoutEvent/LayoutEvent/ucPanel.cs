using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayoutEvent
{
    public partial class ucPanel : UserControl
    {
        public event EventHandler eLabelDoubleClick;
        public ucPanel()
        {
            InitializeComponent();
        }

        private void ucPanel_Resize(object sender, EventArgs e)
        {
            lblPanel.Text = $"(Width{this.Width}, Height{this.Height})";
        }

        private void lblPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            eLabelDoubleClick(this, e);
        }
    }
}
