using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ПР_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Вычислить(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(TextBox_Date1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14;
                v1 = Math.Sqrt(c);
                v2 = Math.Pow(b, 4);
                v3 = 3 * b;
                v4 = Math.Abs(v3);
                v5 = Math.Pow(a, 1 / v4);
                v6 = v5 * v2;
                v7 = v1 * v6;
                v8 = Math.Pow(10, 1 / 3f); // это кубический корень.
                v9 = v8 + v7;
                v10 = Math.Log10(v9);
                v11 = Math.Pow(c, -2);
                v12 = a * b * v11;
                v13 = Math.Pow(Math.E, v12);
                v14 = v10 + v13;
                double S = v14;
                S = Math.Round(S, 3, MidpointRounding.AwayFromZero);
                textBox4.Text = Convert.ToString(S);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBox_Date1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox_Date1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void btn_CloseMouseHover(object sender, EventArgs e)
        {
            Close();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Вычислить(sender, e);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void TextBox_Date1_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(TextBox_Date1, "Введите число!");
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox2, "Введите число!");
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox3, "Введите число!");
        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox4, "Сюда будет выведен результат");
        }

        private void btn312_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn312, "Выполнить расчет");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, "Выход из приложения");
        }

        private void tabPage1_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
