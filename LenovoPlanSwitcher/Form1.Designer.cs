namespace LenovoPlanSwitcher
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.performanceMode_cmbBox = new System.Windows.Forms.ComboBox();
            this.balancedMode_cmbBox = new System.Windows.Forms.ComboBox();
            this.quietMode_cmbBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentLenovoPlan_lbl = new System.Windows.Forms.Label();
            this.currentWindowsPlan_lbl = new System.Windows.Forms.Label();
            this.lenovoPowerPlanWatch_tmr = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.performanceMode_cmbBox);
            this.groupBox1.Controls.Add(this.balancedMode_cmbBox);
            this.groupBox1.Controls.Add(this.quietMode_cmbBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сопоставление режима производительности и плана Windows";
            // 
            // performanceMode_cmbBox
            // 
            this.performanceMode_cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.performanceMode_cmbBox.Location = new System.Drawing.Point(241, 92);
            this.performanceMode_cmbBox.Name = "performanceMode_cmbBox";
            this.performanceMode_cmbBox.Size = new System.Drawing.Size(326, 28);
            this.performanceMode_cmbBox.TabIndex = 6;
            this.performanceMode_cmbBox.SelectionChangeCommitted += new System.EventHandler(this.PerformanceMode_cmbBox_SelectionChangeCommitted);
            // 
            // balancedMode_cmbBox
            // 
            this.balancedMode_cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.balancedMode_cmbBox.FormattingEnabled = true;
            this.balancedMode_cmbBox.Location = new System.Drawing.Point(241, 58);
            this.balancedMode_cmbBox.Name = "balancedMode_cmbBox";
            this.balancedMode_cmbBox.Size = new System.Drawing.Size(326, 28);
            this.balancedMode_cmbBox.TabIndex = 5;
            this.balancedMode_cmbBox.SelectionChangeCommitted += new System.EventHandler(this.BalancedMode_cmbBox_SelectionChangeCommitted);
            // 
            // quietMode_cmbBox
            // 
            this.quietMode_cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quietMode_cmbBox.FormattingEnabled = true;
            this.quietMode_cmbBox.Location = new System.Drawing.Point(241, 24);
            this.quietMode_cmbBox.Name = "quietMode_cmbBox";
            this.quietMode_cmbBox.Size = new System.Drawing.Size(326, 28);
            this.quietMode_cmbBox.TabIndex = 4;
            this.quietMode_cmbBox.SelectionChangeCommitted += new System.EventHandler(this.QuietMode_cmbBox_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Производительный режим:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Сбалансированный режим:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тихий режим:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текущий план питания Lenovo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текущий план питания Windows:";
            // 
            // currentLenovoPlan_lbl
            // 
            this.currentLenovoPlan_lbl.AutoSize = true;
            this.currentLenovoPlan_lbl.Location = new System.Drawing.Point(268, 156);
            this.currentLenovoPlan_lbl.Name = "currentLenovoPlan_lbl";
            this.currentLenovoPlan_lbl.Size = new System.Drawing.Size(14, 20);
            this.currentLenovoPlan_lbl.TabIndex = 4;
            this.currentLenovoPlan_lbl.Text = "-";
            // 
            // currentWindowsPlan_lbl
            // 
            this.currentWindowsPlan_lbl.AutoSize = true;
            this.currentWindowsPlan_lbl.Location = new System.Drawing.Point(268, 180);
            this.currentWindowsPlan_lbl.Name = "currentWindowsPlan_lbl";
            this.currentWindowsPlan_lbl.Size = new System.Drawing.Size(14, 20);
            this.currentWindowsPlan_lbl.TabIndex = 5;
            this.currentWindowsPlan_lbl.Text = "-";
            // 
            // lenovoPowerPlanWatch_tmr
            // 
            this.lenovoPowerPlanWatch_tmr.Interval = 1000;
            this.lenovoPowerPlanWatch_tmr.Tick += new System.EventHandler(this.LenovoPowerPlanWatch_tmr_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 233);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(320, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Добавить программу в автозагрузку?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 269);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.currentWindowsPlan_lbl);
            this.Controls.Add(this.currentLenovoPlan_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainForm";
            this.Text = "Lenovo Power Plan Switcher";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentLenovoPlan_lbl;
        private System.Windows.Forms.Label currentWindowsPlan_lbl;
        private System.Windows.Forms.ComboBox performanceMode_cmbBox;
        private System.Windows.Forms.ComboBox balancedMode_cmbBox;
        private System.Windows.Forms.ComboBox quietMode_cmbBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer lenovoPowerPlanWatch_tmr;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

