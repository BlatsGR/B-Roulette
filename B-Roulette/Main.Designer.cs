namespace B_Roulette
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDevelop = new MaterialSkin.Controls.MaterialLabel();
            this.lblThemeSwitch = new MaterialSkin.Controls.MaterialLabel();
            this.themeSwitcher = new MaterialSkin.Controls.MaterialSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::B_Roulette.Properties.Resources.rouleta;
            this.pictureBox1.Location = new System.Drawing.Point(421, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDevelop
            // 
            this.lblDevelop.AutoSize = true;
            this.lblDevelop.Depth = 0;
            this.lblDevelop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDevelop.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDevelop.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblDevelop.HighEmphasis = true;
            this.lblDevelop.Location = new System.Drawing.Point(831, 663);
            this.lblDevelop.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDevelop.Name = "lblDevelop";
            this.lblDevelop.Size = new System.Drawing.Size(198, 24);
            this.lblDevelop.TabIndex = 1;
            this.lblDevelop.Text = "Developed By Blats.gr";
            this.lblDevelop.UseAccent = true;
            // 
            // lblThemeSwitch
            // 
            this.lblThemeSwitch.AutoSize = true;
            this.lblThemeSwitch.Depth = 0;
            this.lblThemeSwitch.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblThemeSwitch.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblThemeSwitch.Location = new System.Drawing.Point(825, 72);
            this.lblThemeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblThemeSwitch.Name = "lblThemeSwitch";
            this.lblThemeSwitch.Size = new System.Drawing.Size(141, 24);
            this.lblThemeSwitch.TabIndex = 2;
            this.lblThemeSwitch.Text = "Change Theme:";
            // 
            // themeSwitcher
            // 
            this.themeSwitcher.AutoSize = true;
            this.themeSwitcher.Depth = 0;
            this.themeSwitcher.Location = new System.Drawing.Point(966, 67);
            this.themeSwitcher.Margin = new System.Windows.Forms.Padding(0);
            this.themeSwitcher.MouseLocation = new System.Drawing.Point(-1, -1);
            this.themeSwitcher.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeSwitcher.Name = "themeSwitcher";
            this.themeSwitcher.Ripple = true;
            this.themeSwitcher.Size = new System.Drawing.Size(58, 37);
            this.themeSwitcher.TabIndex = 3;
            this.themeSwitcher.UseVisualStyleBackColor = true;
            this.themeSwitcher.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 693);
            this.Controls.Add(this.themeSwitcher);
            this.Controls.Add(this.lblThemeSwitch);
            this.Controls.Add(this.lblDevelop);
            this.Controls.Add(this.pictureBox1);
            this.DrawerShowIconsWhenHidden = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B-Roulette Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblDevelop;
        private MaterialSkin.Controls.MaterialLabel lblThemeSwitch;
        private MaterialSkin.Controls.MaterialSwitch themeSwitcher;
    }
}