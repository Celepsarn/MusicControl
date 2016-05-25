namespace MusicControl.Presentation
{
    partial class InterpretWizzard
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
            this.lblName = new System.Windows.Forms.Label();
            this.edName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.edLand = new System.Windows.Forms.TextBox();
            this.lblFoundationYear = new System.Windows.Forms.Label();
            this.lblLand = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.edFoundationYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // edName
            // 
            this.edName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edName.Location = new System.Drawing.Point(100, 4);
            this.edName.Name = "edName";
            this.edName.Size = new System.Drawing.Size(100, 20);
            this.edName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(44, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // edLand
            // 
            this.edLand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edLand.Location = new System.Drawing.Point(100, 52);
            this.edLand.Name = "edLand";
            this.edLand.Size = new System.Drawing.Size(100, 20);
            this.edLand.TabIndex = 4;
            // 
            // lblFoundationYear
            // 
            this.lblFoundationYear.AutoSize = true;
            this.lblFoundationYear.Location = new System.Drawing.Point(4, 32);
            this.lblFoundationYear.Name = "lblFoundationYear";
            this.lblFoundationYear.Size = new System.Drawing.Size(79, 13);
            this.lblFoundationYear.TabIndex = 5;
            this.lblFoundationYear.Text = "Gründungsjahr:";
            // 
            // lblLand
            // 
            this.lblLand.AutoSize = true;
            this.lblLand.Location = new System.Drawing.Point(4, 56);
            this.lblLand.Name = "lblLand";
            this.lblLand.Size = new System.Drawing.Size(34, 13);
            this.lblLand.TabIndex = 6;
            this.lblLand.Text = "Land:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(125, 78);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // edFoundationYear
            // 
            this.edFoundationYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edFoundationYear.Location = new System.Drawing.Point(100, 28);
            this.edFoundationYear.Name = "edFoundationYear";
            this.edFoundationYear.Size = new System.Drawing.Size(100, 20);
            this.edFoundationYear.TabIndex = 8;
            // 
            // InterpretWizzard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 103);
            this.Controls.Add(this.edFoundationYear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLand);
            this.Controls.Add(this.lblFoundationYear);
            this.Controls.Add(this.edLand);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.edName);
            this.Controls.Add(this.lblName);
            this.MinimumSize = new System.Drawing.Size(220, 142);
            this.Name = "InterpretWizzard";
            this.Text = "Neuer Interpret erstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox edName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox edLand;
        private System.Windows.Forms.Label lblFoundationYear;
        private System.Windows.Forms.Label lblLand;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox edFoundationYear;
    }
}