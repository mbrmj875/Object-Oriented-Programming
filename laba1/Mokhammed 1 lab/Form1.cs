using RSDN;
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mokhammed_1_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        void hidemainbuttons()
        {
            formula_button.Visible = false;
            mintomaxarr_button.Visible = false;
            account_button.Visible = false;
            squares_button.Visible = false;
            strarr_button.Visible = false;


        }
        void showmainbuttons()
        {
            formula_button.Visible = true;
            mintomaxarr_button.Visible = true;
            account_button.Visible = true;
            squares_button.Visible = true;
            strarr_button.Visible = true;


        }
        int m, n;
        double[,] matrix;
        double[] matrix1;
        string[] s1 = {"0","1","2","3","4","5","6","7","8","9","10","11"};
        string[] s2 = { "00", "11", "22", "33", "44", "55", "66", "77", "88", "99", "1010", "1111" };
        string[] s3 = new string[12];

        public class Account
        {
            string surname { get; set; }
            string number { get; set; }
            int percents { get; set; }
            double summa { get; set; }
            public Account(string _surname, string _number, int _percents, int _summa)
            {
                this.surname = _surname;
                this.number = _number;
                this.percents = _percents;
                this.summa = _summa;

            }
            public string changename(string newsurname)
            {
                return this.surname = newsurname;

            }
            public double takemoney(int summaminus)
            {
                if (this.summa - summaminus >= 0)
                    return this.summa -= summaminus;
                else
                    return 0;

            }
            public double applymoney(int summaplus)
            {
                return this.summa += summaplus;

            }
            public double applypercents(double cost)
            {
                this.summa *= (cost / 100 + 1);

                return this.summa;

            }
            public double ToDollar()
            {
                double buff = this.summa / 61.20;
                return buff;
            }
            public double ToEuro()
            {
                double buff = this.summa / 63.68;
                return buff;
            }
            public string SummaToStr()
            {
                int val = Convert.ToInt32(this.summa);
                return RusNumber.Str(val);
            }
    public int check(string res)
        {
            int sd = 0;
            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] == '\0' || res[i] == ' ')
                {
                    sd++;
                }
            }
            return sd;
        }
        }



        private void account_button_Click(object sender, EventArgs e)
        {
            hidemainbuttons();
            groupBox2.Visible = true;
            return_button.Visible = true;
            label1.Visible = false;
            confirm_button.Visible = false;
            maskedTextBox1.Visible = false;

        }
        Account tom = new Account("Игорь", "1743 9062 5338", 0, 10000);
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                maskedTextBox1.Text = "";
                maskedTextBox1.Mask = "LLLLLLLL";
                radioButton1.Visible = false;
                radioButton2.Visible = false; 
                radioButton3.Visible = false; 
                radioButton4.Visible = false;
                label1.Visible = true;
                confirm_button.Visible = true;
                maskedTextBox1.Visible = true;
            }
            else if (radioButton2.Checked)
            {
                maskedTextBox1.Text = "";
                maskedTextBox1.Mask = "00000";
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                
                label1.Visible = true;
                confirm_button.Visible = true;
                maskedTextBox1.Visible = true;
            }
            else if (radioButton3.Checked)
            {
                maskedTextBox1.Text = "";
                maskedTextBox1.Mask = "00000";
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                
                label1.Visible = true;
                confirm_button.Visible = true;
                maskedTextBox1.Visible = true;
            }
            else if (radioButton4.Checked)
            {
                maskedTextBox1.Text = "";
                maskedTextBox1.Mask = "00";
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                
                label1.Visible = true;
                confirm_button.Visible = true;
                maskedTextBox1.Visible = true;
            }
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(tom.ToDollar()));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(tom.ToEuro()));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tom.SummaToStr());
        }
        private void confirm_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show(Convert.ToString(tom.changename(maskedTextBox1.Text)));
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    label1.Visible = false;
                    confirm_button.Visible = false;
                    maskedTextBox1.Visible = false;


                }
                else if (radioButton2.Checked == true)
                {
                    MessageBox.Show(Convert.ToString(tom.takemoney(int.Parse(maskedTextBox1.Text))));
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    label1.Visible = false;
                    confirm_button.Visible = false;
                    maskedTextBox1.Visible = false;

                }
                else if (radioButton3.Checked == true)
                {
                    MessageBox.Show(Convert.ToString(tom.applymoney(int.Parse(maskedTextBox1.Text))));
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    label1.Visible = false;
                    confirm_button.Visible = false;
                    maskedTextBox1.Visible = false;
                }
                else if (radioButton4.Checked == true)
                {
                    MessageBox.Show(Convert.ToString(tom.applypercents(int.Parse(maskedTextBox1.Text))));

                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    label1.Visible = false;
                    confirm_button.Visible = false;
                    maskedTextBox1.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Try again.");
            }
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            listBox1.Visible = false;
            return_button.Visible = false;
            showmainbuttons();
        }

        private void formula_button_Click(object sender, EventArgs e)
        {
            hidemainbuttons();
            return_button.Visible = true;
            label2.Visible = true;
            label2.Text = "X";
            label3.Visible = true;
            label3.Text = "Y";
            groupBox3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e) {
          
           
            {try
                {
                    int x = int.Parse(maskedTextBox2.Text);
                    int y = int.Parse(maskedTextBox3.Text);
                    double z = (Math.Min(x, y) + 0.5) / (1 + Math.Max(x, y) * Math.Max(x, y));
                    MessageBox.Show(Convert.ToString(z));
                }
                catch(Exception) 
                {
                    MessageBox.Show("Error. Try again.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            matrix = new double[m, n];
            matrix1 = new double[n];
            for (int i = 0; i < n; i++)
            {
                matrix1[i] = 0;
            }
            int sch = 0;
            double number = 0;
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    if (Double.TryParse(Convert.ToString(dataGridView1[i, j].Value), out number))
                    {
                        continue;
                    }
                    else
                    {
                        sch++;
                        MessageBox.Show("Проверьте поля!");
                        goto LoopEnd;

                    }

                }
            }
        LoopEnd:;
            
            if (sch == 0)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = Convert.ToDouble(dataGridView1[i, j].Value);
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix1[i] += matrix[j, i];
                    }
                   
                }
                int min=0,max=0;
                for (int i=0; i < n; i++)
                {
                    if (matrix1[i] >= matrix1[0])
                    {
                        matrix1[0] = matrix1[i];
                        max = i;
                    }
                    else {  }           
                }
                for (int i = 0; i < n; i++)
                {
                    if (matrix1[0] <= matrix1[i])
                    {
                        
                        
                    }
                    else {matrix1[0] = matrix1[i];min = i;  }
                }
                MessageBox.Show(Convert.ToString(min)+Convert.ToString(max));
                double[] buffer = new double[m];
                for (int i = 0; i < m; i++)
                {
                    buffer[i]=matrix[i,max];
                    matrix[i,max] = matrix[i,min];
                    matrix[i,min] = buffer[i];
                }
                for (int i = 0; i < m; i++)
                {
                   
                    for (int j = 0; j < n; j++)
                    {
                        dataGridView1[i,j].Value= matrix[i, j];
                    }
                   
                }



            }
            else
            {

               MessageBox.Show("Введите значения заного!");
                sch = 0;
            }
        }

        private void mintomaxarr_button_Click(object sender, EventArgs e)
        {
            hidemainbuttons();
            groupBox4.Visible = true;
            return_button.Visible = true;
        }

        private void squares_button_Click(object sender, EventArgs e)
        {
            hidemainbuttons();
            groupBox5.Visible = true;
            return_button.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(maskedTextBox6.Text) || String.IsNullOrEmpty(maskedTextBox7.Text) || tom.check(maskedTextBox6.Text) > 0 || tom.check(maskedTextBox7.Text) > 0)
            {
                MessageBox.Show("Проверьте поля!");
            }
            else
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();

                m = int.Parse(maskedTextBox6.Text);
                n = int.Parse(maskedTextBox7.Text);

                for (int i = 0; i < m; i++)
                {
                    dataGridView2.Columns.Add(new DataGridViewColumn() { CellTemplate = new DataGridViewTextBoxCell() });
                }

                for (int i = 0; i < n; i++)
                {
                    dataGridView2.Rows.Add(new DataGridViewRow());
                }

                dataGridView2.AllowUserToAddRows = false;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sch = 0;
            double number = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    if (Double.TryParse(Convert.ToString(dataGridView2[i, j].Value), out number))
                    {
                        continue;
                    }
                    else
                    {
                        sch++;
                        MessageBox.Show("Проверьте поля!");
                        goto LoopEnd;

                    }

                }
            }
        LoopEnd:;

            if (sch == 0)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (Convert.ToDouble(dataGridView2[i, j].Value) > 0)
                        {
                            dataGridView2[i, j].Value = Convert.ToDouble(dataGridView2[i, j].Value) * Convert.ToDouble(dataGridView2[i, j].Value);
                        }
                        else { continue; }
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите значения заного!");
                sch = 0;
            }
        }

        private void strarr_button_Click(object sender, EventArgs e)
        {
            hidemainbuttons();
            return_button.Visible = true;
            listBox1.Visible = true;
            for (int i = 0; i < 12; i++)
            {
                if (i%2==0)
                    s3[i] = s1[i];
                
                else s3[i] = s2[i];
               
                
            }
        
            listBox1.Items.AddRange(s1);
            listBox1.Items.AddRange(s2);
            listBox1.Items.AddRange(s3);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(maskedTextBox4.Text) || String.IsNullOrEmpty(maskedTextBox5.Text) || tom.check(maskedTextBox4.Text) > 0 || tom.check(maskedTextBox5.Text) > 0)
            {
                MessageBox.Show("Проверьте поля!");
            }
            else
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                
                m = int.Parse(maskedTextBox4.Text);
                n = int.Parse(maskedTextBox5.Text);
                
                for (int i = 0; i < m; i++)
                {
                    dataGridView1.Columns.Add(new DataGridViewColumn() { CellTemplate = new DataGridViewTextBoxCell() });
                }
                
                for (int i = 0; i < n; i++)
                {
                    dataGridView1.Rows.Add(new DataGridViewRow());
                }
                
                dataGridView1.AllowUserToAddRows = false;

            }
        }
    }
}
