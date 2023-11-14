namespace crackedCupWinFormsGUI
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.printReceiptBtn = new System.Windows.Forms.Button();
            this.saveTxBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.pmtTypeGb = new System.Windows.Forms.GroupBox();
            this.CardRbtn = new System.Windows.Forms.RadioButton();
            this.cashRbtn = new System.Windows.Forms.RadioButton();
            this.cashGb = new System.Windows.Forms.GroupBox();
            this.changeDueTb = new System.Windows.Forms.TextBox();
            this.amountTenderedTb = new System.Windows.Forms.TextBox();
            this.changeDueLbl = new System.Windows.Forms.Label();
            this.amountTenderedLbl = new System.Windows.Forms.Label();
            this.cardGb = new System.Windows.Forms.GroupBox();
            this.cvvTb = new System.Windows.Forms.TextBox();
            this.cardholderNameTb = new System.Windows.Forms.TextBox();
            this.expiryDateTb = new System.Windows.Forms.TextBox();
            this.cardNumberTb = new System.Windows.Forms.TextBox();
            this.cvvLbl = new System.Windows.Forms.Label();
            this.cardholderNameLbl = new System.Windows.Forms.Label();
            this.expiryDateLbl = new System.Windows.Forms.Label();
            this.cardNumberLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeTb = new System.Windows.Forms.TextBox();
            this.dateTb = new System.Windows.Forms.TextBox();
            this.transactionIDTb = new System.Windows.Forms.TextBox();
            this.orderIDTb = new System.Windows.Forms.TextBox();
            this.timeLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.transactionIDLbl = new System.Windows.Forms.Label();
            this.orderIDLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.amountPaidTb = new System.Windows.Forms.TextBox();
            this.totalTb = new System.Windows.Forms.TextBox();
            this.taxTb = new System.Windows.Forms.TextBox();
            this.subtotalTb = new System.Windows.Forms.TextBox();
            this.taxLbl = new System.Windows.Forms.Label();
            this.subtotalLbl = new System.Windows.Forms.Label();
            this.amountPaidLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.processPaymentBtn = new System.Windows.Forms.Button();
            this.processRefundBtn = new System.Windows.Forms.Button();
            this.pmtTypeGb.SuspendLayout();
            this.cashGb.SuspendLayout();
            this.cardGb.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printReceiptBtn
            // 
            this.printReceiptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.printReceiptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptBtn.Location = new System.Drawing.Point(258, 922);
            this.printReceiptBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printReceiptBtn.Name = "printReceiptBtn";
            this.printReceiptBtn.Size = new System.Drawing.Size(188, 46);
            this.printReceiptBtn.TabIndex = 2;
            this.printReceiptBtn.Text = "&Print Receipt";
            this.printReceiptBtn.UseVisualStyleBackColor = true;
            // 
            // saveTxBtn
            // 
            this.saveTxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveTxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTxBtn.Location = new System.Drawing.Point(484, 922);
            this.saveTxBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveTxBtn.Name = "saveTxBtn";
            this.saveTxBtn.Size = new System.Drawing.Size(188, 46);
            this.saveTxBtn.TabIndex = 3;
            this.saveTxBtn.Text = "&Save Transaction";
            this.saveTxBtn.UseVisualStyleBackColor = true;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(21, 14);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(159, 40);
            this.titleLbl.TabIndex = 8;
            this.titleLbl.Text = "Payment";
            // 
            // pmtTypeGb
            // 
            this.pmtTypeGb.Controls.Add(this.CardRbtn);
            this.pmtTypeGb.Controls.Add(this.cashRbtn);
            this.pmtTypeGb.Location = new System.Drawing.Point(466, 65);
            this.pmtTypeGb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pmtTypeGb.Name = "pmtTypeGb";
            this.pmtTypeGb.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pmtTypeGb.Size = new System.Drawing.Size(194, 100);
            this.pmtTypeGb.TabIndex = 13;
            this.pmtTypeGb.TabStop = false;
            this.pmtTypeGb.Text = "Select Payment Type:";
            // 
            // CardRbtn
            // 
            this.CardRbtn.AutoSize = true;
            this.CardRbtn.Location = new System.Drawing.Point(57, 60);
            this.CardRbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CardRbtn.Name = "CardRbtn";
            this.CardRbtn.Size = new System.Drawing.Size(68, 24);
            this.CardRbtn.TabIndex = 1;
            this.CardRbtn.TabStop = true;
            this.CardRbtn.Text = "Card";
            this.CardRbtn.UseVisualStyleBackColor = true;
            // 
            // cashRbtn
            // 
            this.cashRbtn.AutoSize = true;
            this.cashRbtn.Location = new System.Drawing.Point(57, 29);
            this.cashRbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashRbtn.Name = "cashRbtn";
            this.cashRbtn.Size = new System.Drawing.Size(71, 24);
            this.cashRbtn.TabIndex = 0;
            this.cashRbtn.TabStop = true;
            this.cashRbtn.Text = "Cash";
            this.cashRbtn.UseVisualStyleBackColor = true;
            // 
            // cashGb
            // 
            this.cashGb.Controls.Add(this.changeDueTb);
            this.cashGb.Controls.Add(this.amountTenderedTb);
            this.cashGb.Controls.Add(this.changeDueLbl);
            this.cashGb.Controls.Add(this.amountTenderedLbl);
            this.cashGb.Location = new System.Drawing.Point(28, 497);
            this.cashGb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashGb.Name = "cashGb";
            this.cashGb.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashGb.Size = new System.Drawing.Size(432, 114);
            this.cashGb.TabIndex = 14;
            this.cashGb.TabStop = false;
            this.cashGb.Text = "Cash Payment Details";
            // 
            // changeDueTb
            // 
            this.changeDueTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDueTb.Location = new System.Drawing.Point(194, 63);
            this.changeDueTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changeDueTb.Name = "changeDueTb";
            this.changeDueTb.Size = new System.Drawing.Size(224, 30);
            this.changeDueTb.TabIndex = 20;
            // 
            // amountTenderedTb
            // 
            this.amountTenderedTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTenderedTb.Location = new System.Drawing.Point(194, 20);
            this.amountTenderedTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amountTenderedTb.Name = "amountTenderedTb";
            this.amountTenderedTb.Size = new System.Drawing.Size(224, 30);
            this.amountTenderedTb.TabIndex = 19;
            // 
            // changeDueLbl
            // 
            this.changeDueLbl.AutoSize = true;
            this.changeDueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDueLbl.Location = new System.Drawing.Point(9, 68);
            this.changeDueLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changeDueLbl.Name = "changeDueLbl";
            this.changeDueLbl.Size = new System.Drawing.Size(129, 25);
            this.changeDueLbl.TabIndex = 17;
            this.changeDueLbl.Text = "Change Due:";
            // 
            // amountTenderedLbl
            // 
            this.amountTenderedLbl.AutoSize = true;
            this.amountTenderedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTenderedLbl.Location = new System.Drawing.Point(9, 25);
            this.amountTenderedLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountTenderedLbl.Name = "amountTenderedLbl";
            this.amountTenderedLbl.Size = new System.Drawing.Size(176, 25);
            this.amountTenderedLbl.TabIndex = 13;
            this.amountTenderedLbl.Text = "Amount Tendered:";
            // 
            // cardGb
            // 
            this.cardGb.Controls.Add(this.cvvTb);
            this.cardGb.Controls.Add(this.cardholderNameTb);
            this.cardGb.Controls.Add(this.expiryDateTb);
            this.cardGb.Controls.Add(this.cardNumberTb);
            this.cardGb.Controls.Add(this.cvvLbl);
            this.cardGb.Controls.Add(this.cardholderNameLbl);
            this.cardGb.Controls.Add(this.expiryDateLbl);
            this.cardGb.Controls.Add(this.cardNumberLbl);
            this.cardGb.Location = new System.Drawing.Point(28, 634);
            this.cardGb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardGb.Name = "cardGb";
            this.cardGb.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardGb.Size = new System.Drawing.Size(432, 203);
            this.cardGb.TabIndex = 17;
            this.cardGb.TabStop = false;
            this.cardGb.Text = "Card Payment Details";
            // 
            // cvvTb
            // 
            this.cvvTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvvTb.Location = new System.Drawing.Point(194, 152);
            this.cvvTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cvvTb.Name = "cvvTb";
            this.cvvTb.Size = new System.Drawing.Size(224, 30);
            this.cvvTb.TabIndex = 20;
            // 
            // cardholderNameTb
            // 
            this.cardholderNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardholderNameTb.Location = new System.Drawing.Point(194, 106);
            this.cardholderNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardholderNameTb.Name = "cardholderNameTb";
            this.cardholderNameTb.Size = new System.Drawing.Size(224, 30);
            this.cardholderNameTb.TabIndex = 19;
            // 
            // expiryDateTb
            // 
            this.expiryDateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDateTb.Location = new System.Drawing.Point(194, 63);
            this.expiryDateTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expiryDateTb.Name = "expiryDateTb";
            this.expiryDateTb.Size = new System.Drawing.Size(224, 30);
            this.expiryDateTb.TabIndex = 18;
            // 
            // cardNumberTb
            // 
            this.cardNumberTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberTb.Location = new System.Drawing.Point(194, 20);
            this.cardNumberTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardNumberTb.Name = "cardNumberTb";
            this.cardNumberTb.Size = new System.Drawing.Size(224, 30);
            this.cardNumberTb.TabIndex = 17;
            // 
            // cvvLbl
            // 
            this.cvvLbl.AutoSize = true;
            this.cvvLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvvLbl.Location = new System.Drawing.Point(9, 157);
            this.cvvLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cvvLbl.Name = "cvvLbl";
            this.cvvLbl.Size = new System.Drawing.Size(61, 25);
            this.cvvLbl.TabIndex = 16;
            this.cvvLbl.Text = "CVV:";
            // 
            // cardholderNameLbl
            // 
            this.cardholderNameLbl.AutoSize = true;
            this.cardholderNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardholderNameLbl.Location = new System.Drawing.Point(9, 111);
            this.cardholderNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardholderNameLbl.Name = "cardholderNameLbl";
            this.cardholderNameLbl.Size = new System.Drawing.Size(172, 25);
            this.cardholderNameLbl.TabIndex = 15;
            this.cardholderNameLbl.Text = "Cardholder Name:";
            // 
            // expiryDateLbl
            // 
            this.expiryDateLbl.AutoSize = true;
            this.expiryDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDateLbl.Location = new System.Drawing.Point(9, 68);
            this.expiryDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expiryDateLbl.Name = "expiryDateLbl";
            this.expiryDateLbl.Size = new System.Drawing.Size(118, 25);
            this.expiryDateLbl.TabIndex = 14;
            this.expiryDateLbl.Text = "Expiry Date:";
            // 
            // cardNumberLbl
            // 
            this.cardNumberLbl.AutoSize = true;
            this.cardNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberLbl.Location = new System.Drawing.Point(9, 25);
            this.cardNumberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardNumberLbl.Name = "cardNumberLbl";
            this.cardNumberLbl.Size = new System.Drawing.Size(135, 25);
            this.cardNumberLbl.TabIndex = 13;
            this.cardNumberLbl.Text = "Card Number:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timeTb);
            this.panel1.Controls.Add(this.dateTb);
            this.panel1.Controls.Add(this.transactionIDTb);
            this.panel1.Controls.Add(this.orderIDTb);
            this.panel1.Controls.Add(this.timeLbl);
            this.panel1.Controls.Add(this.dateLbl);
            this.panel1.Controls.Add(this.transactionIDLbl);
            this.panel1.Controls.Add(this.orderIDLbl);
            this.panel1.Location = new System.Drawing.Point(28, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 195);
            this.panel1.TabIndex = 25;
            // 
            // timeTb
            // 
            this.timeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTb.Location = new System.Drawing.Point(164, 145);
            this.timeTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeTb.Name = "timeTb";
            this.timeTb.Size = new System.Drawing.Size(224, 30);
            this.timeTb.TabIndex = 32;
            // 
            // dateTb
            // 
            this.dateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTb.Location = new System.Drawing.Point(164, 98);
            this.dateTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTb.Name = "dateTb";
            this.dateTb.Size = new System.Drawing.Size(224, 30);
            this.dateTb.TabIndex = 31;
            // 
            // transactionIDTb
            // 
            this.transactionIDTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionIDTb.Location = new System.Drawing.Point(164, 55);
            this.transactionIDTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transactionIDTb.Name = "transactionIDTb";
            this.transactionIDTb.Size = new System.Drawing.Size(224, 30);
            this.transactionIDTb.TabIndex = 30;
            // 
            // orderIDTb
            // 
            this.orderIDTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDTb.Location = new System.Drawing.Point(164, 12);
            this.orderIDTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderIDTb.Name = "orderIDTb";
            this.orderIDTb.Size = new System.Drawing.Size(224, 30);
            this.orderIDTb.TabIndex = 29;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(14, 149);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(62, 25);
            this.timeLbl.TabIndex = 28;
            this.timeLbl.Text = "Time:";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(16, 103);
            this.dateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(59, 25);
            this.dateLbl.TabIndex = 27;
            this.dateLbl.Text = "Date:";
            // 
            // transactionIDLbl
            // 
            this.transactionIDLbl.AutoSize = true;
            this.transactionIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionIDLbl.Location = new System.Drawing.Point(14, 60);
            this.transactionIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.transactionIDLbl.Name = "transactionIDLbl";
            this.transactionIDLbl.Size = new System.Drawing.Size(145, 25);
            this.transactionIDLbl.TabIndex = 26;
            this.transactionIDLbl.Text = "Transaction ID:";
            // 
            // orderIDLbl
            // 
            this.orderIDLbl.AutoSize = true;
            this.orderIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDLbl.Location = new System.Drawing.Point(14, 17);
            this.orderIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderIDLbl.Name = "orderIDLbl";
            this.orderIDLbl.Size = new System.Drawing.Size(92, 25);
            this.orderIDLbl.TabIndex = 25;
            this.orderIDLbl.Text = "Order ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.amountPaidTb);
            this.panel2.Controls.Add(this.totalTb);
            this.panel2.Controls.Add(this.taxTb);
            this.panel2.Controls.Add(this.subtotalTb);
            this.panel2.Controls.Add(this.taxLbl);
            this.panel2.Controls.Add(this.subtotalLbl);
            this.panel2.Controls.Add(this.amountPaidLbl);
            this.panel2.Controls.Add(this.totalLbl);
            this.panel2.Location = new System.Drawing.Point(28, 274);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 198);
            this.panel2.TabIndex = 27;
            // 
            // amountPaidTb
            // 
            this.amountPaidTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPaidTb.Location = new System.Drawing.Point(164, 146);
            this.amountPaidTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amountPaidTb.Name = "amountPaidTb";
            this.amountPaidTb.Size = new System.Drawing.Size(224, 30);
            this.amountPaidTb.TabIndex = 36;
            // 
            // totalTb
            // 
            this.totalTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTb.Location = new System.Drawing.Point(164, 100);
            this.totalTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalTb.Name = "totalTb";
            this.totalTb.Size = new System.Drawing.Size(224, 30);
            this.totalTb.TabIndex = 35;
            // 
            // taxTb
            // 
            this.taxTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxTb.Location = new System.Drawing.Point(164, 57);
            this.taxTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.taxTb.Name = "taxTb";
            this.taxTb.Size = new System.Drawing.Size(224, 30);
            this.taxTb.TabIndex = 34;
            // 
            // subtotalTb
            // 
            this.subtotalTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalTb.Location = new System.Drawing.Point(164, 14);
            this.subtotalTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subtotalTb.Name = "subtotalTb";
            this.subtotalTb.Size = new System.Drawing.Size(224, 30);
            this.subtotalTb.TabIndex = 33;
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLbl.Location = new System.Drawing.Point(10, 62);
            this.taxLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(52, 25);
            this.taxLbl.TabIndex = 11;
            this.taxLbl.Text = "Tax:";
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLbl.Location = new System.Drawing.Point(10, 18);
            this.subtotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Size = new System.Drawing.Size(90, 25);
            this.subtotalLbl.TabIndex = 10;
            this.subtotalLbl.Text = "Subtotal:";
            // 
            // amountPaidLbl
            // 
            this.amountPaidLbl.AutoSize = true;
            this.amountPaidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPaidLbl.Location = new System.Drawing.Point(10, 151);
            this.amountPaidLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountPaidLbl.Name = "amountPaidLbl";
            this.amountPaidLbl.Size = new System.Drawing.Size(130, 25);
            this.amountPaidLbl.TabIndex = 9;
            this.amountPaidLbl.Text = "Amount Paid:";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(10, 105);
            this.totalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(62, 25);
            this.totalLbl.TabIndex = 8;
            this.totalLbl.Text = "Total:";
            // 
            // processPaymentBtn
            // 
            this.processPaymentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.processPaymentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processPaymentBtn.Location = new System.Drawing.Point(148, 866);
            this.processPaymentBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processPaymentBtn.Name = "processPaymentBtn";
            this.processPaymentBtn.Size = new System.Drawing.Size(188, 46);
            this.processPaymentBtn.TabIndex = 28;
            this.processPaymentBtn.Text = "Process Payment";
            this.processPaymentBtn.UseVisualStyleBackColor = true;
            // 
            // processRefundBtn
            // 
            this.processRefundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.processRefundBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processRefundBtn.Location = new System.Drawing.Point(366, 866);
            this.processRefundBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processRefundBtn.Name = "processRefundBtn";
            this.processRefundBtn.Size = new System.Drawing.Size(188, 46);
            this.processRefundBtn.TabIndex = 29;
            this.processRefundBtn.Text = "Process Refund";
            this.processRefundBtn.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 980);
            this.Controls.Add(this.processRefundBtn);
            this.Controls.Add(this.processPaymentBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cardGb);
            this.Controls.Add(this.cashGb);
            this.Controls.Add(this.pmtTypeGb);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.saveTxBtn);
            this.Controls.Add(this.printReceiptBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Payment";
            this.Text = "Payment - Cracked Cup POS";
            this.pmtTypeGb.ResumeLayout(false);
            this.pmtTypeGb.PerformLayout();
            this.cashGb.ResumeLayout(false);
            this.cashGb.PerformLayout();
            this.cardGb.ResumeLayout(false);
            this.cardGb.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button printReceiptBtn;
        private System.Windows.Forms.Button saveTxBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.GroupBox pmtTypeGb;
        private System.Windows.Forms.RadioButton CardRbtn;
        private System.Windows.Forms.RadioButton cashRbtn;
        private System.Windows.Forms.GroupBox cashGb;
        private System.Windows.Forms.Label changeDueLbl;
        private System.Windows.Forms.Label amountTenderedLbl;
        private System.Windows.Forms.GroupBox cardGb;
        private System.Windows.Forms.Label cvvLbl;
        private System.Windows.Forms.Label cardholderNameLbl;
        private System.Windows.Forms.Label expiryDateLbl;
        private System.Windows.Forms.Label cardNumberLbl;
        private System.Windows.Forms.TextBox cvvTb;
        private System.Windows.Forms.TextBox cardholderNameTb;
        private System.Windows.Forms.TextBox expiryDateTb;
        private System.Windows.Forms.TextBox cardNumberTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox timeTb;
        private System.Windows.Forms.TextBox dateTb;
        private System.Windows.Forms.TextBox transactionIDTb;
        private System.Windows.Forms.TextBox orderIDTb;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label transactionIDLbl;
        private System.Windows.Forms.Label orderIDLbl;
        private System.Windows.Forms.TextBox changeDueTb;
        private System.Windows.Forms.TextBox amountTenderedTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox amountPaidTb;
        private System.Windows.Forms.TextBox totalTb;
        private System.Windows.Forms.TextBox taxTb;
        private System.Windows.Forms.TextBox subtotalTb;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label subtotalLbl;
        private System.Windows.Forms.Label amountPaidLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Button processPaymentBtn;
        private System.Windows.Forms.Button processRefundBtn;
    }
}