namespace CashRegister1
{
    partial class CashRegister
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
            this.receiptLabel = new System.Windows.Forms.Label();
            this.inputTextbox1 = new System.Windows.Forms.TextBox();
            this.inputLabel1 = new System.Windows.Forms.Label();
            this.inputLabel2 = new System.Windows.Forms.Label();
            this.inputLabel3 = new System.Windows.Forms.Label();
            this.inputTextbox2 = new System.Windows.Forms.TextBox();
            this.inputTextbox3 = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.noNumbersLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.blackLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedTextbox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.outputLabel3 = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // receiptLabel
            // 
            this.receiptLabel.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(525, 19);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(243, 418);
            this.receiptLabel.TabIndex = 0;
            // 
            // inputTextbox1
            // 
            this.inputTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.inputTextbox1.Location = new System.Drawing.Point(278, 59);
            this.inputTextbox1.Name = "inputTextbox1";
            this.inputTextbox1.Size = new System.Drawing.Size(205, 20);
            this.inputTextbox1.TabIndex = 1;
            // 
            // inputLabel1
            // 
            this.inputLabel1.Font = new System.Drawing.Font("Baskerville Win95BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel1.Location = new System.Drawing.Point(19, 61);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(235, 20);
            this.inputLabel1.TabIndex = 2;
            this.inputLabel1.Text = "Number of Chocolate Dipped Cheesecakes:";
            // 
            // inputLabel2
            // 
            this.inputLabel2.Font = new System.Drawing.Font("Baskerville Win95BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel2.Location = new System.Drawing.Point(16, 103);
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Size = new System.Drawing.Size(238, 20);
            this.inputLabel2.TabIndex = 4;
            this.inputLabel2.Text = "Number of Peaks:";
            // 
            // inputLabel3
            // 
            this.inputLabel3.Font = new System.Drawing.Font("Baskerville Win95BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel3.Location = new System.Drawing.Point(16, 148);
            this.inputLabel3.Name = "inputLabel3";
            this.inputLabel3.Size = new System.Drawing.Size(238, 20);
            this.inputLabel3.TabIndex = 5;
            this.inputLabel3.Text = "Number of Candy Apples:";
            // 
            // inputTextbox2
            // 
            this.inputTextbox2.Location = new System.Drawing.Point(278, 103);
            this.inputTextbox2.Name = "inputTextbox2";
            this.inputTextbox2.Size = new System.Drawing.Size(205, 20);
            this.inputTextbox2.TabIndex = 6;
            // 
            // inputTextbox3
            // 
            this.inputTextbox3.Location = new System.Drawing.Point(278, 148);
            this.inputTextbox3.Name = "inputTextbox3";
            this.inputTextbox3.Size = new System.Drawing.Size(205, 20);
            this.inputTextbox3.TabIndex = 7;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(22, 215);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(458, 23);
            this.totalButton.TabIndex = 8;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.TotalButton_Click);
            // 
            // noNumbersLabel
            // 
            this.noNumbersLabel.Font = new System.Drawing.Font("Baskerville Win95BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noNumbersLabel.Location = new System.Drawing.Point(145, 186);
            this.noNumbersLabel.Name = "noNumbersLabel";
            this.noNumbersLabel.Size = new System.Drawing.Size(215, 23);
            this.noNumbersLabel.TabIndex = 9;
            this.noNumbersLabel.Text = "Please Enter a Numerical Value";
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Stencil Std", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(22, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(456, 35);
            this.headerLabel.TabIndex = 10;
            this.headerLabel.Text = "Rocky Mountain Chocolate Factory";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(33, 241);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(49, 13);
            this.subtotalLabel.TabIndex = 11;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(33, 267);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(28, 13);
            this.taxLabel.TabIndex = 12;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(33, 299);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "Total:";
            // 
            // blackLabel
            // 
            this.blackLabel.BackColor = System.Drawing.Color.Black;
            this.blackLabel.Location = new System.Drawing.Point(19, 322);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(458, 17);
            this.blackLabel.TabIndex = 14;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(19, 358);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(56, 13);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // tenderedTextbox
            // 
            this.tenderedTextbox.Location = new System.Drawing.Point(148, 351);
            this.tenderedTextbox.Name = "tenderedTextbox";
            this.tenderedTextbox.Size = new System.Drawing.Size(320, 20);
            this.tenderedTextbox.TabIndex = 17;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(22, 384);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(458, 23);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(22, 424);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(47, 13);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "Change:";
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(25, 450);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(458, 23);
            this.receiptButton.TabIndex = 20;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(528, 450);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(240, 23);
            this.newOrderButton.TabIndex = 21;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // outputLabel1
            // 
            this.outputLabel1.AutoSize = true;
            this.outputLabel1.Location = new System.Drawing.Point(396, 241);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(0, 13);
            this.outputLabel1.TabIndex = 22;
            // 
            // outputLabel2
            // 
            this.outputLabel2.AutoSize = true;
            this.outputLabel2.Location = new System.Drawing.Point(396, 267);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(0, 13);
            this.outputLabel2.TabIndex = 23;
            // 
            // outputLabel3
            // 
            this.outputLabel3.AutoSize = true;
            this.outputLabel3.Location = new System.Drawing.Point(396, 299);
            this.outputLabel3.Name = "outputLabel3";
            this.outputLabel3.Size = new System.Drawing.Size(0, 13);
            this.outputLabel3.TabIndex = 24;
            // 
            // changeOutput
            // 
            this.changeOutput.Location = new System.Drawing.Point(399, 424);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(72, 13);
            this.changeOutput.TabIndex = 25;
            this.changeOutput.Click += new System.EventHandler(this.ChangeOutput_Click);
            // 
            // CashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 519);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.outputLabel3);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedTextbox);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.blackLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.noNumbersLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.inputTextbox3);
            this.Controls.Add(this.inputTextbox2);
            this.Controls.Add(this.inputLabel3);
            this.Controls.Add(this.inputLabel2);
            this.Controls.Add(this.inputLabel1);
            this.Controls.Add(this.inputTextbox1);
            this.Controls.Add(this.receiptLabel);
            this.Name = "CashRegister";
            this.Text = "CashRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.TextBox inputTextbox1;
        private System.Windows.Forms.Label inputLabel1;
        private System.Windows.Forms.Label inputLabel2;
        private System.Windows.Forms.Label inputLabel3;
        private System.Windows.Forms.TextBox inputTextbox2;
        private System.Windows.Forms.TextBox inputTextbox3;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label noNumbersLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedTextbox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Label outputLabel2;
        private System.Windows.Forms.Label outputLabel3;
        private System.Windows.Forms.Label changeOutput;
    }
}

