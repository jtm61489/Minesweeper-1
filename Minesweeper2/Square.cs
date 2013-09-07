using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Minesweeper2
{
    class Square
    {
        public Rectangle Bounds { get; set; }
        private int width = 16;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        private int height = 16;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        //initialize all boolean values to false in constructor
        public bool IsBomb { get; set; }
        public bool IsRevealed { get; set; }
        public bool HasMouse { get; set; }
        public bool IsFlagged { get; set; }
        public bool IsQuestion { get; set; }

        public Square()
        {
            this.IsBomb = false;
            this.IsRevealed = false;
            this.HasMouse = false;
            this.IsFlagged = false;
            this.IsQuestion = false;
        }
    }
}
