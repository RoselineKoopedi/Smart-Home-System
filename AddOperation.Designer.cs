namespace PresentationLayer
{
    partial class AddOperation
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
            this.txtOperationID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFault = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOperation = new System.Windows.Forms.Button();
            this.DTOperationDate = new System.Windows.Forms.DateTimePicker();
            this.DTDetectedDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRID = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOperationID
            // 
            this.txtOperationID.Enabled = false;
            this.txtOperationID.Location = new System.Drawing.Point(330, 80);
            this.txtOperationID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtOperationID.Name = "txtOperationID";
            this.txtOperationID.Size = new System.Drawing.Size(331, 27);
            this.txtOperationID.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Operation ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Operation Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 395);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "DetectedDate";
            // 
            // txtFault
            // 
            this.txtFault.Enabled = false;
            this.txtFault.Location = new System.Drawing.Point(330, 344);
            this.txtFault.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFault.Name = "txtFault";
            this.txtFault.Size = new System.Drawing.Size(331, 27);
            this.txtFault.TabIndex = 16;
            this.txtFault.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFault_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "FaultDetected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 285);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Residence ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Operation Date";
            // 
            // btnOperation
            // 
            this.btnOperation.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOperation.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperation.Location = new System.Drawing.Point(241, 458);
            this.btnOperation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(207, 55);
            this.btnOperation.TabIndex = 20;
            this.btnOperation.Text = "Add Operation";
            this.btnOperation.UseVisualStyleBackColor = false;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // DTOperationDate
            // 
            this.DTOperationDate.Location = new System.Drawing.Point(330, 180);
            this.DTOperationDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DTOperationDate.Name = "DTOperationDate";
            this.DTOperationDate.Size = new System.Drawing.Size(331, 27);
            this.DTOperationDate.TabIndex = 21;
            // 
            // DTDetectedDate
            // 
            this.DTDetectedDate.Enabled = false;
            this.DTDetectedDate.Location = new System.Drawing.Point(330, 395);
            this.DTDetectedDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DTDetectedDate.Name = "DTDetectedDate";
            this.DTDetectedDate.Size = new System.Drawing.Size(331, 27);
            this.DTDetectedDate.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(238, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Add NEW Operation";
            // 
            // cmbRID
            // 
            this.cmbRID.FormattingEnabled = true;
            this.cmbRID.Location = new System.Drawing.Point(330, 286);
            this.cmbRID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbRID.Name = "cmbRID";
            this.cmbRID.Size = new System.Drawing.Size(331, 24);
            this.cmbRID.TabIndex = 41;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Installation",
            "Correction",
            "Maintenance"});
            this.cmbType.Location = new System.Drawing.Point(330, 130);
            this.cmbType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(331, 24);
            this.cmbType.TabIndex = 42;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBack.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(5, 511);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 26);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExit.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(654, 511);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 26);
            this.btnExit.TabIndex = 43;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Operation Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(330, 231);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(331, 27);
            this.txtStatus.TabIndex = 45;
            // 
            // AddOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(732, 546);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbRID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTDetectedDate);
            this.Controls.Add(this.DTOperationDate);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.txtOperationID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFault);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technical Operations";
            this.Load += new System.EventHandler(this.AddOperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOperationID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFault;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.DateTimePicker DTOperationDate;
        private System.Windows.Forms.DateTimePicker DTDetectedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRID;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatus;
    }
}