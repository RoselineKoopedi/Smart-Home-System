namespace PresentationLayer
{
    partial class CallCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallCenter));
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbTC = new System.Windows.Forms.TabControl();
            this.PanelTelCall = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnHang = new System.Windows.Forms.Button();
            this.BtnInitiate = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCallReason = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.dtpCallDate = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCallID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCallRecords = new System.Windows.Forms.TabPage();
            this.btnDone = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lsbCallRecords = new System.Windows.Forms.ListBox();
            this.tbTC.SuspendLayout();
            this.PanelTelCall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tbCallRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCancel.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(880, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 37);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Done";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbTC
            // 
            this.tbTC.Controls.Add(this.PanelTelCall);
            this.tbTC.Controls.Add(this.tbCallRecords);
            this.tbTC.Location = new System.Drawing.Point(-2, 1);
            this.tbTC.Name = "tbTC";
            this.tbTC.SelectedIndex = 0;
            this.tbTC.Size = new System.Drawing.Size(1249, 582);
            this.tbTC.TabIndex = 16;
            // 
            // PanelTelCall
            // 
            this.PanelTelCall.BackColor = System.Drawing.SystemColors.Highlight;
            this.PanelTelCall.Controls.Add(this.label11);
            this.PanelTelCall.Controls.Add(this.txtSearch);
            this.PanelTelCall.Controls.Add(this.btnSearch);
            this.PanelTelCall.Controls.Add(this.dgvProducts);
            this.PanelTelCall.Controls.Add(this.btnHang);
            this.PanelTelCall.Controls.Add(this.btnCancel);
            this.PanelTelCall.Controls.Add(this.BtnInitiate);
            this.PanelTelCall.Controls.Add(this.txtSurname);
            this.PanelTelCall.Controls.Add(this.label9);
            this.PanelTelCall.Controls.Add(this.txtClientName);
            this.PanelTelCall.Controls.Add(this.label8);
            this.PanelTelCall.Controls.Add(this.txtCallReason);
            this.PanelTelCall.Controls.Add(this.label7);
            this.PanelTelCall.Controls.Add(this.label5);
            this.PanelTelCall.Controls.Add(this.label6);
            this.PanelTelCall.Controls.Add(this.lblDuration);
            this.PanelTelCall.Controls.Add(this.dtpCallDate);
            this.PanelTelCall.Controls.Add(this.txtPhoneNumber);
            this.PanelTelCall.Controls.Add(this.txtCallID);
            this.PanelTelCall.Controls.Add(this.label3);
            this.PanelTelCall.Controls.Add(this.label4);
            this.PanelTelCall.Controls.Add(this.label2);
            this.PanelTelCall.Controls.Add(this.label1);
            this.PanelTelCall.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelTelCall.Location = new System.Drawing.Point(4, 22);
            this.PanelTelCall.Name = "PanelTelCall";
            this.PanelTelCall.Padding = new System.Windows.Forms.Padding(3);
            this.PanelTelCall.Size = new System.Drawing.Size(1241, 556);
            this.PanelTelCall.TabIndex = 0;
            this.PanelTelCall.Text = "Telephone Call";
            this.PanelTelCall.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(513, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(252, 15);
            this.label11.TabIndex = 38;
            this.label11.Text = "Products related to the Client";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(190, 83);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 37;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSearch.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(422, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(516, 83);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(371, 160);
            this.dgvProducts.TabIndex = 35;
            // 
            // btnHang
            // 
            this.btnHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHang.BackgroundImage")));
            this.btnHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHang.Location = new System.Drawing.Point(317, 396);
            this.btnHang.Name = "btnHang";
            this.btnHang.Size = new System.Drawing.Size(123, 75);
            this.btnHang.TabIndex = 34;
            this.btnHang.UseVisualStyleBackColor = true;
            this.btnHang.Click += new System.EventHandler(this.btnHang_Click_1);
            // 
            // BtnInitiate
            // 
            this.BtnInitiate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnInitiate.BackgroundImage")));
            this.BtnInitiate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInitiate.Location = new System.Drawing.Point(43, 396);
            this.BtnInitiate.Name = "BtnInitiate";
            this.BtnInitiate.Size = new System.Drawing.Size(116, 80);
            this.BtnInitiate.TabIndex = 33;
            this.BtnInitiate.UseVisualStyleBackColor = true;
            this.BtnInitiate.Click += new System.EventHandler(this.BtnInitiate_Click_1);
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(669, 260);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 20);
            this.txtSurname.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(519, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "Client Surname";
            // 
            // txtClientName
            // 
            this.txtClientName.Enabled = false;
            this.txtClientName.Location = new System.Drawing.Point(669, 307);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(200, 20);
            this.txtClientName.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(522, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Client Name";
            // 
            // txtCallReason
            // 
            this.txtCallReason.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCallReason.Location = new System.Drawing.Point(190, 228);
            this.txtCallReason.Name = "txtCallReason";
            this.txtCallReason.Size = new System.Drawing.Size(200, 23);
            this.txtCallReason.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Call Reason";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Initiate a telephone call";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Call Duration";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(187, 278);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(25, 15);
            this.lblDuration.TabIndex = 24;
            this.lblDuration.Text = "00";
            // 
            // dtpCallDate
            // 
            this.dtpCallDate.Enabled = false;
            this.dtpCallDate.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCallDate.Location = new System.Drawing.Point(190, 174);
            this.dtpCallDate.Name = "dtpCallDate";
            this.dtpCallDate.Size = new System.Drawing.Size(200, 22);
            this.dtpCallDate.TabIndex = 23;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(669, 353);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 25);
            this.txtPhoneNumber.TabIndex = 21;
            // 
            // txtCallID
            // 
            this.txtCallID.Enabled = false;
            this.txtCallID.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCallID.Location = new System.Drawing.Point(190, 122);
            this.txtCallID.Name = "txtCallID";
            this.txtCallID.Size = new System.Drawing.Size(200, 25);
            this.txtCallID.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Call Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Client ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Call ID";
            // 
            // tbCallRecords
            // 
            this.tbCallRecords.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbCallRecords.Controls.Add(this.btnDone);
            this.tbCallRecords.Controls.Add(this.label10);
            this.tbCallRecords.Controls.Add(this.lsbCallRecords);
            this.tbCallRecords.Location = new System.Drawing.Point(4, 22);
            this.tbCallRecords.Name = "tbCallRecords";
            this.tbCallRecords.Padding = new System.Windows.Forms.Padding(3);
            this.tbCallRecords.Size = new System.Drawing.Size(1241, 556);
            this.tbCallRecords.TabIndex = 1;
            this.tbCallRecords.Text = "Call Records";
            this.tbCallRecords.Click += new System.EventHandler(this.tbCallRecords_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDone.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(372, 453);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(112, 23);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(331, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Call Records";
            // 
            // lsbCallRecords
            // 
            this.lsbCallRecords.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbCallRecords.FormattingEnabled = true;
            this.lsbCallRecords.ItemHeight = 12;
            this.lsbCallRecords.Location = new System.Drawing.Point(187, 65);
            this.lsbCallRecords.Name = "lsbCallRecords";
            this.lsbCallRecords.Size = new System.Drawing.Size(467, 364);
            this.lsbCallRecords.TabIndex = 3;
            // 
            // CallCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(961, 546);
            this.ControlBox = false;
            this.Controls.Add(this.tbTC);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CallCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Center";
            this.Load += new System.EventHandler(this.CallCenter_Load);
            this.tbTC.ResumeLayout(false);
            this.PanelTelCall.ResumeLayout(false);
            this.PanelTelCall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tbCallRecords.ResumeLayout(false);
            this.tbCallRecords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tbTC;
        private System.Windows.Forms.TabPage tbCallRecords;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lsbCallRecords;
        private System.Windows.Forms.TabPage PanelTelCall;
        private System.Windows.Forms.Button btnHang;
        private System.Windows.Forms.Button BtnInitiate;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCallReason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.DateTimePicker dtpCallDate;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCallID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
    }
}