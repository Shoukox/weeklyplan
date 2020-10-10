namespace WF
{
    partial class Help
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
            this.HelpText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelpText
            // 
            this.HelpText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HelpText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HelpText.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HelpText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HelpText.Location = new System.Drawing.Point(12, 12);
            this.HelpText.Multiline = true;
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(256, 292);
            this.HelpText.TabIndex = 0;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 316);
            this.Controls.Add(this.HelpText);
            this.Name = "Help";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HelpText;
    }
}