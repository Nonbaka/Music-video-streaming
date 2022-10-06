namespace streaming_neshtosi.View.Artist
{
    partial class Artist
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
            this.dataGridViewArtist = new System.Windows.Forms.DataGridView();
            this.btnCreate1 = new System.Windows.Forms.Button();
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnRead1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArtist
            // 
            this.dataGridViewArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtist.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewArtist.Name = "dataGridViewArtist";
            this.dataGridViewArtist.Size = new System.Drawing.Size(776, 262);
            this.dataGridViewArtist.TabIndex = 0;
            // 
            // btnCreate1
            // 
            this.btnCreate1.Location = new System.Drawing.Point(508, 280);
            this.btnCreate1.Name = "btnCreate1";
            this.btnCreate1.Size = new System.Drawing.Size(137, 74);
            this.btnCreate1.TabIndex = 1;
            this.btnCreate1.Text = "create";
            this.btnCreate1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.Location = new System.Drawing.Point(508, 364);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(137, 74);
            this.btnUpdate1.TabIndex = 2;
            this.btnUpdate1.Text = "update";
            this.btnUpdate1.UseVisualStyleBackColor = true;
            // 
            // btnDelete1
            // 
            this.btnDelete1.Location = new System.Drawing.Point(651, 280);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(137, 74);
            this.btnDelete1.TabIndex = 3;
            this.btnDelete1.Text = "delete";
            this.btnDelete1.UseVisualStyleBackColor = true;
            // 
            // btnRead1
            // 
            this.btnRead1.Location = new System.Drawing.Point(651, 364);
            this.btnRead1.Name = "btnRead1";
            this.btnRead1.Size = new System.Drawing.Size(137, 74);
            this.btnRead1.TabIndex = 4;
            this.btnRead1.Text = "read";
            this.btnRead1.UseVisualStyleBackColor = true;
            // 
            // Artist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRead1);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnUpdate1);
            this.Controls.Add(this.btnCreate1);
            this.Controls.Add(this.dataGridViewArtist);
            this.Name = "Artist";
            this.Text = "Artist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArtist;
        private System.Windows.Forms.Button btnCreate1;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnRead1;
    }
}