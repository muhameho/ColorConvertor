using System;
using System.Windows.Forms;

namespace ColorConvertor
{
    public partial class panelFullScreen : Form
    {
        public panelFullScreen()
        {
            InitializeComponent();
        }

        // Override the FormClosing event
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Close the entire application
            Application.Exit();
        }
    }
}
