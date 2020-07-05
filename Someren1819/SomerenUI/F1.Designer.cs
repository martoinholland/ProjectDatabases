namespace SomerenUI
{
    partial class FormCashRegister
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
            this.comboBoxCashRegister = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDrinks = new System.Windows.Forms.ComboBox();
            this.btnCheckOutList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCashRegister
            // 
            this.comboBoxCashRegister.FormattingEnabled = true;
            this.comboBoxCashRegister.Location = new System.Drawing.Point(16, 69);
            this.comboBoxCashRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCashRegister.Name = "comboBoxCashRegister";
            this.comboBoxCashRegister.Size = new System.Drawing.Size(320, 24);
            this.comboBoxCashRegister.TabIndex = 0;
            this.comboBoxCashRegister.SelectedIndexChanged += new System.EventHandler(this.comboBoxCashRegister_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.Location = new System.Drawing.Point(16, 212);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(155, 62);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(16, 282);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(321, 62);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drinks";
            // 
            // comboBoxDrinks
            // 
            this.comboBoxDrinks.FormattingEnabled = true;
            this.comboBoxDrinks.Location = new System.Drawing.Point(16, 161);
            this.comboBoxDrinks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDrinks.Name = "comboBoxDrinks";
            this.comboBoxDrinks.Size = new System.Drawing.Size(320, 24);
            this.comboBoxDrinks.TabIndex = 5;
            this.comboBoxDrinks.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrinks_SelectedIndexChanged);
            // 
            // btnCheckOutList
            // 
            this.btnCheckOutList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOutList.Location = new System.Drawing.Point(183, 212);
            this.btnCheckOutList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOutList.Name = "btnCheckOutList";
            this.btnCheckOutList.Size = new System.Drawing.Size(155, 62);
            this.btnCheckOutList.TabIndex = 6;
            this.btnCheckOutList.Text = "List";
            this.btnCheckOutList.UseVisualStyleBackColor = true;
            this.btnCheckOutList.Click += new System.EventHandler(this.btnCheckOutList_Click);
            // 
            // FormCashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 358);
            this.Controls.Add(this.btnCheckOutList);
            this.Controls.Add(this.comboBoxDrinks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCashRegister);
            this.Location = new System.Drawing.Point(180, 180);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCashRegister";
            this.Text = "CashRegister";
            this.Load += new System.EventHandler(this.FormCashRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCashRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDrinks;
        private System.Windows.Forms.Button btnCheckOutList;
    }
}