namespace WF
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Title = new System.Windows.Forms.Label();
            this.Monday = new System.Windows.Forms.Button();
            this.Tuesday = new System.Windows.Forms.Button();
            this.Wednesday = new System.Windows.Forms.Button();
            this.Thursday = new System.Windows.Forms.Button();
            this.Friday = new System.Windows.Forms.Button();
            this.Saturday = new System.Windows.Forms.Button();
            this.Sunday = new System.Windows.Forms.Button();
            this.Today = new System.Windows.Forms.Label();
            this.EditPlan = new System.Windows.Forms.Button();
            this.textBoxPlan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(104, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(286, 54);
            this.Title.TabIndex = 0;
            this.Title.Text = "Today is [day]:";
            // 
            // Monday
            // 
            this.Monday.Location = new System.Drawing.Point(12, 74);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(75, 23);
            this.Monday.TabIndex = 1;
            this.Monday.Tag = "dayOfWeek1";
            this.Monday.Text = "Monday";
            this.Monday.UseVisualStyleBackColor = true;
            // 
            // Tuesday
            // 
            this.Tuesday.Location = new System.Drawing.Point(93, 74);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(75, 23);
            this.Tuesday.TabIndex = 2;
            this.Tuesday.Tag = "dayOfWeek2";
            this.Tuesday.Text = "Tuesday";
            this.Tuesday.UseVisualStyleBackColor = true;
            // 
            // Wednesday
            // 
            this.Wednesday.Location = new System.Drawing.Point(174, 74);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(75, 23);
            this.Wednesday.TabIndex = 3;
            this.Wednesday.Tag = "dayOfWeek3";
            this.Wednesday.Text = "Wednesday";
            this.Wednesday.UseVisualStyleBackColor = true;
            // 
            // Thursday
            // 
            this.Thursday.Location = new System.Drawing.Point(255, 74);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(75, 23);
            this.Thursday.TabIndex = 4;
            this.Thursday.Tag = "dayOfWeek4";
            this.Thursday.Text = "Thursday";
            this.Thursday.UseVisualStyleBackColor = true;
            // 
            // Friday
            // 
            this.Friday.Location = new System.Drawing.Point(336, 74);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(75, 23);
            this.Friday.TabIndex = 5;
            this.Friday.Tag = "dayOfWeek5";
            this.Friday.Text = "Friday";
            this.Friday.UseVisualStyleBackColor = true;
            // 
            // Saturday
            // 
            this.Saturday.Location = new System.Drawing.Point(417, 74);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(75, 23);
            this.Saturday.TabIndex = 6;
            this.Saturday.Tag = "dayOfWeek6";
            this.Saturday.Text = "Saturday";
            this.Saturday.UseVisualStyleBackColor = true;
            // 
            // Sunday
            // 
            this.Sunday.Location = new System.Drawing.Point(501, 74);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(75, 23);
            this.Sunday.TabIndex = 7;
            this.Sunday.Tag = "dayOfWeek7";
            this.Sunday.Text = "Sunday";
            this.Sunday.UseVisualStyleBackColor = true;
            // 
            // Today
            // 
            this.Today.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Today.AutoSize = true;
            this.Today.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Today.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Today.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Today.Location = new System.Drawing.Point(144, 100);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(295, 37);
            this.Today.TabIndex = 8;
            this.Today.Text = "A plan for [chosenDay]";
            // 
            // EditPlan
            // 
            this.EditPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EditPlan.Location = new System.Drawing.Point(305, 542);
            this.EditPlan.Name = "EditPlan";
            this.EditPlan.Size = new System.Drawing.Size(271, 38);
            this.EditPlan.TabIndex = 10;
            this.EditPlan.Tag = "EditPlan";
            this.EditPlan.Text = "Edit plan";
            this.EditPlan.UseVisualStyleBackColor = true;
            this.EditPlan.Click += new System.EventHandler(this.EditPlan_Click);
            // 
            // textBoxPlan
            // 
            this.textBoxPlan.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold);
            this.textBoxPlan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPlan.Location = new System.Drawing.Point(5, 140);
            this.textBoxPlan.MaxLength = 300;
            this.textBoxPlan.Multiline = true;
            this.textBoxPlan.Name = "textBoxPlan";
            this.textBoxPlan.Size = new System.Drawing.Size(571, 397);
            this.textBoxPlan.TabIndex = 9;
            this.textBoxPlan.Text = resources.GetString("textBoxPlan.Text");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(5, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 38);
            this.button1.TabIndex = 11;
            this.button1.Tag = "Restart";
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Help
            // 
            this.Help.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Help.Location = new System.Drawing.Point(174, 542);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(111, 38);
            this.Help.TabIndex = 12;
            this.Help.Tag = "Help";
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 592);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EditPlan);
            this.Controls.Add(this.textBoxPlan);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.Title);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Monday;
        private System.Windows.Forms.Button Tuesday;
        private System.Windows.Forms.Button Wednesday;
        private System.Windows.Forms.Button Thursday;
        private System.Windows.Forms.Button Friday;
        private System.Windows.Forms.Button Saturday;
        private System.Windows.Forms.Button Sunday;
        private System.Windows.Forms.Label Today;
        private System.Windows.Forms.Button EditPlan;
        private System.Windows.Forms.TextBox textBoxPlan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Help;
    }
}

