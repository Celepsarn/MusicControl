namespace MusicControl.Presentation
{
    partial class SongWizzard
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
            this.lblTrackNo = new System.Windows.Forms.Label();
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblLyrics = new System.Windows.Forms.Label();
            this.edTrackNo = new System.Windows.Forms.TextBox();
            this.edSongName = new System.Windows.Forms.TextBox();
            this.edDuration = new System.Windows.Forms.TextBox();
            this.edLyrics = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrackNo
            // 
            this.lblTrackNo.AutoSize = true;
            this.lblTrackNo.Location = new System.Drawing.Point(4, 8);
            this.lblTrackNo.Name = "lblTrackNo";
            this.lblTrackNo.Size = new System.Drawing.Size(67, 13);
            this.lblTrackNo.TabIndex = 0;
            this.lblTrackNo.Text = "Titelnummer:";
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Location = new System.Drawing.Point(4, 32);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(30, 13);
            this.lblSongName.TabIndex = 1;
            this.lblSongName.Text = "Titel:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(4, 56);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(39, 13);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Dauer:";
            // 
            // lblLyrics
            // 
            this.lblLyrics.AutoSize = true;
            this.lblLyrics.Location = new System.Drawing.Point(4, 84);
            this.lblLyrics.Name = "lblLyrics";
            this.lblLyrics.Size = new System.Drawing.Size(52, 13);
            this.lblLyrics.TabIndex = 3;
            this.lblLyrics.Text = "Songtext:";
            // 
            // edTrackNo
            // 
            this.edTrackNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edTrackNo.Location = new System.Drawing.Point(100, 4);
            this.edTrackNo.Name = "edTrackNo";
            this.edTrackNo.Size = new System.Drawing.Size(180, 20);
            this.edTrackNo.TabIndex = 4;
            // 
            // edSongName
            // 
            this.edSongName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edSongName.Location = new System.Drawing.Point(100, 28);
            this.edSongName.Name = "edSongName";
            this.edSongName.Size = new System.Drawing.Size(180, 20);
            this.edSongName.TabIndex = 5;
            // 
            // edDuration
            // 
            this.edDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edDuration.Location = new System.Drawing.Point(100, 52);
            this.edDuration.Name = "edDuration";
            this.edDuration.Size = new System.Drawing.Size(180, 20);
            this.edDuration.TabIndex = 6;
            // 
            // edLyrics
            // 
            this.edLyrics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edLyrics.Location = new System.Drawing.Point(4, 103);
            this.edLyrics.Multiline = true;
            this.edLyrics.Name = "edLyrics";
            this.edLyrics.Size = new System.Drawing.Size(276, 126);
            this.edLyrics.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(205, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(124, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Hinzufügen";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SongWizzard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.edLyrics);
            this.Controls.Add(this.edDuration);
            this.Controls.Add(this.edSongName);
            this.Controls.Add(this.edTrackNo);
            this.Controls.Add(this.lblLyrics);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.lblTrackNo);
            this.Name = "SongWizzard";
            this.Text = "Song hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrackNo;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblLyrics;
        private System.Windows.Forms.TextBox edTrackNo;
        private System.Windows.Forms.TextBox edSongName;
        private System.Windows.Forms.TextBox edDuration;
        private System.Windows.Forms.TextBox edLyrics;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}