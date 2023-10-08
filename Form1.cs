using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (LDTUtils.isNumberValid(txt_SoThuNhat.Text) && LDTUtils.isNumberValid(txt_SoThuHai.Text))
            {
                float reslut = float.Parse(txt_SoThuNhat.Text) + float.Parse(txt_SoThuHai.Text);
                txt_Result.Text = reslut.ToString();
                Form2 frm2 = new Form2(reslut);
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Fill only numberic!!" + "do not " + txt_SoThuHai.Text + " or " + txt_SoThuNhat.Text);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LDTUtils.isNumberValid(txt_SoThuNhat.Text) && LDTUtils.isNumberValid(txt_SoThuHai.Text))
            {
                float reslut = float.Parse(txt_SoThuNhat.Text) - float.Parse(txt_SoThuHai.Text);
                txt_Result.Text = reslut.ToString();
                Form2 frm2 = new Form2(reslut);
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Fill only numberic!!" + "do not " + txt_SoThuHai.Text + " or " + txt_SoThuNhat.Text);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (LDTUtils.isNumberValid(txt_SoThuNhat.Text) && LDTUtils.isNumberValid(txt_SoThuHai.Text))
            {
                float reslut = float.Parse(txt_SoThuNhat.Text) * float.Parse(txt_SoThuHai.Text);
                txt_Result.Text = reslut.ToString();
                Form2 frm2 = new Form2(reslut);
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Fill only numberic!!" + "do not " + txt_SoThuHai.Text + " or " + txt_SoThuNhat.Text);
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (LDTUtils.isNumberValid(txt_SoThuNhat.Text) && LDTUtils.isNumberValid(txt_SoThuHai.Text))
            {
                if(float.Parse(txt_SoThuHai.Text) > 0)
                {
                    float reslut = float.Parse(txt_SoThuNhat.Text) + float.Parse(txt_SoThuHai.Text);
                    txt_Result.Text = reslut.ToString();
                    Form2 frm2 = new Form2(reslut);
                    frm2.Show();
                }
                else
                {
                    MessageBox.Show("Denominator Have to be more than 0 ");        
                }
                
            //push ne
            }
            else
            {
                MessageBox.Show("Fill only numberic!!" + "do not " + txt_SoThuHai.Text + " or " + txt_SoThuNhat.Text);
            }

        }

    }
}
