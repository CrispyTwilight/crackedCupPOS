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
            this.saveTransactionBtn = new System.Windows.Forms.Button();
            this.paymentTitleLbl = new System.Windows.Forms.Label();
            this.pmtTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.cardRdo = new System.Windows.Forms.RadioButton();
            this.cashRdo = new System.Windows.Forms.RadioButton();
            this.cashGroupBox = new System.Windows.Forms.GroupBox();
            this.changeDueTb = new System.Windows.Forms.TextBox();
            this.amountTenderedTb = new System.Windows.Forms.TextBox();
            this.changeDueLbl = new System.Windows.Forms.Label();
            this.amountTenderedLbl = new System.Windows.Forms.Label();
            this.cardGroupBox = new System.Windows.Forms.GroupBox();
            this.cvvTb = new System.Windows.Forms.TextBox();
            this.cardholderNameTb = new System.Windows.Forms.TextBox();
            this.expiryDateTb = new System.Windows.Forms.TextBox();
            this.cardNumberTb = new System.Windows.Forms.TextBox();
            this.cvvLbl = new System.Windows.Forms.Label();
            this.cardholderNameLbl = new System.Windows.Forms.Label();
            this.expiryDateLbl = new System.Windows.Forms.Label();
            this.cardNumberLbl = new System.Windows.Forms.Label();
            this.orderDetailPanel = new System.Windows.Forms.Panel();
            this.timeTb = new System.Windows.Forms.TextBox();
            this.dateTb = new System.Windows.Forms.TextBox();
            this.transactionIDTb = new System.Windows.Forms.TextBox();
            this.orderIDTb = new System.Windows.Forms.TextBox();
            this.timeLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.transactionIDLbl = new System.Windows.Forms.Label();
            this.orderIDLbl = new System.Windows.Forms.Label();
            this.costDetailPanel = new System.Windows.Forms.Panel();
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
            this.pmtTypeGroupBox.SuspendLayout();
            this.cashGroupBox.SuspendLayout();
            this.cardGroupBox.SuspendLayout();
            this.orderDetailPanel.SuspendLayout();
            this.costDetailPanel.SuspendLayout();
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
            // saveTransactionBtn
            // 
            this.saveTransactionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveTransactionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTransactionBtn.Location = new System.Drawing.Point(325, 279);
            this.saveTransactionBtn.Name = "saveTransactionBtn";
            this.saveTransactionBtn.Size = new System.Drawing.Size(125, 30);
            this.saveTransactionBtn.TabIndex = 3;
            this.saveTransactionBtn.Text = "&Save Transaction";
            this.saveTransactionBtn.UseVisualStyleBackColor = true;
            // 
            // paymentTitleLbl
            // 
            this.paymentTitleLbl.AutoSize = true;
            this.paymentTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTitleLbl.Location = new System.Drawing.Point(14, 9);
            this.paymentTitleLbl.Name = "paymentTitleLbl";
            this.paymentTitleLbl.Size = new System.Drawing.Size(106, 29);
            this.paymentTitleLbl.TabIndex = 8;
            this.paymentTitleLbl.Text = "Payment";
            // 
            // pmtTypeGroupBox
            // 
            this.pmtTypeGroupBox.Controls.Add(this.cardRdo);
            this.pmtTypeGroupBox.Controls.Add(this.cashRdo);
            this.pmtTypeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pmtTypeGroupBox.Location = new System.Drawing.Point(316, 42);
            this.pmtTypeGroupBox.Name = "pmtTypeGroupBox";
            this.pmtTypeGroupBox.Size = new System.Drawing.Size(153, 83);
            this.pmtTypeGroupBox.TabIndex = 13;
            this.pmtTypeGroupBox.TabStop = false;
            this.pmtTypeGroupBox.Text = "Select Payment Type:";
            // 
            // cardRdo
            // 
            this.cardRdo.AutoSize = true;
            this.cardRdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardRdo.Location = new System.Drawing.Point(48, 47);
            this.cardRdo.Name = "cardRdo";
            this.cardRdo.Size = new System.Drawing.Size(54, 20);
            this.cardRdo.TabIndex = 1;
            this.cardRdo.TabStop = true;
            this.cardRdo.Text = "Card";
            this.cardRdo.UseVisualStyleBackColor = true;
            // 
            // cashRdo
            // 
            this.cashRdo.AutoSize = true;
            this.cashRdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashRdo.Location = new System.Drawing.Point(48, 21);
            this.cashRdo.Name = "cashRdo";
            this.cashRdo.Size = new System.Drawing.Size(56, 20);
            this.cashRdo.TabIndex = 0;
            this.cashRdo.TabStop = true;
            this.cashRdo.Text = "Cash";
            this.cashRdo.UseVisualStyleBackColor = true;
            // 
            // cashGroupBox
            // 
            this.cashGroupBox.Controls.Add(this.changeDueTb);
            this.cashGroupBox.Controls.Add(this.amountTenderedTb);
            this.cashGroupBox.Controls.Add(this.changeDueLbl);
            this.cashGroupBox.Controls.Add(this.amountTenderedLbl);
            this.cashGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashGroupBox.Location = new System.Drawing.Point(19, 296);
            this.cashGroupBox.Name = "cashGroupBox";
            this.cashGroupBox.Size = new System.Drawing.Size(288, 83);
            this.cashGroupBox.TabIndex = 14;
            this.cashGroupBox.TabStop = false;
            this.cashGroupBox.Text = "Cash Payment Details";
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
            // cardGroupBox
            // 
            this.cardGroupBox.Controls.Add(this.cvvTb);
            this.cardGroupBox.Controls.Add(this.cardholderNameTb);
            this.cardGroupBox.Controls.Add(this.expiryDateTb);
            this.cardGroupBox.Controls.Add(this.cardNumberTb);
            this.cardGroupBox.Controls.Add(this.cvvLbl);
            this.cardGroupBox.Controls.Add(this.cardholderNameLbl);
            this.cardGroupBox.Controls.Add(this.expiryDateLbl);
            this.cardGroupBox.Controls.Add(this.cardNumberLbl);
            this.cardGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardGroupBox.Location = new System.Drawing.Point(19, 385);
            this.cardGroupBox.Name = "cardGroupBox";
            this.cardGroupBox.Size = new System.Drawing.Size(288, 146);
            this.cardGroupBox.TabIndex = 17;
            this.cardGroupBox.TabStop = false;
            this.cardGroupBox.Text = "Card Payment Details";
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
            // orderDetailPanel
            // 
            this.orderDetailPanel.Controls.Add(this.timeTb);
            this.orderDetailPanel.Controls.Add(this.dateTb);
            this.orderDetailPanel.Controls.Add(this.transactionIDTb);
            this.orderDetailPanel.Controls.Add(this.orderIDTb);
            this.orderDetailPanel.Controls.Add(this.timeLbl);
            this.orderDetailPanel.Controls.Add(this.dateLbl);
            this.orderDetailPanel.Controls.Add(this.transactionIDLbl);
            this.orderDetailPanel.Controls.Add(this.orderIDLbl);
            this.orderDetailPanel.Location = new System.Drawing.Point(19, 42);
            this.orderDetailPanel.Name = "orderDetailPanel";
            this.orderDetailPanel.Size = new System.Drawing.Size(288, 127);
            this.orderDetailPanel.TabIndex = 25;
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
            // costDetailPanel
            // 
            this.costDetailPanel.Controls.Add(this.totalTb);
            this.costDetailPanel.Controls.Add(this.taxTb);
            this.costDetailPanel.Controls.Add(this.subtotalTb);
            this.costDetailPanel.Controls.Add(this.taxLbl);
            this.costDetailPanel.Controls.Add(this.subtotalLbl);
            this.costDetailPanel.Controls.Add(this.totalLbl);
            this.costDetailPanel.Location = new System.Drawing.Point(19, 178);
            this.costDetailPanel.Name = "costDetailPanel";
            this.costDetailPanel.Size = new System.Drawing.Size(288, 100);
            this.costDetailPanel.TabIndex = 27;
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
            this.Controls.Add(this.costDetailPanel);
            this.Controls.Add(this.orderDetailPanel);
            this.Controls.Add(this.cardGroupBox);
            this.Controls.Add(this.cashGroupBox);
            this.Controls.Add(this.pmtTypeGroupBox);
            this.Controls.Add(this.paymentTitleLbl);
            this.Controls.Add(this.saveTransactionBtn);
            this.Controls.Add(this.printReceiptBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "paymentFrm";
            this.Text = "Payment - Cracked Cup POS";
            this.pmtTypeGroupBox.ResumeLayout(false);
            this.pmtTypeGroupBox.PerformLayout();
            this.cashGroupBox.ResumeLayout(false);
            this.cashGroupBox.PerformLayout();
            this.cardGroupBox.ResumeLayout(false);
            this.cardGroupBox.PerformLayout();
            this.orderDetailPanel.ResumeLayout(false);
            this.orderDetailPanel.PerformLayout();
            this.costDetailPanel.ResumeLayout(false);
            this.costDetailPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button printReceiptBtn;
        private System.Windows.Forms.Button saveTransactionBtn;
        private System.Windows.Forms.Label paymentTitleLbl;
        private System.Windows.Forms.GroupBox pmtTypeGroupBox;
        private System.Windows.Forms.RadioButton cardRdo;
        private System.Windows.Forms.RadioButton cashRdo;
        private System.Windows.Forms.GroupBox cashGroupBox;
        private System.Windows.Forms.Label changeDueLbl;
        private System.Windows.Forms.Label amountTenderedLbl;
        private System.Windows.Forms.GroupBox cardGroupBox;
        private System.Windows.Forms.Label cvvLbl;
        private System.Windows.Forms.Label cardholderNameLbl;
        private System.Windows.Forms.Label expiryDateLbl;
        private System.Windows.Forms.Label cardNumberLbl;
        private System.Windows.Forms.TextBox cvvTb;
        private System.Windows.Forms.TextBox cardholderNameTb;
        private System.Windows.Forms.TextBox expiryDateTb;
        private System.Windows.Forms.TextBox cardNumberTb;
        private System.Windows.Forms.Panel orderDetailPanel;
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
        private System.Windows.Forms.Panel costDetailPanel;
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