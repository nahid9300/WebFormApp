namespace CoffeShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.orderBox = new System.Windows.Forms.ComboBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.showLabel13 = new System.Windows.Forms.Label();
            this.showLabel14 = new System.Windows.Forms.Label();
            this.showLabel15 = new System.Windows.Forms.Label();
            this.showLabel16 = new System.Windows.Forms.Label();
            this.showLabel17 = new System.Windows.Forms.Label();
            this.showLabel18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(77, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(258, 340);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(214, 105);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(157, 20);
            this.nameBox.TabIndex = 7;
            // 
            // contactBox
            // 
            this.contactBox.Location = new System.Drawing.Point(214, 145);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(157, 20);
            this.contactBox.TabIndex = 8;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(214, 182);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(157, 20);
            this.addressBox.TabIndex = 9;
            // 
            // orderBox
            // 
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.orderBox.Location = new System.Drawing.Point(214, 247);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(157, 21);
            this.orderBox.TabIndex = 10;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(214, 289);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(157, 20);
            this.quantityBox.TabIndex = 11;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(489, 67);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(249, 296);
            this.outputBox.TabIndex = 12;
            this.outputBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Name: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(532, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Contact No: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Order: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(532, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Quantity: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(531, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total Price: ";
            // 
            // showLabel13
            // 
            this.showLabel13.AutoSize = true;
            this.showLabel13.Location = new System.Drawing.Point(579, 108);
            this.showLabel13.Name = "showLabel13";
            this.showLabel13.Size = new System.Drawing.Size(0, 13);
            this.showLabel13.TabIndex = 19;
            // 
            // showLabel14
            // 
            this.showLabel14.AutoSize = true;
            this.showLabel14.Location = new System.Drawing.Point(616, 147);
            this.showLabel14.Name = "showLabel14";
            this.showLabel14.Size = new System.Drawing.Size(0, 13);
            this.showLabel14.TabIndex = 20;
            // 
            // showLabel15
            // 
            this.showLabel15.AutoSize = true;
            this.showLabel15.Location = new System.Drawing.Point(595, 184);
            this.showLabel15.Name = "showLabel15";
            this.showLabel15.Size = new System.Drawing.Size(0, 13);
            this.showLabel15.TabIndex = 21;
            // 
            // showLabel16
            // 
            this.showLabel16.AutoSize = true;
            this.showLabel16.Location = new System.Drawing.Point(598, 213);
            this.showLabel16.Name = "showLabel16";
            this.showLabel16.Size = new System.Drawing.Size(0, 13);
            this.showLabel16.TabIndex = 22;
            // 
            // showLabel17
            // 
            this.showLabel17.AutoSize = true;
            this.showLabel17.Location = new System.Drawing.Point(595, 249);
            this.showLabel17.Name = "showLabel17";
            this.showLabel17.Size = new System.Drawing.Size(0, 13);
            this.showLabel17.TabIndex = 23;
            // 
            // showLabel18
            // 
            this.showLabel18.AutoSize = true;
            this.showLabel18.Location = new System.Drawing.Point(619, 277);
            this.showLabel18.Name = "showLabel18";
            this.showLabel18.Size = new System.Drawing.Size(0, 13);
            this.showLabel18.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showLabel18);
            this.Controls.Add(this.showLabel17);
            this.Controls.Add(this.showLabel16);
            this.Controls.Add(this.showLabel15);
            this.Controls.Add(this.showLabel14);
            this.Controls.Add(this.showLabel13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.ComboBox orderBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label showLabel13;
        private System.Windows.Forms.Label showLabel14;
        private System.Windows.Forms.Label showLabel15;
        private System.Windows.Forms.Label showLabel16;
        private System.Windows.Forms.Label showLabel17;
        private System.Windows.Forms.Label showLabel18;
    }
}

