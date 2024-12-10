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
    public partial class FormSignup : FormFather
    {
        readonly PersonModel personModel;
        readonly PersonModel myPerson;
        public FormSignup(PersonModel _personModel,PersonModel _myPerson)
        {
            personModel = _personModel;
            myPerson =  _myPerson;
            InitializeComponent();
            InitGlobal();
        }
        private void InitGlobal()
        {
            if (personModel == null || personModel.ID == 0)
            {
                //表示新用户注册
                skinButtonSignup.Visible = true;
                Text = "新用户取消";
            }
            else
            {
                //更新用户
                skinTextBoxUserName.Text = personModel.Name;
                skinTextBoxPassword.Text = personModel.Password;
                skinTextBoxPassword2.Text= personModel.Password;
                dateTimePickerBirthday.Value = personModel.Birthday;
                skinComboBoxSex.SelectedIndex = personModel.Sex;
                skinTextBoxTelphone.Text = personModel.Telphone;
                skinTextBoxAddress.Text = personModel.Address;
                skinTextBoxFather.Text = personModel.Father;
                skinTextBoxMother.Text = personModel.Mother;
                dateTimePickerRegDate.Value = personModel.RegDate;

                //加载用户级别初始值
                Common.UserLevelList.ForEach(item => skinComboBoxLevel.Items.Add(item));
                //加载用户级别的实际值
                skinComboBoxLevel.SelectedIndex = personModel.UserLevel;
                //加载用户激活状态
                if (personModel.Enabled == true)
                {
                    skinComboBoxEnabled.SelectedIndex = 1;
                }
                else
                {
                    skinComboBoxEnabled.SelectedIndex = 0;
                }
                

                if (myPerson.UserLevel == 0)
                {
                    skinButtonDelete.Visible = true;
                    skinButtonUpdate.Visible = true;
                    skinTextBoxUserName.ReadOnly = true; 
                    panelAdmin.Visible = true;
                }
                //这里不修改密码
                skinTextBoxPassword.ReadOnly = true;
                skinTextBoxPassword2.ReadOnly = true;
                Text = "用户管理";
            }
            skinComboBoxSex.SelectedIndex = 0;
        }

        private void FormSignup_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void skinButtonSignup_Click(object sender, EventArgs e)
        {
            //注册
            PersonModel personModel = new PersonModel();
            personModel.Name = skinTextBoxUserName.Text.Trim();
            personModel.Password = skinTextBoxPassword.Text.Trim();
            personModel.Password2 = skinTextBoxPassword2.Text.Trim();
            personModel.Birthday = dateTimePickerBirthday.Value;
            personModel.Sex = skinComboBoxSex.SelectedIndex;
            personModel.Telphone = skinTextBoxTelphone.Text.Trim();
            personModel.Address = skinTextBoxAddress.Text.Trim();
            personModel.Father = skinTextBoxFather.Text.Trim();
            personModel.Mother = skinTextBoxMother.Text.Trim();
            personModel.RegDate = dateTimePickerRegDate.Value;
            personModel.UserLevel = 2;//新用户为学生
            personModel.Enabled = false;//默认新用户不可登录

            PersonBLL personBLL = new PersonBLL();
            if(personBLL.Insert(personModel,out string messageStr)==true)
            {
                MessageBox.Show(messageStr);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(messageStr);
            }


        }

        private void skinButtonCancel_Click(object sender, EventArgs e)
        {
            //关闭
            Close();
        }

        private void skinTextBoxTelphone_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void skinButtonDelete_Click(object sender, EventArgs e)
        {
            //删除用户
            if (personModel.ID != myPerson.ID)
            {

                if (new PersonBLL().Delete(personModel, out string messageStr) == true)
                {
                    MessageBox.Show(messageStr);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(messageStr);
                }
            }
            else
            {
                MessageBox.Show("不能在用户管理中删除自己");
            }
        }

        private void skinButtonUpdate_Click(object sender, EventArgs e)
        {
            //更新数据-获取数据

            // PersonModel personModel = new PersonModel();
            //  personModel.Name = skinTextBoxUserName.Text.Trim();
            personModel.Password = skinTextBoxPassword.Text.Trim();
            personModel.Password2 = skinTextBoxPassword2.Text.Trim();
            personModel.Birthday = dateTimePickerBirthday.Value;
            personModel.Sex = skinComboBoxSex.SelectedIndex;
            personModel.Telphone = skinTextBoxTelphone.Text.Trim();
            personModel.Address = skinTextBoxAddress.Text.Trim();
            personModel.Father = skinTextBoxFather.Text.Trim();
            personModel.Mother = skinTextBoxMother.Text.Trim();
            personModel.RegDate = dateTimePickerRegDate.Value;


            personModel.UserLevel = skinComboBoxLevel.SelectedIndex;

            if (skinComboBoxEnabled.SelectedIndex == 1)
            {
                personModel.Enabled = true;
            }
            else
            {
                personModel.Enabled = false;
            }
            //更新数据-执行命令
            PersonBLL personBLL = new PersonBLL();
            if (personBLL.Update(personModel, out string messageStr) == true)
            {
                MessageBox.Show(messageStr);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(messageStr);
            }
        }
    }
}
