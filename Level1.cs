using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Лабиринт
{
    public partial class Level1 : Form
    {
        public Level1()
        {
            InitializeComponent();
        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                DialogResult result = (MessageBox.Show("Вы действительно хотите закрыть игру?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2));
                if (result == System.Windows.Forms.DialogResult.Yes)
                    this.Close();
            }
        }

        void startGame()
        {
            Point point;
            point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            label6.Visible = true; label7.Visible = true;
            label9.Visible = true; label8.Visible = true;
        }

        private void Level1_Shown(object sender, EventArgs e)
        {
            startGame();
        }

        private void woods_MouseEnter(object sender, EventArgs e) // заход на стену
        {
            Sound.playFail();
            DialogResult result = (MessageBox.Show("Вы проиграли, попробуем ещё раз?", "Сообщение", MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button1));
            if (result == System.Windows.Forms.DialogResult.Yes)
                startGame();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void labelEnd_MouseEnter(object sender, EventArgs e)
        {
            if (countCubs == 0)
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private int countCubs = 4;

        private void takeCub(object sender, EventArgs e) // поднятие куба
        {
            Sound.playTakeMoney();
            (sender as Label).Visible = false;
            countCubs--;
        }
    }
}
