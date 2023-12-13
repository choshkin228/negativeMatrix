using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISRPO_PR_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentColumnCount = 2;
            currentRowCount = 2;
            carFull[0, 0] = tb00;
            carFull[1, 0] = tb10;
            carFull[0, 1] = tb01;
            carFull[1, 1] = tb11;
            for (int i = 0; i < 9; i++)
                this.Controls.Add(columnNumbers[i] = (new Label() { Location = new Point (226 + 46 * i, 71), Size = new Size (13, 13), Text = (i + 1).ToString(), ForeColor = Color.FromArgb(128, 128, 128), Visible = false}));
            columnNumbers[0].Visible = true;
            columnNumbers[1].Visible = true;
        }

        int currentColumnCount;
        int currentRowCount;
        TextBox[,] carFull = new TextBox[9, 9];
        Label[] columnNumbers = new Label[9];

        private void bIncColumn_Click(object sender, EventArgs e)
        {
            currentColumnCount++;

            for (int i = 0; i < currentRowCount; i++)
            {
                carFull[currentColumnCount - 1, i] = (new TextBox() { Location = new Point(211 + 46 * (currentColumnCount - 1), 87 + 26 * i), Size = new Size(40, 20), TabStop = false });
                this.Controls.Add(carFull[currentColumnCount - 1, i]);
            }

            if (currentColumnCount >= 9)
                bIncColumn.Enabled = false;
            bDegColumn.Enabled = true;

            columnNumbers[currentColumnCount - 1].Visible = true;

            labelNegativeColumns.Text = "";
        }
        private void bIncRow_Click(object sender, EventArgs e)
        {
            currentRowCount++;

            for (int i = 0; i < currentColumnCount; i++)
            {
                carFull[i, currentRowCount - 1] = (new TextBox() { Location = new Point(211 + 46 * i, 87 + 26 * (currentRowCount - 1)), Size = new Size(40, 20), TabStop = false });
                this.Controls.Add(carFull[i, currentRowCount - 1]);
            }

            if (currentRowCount >= 9)
                bIncRow.Enabled = false;
            bDegRow.Enabled = true;

            labelNegativeColumns.Text = "";
        }

        private void bDegColumn_Click(object sender, EventArgs e)
        {
            currentColumnCount--;

            for (int i = 0; i < currentRowCount; i ++)
                this.Controls.Remove(carFull[currentColumnCount, i]);

            if (currentColumnCount <= 2)
                bDegColumn.Enabled = false;
            bIncColumn.Enabled = true;

            columnNumbers[currentColumnCount].Visible = false;

            labelNegativeColumns.Text = "";
        }
        private void bDegRow_Click(object sender, EventArgs e)
        {
            currentRowCount--;

            for (int i = 0; i < currentColumnCount; i++)
                this.Controls.Remove(carFull[i, currentRowCount]);

            if (currentRowCount <= 2)
                bDegRow.Enabled = false;
            bIncRow.Enabled = true;

            labelNegativeColumns.Text = "";
        }

        private void bResult_Click(object sender, EventArgs e)
        {
            try
            {
                labelNegativeColumns.Text = "";
                for (int i = 0; i < currentColumnCount; i++)
                {
                    if (isColumnNegative(i))
                    {
                        labelNegativeColumns.Text += (i + 1).ToString() + "   ";
                        labelNegativeColumns.Visible = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так. Видимо вы некорректно ввели числа или оставили пустые поля", "Упс!");
            }
        }

        bool isColumnNegative(int columnNumber)
        {
            for (int j = 0; j < currentRowCount; j++)
                if (Convert.ToInt32(carFull[columnNumber, j].Text) >= 0)
                    return false;
            return true;
        }
    }
}
