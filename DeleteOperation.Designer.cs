namespace PresentationLayer
{
    partial class DeleteOperation
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
            this.cmbOID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOperType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteOperation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbOID
            // 
            this.cmbOID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOID.FormattingEnabled = true;
            this.cmbOID.Location = new System.Drawing.Point(343, 120);
            this.cmbOID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbOID.Name = "cmbOID";
            this.cmbOID.Size = new System.Drawing.Size(227, 23);
            this.cmbOID.TabIndex = 54;
            this.cmbOID.SelectedIndexChanged += new System.EventHandler(this.cmbOID_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 52;
            this.label8.Text = "Operation ID";
            // 
            // txtOperType
            // 
            this.txtOperType.Location = new System.Drawing.Point(343, 169);
            this.txtOperType.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtOperType.Name = "txtOperType";
            this.txtOperType.Size = new System.Drawing.Size(227, 25);
            this.txtOperType.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "Operation Type";
            // 
            // btnDeleteOperation
            // 
            this.btnDeleteOperation.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteOperation.Location = new System.Drawing.Point(226, 226);
            this.btnDeleteOperation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteOperation.Name = "btnDeleteOperation";
            this.btnDeleteOperation.Size = new System.Drawing.Size(209, 27);
            this.btnDeleteOperation.TabIndex = 55;
            this.btnDeleteOperation.Text = "DELETE OPERATION";
            this.btnDeleteOperation.UseVisualStyleBackColor = false;
            this.btnDeleteOperation.Click += new System.EventHandler(this.btnDeleteOperation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "DELETE OPERATION";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDone.Location = new System.Drawing.Point(13, 266);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 57;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExit.Location = new System.Drawing.Point(518, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 58;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DeleteOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(634, 301);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteOperation);
            this.Controls.Add(this.cmbOID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOperType);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DeleteOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteOperation";
            this.Load += new System.EventHandler(this.DeleteOperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOperType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnExit;
    }
}