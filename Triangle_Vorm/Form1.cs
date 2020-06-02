﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Vorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);

            
            Triangle triangle = new Triangle(a, b, c);

          
            listView1.Items.Add("Сторона а");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");

            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Полупериметр");

            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());

            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));

            listView1.Items[5].SubItems.Add(Convert.ToString(triangle.SemiPerimeter()));

            listView1.Items[7].SubItems.Add(triangle.TypeOfTirangle);

            if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Существует"); }
            else listView1.Items[6].SubItems.Add("Не существует");

            try
            {
                if (string.IsNullOrEmpty(txtA.Text) || string.IsNullOrEmpty(txtB.Text) || string.IsNullOrEmpty(txtC.Text))
                {
                    MessageBox.Show("Не все поля были заполнены");
                }
            }
            catch
            {
                MessageBox.Show("Все поля были заполнены");

            }


        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

    }
}
