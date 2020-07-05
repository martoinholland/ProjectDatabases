namespace SomerenUI
{
    partial class F2
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
            this.listViewCheckOut = new System.Windows.Forms.ListView();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewCheckOut
            // 
            this.listViewCheckOut.Location = new System.Drawing.Point(16, 15);
            this.listViewCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewCheckOut.Name = "listViewCheckOut";
            this.listViewCheckOut.Size = new System.Drawing.Size(472, 403);
            this.listViewCheckOut.TabIndex = 0;
            this.listViewCheckOut.UseCompatibleStateImageBehavior = false;
            this.listViewCheckOut.SelectedIndexChanged += new System.EventHandler(this.listViewCheckOut_SelectedIndexChanged);
            // 
            // btnExit1
            // 
            this.btnExit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnExit1.Location = new System.Drawing.Point(145, 426);
            this.btnExit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(215, 42);
            this.btnExit1.TabIndex = 1;
            this.btnExit1.Text = "Exit";
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // F2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 479);
            this.Controls.Add(this.btnExit1);
            this.Controls.Add(this.listViewCheckOut);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F2";
            this.Text = "Check out list";
            this.Load += new System.EventHandler(this.F2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCheckOut;
        private System.Windows.Forms.Button btnExit1;
    }
}