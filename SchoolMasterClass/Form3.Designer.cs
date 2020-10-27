namespace SchoolMasterClass
{
    partial class PaintForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxYellow = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.BackToMenu);
            this.panel.Controls.Add(this.buttonLoad);
            this.panel.Controls.Add(this.buttonSave);
            this.panel.Controls.Add(this.buttonClear);
            this.panel.Controls.Add(this.trackBarSize);
            this.panel.Controls.Add(this.pictureBoxGreen);
            this.panel.Controls.Add(this.pictureBoxYellow);
            this.panel.Controls.Add(this.pictureBoxBlue);
            this.panel.Controls.Add(this.pictureBoxRed);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(106, 500);
            this.panel.TabIndex = 0;
            // 
            // BackToMenu
            // 
            this.BackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMenu.Location = new System.Drawing.Point(9, 465);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(92, 23);
            this.BackToMenu.TabIndex = 6;
            this.BackToMenu.Text = "Выйти";
            this.BackToMenu.UseVisualStyleBackColor = true;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(9, 294);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(92, 19);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(9, 271);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 7, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 19);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(9, 242);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(92, 19);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(9, 192);
            this.trackBarSize.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarSize.Minimum = 1;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(92, 45);
            this.trackBarSize.TabIndex = 2;
            this.trackBarSize.Value = 1;
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.BackColor = System.Drawing.Color.Green;
            this.pictureBoxGreen.Location = new System.Drawing.Point(9, 55);
            this.pictureBoxGreen.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(92, 41);
            this.pictureBoxGreen.TabIndex = 3;
            this.pictureBoxGreen.TabStop = false;
            // 
            // pictureBoxYellow
            // 
            this.pictureBoxYellow.BackColor = System.Drawing.Color.Yellow;
            this.pictureBoxYellow.Location = new System.Drawing.Point(9, 101);
            this.pictureBoxYellow.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxYellow.Name = "pictureBoxYellow";
            this.pictureBoxYellow.Size = new System.Drawing.Size(92, 41);
            this.pictureBoxYellow.TabIndex = 2;
            this.pictureBoxYellow.TabStop = false;
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxBlue.Location = new System.Drawing.Point(9, 146);
            this.pictureBoxBlue.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(92, 41);
            this.pictureBoxBlue.TabIndex = 1;
            this.pictureBoxBlue.TabStop = false;
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.BackColor = System.Drawing.Color.Red;
            this.pictureBoxRed.Location = new System.Drawing.Point(9, 10);
            this.pictureBoxRed.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(92, 41);
            this.pictureBoxRed.TabIndex = 0;
            this.pictureBoxRed.TabStop = false;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.Location = new System.Drawing.Point(106, 0);
            this.pictureBoxMain.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(701, 500);
            this.pictureBoxMain.TabIndex = 1;
            this.pictureBoxMain.TabStop = false;
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PaintForm";
            this.Text = "Paint";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.PictureBox pictureBoxYellow;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button BackToMenu;
    }
}