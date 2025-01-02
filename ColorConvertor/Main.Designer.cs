namespace ColorConvertor
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tbColorCode = new System.Windows.Forms.TextBox();
            this.tbColorRGB = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.lblColorHere = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pbCopy = new System.Windows.Forms.PictureBox();
            this.pbPaste = new System.Windows.Forms.PictureBox();
            this.lblCopied = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCopied2 = new System.Windows.Forms.Label();
            this.pbCopy2 = new System.Windows.Forms.PictureBox();
            this.tbColorRGB2 = new System.Windows.Forms.TextBox();
            this.btnPicker = new System.Windows.Forms.Button();
            this.isMinimized = new System.Windows.Forms.CheckBox();
            this.pbGitHub = new System.Windows.Forms.PictureBox();
            this.pnlColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).BeginInit();
            this.SuspendLayout();
            // 
            // tbColorCode
            // 
            this.tbColorCode.Font = new System.Drawing.Font("STC Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColorCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tbColorCode.Location = new System.Drawing.Point(12, 185);
            this.tbColorCode.MaxLength = 6;
            this.tbColorCode.Name = "tbColorCode";
            this.tbColorCode.Size = new System.Drawing.Size(219, 29);
            this.tbColorCode.TabIndex = 1;
            this.tbColorCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbColorCode_KeyDown);
            // 
            // tbColorRGB
            // 
            this.tbColorRGB.Enabled = false;
            this.tbColorRGB.Font = new System.Drawing.Font("STC Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColorRGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tbColorRGB.Location = new System.Drawing.Point(13, 236);
            this.tbColorRGB.Name = "tbColorRGB";
            this.tbColorRGB.ReadOnly = true;
            this.tbColorRGB.Size = new System.Drawing.Size(219, 29);
            this.tbColorRGB.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvert.FlatAppearance.BorderSize = 0;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("STC Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnConvert.Location = new System.Drawing.Point(267, 185);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 29);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // pnlColor
            // 
            this.pnlColor.Controls.Add(this.lblColorHere);
            this.pnlColor.Location = new System.Drawing.Point(12, 13);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(330, 150);
            this.pnlColor.TabIndex = 4;
            // 
            // lblColorHere
            // 
            this.lblColorHere.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblColorHere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblColorHere.Location = new System.Drawing.Point(60, 58);
            this.lblColorHere.Name = "lblColorHere";
            this.lblColorHere.Size = new System.Drawing.Size(214, 26);
            this.lblColorHere.TabIndex = 0;
            this.lblColorHere.Text = "Color Will Be Shown Here";
            this.lblColorHere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAbout.Font = new System.Drawing.Font("STC Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblAbout.Location = new System.Drawing.Point(281, 351);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(71, 15);
            this.lblAbout.TabIndex = 5;
            this.lblAbout.Text = "@muhameho";
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // pbCopy
            // 
            this.pbCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCopy.Image = ((System.Drawing.Image)(resources.GetObject("pbCopy.Image")));
            this.pbCopy.Location = new System.Drawing.Point(234, 235);
            this.pbCopy.Name = "pbCopy";
            this.pbCopy.Size = new System.Drawing.Size(32, 32);
            this.pbCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCopy.TabIndex = 7;
            this.pbCopy.TabStop = false;
            this.pbCopy.Click += new System.EventHandler(this.pbCopy_Click);
            // 
            // pbPaste
            // 
            this.pbPaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPaste.Image = ((System.Drawing.Image)(resources.GetObject("pbPaste.Image")));
            this.pbPaste.Location = new System.Drawing.Point(236, 185);
            this.pbPaste.Name = "pbPaste";
            this.pbPaste.Size = new System.Drawing.Size(28, 28);
            this.pbPaste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPaste.TabIndex = 8;
            this.pbPaste.TabStop = false;
            this.pbPaste.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCopied
            // 
            this.lblCopied.AutoSize = true;
            this.lblCopied.BackColor = System.Drawing.Color.Transparent;
            this.lblCopied.Font = new System.Drawing.Font("STC Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCopied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblCopied.Location = new System.Drawing.Point(264, 244);
            this.lblCopied.Name = "lblCopied";
            this.lblCopied.Size = new System.Drawing.Size(42, 15);
            this.lblCopied.TabIndex = 9;
            this.lblCopied.Text = "Copied!";
            this.lblCopied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCopied.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STC Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hex Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STC Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Color to RGB (Form Usage) ;";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("STC Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(12, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Color to RGB (Code Usage) ,";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCopied2
            // 
            this.lblCopied2.AutoSize = true;
            this.lblCopied2.BackColor = System.Drawing.Color.Transparent;
            this.lblCopied2.Font = new System.Drawing.Font("STC Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCopied2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblCopied2.Location = new System.Drawing.Point(264, 297);
            this.lblCopied2.Name = "lblCopied2";
            this.lblCopied2.Size = new System.Drawing.Size(42, 15);
            this.lblCopied2.TabIndex = 15;
            this.lblCopied2.Text = "Copied!";
            this.lblCopied2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCopied2.Visible = false;
            // 
            // pbCopy2
            // 
            this.pbCopy2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCopy2.Image = ((System.Drawing.Image)(resources.GetObject("pbCopy2.Image")));
            this.pbCopy2.Location = new System.Drawing.Point(234, 288);
            this.pbCopy2.Name = "pbCopy2";
            this.pbCopy2.Size = new System.Drawing.Size(32, 32);
            this.pbCopy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCopy2.TabIndex = 14;
            this.pbCopy2.TabStop = false;
            this.pbCopy2.Click += new System.EventHandler(this.pbCopy2_Click);
            // 
            // tbColorRGB2
            // 
            this.tbColorRGB2.Enabled = false;
            this.tbColorRGB2.Font = new System.Drawing.Font("STC Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColorRGB2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tbColorRGB2.Location = new System.Drawing.Point(13, 289);
            this.tbColorRGB2.Name = "tbColorRGB2";
            this.tbColorRGB2.ReadOnly = true;
            this.tbColorRGB2.Size = new System.Drawing.Size(219, 29);
            this.tbColorRGB2.TabIndex = 13;
            // 
            // btnPicker
            // 
            this.btnPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPicker.FlatAppearance.BorderSize = 0;
            this.btnPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicker.Image = ((System.Drawing.Image)(resources.GetObject("btnPicker.Image")));
            this.btnPicker.Location = new System.Drawing.Point(15, 325);
            this.btnPicker.Name = "btnPicker";
            this.btnPicker.Size = new System.Drawing.Size(32, 32);
            this.btnPicker.TabIndex = 16;
            this.btnPicker.UseVisualStyleBackColor = false;
            this.btnPicker.Click += new System.EventHandler(this.btnPicker_Click);
            // 
            // isMinimized
            // 
            this.isMinimized.AutoSize = true;
            this.isMinimized.Font = new System.Drawing.Font("STC Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isMinimized.Location = new System.Drawing.Point(53, 332);
            this.isMinimized.Name = "isMinimized";
            this.isMinimized.Size = new System.Drawing.Size(86, 21);
            this.isMinimized.TabIndex = 17;
            this.isMinimized.Text = "isMinimized";
            this.isMinimized.UseVisualStyleBackColor = true;
            // 
            // pbGitHub
            // 
            this.pbGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGitHub.Image = ((System.Drawing.Image)(resources.GetObject("pbGitHub.Image")));
            this.pbGitHub.Location = new System.Drawing.Point(271, 354);
            this.pbGitHub.Name = "pbGitHub";
            this.pbGitHub.Size = new System.Drawing.Size(12, 12);
            this.pbGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGitHub.TabIndex = 18;
            this.pbGitHub.TabStop = false;
            this.pbGitHub.Click += new System.EventHandler(this.pbGitHub_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 369);
            this.Controls.Add(this.pbGitHub);
            this.Controls.Add(this.isMinimized);
            this.Controls.Add(this.btnPicker);
            this.Controls.Add(this.lblCopied2);
            this.Controls.Add(this.pbCopy2);
            this.Controls.Add(this.tbColorRGB2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCopied);
            this.Controls.Add(this.pbPaste);
            this.Controls.Add(this.pbCopy);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbColorRGB);
            this.Controls.Add(this.tbColorCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            this.TopMost = true;
            this.pnlColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbColorCode;
        private System.Windows.Forms.TextBox tbColorRGB;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Label lblColorHere;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.PictureBox pbCopy;
        private System.Windows.Forms.PictureBox pbPaste;
        private System.Windows.Forms.Label lblCopied;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCopied2;
        private System.Windows.Forms.PictureBox pbCopy2;
        private System.Windows.Forms.TextBox tbColorRGB2;
        private System.Windows.Forms.Button btnPicker;
        private System.Windows.Forms.CheckBox isMinimized;
        private System.Windows.Forms.PictureBox pbGitHub;
    }
}

