using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorConvertor
{
    public partial class panelColorPreview : Form
    {
        public panelColorPreview()
        {
            InitializeComponent();
            
            // Make the form always on top (if you need it)
            this.TopMost = true;

            // Set the initial location - it will be updated dynamically
            this.Location = new Point(-100, -100); // Hide the form initially
        }

        // Method to update the color of the preview panel
        public void UpdateColor(Color color)
        {
            this.BackColor = color;
        }

        // Override the OnFormClosing event
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Check if the form is being closed by the user or programmatically
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Close the entire application if this form is closed
                Application.Exit();
            }
        }
    }
}
