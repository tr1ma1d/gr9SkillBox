namespace GibddGroupNine
{
    partial class Information
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbSerial = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbPersonName = new System.Windows.Forms.Label();
            this.lbPassport = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.lbSerial = new System.Windows.Forms.Label();
            this.lbPassNumber = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbLicence = new System.Windows.Forms.TextBox();
            this.lbLic = new System.Windows.Forms.Label();
            this.lbLicNum = new System.Windows.Forms.Label();
            this.tbLicNum = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(368, 23);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(292, 27);
            this.tbFullName.TabIndex = 0;
            // 
            // tbSerial
            // 
            this.tbSerial.Location = new System.Drawing.Point(368, 118);
            this.tbSerial.Name = "tbSerial";
            this.tbSerial.Size = new System.Drawing.Size(86, 27);
            this.tbSerial.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(368, 69);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(292, 27);
            this.tbAddress.TabIndex = 3;
            // 
            // lbPersonName
            // 
            this.lbPersonName.AutoSize = true;
            this.lbPersonName.Location = new System.Drawing.Point(259, 29);
            this.lbPersonName.Name = "lbPersonName";
            this.lbPersonName.Size = new System.Drawing.Size(78, 21);
            this.lbPersonName.TabIndex = 15;
            this.lbPersonName.Text = "Full name";
            // 
            // lbPassport
            // 
            this.lbPassport.AutoSize = true;
            this.lbPassport.Location = new System.Drawing.Point(259, 124);
            this.lbPassport.Name = "lbPassport";
            this.lbPassport.Size = new System.Drawing.Size(71, 21);
            this.lbPassport.TabIndex = 17;
            this.lbPassport.Text = "Passport";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(259, 75);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(66, 21);
            this.lbAddress.TabIndex = 18;
            this.lbAddress.Text = "Address";
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(36, 53);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(128, 128);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 19;
            this.pbPhoto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Photography";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(470, 118);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(190, 27);
            this.tbNum.TabIndex = 21;
            // 
            // lbSerial
            // 
            this.lbSerial.AutoSize = true;
            this.lbSerial.Location = new System.Drawing.Point(364, 148);
            this.lbSerial.Name = "lbSerial";
            this.lbSerial.Size = new System.Drawing.Size(48, 21);
            this.lbSerial.TabIndex = 22;
            this.lbSerial.Text = "Serial";
            // 
            // lbPassNumber
            // 
            this.lbPassNumber.AutoSize = true;
            this.lbPassNumber.Location = new System.Drawing.Point(466, 148);
            this.lbPassNumber.Name = "lbPassNumber";
            this.lbPassNumber.Size = new System.Drawing.Size(67, 21);
            this.lbPassNumber.TabIndex = 23;
            this.lbPassNumber.Text = "Number";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(45, 280);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(72, 21);
            this.lbCategory.TabIndex = 25;
            this.lbCategory.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(184, 274);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(54, 27);
            this.cbCategory.TabIndex = 26;
            // 
            // tbLicence
            // 
            this.tbLicence.Location = new System.Drawing.Point(184, 325);
            this.tbLicence.Name = "tbLicence";
            this.tbLicence.Size = new System.Drawing.Size(228, 27);
            this.tbLicence.TabIndex = 27;
            // 
            // lbLic
            // 
            this.lbLic.AutoSize = true;
            this.lbLic.Location = new System.Drawing.Point(45, 331);
            this.lbLic.Name = "lbLic";
            this.lbLic.Size = new System.Drawing.Size(95, 21);
            this.lbLic.TabIndex = 28;
            this.lbLic.Text = "Licence date";
            // 
            // lbLicNum
            // 
            this.lbLicNum.AutoSize = true;
            this.lbLicNum.Location = new System.Drawing.Point(45, 380);
            this.lbLicNum.Name = "lbLicNum";
            this.lbLicNum.Size = new System.Drawing.Size(119, 21);
            this.lbLicNum.TabIndex = 29;
            this.lbLicNum.Text = "Licence number";
            // 
            // tbLicNum
            // 
            this.tbLicNum.Location = new System.Drawing.Point(184, 374);
            this.tbLicNum.Name = "tbLicNum";
            this.tbLicNum.Size = new System.Drawing.Size(228, 27);
            this.tbLicNum.TabIndex = 30;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(263, 425);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(134, 39);
            this.btRegister.TabIndex = 31;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(678, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(677, 432);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1367, 477);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.tbLicNum);
            this.Controls.Add(this.lbLicNum);
            this.Controls.Add(this.lbLic);
            this.Controls.Add(this.tbLicence);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbPassNumber);
            this.Controls.Add(this.lbSerial);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbPassport);
            this.Controls.Add(this.lbPersonName);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbSerial);
            this.Controls.Add(this.tbFullName);
            this.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbSerial;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPassport;
        private System.Windows.Forms.Label lbPersonName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label lbPassNumber;
        private System.Windows.Forms.Label lbSerial;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbLic;
        private System.Windows.Forms.TextBox tbLicence;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.TextBox tbLicNum;
        private System.Windows.Forms.Label lbLicNum;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}