namespace SchoolMasterClass
{
    partial class MenuBarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuBarForm));
            this.SelectGame = new System.Windows.Forms.ComboBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectGame
            // 
            this.SelectGame.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SelectGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.SelectGame.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SelectGame.FormattingEnabled = true;
            this.SelectGame.ItemHeight = 35;
            this.SelectGame.Items.AddRange(new object[] {
            "Змейка",
            "Рисовашка"});
            this.SelectGame.Location = new System.Drawing.Point(70, 124);
            this.SelectGame.Name = "SelectGame";
            this.SelectGame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SelectGame.Size = new System.Drawing.Size(352, 43);
            this.SelectGame.TabIndex = 0;
            this.SelectGame.Text = "Выбрать игру";
            this.SelectGame.SelectedValueChanged += new System.EventHandler(this.SelectGame_SelectedValueChanged);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.Location = new System.Drawing.Point(55, 19);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(693, 86);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Добро пожаловать!";
            // 
            // Start
            // 
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Enabled = false;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Start.FlatAppearance.BorderSize = 4;
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Start.Location = new System.Drawing.Point(429, 124);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(301, 43);
            this.Start.TabIndex = 2;
            this.Start.Text = "Играть";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // MenuBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(791, 202);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.SelectGame);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuBarForm";
            this.Text = "Выбор игр";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectGame;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button Start;
    }
}

