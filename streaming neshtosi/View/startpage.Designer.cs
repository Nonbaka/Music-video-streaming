namespace streaming_neshtosi
{
    partial class startpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startpage));
            this.btnArtist = new System.Windows.Forms.Button();
            this.btnJanr = new System.Windows.Forms.Button();
            this.btnMusicvideo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArtist
            // 
            this.btnArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnArtist.Location = new System.Drawing.Point(247, 12);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Size = new System.Drawing.Size(433, 175);
            this.btnArtist.TabIndex = 0;
            this.btnArtist.Text = "artist";
            this.btnArtist.UseVisualStyleBackColor = true;
            // 
            // btnJanr
            // 
            this.btnJanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnJanr.Location = new System.Drawing.Point(247, 243);
            this.btnJanr.Name = "btnJanr";
            this.btnJanr.Size = new System.Drawing.Size(433, 170);
            this.btnJanr.TabIndex = 1;
            this.btnJanr.Text = "janr";
            this.btnJanr.UseVisualStyleBackColor = true;
            // 
            // btnMusicvideo
            // 
            this.btnMusicvideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMusicvideo.Location = new System.Drawing.Point(247, 482);
            this.btnMusicvideo.Name = "btnMusicvideo";
            this.btnMusicvideo.Size = new System.Drawing.Size(433, 170);
            this.btnMusicvideo.TabIndex = 2;
            this.btnMusicvideo.Text = "music video";
            this.btnMusicvideo.UseVisualStyleBackColor = true;
            // 
            // startpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(925, 663);
            this.Controls.Add(this.btnMusicvideo);
            this.Controls.Add(this.btnJanr);
            this.Controls.Add(this.btnArtist);
            this.Name = "startpage";
            this.Text = "startpage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArtist;
        private System.Windows.Forms.Button btnJanr;
        private System.Windows.Forms.Button btnMusicvideo;
    }
}

