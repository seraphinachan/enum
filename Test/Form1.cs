using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enumDay
        {
            Monday, 
            Tuesday, 
            Wednesday, 
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }

        enum enumTime
        {
            Morning,
            Afternoon,
            Evening,
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lboxDay.Items.Add(enumDay.Monday.ToString());
            lboxDay.Items.Add(enumDay.Tuesday);
            lboxDay.Items.Add(enumDay.Wednesday);
            lboxDay.Items.Add(enumDay.Thursday);
            lboxDay.Items.Add(enumDay.Friday);
            lboxDay.Items.Add(enumDay.Saturday);
            lboxDay.Items.Add(enumDay.Sunday);

            lboxTime.Items.Add(enumTime.Morning);
            lboxTime.Items.Add(enumTime.Afternoon);
            lboxTime.Items.Add(enumTime.Evening);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // ��ȣ�� Monday(����) Afternoon�� ����� �߽��ϴ�.

            string strResult = tboxName.Text + "�� " + lboxDay.SelectedItem.ToString() + "(����)" + lboxTime.SelectedItem.ToString() + "�� ����� �߽��ϴ�.";

            tboxResult.Text = strResult;
        }
    }
}