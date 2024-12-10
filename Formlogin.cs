using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

namespace SCMS
{
    public partial class Formlogin : FormFather
    {
        private PersonModel personModel;
        /// <summary>
        /// 获取一个登录用户
        /// </summary>
        public PersonModel PersonModel
        {
            get
            {
                return personModel;
            }
        }
        public Formlogin()
        {
            InitializeComponent();
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {

        }

        private void skinTextBox2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skinLabel2_Click(object sender, EventArgs e)
        {

        }

        private void skinButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignup f = new FormSignup(new PersonModel(),new PersonModel());
            f.ShowDialog();
            //注册用户
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //找回密码
        }

        private void skinButtonLogin_Click(object sender, EventArgs e)
        {
            // 登录用户

            personModel = new PersonModel
            {
                Name = skinTextBoxName.Text.Trim(),
                Password = skinTextBoxPassword.Text.Trim()
            };
           
            if(new PersonBLL().Select(personModel,out string messageStr,out  PersonModel personBackUI)==true)
            {
                //判断用户是否激活
                if (personBackUI.Enabled == true)
                {
                 
                DialogResult = DialogResult.OK;
                personModel = personBackUI;
                }
                else
                {
                    MessageBox.Show(messageStr);
                }
               
            }
            else
            {
                MessageBox.Show(messageStr);
                skinTextBoxName.Text = "";
                skinTextBoxPassword.Text = "";
            }



        }

        private void skinTextBoxName_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
