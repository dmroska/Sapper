using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace sapper
{
    public partial class Form1 : Form
    {
        int tic = 0;
        int sizebomb;
        int height;
        int widht;
        bool win = false, loser = false;
        bool FirstClick;

        int distanceBetweenButtons = 30;
        ButtonExtended[,] allButtons;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //генерируем поле и время
        private void GenerateField(int widht, int height)
        {
            //показываем таймер 
            ShowTimer();

            allButtons = new ButtonExtended[widht, height];
            for (int x = 10; (x - 10) < widht * distanceBetweenButtons; x += distanceBetweenButtons)
            {
                for (int y = 60; (y - 60) < height * distanceBetweenButtons; y += distanceBetweenButtons)
                {
                    ButtonExtended button = new ButtonExtended();
                    button.BackColor = Color.Blue;
                    button.Location = new Point(x, y);
                    button.Size = new Size(30, 30);


                    allButtons[(x - 10) / distanceBetweenButtons, (y - 60) / distanceBetweenButtons] = button;
                    Controls.Add(button);

                    button.MouseClick += new MouseEventHandler(FieldClick);
                }
            }
        }

        //показываем таймер при генерирование нового поля
        void ShowTimer()
        {
            int div = tic / 60;
            int mod = tic % 60;
            string str = System.Convert.ToString(div);
            string str1;
            if (mod < 10)
            {
                string help = "0";
                str1 = System.Convert.ToString(mod);
                str1 = help + str1;
            }
            else
                str1 = System.Convert.ToString(mod);

            string str2 = str + " : " + str1;
            label1.Text = "Время " + str2;

            label2.Text = "Мин: " + System.Convert.ToString(sizebomb);

        }

        //генерируем бомбы на поле с условием отсутствия бомбы на 1-ой нажатой кнопке
        void GenerationRandomBomb(int widht, int height, int x0, int y0)
        {
            Random rng = new Random();
            int t = 0;
            int size = widht * height;

            //заполняем кнопки бомбами с вероятностью кол-во бомб/кол-во кнопок
            for (int x = 0; x < widht; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (rng.Next(0, size) < sizebomb && t < sizebomb && (x != x0 || y != y0))
                    {
                        allButtons[x, y].isBomb = true;
                        t++;
                    }
                }
            }

            //расставляем недостающие бомбы
            if (t < sizebomb)
                while (t != sizebomb)
                {
                    int x = rng.Next(0, widht), y = rng.Next(0, height);
                    if (allButtons[x, y].isBomb == false && (x != x0 || y != y0))
                    {
                        allButtons[x, y].isBomb = true;
                        t++;
                    }
                }
        }

        //удаление всего поля кнопок с формы
        void DeleteField(int widht, int height)
        {
            for (int x = 0; x < widht; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    allButtons[x, y].Dispose();
                }
            }
            win = loser = false;
        }

        //результат после клика на кнопку поля
        void FieldClick(object sender, System.Windows.Forms.MouseEventArgs e)

        {

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Нажата правая кнопка");
                return;
            }
            ButtonExtended button = (ButtonExtended)sender;

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Нажата правая кнопка");
                for (int x = 0; x < widht; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        if (allButtons[x, y] == button)
                            allButtons[x, y].BackColor = Color.Red;
                        return;
                    }
                }
            }

            if (win == false && loser == false)
            {
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                }

                if (e.Button == MouseButtons.Left)
                {
                    if (!FirstClick)
                    {
                        FirstClick = true;
                        for (int x = 0; x < widht; x++)
                        {
                            for (int y = 0; y < height; y++)
                            {
                                if (allButtons[x, y] == button)
                                    GenerationRandomBomb(widht, height, x, y);
                            }
                        }
                    }

                    button.flag = true;
                    if (button.isBomb) //если бомба
                    {                       
                        Explode(button);
                    }
                    else
                    {
                        EmptyFieldClick(button); //если нет, то посчитать количество бомб рядом с данной клеткой
                        int t = 0;
                        for (int x = 0; x < widht; x++)
                        {
                            for (int y = 0; y < height; y++)
                            {
                                if (allButtons[x, y].isBomb || allButtons[x, y].flag == true)
                                    t++;
                            }
                        }
                        if (t == widht * height)
                        {
                            timer1.Enabled = false;
                            MessageBox.Show("Вы выиграли!");
                            win = true;
                        }
                    }
                }

            }
        }

        //показать все бомбы при взрыве   
        void Explode(ButtonExtended button)
        {
            timer1.Enabled = false;
            MessageBox.Show("Вы проиграли");
            OpenBomb();           
            loser = true;
        }

        //открыть все бомбы при проигрыше        
        void OpenBomb()
        {
            for (int x = 0; x < widht; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (allButtons[x, y].isBomb)
                    {
                        allButtons[x, y].BackColor = Color.Black;
                    }
                }
            }
        }
      
        //выводим тескстовое сообщение с количеством бомб рядом с данной кнопкой
        void EmptyFieldClick(ButtonExtended button)
        {
            for (int x = 0; x < widht; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (allButtons[x, y] == button)
                    {
                        if (CountBombAround(x, y) == 0)
                        {
                            allButtons[x, y].BackColor = Color.White;
                            OpenButtonsZero(x, y);
                        }
                        else
                        {
                            button.Text = "" + CountBombAround(x, y); // подсчёт количества бомб рядом с нажатой клеткой
                            allButtons[x, y].BackColor = Color.White;
                        }

                        return;

                    }
                }
            }
        }

        //открыть все нулевые клетки сразу
        void OpenButtonsZero(int x0, int y0)
        {
            for (int x = x0 - 1; x <= x0 + 1; x++)
            {
                for (int y = y0 - 1; y <= y0 + 1; y++)
                {
                    if (x >= 0 && x < widht && y >= 0 && y < height && allButtons[x, y].flag == false)
                    {
                        if (CountBombAround(x, y) == 0)
                        {

                            allButtons[x, y].BackColor = Color.White;
                            allButtons[x, y].flag = true;

                            OpenButtonsZero(x, y);

                        }
                        else

                            allButtons[x, y].Text = "" + CountBombAround(x, y);
                        allButtons[x, y].BackColor = Color.White;
                        allButtons[x, y].flag = true;
                    }
                }
            }
        }

        // подсчёт количества бомб рядом с нажатой клеткой
        int CountBombAround(int x0, int y0)
        {
            int BombCount = 0;
            for (int x = x0 - 1; x <= x0 + 1; x++)
            {
                for (int y = y0 - 1; y <= y0 + 1; y++)
                {
                    if (x >= 0 && x < widht && y >= 0 && y < height)
                        if (allButtons[x, y].isBomb)
                        {
                            BombCount++;
                        }
                }
            }
            return BombCount;
        }

        //удаление поля,обнуление таймера и флажков, для создания новой игры
        void NewGame()
        {
            label1.Text = "";
            timer1.Enabled = false;
            tic = 0;
            label2.Text = "";
            DeleteField(widht, height);
            win = loser = false;
        }

        //поле 5х5 3 бомбы 30 секунд
        private void легкоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            FirstClick = false;
            sizebomb = 3;
            tic = 30;
            height = 5;
            widht = 5;
            GenerateField(5, 5);
        }

        //поле 10х10 8 бомб 1.5 минуты      
        private void сложноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            FirstClick = false;
            sizebomb = 8;
            tic = 90;
            height = 10;
            widht = 10;
            GenerateField(10, 10);
        }

        //поле 15х15 20 бомб  2.5 минут      
        private void профиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            FirstClick = false;
            sizebomb = 20;
            tic = 150;
            height = 15;
            widht = 15;
            GenerateField(15, 15);
        }

        //поле 21х45 80 бомб 5 минут
        private void хардкорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            FirstClick = false;
            sizebomb = 80;
            tic = 300;
            height = 21;
            widht = 45;
            GenerateField(45, 21);
        }     

        //наша кнопка с полями бомбы и флажка, отвечающего за открытие кнопки
        class ButtonExtended : Button
        {
            public bool isBomb, flag = false;
        }

        private void цветФонаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // создание объекта окна диалога
            ColorDialog dlg = new ColorDialog();
            // показ диалога на экран и проверка, с помощью какой кнопки он был закрыт
            if (dlg.ShowDialog() == DialogResult.OK)
                // изменение цвета фона путем обращения к цвету, выбранному в диалоге
                BackColor = dlg.Color;
        }

        //приоситановить игру, пока тикает таймер
        private void остановитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (timer1.Enabled == true && tic != 0 && win == false && loser == false)
            {
                timer1.Enabled = false;
                win = loser = true;
            }
        }

        //основной таймер
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            tic--;
            int div = tic / 60;
            int mod = tic % 60;
            string str = System.Convert.ToString(div);
            string str1;
            if (mod < 10)
            {
                string help = "0";
                str1 = System.Convert.ToString(mod);
                str1 = help + str1;
            }
            else
                str1 = System.Convert.ToString(mod);

            string str2 = str + " : " + str1;
            label1.Text = "Время " + str2; ;
            if (tic <= 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Вы проиграли");
                OpenBomb();
                loser = true;
            }
        }

        //продолжить игру после нажатия остановить (есть возможность начать новую игру)
        private void продолжитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (win == true && loser == true)
            {
                timer1.Enabled = true;
                win = loser = false;
            }
        }

        private void свояИграToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewGame();
            // Form Form2 = new Form();
            //  Form2.ShowDialog();

            TextBox[,] tb = new TextBox[1, 5];
            Label[,] l = new Label[1, 5];

            for (int i = 0; i < 5; i++)
            {

                l[0, i] = new System.Windows.Forms.Label();
                l[0, i].Location = new System.Drawing.Point(20, 70 + i * 23);
                l[0, i].Size = new System.Drawing.Size(75, 23);
                l[0, i].Text = "поле";
                Controls.Add(l[0, i]);

                tb[0, i] = new System.Windows.Forms.TextBox();
                tb[0, i].Location = new System.Drawing.Point(120, 70 + i * 23);
                tb[0, i].Size = new System.Drawing.Size(75, 23);
                Controls.Add(tb[0, i]);

            }

            l[0, 0].Text = "мины";
            l[0, 1].Text = "ширина";
            l[0, 2].Text = "длина";
            l[0, 3].Text = "время мин";
            l[0, 4].Text = "время сек";

            ButtonExtended button1 = new ButtonExtended();

            button1.Location = new Point(40, 200);
            button1.Size = new Size(30, 30);
            button1.Text = "OK";

            Controls.Add(button1);
            button1.MouseClick += new MouseEventHandler(FieldClick1);

            void FieldClick1(object sender1, System.Windows.Forms.MouseEventArgs e1)
            {
                ButtonExtended button = (ButtonExtended)sender1;

                if (e1.Button == MouseButtons.Left)
                {
                    //ф-ия, ф-ии обработки введённых полей
                    if (tb[0, 0].Text == "" || tb[0, 1].Text == "" || tb[0, 2].Text == "" || (tb[0, 3].Text == "" && tb[0, 4].Text == ""))
                    {
                        MessageBox.Show("Не все поля введены");
                        return;
                    }

                    if (Convert.ToInt32(tb[0, 0].Text) >= (Convert.ToInt32(tb[0, 1].Text) * Convert.ToInt32(tb[0, 2].Text)))
                    {
                        MessageBox.Show("Количество бомб не может быть больше или равно размеру поля");
                        return;
                    }

                    FirstClick = false;
                    sizebomb = Convert.ToInt32(tb[0, 0].Text);
                    widht = Convert.ToInt32(tb[0, 1].Text);
                    height = Convert.ToInt32(tb[0, 2].Text);
                    if (tb[0, 4].Text == "")
                        tic = 0;
                    else
                        tic = Convert.ToInt32(tb[0, 4].Text);

                    if (tb[0, 3].Text != "")
                        tic = tic + 60 * Convert.ToInt32(tb[0, 3].Text);

                    for (int i = 0; i < 5; i++)
                    {
                        l[0, i].Dispose();
                        tb[0, i].Dispose();
                    }
                    button1.Dispose();

                    GenerateField(widht, height);
                }
            }
        }
    }
}
