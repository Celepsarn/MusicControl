namespace MusicControl.Presentation
{
    partial class AlbumWizzard
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
            this.cbInterprets = new System.Windows.Forms.ComboBox();
            this.lblInterpret = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.edName = new System.Windows.Forms.TextBox();
            this.lblSongs = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cbGenres = new System.Windows.Forms.ComboBox();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.edReleaseYear = new System.Windows.Forms.TextBox();
            this.listSongs = new System.Windows.Forms.ListView();
            this.colSongs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbInterprets
            // 
            this.cbInterprets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInterprets.FormattingEnabled = true;
            this.cbInterprets.Location = new System.Drawing.Point(100, 4);
            this.cbInterprets.Name = "cbInterprets";
            this.cbInterprets.Size = new System.Drawing.Size(179, 21);
            this.cbInterprets.TabIndex = 0;
            // 
            // lblInterpret
            // 
            this.lblInterpret.AutoSize = true;
            this.lblInterpret.Location = new System.Drawing.Point(4, 8);
            this.lblInterpret.Name = "lblInterpret";
            this.lblInterpret.Size = new System.Drawing.Size(49, 13);
            this.lblInterpret.TabIndex = 1;
            this.lblInterpret.Text = "Interpret:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // edName
            // 
            this.edName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edName.Location = new System.Drawing.Point(100, 28);
            this.edName.Name = "edName";
            this.edName.Size = new System.Drawing.Size(179, 20);
            this.edName.TabIndex = 1;
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Location = new System.Drawing.Point(4, 108);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(30, 13);
            this.lblSongs.TabIndex = 5;
            this.lblSongs.Text = "Titel:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(100, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(204, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(123, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(4, 80);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(39, 13);
            this.lblGenre.TabIndex = 10;
            this.lblGenre.Text = "Genre:";
            // 
            // cbGenres
            // 
            this.cbGenres.FormattingEnabled = true;
            this.cbGenres.Location = new System.Drawing.Point(100, 76);
            this.cbGenres.Name = "cbGenres";
            this.cbGenres.Size = new System.Drawing.Size(179, 21);
            this.cbGenres.TabIndex = 3;
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Location = new System.Drawing.Point(4, 56);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(91, 13);
            this.lblReleaseYear.TabIndex = 12;
            this.lblReleaseYear.Text = "Erscheinungsjahr:";
            // 
            // edReleaseYear
            // 
            this.edReleaseYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edReleaseYear.Location = new System.Drawing.Point(100, 52);
            this.edReleaseYear.Name = "edReleaseYear";
            this.edReleaseYear.Size = new System.Drawing.Size(179, 20);
            this.edReleaseYear.TabIndex = 2;
            // 
            // listSongs
            // 
            this.listSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSongs});
            this.listSongs.Location = new System.Drawing.Point(7, 132);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(272, 97);
            this.listSongs.TabIndex = 13;
            this.listSongs.UseCompatibleStateImageBehavior = false;
            this.listSongs.View = System.Windows.Forms.View.Details;
            // 
            // colSongs
            // 
            this.colSongs.Text = "Songs";
            this.colSongs.Width = 267;
            // 
            // AlbumWizzard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listSongs);
            this.Controls.Add(this.edReleaseYear);
            this.Controls.Add(this.lblReleaseYear);
            this.Controls.Add(this.cbGenres);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.edName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblInterpret);
            this.Controls.Add(this.cbInterprets);
            this.Name = "AlbumWizzard";
            this.Text = "Neues Album erstellen";
            this.Load += new System.EventHandler(this.AlbumWizzard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInterprets;
        private System.Windows.Forms.Label lblInterpret;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox edName;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cbGenres;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.TextBox edReleaseYear;
        private System.Windows.Forms.ListView listSongs;
        private System.Windows.Forms.ColumnHeader colSongs;
    }
}