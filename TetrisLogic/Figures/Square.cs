﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisInterfaces;

namespace TetrisLogic.Figures
{
    internal sealed class Square: Figure
    {
        public Square(TColor color, int[,] body, GameBoard board) : base(color, body, board)
        {
        }

        public override string ToString()
        {
            return "Square";
        }

        
    }
}