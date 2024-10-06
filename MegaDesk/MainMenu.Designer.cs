namespace MegaDesk
{
    partial class MainMenu
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
            this.addQuoteBtn = new System.Windows.Forms.Button();
            this.viewQuotesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.searchQuotesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addQuoteBtn
            // 
            this.addQuoteBtn.AutoSize = true;
            this.addQuoteBtn.Location = new System.Drawing.Point(115, 55);
            this.addQuoteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addQuoteBtn.Name = "addQuoteBtn";
            this.addQuoteBtn.Size = new System.Drawing.Size(93, 23);
            this.addQuoteBtn.TabIndex = 0;
            this.addQuoteBtn.Text = "Add New Quote";
            this.addQuoteBtn.UseVisualStyleBackColor = true;
            this.addQuoteBtn.Click += new System.EventHandler(this.addQuoteBtn_Click_1);
            // 
            // viewQuotesBtn
            // 
            this.viewQuotesBtn.AutoSize = true;
            this.viewQuotesBtn.Location = new System.Drawing.Point(115, 86);
            this.viewQuotesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.viewQuotesBtn.Name = "viewQuotesBtn";
            this.viewQuotesBtn.Size = new System.Drawing.Size(77, 23);
            this.viewQuotesBtn.TabIndex = 1;
            this.viewQuotesBtn.Text = "View Quotes";
            this.viewQuotesBtn.UseVisualStyleBackColor = true;
            this.viewQuotesBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Location = new System.Drawing.Point(115, 156);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(73, 23);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // searchQuotesBtn
            // 
            this.searchQuotesBtn.AutoSize = true;
            this.searchQuotesBtn.Location = new System.Drawing.Point(115, 122);
            this.searchQuotesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchQuotesBtn.Name = "searchQuotesBtn";
            this.searchQuotesBtn.Size = new System.Drawing.Size(88, 23);
            this.searchQuotesBtn.TabIndex = 3;
            this.searchQuotesBtn.Text = "Search Quotes";
            this.searchQuotesBtn.UseVisualStyleBackColor = true;
            this.searchQuotesBtn.Click += new System.EventHandler(this.searchQuotesBtn_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.searchQuotesBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.viewQuotesBtn);
            this.Controls.Add(this.addQuoteBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "MegaDeskRamos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addQuoteBtn;
        private System.Windows.Forms.Button viewQuotesBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button searchQuotesBtn;
    }
}

