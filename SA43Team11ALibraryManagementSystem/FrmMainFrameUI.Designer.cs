namespace SA43Team11ALibraryManagementSystem
{
    partial class FrmMainFrameUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainFrameUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookcopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksBorrowedByYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksBorrowedByCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowBooksToolStripMenuItem,
            this.returnBooksToolStripMenuItem,
            this.customerSearchToolStripMenuItem,
            this.bookSearchToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // borrowBooksToolStripMenuItem
            // 
            this.borrowBooksToolStripMenuItem.Name = "borrowBooksToolStripMenuItem";
            this.borrowBooksToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.borrowBooksToolStripMenuItem.Text = "Borrow Books";
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.returnBooksToolStripMenuItem.Text = "Return Books";
            // 
            // customerSearchToolStripMenuItem
            // 
            this.customerSearchToolStripMenuItem.Name = "customerSearchToolStripMenuItem";
            this.customerSearchToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.customerSearchToolStripMenuItem.Text = "Customer Search";
            // 
            // bookSearchToolStripMenuItem
            // 
            this.bookSearchToolStripMenuItem.Name = "bookSearchToolStripMenuItem";
            this.bookSearchToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.bookSearchToolStripMenuItem.Text = "Book Search";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.bookcopyToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.locationCodeToolStripMenuItem,
            this.userAccountToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.memberToolStripMenuItem.Text = "Member";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // bookcopyToolStripMenuItem
            // 
            this.bookcopyToolStripMenuItem.Name = "bookcopyToolStripMenuItem";
            this.bookcopyToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.bookcopyToolStripMenuItem.Text = "Bookcopy";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // locationCodeToolStripMenuItem
            // 
            this.locationCodeToolStripMenuItem.Name = "locationCodeToolStripMenuItem";
            this.locationCodeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.locationCodeToolStripMenuItem.Text = "Location Code";
            // 
            // userAccountToolStripMenuItem
            // 
            this.userAccountToolStripMenuItem.Name = "userAccountToolStripMenuItem";
            this.userAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.userAccountToolStripMenuItem.Text = "User Account";
            this.userAccountToolStripMenuItem.Click += new System.EventHandler(this.userAccountToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowerReceiptToolStripMenuItem,
            this.listOfBooksToolStripMenuItem,
            this.booksBorrowedByYearToolStripMenuItem,
            this.booksBorrowedByCategoryToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // borrowerReceiptToolStripMenuItem
            // 
            this.borrowerReceiptToolStripMenuItem.Name = "borrowerReceiptToolStripMenuItem";
            this.borrowerReceiptToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.borrowerReceiptToolStripMenuItem.Text = "Borrower Receipt";
            // 
            // listOfBooksToolStripMenuItem
            // 
            this.listOfBooksToolStripMenuItem.Name = "listOfBooksToolStripMenuItem";
            this.listOfBooksToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.listOfBooksToolStripMenuItem.Text = "List of Books";
            // 
            // booksBorrowedByYearToolStripMenuItem
            // 
            this.booksBorrowedByYearToolStripMenuItem.Name = "booksBorrowedByYearToolStripMenuItem";
            this.booksBorrowedByYearToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.booksBorrowedByYearToolStripMenuItem.Text = "Books Borrowed by Year";
            // 
            // booksBorrowedByCategoryToolStripMenuItem
            // 
            this.booksBorrowedByCategoryToolStripMenuItem.Name = "booksBorrowedByCategoryToolStripMenuItem";
            this.booksBorrowedByCategoryToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.booksBorrowedByCategoryToolStripMenuItem.Text = "Books Borrowed by Category";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(169, 20);
            this.toolStripStatusLabel1.Text = "Verification in Progress...";
            // 
            // FrmMainFrameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMainFrameUI";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.FrmMainFrameUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookcopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksBorrowedByYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksBorrowedByCategoryToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}