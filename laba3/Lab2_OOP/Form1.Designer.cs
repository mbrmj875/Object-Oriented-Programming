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
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonRound = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_All_Clear = new System.Windows.Forms.Button();
            this.ship = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Polygon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEllipse.Location = new System.Drawing.Point(0, 106);
            this.buttonEllipse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(93, 32);
            this.buttonEllipse.TabIndex = 1;
            this.buttonEllipse.Text = "Эллипс";
            this.buttonEllipse.UseVisualStyleBackColor = false;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonRound
            // 
            this.buttonRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonRound.Location = new System.Drawing.Point(0, 142);
            this.buttonRound.Margin = new System.Windows.Forms.Padding(2);
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
            this.buttonSquare.Location = new System.Drawing.Point(0, 70);
            this.buttonSquare.Margin = new System.Windows.Forms.Padding(2);
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
            this.buttonRectangle.Location = new System.Drawing.Point(0, 34);
            this.buttonRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(89, 32);
            this.buttonRectangle.TabIndex = 3;
            this.buttonRectangle.Text = "Прямоугольник";
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_All_Clear);
            this.groupBox1.Controls.Add(this.buttonRectangle);
            this.groupBox1.Controls.Add(this.ship);
            this.groupBox1.Controls.Add(this.buttonSquare);
            this.groupBox1.Controls.Add(this.buttonEllipse);
            this.groupBox1.Controls.Add(this.Triangle);
            this.groupBox1.Controls.Add(this.buttonRound);
            this.groupBox1.Controls.Add(this.Polygon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(89, 499);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "           Управление";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_All_Clear
            // 
            this.button_All_Clear.BackColor = System.Drawing.Color.Red;
            this.button_All_Clear.Location = new System.Drawing.Point(0, 353);
            this.button_All_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_All_Clear.Name = "button_All_Clear";
            this.button_All_Clear.Size = new System.Drawing.Size(89, 32);
            this.button_All_Clear.TabIndex = 5;
            this.button_All_Clear.Text = "Очистить холст";
            this.button_All_Clear.UseVisualStyleBackColor = false;
            this.button_All_Clear.Click += new System.EventHandler(this.button_All_Clear_Click);
            // 
            // ship
            // 
            this.ship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ship.Location = new System.Drawing.Point(0, 250);
            this.ship.Margin = new System.Windows.Forms.Padding(2);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(89, 32);
            this.ship.TabIndex = 8;
            this.ship.Text = "лодка";
            this.ship.UseVisualStyleBackColor = false;
            this.ship.Click += new System.EventHandler(this.ship_Click);
            // 
            // Triangle
            // 
            this.Triangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Triangle.Location = new System.Drawing.Point(0, 214);
            this.Triangle.Margin = new System.Windows.Forms.Padding(2);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(89, 32);
            this.Triangle.TabIndex = 7;
            this.Triangle.Text = "Треугольник";
            this.Triangle.UseVisualStyleBackColor = false;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Polygon
            // 
            this.Polygon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Polygon.Location = new System.Drawing.Point(0, 178);
            this.Polygon.Margin = new System.Windows.Forms.Padding(2);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(89, 32);
            this.Polygon.TabIndex = 6;
            this.Polygon.Text = "Многоугольник";
            this.Polygon.UseVisualStyleBackColor = false;
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(109, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 499);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(775, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "lap3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonRound;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_All_Clear;
        private System.Windows.Forms.Button ship;
        private System.Windows.Forms.Button Polygon;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

