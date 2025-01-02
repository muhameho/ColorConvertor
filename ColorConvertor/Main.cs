using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace ColorConvertor
{
    public partial class Main : Form
    {

        private System.Windows.Forms.Timer fadeOutTimer;
        panelFullScreen panelFullScreen = new panelFullScreen();
        private panelColorPreview colorPreviewPanel; // Declare the preview panel form
        private System.Windows.Forms.Timer cursorTimer;  // Timer to track cursor position
        private bool isColorPickerActive = false; // Flag to track if color picker is active

        // Declare necessary P/Invoke methods for screen capturing
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int GetCursorPos(out Point lpPoint);

        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        public Main()
        {
            InitializeComponent();
            InitializeFadeOutTimer();


            // Initialize the panelColorPreview form but keep it hidden initially
            colorPreviewPanel = new panelColorPreview();
            colorPreviewPanel.Hide(); // Hide initially

            // Initialize the timer for cursor tracking
            cursorTimer = new System.Windows.Forms.Timer();
            cursorTimer.Interval = 50; // Update every 50ms
            cursorTimer.Tick += CursorTimer_Tick;
        }


        // Initialize the fade-out timer
        private void InitializeFadeOutTimer()
        {
            fadeOutTimer = new System.Windows.Forms.Timer();
            fadeOutTimer.Interval = 5;  // Timer interval for fading (5ms)
            fadeOutTimer.Tick += FadeOutTimer_Tick;
        }

        // Timer tick event for fading out the label
        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            // Decrease the opacity of lblCopied
            if (lblCopied.BackColor.A > 0)  // Keep fading until it's fully transparent
            {
                lblCopied.BackColor = Color.FromArgb(Math.Max(lblCopied.BackColor.A - 5, 0), lblCopied.BackColor.R, lblCopied.BackColor.G, lblCopied.BackColor.B);
            }
            else
            {
                // Stop the timer and hide the label when the fade is complete
                fadeOutTimer.Stop();
                lblCopied.Visible = false;
                lblCopied.BackColor = Color.FromArgb(255, lblCopied.BackColor.R, lblCopied.BackColor.G, lblCopied.BackColor.B);  // Restore full opacity
            }

            // Decrease the opacity of lblCopied
            if (lblCopied2.BackColor.A > 0)  // Keep fading until it's fully transparent
            {
                lblCopied2.BackColor = Color.FromArgb(Math.Max(lblCopied2.BackColor.A - 5, 0), lblCopied2.BackColor.R, lblCopied2.BackColor.G, lblCopied2.BackColor.B);
            }
            else
            {
                // Stop the timer and hide the label when the fade is complete
                fadeOutTimer.Stop();
                lblCopied2.Visible = false;
                lblCopied2.BackColor = Color.FromArgb(255, lblCopied2.BackColor.R, lblCopied2.BackColor.G, lblCopied2.BackColor.B);  // Restore full opacity
            }
        }

        // Method to validate whether the color code is a valid hex color
        private bool IsValidHexColor(string hex)
        {
            if (string.IsNullOrEmpty(hex))
                return false;

            // Make sure the color code is 6 characters long and is a valid hexadecimal number
            hex = hex.Trim();

            if (hex.Length == 6)
            {
                foreach (char c in hex)
                {
                    if (!Uri.IsHexDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        // Method to filter valid hex characters from the clipboard text
        private string FilterValidHex(string input)
        {
            // Remove any characters that are not hex (0-9, A-F)
            string validHex = "";
            foreach (char c in input)
            {
                if (Uri.IsHexDigit(c))
                {
                    validHex += c;
                }
            }
            return validHex;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Get the color code entered by the user
            string colorCode = tbColorCode.Text.Trim();

            // Check if the entered color code is valid
            if (IsValidHexColor(colorCode))
            {
                // Convert Hex color code to RGB values
                Color color = ColorTranslator.FromHtml("#" + colorCode);
                pnlColor.BackColor = color;  // Set the panel color

                // Set the RGB value in the text box (format: ; ; )
                tbColorRGB.Text = $"{color.R}; {color.G}; {color.B}";

                // Set the RGB value in the text box (format: , , )
                tbColorRGB2.Text = $"{color.R}, {color.G}, {color.B}";

                // Hide the error label if the color code is valid
                lblColorHere.Visible = false;
            }
            else
            {
                // Display error message and make the label visible
                pnlColor.BackColor = Color.White;
                lblColorHere.Text = "Color Isn't Valid";                
                lblColorHere.Visible = true;
            }
        }
        private void pbCopy_Click(object sender, EventArgs e)
        {
            // If tbColorRGB is not empty, copy its text to the clipboard
            if (!string.IsNullOrEmpty(tbColorRGB.Text))
            {
                Clipboard.SetText(tbColorRGB.Text);

                // Show the "Copied!" label
                lblCopied.Visible = true;

                // Start the fade-out timer
                fadeOutTimer.Start();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Get the text from the clipboard
            string clipboardText = Clipboard.GetText().Trim();

            // Limit the pasted text to a maximum of 6 characters and ensure it's valid hex
            if (clipboardText.Length > 6)
            {
                clipboardText = clipboardText.Substring(0, 6);  // Get only the first 6 characters
            }

            // Filter only valid hex characters (0-9, A-F)
            clipboardText = FilterValidHex(clipboardText);

            // Paste the valid text into the tbColorCode TextBox
            tbColorCode.Text = clipboardText;
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            string GitHub = "https://github.com/muhameho";

            // Open the URL in the default web browser
            Process.Start(new ProcessStartInfo(GitHub) { UseShellExecute = true });
        }

        private void pbGitHub_Click(object sender, EventArgs e)
        {
            string GitHub = "https://github.com/muhameho";

            // Open the URL in the default web browser
            Process.Start(new ProcessStartInfo(GitHub) { UseShellExecute = true });
        }

        private void pbCopy2_Click(object sender, EventArgs e)
        {
            // If tbColorRGB is not empty, copy its text to the clipboard
            if (!string.IsNullOrEmpty(tbColorRGB2.Text))
            {
                Clipboard.SetText(tbColorRGB2.Text);

                // Show the "Copied!" label
                lblCopied2.Visible = true;

                // Start the fade-out timer
                fadeOutTimer.Start();
            }
        }

        private void btnPicker_Click(object sender, EventArgs e)
        {
            // Minimize
            if (isMinimized.Checked == true)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            // Set the cursor to the cross shape
            Cursor.Current = Cursors.Cross;

            // Set the panelFullScreen form to full-screen
            panelFullScreen.Top = 0;
            panelFullScreen.Left = 0;
            panelFullScreen.Width = Screen.PrimaryScreen.Bounds.Width;
            panelFullScreen.Height = Screen.PrimaryScreen.Bounds.Height;

            // Make the form fully transparent
            panelFullScreen.FormBorderStyle = FormBorderStyle.None;
            panelFullScreen.Opacity = 0.01;  // Set low opacity for transparency
            panelFullScreen.Show();

            // Set the (panel full screen) to always stay on top
            panelFullScreen.TopMost = true;

            // Set the (panel color preview) to always stay on top
            colorPreviewPanel.TopMost = true;

            // Set the flag to true, indicating that color picking is active
            isColorPickerActive = true;

            // Show the preview panel
            colorPreviewPanel.Show();

            // Start the timer to track the cursor and update the color preview
            cursorTimer.Start();

            // Change the cursor to a cross globally
            Cursor.Current = Cursors.Cross;

            // Disable all controls in the Main
            DisableControls(this);

            // Mark color picker as active
            isColorPickerActive = true;

            // Start capturing color in the background
            CaptureColorFromScreen();
        }

        private void CursorTimer_Tick(object sender, EventArgs e)
        {
            if (!isColorPickerActive) return;

            // Get the current position of the cursor
            Point cursorPos;
            GetCursorPos(out cursorPos);

            // Set the location of the panelColorPreview form to be above and to the right of the cursor
            colorPreviewPanel.Location = new Point(cursorPos.X + 10, cursorPos.Y - colorPreviewPanel.Height - 10);

            // Capture the color at the current cursor position
            IntPtr screenDC = GetDC(IntPtr.Zero); // Get the screen device context
            uint pixelColor = GetPixel(screenDC, cursorPos.X, cursorPos.Y);

            // Convert the captured color to RGB components
            int r = (int)(pixelColor & 0x000000FF);
            int g = (int)((pixelColor & 0x0000FF00) >> 8);
            int b = (int)((pixelColor & 0x00FF0000) >> 16);
            Color color = Color.FromArgb(r, g, b);

            // Update the panel color preview with the captured color
            colorPreviewPanel.UpdateColor(color);
        }


        private void DisableControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Enabled = false;
                if (control.HasChildren)
                {
                    DisableControls(control);
                }
            }
        }

        private void EnableControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Enabled = true;
                if (control.HasChildren)
                {
                    EnableControls(control);
                }
            }
        }

        private void CaptureColorFromScreen()
        {
            // Start a new task to capture color from the screen
            Task.Run(() =>
            {
                while (isColorPickerActive)
                {
                    // Wait for a click event (it could be on any part of the screen)
                    if (Control.MouseButtons == MouseButtons.Left) // User clicked anywhere
                    {
                        // Get the cursor position
                        GetCursorPos(out Point cursorPos);

                        // Capture the color at the cursor position
                        IntPtr screenDC = GetDC(IntPtr.Zero); // Get the screen device context
                        uint pixelColor = GetPixel(screenDC, cursorPos.X, cursorPos.Y);

                        // Convert the captured color to RGB components
                        int r = (int)(pixelColor & 0x000000FF);
                        int g = (int)((pixelColor & 0x0000FF00) >> 8);
                        int b = (int)((pixelColor & 0x00FF0000) >> 16);
                        Color color = Color.FromArgb(r, g, b);

                        // Update the UI on the main thread
                        Invoke(new Action(() =>
                        {
                            // Set the color in the textbox and panel
                            tbColorCode.Text = ColorTranslator.ToHtml(color).TrimStart('#');
                            pnlColor.BackColor = color;

                            // Automatically convert it to RGB
                            tbColorRGB.Text = $"{color.R}; {color.G}; {color.B}";
                            tbColorRGB2.Text = $"{color.R}, {color.G}, {color.B}";

                            // Hide error label if valid
                            lblColorHere.Visible = false;

                            // Reset the UI state
                            Cursor.Current = Cursors.Default; // Reset the cursor to default

                            // Enable all controls again
                            EnableControls(this);

                            // Mark color picking as finished
                            isColorPickerActive = false;

                            // Close the full-screen form
                            panelFullScreen.Hide();
                            colorPreviewPanel.Hide();
                            this.BringToFront();

                            //Return the cursor to default
                            Cursor.Current = Cursors.Default;

                            // Normal size
                            if (this.WindowState == FormWindowState.Minimized)
                            {
                                // Return the form to normal size
                                this.WindowState = FormWindowState.Normal;
                            }
                        }));
                        break; // Exit the loop once color is picked
                    }

                    // Delay to prevent excessive CPU usage while waiting for a click
                    Thread.Sleep(10);
                }
            });
        }


        // Helper function to get the screen device context
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        private void tbColorCode_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key was pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the beep sound when Enter is pressed
                e.SuppressKeyPress = true;

                // Simulate the click of pictureBox1
                btnConvert_Click(sender, e);
            }
        }

    }
}
