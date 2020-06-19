namespace Треугольник
{
    partial class Треугольник
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.storonaAlb = new System.Windows.Forms.Label();
            this.storonaBlb = new System.Windows.Forms.Label();
            this.storonaClb = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.num3 = new System.Windows.Forms.NumericUpDown();
            this.rBtn1 = new System.Windows.Forms.RadioButton();
            this.rBtn2 = new System.Windows.Forms.RadioButton();
            this.btnRes = new System.Windows.Forms.Button();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.titleLb = new System.Windows.Forms.Label();
            this.title2Lb = new System.Windows.Forms.Label();
            this.menuSt = new System.Windows.Forms.MenuStrip();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьСтандартныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).BeginInit();
            this.menuSt.SuspendLayout();
            this.SuspendLayout();
            // 
            // storonaAlb
            // 
            this.storonaAlb.AutoSize = true;
            this.storonaAlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storonaAlb.Location = new System.Drawing.Point(12, 68);
            this.storonaAlb.Name = "storonaAlb";
            this.storonaAlb.Size = new System.Drawing.Size(77, 18);
            this.storonaAlb.TabIndex = 3;
            this.storonaAlb.Text = "сторона а";
            // 
            // storonaBlb
            // 
            this.storonaBlb.AutoSize = true;
            this.storonaBlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storonaBlb.Location = new System.Drawing.Point(12, 105);
            this.storonaBlb.Name = "storonaBlb";
            this.storonaBlb.Size = new System.Drawing.Size(77, 18);
            this.storonaBlb.TabIndex = 4;
            this.storonaBlb.Text = "сторона b";
            // 
            // storonaClb
            // 
            this.storonaClb.AutoSize = true;
            this.storonaClb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storonaClb.Location = new System.Drawing.Point(12, 143);
            this.storonaClb.Name = "storonaClb";
            this.storonaClb.Size = new System.Drawing.Size(77, 18);
            this.storonaClb.TabIndex = 5;
            this.storonaClb.Text = "сторона с";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(95, 70);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(120, 20);
            this.num1.TabIndex = 6;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(95, 107);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(120, 20);
            this.num2.TabIndex = 7;
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(95, 145);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(120, 20);
            this.num3.TabIndex = 8;
            // 
            // rBtn1
            // 
            this.rBtn1.AutoSize = true;
            this.rBtn1.Location = new System.Drawing.Point(241, 68);
            this.rBtn1.Name = "rBtn1";
            this.rBtn1.Size = new System.Drawing.Size(127, 17);
            this.rBtn1.TabIndex = 9;
            this.rBtn1.TabStop = true;
            this.rBtn1.Text = "вычислить площадь";
            this.rBtn1.UseVisualStyleBackColor = true;
            // 
            // rBtn2
            // 
            this.rBtn2.AutoSize = true;
            this.rBtn2.Location = new System.Drawing.Point(241, 105);
            this.rBtn2.Name = "rBtn2";
            this.rBtn2.Size = new System.Drawing.Size(131, 17);
            this.rBtn2.TabIndex = 10;
            this.rBtn2.TabStop = true;
            this.rBtn2.Text = "вычислить периметр";
            this.rBtn2.UseVisualStyleBackColor = true;
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(241, 145);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(90, 31);
            this.btnRes.TabIndex = 11;
            this.btnRes.Text = "Вычислить";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(351, 148);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(100, 28);
            this.txtRes.TabIndex = 12;
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.Location = new System.Drawing.Point(12, 33);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(123, 13);
            this.titleLb.TabIndex = 13;
            this.titleLb.Text = "ИСХОДНЫЕ ДАННЫЕ";
            // 
            // title2Lb
            // 
            this.title2Lb.AutoSize = true;
            this.title2Lb.Location = new System.Drawing.Point(238, 33);
            this.title2Lb.Name = "title2Lb";
            this.title2Lb.Size = new System.Drawing.Size(143, 13);
            this.title2Lb.TabIndex = 14;
            this.title2Lb.Text = "РЕЗУЛЬТАТЫ РАСЧЕТОВ";
            // 
            // menuSt
            // 
            this.menuSt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветФонаToolStripMenuItem});
            this.menuSt.Location = new System.Drawing.Point(0, 0);
            this.menuSt.Name = "menuSt";
            this.menuSt.Size = new System.Drawing.Size(476, 24);
            this.menuSt.TabIndex = 15;
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветаToolStripMenuItem});
            this.цветФонаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.цветФонаToolStripMenuItem.Text = "Цвет фона";
            // 
            // цветаToolStripMenuItem
            // 
            this.цветаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.красныйToolStripMenuItem,
            this.синийToolStripMenuItem,
            this.зеленыйToolStripMenuItem,
            this.вернутьСтандартныйToolStripMenuItem});
            this.цветаToolStripMenuItem.Name = "цветаToolStripMenuItem";
            this.цветаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.цветаToolStripMenuItem.Text = "Цвета";
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.красныйToolStripMenuItem.Text = "Красный";
            this.красныйToolStripMenuItem.Click += new System.EventHandler(this.красныйToolStripMenuItem_Click);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.синийToolStripMenuItem.Text = "Синий";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.синийToolStripMenuItem_Click);
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            this.зеленыйToolStripMenuItem.Click += new System.EventHandler(this.зеленыйToolStripMenuItem_Click);
            // 
            // вернутьСтандартныйToolStripMenuItem
            // 
            this.вернутьСтандартныйToolStripMenuItem.Name = "вернутьСтандартныйToolStripMenuItem";
            this.вернутьСтандартныйToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.вернутьСтандартныйToolStripMenuItem.Text = "Вернуть серый";
            this.вернутьСтандартныйToolStripMenuItem.Click += new System.EventHandler(this.вернутьСтандартныйToolStripMenuItem_Click);
            // 
            // Треугольник
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(476, 207);
            this.Controls.Add(this.title2Lb);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.rBtn2);
            this.Controls.Add(this.rBtn1);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.storonaClb);
            this.Controls.Add(this.storonaBlb);
            this.Controls.Add(this.storonaAlb);
            this.Controls.Add(this.menuSt);
            this.MainMenuStrip = this.menuSt;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Треугольник";
            this.Text = "Расчет площади";
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).EndInit();
            this.menuSt.ResumeLayout(false);
            this.menuSt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storonaAlb;
        private System.Windows.Forms.Label storonaBlb;
        private System.Windows.Forms.Label storonaClb;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.NumericUpDown num3;
        private System.Windows.Forms.RadioButton rBtn1;
        private System.Windows.Forms.RadioButton rBtn2;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Label title2Lb;
        private System.Windows.Forms.MenuStrip menuSt;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem красныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьСтандартныйToolStripMenuItem;

    }
}

