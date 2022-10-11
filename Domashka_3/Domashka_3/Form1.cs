using System;
using System.Drawing;
using System.Windows.Forms;

namespace Domashka_3
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            Text = "Домашняя работа №3. УТС-21. Пыльнюк Николай";

            label1.Text = "Приложение для проверки знаний таблицы умножения";
            label2.Text = "Вычислите произведение";

            button1.Text = "Начать";

            textBox4.Text = "0";
            textBox5.Text = "0";

            radioButton1.Text = "A";
            radioButton2.Text = "B";
            radioButton3.Text = "C";
            radioButton4.Text = "D";
        }



        void generation_example()       //твоя функция генерации
        {
            // —------— Рандомайзер, выдающий ответы —--------
            Random rnd1 = new Random();         //Создание объекта для генерации чисел answer
            int value1 = rnd1.Next(1, 10);      //Получить случайное число (в диапазоне от 1 до 9)

            Random rnd2 = new Random();
            int value2 = rnd2.Next(1, 10);

            Random rnd3 = new Random();
            int answer1 = rnd3.Next(1, 82);     //Получить случайное число (в диапазоне от 1 до 81)

            Random rnd4 = new Random();
            int answer2 = rnd4.Next(1, 82);

            Random rnd5 = new Random();
            int answer3 = rnd5.Next(1, 82);


            // —------— Рандомайзер на позицию правильного ответа —--------
            Random rnd6 = new Random();
            int position = rnd6.Next(1, 5);
        } 

        bool is_second_click = false;           //переменная в глобальной области видимости



        void button1_Click(object sender, EventArgs e)
        {
            

            if (button1.Text == "Начать")
            {
                button1.Text = "Проверить";
            }


            //проверка состояния флага is_second_click
            if (is_second_click)
            {
                //вызов функции генерации, когда is_second_click == true
                generation_example();
            }
            //смена состояния флага is_second_click
            is_second_click = !is_second_click;


            


            textBox3.Text = Convert.ToString(value1);
            textBox2.Text = Convert.ToString(value2);


            // ---------- С помощью рандомайзера определяем позиции правильного и неправильных ответов ----------
            if (position == 1)
            {
                radioButton1.Text = Convert.ToString(value1 * value2);

                radioButton2.Text = Convert.ToString(answer1);
                radioButton3.Text = Convert.ToString(answer2);
                radioButton4.Text = Convert.ToString(answer3);
            }

            else if (position == 2)
            {
                radioButton2.Text = Convert.ToString(value1 * value2);

                radioButton1.Text = Convert.ToString(answer1);
                radioButton3.Text = Convert.ToString(answer2);
                radioButton4.Text = Convert.ToString(answer3);
            }

            else if (position == 3)
            {
                radioButton3.Text = Convert.ToString(value1 * value2);

                radioButton1.Text = Convert.ToString(answer1);
                radioButton2.Text = Convert.ToString(answer2);
                radioButton4.Text = Convert.ToString(answer3);
            }

            else if (position == 4)
            {
                radioButton4.Text = Convert.ToString(value1 * value2);

                radioButton1.Text = Convert.ToString(answer1);
                radioButton2.Text = Convert.ToString(answer2);
                radioButton3.Text = Convert.ToString(answer3);
            }
            




            // ---------- Проверяем правильность выбранного ответа ----------

            if (radioButton1.Checked == true)
            {
                if (Convert.ToInt32(radioButton1.Text) == value1 * value2)
                {
                    textBox1.Text = "Верно!";
                    textBox1.BackColor = Color.LimeGreen;
                    textBox5.Text = Convert.ToString(Convert.ToInt32(textBox5.Text) + 1);
                }
                else
                {
                    textBox1.Text = "Не верно!";
                    textBox1.BackColor = Color.OrangeRed;
                    textBox4.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) + 1);
                }
            }

            if (radioButton2.Checked == true)
            {
                if (Convert.ToByte(radioButton2.Text) == value1 * value2)
                {
                    textBox1.Text = "Верно!";
                    textBox1.BackColor = Color.LimeGreen;
                    textBox5.Text = Convert.ToString(Convert.ToInt32(textBox5.Text) + 1);
                }
                else
                {
                    textBox1.Text = "Не верно!";
                    textBox1.BackColor = Color.OrangeRed;
                    textBox4.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) + 1);
                }
            }

            if (radioButton3.Checked == true)
            {
                if (Convert.ToByte(radioButton3.Text) == value1 * value2)
                {
                    textBox1.Text = "Верно!";
                    textBox1.BackColor = Color.LimeGreen;
                    textBox5.Text = Convert.ToString(Convert.ToInt32(textBox5.Text) + 1);
                }
                else
                {
                    textBox1.Text = "Не верно!";
                    textBox1.BackColor = Color.OrangeRed;
                    textBox4.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) + 1);
                }
            }

            if (radioButton4.Checked == true)
            {
                if (Convert.ToByte(radioButton4.Text) == value1 * value2)
                {
                    textBox1.Text = "Верно!";
                    textBox1.BackColor = Color.LimeGreen;
                    textBox5.Text = Convert.ToString(Convert.ToInt32(textBox5.Text) + 1);
                }
                else
                {
                    textBox1.Text = "Не верно!";
                    textBox1.BackColor = Color.OrangeRed;
                    textBox4.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) + 1);
                }
            }

           
        

        }




    }
}

