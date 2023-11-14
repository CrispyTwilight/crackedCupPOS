namespace crackedCupWinFormsGUI
{
    partial class orderFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderFrm));
            this.titleLbl = new System.Windows.Forms.Label();
            this.americanoBtn = new System.Windows.Forms.Button();
            this.blackCoffeBtn = new System.Windows.Forms.Button();
            this.cappuccinoBtn = new System.Windows.Forms.Button();
            this.coldBrewBtn = new System.Windows.Forms.Button();
            this.espressoBtn = new System.Windows.Forms.Button();
            this.frappeBtn = new System.Windows.Forms.Button();
            this.latteBtn = new System.Windows.Forms.Button();
            this.macchiatoBtn = new System.Windows.Forms.Button();
            this.mochaBtn = new System.Windows.Forms.Button();
            this.bagelBtn = new System.Windows.Forms.Button();
            this.danishBtn = new System.Windows.Forms.Button();
            this.donuts = new System.Windows.Forms.Button();
            this.orderLB = new System.Windows.Forms.ListBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orderIDTb = new System.Windows.Forms.TextBox();
            this.orderIDLb = new System.Windows.Forms.Label();
            this.orderTypeGb = new System.Windows.Forms.GroupBox();
            this.inStoreRb = new System.Windows.Forms.RadioButton();
            this.takeOutRb = new System.Windows.Forms.RadioButton();
            this.orderStatusGb = new System.Windows.Forms.GroupBox();
            this.preparingRb = new System.Windows.Forms.RadioButton();
            this.orderedRb = new System.Windows.Forms.RadioButton();
            this.completedTb = new System.Windows.Forms.RadioButton();
            this.orderTypeGb.SuspendLayout();
            this.orderStatusGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(76, 29);
            this.titleLbl.TabIndex = 9;
            this.titleLbl.Text = "Order";
            // 
            // americanoBtn
            // 
            this.americanoBtn.Location = new System.Drawing.Point(17, 41);
            this.americanoBtn.Name = "americanoBtn";
            this.americanoBtn.Size = new System.Drawing.Size(75, 75);
            this.americanoBtn.TabIndex = 10;
            this.americanoBtn.Text = "Americano";
            this.americanoBtn.UseVisualStyleBackColor = true;
            // 
            // blackCoffeBtn
            // 
            this.blackCoffeBtn.Location = new System.Drawing.Point(98, 41);
            this.blackCoffeBtn.Name = "blackCoffeBtn";
            this.blackCoffeBtn.Size = new System.Drawing.Size(75, 75);
            this.blackCoffeBtn.TabIndex = 11;
            this.blackCoffeBtn.Text = "Black Coffee";
            this.blackCoffeBtn.UseVisualStyleBackColor = true;
            // 
            // cappuccinoBtn
            // 
            this.cappuccinoBtn.Location = new System.Drawing.Point(179, 41);
            this.cappuccinoBtn.Name = "cappuccinoBtn";
            this.cappuccinoBtn.Size = new System.Drawing.Size(75, 75);
            this.cappuccinoBtn.TabIndex = 12;
            this.cappuccinoBtn.Text = "Cappuccino";
            this.cappuccinoBtn.UseVisualStyleBackColor = true;
            // 
            // coldBrewBtn
            // 
            this.coldBrewBtn.Location = new System.Drawing.Point(17, 122);
            this.coldBrewBtn.Name = "coldBrewBtn";
            this.coldBrewBtn.Size = new System.Drawing.Size(75, 75);
            this.coldBrewBtn.TabIndex = 13;
            this.coldBrewBtn.Text = "Cold Brew";
            this.coldBrewBtn.UseVisualStyleBackColor = true;
            // 
            // espressoBtn
            // 
            this.espressoBtn.Location = new System.Drawing.Point(98, 122);
            this.espressoBtn.Name = "espressoBtn";
            this.espressoBtn.Size = new System.Drawing.Size(75, 75);
            this.espressoBtn.TabIndex = 14;
            this.espressoBtn.Text = "Espresso";
            this.espressoBtn.UseVisualStyleBackColor = true;
            // 
            // frappeBtn
            // 
            this.frappeBtn.Location = new System.Drawing.Point(179, 122);
            this.frappeBtn.Name = "frappeBtn";
            this.frappeBtn.Size = new System.Drawing.Size(75, 75);
            this.frappeBtn.TabIndex = 15;
            this.frappeBtn.Text = "Frappe";
            this.frappeBtn.UseVisualStyleBackColor = true;
            // 
            // latteBtn
            // 
            this.latteBtn.Location = new System.Drawing.Point(17, 203);
            this.latteBtn.Name = "latteBtn";
            this.latteBtn.Size = new System.Drawing.Size(75, 75);
            this.latteBtn.TabIndex = 16;
            this.latteBtn.Text = "Latte";
            this.latteBtn.UseVisualStyleBackColor = true;
            // 
            // macchiatoBtn
            // 
            this.macchiatoBtn.Location = new System.Drawing.Point(98, 203);
            this.macchiatoBtn.Name = "macchiatoBtn";
            this.macchiatoBtn.Size = new System.Drawing.Size(75, 75);
            this.macchiatoBtn.TabIndex = 17;
            this.macchiatoBtn.Text = "Macchiato";
            this.macchiatoBtn.UseVisualStyleBackColor = true;
            // 
            // mochaBtn
            // 
            this.mochaBtn.Location = new System.Drawing.Point(179, 203);
            this.mochaBtn.Name = "mochaBtn";
            this.mochaBtn.Size = new System.Drawing.Size(75, 75);
            this.mochaBtn.TabIndex = 18;
            this.mochaBtn.Text = "Mocha";
            this.mochaBtn.UseVisualStyleBackColor = true;
            // 
            // bagelBtn
            // 
            this.bagelBtn.Location = new System.Drawing.Point(17, 284);
            this.bagelBtn.Name = "bagelBtn";
            this.bagelBtn.Size = new System.Drawing.Size(75, 75);
            this.bagelBtn.TabIndex = 19;
            this.bagelBtn.Text = "Bagel";
            this.bagelBtn.UseVisualStyleBackColor = true;
            // 
            // danishBtn
            // 
            this.danishBtn.Location = new System.Drawing.Point(98, 284);
            this.danishBtn.Name = "danishBtn";
            this.danishBtn.Size = new System.Drawing.Size(75, 75);
            this.danishBtn.TabIndex = 20;
            this.danishBtn.Text = "Danish";
            this.danishBtn.UseVisualStyleBackColor = true;
            // 
            // donuts
            // 
            this.donuts.Location = new System.Drawing.Point(179, 284);
            this.donuts.Name = "donuts";
            this.donuts.Size = new System.Drawing.Size(75, 75);
            this.donuts.TabIndex = 21;
            this.donuts.Text = "Donuts";
            this.donuts.UseVisualStyleBackColor = true;
            // 
            // orderLB
            // 
            this.orderLB.FormattingEnabled = true;
            this.orderLB.Location = new System.Drawing.Point(260, 41);
            this.orderLB.Name = "orderLB";
            this.orderLB.Size = new System.Drawing.Size(99, 316);
            this.orderLB.TabIndex = 22;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(14, 370);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(58, 16);
            this.quantityLbl.TabIndex = 23;
            this.quantityLbl.Text = "Quantity:";
            // 
            // paymentBtn
            // 
            this.paymentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paymentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBtn.Location = new System.Drawing.Point(402, 370);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(75, 30);
            this.paymentBtn.TabIndex = 25;
            this.paymentBtn.Text = "&Return";
            this.paymentBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(215, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "&Payment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            // 
            // orderIDTb
            // 
            this.orderIDTb.Location = new System.Drawing.Point(424, 37);
            this.orderIDTb.Name = "orderIDTb";
            this.orderIDTb.Size = new System.Drawing.Size(53, 20);
            this.orderIDTb.TabIndex = 29;
            // 
            // orderIDLb
            // 
            this.orderIDLb.AutoSize = true;
            this.orderIDLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDLb.Location = new System.Drawing.Point(365, 41);
            this.orderIDLb.Name = "orderIDLb";
            this.orderIDLb.Size = new System.Drawing.Size(57, 16);
            this.orderIDLb.TabIndex = 28;
            this.orderIDLb.Text = "OrderID:";
            // 
            // orderTypeGb
            // 
            this.orderTypeGb.Controls.Add(this.takeOutRb);
            this.orderTypeGb.Controls.Add(this.inStoreRb);
            this.orderTypeGb.Location = new System.Drawing.Point(368, 63);
            this.orderTypeGb.Name = "orderTypeGb";
            this.orderTypeGb.Size = new System.Drawing.Size(109, 76);
            this.orderTypeGb.TabIndex = 30;
            this.orderTypeGb.TabStop = false;
            this.orderTypeGb.Text = "Order Type";
            // 
            // inStoreRb
            // 
            this.inStoreRb.AutoSize = true;
            this.inStoreRb.Location = new System.Drawing.Point(7, 20);
            this.inStoreRb.Name = "inStoreRb";
            this.inStoreRb.Size = new System.Drawing.Size(59, 17);
            this.inStoreRb.TabIndex = 0;
            this.inStoreRb.TabStop = true;
            this.inStoreRb.Text = "InStore";
            this.inStoreRb.UseVisualStyleBackColor = true;
            // 
            // takeOutRb
            // 
            this.takeOutRb.AutoSize = true;
            this.takeOutRb.Location = new System.Drawing.Point(7, 43);
            this.takeOutRb.Name = "takeOutRb";
            this.takeOutRb.Size = new System.Drawing.Size(68, 17);
            this.takeOutRb.TabIndex = 1;
            this.takeOutRb.TabStop = true;
            this.takeOutRb.Text = "Take out";
            this.takeOutRb.UseVisualStyleBackColor = true;
            // 
            // orderStatusGb
            // 
            this.orderStatusGb.Controls.Add(this.completedTb);
            this.orderStatusGb.Controls.Add(this.preparingRb);
            this.orderStatusGb.Controls.Add(this.orderedRb);
            this.orderStatusGb.Location = new System.Drawing.Point(368, 145);
            this.orderStatusGb.Name = "orderStatusGb";
            this.orderStatusGb.Size = new System.Drawing.Size(109, 93);
            this.orderStatusGb.TabIndex = 31;
            this.orderStatusGb.TabStop = false;
            this.orderStatusGb.Text = "Order Status";
            // 
            // preparingRb
            // 
            this.preparingRb.AutoSize = true;
            this.preparingRb.Location = new System.Drawing.Point(7, 43);
            this.preparingRb.Name = "preparingRb";
            this.preparingRb.Size = new System.Drawing.Size(70, 17);
            this.preparingRb.TabIndex = 1;
            this.preparingRb.TabStop = true;
            this.preparingRb.Text = "Preparing";
            this.preparingRb.UseVisualStyleBackColor = true;
            // 
            // orderedRb
            // 
            this.orderedRb.AutoSize = true;
            this.orderedRb.Location = new System.Drawing.Point(7, 20);
            this.orderedRb.Name = "orderedRb";
            this.orderedRb.Size = new System.Drawing.Size(69, 17);
            this.orderedRb.TabIndex = 0;
            this.orderedRb.TabStop = true;
            this.orderedRb.Text = "Oredered";
            this.orderedRb.UseVisualStyleBackColor = true;
            // 
            // completedTb
            // 
            this.completedTb.AutoSize = true;
            this.completedTb.Location = new System.Drawing.Point(7, 66);
            this.completedTb.Name = "completedTb";
            this.completedTb.Size = new System.Drawing.Size(75, 17);
            this.completedTb.TabIndex = 2;
            this.completedTb.TabStop = true;
            this.completedTb.Text = "Completed";
            this.completedTb.UseVisualStyleBackColor = true;
            // 
            // orderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 420);
            this.Controls.Add(this.orderStatusGb);
            this.Controls.Add(this.orderTypeGb);
            this.Controls.Add(this.orderIDTb);
            this.Controls.Add(this.orderIDLb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paymentBtn);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.orderLB);
            this.Controls.Add(this.donuts);
            this.Controls.Add(this.danishBtn);
            this.Controls.Add(this.bagelBtn);
            this.Controls.Add(this.mochaBtn);
            this.Controls.Add(this.macchiatoBtn);
            this.Controls.Add(this.latteBtn);
            this.Controls.Add(this.frappeBtn);
            this.Controls.Add(this.espressoBtn);
            this.Controls.Add(this.coldBrewBtn);
            this.Controls.Add(this.cappuccinoBtn);
            this.Controls.Add(this.blackCoffeBtn);
            this.Controls.Add(this.americanoBtn);
            this.Controls.Add(this.titleLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "orderFrm";
            this.Text = "Order - Cracked Cup POS";
            this.orderTypeGb.ResumeLayout(false);
            this.orderTypeGb.PerformLayout();
            this.orderStatusGb.ResumeLayout(false);
            this.orderStatusGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button americanoBtn;
        private System.Windows.Forms.Button blackCoffeBtn;
        private System.Windows.Forms.Button cappuccinoBtn;
        private System.Windows.Forms.Button coldBrewBtn;
        private System.Windows.Forms.Button espressoBtn;
        private System.Windows.Forms.Button frappeBtn;
        private System.Windows.Forms.Button latteBtn;
        private System.Windows.Forms.Button macchiatoBtn;
        private System.Windows.Forms.Button mochaBtn;
        private System.Windows.Forms.Button bagelBtn;
        private System.Windows.Forms.Button danishBtn;
        private System.Windows.Forms.Button donuts;
        private System.Windows.Forms.ListBox orderLB;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox orderIDTb;
        private System.Windows.Forms.Label orderIDLb;
        private System.Windows.Forms.GroupBox orderTypeGb;
        private System.Windows.Forms.RadioButton takeOutRb;
        private System.Windows.Forms.RadioButton inStoreRb;
        private System.Windows.Forms.GroupBox orderStatusGb;
        private System.Windows.Forms.RadioButton completedTb;
        private System.Windows.Forms.RadioButton preparingRb;
        private System.Windows.Forms.RadioButton orderedRb;
    }
}