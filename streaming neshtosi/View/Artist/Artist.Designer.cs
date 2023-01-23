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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewArtist = new System.Windows.Forms.DataGridView();
            this.btnCreate1 = new System.Windows.Forms.Button();
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnRead1 = new System.Windows.Forms.Button();
            this.musicStreamingDBDataSet = new streaming_neshtosi.MusicStreamingDBDataSet();
            this.artistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistTableAdapter = new streaming_neshtosi.MusicStreamingDBDataSetTableAdapters.ArtistTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songsListDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicStreamingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArtist
            // 
            this.dataGridViewArtist.AutoGenerateColumns = false;
            this.dataGridViewArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.songsListDataGridViewTextBoxColumn,
            this.genresDataGridViewTextBoxColumn});
            this.dataGridViewArtist.DataSource = this.artistBindingSource;
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
            this.btnCreate1.Click += new System.EventHandler(this.btnCreate1_Click);
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
            // musicStreamingDBDataSet
            // 
            this.musicStreamingDBDataSet.DataSetName = "MusicStreamingDBDataSet";
            this.musicStreamingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artistBindingSource
            // 
            this.artistBindingSource.DataMember = "Artist";
            this.artistBindingSource.DataSource = this.musicStreamingDBDataSet;
            // 
            // artistTableAdapter
            // 
            this.artistTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // songsListDataGridViewTextBoxColumn
            // 
            this.songsListDataGridViewTextBoxColumn.DataPropertyName = "SongsList";
            this.songsListDataGridViewTextBoxColumn.HeaderText = "SongsList";
            this.songsListDataGridViewTextBoxColumn.Name = "songsListDataGridViewTextBoxColumn";
            // 
            // genresDataGridViewTextBoxColumn
            // 
            this.genresDataGridViewTextBoxColumn.DataPropertyName = "Genres";
            this.genresDataGridViewTextBoxColumn.HeaderText = "Genres";
            this.genresDataGridViewTextBoxColumn.Name = "genresDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(306, 334);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(306, 364);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(306, 392);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "SongsList";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Genres";
            // 
            // Artist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRead1);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnUpdate1);
            this.Controls.Add(this.btnCreate1);
            this.Controls.Add(this.dataGridViewArtist);
            this.Name = "Artist";
            this.Text = "Artist";
            this.Load += new System.EventHandler(this.Artist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicStreamingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArtist;
        private System.Windows.Forms.Button btnCreate1;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnRead1;
        private MusicStreamingDBDataSet musicStreamingDBDataSet;
        private System.Windows.Forms.BindingSource artistBindingSource;
        private MusicStreamingDBDataSetTableAdapters.ArtistTableAdapter artistTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songsListDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genresDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}