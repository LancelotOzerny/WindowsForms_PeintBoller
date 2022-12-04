using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab5_V3
{
    public partial class Peintboller : Panel
    {
        // Скорость и направление движения
        private float speed = 10.4f;
        private Point movementDirection = Point.Empty;

        // таймер, который будет вызывать метод Update раз в N секунд
        Timer timer = new Timer();

        // Рандомайзер для случайного направления
        Random rand = new Random();



        // Свойство для установки скорости всвойствах формы
        public float Speed { get => speed; set => speed = Math.Abs(value); }



        /// <summary>
        /// Конструктор класса по умолчанию, который задает первоначальное стандартное направление и устанавливает таймер
        /// </summary>
        public Peintboller()
        {
            InitializeComponent();
            SetRandomDirection();

            // Устанавливаем интервал и вызываем собитие EventHundler
            timer.Interval = 30;
            timer.Tick += new EventHandler(Update);
            timer.Start();

        }

        /// <summary>
        /// Метод, который позволяет установить случайое направление движения
        /// </summary>
        public void SetRandomDirection()
        {
            // задаем случайные направление по x и у 
            // -1 : влево; 
            // 1 : вправо)
            // 0 : никуда

            int x = rand.Next(-1, 2);
            int y = rand.Next(1, 2);

            movementDirection = new Point(x, y);
        }

        
        protected override void OnPaint(PaintEventArgs e)
        {
            // Просто отключаю сглаживание. Вроде это уменьшает мерцание картинки
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            base.OnPaint(e);
        }

        /// <summary>
        /// Метод, который вызывается таймером раз в N секунд. В нем реализована вся логика программы - движение компонената
        /// </summary>
        public void Update(object sender, EventArgs e)
        {
            // Меняем положение компонента
            this.Location = new Point(
                Location.X + (int)(movementDirection.X * speed),
                Location.Y + (int)(movementDirection.Y * speed)
            );

            // Следим - не вышел ли он за левую и правую границы родителя
            if (Location.X < 0 | Location.X + Width > Parent.Width)
            {
                movementDirection.X *= -1;
            }

            // Следим - не вышел ли он за верхнюю и нижнюю границы родителя
            if (Location.Y < 0 | Location.Y + Height > Parent.Height)
            {
                movementDirection.Y *= -1;
            }
        }
    }
}
