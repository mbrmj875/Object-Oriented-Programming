﻿namespace Lab3_OOP
{
    partial class FormRect
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
            this.label3 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.Button_New_Size = new System.Windows.Forms.Button();
            this.Button_New_Cords = new System.Windows.Forms.Button();
            this.new_width = new System.Windows.Forms.TextBox();
            this.new_height = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.new_Y = new System.Windows.Forms.TextBox();
            this.new_X = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Button_Draw = new System.Windows.Forms.Button();
            this.width = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelWH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setY = new System.Windows.Forms.TextBox();
            this.setX = new System.Windows.Forms.TextBox();
            this.labelXY = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.figure_box = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(68, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "ПРЯМОУГОЛЬНИК";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_back.Location = new System.Drawing.Point(188, 5);
            this.button_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(70, 19);
            this.button_back.TabIndex = 72;
            this.button_back.Text = "Закрыть";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Button_New_Size
            // 
            this.Button_New_Size.Location = new System.Drawing.Point(161, 131);
            this.Button_New_Size.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_New_Size.Name = "Button_New_Size";
            this.Button_New_Size.Size = new System.Drawing.Size(70, 19);
            this.Button_New_Size.TabIndex = 71;
            this.Button_New_Size.Text = "Изменить";
            this.Button_New_Size.UseVisualStyleBackColor = true;
            this.Button_New_Size.Click += new System.EventHandler(this.Button_New_Size_Click);
            // 
            // Button_New_Cords
            // 
            this.Button_New_Cords.Location = new System.Drawing.Point(19, 131);
            this.Button_New_Cords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_New_Cords.Name = "Button_New_Cords";
            this.Button_New_Cords.Size = new System.Drawing.Size(70, 19);
            this.Button_New_Cords.TabIndex = 70;
            this.Button_New_Cords.Text = "Изменить";
            this.Button_New_Cords.UseVisualStyleBackColor = true;
            this.Button_New_Cords.Click += new System.EventHandler(this.Button_New_Cords_Click);
            // 
            // new_width
            // 
            this.new_width.Location = new System.Drawing.Point(161, 89);
            this.new_width.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.new_width.Name = "new_width";
            this.new_width.Size = new System.Drawing.Size(75, 20);
            this.new_width.TabIndex = 69;
            // 
            // new_height
            // 
            this.new_height.Location = new System.Drawing.Point(161, 110);
            this.new_height.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.new_height.Name = "new_height";
            this.new_height.Size = new System.Drawing.Size(75, 20);
            this.new_height.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Высота";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Ширина";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Новые размеры:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "X";
            // 
            // new_Y
            // 
            this.new_Y.Location = new System.Drawing.Point(19, 110);
            this.new_Y.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.new_Y.Name = "new_Y";
            this.new_Y.Size = new System.Drawing.Size(75, 20);
            this.new_Y.TabIndex = 62;
            // 
            // new_X
            // 
            this.new_X.Location = new System.Drawing.Point(19, 89);
            this.new_X.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.new_X.Name = "new_X";
            this.new_X.Size = new System.Drawing.Size(75, 20);
            this.new_X.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Новые координаты:";
            // 
            // Button_Draw
            // 
            this.Button_Draw.Location = new System.Drawing.Point(71, 98);
            this.Button_Draw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_Draw.Name = "Button_Draw";
            this.Button_Draw.Size = new System.Drawing.Size(76, 19);
            this.Button_Draw.TabIndex = 59;
            this.Button_Draw.Text = "Нарисовать";
            this.Button_Draw.UseVisualStyleBackColor = true;
            this.Button_Draw.Click += new System.EventHandler(this.Button_Draw_Click);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(164, 47);
            this.width.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(75, 20);
            this.width.TabIndex = 58;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(164, 68);
            this.height.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(75, 20);
            this.height.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Высота";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Ширина";
            // 
            // labelWH
            // 
            this.labelWH.AutoSize = true;
            this.labelWH.Location = new System.Drawing.Point(146, 25);
            this.labelWH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWH.Name = "labelWH";
            this.labelWH.Size = new System.Drawing.Size(54, 13);
            this.labelWH.TabIndex = 54;
            this.labelWH.Text = "Размеры:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "X";
            // 
            // setY
            // 
            this.setY.Location = new System.Drawing.Point(16, 68);
            this.setY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.setY.Name = "setY";
            this.setY.Size = new System.Drawing.Size(75, 20);
            this.setY.TabIndex = 51;
            // 
            // setX
            // 
            this.setX.Location = new System.Drawing.Point(16, 47);
            this.setX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.setX.Name = "setX";
            this.setX.Size = new System.Drawing.Size(75, 20);
            this.setX.TabIndex = 50;
            // 
            // labelXY
            // 
            this.labelXY.AutoSize = true;
            this.labelXY.Location = new System.Drawing.Point(14, 25);
            this.labelXY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(75, 13);
            this.labelXY.TabIndex = 49;
            this.labelXY.Text = "Координаты:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.labelXY);
            this.groupBox1.Controls.Add(this.setX);
            this.groupBox1.Controls.Add(this.setY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelWH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.height);
            this.groupBox1.Controls.Add(this.width);
            this.groupBox1.Controls.Add(this.Button_Draw);
            this.groupBox1.Location = new System.Drawing.Point(8, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(250, 138);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нарисовать новый";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.figure_box);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.new_X);
            this.groupBox2.Controls.Add(this.new_Y);
            this.groupBox2.Controls.Add(this.Button_New_Size);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Button_New_Cords);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.new_width);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.new_height);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(8, 193);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(251, 171);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменить существующий";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(180, 28);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(70, 19);
            this.buttonDelete.TabIndex = 74;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 73;
            this.label12.Text = "Прямоугольник:";
            // 
            // figure_box
            // 
            this.figure_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.figure_box.FormattingEnabled = true;
            this.figure_box.Location = new System.Drawing.Point(93, 27);
            this.figure_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.figure_box.Name = "figure_box";
            this.figure_box.Size = new System.Drawing.Size(83, 21);
            this.figure_box.TabIndex = 72;
            this.figure_box.SelectedIndexChanged += new System.EventHandler(this.figure_box_SelectedIndexChanged);
            // 
            // FormRect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(274, 383);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormRect";
            this.Text = "FormRect";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRect_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button Button_New_Size;
        private System.Windows.Forms.Button Button_New_Cords;
        private System.Windows.Forms.TextBox new_width;
        private System.Windows.Forms.TextBox new_height;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox new_Y;
        private System.Windows.Forms.TextBox new_X;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Button_Draw;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelWH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox setY;
        private System.Windows.Forms.TextBox setX;
        private System.Windows.Forms.Label labelXY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox figure_box;
        private System.Windows.Forms.Button buttonDelete;
    }
}