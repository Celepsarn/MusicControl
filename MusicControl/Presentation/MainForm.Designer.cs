namespace MusicControl.Presentation
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menTopBar = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interpretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.edSearchBar = new System.Windows.Forms.TextBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnFavorites = new System.Windows.Forms.Panel();
            this.lblFavTitle = new System.Windows.Forms.Label();
            this.spltr2 = new System.Windows.Forms.Splitter();
            this.pnDetailEditing = new System.Windows.Forms.Panel();
            this.spltr1 = new System.Windows.Forms.Splitter();
            this.pnTree = new System.Windows.Forms.Panel();
            this.treeMain = new System.Windows.Forms.TreeView();
            this.menTopBar.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.pnFavorites.SuspendLayout();
            this.pnDetailEditing.SuspendLayout();
            this.pnTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // menTopBar
            // 
            this.menTopBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menTopBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.ansichtToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menTopBar.Location = new System.Drawing.Point(0, 0);
            this.menTopBar.Name = "menTopBar";
            this.menTopBar.Size = new System.Drawing.Size(704, 21);
            this.menTopBar.TabIndex = 0;
            this.menTopBar.Text = "menuStrip1";
            this.menTopBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 17);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interpretToolStripMenuItem});
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            // 
            // interpretToolStripMenuItem
            // 
            this.interpretToolStripMenuItem.Name = "interpretToolStripMenuItem";
            this.interpretToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.interpretToolStripMenuItem.Text = "Interpret";
            this.interpretToolStripMenuItem.Click += new System.EventHandler(this.interpretToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 17);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 17);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 17);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.pnSearch);
            this.pnTop.Controls.Add(this.menTopBar);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.MaximumSize = new System.Drawing.Size(0, 21);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(704, 21);
            this.pnTop.TabIndex = 6;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.edSearchBar);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSearch.Location = new System.Drawing.Point(562, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(142, 21);
            this.pnSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(21, 21);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "🔎";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // edSearchBar
            // 
            this.edSearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edSearchBar.Location = new System.Drawing.Point(0, 0);
            this.edSearchBar.Name = "edSearchBar";
            this.edSearchBar.Size = new System.Drawing.Size(142, 20);
            this.edSearchBar.TabIndex = 0;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnFavorites);
            this.pnMain.Controls.Add(this.spltr2);
            this.pnMain.Controls.Add(this.pnDetailEditing);
            this.pnMain.Controls.Add(this.pnTree);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 21);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(704, 431);
            this.pnMain.TabIndex = 7;
            // 
            // pnFavorites
            // 
            this.pnFavorites.Controls.Add(this.lblFavTitle);
            this.pnFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFavorites.Location = new System.Drawing.Point(565, 0);
            this.pnFavorites.Name = "pnFavorites";
            this.pnFavorites.Size = new System.Drawing.Size(139, 431);
            this.pnFavorites.TabIndex = 4;
            // 
            // lblFavTitle
            // 
            this.lblFavTitle.AutoSize = true;
            this.lblFavTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavTitle.Location = new System.Drawing.Point(6, 3);
            this.lblFavTitle.Name = "lblFavTitle";
            this.lblFavTitle.Size = new System.Drawing.Size(84, 20);
            this.lblFavTitle.TabIndex = 0;
            this.lblFavTitle.Text = "Favoriten";
            // 
            // spltr2
            // 
            this.spltr2.Location = new System.Drawing.Point(562, 0);
            this.spltr2.Name = "spltr2";
            this.spltr2.Size = new System.Drawing.Size(3, 431);
            this.spltr2.TabIndex = 3;
            this.spltr2.TabStop = false;
            // 
            // pnDetailEditing
            // 
            this.pnDetailEditing.Controls.Add(this.spltr1);
            this.pnDetailEditing.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDetailEditing.Location = new System.Drawing.Point(200, 0);
            this.pnDetailEditing.Name = "pnDetailEditing";
            this.pnDetailEditing.Size = new System.Drawing.Size(362, 431);
            this.pnDetailEditing.TabIndex = 1;
            // 
            // spltr1
            // 
            this.spltr1.Location = new System.Drawing.Point(0, 0);
            this.spltr1.Name = "spltr1";
            this.spltr1.Size = new System.Drawing.Size(3, 431);
            this.spltr1.TabIndex = 0;
            this.spltr1.TabStop = false;
            // 
            // pnTree
            // 
            this.pnTree.Controls.Add(this.treeMain);
            this.pnTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTree.Location = new System.Drawing.Point(0, 0);
            this.pnTree.Name = "pnTree";
            this.pnTree.Size = new System.Drawing.Size(200, 431);
            this.pnTree.TabIndex = 0;
            // 
            // treeMain
            // 
            this.treeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMain.Location = new System.Drawing.Point(0, 0);
            this.treeMain.Name = "treeMain";
            this.treeMain.Size = new System.Drawing.Size(200, 431);
            this.treeMain.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 452);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTop);
            this.MainMenuStrip = this.menTopBar;
            this.Name = "MainForm";
            this.Text = "MusicControl";
            this.menTopBar.ResumeLayout(false);
            this.menTopBar.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.pnFavorites.ResumeLayout(false);
            this.pnFavorites.PerformLayout();
            this.pnDetailEditing.ResumeLayout(false);
            this.pnTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menTopBar;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox edSearchBar;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnFavorites;
        private System.Windows.Forms.Splitter spltr2;
        private System.Windows.Forms.Panel pnDetailEditing;
        private System.Windows.Forms.Splitter spltr1;
        private System.Windows.Forms.Panel pnTree;
        private System.Windows.Forms.Label lblFavTitle;
        private System.Windows.Forms.TreeView treeMain;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interpretToolStripMenuItem;
    }
}

