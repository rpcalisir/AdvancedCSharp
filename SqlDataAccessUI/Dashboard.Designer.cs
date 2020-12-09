namespace SqlDataAccessUI
{
    partial class Dashboard
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
            this.lstBoxPeopleFound = new System.Windows.Forms.ListBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstNameInsert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailAddressInsert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastNameInsert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumberInsert = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxPeopleFound
            // 
            this.lstBoxPeopleFound.FormattingEnabled = true;
            this.lstBoxPeopleFound.ItemHeight = 25;
            this.lstBoxPeopleFound.Location = new System.Drawing.Point(12, 137);
            this.lstBoxPeopleFound.Name = "lstBoxPeopleFound";
            this.lstBoxPeopleFound.Size = new System.Drawing.Size(406, 404);
            this.lstBoxPeopleFound.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(133, 16);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(285, 31);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 22);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(115, 25);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(289, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 37);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // txtFirstNameInsert
            // 
            this.txtFirstNameInsert.Location = new System.Drawing.Point(789, 22);
            this.txtFirstNameInsert.Name = "txtFirstNameInsert";
            this.txtFirstNameInsert.Size = new System.Drawing.Size(285, 31);
            this.txtFirstNameInsert.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email Address";
            // 
            // txtEmailAddressInsert
            // 
            this.txtEmailAddressInsert.Location = new System.Drawing.Point(789, 146);
            this.txtEmailAddressInsert.Name = "txtEmailAddressInsert";
            this.txtEmailAddressInsert.Size = new System.Drawing.Size(285, 31);
            this.txtEmailAddressInsert.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // txtLastNameInsert
            // 
            this.txtLastNameInsert.Location = new System.Drawing.Point(789, 82);
            this.txtLastNameInsert.Name = "txtLastNameInsert";
            this.txtLastNameInsert.Size = new System.Drawing.Size(285, 31);
            this.txtLastNameInsert.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone Number";
            // 
            // txtPhoneNumberInsert
            // 
            this.txtPhoneNumberInsert.Location = new System.Drawing.Point(789, 217);
            this.txtPhoneNumberInsert.Name = "txtPhoneNumberInsert";
            this.txtPhoneNumberInsert.Size = new System.Drawing.Size(285, 31);
            this.txtPhoneNumberInsert.TabIndex = 10;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(945, 279);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(129, 37);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 555);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhoneNumberInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastNameInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailAddressInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstNameInsert);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lstBoxPeopleFound);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "Sql Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxPeopleFound;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstNameInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailAddressInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastNameInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumberInsert;
        private System.Windows.Forms.Button btnInsert;
    }
}

