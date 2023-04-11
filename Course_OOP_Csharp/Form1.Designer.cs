
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
            this.SuspendLayout();
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(102, 43);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.productNameTextBox.TabIndex = 0;
            // 
            // manufacturingDateTextBox
            // 
            this.manufacturingDateTextBox.Location = new System.Drawing.Point(102, 99);
            this.manufacturingDateTextBox.Name = "manufacturingDateTextBox";
            this.manufacturingDateTextBox.Size = new System.Drawing.Size(100, 22);
            this.manufacturingDateTextBox.TabIndex = 1;
            // 
            // qualityCertificateTextBox
            // 
            this.qualityCertificateTextBox.Location = new System.Drawing.Point(102, 159);
            this.qualityCertificateTextBox.Name = "qualityCertificateTextBox";
            this.qualityCertificateTextBox.Size = new System.Drawing.Size(100, 22);
            this.qualityCertificateTextBox.TabIndex = 2;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(102, 226);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 22);
            this.costTextBox.TabIndex = 3;
            // 
            // expirationDateTextBox
            // 
            this.expirationDateTextBox.Location = new System.Drawing.Point(102, 332);
            this.expirationDateTextBox.Name = "expirationDateTextBox";
            this.expirationDateTextBox.Size = new System.Drawing.Size(100, 22);
            this.expirationDateTextBox.TabIndex = 6;
            // 
            // markupTextBox
            // 
            this.markupTextBox.Location = new System.Drawing.Point(102, 280);
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
            this.calculateProfitButton.Size = new System.Drawing.Size(75, 23);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 691);
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
    }
}

