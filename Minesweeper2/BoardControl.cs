using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Minesweeper2
{
    public class BoardControl : Panel
    {
        private const int SQUARE_SIZE = 16; 
        public int SquareSize
        {
            get
            {
                return SQUARE_SIZE;
            }
        }

        public int columns { get; set; }
        public int rows { get; set; }
        Square[,] squares;


        public BoardControl(int row, int col, int mines)
        {
            this.Dock = DockStyle.Fill;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            this.columns = col;
            this.rows = row;
            //this.MouseMove += new MouseEventHandler(BoardControl_MouseMove);
            //this.Paint += new PaintEventHandler(OnPaint);

            squares = new Square[row, col];
            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    squares[x, y] = new Square();
                    squares[x, y].Bounds = new Rectangle(x * SQUARE_SIZE, y * SQUARE_SIZE, SQUARE_SIZE, SQUARE_SIZE);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //StringFormat sf = new StringFormat();
            //sf.LineAlignment = StringAlignment.Center;
            //sf.Alignment = StringAlignment.Center;
            
            String flag = "O";
            String question = "?";

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    if (squares[x, y].IsRevealed)
                    {
                        e.Graphics.FillRectangle(Brushes.DarkGray, squares[x, y].Bounds);
                    }
                    else if (squares[x, y].IsFlagged)
                    {
                        ControlPaint.DrawButton(e.Graphics, squares[x, y].Bounds, ButtonState.Normal);
                        e.Graphics.DrawString(flag, new Font("Wingdings", 8.5F, FontStyle.Bold), Brushes.Brown, squares[x, y].Bounds.X + 1, squares[x, y].Bounds.Y + 1);
                    }
                    else if (squares[x, y].IsQuestion)
                    {
                        ControlPaint.DrawButton(e.Graphics, squares[x, y].Bounds, ButtonState.Normal);
                        e.Graphics.DrawString(question, new Font(this.Font.Name, 8.5F, FontStyle.Bold), Brushes.Blue, squares[x, y].Bounds.X + 1, squares[x, y].Bounds.Y + 1);
                    }
                    else
                    {
                        ControlPaint.DrawButton(e.Graphics, squares[x, y].Bounds, ButtonState.Normal);
                        if (squares[x, y].HasMouse)
                            ControlPaint.DrawBorder(e.Graphics, squares[x, y].Bounds, Color.CadetBlue, 2, ButtonBorderStyle.Outset,
                                Color.CadetBlue, 2, ButtonBorderStyle.Outset,
                                Color.CadetBlue, 1, ButtonBorderStyle.Outset,
                                Color.CadetBlue, 1, ButtonBorderStyle.Outset);
                    }
                }
            }
            base.OnResize(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            //this.Invalidate();
            foreach (Square square in squares)
            {
                if (square.Bounds.Contains(e.Location))
                {
                    if (!square.IsFlagged && !square.IsQuestion && e.Button == MouseButtons.Left)
                    {
                        square.IsFlagged = false;
                        square.IsQuestion = false;
                        square.IsRevealed = true;
                    }
                    else if (!square.IsFlagged && !square.IsQuestion && e.Button == MouseButtons.Right)
                    {
                        square.IsFlagged = true;
                    }
                    else if (square.IsFlagged && e.Button == MouseButtons.Right)
                    {
                        square.IsFlagged = false;
                        square.IsQuestion = true;
                    }
                    else if (square.IsQuestion && e.Button == MouseButtons.Right)
                    {
                        square.IsFlagged = false;
                        square.IsQuestion = false;
                    }     
                }
            }
            base.OnMouseClick(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            Square onMouseSquare;
            int xLoc = e.Location.X / SQUARE_SIZE;
            int yLoc = e.Location.Y / SQUARE_SIZE;
            //must stay within bounds of array (I like the looks of the panel to be +1 pixel larger than necessary)
            if ( (xLoc < this.rows) && (yLoc < this.columns) )
            {
                onMouseSquare = squares[e.Location.X / SQUARE_SIZE, e.Location.Y / SQUARE_SIZE];
                onMouseSquare.HasMouse = true;
                foreach (Square square in squares)
                    if (square.HasMouse == true && square != onMouseSquare)
                        square.HasMouse = false;
            }
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            foreach (Square sq in squares)
                sq.HasMouse = false;
            base.OnMouseLeave(e);
        }

        
    }
}
