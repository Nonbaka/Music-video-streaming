namespace streaming_neshtosi.View.janr
{
    partial class Genre
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
            this.dataGridViewGenre = new System.Windows.Forms.DataGridView();
            this.btnUpdate2 = new System.Windows.Forms.Button();
            this.btnCreate2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnRead2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGenre
            // 
            this.dataGridViewGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenre.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewGenre.Name = "dataGridViewGenre";
            this.dataGridViewGenre.Size = new System.Drawing.Size(776, 248);
            this.dataGridViewGenre.TabIndex = 0;
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.Location = new System.Drawing.Point(508, 364);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(137, 74);
            this.btnUpdate2.TabIndex = 2;
            this.btnUpdate2.Text = "update";
            this.btnUpdate2.UseVisualStyleBackColor = true;
            // 
            // btnCreate2
            // 
            this.btnCreate2.Location = new System.Drawing.Point(508, 266);
            this.btnCreate2.Name = "btnCreate2";
            this.btnCreate2.Size = new System.Drawing.Size(137, 74);
            this.btnCreate2.TabIndex = 3;
            this.btnCreate2.Text = "create";
            this.btnCreate2.UseVisualStyleBackColor = true;
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(651, 266);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(137, 74);
            this.btnDelete2.TabIndex = 4;
            this.btnDelete2.Text = "delete";
            this.btnDelete2.UseVisualStyleBackColor = true;
            // 
            // btnRead2
            // 
            this.btnRead2.Location = new System.Drawing.Point(651, 364);
            this.btnRead2.Name = "btnRead2";
            this.btnRead2.Size = new System.Drawing.Size(137, 74);
            this.btnRead2.TabIndex = 5;
            this.btnRead2.Text = "read";
            this.btnRead2.UseVisualStyleBackColor = true;
            // 
            // Janr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRead2);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnCreate2);
            this.Controls.Add(this.btnUpdate2);
            this.Controls.Add(this.dataGridViewGenre);
            this.Name = "Janr";
            this.Text = "Janr";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGenre;
        private System.Windows.Forms.Button btnUpdate2;
        private System.Windows.Forms.Button btnCreate2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnRead2;
    }
}