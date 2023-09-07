using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace job
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imagePath = "\\\\192.168.3.250\\Veda\\3 курс\\ИСП 33-9\\МДК 03. 01\\Жиделев А Якорев В\\1.jpg"; // 
            if (File.Exists(imagePath))
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при загрузке картинки: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Файл не найден!");
            }
        }
    }
}
