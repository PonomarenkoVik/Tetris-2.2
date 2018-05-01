﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisInterfaces;
using TetrisLogic.Interfaces;

namespace TetrisLogic.Figures
{
    internal sealed class LeftZigzag : Figure,  IRotatable
    {
        public LeftZigzag(TColor color, int[,] body, GameBoard board) : base(color, body, board)
        {
        }

        public override string ToString()
        {
            return "LeftZigzag";
        }

        public bool Turn()
        {
            return base.TurnFigure();
        }
    }
}
