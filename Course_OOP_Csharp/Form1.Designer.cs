
namespace Course_OOP_Csharp
{
    partial class Form1
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
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.manufacturingDateTextBox = new System.Windows.Forms.TextBox();
            this.qualityCertificateTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.expirationDateTextBox = new System.Windows.Forms.TextBox();
            this.markupTextBox = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.calculateProfitButton = new System.Windows.Forms.Button();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.profitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(179, 44);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.productNameTextBox.TabIndex = 0;
            // 
            // manufacturingDateTextBox
            // 
            this.manufacturingDateTextBox.Location = new System.Drawing.Point(179, 100);
            this.manufacturingDateTextBox.Name = "manufacturingDateTextBox";
            this.manufacturingDateTextBox.Size = new System.Drawing.Size(100, 22);
            this.manufacturingDateTextBox.TabIndex = 1;
            // 
            // qualityCertificateTextBox
            // 
            this.qualityCertificateTextBox.Location = new System.Drawing.Point(179, 160);
            this.qualityCertificateTextBox.Name = "qualityCertificateTextBox";
            this.qualityCertificateTextBox.Size = new System.Drawing.Size(100, 22);
            this.qualityCertificateTextBox.TabIndex = 2;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(179, 227);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 22);
            this.costTextBox.TabIndex = 3;
            // 
            // expirationDateTextBox
            // 
            this.expirationDateTextBox.Location = new System.Drawing.Point(179, 333);
            this.expirationDateTextBox.Name = "expirationDateTextBox";
            this.expirationDateTextBox.Size = new System.Drawing.Size(100, 22);
            this.expirationDateTextBox.TabIndex = 6;
            // 
            // markupTextBox
            // 
            this.markupTextBox.Location = new System.Drawing.Point(179, 281);
            this.markupTextBox.Name = "markupTextBox";
            this.markupTextBox.Size = new System.Drawing.Size(100, 22);
            this.markupTextBox.TabIndex = 5;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(324, 43);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 23);
            this.addProductButton.TabIndex = 7;
            this.addProductButton.Text = " ADD";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // calculateProfitButton
            // 
            this.calculateProfitButton.Location = new System.Drawing.Point(324, 98);
            this.calculateProfitButton.Name = "calculateProfitButton";
            this.calculateProfitButton.Size = new System.Drawing.Size(86, 23);
            this.calculateProfitButton.TabIndex = 8;
            this.calculateProfitButton.Text = "Calculate";
            this.calculateProfitButton.UseVisualStyleBackColor = true;
            this.calculateProfitButton.Click += new System.EventHandler(this.calculateProfitButton_Click);
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 16;
            this.productsListBox.Location = new System.Drawing.Point(433, 43);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(707, 564);
            this.productsListBox.TabIndex = 9;
            // 
            // profitLabel
            // 
            this.profitLabel.AutoSize = true;
            this.profitLabel.Location = new System.Drawing.Point(321, 180);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(41, 17);
            this.profitLabel.TabIndex = 10;
            this.profitLabel.Text = "Profit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Назва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Дата виготовлення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Свідоцтво якості";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Вартість";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Націнка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Термін придатності";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 691);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profitLabel);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.calculateProfitButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.expirationDateTextBox);
            this.Controls.Add(this.markupTextBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.qualityCertificateTextBox);
            this.Controls.Add(this.manufacturingDateTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox manufacturingDateTextBox;
        private System.Windows.Forms.TextBox qualityCertificateTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox expirationDateTextBox;
        private System.Windows.Forms.TextBox markupTextBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button calculateProfitButton;
        private System.Windows.Forms.ListBox productsListBox;
        private System.Windows.Forms.Label profitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

