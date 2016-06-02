﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class HorizontalLine : Figura {
        

        public HorizontalLine(int xLeft, int xReight, int y, char symb) {
            pList = new List<Point>();

            for(int x = xLeft; x <= xReight; x++) {
                Point p = new Point(x, y, symb);
                pList.Add(p);
            }
            
        }

    }
}
