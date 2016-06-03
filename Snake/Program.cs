using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake {
    class Program {
        static void Main(string[] args) {

            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();
            //Отрисовка рамки
/*
            HorizontalLine UpLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine BottomLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine RightLine = new VerticalLine(0, 24, 78, '+');
            UpLine.Draw();
            BottomLine.Draw();
            LeftLine.Draw();
            RightLine.Draw();
*/            

            Point p = new Point(5, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator FoodCreator = new FoodCreator(80, 25, '&');
            Point food = FoodCreator.CreateFood();
            food.Draw();

            while (true) {
                if (walls.IsHit(snake) || snake.IsHitTail()) {
                    break;
                }
                if (snake.Eat(food)) {
                    food = FoodCreator.CreateFood();
                    food.Draw();
                } else {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable) {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);
                }
                //ConsoleKeyInfo key = Console.ReadKey();
                //snake.HandlKey(key.Key);
                //Thread.Sleep(100);
                //snake.Move();
            }
            //Console.ReadLine();
        }

    }
}