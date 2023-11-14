namespace crackedCupWinFormsGUI
{
    partial class homeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeFrm));
            this.paymentBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.homeTitleLbl = new System.Windows.Forms.Label();
            this.instructionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paymentBtn
            // 
            this.paymentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paymentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBtn.Location = new System.Drawing.Point(85, 134);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(75, 30);
            this.paymentBtn.TabIndex = 0;
            this.paymentBtn.Text = "&Payment";
            this.paymentBtn.UseVisualStyleBackColor = true;
            // 
            // orderBtn
            // 
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.Location = new System.Drawing.Point(166, 134);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(75, 30);
            this.orderBtn.TabIndex = 1;
            this.orderBtn.Text = "&Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(247, 134);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 30);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // homeTitleLbl
            // 
            this.homeTitleLbl.AutoSize = true;
            this.homeTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTitleLbl.Location = new System.Drawing.Point(12, 9);
            this.homeTitleLbl.Name = "homeTitleLbl";
            this.homeTitleLbl.Size = new System.Drawing.Size(396, 37);
            this.homeTitleLbl.TabIndex = 4;
            this.homeTitleLbl.Text = "Cracked Cup Point-of-Sale";
            // 
            // instructionLbl
            // 
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLbl.Location = new System.Drawing.Point(55, 93);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(305, 25);
            this.instructionLbl.TabIndex = 5;
            this.instructionLbl.Text = "Select an option to get started:";
            // 
            // homeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 215);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.homeTitleLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.paymentBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "homeFrm";
            this.Text = "Home - Cracked Cup POS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label homeTitleLbl;
        private System.Windows.Forms.Label instructionLbl;
    }
}

