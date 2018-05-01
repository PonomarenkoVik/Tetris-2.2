﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisInterfaces;
using TetrisLogic.Interfaces;

namespace TetrisLogic.Figures
{
    internal sealed class RightG : Figure, IRotatable
    {
        public RightG(TColor color, int[,] body, GameBoard board) : base(color, body, board)
        {
        }

        public override string ToString()
        {
            return "RightG";
        }

        public bool Turn()
        {
            return base.TurnFigure();
        }     
    }
}