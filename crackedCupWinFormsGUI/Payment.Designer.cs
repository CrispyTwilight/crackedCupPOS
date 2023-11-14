namespace crackedCupWinFormsGUI
{
    partial class paymentFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentFrm));
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
            this.totalTb = new System.Windows.Forms.TextBox();
            this.taxTb = new System.Windows.Forms.TextBox();
            this.subtotalTb = new System.Windows.Forms.TextBox();
            this.taxLbl = new System.Windows.Forms.Label();
            this.subtotalLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.processPaymentBtn = new System.Windows.Forms.Button();
            this.processRefundBtn = new System.Windows.Forms.Button();
            this.searchOrderBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.printReceiptBtn.Location = new System.Drawing.Point(325, 243);
            this.printReceiptBtn.Name = "printReceiptBtn";
            this.printReceiptBtn.Size = new System.Drawing.Size(125, 30);
            this.printReceiptBtn.TabIndex = 2;
            this.printReceiptBtn.Text = "Print &Receipt";
            this.printReceiptBtn.UseVisualStyleBackColor = true;
            // 
            // saveTxBtn
            // 
            this.saveTxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveTxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTxBtn.Location = new System.Drawing.Point(325, 279);
            this.saveTxBtn.Name = "saveTxBtn";
            this.saveTxBtn.Size = new System.Drawing.Size(125, 30);
            this.saveTxBtn.TabIndex = 3;
            this.saveTxBtn.Text = "&Save Transaction";
            this.saveTxBtn.UseVisualStyleBackColor = true;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(14, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(106, 29);
            this.titleLbl.TabIndex = 8;
            this.titleLbl.Text = "Payment";
            // 
            // pmtTypeGb
            // 
            this.pmtTypeGb.Controls.Add(this.CardRbtn);
            this.pmtTypeGb.Controls.Add(this.cashRbtn);
            this.pmtTypeGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pmtTypeGb.Location = new System.Drawing.Point(316, 42);
            this.pmtTypeGb.Name = "pmtTypeGb";
            this.pmtTypeGb.Size = new System.Drawing.Size(153, 83);
            this.pmtTypeGb.TabIndex = 13;
            this.pmtTypeGb.TabStop = false;
            this.pmtTypeGb.Text = "Select Payment Type:";
            // 
            // CardRbtn
            // 
            this.CardRbtn.AutoSize = true;
            this.CardRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardRbtn.Location = new System.Drawing.Point(48, 47);
            this.CardRbtn.Name = "CardRbtn";
            this.CardRbtn.Size = new System.Drawing.Size(54, 20);
            this.CardRbtn.TabIndex = 1;
            this.CardRbtn.TabStop = true;
            this.CardRbtn.Text = "Card";
            this.CardRbtn.UseVisualStyleBackColor = true;
            // 
            // cashRbtn
            // 
            this.cashRbtn.AutoSize = true;
            this.cashRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashRbtn.Location = new System.Drawing.Point(48, 21);
            this.cashRbtn.Name = "cashRbtn";
            this.cashRbtn.Size = new System.Drawing.Size(56, 20);
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
            this.cashGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashGb.Location = new System.Drawing.Point(19, 296);
            this.cashGb.Name = "cashGb";
            this.cashGb.Size = new System.Drawing.Size(288, 83);
            this.cashGb.TabIndex = 14;
            this.cashGb.TabStop = false;
            this.cashGb.Text = "Cash Payment Details";
            // 
            // changeDueTb
            // 
            this.changeDueTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDueTb.Location = new System.Drawing.Point(129, 49);
            this.changeDueTb.Name = "changeDueTb";
            this.changeDueTb.Size = new System.Drawing.Size(151, 22);
            this.changeDueTb.TabIndex = 20;
            // 
            // amountTenderedTb
            // 
            this.amountTenderedTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTenderedTb.Location = new System.Drawing.Point(129, 21);
            this.amountTenderedTb.Name = "amountTenderedTb";
            this.amountTenderedTb.Size = new System.Drawing.Size(151, 22);
            this.amountTenderedTb.TabIndex = 19;
            // 
            // changeDueLbl
            // 
            this.changeDueLbl.AutoSize = true;
            this.changeDueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDueLbl.Location = new System.Drawing.Point(6, 52);
            this.changeDueLbl.Name = "changeDueLbl";
            this.changeDueLbl.Size = new System.Drawing.Size(85, 16);
            this.changeDueLbl.TabIndex = 17;
            this.changeDueLbl.Text = "Change Due:";
            // 
            // amountTenderedLbl
            // 
            this.amountTenderedLbl.AutoSize = true;
            this.amountTenderedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTenderedLbl.Location = new System.Drawing.Point(6, 24);
            this.amountTenderedLbl.Name = "amountTenderedLbl";
            this.amountTenderedLbl.Size = new System.Drawing.Size(118, 16);
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
            this.cardGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardGb.Location = new System.Drawing.Point(19, 385);
            this.cardGb.Name = "cardGb";
            this.cardGb.Size = new System.Drawing.Size(288, 146);
            this.cardGb.TabIndex = 17;
            this.cardGb.TabStop = false;
            this.cardGb.Text = "Card Payment Details";
            // 
            // cvvTb
            // 
            this.cvvTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvvTb.Location = new System.Drawing.Point(129, 107);
            this.cvvTb.Name = "cvvTb";
            this.cvvTb.Size = new System.Drawing.Size(151, 22);
            this.cvvTb.TabIndex = 20;
            // 
            // cardholderNameTb
            // 
            this.cardholderNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardholderNameTb.Location = new System.Drawing.Point(129, 77);
            this.cardholderNameTb.Name = "cardholderNameTb";
            this.cardholderNameTb.Size = new System.Drawing.Size(151, 22);
            this.cardholderNameTb.TabIndex = 19;
            // 
            // expiryDateTb
            // 
            this.expiryDateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDateTb.Location = new System.Drawing.Point(129, 49);
            this.expiryDateTb.Name = "expiryDateTb";
            this.expiryDateTb.Size = new System.Drawing.Size(151, 22);
            this.expiryDateTb.TabIndex = 18;
            // 
            // cardNumberTb
            // 
            this.cardNumberTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberTb.Location = new System.Drawing.Point(129, 21);
            this.cardNumberTb.Name = "cardNumberTb";
            this.cardNumberTb.Size = new System.Drawing.Size(151, 22);
            this.cardNumberTb.TabIndex = 17;
            // 
            // cvvLbl
            // 
            this.cvvLbl.AutoSize = true;
            this.cvvLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvvLbl.Location = new System.Drawing.Point(6, 110);
            this.cvvLbl.Name = "cvvLbl";
            this.cvvLbl.Size = new System.Drawing.Size(37, 16);
            this.cvvLbl.TabIndex = 16;
            this.cvvLbl.Text = "CVV:";
            // 
            // cardholderNameLbl
            // 
            this.cardholderNameLbl.AutoSize = true;
            this.cardholderNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardholderNameLbl.Location = new System.Drawing.Point(6, 80);
            this.cardholderNameLbl.Name = "cardholderNameLbl";
            this.cardholderNameLbl.Size = new System.Drawing.Size(117, 16);
            this.cardholderNameLbl.TabIndex = 15;
            this.cardholderNameLbl.Text = "Cardholder Name:";
            // 
            // expiryDateLbl
            // 
            this.expiryDateLbl.AutoSize = true;
            this.expiryDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDateLbl.Location = new System.Drawing.Point(6, 52);
            this.expiryDateLbl.Name = "expiryDateLbl";
            this.expiryDateLbl.Size = new System.Drawing.Size(79, 16);
            this.expiryDateLbl.TabIndex = 14;
            this.expiryDateLbl.Text = "Expiry Date:";
            // 
            // cardNumberLbl
            // 
            this.cardNumberLbl.AutoSize = true;
            this.cardNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberLbl.Location = new System.Drawing.Point(6, 24);
            this.cardNumberLbl.Name = "cardNumberLbl";
            this.cardNumberLbl.Size = new System.Drawing.Size(90, 16);
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
            this.panel1.Location = new System.Drawing.Point(19, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 127);
            this.panel1.TabIndex = 25;
            // 
            // timeTb
            // 
            this.timeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTb.Location = new System.Drawing.Point(129, 94);
            this.timeTb.Name = "timeTb";
            this.timeTb.Size = new System.Drawing.Size(151, 22);
            this.timeTb.TabIndex = 32;
            // 
            // dateTb
            // 
            this.dateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTb.Location = new System.Drawing.Point(129, 64);
            this.dateTb.Name = "dateTb";
            this.dateTb.Size = new System.Drawing.Size(151, 22);
            this.dateTb.TabIndex = 31;
            // 
            // transactionIDTb
            // 
            this.transactionIDTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionIDTb.Location = new System.Drawing.Point(129, 36);
            this.transactionIDTb.Name = "transactionIDTb";
            this.transactionIDTb.Size = new System.Drawing.Size(151, 22);
            this.transactionIDTb.TabIndex = 30;
            // 
            // orderIDTb
            // 
            this.orderIDTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDTb.Location = new System.Drawing.Point(129, 8);
            this.orderIDTb.Name = "orderIDTb";
            this.orderIDTb.Size = new System.Drawing.Size(151, 22);
            this.orderIDTb.TabIndex = 29;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(9, 97);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(41, 16);
            this.timeLbl.TabIndex = 28;
            this.timeLbl.Text = "Time:";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(11, 67);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(39, 16);
            this.dateLbl.TabIndex = 27;
            this.dateLbl.Text = "Date:";
            // 
            // transactionIDLbl
            // 
            this.transactionIDLbl.AutoSize = true;
            this.transactionIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionIDLbl.Location = new System.Drawing.Point(9, 39);
            this.transactionIDLbl.Name = "transactionIDLbl";
            this.transactionIDLbl.Size = new System.Drawing.Size(97, 16);
            this.transactionIDLbl.TabIndex = 26;
            this.transactionIDLbl.Text = "Transaction ID:";
            // 
            // orderIDLbl
            // 
            this.orderIDLbl.AutoSize = true;
            this.orderIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDLbl.Location = new System.Drawing.Point(9, 11);
            this.orderIDLbl.Name = "orderIDLbl";
            this.orderIDLbl.Size = new System.Drawing.Size(60, 16);
            this.orderIDLbl.TabIndex = 25;
            this.orderIDLbl.Text = "Order ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.totalTb);
            this.panel2.Controls.Add(this.taxTb);
            this.panel2.Controls.Add(this.subtotalTb);
            this.panel2.Controls.Add(this.taxLbl);
            this.panel2.Controls.Add(this.subtotalLbl);
            this.panel2.Controls.Add(this.totalLbl);
            this.panel2.Location = new System.Drawing.Point(19, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 100);
            this.panel2.TabIndex = 27;
            // 
            // totalTb
            // 
            this.totalTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTb.Location = new System.Drawing.Point(129, 65);
            this.totalTb.Name = "totalTb";
            this.totalTb.Size = new System.Drawing.Size(151, 22);
            this.totalTb.TabIndex = 35;
            // 
            // taxTb
            // 
            this.taxTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxTb.Location = new System.Drawing.Point(129, 37);
            this.taxTb.Name = "taxTb";
            this.taxTb.Size = new System.Drawing.Size(151, 22);
            this.taxTb.TabIndex = 34;
            // 
            // subtotalTb
            // 
            this.subtotalTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalTb.Location = new System.Drawing.Point(129, 9);
            this.subtotalTb.Name = "subtotalTb";
            this.subtotalTb.Size = new System.Drawing.Size(151, 22);
            this.subtotalTb.TabIndex = 33;
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLbl.Location = new System.Drawing.Point(7, 40);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(33, 16);
            this.taxLbl.TabIndex = 11;
            this.taxLbl.Text = "Tax:";
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLbl.Location = new System.Drawing.Point(7, 12);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Size = new System.Drawing.Size(59, 16);
            this.subtotalLbl.TabIndex = 10;
            this.subtotalLbl.Text = "Subtotal:";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(7, 68);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(41, 16);
            this.totalLbl.TabIndex = 8;
            this.totalLbl.Text = "Total:";
            // 
            // processPaymentBtn
            // 
            this.processPaymentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.processPaymentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processPaymentBtn.Location = new System.Drawing.Point(325, 168);
            this.processPaymentBtn.Name = "processPaymentBtn";
            this.processPaymentBtn.Size = new System.Drawing.Size(125, 30);
            this.processPaymentBtn.TabIndex = 28;
            this.processPaymentBtn.Text = "Process &Payment";
            this.processPaymentBtn.UseVisualStyleBackColor = true;
            // 
            // processRefundBtn
            // 
            this.processRefundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.processRefundBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processRefundBtn.Location = new System.Drawing.Point(325, 204);
            this.processRefundBtn.Name = "processRefundBtn";
            this.processRefundBtn.Size = new System.Drawing.Size(125, 30);
            this.processRefundBtn.TabIndex = 29;
            this.processRefundBtn.Text = "Process Re&fund";
            this.processRefundBtn.UseVisualStyleBackColor = true;
            // 
            // searchOrderBtn
            // 
            this.searchOrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOrderBtn.Location = new System.Drawing.Point(325, 132);
            this.searchOrderBtn.Name = "searchOrderBtn";
            this.searchOrderBtn.Size = new System.Drawing.Size(125, 30);
            this.searchOrderBtn.TabIndex = 30;
            this.searchOrderBtn.Text = "Seach &Order";
            this.searchOrderBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 31;
            this.button1.Text = "&Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(325, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 32;
            this.button2.Text = "E&xit to Home";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // paymentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 572);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchOrderBtn);
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
            this.Name = "paymentFrm";
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
        private System.Windows.Forms.TextBox totalTb;
        private System.Windows.Forms.TextBox taxTb;
        private System.Windows.Forms.TextBox subtotalTb;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label subtotalLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Button processPaymentBtn;
        private System.Windows.Forms.Button processRefundBtn;
        private System.Windows.Forms.Button searchOrderBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}