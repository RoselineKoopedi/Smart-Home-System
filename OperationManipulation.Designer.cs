namespace PresentationLayer
{
    partial class OperationManipulation
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
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOID = new System.Windows.Forms.ComboBox();
            this.DTDetectedDate = new System.Windows.Forms.DateTimePicker();
            this.DTOperationDate = new System.Windows.Forms.DateTimePicker();
            this.btnOperation = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOperType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFault = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "UPDATE Operation ";
            // 
            // cmbOID
            // 
            this.cmbOID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOID.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOID.FormattingEnabled = true;
            this.cmbOID.Location = new System.Drawing.Point(326, 99);
            this.cmbOID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOID.Name = "cmbOID";
            this.cmbOID.Size = new System.Drawing.Size(298, 23);
            this.cmbOID.TabIndex = 50;
            this.cmbOID.SelectedIndexChanged += new System.EventHandler(this.cmbOID_SelectedIndexChanged);
            // 
            // DTDetectedDate
            // 
            this.DTDetectedDate.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTDetectedDate.Location = new System.Drawing.Point(326, 364);
            this.DTDetectedDate.Margin = new System.Windows.Forms.Padding(4);
            this.DTDetectedDate.Name = "DTDetectedDate";
            this.DTDetectedDate.Size = new System.Drawing.Size(298, 25);
            this.DTDetectedDate.TabIndex = 48;
            // 
            // DTOperationDate
            // 
            this.DTOperationDate.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTOperationDate.Location = new System.Drawing.Point(326, 195);
            this.DTOperationDate.Margin = new System.Windows.Forms.Padding(4);
            this.DTOperationDate.Name = "DTOperationDate";
            this.DTOperationDate.Size = new System.Drawing.Size(298, 25);
            this.DTOperationDate.TabIndex = 49;
            // 
            // btnOperation
            // 
            this.btnOperation.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOperation.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperation.Location = new System.Drawing.Point(230, 426);
            this.btnOperation.Margin = new System.Windows.Forms.Padding(4);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(160, 28);
            this.btnOperation.TabIndex = 47;
            this.btnOperation.Text = "Update Operation";
            this.btnOperation.UseVisualStyleBackColor = false;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Operation ID";
            // 
            // txtOperType
            // 
            this.txtOperType.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperType.Location = new System.Drawing.Point(326, 142);
            this.txtOperType.Margin = new System.Windows.Forms.Padding(4);
            this.txtOperType.Name = "txtOperType";
            this.txtOperType.Size = new System.Drawing.Size(298, 25);
            this.txtOperType.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Operation Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "DetectedDate";
            // 
            // txtFault
            // 
            this.txtFault.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFault.Location = new System.Drawing.Point(326, 312);
            this.txtFault.Margin = new System.Windows.Forms.Padding(4);
            this.txtFault.Name = "txtFault";
            this.txtFault.Size = new System.Drawing.Size(298, 25);
            this.txtFault.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 316);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "FaultDetected";
            // 
            // txtResID
            // 
            this.txtResID.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResID.Location = new System.Drawing.Point(326, 253);
            this.txtResID.Margin = new System.Windows.Forms.Padding(4);
            this.txtResID.Name = "txtResID";
            this.txtResID.Size = new System.Drawing.Size(298, 25);
            this.txtResID.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Residence ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Operation Date";
            // 
            // OperationManipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(690, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbOID);
            this.Controls.Add(this.DTDetectedDate);
            this.Controls.Add(this.DTOperationDate);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOperType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFault);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "OperationManipulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperationManipulation";
            this.Load += new System.EventHandler(this.OperationManipulation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOID;
        private System.Windows.Forms.DateTimePicker DTDetectedDate;
        private System.Windows.Forms.DateTimePicker DTOperationDate;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOperType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFault;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}