namespace AppleMusic
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.a_music = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.a_music)).BeginInit();
            this.SuspendLayout();
            // 
            // a_music
            // 
            this.a_music.AllowExternalDrop = true;
            this.a_music.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.a_music.CreationProperties = null;
            this.a_music.DefaultBackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.a_music.Location = new System.Drawing.Point(0, 0);
            this.a_music.Name = "a_music";
            this.a_music.Size = new System.Drawing.Size(984, 611);
            this.a_music.Source = new System.Uri("https://music.apple.com/us/browse", System.UriKind.Absolute);
            this.a_music.TabIndex = 0;
            this.a_music.ZoomFactor = 1D;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.a_music);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music";
            ((System.ComponentModel.ISupportInitialize)(this.a_music)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 a_music;
    }
}

