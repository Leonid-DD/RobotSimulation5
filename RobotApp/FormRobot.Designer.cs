namespace RobotApp
{
    partial class FormRobot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRobot));
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.buttonDownLeft = new System.Windows.Forms.Button();
            this.buttonUpLeft = new System.Windows.Forms.Button();
            this.buttonDownRight = new System.Windows.Forms.Button();
            this.buttonUpRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPercentEnergy = new System.Windows.Forms.TextBox();
            this.buttonChargeDown = new System.Windows.Forms.Button();
            this.buttonChargeUp = new System.Windows.Forms.Button();
            this.buttonRIGHT = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDOWN = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.pictureBoxGameField = new System.Windows.Forms.PictureBox();
            this.pictureBoxRobot = new System.Windows.Forms.PictureBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.groupBoxControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobot)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxControl.Controls.Add(this.labelSpeed);
            this.groupBoxControl.Controls.Add(this.textBoxSpeed);
            this.groupBoxControl.Controls.Add(this.buttonDownLeft);
            this.groupBoxControl.Controls.Add(this.buttonUpLeft);
            this.groupBoxControl.Controls.Add(this.buttonDownRight);
            this.groupBoxControl.Controls.Add(this.buttonUpRight);
            this.groupBoxControl.Controls.Add(this.label1);
            this.groupBoxControl.Controls.Add(this.textBoxPercentEnergy);
            this.groupBoxControl.Controls.Add(this.buttonChargeDown);
            this.groupBoxControl.Controls.Add(this.buttonChargeUp);
            this.groupBoxControl.Controls.Add(this.buttonRIGHT);
            this.groupBoxControl.Controls.Add(this.buttonUp);
            this.groupBoxControl.Controls.Add(this.buttonDOWN);
            this.groupBoxControl.Controls.Add(this.buttonLeft);
            this.groupBoxControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxControl.Location = new System.Drawing.Point(0, 0);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(204, 407);
            this.groupBoxControl.TabIndex = 0;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Панель управления";
            // 
            // buttonDownLeft
            // 
            this.buttonDownLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownLeft.Location = new System.Drawing.Point(15, 143);
            this.buttonDownLeft.Name = "buttonDownLeft";
            this.buttonDownLeft.Size = new System.Drawing.Size(54, 53);
            this.buttonDownLeft.TabIndex = 11;
            this.buttonDownLeft.Text = "DOWN LEFT";
            this.buttonDownLeft.UseVisualStyleBackColor = true;
            this.buttonDownLeft.Click += new System.EventHandler(this.buttonDownLeft_Click);
            // 
            // buttonUpLeft
            // 
            this.buttonUpLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpLeft.Location = new System.Drawing.Point(15, 25);
            this.buttonUpLeft.Name = "buttonUpLeft";
            this.buttonUpLeft.Size = new System.Drawing.Size(54, 53);
            this.buttonUpLeft.TabIndex = 10;
            this.buttonUpLeft.Text = "UP LEFT";
            this.buttonUpLeft.UseVisualStyleBackColor = true;
            this.buttonUpLeft.Click += new System.EventHandler(this.buttonUpLeft_Click);
            // 
            // buttonDownRight
            // 
            this.buttonDownRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownRight.Location = new System.Drawing.Point(135, 143);
            this.buttonDownRight.Name = "buttonDownRight";
            this.buttonDownRight.Size = new System.Drawing.Size(54, 53);
            this.buttonDownRight.TabIndex = 9;
            this.buttonDownRight.Text = "DOWN RIGHT";
            this.buttonDownRight.UseVisualStyleBackColor = true;
            this.buttonDownRight.Click += new System.EventHandler(this.buttonDownRight_Click);
            // 
            // buttonUpRight
            // 
            this.buttonUpRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpRight.Location = new System.Drawing.Point(135, 25);
            this.buttonUpRight.Name = "buttonUpRight";
            this.buttonUpRight.Size = new System.Drawing.Size(54, 53);
            this.buttonUpRight.TabIndex = 8;
            this.buttonUpRight.Text = "UP RIGHT";
            this.buttonUpRight.UseVisualStyleBackColor = true;
            this.buttonUpRight.Click += new System.EventHandler(this.buttonUpRight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "%";
            // 
            // textBoxPercentEnergy
            // 
            this.textBoxPercentEnergy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxPercentEnergy.Enabled = false;
            this.textBoxPercentEnergy.ForeColor = System.Drawing.Color.Blue;
            this.textBoxPercentEnergy.Location = new System.Drawing.Point(75, 358);
            this.textBoxPercentEnergy.Name = "textBoxPercentEnergy";
            this.textBoxPercentEnergy.Size = new System.Drawing.Size(122, 26);
            this.textBoxPercentEnergy.TabIndex = 6;
            // 
            // buttonChargeDown
            // 
            this.buttonChargeDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChargeDown.Location = new System.Drawing.Point(75, 321);
            this.buttonChargeDown.Name = "buttonChargeDown";
            this.buttonChargeDown.Size = new System.Drawing.Size(122, 31);
            this.buttonChargeDown.TabIndex = 5;
            this.buttonChargeDown.Text = "CHARGE DOWN";
            this.buttonChargeDown.UseVisualStyleBackColor = true;
            this.buttonChargeDown.Click += new System.EventHandler(this.buttonChargeDown_Click);
            // 
            // buttonChargeUp
            // 
            this.buttonChargeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChargeUp.Location = new System.Drawing.Point(75, 284);
            this.buttonChargeUp.Name = "buttonChargeUp";
            this.buttonChargeUp.Size = new System.Drawing.Size(122, 31);
            this.buttonChargeUp.TabIndex = 4;
            this.buttonChargeUp.Text = "CHARGE UP";
            this.buttonChargeUp.UseVisualStyleBackColor = true;
            this.buttonChargeUp.Click += new System.EventHandler(this.buttonChargeUp_Click);
            // 
            // buttonRIGHT
            // 
            this.buttonRIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRIGHT.Location = new System.Drawing.Point(135, 84);
            this.buttonRIGHT.Name = "buttonRIGHT";
            this.buttonRIGHT.Size = new System.Drawing.Size(54, 53);
            this.buttonRIGHT.TabIndex = 3;
            this.buttonRIGHT.Text = "RIGHT";
            this.buttonRIGHT.UseVisualStyleBackColor = true;
            this.buttonRIGHT.Click += new System.EventHandler(this.buttonRIGHT_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUp.Location = new System.Drawing.Point(75, 25);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(54, 53);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.Text = "UP";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDOWN
            // 
            this.buttonDOWN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDOWN.Location = new System.Drawing.Point(75, 143);
            this.buttonDOWN.Name = "buttonDOWN";
            this.buttonDOWN.Size = new System.Drawing.Size(54, 53);
            this.buttonDOWN.TabIndex = 1;
            this.buttonDOWN.Text = "DOWN";
            this.buttonDOWN.UseVisualStyleBackColor = true;
            this.buttonDOWN.Click += new System.EventHandler(this.buttonDOWN_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeft.Location = new System.Drawing.Point(15, 84);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(54, 53);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.Text = "LEFT";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // pictureBoxGameField
            // 
            this.pictureBoxGameField.BackColor = System.Drawing.Color.White;
            this.pictureBoxGameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGameField.Location = new System.Drawing.Point(204, 0);
            this.pictureBoxGameField.Name = "pictureBoxGameField";
            this.pictureBoxGameField.Size = new System.Drawing.Size(585, 407);
            this.pictureBoxGameField.TabIndex = 1;
            this.pictureBoxGameField.TabStop = false;
            // 
            // pictureBoxRobot
            // 
            this.pictureBoxRobot.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRobot.Image")));
            this.pictureBoxRobot.Location = new System.Drawing.Point(456, 171);
            this.pictureBoxRobot.Name = "pictureBoxRobot";
            this.pictureBoxRobot.Size = new System.Drawing.Size(72, 67);
            this.pictureBoxRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRobot.TabIndex = 2;
            this.pictureBoxRobot.TabStop = false;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxSpeed.Location = new System.Drawing.Point(75, 252);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(122, 26);
            this.textBoxSpeed.TabIndex = 12;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(13, 255);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(56, 20);
            this.labelSpeed.TabIndex = 13;
            this.labelSpeed.Text = "Speed";
            // 
            // FormRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 407);
            this.Controls.Add(this.pictureBoxRobot);
            this.Controls.Add(this.pictureBoxGameField);
            this.Controls.Add(this.groupBoxControl);
            this.Name = "FormRobot";
            this.Text = "Имитация работы робота";
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.PictureBox pictureBoxGameField;
        private System.Windows.Forms.PictureBox pictureBoxRobot;
        private System.Windows.Forms.Button buttonChargeDown;
        private System.Windows.Forms.Button buttonChargeUp;
        private System.Windows.Forms.Button buttonRIGHT;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDOWN;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.TextBox textBoxPercentEnergy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDownLeft;
        private System.Windows.Forms.Button buttonUpLeft;
        private System.Windows.Forms.Button buttonDownRight;
        private System.Windows.Forms.Button buttonUpRight;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TextBox textBoxSpeed;
    }
}

