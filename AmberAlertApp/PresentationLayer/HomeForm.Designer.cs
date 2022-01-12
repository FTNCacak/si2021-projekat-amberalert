
namespace PresentationLayer
{
    partial class HomeForm
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
            this.HomeBackground = new System.Windows.Forms.PictureBox();
            this.ExitHome = new System.Windows.Forms.PictureBox();
            this.buttonAddMissing = new System.Windows.Forms.Button();
            this.buttonMissingSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitHome)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeBackground
            // 
            this.HomeBackground.Image = global::PresentationLayer.Properties.Resources.homeback;
            this.HomeBackground.Location = new System.Drawing.Point(-24, -3);
            this.HomeBackground.Name = "HomeBackground";
            this.HomeBackground.Size = new System.Drawing.Size(1195, 716);
            this.HomeBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeBackground.TabIndex = 0;
            this.HomeBackground.TabStop = false;
            this.HomeBackground.Click += new System.EventHandler(this.HomeBackground_Click);
            // 
            // ExitHome
            // 
            this.ExitHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ExitHome.Image = global::PresentationLayer.Properties.Resources.x;
            this.ExitHome.Location = new System.Drawing.Point(12, 12);
            this.ExitHome.Name = "ExitHome";
            this.ExitHome.Size = new System.Drawing.Size(29, 32);
            this.ExitHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitHome.TabIndex = 1;
            this.ExitHome.TabStop = false;
            this.ExitHome.Click += new System.EventHandler(this.ExitHome_Click);
            // 
            // buttonAddMissing
            // 
            this.buttonAddMissing.BackColor = System.Drawing.Color.Black;
            this.buttonAddMissing.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(55)))), ((int)(((byte)(24)))));
            this.buttonAddMissing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAddMissing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonAddMissing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMissing.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMissing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(55)))), ((int)(((byte)(24)))));
            this.buttonAddMissing.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddMissing.Location = new System.Drawing.Point(24, 299);
            this.buttonAddMissing.Name = "buttonAddMissing";
            this.buttonAddMissing.Size = new System.Drawing.Size(295, 89);
            this.buttonAddMissing.TabIndex = 2;
            this.buttonAddMissing.Text = "EVIDENCIJA NESTALIH";
            this.buttonAddMissing.UseVisualStyleBackColor = false;
            this.buttonAddMissing.Click += new System.EventHandler(this.buttonAddMissing_Click);
            // 
            // buttonMissingSearch
            // 
            this.buttonMissingSearch.BackColor = System.Drawing.Color.Black;
            this.buttonMissingSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(55)))), ((int)(((byte)(24)))));
            this.buttonMissingSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMissingSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonMissingSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMissingSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMissingSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(55)))), ((int)(((byte)(24)))));
            this.buttonMissingSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMissingSearch.Location = new System.Drawing.Point(24, 416);
            this.buttonMissingSearch.Name = "buttonMissingSearch";
            this.buttonMissingSearch.Size = new System.Drawing.Size(295, 89);
            this.buttonMissingSearch.TabIndex = 3;
            this.buttonMissingSearch.Text = "PRETRAGA PRONALAZAKA";
            this.buttonMissingSearch.UseVisualStyleBackColor = false;
            this.buttonMissingSearch.Click += new System.EventHandler(this.buttonMissingSearch_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 665);
            this.Controls.Add(this.buttonMissingSearch);
            this.Controls.Add(this.buttonAddMissing);
            this.Controls.Add(this.ExitHome);
            this.Controls.Add(this.HomeBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.HomeBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HomeBackground;
        private System.Windows.Forms.PictureBox ExitHome;
        private System.Windows.Forms.Button buttonAddMissing;
        private System.Windows.Forms.Button buttonMissingSearch;
    }
}