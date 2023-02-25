namespace Lab3_OOP
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonRound = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OlimpicRounds = new System.Windows.Forms.Button();
            this.Robot = new System.Windows.Forms.Button();
            this.Polygon = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.button_All_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(97, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 521);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEllipse.Location = new System.Drawing.Point(4, 104);
            this.buttonEllipse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(89, 32);
            this.buttonEllipse.TabIndex = 1;
            this.buttonEllipse.Text = "Эллипс";
            this.buttonEllipse.UseVisualStyleBackColor = false;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonRound
            // 
            this.buttonRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonRound.Location = new System.Drawing.Point(4, 140);
            this.buttonRound.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRound.Name = "buttonRound";
            this.buttonRound.Size = new System.Drawing.Size(89, 32);
            this.buttonRound.TabIndex = 2;
            this.buttonRound.Text = "Окружность";
            this.buttonRound.UseVisualStyleBackColor = false;
            this.buttonRound.Click += new System.EventHandler(this.buttonRound_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSquare.Location = new System.Drawing.Point(4, 68);
            this.buttonSquare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(89, 32);
            this.buttonSquare.TabIndex = 4;
            this.buttonSquare.Text = "Квадрат";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonRectangle.Location = new System.Drawing.Point(4, 32);
            this.buttonRectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(89, 32);
            this.buttonRectangle.TabIndex = 3;
            this.buttonRectangle.Text = "Прямоугольник";
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OlimpicRounds);
            this.groupBox1.Controls.Add(this.Robot);
            this.groupBox1.Controls.Add(this.Polygon);
            this.groupBox1.Controls.Add(this.Triangle);
            this.groupBox1.Controls.Add(this.button_All_Clear);
            this.groupBox1.Controls.Add(this.buttonRectangle);
            this.groupBox1.Controls.Add(this.buttonSquare);
            this.groupBox1.Controls.Add(this.buttonEllipse);
            this.groupBox1.Controls.Add(this.buttonRound);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(100, 483);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "           Управление";
            // 
            // OlimpicRounds
            // 
            this.OlimpicRounds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OlimpicRounds.Location = new System.Drawing.Point(4, 284);
            this.OlimpicRounds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OlimpicRounds.Name = "OlimpicRounds";
            this.OlimpicRounds.Size = new System.Drawing.Size(89, 32);
            this.OlimpicRounds.TabIndex = 9;
            this.OlimpicRounds.Text = "Олимп. кольца";
            this.OlimpicRounds.UseVisualStyleBackColor = false;
            this.OlimpicRounds.Click += new System.EventHandler(this.OlimpicRounds_Click);
            // 
            // Robot
            // 
            this.Robot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Robot.Location = new System.Drawing.Point(4, 248);
            this.Robot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Robot.Name = "Robot";
            this.Robot.Size = new System.Drawing.Size(89, 32);
            this.Robot.TabIndex = 8;
            this.Robot.Text = "Робот";
            this.Robot.UseVisualStyleBackColor = false;
            this.Robot.Click += new System.EventHandler(this.Robot_Click);
            // 
            // Polygon
            // 
            this.Polygon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Polygon.Location = new System.Drawing.Point(4, 176);
            this.Polygon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(89, 32);
            this.Polygon.TabIndex = 6;
            this.Polygon.Text = "Многоугольник";
            this.Polygon.UseVisualStyleBackColor = false;
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // Triangle
            // 
            this.Triangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Triangle.Location = new System.Drawing.Point(4, 212);
            this.Triangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(89, 32);
            this.Triangle.TabIndex = 7;
            this.Triangle.Text = "Треугольник";
            this.Triangle.UseVisualStyleBackColor = false;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // button_All_Clear
            // 
            this.button_All_Clear.BackColor = System.Drawing.Color.Red;
            this.button_All_Clear.Location = new System.Drawing.Point(4, 445);
            this.button_All_Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_All_Clear.Name = "button_All_Clear";
            this.button_All_Clear.Size = new System.Drawing.Size(89, 32);
            this.button_All_Clear.TabIndex = 5;
            this.button_All_Clear.Text = "Очистить холст";
            this.button_All_Clear.UseVisualStyleBackColor = false;
            this.button_All_Clear.Click += new System.EventHandler(this.button_All_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(859, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonRound;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_All_Clear;
        private System.Windows.Forms.Button Robot;
        private System.Windows.Forms.Button Polygon;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button OlimpicRounds;
    }
}

