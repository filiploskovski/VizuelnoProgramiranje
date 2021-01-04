
namespace PotrosuvackaKosnicka
{
    partial class AddProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.productNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productCategoryText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productPriceText = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.addToProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // productNameText
            // 
            this.productNameText.Location = new System.Drawing.Point(13, 30);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(260, 20);
            this.productNameText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategorija";
            // 
            // productCategoryText
            // 
            this.productCategoryText.Location = new System.Drawing.Point(13, 74);
            this.productCategoryText.Name = "productCategoryText";
            this.productCategoryText.Size = new System.Drawing.Size(260, 20);
            this.productCategoryText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cena";
            // 
            // productPriceText
            // 
            this.productPriceText.Location = new System.Drawing.Point(13, 118);
            this.productPriceText.Name = "productPriceText";
            this.productPriceText.Size = new System.Drawing.Size(150, 20);
            this.productPriceText.TabIndex = 5;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(117, 144);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Otkazi";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // addToProducts
            // 
            this.addToProducts.Location = new System.Drawing.Point(198, 144);
            this.addToProducts.Name = "addToProducts";
            this.addToProducts.Size = new System.Drawing.Size(75, 23);
            this.addToProducts.TabIndex = 7;
            this.addToProducts.Text = "Dodadi";
            this.addToProducts.UseVisualStyleBackColor = true;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 179);
            this.Controls.Add(this.addToProducts);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.productPriceText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productCategoryText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productNameText);
            this.Controls.Add(this.label1);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productCategoryText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productPriceText;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button addToProducts;
    }
}