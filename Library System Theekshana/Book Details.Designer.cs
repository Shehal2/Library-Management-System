namespace Library_System_Theekshana
{
    partial class frmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook));
            this.lblDName = new System.Windows.Forms.Label();
            this.lblDdate = new System.Windows.Forms.Label();
            this.lblBFrom = new System.Windows.Forms.Label();
            this.lblBDate = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnFIND = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCLs = new System.Windows.Forms.Button();
            this.dtpDoDate = new System.Windows.Forms.DateTimePicker();
            this.txtDoName = new System.Windows.Forms.TextBox();
            this.txtBoName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBookAdd = new System.Windows.Forms.TabPage();
            this.lblBID = new System.Windows.Forms.Label();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.lblBName = new System.Windows.Forms.Label();
            this.cmbCate = new System.Windows.Forms.ComboBox();
            this.cmbLang = new System.Windows.Forms.ComboBox();
            this.txtAuName = new System.Windows.Forms.TextBox();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISB = new System.Windows.Forms.Label();
            this.lblAName = new System.Windows.Forms.Label();
            this.lblLan = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.tabDonate = new System.Windows.Forms.TabPage();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Book = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet6 = new Library_System_Theekshana.LibraryDataSet6();
            this.label1 = new System.Windows.Forms.Label();
            this.bookTableAdapter = new Library_System_Theekshana.LibraryDataSet6TableAdapters.BookTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabBookAdd.SuspendLayout();
            this.tabDonate.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDName
            // 
            this.lblDName.AutoSize = true;
            this.lblDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDName.Location = new System.Drawing.Point(39, 24);
            this.lblDName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDName.Name = "lblDName";
            this.lblDName.Size = new System.Drawing.Size(199, 29);
            this.lblDName.TabIndex = 6;
            this.lblDName.Text = "Donator\'s Name";
            // 
            // lblDdate
            // 
            this.lblDdate.AutoSize = true;
            this.lblDdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDdate.Location = new System.Drawing.Point(44, 90);
            this.lblDdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDdate.Name = "lblDdate";
            this.lblDdate.Size = new System.Drawing.Size(165, 29);
            this.lblDdate.TabIndex = 7;
            this.lblDdate.Text = "DonatedDate";
            // 
            // lblBFrom
            // 
            this.lblBFrom.AutoSize = true;
            this.lblBFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBFrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBFrom.Location = new System.Drawing.Point(44, 161);
            this.lblBFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBFrom.Name = "lblBFrom";
            this.lblBFrom.Size = new System.Drawing.Size(149, 29);
            this.lblBFrom.TabIndex = 8;
            this.lblBFrom.Text = "Book Name";
            // 
            // lblBDate
            // 
            this.lblBDate.AutoSize = true;
            this.lblBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBDate.Location = new System.Drawing.Point(46, 229);
            this.lblBDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBDate.Name = "lblBDate";
            this.lblBDate.Size = new System.Drawing.Size(164, 29);
            this.lblBDate.TabIndex = 9;
            this.lblBDate.Text = "Author Name";
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Blue;
            this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnADD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Location = new System.Drawing.Point(678, 82);
            this.btnADD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(150, 46);
            this.btnADD.TabIndex = 10;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnFIND
            // 
            this.btnFIND.BackColor = System.Drawing.Color.Blue;
            this.btnFIND.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnFIND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFIND.ForeColor = System.Drawing.Color.White;
            this.btnFIND.Location = new System.Drawing.Point(678, 140);
            this.btnFIND.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFIND.Name = "btnFIND";
            this.btnFIND.Size = new System.Drawing.Size(150, 46);
            this.btnFIND.TabIndex = 11;
            this.btnFIND.Text = "FIND";
            this.btnFIND.UseVisualStyleBackColor = false;
            this.btnFIND.Click += new System.EventHandler(this.btnFIND_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Blue;
            this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(866, 82);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(150, 46);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "UPDATE";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Blue;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnDel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(866, 141);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(150, 46);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCLs
            // 
            this.btnCLs.BackColor = System.Drawing.Color.Blue;
            this.btnCLs.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCLs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLs.ForeColor = System.Drawing.Color.White;
            this.btnCLs.Location = new System.Drawing.Point(866, 201);
            this.btnCLs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCLs.Name = "btnCLs";
            this.btnCLs.Size = new System.Drawing.Size(150, 46);
            this.btnCLs.TabIndex = 14;
            this.btnCLs.Text = "CLEAR";
            this.btnCLs.UseVisualStyleBackColor = false;
            this.btnCLs.Click += new System.EventHandler(this.btnCLs_Click);
            // 
            // dtpDoDate
            // 
            this.dtpDoDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDoDate.Location = new System.Drawing.Point(254, 94);
            this.dtpDoDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDoDate.Name = "dtpDoDate";
            this.dtpDoDate.Size = new System.Drawing.Size(298, 26);
            this.dtpDoDate.TabIndex = 15;
            // 
            // txtDoName
            // 
            this.txtDoName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoName.Location = new System.Drawing.Point(255, 26);
            this.txtDoName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDoName.Multiline = true;
            this.txtDoName.Name = "txtDoName";
            this.txtDoName.Size = new System.Drawing.Size(306, 30);
            this.txtDoName.TabIndex = 23;
            // 
            // txtBoName
            // 
            this.txtBoName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoName.Location = new System.Drawing.Point(252, 163);
            this.txtBoName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoName.Multiline = true;
            this.txtBoName.Name = "txtBoName";
            this.txtBoName.Size = new System.Drawing.Size(299, 30);
            this.txtBoName.TabIndex = 24;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBookAdd);
            this.tabControl1.Controls.Add(this.tabDonate);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(28, 49);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 451);
            this.tabControl1.TabIndex = 26;
            // 
            // tabBookAdd
            // 
            this.tabBookAdd.Controls.Add(this.lblBID);
            this.tabBookAdd.Controls.Add(this.txtBID);
            this.tabBookAdd.Controls.Add(this.lblBName);
            this.tabBookAdd.Controls.Add(this.cmbCate);
            this.tabBookAdd.Controls.Add(this.cmbLang);
            this.tabBookAdd.Controls.Add(this.txtAuName);
            this.tabBookAdd.Controls.Add(this.txtBName);
            this.tabBookAdd.Controls.Add(this.txtISBN);
            this.tabBookAdd.Controls.Add(this.lblISB);
            this.tabBookAdd.Controls.Add(this.lblAName);
            this.tabBookAdd.Controls.Add(this.lblLan);
            this.tabBookAdd.Controls.Add(this.lblCat);
            this.tabBookAdd.Location = new System.Drawing.Point(4, 29);
            this.tabBookAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabBookAdd.Name = "tabBookAdd";
            this.tabBookAdd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabBookAdd.Size = new System.Drawing.Size(587, 418);
            this.tabBookAdd.TabIndex = 0;
            this.tabBookAdd.Text = "Book Add";
            this.tabBookAdd.UseVisualStyleBackColor = true;
            this.tabBookAdd.Click += new System.EventHandler(this.tabBookAdd_Click);
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBID.Location = new System.Drawing.Point(33, 29);
            this.lblBID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(105, 29);
            this.lblBID.TabIndex = 23;
            this.lblBID.Text = "Book ID";
            // 
            // txtBID
            // 
            this.txtBID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBID.Location = new System.Drawing.Point(225, 31);
            this.txtBID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBID.MaxLength = 10;
            this.txtBID.Multiline = true;
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(172, 30);
            this.txtBID.TabIndex = 31;
            this.txtBID.TextChanged += new System.EventHandler(this.txtBID_TextChanged);
            // 
            // lblBName
            // 
            this.lblBName.AutoSize = true;
            this.lblBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBName.Location = new System.Drawing.Point(30, 89);
            this.lblBName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBName.Name = "lblBName";
            this.lblBName.Size = new System.Drawing.Size(149, 29);
            this.lblBName.TabIndex = 24;
            this.lblBName.Text = "Book Name";
            // 
            // cmbCate
            // 
            this.cmbCate.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCate.FormattingEnabled = true;
            this.cmbCate.Items.AddRange(new object[] {
            "Kids",
            "Novels",
            "Short Story",
            "Translations",
            "Educational",
            "Others"});
            this.cmbCate.Location = new System.Drawing.Point(228, 342);
            this.cmbCate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCate.Name = "cmbCate";
            this.cmbCate.Size = new System.Drawing.Size(170, 28);
            this.cmbCate.TabIndex = 29;
            this.cmbCate.SelectedIndexChanged += new System.EventHandler(this.cmbCate_SelectedIndexChanged);
            // 
            // cmbLang
            // 
            this.cmbLang.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLang.FormattingEnabled = true;
            this.cmbLang.Items.AddRange(new object[] {
            "SINHALA",
            "ENGLISH",
            "TAMIL",
            "Other"});
            this.cmbLang.Location = new System.Drawing.Point(227, 280);
            this.cmbLang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLang.Name = "cmbLang";
            this.cmbLang.Size = new System.Drawing.Size(170, 28);
            this.cmbLang.TabIndex = 30;
            // 
            // txtAuName
            // 
            this.txtAuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuName.Location = new System.Drawing.Point(227, 214);
            this.txtAuName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAuName.Multiline = true;
            this.txtAuName.Name = "txtAuName";
            this.txtAuName.Size = new System.Drawing.Size(299, 30);
            this.txtAuName.TabIndex = 34;
            // 
            // txtBName
            // 
            this.txtBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBName.Location = new System.Drawing.Point(223, 92);
            this.txtBName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBName.Multiline = true;
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(299, 30);
            this.txtBName.TabIndex = 32;
            // 
            // txtISBN
            // 
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(229, 150);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtISBN.Multiline = true;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(172, 30);
            this.txtISBN.TabIndex = 33;
            // 
            // lblISB
            // 
            this.lblISB.AutoSize = true;
            this.lblISB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblISB.Location = new System.Drawing.Point(31, 149);
            this.lblISB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISB.Name = "lblISB";
            this.lblISB.Size = new System.Drawing.Size(114, 29);
            this.lblISB.TabIndex = 25;
            this.lblISB.Text = "ISBN No";
            // 
            // lblAName
            // 
            this.lblAName.AutoSize = true;
            this.lblAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAName.Location = new System.Drawing.Point(30, 213);
            this.lblAName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAName.Name = "lblAName";
            this.lblAName.Size = new System.Drawing.Size(164, 29);
            this.lblAName.TabIndex = 26;
            this.lblAName.Text = "Author Name";
            // 
            // lblLan
            // 
            this.lblLan.AutoSize = true;
            this.lblLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLan.Location = new System.Drawing.Point(32, 275);
            this.lblLan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLan.Name = "lblLan";
            this.lblLan.Size = new System.Drawing.Size(128, 29);
            this.lblLan.TabIndex = 27;
            this.lblLan.Text = "Language";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCat.Location = new System.Drawing.Point(30, 342);
            this.lblCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(185, 29);
            this.lblCat.TabIndex = 28;
            this.lblCat.Text = "Book Category";
            // 
            // tabDonate
            // 
            this.tabDonate.Controls.Add(this.txtAName);
            this.tabDonate.Controls.Add(this.txtDoName);
            this.tabDonate.Controls.Add(this.txtBoName);
            this.tabDonate.Controls.Add(this.lblDName);
            this.tabDonate.Controls.Add(this.lblDdate);
            this.tabDonate.Controls.Add(this.lblBFrom);
            this.tabDonate.Controls.Add(this.dtpDoDate);
            this.tabDonate.Controls.Add(this.lblBDate);
            this.tabDonate.Location = new System.Drawing.Point(4, 29);
            this.tabDonate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDonate.Name = "tabDonate";
            this.tabDonate.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDonate.Size = new System.Drawing.Size(587, 418);
            this.tabDonate.TabIndex = 1;
            this.tabDonate.Text = "Donate Book";
            this.tabDonate.UseVisualStyleBackColor = true;
            this.tabDonate.Click += new System.EventHandler(this.tabDonate_Click);
            // 
            // txtAName
            // 
            this.txtAName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAName.Location = new System.Drawing.Point(252, 231);
            this.txtAName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAName.Multiline = true;
            this.txtAName.Name = "txtAName";
            this.txtAName.Size = new System.Drawing.Size(299, 30);
            this.txtAName.TabIndex = 25;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1078, 27);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "Member details";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Book
            // 
            this.Book.DataMember = "Book";
            this.Book.DataSource = this.libraryDataSet6;
            // 
            // libraryDataSet6
            // 
            this.libraryDataSet6.DataSetName = "LibraryDataSet6";
            this.libraryDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "book Details";
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(678, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 29;
            this.button1.Text = "Cancle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_System_Theekshana.Properties.Resources._1162647;
            this.pictureBox1.Location = new System.Drawing.Point(733, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Member Details";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "Borrow Return Details";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(587, 418);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Report view";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.auNameDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.doNameDataGridViewTextBoxColumn,
            this.doDateDataGridViewTextBoxColumn,
            this.boNameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.Book;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(581, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auNameDataGridViewTextBoxColumn
            // 
            this.auNameDataGridViewTextBoxColumn.DataPropertyName = "AuName";
            this.auNameDataGridViewTextBoxColumn.HeaderText = "AuName";
            this.auNameDataGridViewTextBoxColumn.Name = "auNameDataGridViewTextBoxColumn";
            this.auNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            this.languageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doNameDataGridViewTextBoxColumn
            // 
            this.doNameDataGridViewTextBoxColumn.DataPropertyName = "DoName";
            this.doNameDataGridViewTextBoxColumn.HeaderText = "DoName";
            this.doNameDataGridViewTextBoxColumn.Name = "doNameDataGridViewTextBoxColumn";
            this.doNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doDateDataGridViewTextBoxColumn
            // 
            this.doDateDataGridViewTextBoxColumn.DataPropertyName = "DoDate";
            this.doDateDataGridViewTextBoxColumn.HeaderText = "DoDate";
            this.doDateDataGridViewTextBoxColumn.Name = "doDateDataGridViewTextBoxColumn";
            this.doDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boNameDataGridViewTextBoxColumn
            // 
            this.boNameDataGridViewTextBoxColumn.DataPropertyName = "BName";
            this.boNameDataGridViewTextBoxColumn.HeaderText = "DonateBookName";
            this.boNameDataGridViewTextBoxColumn.Name = "boNameDataGridViewTextBoxColumn";
            this.boNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            this.authorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(1078, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCLs);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnFIND);
            this.Controls.Add(this.btnADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Book Details";
            this.Load += new System.EventHandler(this.frmBookDetails_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBookAdd.ResumeLayout(false);
            this.tabBookAdd.PerformLayout();
            this.tabDonate.ResumeLayout(false);
            this.tabDonate.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDName;
        private System.Windows.Forms.Label lblDdate;
        private System.Windows.Forms.Label lblBFrom;
        private System.Windows.Forms.Label lblBDate;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnFIND;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCLs;
        private System.Windows.Forms.DateTimePicker dtpDoDate;
        private System.Windows.Forms.TextBox txtDoName;
        private System.Windows.Forms.TextBox txtBoName;
        private System.Windows.Forms.BindingSource Book;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBookAdd;
        private System.Windows.Forms.TabPage tabDonate;
        private System.Windows.Forms.Label lblBID;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Label lblBName;
        private System.Windows.Forms.ComboBox cmbCate;
        private System.Windows.Forms.ComboBox cmbLang;
        private System.Windows.Forms.TextBox txtAuName;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISB;
        private System.Windows.Forms.Label lblAName;
        private System.Windows.Forms.Label lblLan;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAName;
        private LibraryDataSet6 libraryDataSet6;
        private LibraryDataSet6TableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
    }
}