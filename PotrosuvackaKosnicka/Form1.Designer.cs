
namespace PotrosuvackaKosnicka
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.productList = new System.Windows.Forms.ListBox();
            this.deleteProductsList = new System.Windows.Forms.Button();
            this.labelProductName = new System.Windows.Forms.Label();
            this.productNameText = new System.Windows.Forms.TextBox();
            this.labelProductCategory = new System.Windows.Forms.Label();
            this.productCategoryText = new System.Windows.Forms.TextBox();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.productPriceText = new System.Windows.Forms.TextBox();
            this.addToCard = new System.Windows.Forms.Button();
            this.removeFromCard = new System.Windows.Forms.Button();
            this.addNewProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.cardList = new System.Windows.Forms.ListBox();
            this.totalInCardLabel = new System.Windows.Forms.Label();
            this.totalInCardText = new System.Windows.Forms.TextBox();
            this.removeAllFromCard = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteProductsList);
            this.groupBox1.Controls.Add(this.productList);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista na produkti";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteProduct);
            this.groupBox2.Controls.Add(this.addNewProduct);
            this.groupBox2.Controls.Add(this.removeFromCard);
            this.groupBox2.Controls.Add(this.addToCard);
            this.groupBox2.Controls.Add(this.productPriceText);
            this.groupBox2.Controls.Add(this.labelProductPrice);
            this.groupBox2.Controls.Add(this.productCategoryText);
            this.groupBox2.Controls.Add(this.labelProductCategory);
            this.groupBox2.Controls.Add(this.productNameText);
            this.groupBox2.Controls.Add(this.labelProductName);
            this.groupBox2.Location = new System.Drawing.Point(275, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 383);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detali za produktot";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.removeAllFromCard);
            this.groupBox3.Controls.Add(this.totalInCardText);
            this.groupBox3.Controls.Add(this.totalInCardLabel);
            this.groupBox3.Controls.Add(this.cardList);
            this.groupBox3.Location = new System.Drawing.Point(524, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 425);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kosnicka";
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(7, 20);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(243, 355);
            this.productList.TabIndex = 0;
            // 
            // deleteProductsList
            // 
            this.deleteProductsList.Location = new System.Drawing.Point(7, 396);
            this.deleteProductsList.Name = "deleteProductsList";
            this.deleteProductsList.Size = new System.Drawing.Size(243, 23);
            this.deleteProductsList.TabIndex = 1;
            this.deleteProductsList.Text = "Istazni ja listata so produkti";
            this.deleteProductsList.UseVisualStyleBackColor = true;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(7, 30);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(24, 13);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Ime";
            // 
            // productNameText
            // 
            this.productNameText.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.productNameText.Location = new System.Drawing.Point(10, 47);
            this.productNameText.Name = "productNameText";
            this.productNameText.ReadOnly = true;
            this.productNameText.Size = new System.Drawing.Size(226, 20);
            this.productNameText.TabIndex = 1;
            // 
            // labelProductCategory
            // 
            this.labelProductCategory.AutoSize = true;
            this.labelProductCategory.Location = new System.Drawing.Point(10, 74);
            this.labelProductCategory.Name = "labelProductCategory";
            this.labelProductCategory.Size = new System.Drawing.Size(54, 13);
            this.labelProductCategory.TabIndex = 2;
            this.labelProductCategory.Text = "Kategorija";
            // 
            // productCategoryText
            // 
            this.productCategoryText.Location = new System.Drawing.Point(10, 91);
            this.productCategoryText.Name = "productCategoryText";
            this.productCategoryText.ReadOnly = true;
            this.productCategoryText.Size = new System.Drawing.Size(226, 20);
            this.productCategoryText.TabIndex = 3;
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Location = new System.Drawing.Point(13, 118);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(32, 13);
            this.labelProductPrice.TabIndex = 4;
            this.labelProductPrice.Text = "Cena";
            // 
            // productPriceText
            // 
            this.productPriceText.Location = new System.Drawing.Point(10, 135);
            this.productPriceText.Name = "productPriceText";
            this.productPriceText.ReadOnly = true;
            this.productPriceText.Size = new System.Drawing.Size(226, 20);
            this.productPriceText.TabIndex = 5;
            // 
            // addToCard
            // 
            this.addToCard.Location = new System.Drawing.Point(10, 185);
            this.addToCard.Name = "addToCard";
            this.addToCard.Size = new System.Drawing.Size(226, 23);
            this.addToCard.TabIndex = 6;
            this.addToCard.Text = "Dodadi vo kosnicka";
            this.addToCard.UseVisualStyleBackColor = true;
            // 
            // removeFromCard
            // 
            this.removeFromCard.Location = new System.Drawing.Point(10, 215);
            this.removeFromCard.Name = "removeFromCard";
            this.removeFromCard.Size = new System.Drawing.Size(226, 23);
            this.removeFromCard.TabIndex = 7;
            this.removeFromCard.Text = "Izbrisi od kosnicka";
            this.removeFromCard.UseVisualStyleBackColor = true;
            // 
            // addNewProduct
            // 
            this.addNewProduct.Location = new System.Drawing.Point(10, 245);
            this.addNewProduct.Name = "addNewProduct";
            this.addNewProduct.Size = new System.Drawing.Size(226, 23);
            this.addNewProduct.TabIndex = 8;
            this.addNewProduct.Text = "Dodadi nov produkt";
            this.addNewProduct.UseVisualStyleBackColor = true;
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(10, 275);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(226, 23);
            this.deleteProduct.TabIndex = 9;
            this.deleteProduct.Text = "Izbrsi produkt";
            this.deleteProduct.UseVisualStyleBackColor = true;
            // 
            // cardList
            // 
            this.cardList.FormattingEnabled = true;
            this.cardList.Location = new System.Drawing.Point(7, 20);
            this.cardList.Name = "cardList";
            this.cardList.Size = new System.Drawing.Size(251, 329);
            this.cardList.TabIndex = 0;
            // 
            // totalInCardLabel
            // 
            this.totalInCardLabel.AutoSize = true;
            this.totalInCardLabel.Location = new System.Drawing.Point(7, 361);
            this.totalInCardLabel.Name = "totalInCardLabel";
            this.totalInCardLabel.Size = new System.Drawing.Size(44, 13);
            this.totalInCardLabel.TabIndex = 1;
            this.totalInCardLabel.Text = "Vkupno";
            // 
            // totalInCardText
            // 
            this.totalInCardText.Location = new System.Drawing.Point(58, 361);
            this.totalInCardText.Name = "totalInCardText";
            this.totalInCardText.ReadOnly = true;
            this.totalInCardText.Size = new System.Drawing.Size(200, 20);
            this.totalInCardText.TabIndex = 2;
            this.totalInCardText.Text = "0";
            // 
            // removeAllFromCard
            // 
            this.removeAllFromCard.Location = new System.Drawing.Point(7, 396);
            this.removeAllFromCard.Name = "removeAllFromCard";
            this.removeAllFromCard.Size = new System.Drawing.Size(248, 23);
            this.removeAllFromCard.TabIndex = 3;
            this.removeAllFromCard.Text = "Isprazni ja kosnickata ?";
            this.removeAllFromCard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteProductsList;
        private System.Windows.Forms.ListBox productList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button addNewProduct;
        private System.Windows.Forms.Button removeFromCard;
        private System.Windows.Forms.Button addToCard;
        private System.Windows.Forms.TextBox productPriceText;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.TextBox productCategoryText;
        private System.Windows.Forms.Label labelProductCategory;
        private System.Windows.Forms.TextBox productNameText;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button removeAllFromCard;
        private System.Windows.Forms.TextBox totalInCardText;
        private System.Windows.Forms.Label totalInCardLabel;
        private System.Windows.Forms.ListBox cardList;
    }
}

