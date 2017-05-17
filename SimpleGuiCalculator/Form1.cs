using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGuiCalculator
{
	public partial class Form1 : Form
	{
		double num1, num2, sum;


		public Form1()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{			
			num1 = Convert.ToDouble(txtNum1.Text);
			num2 = Convert.ToDouble(txtNum2.Text);

			sum = num1 + num2;

			lblAnswer.Text = sum.ToString("n");
		}

		private void btnSub_Click(object sender, EventArgs e)
		{
			num1 = Convert.ToDouble(txtNum1.Text);
			num2 = Convert.ToDouble(txtNum2.Text);

			sum = num1 - num2;

			lblAnswer.Text = sum.ToString("n");
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			lblAnswer.Text = "";
			txtNum1.Text = "";
			txtNum2.Text = "";
		}

		private void btnMult_Click(object sender, EventArgs e)
		{
			num1 = Convert.ToDouble(txtNum1.Text);
			num2 = Convert.ToDouble(txtNum2.Text);

			sum = num1 * num2;

			lblAnswer.Text = sum.ToString("n");

		}

		private void btnDiv_Click(object sender, EventArgs e)
		{
			num1 = Convert.ToDouble(txtNum1.Text);
			num2 = Convert.ToDouble(txtNum2.Text);

			sum = num1 / num2;

			lblAnswer.Text = sum.ToString("n");
		}
	}
}
