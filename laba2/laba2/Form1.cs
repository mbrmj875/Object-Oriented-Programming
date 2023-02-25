using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
enum Figure
{
    Square = 1,
    Circle,
    Line,
    Ellipse,
    Rectangle,

}

enum Action
{
    Move = 1,
    Change,
    Delete,


}
namespace laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideall();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Square[] squares = new Square[1];
        public int squaresCnt = 0;
        public Line[] lines = new Line[1];
        public int linesCnt = 0;
        public Circle[] circles = new Circle[1];
        public int circlesCnt = 0;
        public Ellipse[] ellipses = new Ellipse[1];
        public int ellipsesCnt = 0;
        public ClassLibrary.Rectangle[] rectangles = new ClassLibrary.Rectangle[1];
        public int rectsCnt = 0;



        public bool[] checkedSquaresList = new bool[0];
        public bool[] checkedLinesList = new bool[0];
        public bool[] checkedCirclesList = new bool[0];
        public bool[] checkedEllipsesList = new bool[0];
        public bool[] checkedRectanglesList = new bool[0];


        Figure figureIndex;
        Action actionIndex;

        public void hideall()
        {
            square_user.Visible = false;
            square_random.Visible = false;


            line_user.Visible = false;
            line_random.Visible = false;


            circle_user.Visible = false;
            circle_random.Visible = false;


            ellipse_user.Visible = false;
            ellipse_random.Visible = false;


            rectangle_user.Visible = false;
            rectangle_random.Visible = false;



        }

        public void enablebuttons(bool toDo)
        {
            move_button.Enabled = toDo;
            change_button.Enabled = toDo;

            delete_button.Enabled = toDo;
            square_button.Enabled = toDo;
            square_button.Enabled = toDo;
            square_random.Enabled = toDo;
            line_button.Enabled = toDo;
            line_user.Enabled = toDo;
            line_random.Enabled = toDo;
            circle_button.Enabled = toDo;
            circle_user.Enabled = toDo;
            circle_random.Enabled = toDo;
            ellipse_button.Enabled = toDo;
            ellipse_user.Enabled = toDo;
            ellipse_random.Enabled = toDo;
            rectangle_button.Enabled = toDo;
            rectangle_user.Enabled = toDo;
            rectangle_random.Enabled = toDo;

        }
        public void restorePaintments()
        {
            Graphics g = pictureBox1.CreateGraphics();
            pictureBox1.Refresh();

            for (int i = 0; i < squaresCnt; i++)
            {
                squares[i].Show(g, Color.Green);
            }

            for (int i = 0; i < linesCnt; i++)
            {
                lines[i].Show(g, Color.Green);
            }

            for (int i = 0; i < circlesCnt; i++)
            {
                circles[i].Show(g, Color.Green);
            }

            for (int i = 0; i < ellipsesCnt; i++)
            {
                ellipses[i].Show(g, Color.Green);
            }

            for (int i = 0; i < rectsCnt; i++)
            {
                rectangles[i].Show(g, Color.Green);
            }


        }

        public void fillCheckedListIn()
        {
            checkedListBox1.Items.Clear();

            checkedListBox1.Items.Add("---Все квадраты---");
            for (int i = 0; i < squaresCnt; i++)
            {
                checkedListBox1.Items.Add($"Квадрат {i + 1}");
            }



            checkedListBox1.Items.Add("---Все круги---");
            for (int i = 0; i < circlesCnt; i++)
            {
                checkedListBox1.Items.Add($"Круг {i + 1}");
            }
            checkedListBox1.Items.Add("---Все линии---");
            for (int i = 0; i < linesCnt; i++)
            {
                checkedListBox1.Items.Add($"Линия {i + 1}");
            }

            checkedListBox1.Items.Add("---Все эллипсы---");
            for (int i = 0; i < ellipsesCnt; i++)
            {
                checkedListBox1.Items.Add($"Эллипс {i + 1}");
            }

            checkedListBox1.Items.Add("---Все прямоугольники---");
            for (int i = 0; i < rectsCnt; i++)
            {
                checkedListBox1.Items.Add($"Прямоугольник {i + 1}");
            }


        }

        public void fillSquaresandCirclesListIn()
        {
            checkedListBox1.Items.Clear();

            checkedListBox1.Items.Add("---Все квадраты---");
            for (int i = 0; i < squaresCnt; i++)
            {
                checkedListBox1.Items.Add($"Квадрат {i + 1}");
            }
            checkedListBox1.Items.Add("---Все круги---");
            for (int i = 0; i < circlesCnt; i++)
            {
                checkedListBox1.Items.Add($"Круг{i + 1}");
            }
        }


        private void square_button_Click(object sender, EventArgs e)
        {
            hideall();
            square_user.Visible = true;
            square_random.Visible = true;
        }

        private void line_button_Click(object sender, EventArgs e)
        {
            hideall();
            line_user.Visible = true;
            line_random.Visible = true;
        }

        private void circle_button_Click(object sender, EventArgs e)
        {
            hideall();
            circle_user.Visible = true;
            circle_random.Visible = true;
        }

        private void ellipse_button_Click(object sender, EventArgs e)
        {
            hideall();
            ellipse_user.Visible = true;
            ellipse_random.Visible = true;
        }

        private void rectangle_button_Click(object sender, EventArgs e)
        {
            hideall();
            rectangle_user.Visible = true;
            rectangle_random.Visible = true;
        }

        private void square_user_Click(object sender, EventArgs e)
        {
            figureIndex = Figure.Square;

            //Во избежание налеганий меню друг на друга
            square_button.Enabled = false;
            line_button.Enabled = false;
            circle_button.Enabled = false;
            ellipse_button.Enabled = false;
            rectangle_button.Enabled = false;


            hideall();

            input_panel.Visible = true;
            x4.Visible = false;
            textBox4.Visible = false;
            main_label1.Text = "Координаты центра квадрата";
            main_label1.Visible = true;
            main_label2.Text = "Сторона квадрата";
            main_label2.Visible = true;
            x1.Text = "X";
            x1.Visible = true;
            x2.Text = "Y";
            x2.Visible = true;
            x3.Text = "A:";
            x3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
        }

        private void line_user_Click(object sender, EventArgs e)
        {
            figureIndex = Figure.Line;

            //Во избежание налеганий меню друг на друга
            square_button.Enabled = false;
            line_button.Enabled = false;
            circle_button.Enabled = false;
            ellipse_button.Enabled = false;
            rectangle_button.Enabled = false;


            hideall();

            input_panel.Visible = true;
            main_label1.Text = "Координаты начала линии";
            main_label1.Visible = true;
            main_label2.Text = "Координаты конца линии";
            main_label2.Visible = true;
            x1.Visible = true;
            x2.Visible = true;
            x3.Text = "X:";
            x3.Visible = true;
            x4.Text = "Y:";
            x4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }

        private void circle_user_Click(object sender, EventArgs e)
        {
            figureIndex = Figure.Circle;

            //Во избежание налеганий меню друг на друга
            square_button.Enabled = false;
            line_button.Enabled = false;
            circle_button.Enabled = false;
            ellipse_button.Enabled = false;
            rectangle_button.Enabled = false;


            hideall();

            input_panel.Visible = true;
            textBox4.Visible = false;
            x4.Visible = false;
            main_label1.Text = "Координаты центра круга";
            main_label1.Visible = true;
            main_label2.Text = "Радиус круга";
            main_label2.Visible = true;
            x1.Visible = true;
            x2.Visible = true;
            x3.Text = "R:";
            x3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
        }

        private void ellipse_user_Click(object sender, EventArgs e)
        {
            figureIndex = Figure.Ellipse;

            //Во избежание налеганий меню друг на друга
            square_button.Enabled = false;
            line_button.Enabled = false;
            circle_button.Enabled = false;
            ellipse_button.Enabled = false;
            rectangle_button.Enabled = false;


            hideall();

            input_panel.Visible = true;
            main_label1.Text = "Координаты центра эллипса";
            main_label1.Visible = true;
            main_label2.Text = "Оси эллипса";
            main_label2.Visible = true;
            x1.Visible = true;
            x2.Visible = true;
            x3.Text = "R1:";
            x3.Visible = true;
            x4.Text = "R2";
            x4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }

        private void rectangle_user_Click(object sender, EventArgs e)
        {
            figureIndex = Figure.Rectangle;

            //Во избежание налеганий меню друг на друга
            square_button.Enabled = false;
            line_button.Enabled = false;
            circle_button.Enabled = false;
            ellipse_button.Enabled = false;
            rectangle_button.Enabled = false;


            hideall();

            input_panel.Visible = true;
            main_label1.Text = "Координаты центра прямоугольника";
            main_label1.Visible = true;
            main_label2.Text = "Стороны прямоугольника";
            main_label2.Visible = true;
            x1.Visible = true;
            x2.Visible = true;
            x3.Text = "A:";
            x3.Visible = true;
            x4.Text = "B:";
            x4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }


        private void cancel_button_Click(object sender, EventArgs e)
        {
            //Возвращаем верхние кнопки в активное состояние
            square_button.Enabled = true;
            line_button.Enabled = true;
            circle_button.Enabled = true;
            ellipse_button.Enabled = true;
            rectangle_button.Enabled = true;


            //Скрытие всех промеуточных меню
            input_panel.Visible = false;
            main_label1.Visible = false;
            main_label2.Visible = false;
            x1.Visible = false;
            x2.Visible = false;
            x3.Visible = false;
            x4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();

            //Возвращаем верхние кнопки в активное состояние
            square_button.Enabled = true;
            line_button.Enabled = true;
            circle_button.Enabled = true;
            ellipse_button.Enabled = true;
            rectangle_button.Enabled = true;


            //Скрытие всех промеуточных меню
            input_panel.Visible = false;
            main_label1.Visible = false;
            main_label2.Visible = false;
            x1.Visible = false;
            x2.Visible = false;
            x3.Visible = false;
            x4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;

            switch (figureIndex)
            {
                case Figure.Square:
                    try
                    {
                        int x = int.Parse(textBox1.Text);
                        int y = int.Parse(textBox2.Text);
                        int sideLenght = int.Parse(textBox3.Text);

                        Array.Resize(ref squares, squaresCnt + 1);
                        squares[squaresCnt] = new Square(x, y, sideLenght);
                        squares[squaresCnt].Show(g, Color.Green);

                        squaresCnt++;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка ввода. Повторите, пожалуйста, ввод!");
                    }
                    break;
                case Figure.Circle:
                    try
                    {
                        int x = int.Parse(textBox1.Text);
                        int y = int.Parse(textBox2.Text);
                        int r = int.Parse(textBox3.Text);

                        Array.Resize<Circle>(ref circles, circlesCnt + 1);
                        circles[circlesCnt] = new Circle(x, y, r);
                        circles[circlesCnt].Show(g, Color.Green);

                        circlesCnt++;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка ввода. Повторите, пожалуйста, ввод!");
                    }
                    break;
                case Figure.Line:
                    try
                    {
                        int x1 = int.Parse(textBox1.Text);
                        int y1 = int.Parse(textBox2.Text);
                        int x2 = int.Parse(textBox3.Text);
                        int y2 = int.Parse(textBox4.Text);

                        Array.Resize<Line>(ref lines, linesCnt + 1);
                        lines[linesCnt] = new Line(x1, y1, x2, y2);
                        lines[linesCnt].Show(g, Color.Green);

                        linesCnt++;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка ввода. Повторите, пожалуйста, ввод!");
                    }
                    break;
                case Figure.Ellipse:
                    try
                    {
                        int x = int.Parse(textBox1.Text);
                        int y = int.Parse(textBox2.Text);
                        int r1 = int.Parse(textBox3.Text);
                        int r2 = int.Parse(textBox4.Text);

                        Array.Resize<Ellipse>(ref ellipses, ellipsesCnt + 1);
                        ellipses[ellipsesCnt] = new Ellipse(x, y, r1, r2);
                        ellipses[ellipsesCnt].Show(g, Color.Green);

                        ellipsesCnt++;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка ввода. Повторите, пожалуйста, ввод!");
                    }
                    break;
                case Figure.Rectangle:
                    try
                    {
                        int x = int.Parse(textBox1.Text);
                        int y = int.Parse(textBox2.Text);
                        int height = int.Parse(textBox3.Text);
                        int wight = int.Parse(textBox4.Text);

                        Array.Resize<ClassLibrary.Rectangle>(ref rectangles, rectsCnt + 1);
                        rectangles[rectsCnt] = new ClassLibrary.Rectangle(x, y, height, wight);
                        rectangles[rectsCnt].Show(g, Color.Green);

                        rectsCnt++;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка ввода. Повторите, пожалуйста, ввод!");
                    }
                    break;


            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void square_random_Click(object sender, EventArgs e)
        {
            Array.Resize(ref squares, squaresCnt + 1);
            squares[squaresCnt] = new Square();
            Graphics g = pictureBox1.CreateGraphics();
            squares[squaresCnt].Show(g, Color.Green);
            squaresCnt++;
        }

        private void circle_random_Click(object sender, EventArgs e)
        {
            Array.Resize<Circle>(ref circles, circlesCnt + 1);
            circles[circlesCnt] = new Circle();
            Graphics g = pictureBox1.CreateGraphics();
            circles[circlesCnt].Show(g, Color.Green);

            circlesCnt++;
        }

        private void line_random_Click(object sender, EventArgs e)
        {
            Array.Resize<Line>(ref lines, linesCnt + 1);
            lines[linesCnt] = new Line();
            Graphics g = pictureBox1.CreateGraphics();
            lines[linesCnt].Show(g, Color.Green);

            linesCnt++;
        }

        private void ellipse_random_Click(object sender, EventArgs e)
        {
            Array.Resize<Ellipse>(ref ellipses, ellipsesCnt + 1);
            ellipses[ellipsesCnt] = new Ellipse();
            Graphics g = pictureBox1.CreateGraphics();
            ellipses[ellipsesCnt].Show(g, Color.Green);

            ellipsesCnt++;
        }

        private void rectangle_random_Click(object sender, EventArgs e)
        {
            Array.Resize<ClassLibrary.Rectangle>(ref rectangles, rectsCnt + 1);
            rectangles[rectsCnt] = new ClassLibrary.Rectangle();
            Graphics g = pictureBox1.CreateGraphics();
            rectangles[rectsCnt].Show(g, Color.Green);

            rectsCnt++;
        }




        private void move_button_Click(object sender, EventArgs e)
        {
            actionIndex = Action.Move;
            enablebuttons(false);

            //Открываем единое меню действий
            checkedListBox1.Visible = true;
            confirm_button1.Visible = true;
            cancel_button1.Visible = true;
            X.Text = "X:";
            X.Visible = true;
            Y.Text = "Y:";
            Y.Visible = true;
            textBox6.Visible = true;
            textBox5.Visible = true;

            fillCheckedListIn();
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            actionIndex = Action.Change;
            enablebuttons(false);

            //Открываем единое меню действий
            checkedListBox1.Visible = true;
            confirm_button1.Visible = true;
            cancel_button1.Visible = true;
            X.Text = "A:";
            X.Visible = true;
            Y.Text = "R:";
            Y.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;

            fillSquaresandCirclesListIn();

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            actionIndex = Action.Delete;
            enablebuttons(false);

            //Открываем единое меню действий
            checkedListBox1.Visible = true;
            confirm_button1.Visible = true;
            cancel_button1.Visible = true;

            fillCheckedListIn();
        }



        private void confirm_button1_Click(object sender, EventArgs e)
        {
            enablebuttons(true);

            //Прячем меню действий
            checkedListBox1.Visible = false;
            checkedListBox1.ClearSelected();
            confirm_button1.Visible = false;
            cancel_button1.Visible = false;
            X.Visible = false;
            Y.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

            switch (actionIndex)
            {
                case Action.Move:
                    try
                    {
                        int x = int.Parse(textBox5.Text);
                        int y = int.Parse(textBox6.Text);

                        for (int i = 0; i < squaresCnt; i++)
                        {
                            if (checkedSquaresList[i])
                            {
                                squares[i].MoveTo(x, y);
                                checkedSquaresList[i] = false;
                            }
                        }

                        for (int i = 0; i < linesCnt; i++)
                        {
                            if (checkedLinesList[i])
                            {
                                lines[i].MoveTo(x, y);
                                checkedLinesList[i] = false;
                            }
                        }

                        for (int i = 0; i < circlesCnt; i++)
                        {
                            if (checkedCirclesList[i])
                            {
                                circles[i].MoveTo(x, y);
                                checkedCirclesList[i] = false;
                            }
                        }

                        for (int i = 0; i < ellipsesCnt; i++)
                        {
                            if (checkedEllipsesList[i])
                            {
                                ellipses[i].MoveTo(x, y);
                                checkedEllipsesList[i] = false;
                            }
                        }

                        for (int i = 0; i < rectsCnt; i++)
                        {
                            if (checkedRectanglesList[i])
                            {
                                rectangles[i].MoveTo(x, y);
                                checkedRectanglesList[i] = false;
                            }
                        }


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка ввода. Попробуйте ещё раз!");
                    }
                    break;
                case Action.Change:
                    try
                    {
                        int sideLenght = int.Parse(textBox5.Text);
                        int radiussize = int.Parse(textBox6.Text);
                        for (int i = 0; i < circlesCnt; i++)
                        {
                            if (checkedCirclesList[i])
                            {
                                circles[i].ChangeRadius(radiussize);
                                checkedCirclesList[i] = false;
                            }
                        }


                        for (int i = 0; i < squaresCnt; i++)
                        {
                            if (checkedSquaresList[i])
                            {
                                squares[i].ChangeSideLenght(sideLenght);
                                checkedSquaresList[i] = false;
                            }
                        }

                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка ввода. Попробуйте ещё раз!");
                    }
                    break;
                case Action.Delete:
                    //Создаем новые счетчики для массивов из неудаляемых объектов
                    int newSquaresCnt = 0;
                    int newLinesCnt = 0;
                    int newCirclesCnt = 0;
                    int newEllipsesCnt = 0;
                    int newRectanglesCnt = 0;

                    //Считаем оставшиеся объекты каждого класса
                    for (int i = 0; i < checkedSquaresList.Length; i++)
                    {
                        if (!(checkedSquaresList[i])) newSquaresCnt++;
                    }

                    for (int i = 0; i < checkedLinesList.Length; i++)
                    {
                        if (!(checkedLinesList[i])) newLinesCnt++;
                    }

                    for (int i = 0; i < checkedCirclesList.Length; i++)
                    {
                        if (!(checkedCirclesList[i])) newCirclesCnt++;
                    }

                    for (int i = 0; i < checkedEllipsesList.Length; i++)
                    {
                        if (!(checkedEllipsesList[i])) newEllipsesCnt++;
                    }

                    for (int i = 0; i < checkedRectanglesList.Length; i++)
                    {
                        if (!(checkedRectanglesList[i])) newRectanglesCnt++;
                    }


                    //Создаем новые массивы под классы c оставшимся количеством объектов
                    Square[] newSquares = new Square[newSquaresCnt];
                    Line[] newLines = new Line[newLinesCnt];
                    Circle[] newCircles = new Circle[newCirclesCnt];
                    Ellipse[] newEllipses = new Ellipse[newEllipsesCnt];
                    ClassLibrary.Rectangle[] newRectangles = new ClassLibrary.Rectangle[newRectanglesCnt];


                    for (int i = 0, j = 0; i < squaresCnt; i++)
                    {
                        if (!(checkedSquaresList[i]))
                        {
                            newSquares[j] = squares[i];
                            j++;
                        }
                        else checkedSquaresList[i] = false;
                    }
                    squares = newSquares;

                    for (int i = 0, j = 0; i < linesCnt; i++)
                    {
                        if (!(checkedLinesList[i]))
                        {
                            newLines[j] = lines[i];
                            j++;
                        }
                        else checkedLinesList[i] = false;
                    }
                    lines = newLines;

                    for (int i = 0, j = 0; i < circlesCnt; i++)
                    {
                        if (!(checkedCirclesList[i]))
                        {
                            newCircles[j] = circles[i];
                            j++;
                        }
                        else checkedCirclesList[i] = false;
                    }
                    circles = newCircles;

                    for (int i = 0, j = 0; i < ellipsesCnt; i++)
                    {
                        if (!(checkedEllipsesList[i]))
                        {
                            newEllipses[j] = ellipses[i];
                            j++;
                        }
                        else checkedEllipsesList[i] = false;
                    }
                    ellipses = newEllipses;

                    for (int i = 0, j = 0; i < rectsCnt; i++)
                    {
                        if (!(checkedRectanglesList[i]))
                        {
                            newRectangles[j] = rectangles[i];
                            j++;
                        }
                        else checkedRectanglesList[i] = false;
                    }
                    rectangles = newRectangles;



                    Array.Resize<bool>(ref checkedSquaresList, newSquaresCnt);
                    Array.Resize<bool>(ref checkedLinesList, newLinesCnt);
                    Array.Resize<bool>(ref checkedCirclesList, newCirclesCnt);
                    Array.Resize<bool>(ref checkedEllipsesList, newEllipsesCnt);
                    Array.Resize<bool>(ref checkedRectanglesList, newRectanglesCnt);
                    ;

                    squaresCnt = newSquaresCnt - 1;
                    linesCnt = newLinesCnt - 1;
                    circlesCnt = newCirclesCnt - 1;
                    ellipsesCnt = newEllipsesCnt - 1;
                    rectsCnt = newRectanglesCnt - 1;


                    break;

            }
            textBox5.Clear();
            textBox6.Clear();
            restorePaintments();
            checkedListBox1.ClearSelected();
        }

        private void cancel_button1_Click(object sender, EventArgs e)
        {
            enablebuttons(true);

            //Прячем меню действий
            checkedListBox1.Visible = false;
            checkedListBox1.ClearSelected();
            confirm_button1.Visible = false;
            cancel_button1.Visible = false;
            X.Visible = false;
            Y.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

            for (int i = 0; i < checkedSquaresList.Length; i++)
            {
                checkedSquaresList[i] = false;
            }
            for (int i = 0; i < checkedLinesList.Length; i++)
            {
                checkedLinesList[i] = false;
            }
            for (int i = 0; i < checkedCirclesList.Length; i++)
            {
                checkedCirclesList[i] = false;
            }

            textBox5.Clear();
            textBox6.Clear();
            restorePaintments();
        }

        private void checkedListBox1_ItemCheck(Object sender, ItemCheckEventArgs e)
        {
            Array.Resize<bool>(ref checkedSquaresList, squaresCnt + 1);
            Array.Resize<bool>(ref checkedLinesList, linesCnt + 1);
            Array.Resize<bool>(ref checkedCirclesList, circlesCnt + 1);
            Array.Resize<bool>(ref checkedEllipsesList, ellipsesCnt + 1);
            Array.Resize<bool>(ref checkedRectanglesList, rectsCnt + 1);

            Graphics g = pictureBox1.CreateGraphics();

            Dictionary<string, int> figuresPositions = new Dictionary<string, int>(6);
            figuresPositions.Add("firstSquare", 1);
            figuresPositions.Add("firstCircle", squaresCnt + 2);
            figuresPositions.Add("firstLine", squaresCnt + circlesCnt + 3);
            figuresPositions.Add("firstEllipse", squaresCnt + linesCnt + circlesCnt + 4);
            figuresPositions.Add("firstRectangle", squaresCnt + linesCnt + circlesCnt + ellipsesCnt + 5);



            //Первым в списке всегда пункт "Все квадраты"
            if (e.Index == figuresPositions["firstSquare"] - 1)
            {
                for (int i = figuresPositions["firstSquare"]; i < figuresPositions["firstCircle"] - 1; i++)
                {
                    checkedListBox1.SetItemChecked(i, (e.NewValue == CheckState.Checked));
                    checkedSquaresList[i - 1] = (e.NewValue == CheckState.Checked);
                }
            }
            //Если выбран конкретный квадрат
            else if (e.Index < figuresPositions["firstCircle"] - 1)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    squares[e.Index - 1].Show(g, Color.DarkRed);
                    checkedSquaresList[e.Index - 1] = true;
                }
                else
                {
                    squares[e.Index - 1].Show(g, Color.Green);
                    checkedSquaresList[e.Index - 1] = false;
                }
            }
            //После линий всегда идут "Все круги"
            else if (e.Index == figuresPositions["firstCircle"] - 1)
            {
                for (int i = figuresPositions["firstCircle"]; i < figuresPositions["firstLine"] - 1; i++)
                {
                    checkedListBox1.SetItemChecked(i, (e.NewValue == CheckState.Checked));
                    checkedCirclesList[i - figuresPositions["firstCircle"]] = (e.NewValue == CheckState.Checked);
                }
            }
            //Если выбран конкретный круг
            else if (e.Index < figuresPositions["firstLine"] - 1)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    circles[e.Index - figuresPositions["firstCircle"]].Show(g, Color.DarkRed);
                    checkedCirclesList[e.Index - figuresPositions["firstCircle"]] = true;
                }
                else
                {
                    circles[e.Index - figuresPositions["firstCircle"]].Show(g, Color.Green);
                    checkedCirclesList[e.Index - figuresPositions["firstCircle"]] = false;
                }
            }
            else if (e.Index == figuresPositions["firstLine"] - 1)
            {
                for (int i = figuresPositions["firstLine"]; i < figuresPositions["firstEllipse"] - 1; i++)
                {
                    checkedListBox1.SetItemChecked(i, (e.NewValue == CheckState.Checked));
                    checkedLinesList[i - figuresPositions["firstLine"]] = (e.NewValue == CheckState.Checked);
                }
            }
            //Если выбрана конкретая линия
            else if (e.Index < figuresPositions["firstEllipse"] - 1)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    lines[e.Index - figuresPositions["firstLine"]].Show(g, Color.DarkRed);
                    checkedLinesList[e.Index - figuresPositions["firstLine"]] = true;
                }
                else
                {
                    lines[e.Index - figuresPositions["firstLine"]].Show(g, Color.Green);
                    checkedLinesList[e.Index - figuresPositions["firstLine"]] = false;
                }
            }
            //После кругов всегда идут "Все эллипсы"
            else if (e.Index == figuresPositions["firstEllipse"] - 1)
            {
                for (int i = figuresPositions["firstEllipse"]; i < figuresPositions["firstRectangle"] - 1; i++)
                {
                    checkedListBox1.SetItemChecked(i, (e.NewValue == CheckState.Checked));
                    checkedEllipsesList[i - figuresPositions["firstEllipse"]] = (e.NewValue == CheckState.Checked);
                }
            }
            //Если выбран конкретный эллипс
            else if (e.Index < figuresPositions["firstRectangle"] - 1)
            {
                if (e.NewValue == CheckState.Checked)

                {
                    ellipses[e.Index - figuresPositions["firstEllipse"]].Show(g, Color.DarkRed);
                    checkedEllipsesList[e.Index - figuresPositions["firstEllipse"]] = true;
                }
                else
                {
                    ellipses[e.Index - figuresPositions["firstEllipse"]].Show(g, Color.Green);
                    checkedEllipsesList[e.Index - figuresPositions["firstEllipse"]] = false;
                }
            }
            //После эллипсов всегда идут "Все прямоугольники"
            else if (e.Index == figuresPositions["firstRectangle"] - 1)
            {
                for (int i = figuresPositions["firstRectangle"]; i < figuresPositions["firstRectangle"] + rectsCnt; i++)
                {
                    checkedListBox1.SetItemChecked(i, (e.NewValue == CheckState.Checked));
                    checkedRectanglesList[i - figuresPositions["firstRectangle"]] = (e.NewValue == CheckState.Checked);
                }
            }
            //Если выбран конкретный прямоугольник
            else if (e.NewValue == CheckState.Checked)
            {


                rectangles[e.Index - figuresPositions["firstRectangle"]].Show(g, Color.DarkRed);
                checkedRectanglesList[e.Index - figuresPositions["firstRectangle"]] = true;
            }
            else
            {
                rectangles[e.Index - figuresPositions["firstRectangle"]].Show(g, Color.Green);
                checkedRectanglesList[e.Index - figuresPositions["firstRectangle"]] = false;
            }
        }





        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
