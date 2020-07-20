using System;

namespace YouthSports
{
    partial class Form1
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkGloves = new System.Windows.Forms.CheckBox();
            this.chkSkis = new System.Windows.Forms.CheckBox();
            this.chkGoggles = new System.Windows.Forms.CheckBox();
            this.chkEarMuffs = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(342, 401);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 25);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(473, 401);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // chkGloves
            // 
            this.chkGloves.AutoSize = true;
            this.chkGloves.Location = new System.Drawing.Point(52, 45);
            this.chkGloves.Name = "chkGloves";
            this.chkGloves.Size = new System.Drawing.Size(89, 17);
            this.chkGloves.TabIndex = 2;
            this.chkGloves.Text = "Snow Gloves";
            this.chkGloves.UseVisualStyleBackColor = true;
            // 
            // chkSkis
            // 
            this.chkSkis.AutoSize = true;
            this.chkSkis.Location = new System.Drawing.Point(52, 87);
            this.chkSkis.Name = "chkSkis";
            this.chkSkis.Size = new System.Drawing.Size(46, 17);
            this.chkSkis.TabIndex = 3;
            this.chkSkis.Text = "Skis";
            this.chkSkis.UseVisualStyleBackColor = true;
            // 
            // chkGoggles
            // 
            this.chkGoggles.AutoSize = true;
            this.chkGoggles.Location = new System.Drawing.Point(52, 132);
            this.chkGoggles.Name = "chkGoggles";
            this.chkGoggles.Size = new System.Drawing.Size(65, 17);
            this.chkGoggles.TabIndex = 4;
            this.chkGoggles.Text = "Goggles";
            this.chkGoggles.UseVisualStyleBackColor = true;
            // 
            // chkEarMuffs
            // 
            this.chkEarMuffs.AutoSize = true;
            this.chkEarMuffs.Location = new System.Drawing.Point(52, 180);
            this.chkEarMuffs.Name = "chkEarMuffs";
            this.chkEarMuffs.Size = new System.Drawing.Size(67, 17);
            this.chkEarMuffs.TabIndex = 5;
            this.chkEarMuffs.Text = "Earmuffs";
            this.chkEarMuffs.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YouthSports.Properties.Resources.man_downhill_skiing_yellow_jacket_b;
            this.pictureBox1.Location = new System.Drawing.Point(207, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkEarMuffs);
            this.Controls.Add(this.chkGoggles);
            this.Controls.Add(this.chkSkis);
            this.Controls.Add(this.chkGloves);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkGloves;
        private System.Windows.Forms.CheckBox chkSkis;
        private System.Windows.Forms.CheckBox chkGoggles;
        private System.Windows.Forms.CheckBox chkEarMuffs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}