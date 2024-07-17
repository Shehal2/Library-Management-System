namespace Library_System_Theekshana
{
    partial class frmBR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBR));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMID = new System.Windows.Forms.TextBox();
            this.lblMID = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.lblBID = new System.Windows.Forms.Label();
            this.lblBName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRefCode = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnGenRef = new System.Windows.Forms.Button();
            this.lblRDate = new System.Windows.Forms.Label();
            this.lblBDate = new System.Windows.Forms.Label();
            this.dtpRetDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBorDate = new System.Windows.Forms.DateTimePicker();
            this.txtRefCode1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnRetBook = new System.Windows.Forms.Button();
            this.btnFCheck = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblRDate2 = new System.Windows.Forms.Label();
            this.lblRefCode2 = new System.Windows.Forms.Label();
            this.dtpRetDate2 = new System.Windows.Forms.DateTimePicker();
            this.txtRefCode2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtFPDay2 = new System.Windows.Forms.TextBox();
            this.btnFineperday = new System.Windows.Forms.Button();
            this.txtTFine = new System.Windows.Forms.TextBox();
            this.txtFPDay = new System.Windows.Forms.TextBox();
            this.txtLDays = new System.Windows.Forms.TextBox();
            this.txtTDays = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Library = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet1 = new Library_System_Theekshana.LibraryDataSet1();
            this.bookTableAdapter = new Library_System_Theekshana.LibraryDataSet1TableAdapters.BookTableAdapter();
            this.memberTableAdapter = new Library_System_Theekshana.LibraryDataSet1TableAdapters.MemberTableAdapter();
            this.bRTableAdapter = new Library_System_Theekshana.LibraryDataSet1TableAdapters.BRTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Library)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtMID);
            this.groupBox1.Controls.Add(this.lblMID);
            this.groupBox1.Controls.Add(this.lblMName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(680, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Details";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(289, 142);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(358, 33);
            this.txtName.TabIndex = 3;
            // 
            // txtMID
            // 
            this.txtMID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMID.Location = new System.Drawing.Point(292, 78);
            this.txtMID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMID.MaxLength = 6;
            this.txtMID.Name = "txtMID";
            this.txtMID.Size = new System.Drawing.Size(232, 33);
            this.txtMID.TabIndex = 2;
            this.txtMID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMID_KeyPress);
            // 
            // lblMID
            // 
            this.lblMID.AutoSize = true;
            this.lblMID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMID.Location = new System.Drawing.Point(33, 78);
            this.lblMID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMID.Name = "lblMID";
            this.lblMID.Size = new System.Drawing.Size(231, 33);
            this.lblMID.TabIndex = 0;
            this.lblMID.Text = "Member ID      :";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMName.Location = new System.Drawing.Point(24, 141);
            this.lblMName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(237, 33);
            this.lblMName.TabIndex = 1;
            this.lblMName.Text = "Member Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aqua;
            this.groupBox2.Controls.Add(this.txtBName);
            this.groupBox2.Controls.Add(this.txtBID);
            this.groupBox2.Controls.Add(this.lblBID);
            this.groupBox2.Controls.Add(this.lblBName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(741, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(680, 231);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtBName
            // 
            this.txtBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBName.Location = new System.Drawing.Point(269, 139);
            this.txtBName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(377, 33);
            this.txtBName.TabIndex = 5;
            // 
            // txtBID
            // 
            this.txtBID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBID.Location = new System.Drawing.Point(269, 75);
            this.txtBID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBID.MaxLength = 10;
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(227, 33);
            this.txtBID.TabIndex = 4;
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBID.Location = new System.Drawing.Point(26, 75);
            this.lblBID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(188, 33);
            this.lblBID.TabIndex = 2;
            this.lblBID.Text = "Book ID      :";
            // 
            // lblBName
            // 
            this.lblBName.AutoSize = true;
            this.lblBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBName.Location = new System.Drawing.Point(17, 135);
            this.lblBName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBName.Name = "lblBName";
            this.lblBName.Size = new System.Drawing.Size(194, 33);
            this.lblBName.TabIndex = 3;
            this.lblBName.Text = "Book Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox3.Controls.Add(this.lblRefCode);
            this.groupBox3.Controls.Add(this.btnIssue);
            this.groupBox3.Controls.Add(this.btnGenRef);
            this.groupBox3.Controls.Add(this.lblRDate);
            this.groupBox3.Controls.Add(this.lblBDate);
            this.groupBox3.Controls.Add(this.dtpRetDate);
            this.groupBox3.Controls.Add(this.dtpBorDate);
            this.groupBox3.Controls.Add(this.txtRefCode1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(101, 273);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1220, 218);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Book Borrowing Details";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblRefCode
            // 
            this.lblRefCode.AutoSize = true;
            this.lblRefCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefCode.Location = new System.Drawing.Point(678, 43);
            this.lblRefCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefCode.Name = "lblRefCode";
            this.lblRefCode.Size = new System.Drawing.Size(181, 29);
            this.lblRefCode.TabIndex = 7;
            this.lblRefCode.Text = "Ref.Code          :";
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIssue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIssue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIssue.Location = new System.Drawing.Point(986, 126);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(150, 46);
            this.btnIssue.TabIndex = 6;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.UseVisualStyleBackColor = false;
            // 
            // btnGenRef
            // 
            this.btnGenRef.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGenRef.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGenRef.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenRef.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenRef.Location = new System.Drawing.Point(672, 108);
            this.btnGenRef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenRef.Name = "btnGenRef";
            this.btnGenRef.Size = new System.Drawing.Size(206, 81);
            this.btnGenRef.TabIndex = 5;
            this.btnGenRef.Text = "Generate Ref Code";
            this.btnGenRef.UseVisualStyleBackColor = false;
            // 
            // lblRDate
            // 
            this.lblRDate.AutoSize = true;
            this.lblRDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRDate.Location = new System.Drawing.Point(32, 141);
            this.lblRDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRDate.Name = "lblRDate";
            this.lblRDate.Size = new System.Drawing.Size(182, 29);
            this.lblRDate.TabIndex = 4;
            this.lblRDate.Text = "Return Date      :";
            // 
            // lblBDate
            // 
            this.lblBDate.AutoSize = true;
            this.lblBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDate.Location = new System.Drawing.Point(24, 55);
            this.lblBDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBDate.Name = "lblBDate";
            this.lblBDate.Size = new System.Drawing.Size(192, 29);
            this.lblBDate.TabIndex = 3;
            this.lblBDate.Text = "Borrowing Date :";
            // 
            // dtpRetDate
            // 
            this.dtpRetDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRetDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRetDate.Location = new System.Drawing.Point(222, 141);
            this.dtpRetDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpRetDate.Name = "dtpRetDate";
            this.dtpRetDate.Size = new System.Drawing.Size(361, 30);
            this.dtpRetDate.TabIndex = 2;
            // 
            // dtpBorDate
            // 
            this.dtpBorDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBorDate.Location = new System.Drawing.Point(218, 58);
            this.dtpBorDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpBorDate.Name = "dtpBorDate";
            this.dtpBorDate.Size = new System.Drawing.Size(361, 30);
            this.dtpBorDate.TabIndex = 1;
            // 
            // txtRefCode1
            // 
            this.txtRefCode1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefCode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefCode1.Location = new System.Drawing.Point(909, 42);
            this.txtRefCode1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRefCode1.Multiline = true;
            this.txtRefCode1.Name = "txtRefCode1";
            this.txtRefCode1.Size = new System.Drawing.Size(251, 37);
            this.txtRefCode1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Controls.Add(this.btnRetBook);
            this.groupBox4.Controls.Add(this.btnFCheck);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.lblRDate2);
            this.groupBox4.Controls.Add(this.lblRefCode2);
            this.groupBox4.Controls.Add(this.dtpRetDate2);
            this.groupBox4.Controls.Add(this.txtRefCode2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(24, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(657, 599);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Book Returning Details";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Library_System_Theekshana.Properties.Resources.Screenshot_2022_09_13_194534;
            this.pictureBox3.Location = new System.Drawing.Point(125, 48);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(400, 175);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // btnRetBook
            // 
            this.btnRetBook.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRetBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRetBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetBook.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRetBook.Location = new System.Drawing.Point(359, 471);
            this.btnRetBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetBook.Name = "btnRetBook";
            this.btnRetBook.Size = new System.Drawing.Size(238, 71);
            this.btnRetBook.TabIndex = 8;
            this.btnRetBook.Text = "Return Book";
            this.btnRetBook.UseVisualStyleBackColor = false;
            // 
            // btnFCheck
            // 
            this.btnFCheck.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFCheck.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFCheck.Location = new System.Drawing.Point(66, 471);
            this.btnFCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFCheck.Name = "btnFCheck";
            this.btnFCheck.Size = new System.Drawing.Size(238, 71);
            this.btnFCheck.TabIndex = 7;
            this.btnFCheck.Text = "Fine Details";
            this.btnFCheck.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lime;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(228, 311);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(208, 60);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblRDate2
            // 
            this.lblRDate2.AutoSize = true;
            this.lblRDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRDate2.Location = new System.Drawing.Point(32, 392);
            this.lblRDate2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRDate2.Name = "lblRDate2";
            this.lblRDate2.Size = new System.Drawing.Size(234, 33);
            this.lblRDate2.TabIndex = 5;
            this.lblRDate2.Text = "Returned Date :";
            // 
            // lblRefCode2
            // 
            this.lblRefCode2.AutoSize = true;
            this.lblRefCode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefCode2.Location = new System.Drawing.Point(36, 249);
            this.lblRefCode2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefCode2.Name = "lblRefCode2";
            this.lblRefCode2.Size = new System.Drawing.Size(235, 33);
            this.lblRefCode2.TabIndex = 4;
            this.lblRefCode2.Text = "Ref.Code         :";
            // 
            // dtpRetDate2
            // 
            this.dtpRetDate2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRetDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRetDate2.Location = new System.Drawing.Point(280, 395);
            this.dtpRetDate2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpRetDate2.Name = "dtpRetDate2";
            this.dtpRetDate2.Size = new System.Drawing.Size(352, 30);
            this.dtpRetDate2.TabIndex = 3;
            // 
            // txtRefCode2
            // 
            this.txtRefCode2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefCode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefCode2.Location = new System.Drawing.Point(279, 254);
            this.txtRefCode2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRefCode2.Multiline = true;
            this.txtRefCode2.Name = "txtRefCode2";
            this.txtRefCode2.Size = new System.Drawing.Size(258, 37);
            this.txtRefCode2.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox5.Controls.Add(this.txtFPDay2);
            this.groupBox5.Controls.Add(this.btnFineperday);
            this.groupBox5.Controls.Add(this.txtTFine);
            this.groupBox5.Controls.Add(this.txtFPDay);
            this.groupBox5.Controls.Add(this.txtLDays);
            this.groupBox5.Controls.Add(this.txtTDays);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(747, 74);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(631, 495);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fine Details";
            // 
            // txtFPDay2
            // 
            this.txtFPDay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFPDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFPDay2.Location = new System.Drawing.Point(447, 251);
            this.txtFPDay2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFPDay2.Name = "txtFPDay2";
            this.txtFPDay2.Size = new System.Drawing.Size(111, 35);
            this.txtFPDay2.TabIndex = 11;
            // 
            // btnFineperday
            // 
            this.btnFineperday.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFineperday.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnFineperday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFineperday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFineperday.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFineperday.Location = new System.Drawing.Point(212, 401);
            this.btnFineperday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFineperday.Name = "btnFineperday";
            this.btnFineperday.Size = new System.Drawing.Size(208, 61);
            this.btnFineperday.TabIndex = 10;
            this.btnFineperday.Text = "ADD";
            this.btnFineperday.UseVisualStyleBackColor = false;
            this.btnFineperday.Click += new System.EventHandler(this.btnFineperday_Click);
            // 
            // txtTFine
            // 
            this.txtTFine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTFine.Location = new System.Drawing.Point(316, 328);
            this.txtTFine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTFine.Name = "txtTFine";
            this.txtTFine.Size = new System.Drawing.Size(244, 35);
            this.txtTFine.TabIndex = 9;
            // 
            // txtFPDay
            // 
            this.txtFPDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFPDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFPDay.Location = new System.Drawing.Point(316, 251);
            this.txtFPDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFPDay.Name = "txtFPDay";
            this.txtFPDay.ReadOnly = true;
            this.txtFPDay.Size = new System.Drawing.Size(111, 35);
            this.txtFPDay.TabIndex = 8;
            this.txtFPDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLDays
            // 
            this.txtLDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLDays.Location = new System.Drawing.Point(316, 171);
            this.txtLDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLDays.Name = "txtLDays";
            this.txtLDays.Size = new System.Drawing.Size(244, 35);
            this.txtLDays.TabIndex = 7;
            // 
            // txtTDays
            // 
            this.txtTDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDays.Location = new System.Drawing.Point(316, 94);
            this.txtTDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTDays.Name = "txtTDays";
            this.txtTDays.Size = new System.Drawing.Size(244, 35);
            this.txtTDays.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 249);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 33);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fine Per Day  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 328);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 33);
            this.label10.TabIndex = 5;
            this.label10.Text = "Total Fine      :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 33);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total Days      :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 169);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 33);
            this.label8.TabIndex = 3;
            this.label8.Text = "Late Days       :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 36);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1464, 644);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1450, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book Borrow";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1456, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Book Return";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Library
            // 
            this.Library.DataMember = "BR";
            this.Library.DataSource = this.libraryDataSet1;
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "LibraryDataSet1";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // bRTableAdapter
            // 
            this.bRTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1466, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "Member Details";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "Book Details";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(626, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Borrow and Return";
            // 
            // frmBR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(1466, 751);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBR";
            this.Text = "Borrow and Return details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBR_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Library)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMID;
        private System.Windows.Forms.Label lblMID;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Label lblBID;
        private System.Windows.Forms.Label lblBName;
        private System.Windows.Forms.TextBox txtRefCode1;
        private System.Windows.Forms.TextBox txtRefCode2;
        private System.Windows.Forms.TextBox txtTFine;
        private System.Windows.Forms.TextBox txtFPDay;
        private System.Windows.Forms.TextBox txtLDays;
        private System.Windows.Forms.TextBox txtTDays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpRetDate;
        private System.Windows.Forms.DateTimePicker dtpBorDate;
        private System.Windows.Forms.DateTimePicker dtpRetDate2;
        private System.Windows.Forms.Label lblRefCode;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnGenRef;
        private System.Windows.Forms.Label lblRDate;
        private System.Windows.Forms.Label lblBDate;
        private System.Windows.Forms.Button btnRetBook;
        private System.Windows.Forms.Button btnFCheck;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblRDate2;
        private System.Windows.Forms.Label lblRefCode2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnFineperday;
        private System.Windows.Forms.TextBox txtFPDay2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource Library;
        private LibraryDataSet1 libraryDataSet1;
        private LibraryDataSet1TableAdapters.BookTableAdapter bookTableAdapter;
        private LibraryDataSet1TableAdapters.MemberTableAdapter memberTableAdapter;
        private LibraryDataSet1TableAdapters.BRTableAdapter bRTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label1;
    }
}