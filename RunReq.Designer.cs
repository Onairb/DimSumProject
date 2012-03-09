namespace COMPortTerminal
{
    partial class RunReq
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
            this.boxRunReq = new System.Windows.Forms.ListBox();
            this.butClose = new System.Windows.Forms.Button();
            this.butBeep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxRunReq
            // 
            this.boxRunReq.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.boxRunReq.FormattingEnabled = true;
            this.boxRunReq.ItemHeight = 29;
            this.boxRunReq.Location = new System.Drawing.Point(10, 13);
            this.boxRunReq.Name = "boxRunReq";
            this.boxRunReq.Size = new System.Drawing.Size(319, 265);
            this.boxRunReq.TabIndex = 0;
            this.boxRunReq.SelectedIndexChanged += new System.EventHandler(this.boxRunReq_SelectedIndexChanged);
            // 
            // butClose
            // 
            this.butClose.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.butClose.Location = new System.Drawing.Point(231, 284);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(105, 42);
            this.butClose.TabIndex = 1;
            this.butClose.Text = "Close";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butBeep
            // 
            this.butBeep.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.butBeep.Location = new System.Drawing.Point(12, 284);
            this.butBeep.Name = "butBeep";
            this.butBeep.Size = new System.Drawing.Size(105, 42);
            this.butBeep.TabIndex = 2;
            this.butBeep.Text = "BEEP";
            this.butBeep.UseVisualStyleBackColor = true;
            this.butBeep.Click += new System.EventHandler(this.butBeep_Click);
            // 
            // RunReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 337);
            this.Controls.Add(this.butBeep);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.boxRunReq);
            this.Name = "RunReq";
            this.Text = "RunReq";
            this.Load += new System.EventHandler(this.RunReq_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox boxRunReq;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butBeep;
    }
}