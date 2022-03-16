using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{

    public partial class Form1 : Form
    {
        ICalculater Calculate;
        public Form1()
        {
            InitializeComponent();
            Calculate = new Calculate();
        }
        bool ValidateInput()
        {
            bool Isvalid = true;

            if (GetNum1.Value == 0)
            {
                Isvalid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");
            }
            else
            {
                if (GetNum2.Value == 0)
                {
                    Isvalid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد کنید");
                }

            }
            return true;
        }
        private void GetNum1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int minus = Calculate.Minus((int)GetNum1.Value, (int)GetNum2.Value);
                MessageBox.Show("Minus Is " + minus);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int plus = Calculate.Plus((int)GetNum1.Value, (int)GetNum2.Value);
                MessageBox.Show("Sum Is " + plus);
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int multiple = Calculate.Multiple((int)GetNum1.Value, (int)GetNum2.Value);
                MessageBox.Show("multiple Is " + multiple);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int divide = Calculate.Divide((int)GetNum1.Value, (int)GetNum2.Value);
                MessageBox.Show("Divide Is " + divide);
            }

        }
    }
}
