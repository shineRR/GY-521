namespace GyroL5
{
    partial class Form1
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
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.startMonitoringButton = new System.Windows.Forms.Button();
            this.stopMonitoringButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.gxTextBox = new System.Windows.Forms.TextBox();
            this.gyTextBox = new System.Windows.Forms.TextBox();
            this.gzTextBox = new System.Windows.Forms.TextBox();
            this.gxLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.azTextBox = new System.Windows.Forms.TextBox();
            this.ayTextBox = new System.Windows.Forms.TextBox();
            this.axTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // portComboBox
            // 
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(35, 33);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(144, 21);
            this.portComboBox.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refresh ports";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // startMonitoringButton
            // 
            this.startMonitoringButton.Location = new System.Drawing.Point(35, 137);
            this.startMonitoringButton.Name = "startMonitoringButton";
            this.startMonitoringButton.Size = new System.Drawing.Size(144, 37);
            this.startMonitoringButton.TabIndex = 4;
            this.startMonitoringButton.Text = "Start Monitoring";
            this.startMonitoringButton.UseVisualStyleBackColor = true;
            this.startMonitoringButton.Click += new System.EventHandler(this.DidTapOnMonitor);
            // 
            // stopMonitoringButton
            // 
            this.stopMonitoringButton.Location = new System.Drawing.Point(35, 193);
            this.stopMonitoringButton.Name = "stopMonitoringButton";
            this.stopMonitoringButton.Size = new System.Drawing.Size(144, 35);
            this.stopMonitoringButton.TabIndex = 5;
            this.stopMonitoringButton.Text = "Update Game";
            this.stopMonitoringButton.UseVisualStyleBackColor = true;
            this.stopMonitoringButton.Click += new System.EventHandler(this.DidTapOnUpdateGame);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(32, 428);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 13);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Closed";
            // 
            // gxTextBox
            // 
            this.gxTextBox.Location = new System.Drawing.Point(311, 34);
            this.gxTextBox.Name = "gxTextBox";
            this.gxTextBox.ReadOnly = true;
            this.gxTextBox.Size = new System.Drawing.Size(100, 20);
            this.gxTextBox.TabIndex = 7;
            // 
            // gyTextBox
            // 
            this.gyTextBox.Location = new System.Drawing.Point(448, 34);
            this.gyTextBox.Name = "gyTextBox";
            this.gyTextBox.ReadOnly = true;
            this.gyTextBox.Size = new System.Drawing.Size(100, 20);
            this.gyTextBox.TabIndex = 8;
            // 
            // gzTextBox
            // 
            this.gzTextBox.Location = new System.Drawing.Point(595, 34);
            this.gzTextBox.Name = "gzTextBox";
            this.gzTextBox.ReadOnly = true;
            this.gzTextBox.Size = new System.Drawing.Size(100, 20);
            this.gzTextBox.TabIndex = 9;
            // 
            // gxLabel
            // 
            this.gxLabel.AutoSize = true;
            this.gxLabel.Location = new System.Drawing.Point(284, 37);
            this.gxLabel.Name = "gxLabel";
            this.gxLabel.Size = new System.Drawing.Size(21, 13);
            this.gxLabel.TabIndex = 10;
            this.gxLabel.Text = "gx:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "gy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "gz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "az:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ay:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ax:";
            // 
            // azTextBox
            // 
            this.azTextBox.Location = new System.Drawing.Point(595, 71);
            this.azTextBox.Name = "azTextBox";
            this.azTextBox.ReadOnly = true;
            this.azTextBox.Size = new System.Drawing.Size(100, 20);
            this.azTextBox.TabIndex = 15;
            // 
            // ayTextBox
            // 
            this.ayTextBox.Location = new System.Drawing.Point(448, 71);
            this.ayTextBox.Name = "ayTextBox";
            this.ayTextBox.ReadOnly = true;
            this.ayTextBox.Size = new System.Drawing.Size(100, 20);
            this.ayTextBox.TabIndex = 14;
            // 
            // axTextBox
            // 
            this.axTextBox.Location = new System.Drawing.Point(311, 71);
            this.axTextBox.Name = "axTextBox";
            this.axTextBox.ReadOnly = true;
            this.axTextBox.Size = new System.Drawing.Size(100, 20);
            this.axTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "temp:";
            // 
            // tempTextBox
            // 
            this.tempTextBox.Location = new System.Drawing.Point(323, 106);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.ReadOnly = true;
            this.tempTextBox.Size = new System.Drawing.Size(100, 20);
            this.tempTextBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tempTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.azTextBox);
            this.Controls.Add(this.ayTextBox);
            this.Controls.Add(this.axTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gxLabel);
            this.Controls.Add(this.gzTextBox);
            this.Controls.Add(this.gyTextBox);
            this.Controls.Add(this.gxTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.stopMonitoringButton);
            this.Controls.Add(this.startMonitoringButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.portComboBox);
            this.Name = "Form1";
            this.Text = "l";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button startMonitoringButton;
        private System.Windows.Forms.Button stopMonitoringButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox gxTextBox;
        private System.Windows.Forms.TextBox gyTextBox;
        private System.Windows.Forms.TextBox gzTextBox;
        private System.Windows.Forms.Label gxLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox azTextBox;
        private System.Windows.Forms.TextBox ayTextBox;
        private System.Windows.Forms.TextBox axTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tempTextBox;
    }
}

