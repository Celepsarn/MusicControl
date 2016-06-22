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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("MusicControl");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menTopBar = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interpretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.edSearchBar = new System.Windows.Forms.TextBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pnTree = new System.Windows.Forms.Panel();
            this.treeMain = new System.Windows.Forms.TreeView();
            this.pnDetailEditing = new System.Windows.Forms.Panel();
            this.pnDetailEditingAlbum = new System.Windows.Forms.Panel();
            this.btnSaveAlbum = new System.Windows.Forms.Button();
            this.edDetailEditingAlbumGenre = new System.Windows.Forms.TextBox();
            this.edDetailEditingAlbumYear = new System.Windows.Forms.TextBox();
            this.edDetailEditingAlbumInterpret = new System.Windows.Forms.TextBox();
            this.edDetailEditingAlbumName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDetailEditingAlbumGenre = new System.Windows.Forms.Label();
            this.lblDetailEditingAlbumReleaseYear = new System.Windows.Forms.Label();
            this.lblDetailEditingAlbumInterpret = new System.Windows.Forms.Label();
            this.lblDetailEditingAlbumName = new System.Windows.Forms.Label();
            this.pnDetailEditingInterpret = new System.Windows.Forms.Panel();
            this.edDetailEditingInterpretNoOfAlbums = new System.Windows.Forms.TextBox();
            this.lblDetailEditingInterpretNoOfAlbums = new System.Windows.Forms.Label();
            this.edDetailEditingInterpretLand = new System.Windows.Forms.TextBox();
            this.edDetailEditingInterpretFoundationYear = new System.Windows.Forms.TextBox();
            this.edDetailEditingInterpretName = new System.Windows.Forms.TextBox();
            this.lblDetailEditingInterpretLand = new System.Windows.Forms.Label();
            this.lblDetailEditingInterpretFoundationYear = new System.Windows.Forms.Label();
            this.lblDetailEditingInterpretName = new System.Windows.Forms.Label();
            this.pnFavorites = new System.Windows.Forms.Panel();
            this.lblFavTitle = new System.Windows.Forms.Label();
            this.btnSaveInterpret = new System.Windows.Forms.Button();
            this.alsFavoritMarkierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favList = new System.Windows.Forms.ListBox();
            this.listSongs = new System.Windows.Forms.ListBox();
            this.menTopBar.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnTree.SuspendLayout();
            this.pnDetailEditing.SuspendLayout();
            this.pnDetailEditingAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnDetailEditingInterpret.SuspendLayout();
            this.pnFavorites.SuspendLayout();
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
            this.menTopBar.Size = new System.Drawing.Size(789, 21);
            this.menTopBar.TabIndex = 0;
            this.menTopBar.Text = "menuStrip1";
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
            this.interpretToolStripMenuItem,
            this.albumToolStripMenuItem,
            this.genreToolStripMenuItem});
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
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.albumToolStripMenuItem.Text = "Album";
            this.albumToolStripMenuItem.Click += new System.EventHandler(this.albumToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.löschenToolStripMenuItem,
            this.alsFavoritMarkierenToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 17);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
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
            this.pnTop.Size = new System.Drawing.Size(789, 21);
            this.pnTop.TabIndex = 6;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.edSearchBar);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSearch.Location = new System.Drawing.Point(647, 0);
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
            this.pnMain.Controls.Add(this.splitContainer);
            this.pnMain.Controls.Add(this.pnFavorites);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 21);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(789, 337);
            this.pnMain.TabIndex = 7;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pnTree);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnDetailEditing);
            this.splitContainer.Size = new System.Drawing.Size(647, 337);
            this.splitContainer.SplitterDistance = 137;
            this.splitContainer.TabIndex = 5;
            // 
            // pnTree
            // 
            this.pnTree.Controls.Add(this.treeMain);
            this.pnTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTree.Location = new System.Drawing.Point(0, 0);
            this.pnTree.MinimumSize = new System.Drawing.Size(103, 0);
            this.pnTree.Name = "pnTree";
            this.pnTree.Size = new System.Drawing.Size(137, 337);
            this.pnTree.TabIndex = 0;
            // 
            // treeMain
            // 
            this.treeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMain.Location = new System.Drawing.Point(0, 0);
            this.treeMain.Name = "treeMain";
            treeNode2.Name = "ndRoot";
            treeNode2.Text = "MusicControl";
            this.treeMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeMain.Size = new System.Drawing.Size(137, 337);
            this.treeMain.TabIndex = 0;
            this.treeMain.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeMain_NodeMouseClick);
            // 
            // pnDetailEditing
            // 
            this.pnDetailEditing.BackColor = System.Drawing.SystemColors.Control;
            this.pnDetailEditing.Controls.Add(this.pnDetailEditingAlbum);
            this.pnDetailEditing.Controls.Add(this.pnDetailEditingInterpret);
            this.pnDetailEditing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDetailEditing.Location = new System.Drawing.Point(0, 0);
            this.pnDetailEditing.Name = "pnDetailEditing";
            this.pnDetailEditing.Size = new System.Drawing.Size(506, 337);
            this.pnDetailEditing.TabIndex = 1;
            // 
            // pnDetailEditingAlbum
            // 
            this.pnDetailEditingAlbum.BackColor = System.Drawing.SystemColors.Control;
            this.pnDetailEditingAlbum.Controls.Add(this.listSongs);
            this.pnDetailEditingAlbum.Controls.Add(this.btnSaveAlbum);
            this.pnDetailEditingAlbum.Controls.Add(this.edDetailEditingAlbumGenre);
            this.pnDetailEditingAlbum.Controls.Add(this.edDetailEditingAlbumYear);
            this.pnDetailEditingAlbum.Controls.Add(this.edDetailEditingAlbumInterpret);
            this.pnDetailEditingAlbum.Controls.Add(this.edDetailEditingAlbumName);
            this.pnDetailEditingAlbum.Controls.Add(this.pictureBox1);
            this.pnDetailEditingAlbum.Controls.Add(this.lblDetailEditingAlbumGenre);
            this.pnDetailEditingAlbum.Controls.Add(this.lblDetailEditingAlbumReleaseYear);
            this.pnDetailEditingAlbum.Controls.Add(this.lblDetailEditingAlbumInterpret);
            this.pnDetailEditingAlbum.Controls.Add(this.lblDetailEditingAlbumName);
            this.pnDetailEditingAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDetailEditingAlbum.Location = new System.Drawing.Point(0, 0);
            this.pnDetailEditingAlbum.Name = "pnDetailEditingAlbum";
            this.pnDetailEditingAlbum.Size = new System.Drawing.Size(506, 337);
            this.pnDetailEditingAlbum.TabIndex = 2;
            // 
            // btnSaveAlbum
            // 
            this.btnSaveAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAlbum.Location = new System.Drawing.Point(425, 308);
            this.btnSaveAlbum.Name = "btnSaveAlbum";
            this.btnSaveAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAlbum.TabIndex = 9;
            this.btnSaveAlbum.Text = "Speichern";
            this.btnSaveAlbum.UseVisualStyleBackColor = true;
            this.btnSaveAlbum.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // edDetailEditingAlbumGenre
            // 
            this.edDetailEditingAlbumGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edDetailEditingAlbumGenre.Location = new System.Drawing.Point(156, 76);
            this.edDetailEditingAlbumGenre.Name = "edDetailEditingAlbumGenre";
            this.edDetailEditingAlbumGenre.Size = new System.Drawing.Size(344, 20);
            this.edDetailEditingAlbumGenre.TabIndex = 8;
            // 
            // edDetailEditingAlbumYear
            // 
            this.edDetailEditingAlbumYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edDetailEditingAlbumYear.Location = new System.Drawing.Point(156, 52);
            this.edDetailEditingAlbumYear.Name = "edDetailEditingAlbumYear";
            this.edDetailEditingAlbumYear.Size = new System.Drawing.Size(344, 20);
            this.edDetailEditingAlbumYear.TabIndex = 7;
            // 
            // edDetailEditingAlbumInterpret
            // 
            this.edDetailEditingAlbumInterpret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edDetailEditingAlbumInterpret.Location = new System.Drawing.Point(156, 28);
            this.edDetailEditingAlbumInterpret.Name = "edDetailEditingAlbumInterpret";
            this.edDetailEditingAlbumInterpret.ReadOnly = true;
            this.edDetailEditingAlbumInterpret.Size = new System.Drawing.Size(344, 20);
            this.edDetailEditingAlbumInterpret.TabIndex = 6;
            // 
            // edDetailEditingAlbumName
            // 
            this.edDetailEditingAlbumName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edDetailEditingAlbumName.Location = new System.Drawing.Point(156, 4);
            this.edDetailEditingAlbumName.Name = "edDetailEditingAlbumName";
            this.edDetailEditingAlbumName.Size = new System.Drawing.Size(344, 20);
            this.edDetailEditingAlbumName.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(300, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // lblDetailEditingAlbumGenre
            // 
            this.lblDetailEditingAlbumGenre.AutoSize = true;
            this.lblDetailEditingAlbumGenre.Location = new System.Drawing.Point(4, 80);
            this.lblDetailEditingAlbumGenre.Name = "lblDetailEditingAlbumGenre";
            this.lblDetailEditingAlbumGenre.Size = new System.Drawing.Size(39, 13);
            this.lblDetailEditingAlbumGenre.TabIndex = 3;
            this.lblDetailEditingAlbumGenre.Text = "Genre:";
            // 
            // lblDetailEditingAlbumReleaseYear
            // 
            this.lblDetailEditingAlbumReleaseYear.AutoSize = true;
            this.lblDetailEditingAlbumReleaseYear.Location = new System.Drawing.Point(4, 56);
            this.lblDetailEditingAlbumReleaseYear.Name = "lblDetailEditingAlbumReleaseYear";
            this.lblDetailEditingAlbumReleaseYear.Size = new System.Drawing.Size(30, 13);
            this.lblDetailEditingAlbumReleaseYear.TabIndex = 2;
            this.lblDetailEditingAlbumReleaseYear.Text = "Jahr:";
            // 
            // lblDetailEditingAlbumInterpret
            // 
            this.lblDetailEditingAlbumInterpret.AutoSize = true;
            this.lblDetailEditingAlbumInterpret.Location = new System.Drawing.Point(4, 32);
            this.lblDetailEditingAlbumInterpret.Name = "lblDetailEditingAlbumInterpret";
            this.lblDetailEditingAlbumInterpret.Size = new System.Drawing.Size(49, 13);
            this.lblDetailEditingAlbumInterpret.TabIndex = 1;
            this.lblDetailEditingAlbumInterpret.Text = "Interpret:";
            // 
            // lblDetailEditingAlbumName
            // 
            this.lblDetailEditingAlbumName.AutoSize = true;
            this.lblDetailEditingAlbumName.Location = new System.Drawing.Point(4, 8);
            this.lblDetailEditingAlbumName.Name = "lblDetailEditingAlbumName";
            this.lblDetailEditingAlbumName.Size = new System.Drawing.Size(38, 13);
            this.lblDetailEditingAlbumName.TabIndex = 0;
            this.lblDetailEditingAlbumName.Text = "Name:";
            // 
            // pnDetailEditingInterpret
            // 
            this.pnDetailEditingInterpret.BackColor = System.Drawing.SystemColors.Control;
            this.pnDetailEditingInterpret.Controls.Add(this.btnSaveInterpret);
            this.pnDetailEditingInterpret.Controls.Add(this.edDetailEditingInterpretNoOfAlbums);
            this.pnDetailEditingInterpret.Controls.Add(this.lblDetailEditingInterpretNoOfAlbums);
            this.pnDetailEditingInterpret.Controls.Add(this.edDetailEditingInterpretLand);
            this.pnDetailEditingInterpret.Controls.Add(this.edDetailEditingInterpretFoundationYear);
            this.pnDetailEditingInterpret.Controls.Add(this.edDetailEditingInterpretName);
            this.pnDetailEditingInterpret.Controls.Add(this.lblDetailEditingInterpretLand);
            this.pnDetailEditingInterpret.Controls.Add(this.lblDetailEditingInterpretFoundationYear);
            this.pnDetailEditingInterpret.Controls.Add(this.lblDetailEditingInterpretName);
            this.pnDetailEditingInterpret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDetailEditingInterpret.Location = new System.Drawing.Point(0, 0);
            this.pnDetailEditingInterpret.Name = "pnDetailEditingInterpret";
            this.pnDetailEditingInterpret.Size = new System.Drawing.Size(506, 337);
            this.pnDetailEditingInterpret.TabIndex = 1;
            // 
            // edDetailEditingInterpretNoOfAlbums
            // 
            this.edDetailEditingInterpretNoOfAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edDetailEditingInterpretNoOfAlbums.Location = new System.Drawing.Point(156, 76);
            this.edDetailEditingInterpretNoOfAlbums.Name = "edDetailEditingInterpretNoOfAlbums";
            this.edDetailEditingInterpretNoOfAlbums.Size = new System.Drawing.Size(344, 20);
            this.edDetailEditingInterpretNoOfAlbums.TabIndex = 7;
            // 
            // lblDetailEditingInterpretNoOfAlbums
            // 
            this.lblDetailEditingInterpretNoOfAlbums.AutoSize = true;
            this.lblDetailEditingInterpretNoOfAlbums.Location = new System.Drawing.Point(4, 80);
            this.lblDetailEditingInterpretNoOfAlbums.Name = "lblDetailEditingInterpretNoOfAlbums";
            this.lblDetailEditingInterpretNoOfAlbums.Size = new System.Drawing.Size(72, 13);
            this.lblDetailEditingInterpretNoOfAlbums.TabIndex = 6;
            this.lblDetailEditingInterpretNoOfAlbums.Text = "Anzahl Alben:";
            // 
            // edDetailEditingInterpretLand
            // 
            this.edDetailEditingInterpretLand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edDetailEditingInterpretLand.Location = new System.Drawing.Point(156, 52);
            this.edDetailEditingInterpretLand.Name = "edDetailEditingInterpretLand";
            this.edDetailEditingInterpretLand.Size = new System.Drawing.Size(344, 20);
            this.edDetailEditingInterpretLand.TabIndex = 5;
            // 
            // edDetailEditingInterpretFoundationYear
            // 
            this.edDetailEditingInterpretFoundationYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edDetailEditingInterpretFoundationYear.Location = new System.Drawing.Point(156, 28);
            this.edDetailEditingInterpretFoundationYear.Name = "edDetailEditingInterpretFoundationYear";
            this.edDetailEditingInterpretFoundationYear.Size = new System.Drawing.Size(344, 20);
            this.edDetailEditingInterpretFoundationYear.TabIndex = 4;
            // 
            // edDetailEditingInterpretName
            // 
            this.edDetailEditingInterpretName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edDetailEditingInterpretName.Location = new System.Drawing.Point(156, 4);
            this.edDetailEditingInterpretName.Name = "edDetailEditingInterpretName";
            this.edDetailEditingInterpretName.Size = new System.Drawing.Size(344, 20);
            this.edDetailEditingInterpretName.TabIndex = 3;
            // 
            // lblDetailEditingInterpretLand
            // 
            this.lblDetailEditingInterpretLand.AutoSize = true;
            this.lblDetailEditingInterpretLand.Location = new System.Drawing.Point(4, 56);
            this.lblDetailEditingInterpretLand.Name = "lblDetailEditingInterpretLand";
            this.lblDetailEditingInterpretLand.Size = new System.Drawing.Size(34, 13);
            this.lblDetailEditingInterpretLand.TabIndex = 2;
            this.lblDetailEditingInterpretLand.Text = "Land:";
            // 
            // lblDetailEditingInterpretFoundationYear
            // 
            this.lblDetailEditingInterpretFoundationYear.AutoSize = true;
            this.lblDetailEditingInterpretFoundationYear.Location = new System.Drawing.Point(4, 32);
            this.lblDetailEditingInterpretFoundationYear.Name = "lblDetailEditingInterpretFoundationYear";
            this.lblDetailEditingInterpretFoundationYear.Size = new System.Drawing.Size(79, 13);
            this.lblDetailEditingInterpretFoundationYear.TabIndex = 1;
            this.lblDetailEditingInterpretFoundationYear.Text = "Gründungsjahr:";
            // 
            // lblDetailEditingInterpretName
            // 
            this.lblDetailEditingInterpretName.AutoSize = true;
            this.lblDetailEditingInterpretName.Location = new System.Drawing.Point(4, 8);
            this.lblDetailEditingInterpretName.Name = "lblDetailEditingInterpretName";
            this.lblDetailEditingInterpretName.Size = new System.Drawing.Size(38, 13);
            this.lblDetailEditingInterpretName.TabIndex = 0;
            this.lblDetailEditingInterpretName.Text = "Name:";
            // 
            // pnFavorites
            // 
            this.pnFavorites.BackColor = System.Drawing.SystemColors.Window;
            this.pnFavorites.Controls.Add(this.favList);
            this.pnFavorites.Controls.Add(this.lblFavTitle);
            this.pnFavorites.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnFavorites.Location = new System.Drawing.Point(647, 0);
            this.pnFavorites.MinimumSize = new System.Drawing.Size(116, 0);
            this.pnFavorites.Name = "pnFavorites";
            this.pnFavorites.Size = new System.Drawing.Size(142, 337);
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
            // btnSaveInterpret
            // 
            this.btnSaveInterpret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveInterpret.Location = new System.Drawing.Point(425, 308);
            this.btnSaveInterpret.Name = "btnSaveInterpret";
            this.btnSaveInterpret.Size = new System.Drawing.Size(75, 23);
            this.btnSaveInterpret.TabIndex = 9;
            this.btnSaveInterpret.Text = "Speichern";
            this.btnSaveInterpret.UseVisualStyleBackColor = true;
            this.btnSaveInterpret.Click += new System.EventHandler(this.button1_Click);
            // 
            // alsFavoritMarkierenToolStripMenuItem
            // 
            this.alsFavoritMarkierenToolStripMenuItem.Name = "alsFavoritMarkierenToolStripMenuItem";
            this.alsFavoritMarkierenToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.alsFavoritMarkierenToolStripMenuItem.Text = "Als Favorit markieren";
            this.alsFavoritMarkierenToolStripMenuItem.Click += new System.EventHandler(this.alsFavoritMarkierenToolStripMenuItem_Click);
            // 
            // favList
            // 
            this.favList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favList.FormattingEnabled = true;
            this.favList.Location = new System.Drawing.Point(6, 28);
            this.favList.Name = "favList";
            this.favList.Size = new System.Drawing.Size(133, 303);
            this.favList.TabIndex = 1;
            // 
            // listSongs
            // 
            this.listSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSongs.FormattingEnabled = true;
            this.listSongs.Location = new System.Drawing.Point(7, 102);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(287, 199);
            this.listSongs.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 358);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTop);
            this.MainMenuStrip = this.menTopBar;
            this.MinimumSize = new System.Drawing.Size(805, 397);
            this.Name = "MainForm";
            this.Text = "MusicControl";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menTopBar.ResumeLayout(false);
            this.menTopBar.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnTree.ResumeLayout(false);
            this.pnDetailEditing.ResumeLayout(false);
            this.pnDetailEditingAlbum.ResumeLayout(false);
            this.pnDetailEditingAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnDetailEditingInterpret.ResumeLayout(false);
            this.pnDetailEditingInterpret.PerformLayout();
            this.pnFavorites.ResumeLayout(false);
            this.pnFavorites.PerformLayout();
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
        private System.Windows.Forms.Panel pnDetailEditing;
        private System.Windows.Forms.Panel pnTree;
        private System.Windows.Forms.Label lblFavTitle;
        private System.Windows.Forms.TreeView treeMain;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interpretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.Panel pnDetailEditingInterpret;
        private System.Windows.Forms.TextBox edDetailEditingInterpretLand;
        private System.Windows.Forms.TextBox edDetailEditingInterpretFoundationYear;
        private System.Windows.Forms.TextBox edDetailEditingInterpretName;
        private System.Windows.Forms.Label lblDetailEditingInterpretLand;
        private System.Windows.Forms.Label lblDetailEditingInterpretFoundationYear;
        private System.Windows.Forms.Label lblDetailEditingInterpretName;
        private System.Windows.Forms.TextBox edDetailEditingInterpretNoOfAlbums;
        private System.Windows.Forms.Label lblDetailEditingInterpretNoOfAlbums;
        private System.Windows.Forms.Panel pnDetailEditingAlbum;
        private System.Windows.Forms.TextBox edDetailEditingAlbumGenre;
        private System.Windows.Forms.TextBox edDetailEditingAlbumYear;
        private System.Windows.Forms.TextBox edDetailEditingAlbumInterpret;
        private System.Windows.Forms.TextBox edDetailEditingAlbumName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDetailEditingAlbumGenre;
        private System.Windows.Forms.Label lblDetailEditingAlbumReleaseYear;
        private System.Windows.Forms.Label lblDetailEditingAlbumInterpret;
        private System.Windows.Forms.Label lblDetailEditingAlbumName;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnSaveAlbum;
        private System.Windows.Forms.Button btnSaveInterpret;
        private System.Windows.Forms.ToolStripMenuItem alsFavoritMarkierenToolStripMenuItem;
        private System.Windows.Forms.ListBox favList;
        private System.Windows.Forms.ListBox listSongs;
    }
}

