using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouthSports
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

        //Display Button
        private void button1_Click(object sender, EventArgs e)
        {
            {

                //if (string.IsNullOrEmpty(nameTextBox.Text.ToString()))

                //{

                //    MessageBox.Show("Please enter your name");

                //}
                //else
                //{
                StringBuilder itemselected = new StringBuilder();

                itemselected.AppendLine("Item selected: ");
                if (chkGloves.Checked)

                {

                    itemselected.AppendLine("Snow Gloves ");

                }

                if (chkSkis.Checked)

                {

                    itemselected.AppendLine("Skis ");

                }

                if (chkGoggles.Checked)

                {

                    itemselected.AppendLine("Goggles ");

                }

                if (chkEarMuffs.Checked)

                {

                    itemselected.AppendLine("Earmuffs ");

                }

                //if (checkBox5.Checked)

                //{

                //    itemselected.AppendLine(" ");

                //}

                //if (checkBox6.Checked)

                //{

                //    itemselected.AppendLine(" ");

                //}

                //if (checkBox7.Checked)

                //{

                //    itemselected.AppendLine(" ");

                //}


                MessageBox.Show(itemselected.ToString());

            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (Control control in Form1.ActiveForm.Controls)

            {

                var type = control.GetType();

                if (type.Name == "CheckBox")

                {

                    CheckBox cb = control as CheckBox;

                    if (cb != null)

                        cb.Checked = false;

                }

                else if (type.Name == "TextBox")

                {

                    TextBox tb = control as TextBox;

                    tb.Text = "";
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }

}

