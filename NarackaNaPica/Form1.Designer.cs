
namespace NarackaNaPica
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sSize = new System.Windows.Forms.RadioButton();
            this.mSize = new System.Windows.Forms.RadioButton();
            this.lSize = new System.Windows.Forms.RadioButton();
            this.sPrize = new System.Windows.Forms.TextBox();
            this.mPrize = new System.Windows.Forms.TextBox();
            this.lPrize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vkupnoZaNaplata = new System.Windows.Forms.TextBox();
            this.naplateno = new System.Windows.Forms.TextBox();
            this.zaVrakanje = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lPrize);
            this.groupBox1.Controls.Add(this.mPrize);
            this.groupBox1.Controls.Add(this.sPrize);
            this.groupBox1.Controls.Add(this.lSize);
            this.groupBox1.Controls.Add(this.mSize);
            this.groupBox1.Controls.Add(this.sSize);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Golemina";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(393, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodatoci";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(13, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pijalok";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(12, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 182);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Desert";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.zaVrakanje);
            this.groupBox5.Controls.Add(this.naplateno);
            this.groupBox5.Controls.Add(this.vkupnoZaNaplata);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(393, 256);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(395, 182);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Naplata";
            // 
            // sSize
            // 
            this.sSize.AutoSize = true;
            this.sSize.Location = new System.Drawing.Point(7, 20);
            this.sSize.Name = "sSize";
            this.sSize.Size = new System.Drawing.Size(48, 17);
            this.sSize.TabIndex = 0;
            this.sSize.TabStop = true;
            this.sSize.Text = "Mala";
            this.sSize.UseVisualStyleBackColor = true;
            this.sSize.CheckedChanged += new System.EventHandler(this.sSize_CheckedChanged);
            // 
            // mSize
            // 
            this.mSize.AutoSize = true;
            this.mSize.Location = new System.Drawing.Point(7, 44);
            this.mSize.Name = "mSize";
            this.mSize.Size = new System.Drawing.Size(59, 17);
            this.mSize.TabIndex = 1;
            this.mSize.TabStop = true;
            this.mSize.Text = "Sredna";
            this.mSize.UseVisualStyleBackColor = true;
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Location = new System.Drawing.Point(7, 68);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(61, 17);
            this.lSize.TabIndex = 2;
            this.lSize.TabStop = true;
            this.lSize.Text = "Golema";
            this.lSize.UseVisualStyleBackColor = true;
            // 
            // sPrize
            // 
            this.sPrize.Location = new System.Drawing.Point(258, 20);
            this.sPrize.Name = "sPrize";
            this.sPrize.Size = new System.Drawing.Size(100, 20);
            this.sPrize.TabIndex = 3;
            this.sPrize.Text = "200";
            // 
            // mPrize
            // 
            this.mPrize.Location = new System.Drawing.Point(258, 47);
            this.mPrize.Name = "mPrize";
            this.mPrize.Size = new System.Drawing.Size(100, 20);
            this.mPrize.TabIndex = 4;
            this.mPrize.Text = "300";
            // 
            // lPrize
            // 
            this.lPrize.Location = new System.Drawing.Point(258, 74);
            this.lPrize.Name = "lPrize";
            this.lPrize.Size = new System.Drawing.Size(100, 20);
            this.lPrize.TabIndex = 5;
            this.lPrize.Text = "500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bkupno za Naplata:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naplateno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Za vrakanje:";
            // 
            // vkupnoZaNaplata
            // 
            this.vkupnoZaNaplata.Location = new System.Drawing.Point(223, 12);
            this.vkupnoZaNaplata.Name = "vkupnoZaNaplata";
            this.vkupnoZaNaplata.ReadOnly = true;
            this.vkupnoZaNaplata.Size = new System.Drawing.Size(100, 20);
            this.vkupnoZaNaplata.TabIndex = 3;
            this.vkupnoZaNaplata.Text = "0";
            // 
            // naplateno
            // 
            this.naplateno.Location = new System.Drawing.Point(223, 29);
            this.naplateno.Name = "naplateno";
            this.naplateno.Size = new System.Drawing.Size(100, 20);
            this.naplateno.TabIndex = 4;
            // 
            // zaVrakanje
            // 
            this.zaVrakanje.Location = new System.Drawing.Point(223, 46);
            this.zaVrakanje.Name = "zaVrakanje";
            this.zaVrakanje.ReadOnly = true;
            this.zaVrakanje.Size = new System.Drawing.Size(100, 20);
            this.zaVrakanje.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lPrize;
        private System.Windows.Forms.TextBox mPrize;
        private System.Windows.Forms.TextBox sPrize;
        private System.Windows.Forms.RadioButton lSize;
        private System.Windows.Forms.RadioButton mSize;
        private System.Windows.Forms.RadioButton sSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox zaVrakanje;
        private System.Windows.Forms.TextBox naplateno;
        private System.Windows.Forms.TextBox vkupnoZaNaplata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

