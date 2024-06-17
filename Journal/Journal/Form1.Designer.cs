
namespace Journal
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
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMond = new System.Windows.Forms.Button();
            this.st = new System.Windows.Forms.Label();
            this.fr = new System.Windows.Forms.Label();
            this.th = new System.Windows.Forms.Label();
            this.we = new System.Windows.Forms.Label();
            this.tu = new System.Windows.Forms.Label();
            this.mn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comBoxpn = new System.Windows.Forms.ComboBox();
            this.su = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(802, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 358);
            this.button5.TabIndex = 6;
            this.button5.Text = "Справочники";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 384);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.su);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.comBoxpn);
            this.tabPage1.Controls.Add(this.btnMond);
            this.tabPage1.Controls.Add(this.st);
            this.tabPage1.Controls.Add(this.fr);
            this.tabPage1.Controls.Add(this.th);
            this.tabPage1.Controls.Add(this.we);
            this.tabPage1.Controls.Add(this.tu);
            this.tabPage1.Controls.Add(this.mn);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расписание";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnMond
            // 
            this.btnMond.Location = new System.Drawing.Point(353, 329);
            this.btnMond.Name = "btnMond";
            this.btnMond.Size = new System.Drawing.Size(84, 23);
            this.btnMond.TabIndex = 17;
            this.btnMond.Text = "Расписание";
            this.btnMond.UseVisualStyleBackColor = true;
            this.btnMond.Click += new System.EventHandler(this.btnMond_Click);
            // 
            // st
            // 
            this.st.AutoSize = true;
            this.st.Location = new System.Drawing.Point(560, 74);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(19, 13);
            this.st.TabIndex = 15;
            this.st.Text = "сб";
            // 
            // fr
            // 
            this.fr.AutoSize = true;
            this.fr.Location = new System.Drawing.Point(467, 74);
            this.fr.Name = "fr";
            this.fr.Size = new System.Drawing.Size(18, 13);
            this.fr.TabIndex = 14;
            this.fr.Text = "пт";
            // 
            // th
            // 
            this.th.AutoSize = true;
            this.th.Location = new System.Drawing.Point(350, 74);
            this.th.Name = "th";
            this.th.Size = new System.Drawing.Size(17, 13);
            this.th.TabIndex = 13;
            this.th.Text = "чт";
            // 
            // we
            // 
            this.we.AutoSize = true;
            this.we.Location = new System.Drawing.Point(236, 74);
            this.we.Name = "we";
            this.we.Size = new System.Drawing.Size(19, 13);
            this.we.TabIndex = 12;
            this.we.Text = "ср";
            // 
            // tu
            // 
            this.tu.AutoSize = true;
            this.tu.Location = new System.Drawing.Point(126, 74);
            this.tu.Name = "tu";
            this.tu.Size = new System.Drawing.Size(18, 13);
            this.tu.TabIndex = 11;
            this.tu.Text = "вт";
            // 
            // mn
            // 
            this.mn.AutoSize = true;
            this.mn.Location = new System.Drawing.Point(3, 74);
            this.mn.Name = "mn";
            this.mn.Size = new System.Drawing.Size(19, 13);
            this.mn.TabIndex = 10;
            this.mn.Text = "пн";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(558, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Сб";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(465, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Пт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(348, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Чт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(234, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ср";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(124, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вт";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(235, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "<-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пн";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(443, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "->";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, -22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Журнал";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comBoxpn
            // 
            this.comBoxpn.FormattingEnabled = true;
            this.comBoxpn.Location = new System.Drawing.Point(6, 3);
            this.comBoxpn.Name = "comBoxpn";
            this.comBoxpn.Size = new System.Drawing.Size(121, 21);
            this.comBoxpn.TabIndex = 18;
            // 
            // su
            // 
            this.su.AutoSize = true;
            this.su.Location = new System.Drawing.Point(660, 74);
            this.su.Name = "su";
            this.su.Size = new System.Drawing.Size(19, 13);
            this.su.TabIndex = 20;
            this.su.Text = "вс";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(658, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 25);
            this.label14.TabIndex = 19;
            this.label14.Text = "Вс";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(316, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(539, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 405);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMond;
        private System.Windows.Forms.Label st;
        private System.Windows.Forms.Label fr;
        private System.Windows.Forms.Label th;
        private System.Windows.Forms.Label we;
        private System.Windows.Forms.Label tu;
        private System.Windows.Forms.Label mn;
        private System.Windows.Forms.ComboBox comBoxpn;
        private System.Windows.Forms.Label su;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

