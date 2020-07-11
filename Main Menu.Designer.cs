namespace PresentationLayer
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.btnClient = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnTechnical = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClient.BackgroundImage")));
            this.btnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClient.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClient.Location = new System.Drawing.Point(43, 108);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(171, 118);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Client Management Department";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProduct.BackgroundImage")));
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduct.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnProduct.Location = new System.Drawing.Point(241, 108);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(171, 118);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Product Management Department";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnTechnical
            // 
            this.btnTechnical.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTechnical.BackgroundImage")));
            this.btnTechnical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTechnical.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechnical.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTechnical.Location = new System.Drawing.Point(441, 108);
            this.btnTechnical.Name = "btnTechnical";
            this.btnTechnical.Size = new System.Drawing.Size(171, 118);
            this.btnTechnical.TabIndex = 4;
            this.btnTechnical.Text = "Technical Support Department";
            this.btnTechnical.UseVisualStyleBackColor = true;
            this.btnTechnical.Click += new System.EventHandler(this.btnTechnical_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Wide Latin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(71, 56);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(475, 19);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome to Smart Home System";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(634, 292);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnTechnical);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnClient);
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnTechnical;
        private System.Windows.Forms.Label lblWelcome;
    }
}