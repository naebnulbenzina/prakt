namespace prakt
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.label52 = new System.Windows.Forms.Label();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.btnSort22 = new System.Windows.Forms.Button();
            this.btnMas2 = new System.Windows.Forms.Button();
            this.groupBox12.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.textBox32);
            this.groupBox12.Controls.Add(this.textBox22);
            this.groupBox12.Controls.Add(this.textBox12);
            this.groupBox12.Controls.Add(this.label3);
            this.groupBox12.Controls.Add(this.label2);
            this.groupBox12.Controls.Add(this.label1);
            this.groupBox12.ForeColor = System.Drawing.Color.Blue;
            this.groupBox12.Location = new System.Drawing.Point(11, 12);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(406, 164);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Параметры массива";
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(218, 104);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(100, 20);
            this.textBox32.TabIndex = 5;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(218, 69);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 20);
            this.textBox22.TabIndex = 4;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(262, 35);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Верхняя граница чисел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Нижняя граница чисел";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Колличество чисел в массиве";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.label42);
            this.groupBox22.ForeColor = System.Drawing.Color.Blue;
            this.groupBox22.Location = new System.Drawing.Point(11, 174);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(406, 69);
            this.groupBox22.TabIndex = 2;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Исходный массив";
            // 
            // label42
            // 
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Location = new System.Drawing.Point(6, 32);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(394, 13);
            this.label42.TabIndex = 3;
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.label52);
            this.groupBox32.ForeColor = System.Drawing.Color.Blue;
            this.groupBox32.Location = new System.Drawing.Point(12, 265);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(406, 69);
            this.groupBox32.TabIndex = 3;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Преобразованный массив";
            // 
            // label52
            // 
            this.label52.ForeColor = System.Drawing.Color.Black;
            this.label52.Location = new System.Drawing.Point(6, 30);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(394, 13);
            this.label52.TabIndex = 4;
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(289, 367);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(100, 23);
            this.btnExit2.TabIndex = 8;
            this.btnExit2.Text = "Выход";
            this.btnExit2.UseVisualStyleBackColor = true;
            // 
            // btnSort22
            // 
            this.btnSort22.Enabled = false;
            this.btnSort22.Location = new System.Drawing.Point(159, 367);
            this.btnSort22.Name = "btnSort22";
            this.btnSort22.Size = new System.Drawing.Size(100, 23);
            this.btnSort22.TabIndex = 7;
            this.btnSort22.Text = "Сортировка";
            this.btnSort22.UseVisualStyleBackColor = true;
            // 
            // btnMas2
            // 
            this.btnMas2.Location = new System.Drawing.Point(35, 367);
            this.btnMas2.Name = "btnMas2";
            this.btnMas2.Size = new System.Drawing.Size(100, 23);
            this.btnMas2.TabIndex = 6;
            this.btnMas2.Text = "Новый массив";
            this.btnMas2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 416);
            this.Controls.Add(this.btnExit2);
            this.Controls.Add(this.btnSort22);
            this.Controls.Add(this.btnMas2);
            this.Controls.Add(this.groupBox32);
            this.Controls.Add(this.groupBox22);
            this.Controls.Add(this.groupBox12);
            this.Name = "Form2";
            this.Text = "Алгоритм сортировки вставками";
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox32.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button btnSort22;
        private System.Windows.Forms.Button btnMas2;
    }
}