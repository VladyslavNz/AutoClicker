namespace AutoClicker
{
    partial class AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            this.PanelExitMin = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.NamePanelExitMin = new System.Windows.Forms.Label();
            this.MainPanelAutoClicker = new System.Windows.Forms.Panel();
            this.groupBoxDobOne = new System.Windows.Forms.GroupBox();
            this.ButtonOne = new System.Windows.Forms.RadioButton();
            this.ButtonDouble = new System.Windows.Forms.RadioButton();
            this.groupBoxLeftRight = new System.Windows.Forms.GroupBox();
            this.ButtonRight = new System.Windows.Forms.RadioButton();
            this.ButtonLeft = new System.Windows.Forms.RadioButton();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.buttonPickLoc = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelSecs = new System.Windows.Forms.Label();
            this.labelMins = new System.Windows.Forms.Label();
            this.textBoxForSecs = new System.Windows.Forms.TextBox();
            this.textBoxForMins = new System.Windows.Forms.TextBox();
            this.PanelExitMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.MainPanelAutoClicker.SuspendLayout();
            this.groupBoxDobOne.SuspendLayout();
            this.groupBoxLeftRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelExitMin
            // 
            this.PanelExitMin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelExitMin.Controls.Add(this.pictureBoxExit);
            this.PanelExitMin.Controls.Add(this.NamePanelExitMin);
            this.PanelExitMin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelExitMin.Location = new System.Drawing.Point(0, 0);
            this.PanelExitMin.Name = "PanelExitMin";
            this.PanelExitMin.Size = new System.Drawing.Size(500, 30);
            this.PanelExitMin.TabIndex = 0;
            this.PanelExitMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelExitMin_MouseDown);
            this.PanelExitMin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelExitMin_MouseMove);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(458, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 1;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // NamePanelExitMin
            // 
            this.NamePanelExitMin.AutoSize = true;
            this.NamePanelExitMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.NamePanelExitMin.Location = new System.Drawing.Point(12, 3);
            this.NamePanelExitMin.Name = "NamePanelExitMin";
            this.NamePanelExitMin.Size = new System.Drawing.Size(106, 24);
            this.NamePanelExitMin.TabIndex = 1;
            this.NamePanelExitMin.Text = "AutoClicker";
            // 
            // MainPanelAutoClicker
            // 
            this.MainPanelAutoClicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.MainPanelAutoClicker.Controls.Add(this.groupBoxDobOne);
            this.MainPanelAutoClicker.Controls.Add(this.groupBoxLeftRight);
            this.MainPanelAutoClicker.Controls.Add(this.labelY);
            this.MainPanelAutoClicker.Controls.Add(this.labelX);
            this.MainPanelAutoClicker.Controls.Add(this.textBoxY);
            this.MainPanelAutoClicker.Controls.Add(this.textBoxX);
            this.MainPanelAutoClicker.Controls.Add(this.buttonPickLoc);
            this.MainPanelAutoClicker.Controls.Add(this.buttonStop);
            this.MainPanelAutoClicker.Controls.Add(this.buttonStart);
            this.MainPanelAutoClicker.Controls.Add(this.labelSecs);
            this.MainPanelAutoClicker.Controls.Add(this.labelMins);
            this.MainPanelAutoClicker.Controls.Add(this.textBoxForSecs);
            this.MainPanelAutoClicker.Controls.Add(this.textBoxForMins);
            this.MainPanelAutoClicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelAutoClicker.Location = new System.Drawing.Point(0, 30);
            this.MainPanelAutoClicker.Name = "MainPanelAutoClicker";
            this.MainPanelAutoClicker.Size = new System.Drawing.Size(500, 270);
            this.MainPanelAutoClicker.TabIndex = 1;
            // 
            // groupBoxDobOne
            // 
            this.groupBoxDobOne.Controls.Add(this.ButtonOne);
            this.groupBoxDobOne.Controls.Add(this.ButtonDouble);
            this.groupBoxDobOne.Location = new System.Drawing.Point(280, 79);
            this.groupBoxDobOne.Name = "groupBoxDobOne";
            this.groupBoxDobOne.Size = new System.Drawing.Size(168, 48);
            this.groupBoxDobOne.TabIndex = 12;
            this.groupBoxDobOne.TabStop = false;
            // 
            // ButtonOne
            // 
            this.ButtonOne.AutoSize = true;
            this.ButtonOne.Checked = true;
            this.ButtonOne.ForeColor = System.Drawing.SystemColors.Info;
            this.ButtonOne.Location = new System.Drawing.Point(16, 17);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(57, 20);
            this.ButtonOne.TabIndex = 2;
            this.ButtonOne.TabStop = true;
            this.ButtonOne.Text = "ONE";
            this.ButtonOne.UseVisualStyleBackColor = true;
            // 
            // ButtonDouble
            // 
            this.ButtonDouble.AutoSize = true;
            this.ButtonDouble.ForeColor = System.Drawing.SystemColors.Info;
            this.ButtonDouble.Location = new System.Drawing.Point(79, 17);
            this.ButtonDouble.Name = "ButtonDouble";
            this.ButtonDouble.Size = new System.Drawing.Size(83, 20);
            this.ButtonDouble.TabIndex = 2;
            this.ButtonDouble.Text = "DOUBLE";
            this.ButtonDouble.UseVisualStyleBackColor = true;
            // 
            // groupBoxLeftRight
            // 
            this.groupBoxLeftRight.Controls.Add(this.ButtonRight);
            this.groupBoxLeftRight.Controls.Add(this.ButtonLeft);
            this.groupBoxLeftRight.Location = new System.Drawing.Point(50, 79);
            this.groupBoxLeftRight.Name = "groupBoxLeftRight";
            this.groupBoxLeftRight.Size = new System.Drawing.Size(168, 48);
            this.groupBoxLeftRight.TabIndex = 11;
            this.groupBoxLeftRight.TabStop = false;
            // 
            // ButtonRight
            // 
            this.ButtonRight.AutoSize = true;
            this.ButtonRight.ForeColor = System.Drawing.SystemColors.Info;
            this.ButtonRight.Location = new System.Drawing.Point(83, 17);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(70, 20);
            this.ButtonRight.TabIndex = 1;
            this.ButtonRight.Text = "RIGHT";
            this.ButtonRight.UseVisualStyleBackColor = true;
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.AutoSize = true;
            this.ButtonLeft.Checked = true;
            this.ButtonLeft.ForeColor = System.Drawing.SystemColors.Info;
            this.ButtonLeft.Location = new System.Drawing.Point(16, 17);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(61, 20);
            this.ButtonLeft.TabIndex = 0;
            this.ButtonLeft.TabStop = true;
            this.ButtonLeft.Text = "LEFT";
            this.ButtonLeft.UseVisualStyleBackColor = true;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelY.ForeColor = System.Drawing.SystemColors.Info;
            this.labelY.Location = new System.Drawing.Point(160, 137);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(25, 25);
            this.labelY.TabIndex = 10;
            this.labelY.Text = "Y";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelX.ForeColor = System.Drawing.SystemColors.Info;
            this.labelX.Location = new System.Drawing.Point(77, 137);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(26, 25);
            this.labelX.TabIndex = 9;
            this.labelX.Text = "X";
            // 
            // textBoxY
            // 
            this.textBoxY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBoxY.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxY.Location = new System.Drawing.Point(133, 165);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(77, 34);
            this.textBoxY.TabIndex = 8;
            this.textBoxY.Text = "0";
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBoxX.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxX.Location = new System.Drawing.Point(50, 165);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(77, 34);
            this.textBoxX.TabIndex = 7;
            this.textBoxX.Text = "0";
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPickLoc
            // 
            this.buttonPickLoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPickLoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonPickLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPickLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPickLoc.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonPickLoc.Location = new System.Drawing.Point(280, 158);
            this.buttonPickLoc.Name = "buttonPickLoc";
            this.buttonPickLoc.Size = new System.Drawing.Size(168, 41);
            this.buttonPickLoc.TabIndex = 6;
            this.buttonPickLoc.Text = "Pick Location(F3)";
            this.buttonPickLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPickLoc.UseVisualStyleBackColor = true;
            this.buttonPickLoc.Click += new System.EventHandler(this.buttonPickLoc_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonStop.Location = new System.Drawing.Point(280, 217);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(168, 41);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "STOP(F10)";
            this.buttonStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonStart.Location = new System.Drawing.Point(50, 217);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(160, 41);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "START(F2)";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelSecs
            // 
            this.labelSecs.AutoSize = true;
            this.labelSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelSecs.ForeColor = System.Drawing.SystemColors.Info;
            this.labelSecs.Location = new System.Drawing.Point(386, 46);
            this.labelSecs.Name = "labelSecs";
            this.labelSecs.Size = new System.Drawing.Size(68, 25);
            this.labelSecs.TabIndex = 3;
            this.labelSecs.Text = "SECS";
            // 
            // labelMins
            // 
            this.labelMins.AutoSize = true;
            this.labelMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelMins.ForeColor = System.Drawing.SystemColors.Info;
            this.labelMins.Location = new System.Drawing.Point(156, 46);
            this.labelMins.Name = "labelMins";
            this.labelMins.Size = new System.Drawing.Size(62, 25);
            this.labelMins.TabIndex = 2;
            this.labelMins.Text = "MINS";
            // 
            // textBoxForSecs
            // 
            this.textBoxForSecs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxForSecs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxForSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBoxForSecs.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxForSecs.Location = new System.Drawing.Point(280, 29);
            this.textBoxForSecs.Name = "textBoxForSecs";
            this.textBoxForSecs.Size = new System.Drawing.Size(100, 42);
            this.textBoxForSecs.TabIndex = 1;
            this.textBoxForSecs.Text = "0";
            this.textBoxForSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxForSecs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForSecs_KeyPress);
            // 
            // textBoxForMins
            // 
            this.textBoxForMins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxForMins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxForMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBoxForMins.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxForMins.Location = new System.Drawing.Point(50, 29);
            this.textBoxForMins.Name = "textBoxForMins";
            this.textBoxForMins.Size = new System.Drawing.Size(100, 42);
            this.textBoxForMins.TabIndex = 0;
            this.textBoxForMins.Text = "0";
            this.textBoxForMins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxForMins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForSecs_KeyPress);
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.MainPanelAutoClicker);
            this.Controls.Add(this.PanelExitMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoClicker";
            this.Text = "Form1";
            this.PanelExitMin.ResumeLayout(false);
            this.PanelExitMin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.MainPanelAutoClicker.ResumeLayout(false);
            this.MainPanelAutoClicker.PerformLayout();
            this.groupBoxDobOne.ResumeLayout(false);
            this.groupBoxDobOne.PerformLayout();
            this.groupBoxLeftRight.ResumeLayout(false);
            this.groupBoxLeftRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelExitMin;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label NamePanelExitMin;
        private System.Windows.Forms.Panel MainPanelAutoClicker;
        private System.Windows.Forms.Label labelMins;
        private System.Windows.Forms.TextBox textBoxForSecs;
        private System.Windows.Forms.TextBox textBoxForMins;
        private System.Windows.Forms.Label labelSecs;
        private System.Windows.Forms.Button buttonPickLoc;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.GroupBox groupBoxDobOne;
        private System.Windows.Forms.GroupBox groupBoxLeftRight;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.RadioButton ButtonOne;
        private System.Windows.Forms.RadioButton ButtonDouble;
        private System.Windows.Forms.RadioButton ButtonRight;
        private System.Windows.Forms.RadioButton ButtonLeft;
    }
}

