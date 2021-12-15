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
            this.startMonitoringButton.Location = new System.Drawing.Point(55, 135);
            this.startMonitoringButton.Name = "startMonitoringButton";
            this.startMonitoringButton.Size = new System.Drawing.Size(140, 23);
            this.startMonitoringButton.TabIndex = 4;
            this.startMonitoringButton.Text = "Start Monitoring";
            this.startMonitoringButton.UseVisualStyleBackColor = true;
            this.startMonitoringButton.Click += new System.EventHandler(this.startMonitoringButton_Click);
            // 
            // stopMonitoringButton
            // 
            this.stopMonitoringButton.Location = new System.Drawing.Point(55, 180);
            this.stopMonitoringButton.Name = "stopMonitoringButton";
            this.stopMonitoringButton.Size = new System.Drawing.Size(140, 23);
            this.stopMonitoringButton.TabIndex = 5;
            this.stopMonitoringButton.Text = "Stop Monitoring";
            this.stopMonitoringButton.UseVisualStyleBackColor = true;
            this.stopMonitoringButton.Click += new System.EventHandler(this.stopMonitoringButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopMonitoringButton);
            this.Controls.Add(this.startMonitoringButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.portComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button startMonitoringButton;
        private System.Windows.Forms.Button stopMonitoringButton;
    }
}

