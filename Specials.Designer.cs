namespace COMPortTerminal
{
    partial class Specials
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
            this.boxSpcList = new System.Windows.Forms.ListBox();
            this.boxOrders = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxSpcList
            // 
            this.boxSpcList.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.boxSpcList.FormattingEnabled = true;
            this.boxSpcList.ItemHeight = 29;
            this.boxSpcList.Location = new System.Drawing.Point(12, 12);
            this.boxSpcList.Name = "boxSpcList";
            this.boxSpcList.Size = new System.Drawing.Size(319, 265);
            this.boxSpcList.TabIndex = 0;
            this.boxSpcList.SelectedIndexChanged += new System.EventHandler(this.boxSpcList_SelectedIndexChanged);
            // 
            // boxOrders
            // 
            this.boxOrders.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.boxOrders.FormattingEnabled = true;
            this.boxOrders.ItemHeight = 29;
            this.boxOrders.Location = new System.Drawing.Point(458, 12);
            this.boxOrders.Name = "boxOrders";
            this.boxOrders.Size = new System.Drawing.Size(319, 265);
            this.boxOrders.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.Add.Location = new System.Drawing.Point(357, 74);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(74, 41);
            this.Add.TabIndex = 2;
            this.Add.Text = ">>>";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.Remove.Location = new System.Drawing.Point(357, 141);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(74, 41);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "<<<";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Done
            // 
            this.Done.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.Done.Location = new System.Drawing.Point(672, 284);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(105, 42);
            this.Done.TabIndex = 4;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Specials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 331);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.boxOrders);
            this.Controls.Add(this.boxSpcList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Specials";
            this.Text = "Specials";
            this.Load += new System.EventHandler(this.Specials_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox boxSpcList;
        private System.Windows.Forms.ListBox boxOrders;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Done;
    }
}