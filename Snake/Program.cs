﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class Program {
        static void Main(string[] args) {

            Console.SetBufferSize(80, 25);

            //Отрисовка рамки

            HorizontalLine UpLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine BottomLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine RightLine = new VerticalLine(0, 24, 78, '+');
            UpLine.Draw();
            BottomLine.Draw();
            LeftLine.Draw();
            RightLine.Draw();
            Console.ReadLine();

            Point p = new Point(5, 5, '*');
            p.Draw();
        }

    }
}