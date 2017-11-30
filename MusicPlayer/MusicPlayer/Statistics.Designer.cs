﻿namespace MusicPlayer
{
    partial class Statistics
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongTrend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongName,
            this.SongScore,
            this.SongTrend,
            this.SongAge,
            this.Chance});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 600);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.Resize += new System.EventHandler(this.dataGridView1_Resize);
            // 
            // SongName
            // 
            this.SongName.HeaderText = "SongName";
            this.SongName.Name = "SongName";
            // 
            // SongScore
            // 
            this.SongScore.HeaderText = "SongScore";
            this.SongScore.Name = "SongScore";
            // 
            // SongTrend
            // 
            this.SongTrend.HeaderText = "SongTrend";
            this.SongTrend.Name = "SongTrend";
            // 
            // SongAge
            // 
            this.SongAge.HeaderText = "SongAge (in Days)";
            this.SongAge.Name = "SongAge";
            // 
            // Chance
            // 
            this.Chance.HeaderText = "PlayChance (in %)";
            this.Chance.Name = "Chance";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 625);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongTrend;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chance;
    }
}