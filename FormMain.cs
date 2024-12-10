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
    public partial class FormMain : FormFather
    {
        private readonly PersonModel myPerson ;
        private List<PersonModel> personModelList;
        private List<SubjectModel> subjectModelList;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_personModel"></param>
        public FormMain(PersonModel _personModel)
        {
            InitializeComponent();
            myPerson =_personModel;
            InitGlobal();

        }
        private void InitGlobal()
        {
            Text = "[主界面] 欢迎您，" + myPerson.Name +"!您的级别：" + Common.UserLevelList[myPerson.UserLevel];
            dataGridViewPerson.CellDoubleClick += DataGridViewPerson_CellDoubleClick;
            dataGridViewPerson.AutoGenerateColumns = false;

            //加载用户表
            InitPerson();
            //加载科目表
            InitSubject();

        }
        private void InitPerson()
        {
            personModelList = new PersonBLL().Select();//用户泛型数组

            foreach (PersonModel item in personModelList)
            {
                item.SexName = Common.SexList[item.Sex];
            }
            dataGridViewPerson.DataSource = personModelList;

        }

        private void InitSubject()
        {
            subjectModelList = new SubjectBLL().Select();//获取所有科目记录
            dataGridViewSubject.DataSource = subjectModelList;

        }

        private void DataGridViewPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //当用户级别为管理员或老师时
            if (myPerson.UserLevel <=1)
            {
                DataGridView dataGridView = sender as DataGridView;
                DataGridViewRow dataGridViewRow = dataGridView.CurrentRow;
               MessageBox.Show(dataGridViewRow.Cells[0].FormattedValue.ToString());
                int number;
                if (int.TryParse(dataGridViewRow.Cells[0].FormattedValue.ToString(), out number))
                {
                    // 转换成功，在这里可以使用number变量进行后续操作
                }
                else
                {
                    // 转换失败，说明单元格中的值不是合法整数，可以进行相应提示或者其他错误处理逻辑
                    Console.WriteLine("单元格中的值不是合法整数，请检查数据");
                }
                PersonModel personModel = personModelList.Find(item => item.ID == number);

               

                FormSignup f = new FormSignup(personModel,myPerson);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    InitPerson();
                }

            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sTMSDataSet.Person”中。您可以根据需要移动或移除它。
            this.personTableAdapter.Fill(this.sTMSDataSet.Person);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                                     //DataGridViewCellEventHandler
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
