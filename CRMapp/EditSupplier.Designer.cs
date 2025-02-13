﻿namespace CRMapp
{
    partial class EditSupplier
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLbl = new System.Windows.Forms.Label();
            this.SearchNameTxt = new System.Windows.Forms.TextBox();
            this.OccupationTxt = new System.Windows.Forms.TextBox();
            this.OccupationLbl = new System.Windows.Forms.Label();
            this.AfmTxt = new System.Windows.Forms.TextBox();
            this.AfmLbl = new System.Windows.Forms.Label();
            this.TkTxt = new System.Windows.Forms.TextBox();
            this.TkLbl = new System.Windows.Forms.Label();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.DebitTxt = new System.Windows.Forms.TextBox();
            this.DebitLbl = new System.Windows.Forms.Label();
            this.Tax_officeTxt = new System.Windows.Forms.TextBox();
            this.Tax_officeLbl = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SearchNameListBox = new System.Windows.Forms.ListBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchAfmTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectNameCmb = new System.Windows.Forms.ComboBox();
            this.RetrieveBtn = new System.Windows.Forms.Button();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.IdLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.MaxDebitTxt = new System.Windows.Forms.TextBox();
            this.MaxDebitLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DocumentLbx = new System.Windows.Forms.ListBox();
            this.RegionTxt = new System.Windows.Forms.TextBox();
            this.RegionLbl = new System.Windows.Forms.Label();
            this.ManagerLbl = new System.Windows.Forms.Label();
            this.ManagerTxt = new System.Windows.Forms.TextBox();
            this.Phone2Txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(434, 44);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(80, 21);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Επωνυμία";
            // 
            // SearchNameTxt
            // 
            this.SearchNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchNameTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SearchNameTxt.Location = new System.Drawing.Point(96, 45);
            this.SearchNameTxt.MaxLength = 100;
            this.SearchNameTxt.Name = "SearchNameTxt";
            this.SearchNameTxt.Size = new System.Drawing.Size(250, 21);
            this.SearchNameTxt.TabIndex = 1;
            this.SearchNameTxt.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            this.SearchNameTxt.Enter += new System.EventHandler(this.SearchNameTxt_Enter);
            this.SearchNameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchNameTxt_KeyDown);
            this.SearchNameTxt.Leave += new System.EventHandler(this.SearchNameTxt_Leave);
            // 
            // OccupationTxt
            // 
            this.OccupationTxt.Enabled = false;
            this.OccupationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OccupationTxt.Location = new System.Drawing.Point(524, 76);
            this.OccupationTxt.MaxLength = 200;
            this.OccupationTxt.Multiline = true;
            this.OccupationTxt.Name = "OccupationTxt";
            this.OccupationTxt.Size = new System.Drawing.Size(250, 42);
            this.OccupationTxt.TabIndex = 8;
            // 
            // OccupationLbl
            // 
            this.OccupationLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.OccupationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OccupationLbl.Location = new System.Drawing.Point(434, 76);
            this.OccupationLbl.Name = "OccupationLbl";
            this.OccupationLbl.Size = new System.Drawing.Size(80, 21);
            this.OccupationLbl.TabIndex = 0;
            this.OccupationLbl.Text = "Επάγγελμα";
            // 
            // AfmTxt
            // 
            this.AfmTxt.Enabled = false;
            this.AfmTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfmTxt.Location = new System.Drawing.Point(524, 130);
            this.AfmTxt.MaxLength = 9;
            this.AfmTxt.Name = "AfmTxt";
            this.AfmTxt.Size = new System.Drawing.Size(70, 21);
            this.AfmTxt.TabIndex = 9;
            // 
            // AfmLbl
            // 
            this.AfmLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AfmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfmLbl.Location = new System.Drawing.Point(434, 130);
            this.AfmLbl.Name = "AfmLbl";
            this.AfmLbl.Size = new System.Drawing.Size(80, 21);
            this.AfmLbl.TabIndex = 0;
            this.AfmLbl.Text = "Α.Φ.Μ.";
            // 
            // TkTxt
            // 
            this.TkTxt.Enabled = false;
            this.TkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TkTxt.Location = new System.Drawing.Point(524, 258);
            this.TkTxt.MaxLength = 5;
            this.TkTxt.Name = "TkTxt";
            this.TkTxt.Size = new System.Drawing.Size(45, 21);
            this.TkTxt.TabIndex = 13;
            // 
            // TkLbl
            // 
            this.TkLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TkLbl.Location = new System.Drawing.Point(434, 258);
            this.TkLbl.Name = "TkLbl";
            this.TkLbl.Size = new System.Drawing.Size(80, 21);
            this.TkLbl.TabIndex = 0;
            this.TkLbl.Text = "Τ.Κ.";
            // 
            // AddressTxt
            // 
            this.AddressTxt.Enabled = false;
            this.AddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTxt.Location = new System.Drawing.Point(524, 194);
            this.AddressTxt.MaxLength = 100;
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(250, 21);
            this.AddressTxt.TabIndex = 11;
            // 
            // AddressLbl
            // 
            this.AddressLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLbl.Location = new System.Drawing.Point(434, 194);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(80, 21);
            this.AddressLbl.TabIndex = 0;
            this.AddressLbl.Text = "Διεύθυνση";
            // 
            // DebitTxt
            // 
            this.DebitTxt.Enabled = false;
            this.DebitTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebitTxt.Location = new System.Drawing.Point(524, 418);
            this.DebitTxt.MaxLength = 10;
            this.DebitTxt.Name = "DebitTxt";
            this.DebitTxt.Size = new System.Drawing.Size(91, 21);
            this.DebitTxt.TabIndex = 18;
            this.DebitTxt.TextChanged += new System.EventHandler(this.DebitTxt_TextChanged);
            // 
            // DebitLbl
            // 
            this.DebitLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DebitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebitLbl.Location = new System.Drawing.Point(434, 418);
            this.DebitLbl.Name = "DebitLbl";
            this.DebitLbl.Size = new System.Drawing.Size(80, 21);
            this.DebitLbl.TabIndex = 0;
            this.DebitLbl.Text = "Υπόλοιπο";
            // 
            // Tax_officeTxt
            // 
            this.Tax_officeTxt.Enabled = false;
            this.Tax_officeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax_officeTxt.Location = new System.Drawing.Point(524, 162);
            this.Tax_officeTxt.MaxLength = 30;
            this.Tax_officeTxt.Name = "Tax_officeTxt";
            this.Tax_officeTxt.Size = new System.Drawing.Size(250, 21);
            this.Tax_officeTxt.TabIndex = 10;
            // 
            // Tax_officeLbl
            // 
            this.Tax_officeLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Tax_officeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax_officeLbl.Location = new System.Drawing.Point(434, 162);
            this.Tax_officeLbl.Name = "Tax_officeLbl";
            this.Tax_officeLbl.Size = new System.Drawing.Size(80, 21);
            this.Tax_officeLbl.TabIndex = 0;
            this.Tax_officeLbl.Text = "Δ.Ο.Υ.";
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditBtn.Location = new System.Drawing.Point(524, 477);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(70, 38);
            this.EditBtn.TabIndex = 20;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Visible = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SearchNameListBox
            // 
            this.SearchNameListBox.FormattingEnabled = true;
            this.SearchNameListBox.Location = new System.Drawing.Point(96, 65);
            this.SearchNameListBox.Name = "SearchNameListBox";
            this.SearchNameListBox.Size = new System.Drawing.Size(250, 17);
            this.SearchNameListBox.TabIndex = 2;
            this.SearchNameListBox.Visible = false;
            this.SearchNameListBox.Click += new System.EventHandler(this.SearchNameListBox_Click);
            this.SearchNameListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchNameListBox_KeyPress);
            this.SearchNameListBox.Leave += new System.EventHandler(this.SearchNameListBox_Leave);
            // 
            // NameTxt
            // 
            this.NameTxt.Enabled = false;
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NameTxt.Location = new System.Drawing.Point(524, 44);
            this.NameTxt.MaxLength = 100;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(250, 21);
            this.NameTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Αναζήτηση Επωνυμίας";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Αναζήτηση Α.Φ.Μ.";
            // 
            // SearchAfmTxt
            // 
            this.SearchAfmTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchAfmTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchAfmTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAfmTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SearchAfmTxt.Location = new System.Drawing.Point(96, 155);
            this.SearchAfmTxt.MaxLength = 9;
            this.SearchAfmTxt.Name = "SearchAfmTxt";
            this.SearchAfmTxt.Size = new System.Drawing.Size(92, 21);
            this.SearchAfmTxt.TabIndex = 4;
            this.SearchAfmTxt.Enter += new System.EventHandler(this.SearchAfmTxt_Enter);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Επιλογή Επωνυμίας";
            // 
            // SelectNameCmb
            // 
            this.SelectNameCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectNameCmb.FormattingEnabled = true;
            this.SelectNameCmb.Location = new System.Drawing.Point(96, 100);
            this.SelectNameCmb.MaxDropDownItems = 3;
            this.SelectNameCmb.Name = "SelectNameCmb";
            this.SelectNameCmb.Size = new System.Drawing.Size(250, 21);
            this.SelectNameCmb.TabIndex = 3;
            this.SelectNameCmb.Enter += new System.EventHandler(this.SelectNameCmb_Enter);
            // 
            // RetrieveBtn
            // 
            this.RetrieveBtn.Location = new System.Drawing.Point(25, 186);
            this.RetrieveBtn.Name = "RetrieveBtn";
            this.RetrieveBtn.Size = new System.Drawing.Size(250, 33);
            this.RetrieveBtn.TabIndex = 5;
            this.RetrieveBtn.Text = "Ανάκτηση";
            this.RetrieveBtn.UseVisualStyleBackColor = true;
            this.RetrieveBtn.Click += new System.EventHandler(this.RetrieveBtn_Click);
            // 
            // IdTxt
            // 
            this.IdTxt.Enabled = false;
            this.IdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IdTxt.Location = new System.Drawing.Point(524, 12);
            this.IdTxt.MaxLength = 100;
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(70, 21);
            this.IdTxt.TabIndex = 6;
            // 
            // IdLbl
            // 
            this.IdLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.IdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLbl.Location = new System.Drawing.Point(434, 12);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(80, 21);
            this.IdLbl.TabIndex = 0;
            this.IdLbl.Text = "Κωδικός";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Lime;
            this.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveBtn.Location = new System.Drawing.Point(614, 477);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(70, 38);
            this.SaveBtn.TabIndex = 21;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Red;
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelBtn.Location = new System.Drawing.Point(704, 477);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(70, 38);
            this.CancelBtn.TabIndex = 22;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Visible = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // MaxDebitTxt
            // 
            this.MaxDebitTxt.Enabled = false;
            this.MaxDebitTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxDebitTxt.Location = new System.Drawing.Point(524, 450);
            this.MaxDebitTxt.MaxLength = 15;
            this.MaxDebitTxt.Name = "MaxDebitTxt";
            this.MaxDebitTxt.Size = new System.Drawing.Size(91, 21);
            this.MaxDebitTxt.TabIndex = 19;
            this.MaxDebitTxt.TextChanged += new System.EventHandler(this.MaxDebitTxt_TextChanged);
            // 
            // MaxDebitLbl
            // 
            this.MaxDebitLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MaxDebitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxDebitLbl.Location = new System.Drawing.Point(434, 448);
            this.MaxDebitLbl.Name = "MaxDebitLbl";
            this.MaxDebitLbl.Size = new System.Drawing.Size(80, 31);
            this.MaxDebitLbl.TabIndex = 0;
            this.MaxDebitLbl.Text = "Μέγιστο Υπόλοιπο";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RetrieveBtn);
            this.panel1.Location = new System.Drawing.Point(70, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 228);
            this.panel1.TabIndex = 0;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Enabled = false;
            this.EmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.Location = new System.Drawing.Point(524, 386);
            this.EmailTxt.MaxLength = 100;
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(250, 21);
            this.EmailTxt.TabIndex = 17;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(434, 386);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(80, 21);
            this.EmailLbl.TabIndex = 0;
            this.EmailLbl.Text = "E-mail";
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Enabled = false;
            this.PhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTxt.Location = new System.Drawing.Point(524, 322);
            this.PhoneTxt.MaxLength = 150;
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(250, 21);
            this.PhoneTxt.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(434, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Τηλέφωνο";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ποσό";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ημερομηνία  |";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Παραστατικό  |";
            // 
            // DocumentLbx
            // 
            this.DocumentLbx.FormattingEnabled = true;
            this.DocumentLbx.Location = new System.Drawing.Point(70, 307);
            this.DocumentLbx.Name = "DocumentLbx";
            this.DocumentLbx.Size = new System.Drawing.Size(302, 173);
            this.DocumentLbx.TabIndex = 26;
            this.DocumentLbx.DoubleClick += new System.EventHandler(this.DocumentLbx_DoubleClick);
            // 
            // RegionTxt
            // 
            this.RegionTxt.Enabled = false;
            this.RegionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionTxt.Location = new System.Drawing.Point(524, 226);
            this.RegionTxt.MaxLength = 50;
            this.RegionTxt.Name = "RegionTxt";
            this.RegionTxt.Size = new System.Drawing.Size(250, 21);
            this.RegionTxt.TabIndex = 12;
            // 
            // RegionLbl
            // 
            this.RegionLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.RegionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionLbl.Location = new System.Drawing.Point(434, 226);
            this.RegionLbl.Name = "RegionLbl";
            this.RegionLbl.Size = new System.Drawing.Size(80, 21);
            this.RegionLbl.TabIndex = 0;
            this.RegionLbl.Text = "Περιοχή";
            // 
            // ManagerLbl
            // 
            this.ManagerLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ManagerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerLbl.Location = new System.Drawing.Point(434, 290);
            this.ManagerLbl.Name = "ManagerLbl";
            this.ManagerLbl.Size = new System.Drawing.Size(80, 21);
            this.ManagerLbl.TabIndex = 0;
            this.ManagerLbl.Text = "Υπεύθυνος";
            // 
            // ManagerTxt
            // 
            this.ManagerTxt.Enabled = false;
            this.ManagerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerTxt.Location = new System.Drawing.Point(524, 290);
            this.ManagerTxt.MaxLength = 50;
            this.ManagerTxt.Name = "ManagerTxt";
            this.ManagerTxt.Size = new System.Drawing.Size(250, 21);
            this.ManagerTxt.TabIndex = 14;
            // 
            // Phone2Txt
            // 
            this.Phone2Txt.Enabled = false;
            this.Phone2Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone2Txt.Location = new System.Drawing.Point(524, 354);
            this.Phone2Txt.MaxLength = 150;
            this.Phone2Txt.Name = "Phone2Txt";
            this.Phone2Txt.Size = new System.Drawing.Size(250, 21);
            this.Phone2Txt.TabIndex = 16;
            // 
            // EditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Phone2Txt);
            this.Controls.Add(this.ManagerLbl);
            this.Controls.Add(this.ManagerTxt);
            this.Controls.Add(this.RegionTxt);
            this.Controls.Add(this.RegionLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DocumentLbx);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MaxDebitTxt);
            this.Controls.Add(this.MaxDebitLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.SearchNameListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.TkLbl);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.Tax_officeTxt);
            this.Controls.Add(this.Tax_officeLbl);
            this.Controls.Add(this.DebitTxt);
            this.Controls.Add(this.DebitLbl);
            this.Controls.Add(this.TkTxt);
            this.Controls.Add(this.AddressTxt);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.AfmTxt);
            this.Controls.Add(this.AfmLbl);
            this.Controls.Add(this.OccupationTxt);
            this.Controls.Add(this.OccupationLbl);
            this.Controls.Add(this.SearchNameTxt);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectNameCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchAfmTxt);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "EditSupplier";
            this.Size = new System.Drawing.Size(845, 516);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox SearchNameTxt;
        private System.Windows.Forms.TextBox OccupationTxt;
        private System.Windows.Forms.Label OccupationLbl;
        private System.Windows.Forms.TextBox AfmTxt;
        private System.Windows.Forms.Label AfmLbl;
        private System.Windows.Forms.TextBox TkTxt;
        private System.Windows.Forms.Label TkLbl;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox DebitTxt;
        private System.Windows.Forms.Label DebitLbl;
        private System.Windows.Forms.TextBox Tax_officeTxt;
        private System.Windows.Forms.Label Tax_officeLbl;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.ListBox SearchNameListBox;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchAfmTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SelectNameCmb;
        private System.Windows.Forms.Button RetrieveBtn;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox MaxDebitTxt;
        private System.Windows.Forms.Label MaxDebitLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox DocumentLbx;
        private System.Windows.Forms.TextBox RegionTxt;
        private System.Windows.Forms.Label RegionLbl;
        private System.Windows.Forms.Label ManagerLbl;
        private System.Windows.Forms.TextBox ManagerTxt;
        private System.Windows.Forms.TextBox Phone2Txt;
    }
}
