﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameEngine.Math;
namespace Example
{
    public class TheGame : GameEngine.Game
    {
        public override void Render(Graphics graphics)
        {
            graphics.DrawLine(Pens.Red, vecStart.ToPointF(), (vecEnd.Rotate(Angle.FromDegrees(angle)).ToPointF()));
        }

        public override void UpdateLogic(double elapsedTime)
        {
            angle += 1f;
            this.Text = string.Format($"The Game - FPS: {FPS}");
        }

        public override void UpdateTime(double elapsedTime) { }
        private float angle = 0;
        private Vector2 vecStart = new Vector2(0, 0);
        private Vector2 vecEnd = new Vector2(100, 0);
    }
}
