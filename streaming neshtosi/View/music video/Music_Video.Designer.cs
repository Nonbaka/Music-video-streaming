namespace streaming_neshtosi.View.music_video
{
    partial class Music_Video
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
            this.dataGridViewMusicvideo = new System.Windows.Forms.DataGridView();
            this.btnUpdate3 = new System.Windows.Forms.Button();
            this.btnCreate3 = new System.Windows.Forms.Button();
            this.btnRead3 = new System.Windows.Forms.Button();
            this.btnDelete3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusicvideo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMusicvideo
            // 
            this.dataGridViewMusicvideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusicvideo.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMusicvideo.Name = "dataGridViewMusicvideo";
            this.dataGridViewMusicvideo.Size = new System.Drawing.Size(776, 256);
            this.dataGridViewMusicvideo.TabIndex = 0;
            // 
            // btnUpdate3
            // 
            this.btnUpdate3.Location = new System.Drawing.Point(508, 364);
            this.btnUpdate3.Name = "btnUpdate3";
            this.btnUpdate3.Size = new System.Drawing.Size(137, 74);
            this.btnUpdate3.TabIndex = 2;
            this.btnUpdate3.Text = "update";
            this.btnUpdate3.UseVisualStyleBackColor = true;
            // 
            // btnCreate3
            // 
            this.btnCreate3.Location = new System.Drawing.Point(508, 274);
            this.btnCreate3.Name = "btnCreate3";
            this.btnCreate3.Size = new System.Drawing.Size(137, 74);
            this.btnCreate3.TabIndex = 3;
            this.btnCreate3.Text = "create";
            this.btnCreate3.UseVisualStyleBackColor = true;
            // 
            // btnRead3
            // 
            this.btnRead3.Location = new System.Drawing.Point(651, 364);
            this.btnRead3.Name = "btnRead3";
            this.btnRead3.Size = new System.Drawing.Size(137, 74);
            this.btnRead3.TabIndex = 4;
            this.btnRead3.Text = "read";
            this.btnRead3.UseVisualStyleBackColor = true;
            // 
            // btnDelete3
            // 
            this.btnDelete3.Location = new System.Drawing.Point(651, 274);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(137, 74);
            this.btnDelete3.TabIndex = 5;
            this.btnDelete3.Text = "delete";
            this.btnDelete3.UseVisualStyleBackColor = true;
            // 
            // Music_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete3);
            this.Controls.Add(this.btnRead3);
            this.Controls.Add(this.btnCreate3);
            this.Controls.Add(this.btnUpdate3);
            this.Controls.Add(this.dataGridViewMusicvideo);
            this.Name = "Music_Video";
            this.Text = "Music_Video";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusicvideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMusicvideo;
        private System.Windows.Forms.Button btnUpdate3;
        private System.Windows.Forms.Button btnCreate3;
        private System.Windows.Forms.Button btnRead3;
        private System.Windows.Forms.Button btnDelete3;
    }
}