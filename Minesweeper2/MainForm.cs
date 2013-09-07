using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper2
{
    public partial class MainForm : Form
    {
        //Size EASY_SIZE = new Size(180, 266);
        //Size MEDIUM_SIZE = new Size(292, 378);
        //Size HARD_SIZE = new Size(516, 378);
        //const int EASY_ROW_COL = 9;
        //const int MED_ROW_COL = 16;
        //const int HARD_ROW = 30;
        //const int HARD_COL = 16;
        const int ROW_BUFF = 36;    //add this to (row * square.width)
        const int COL_BUFF = 122; //this this to (col * square.width)

        public enum Difficulty {EASY, MED, HARD, CUST};
        public Difficulty diff = Difficulty.MED;

        public int rows { get; set; }
        public int columns { get; set; }
        public int mines { get; set; }

        private BoardControl board;
        private OptionsForm opt;

        public MainForm(int row, int col, int mines)
        {
            InitializeComponent();
            DrawPanel(row, col, mines);
            diff = Difficulty.MED;
            this.rows = row;
            this.columns = col;
            this.mines = mines;

            //this.opt.okBtn_Click() += new EventHandler(ReDrawBoard);
        }

        public void DrawPanel(int row, int col, int mines)
        {
            if (board != null)
                this.board.Dispose();
            board = new BoardControl(row, col, mines);
            this.Size = new Size( (row * board.SquareSize + ROW_BUFF), (col * board.SquareSize + COL_BUFF) ); //resize window adding buffers
            board.BorderStyle = BorderStyle.Fixed3D;
            board.Margin = new System.Windows.Forms.Padding(0);
            this.Controls.Add(board);
            this.mainTableLayout.Controls.Add(board);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opt = new OptionsForm(diff, rows, columns, mines, this);
            opt.Location = this.Location;
            opt.ShowDialog();
        }

        //public void ReDrawBoard(object sender, EventArgs e)
        //{
        //    this.rows = opt.row;
        //    this.columns = opt.col;
        //    this.mines = opt.mines;
        //}
    }
}
