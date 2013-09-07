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
    public partial class OptionsForm : Form
    {
        const int EASY_RC = 9;
        const int EASY_MINE = 10;
        const int MED_RC = 16;
        const int MED_MINE = 40;
        const int HARD_ROW = 30;
        const int HARD_COL = 16;
        const int HARD_MINE = 99;
        MainForm mainForm;
        public int row { get; set; }
        public int col { get; set; }
        public int mines { get; set; }
        MainForm.Difficulty difficulty;

        public OptionsForm(MainForm.Difficulty diff, int row, int col, int mines, MainForm mainForm)
        {
            InitializeComponent();
            this.difficulty = diff;
            this.mainForm = mainForm;
            switch (diff)
            {
                case MainForm.Difficulty.EASY:
                    this.easyRdBtn.Checked = true;
                    break;
                case MainForm.Difficulty.MED:
                    this.medRdBtn.Checked = true;
                    break;
                case MainForm.Difficulty.HARD:
                    this.hardRdBtn.Checked = true;
                    break;
                case MainForm.Difficulty.CUST:
                    this.customRdBtn.Checked = true;
                    this.rowNumBox.Enabled = true;
                    this.rowNumBox.Text = Convert.ToString(mainForm.rows);
                    this.colNumBox.Enabled = true;
                    this.colNumBox.Text = Convert.ToString(mainForm.columns);
                    this.mineNumBox.Enabled = true;
                    this.mineNumBox.Text = Convert.ToString(mainForm.mines);
                    break;
            }
            //SetupMainForm(MED_RC, MED_RC, MED_MINE);
        }

        public void okBtn_Click(object sender, EventArgs e)
        {
            
            if (this.easyRdBtn.Checked)
            {
                //row = EASY_RC;
                //col = EASY_RC;
                //mines = EASY_MINE;
                mainForm.diff = MainForm.Difficulty.EASY;
                SetupMainForm(EASY_RC, EASY_RC, EASY_MINE);
            }
            else if (this.medRdBtn.Checked)
            {
                //row = MED_RC;
                //col = MED_RC;
                //mines = MED_MINE;
                mainForm.diff = MainForm.Difficulty.MED;
                SetupMainForm(MED_RC, MED_RC, MED_MINE);
            }
            else if (this.hardRdBtn.Checked)
            {
                mainForm.diff = MainForm.Difficulty.HARD;
                SetupMainForm(HARD_ROW, HARD_COL, HARD_MINE);
            }
            else
            {
                //row = Convert.ToInt32(rowNumBox.Text);
                //col = Convert.ToInt32(colNumBox.Text);
                //mines = Convert.ToInt32(mineNumBox.Text);
                mainForm.diff = MainForm.Difficulty.CUST;
                SetupMainForm(Convert.ToInt32(rowNumBox.Text), Convert.ToInt32(colNumBox.Text), Convert.ToInt32(mineNumBox.Text));
            }
            
            this.Dispose();
        }

        public void SetupMainForm(int row, int col, int mines)
        {
            //this.Hide();
            //if (mainForm != null)
            //    mainForm.Dispose();
            //mainForm = new MainForm(row, col, mines);
            //mainForm.Show();
            mainForm.rows = row;
            mainForm.columns = col;
            mainForm.mines = mines;
            mainForm.DrawPanel(row, col, mines);
            this.Dispose();

        }

        private void customRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (customRdBtn.Checked)
            {
                rowNumBox.Enabled = true;
                colNumBox.Enabled = true;
                mineNumBox.Enabled = true;
            }
            else
            {
                rowNumBox.Enabled = false;
                colNumBox.Enabled = false;
                mineNumBox.Enabled = false;
            }
        }

    }
}
