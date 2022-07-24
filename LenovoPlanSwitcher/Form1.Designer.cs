namespace LenovoPlanSwitcher
{
    partial class mainForm
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 711);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.groupBox1.Size = new System.Drawing.Size(1173, 597);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // performanceMode_cmbBox
            // 
            this.performanceMode_cmbBox.FormattingEnabled = true;
            this.performanceMode_cmbBox.Location = new System.Drawing.Point(263, 102);
            this.performanceMode_cmbBox.Name = "performanceMode_cmbBox";
            this.performanceMode_cmbBox.Size = new System.Drawing.Size(449, 28);
            this.performanceMode_cmbBox.TabIndex = 6;
            this.performanceMode_cmbBox.SelectionChangeCommitted += new System.EventHandler(this.performanceMode_cmbBox_SelectionChangeCommitted);
            // 
            // balancedMode_cmbBox
            // 
            this.balancedMode_cmbBox.FormattingEnabled = true;
            this.balancedMode_cmbBox.Location = new System.Drawing.Point(263, 65);
            this.balancedMode_cmbBox.Name = "balancedMode_cmbBox";
            this.balancedMode_cmbBox.Size = new System.Drawing.Size(449, 28);
            this.balancedMode_cmbBox.TabIndex = 5;
            this.balancedMode_cmbBox.SelectionChangeCommitted += new System.EventHandler(this.balancedMode_cmbBox_SelectionChangeCommitted);
            // 
            // quietMode_cmbBox
            // 
            this.quietMode_cmbBox.FormattingEnabled = true;
            this.quietMode_cmbBox.Location = new System.Drawing.Point(263, 29);
            this.quietMode_cmbBox.Name = "quietMode_cmbBox";
            this.quietMode_cmbBox.Size = new System.Drawing.Size(449, 28);
            this.quietMode_cmbBox.TabIndex = 4;
            this.quietMode_cmbBox.SelectionChangeCommitted += new System.EventHandler(this.quietMode_cmbBox_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Производительный режим:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Сбалансированный режим:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тихий режим:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текущий план питания Lenovo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текущий план питания Windows:";
            // 
            // currentLenovoPlan_lbl
            // 
            this.currentLenovoPlan_lbl.AutoSize = true;
            this.currentLenovoPlan_lbl.Location = new System.Drawing.Point(272, 628);
            this.currentLenovoPlan_lbl.Name = "currentLenovoPlan_lbl";
            this.currentLenovoPlan_lbl.Size = new System.Drawing.Size(14, 20);
            this.currentLenovoPlan_lbl.TabIndex = 4;
            this.currentLenovoPlan_lbl.Text = "-";
            // 
            // currentWindowsPlan_lbl
            // 
            this.currentWindowsPlan_lbl.AutoSize = true;
            this.currentWindowsPlan_lbl.Location = new System.Drawing.Point(272, 652);
            this.currentWindowsPlan_lbl.Name = "currentWindowsPlan_lbl";
            this.currentWindowsPlan_lbl.Size = new System.Drawing.Size(14, 20);
            this.currentWindowsPlan_lbl.TabIndex = 5;
            this.currentWindowsPlan_lbl.Text = "-";
            // 
            // lenovoPowerPlanWatch_tmr
            // 
            this.lenovoPowerPlanWatch_tmr.Interval = 1000;
            this.lenovoPowerPlanWatch_tmr.Tick += new System.EventHandler(this.lenovoPowerPlanWatch_tmr_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 951);
            this.Controls.Add(this.currentWindowsPlan_lbl);
            this.Controls.Add(this.currentLenovoPlan_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "mainForm";
            this.Text = "Lenovo Power Plan Switcher";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
    }
}

