
namespace IznajmuvanjeApartmani
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
            this.addApartment = new System.Windows.Forms.Button();
            this.deleteCity = new System.Windows.Forms.Button();
            this.addCity = new System.Windows.Forms.Button();
            this.cityList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cheapersApartment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aratmentList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addApartment);
            this.groupBox1.Controls.Add(this.deleteCity);
            this.groupBox1.Controls.Add(this.addCity);
            this.groupBox1.Controls.Add(this.cityList);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gradovi";
            // 
            // addApartment
            // 
            this.addApartment.Location = new System.Drawing.Point(7, 364);
            this.addApartment.Name = "addApartment";
            this.addApartment.Size = new System.Drawing.Size(338, 23);
            this.addApartment.TabIndex = 3;
            this.addApartment.Text = "Dodadi Apartman";
            this.addApartment.UseVisualStyleBackColor = true;
            // 
            // deleteCity
            // 
            this.deleteCity.Location = new System.Drawing.Point(7, 334);
            this.deleteCity.Name = "deleteCity";
            this.deleteCity.Size = new System.Drawing.Size(338, 23);
            this.deleteCity.TabIndex = 2;
            this.deleteCity.Text = "Izbrisi Grad";
            this.deleteCity.UseVisualStyleBackColor = true;
            // 
            // addCity
            // 
            this.addCity.Location = new System.Drawing.Point(7, 304);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(338, 23);
            this.addCity.TabIndex = 1;
            this.addCity.Text = "Dodadi Grad";
            this.addCity.UseVisualStyleBackColor = true;
            // 
            // cityList
            // 
            this.cityList.FormattingEnabled = true;
            this.cityList.Location = new System.Drawing.Point(7, 20);
            this.cityList.Name = "cityList";
            this.cityList.Size = new System.Drawing.Size(338, 277);
            this.cityList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cheapersApartment);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.aratmentList);
            this.groupBox2.Location = new System.Drawing.Point(371, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apartmani";
            // 
            // cheapersApartment
            // 
            this.cheapersApartment.Location = new System.Drawing.Point(9, 326);
            this.cheapersApartment.Name = "cheapersApartment";
            this.cheapersApartment.ReadOnly = true;
            this.cheapersApartment.Size = new System.Drawing.Size(402, 20);
            this.cheapersApartment.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Najeftin apartman";
            // 
            // aratmentList
            // 
            this.aratmentList.FormattingEnabled = true;
            this.aratmentList.Location = new System.Drawing.Point(7, 20);
            this.aratmentList.Name = "aratmentList";
            this.aratmentList.Size = new System.Drawing.Size(404, 277);
            this.aratmentList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addApartment;
        private System.Windows.Forms.Button deleteCity;
        private System.Windows.Forms.Button addCity;
        private System.Windows.Forms.ListBox cityList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cheapersApartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox aratmentList;
    }
}

