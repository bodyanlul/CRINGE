
namespace lr2im
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AvgLoadM = new System.Windows.Forms.Label();
            this.AvgLoadP = new System.Windows.Forms.Label();
            this.AvgTime = new System.Windows.Forms.Label();
            this.Chance = new System.Windows.Forms.Label();
            this.AvgCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Time1 = new System.Windows.Forms.Label();
            this.Time2 = new System.Windows.Forms.Label();
            this.Count1 = new System.Windows.Forms.Label();
            this.Count2 = new System.Windows.Forms.Label();
            this.Chance1 = new System.Windows.Forms.Label();
            this.Chance2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(714, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(672, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "24";
            // 
            // AvgLoadM
            // 
            this.AvgLoadM.AutoSize = true;
            this.AvgLoadM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgLoadM.Location = new System.Drawing.Point(272, 38);
            this.AvgLoadM.Name = "AvgLoadM";
            this.AvgLoadM.Size = new System.Drawing.Size(41, 13);
            this.AvgLoadM.TabIndex = 2;
            this.AvgLoadM.Text = "label1";
            // 
            // AvgLoadP
            // 
            this.AvgLoadP.AutoSize = true;
            this.AvgLoadP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgLoadP.Location = new System.Drawing.Point(272, 64);
            this.AvgLoadP.Name = "AvgLoadP";
            this.AvgLoadP.Size = new System.Drawing.Size(41, 13);
            this.AvgLoadP.TabIndex = 3;
            this.AvgLoadP.Text = "label1";
            // 
            // AvgTime
            // 
            this.AvgTime.AutoSize = true;
            this.AvgTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgTime.Location = new System.Drawing.Point(272, 92);
            this.AvgTime.Name = "AvgTime";
            this.AvgTime.Size = new System.Drawing.Size(41, 13);
            this.AvgTime.TabIndex = 4;
            this.AvgTime.Text = "label1";
            // 
            // Chance
            // 
            this.Chance.AutoSize = true;
            this.Chance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chance.Location = new System.Drawing.Point(272, 119);
            this.Chance.Name = "Chance";
            this.Chance.Size = new System.Drawing.Size(41, 13);
            this.Chance.TabIndex = 5;
            this.Chance.Text = "label1";
            // 
            // AvgCount
            // 
            this.AvgCount.AutoSize = true;
            this.AvgCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgCount.Location = new System.Drawing.Point(272, 147);
            this.AvgCount.Name = "AvgCount";
            this.AvgCount.Size = new System.Drawing.Size(41, 13);
            this.AvgCount.TabIndex = 6;
            this.AvgCount.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Время загрузки (в минутах)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Время загрузки (в процентах)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Среднее время обработки (в минутах)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Вероятность обработки (в процентах)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Среднее число обработанных деталей";
            // 
            // Time1
            // 
            this.Time1.AutoSize = true;
            this.Time1.Location = new System.Drawing.Point(461, 92);
            this.Time1.Name = "Time1";
            this.Time1.Size = new System.Drawing.Size(35, 13);
            this.Time1.TabIndex = 12;
            this.Time1.Text = "label6";
            // 
            // Time2
            // 
            this.Time2.AutoSize = true;
            this.Time2.Location = new System.Drawing.Point(639, 92);
            this.Time2.Name = "Time2";
            this.Time2.Size = new System.Drawing.Size(35, 13);
            this.Time2.TabIndex = 13;
            this.Time2.Text = "label6";
            // 
            // Count1
            // 
            this.Count1.AutoSize = true;
            this.Count1.Location = new System.Drawing.Point(461, 147);
            this.Count1.Name = "Count1";
            this.Count1.Size = new System.Drawing.Size(35, 13);
            this.Count1.TabIndex = 14;
            this.Count1.Text = "label1";
            // 
            // Count2
            // 
            this.Count2.AutoSize = true;
            this.Count2.Location = new System.Drawing.Point(639, 147);
            this.Count2.Name = "Count2";
            this.Count2.Size = new System.Drawing.Size(35, 13);
            this.Count2.TabIndex = 15;
            this.Count2.Text = "label1";
            // 
            // Chance1
            // 
            this.Chance1.AutoSize = true;
            this.Chance1.Location = new System.Drawing.Point(461, 119);
            this.Chance1.Name = "Chance1";
            this.Chance1.Size = new System.Drawing.Size(35, 13);
            this.Chance1.TabIndex = 16;
            this.Chance1.Text = "label6";
            // 
            // Chance2
            // 
            this.Chance2.AutoSize = true;
            this.Chance2.Location = new System.Drawing.Point(639, 119);
            this.Chance2.Name = "Chance2";
            this.Chance2.Size = new System.Drawing.Size(35, 13);
            this.Chance2.TabIndex = 17;
            this.Chance2.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Время моделирования в часах";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 232);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Chance2);
            this.Controls.Add(this.Chance1);
            this.Controls.Add(this.Count2);
            this.Controls.Add(this.Count1);
            this.Controls.Add(this.Time2);
            this.Controls.Add(this.Time1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvgCount);
            this.Controls.Add(this.Chance);
            this.Controls.Add(this.AvgTime);
            this.Controls.Add(this.AvgLoadP);
            this.Controls.Add(this.AvgLoadM);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Моделирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AvgLoadM;
        private System.Windows.Forms.Label AvgLoadP;
        private System.Windows.Forms.Label AvgTime;
        private System.Windows.Forms.Label Chance;
        private System.Windows.Forms.Label AvgCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Time1;
        private System.Windows.Forms.Label Time2;
        private System.Windows.Forms.Label Count1;
        private System.Windows.Forms.Label Count2;
        private System.Windows.Forms.Label Chance1;
        private System.Windows.Forms.Label Chance2;
        private System.Windows.Forms.Label label6;
    }
}

