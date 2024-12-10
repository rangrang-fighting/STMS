namespace SCMS
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinTabControlMain = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPagePerson = new CCWin.SkinControl.SkinTabPage();
            this.panelTop = new System.Windows.Forms.Panel();
            this.dataGridViewPerson = new System.Windows.Forms.DataGridView();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTMSDataSet = new SCMS.STMSDataSet();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.dataGridViewSubject = new System.Windows.Forms.DataGridView();
            this.skinTabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage4 = new CCWin.SkinControl.SkinTabPage();
            this.personTableAdapter = new SCMS.STMSDataSetTableAdapters.PersonTableAdapter();
            this.ColumnPersonCreatorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonPassword2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonEnabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonUserlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonRegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonMother = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonFather = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonTelphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonSexName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinTabControlMain.SuspendLayout();
            this.skinTabPagePerson.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTMSDataSet)).BeginInit();
            this.skinTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // skinTabControlMain
            // 
            this.skinTabControlMain.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControlMain.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControlMain.Controls.Add(this.skinTabPagePerson);
            this.skinTabControlMain.Controls.Add(this.skinTabPage2);
            this.skinTabControlMain.Controls.Add(this.skinTabPage3);
            this.skinTabControlMain.Controls.Add(this.skinTabPage4);
            this.skinTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControlMain.HeadBack = null;
            this.skinTabControlMain.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControlMain.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControlMain.Location = new System.Drawing.Point(4, 32);
            this.skinTabControlMain.Name = "skinTabControlMain";
            this.skinTabControlMain.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControlMain.PageArrowDown")));
            this.skinTabControlMain.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControlMain.PageArrowHover")));
            this.skinTabControlMain.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControlMain.PageCloseHover")));
            this.skinTabControlMain.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControlMain.PageCloseNormal")));
            this.skinTabControlMain.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControlMain.PageDown")));
            this.skinTabControlMain.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControlMain.PageHover")));
            this.skinTabControlMain.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControlMain.PageNorml = null;
            this.skinTabControlMain.SelectedIndex = 1;
            this.skinTabControlMain.Size = new System.Drawing.Size(786, 502);
            this.skinTabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControlMain.TabIndex = 1;
            // 
            // skinTabPagePerson
            // 
            this.skinTabPagePerson.BackColor = System.Drawing.Color.White;
            this.skinTabPagePerson.Controls.Add(this.panelTop);
            this.skinTabPagePerson.Controls.Add(this.panelBottom);
            this.skinTabPagePerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPagePerson.Location = new System.Drawing.Point(0, 36);
            this.skinTabPagePerson.Name = "skinTabPagePerson";
            this.skinTabPagePerson.Size = new System.Drawing.Size(786, 466);
            this.skinTabPagePerson.TabIndex = 0;
            this.skinTabPagePerson.TabItemImage = null;
            this.skinTabPagePerson.Text = "用户管理";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.dataGridViewPerson);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(786, 418);
            this.panelTop.TabIndex = 2;
            // 
            // dataGridViewPerson
            // 
            this.dataGridViewPerson.AllowUserToAddRows = false;
            this.dataGridViewPerson.AllowUserToDeleteRows = false;
            this.dataGridViewPerson.AutoGenerateColumns = false;
            this.dataGridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPersonID,
            this.ColumnPersonName,
            this.ColumnPersonSexName,
            this.ColumnPersonBirthday,
            this.ColumnPersonTelphone,
            this.ColumnPersonAddress,
            this.ColumnPersonFather,
            this.ColumnPersonMother,
            this.ColumnPersonRegDate,
            this.ColumnPersonUserlevel,
            this.ColumnPersonEnabled,
            this.ColumnPersonCreationDate,
            this.ColumnPersonModifiedDate,
            this.ColumnPersonPassword,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.telphoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.fatherDataGridViewTextBoxColumn,
            this.motherDataGridViewTextBoxColumn,
            this.regDateDataGridViewTextBoxColumn,
            this.userLevelDataGridViewTextBoxColumn,
            this.enabledDataGridViewCheckBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn,
            this.ColumnPersonSex,
            this.ColumnPersonPassword2,
            this.ColumnPersonCreatorID});
            this.dataGridViewPerson.DataSource = this.personBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPerson.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPerson.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPerson.Name = "dataGridViewPerson";
            this.dataGridViewPerson.ReadOnly = true;
            this.dataGridViewPerson.RowHeadersWidth = 62;
            this.dataGridViewPerson.RowTemplate.Height = 30;
            this.dataGridViewPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPerson.Size = new System.Drawing.Size(786, 418);
            this.dataGridViewPerson.TabIndex = 0;
            this.dataGridViewPerson.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPerson_CellContentClick);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.sTMSDataSet;
            // 
            // sTMSDataSet
            // 
            this.sTMSDataSet.DataSetName = "STMSDataSet";
            this.sTMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 418);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(786, 48);
            this.panelBottom.TabIndex = 1;
            this.panelBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.White;
            this.skinTabPage2.Controls.Add(this.dataGridViewSubject);
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(786, 466);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "科目管理";
            // 
            // dataGridViewSubject
            // 
            this.dataGridViewSubject.AllowUserToAddRows = false;
            this.dataGridViewSubject.AllowUserToDeleteRows = false;
            this.dataGridViewSubject.AutoGenerateColumns = false;
            this.dataGridViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn17,
            this.ColumnSubject});
            this.dataGridViewSubject.DataSource = this.personBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSubject.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubject.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSubject.Name = "dataGridViewSubject";
            this.dataGridViewSubject.ReadOnly = true;
            this.dataGridViewSubject.RowHeadersWidth = 62;
            this.dataGridViewSubject.RowTemplate.Height = 30;
            this.dataGridViewSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSubject.Size = new System.Drawing.Size(786, 466);
            this.dataGridViewSubject.TabIndex = 1;
            this.dataGridViewSubject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // skinTabPage3
            // 
            this.skinTabPage3.BackColor = System.Drawing.Color.White;
            this.skinTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage3.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage3.Name = "skinTabPage3";
            this.skinTabPage3.Size = new System.Drawing.Size(786, 466);
            this.skinTabPage3.TabIndex = 2;
            this.skinTabPage3.TabItemImage = null;
            this.skinTabPage3.Text = "成绩单管理";
            // 
            // skinTabPage4
            // 
            this.skinTabPage4.BackColor = System.Drawing.Color.White;
            this.skinTabPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage4.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage4.Name = "skinTabPage4";
            this.skinTabPage4.Size = new System.Drawing.Size(786, 466);
            this.skinTabPage4.TabIndex = 3;
            this.skinTabPage4.TabItemImage = null;
            this.skinTabPage4.Text = "分数管理";
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // ColumnPersonCreatorID
            // 
            this.ColumnPersonCreatorID.DataPropertyName = "CreatorID";
            this.ColumnPersonCreatorID.HeaderText = "CreatorID";
            this.ColumnPersonCreatorID.MinimumWidth = 8;
            this.ColumnPersonCreatorID.Name = "ColumnPersonCreatorID";
            this.ColumnPersonCreatorID.ReadOnly = true;
            this.ColumnPersonCreatorID.Visible = false;
            this.ColumnPersonCreatorID.Width = 150;
            // 
            // ColumnPersonPassword2
            // 
            this.ColumnPersonPassword2.DataPropertyName = "Password2";
            this.ColumnPersonPassword2.HeaderText = "Password2";
            this.ColumnPersonPassword2.MinimumWidth = 8;
            this.ColumnPersonPassword2.Name = "ColumnPersonPassword2";
            this.ColumnPersonPassword2.ReadOnly = true;
            this.ColumnPersonPassword2.Visible = false;
            this.ColumnPersonPassword2.Width = 150;
            // 
            // ColumnPersonSex
            // 
            this.ColumnPersonSex.DataPropertyName = "SexName";
            this.ColumnPersonSex.HeaderText = "性别";
            this.ColumnPersonSex.MinimumWidth = 8;
            this.ColumnPersonSex.Name = "ColumnPersonSex";
            this.ColumnPersonSex.ReadOnly = true;
            this.ColumnPersonSex.Width = 150;
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            this.modifiedDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.modifiedDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.creationDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // enabledDataGridViewCheckBoxColumn
            // 
            this.enabledDataGridViewCheckBoxColumn.DataPropertyName = "Enabled";
            this.enabledDataGridViewCheckBoxColumn.HeaderText = "Enabled";
            this.enabledDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.enabledDataGridViewCheckBoxColumn.Name = "enabledDataGridViewCheckBoxColumn";
            this.enabledDataGridViewCheckBoxColumn.ReadOnly = true;
            this.enabledDataGridViewCheckBoxColumn.Width = 150;
            // 
            // userLevelDataGridViewTextBoxColumn
            // 
            this.userLevelDataGridViewTextBoxColumn.DataPropertyName = "UserLevel";
            this.userLevelDataGridViewTextBoxColumn.HeaderText = "UserLevel";
            this.userLevelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userLevelDataGridViewTextBoxColumn.Name = "userLevelDataGridViewTextBoxColumn";
            this.userLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.userLevelDataGridViewTextBoxColumn.Width = 150;
            // 
            // regDateDataGridViewTextBoxColumn
            // 
            this.regDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate";
            this.regDateDataGridViewTextBoxColumn.HeaderText = "RegDate";
            this.regDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
            this.regDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.regDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // motherDataGridViewTextBoxColumn
            // 
            this.motherDataGridViewTextBoxColumn.DataPropertyName = "Mother";
            this.motherDataGridViewTextBoxColumn.HeaderText = "Mother";
            this.motherDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.motherDataGridViewTextBoxColumn.Name = "motherDataGridViewTextBoxColumn";
            this.motherDataGridViewTextBoxColumn.ReadOnly = true;
            this.motherDataGridViewTextBoxColumn.Width = 150;
            // 
            // fatherDataGridViewTextBoxColumn
            // 
            this.fatherDataGridViewTextBoxColumn.DataPropertyName = "Father";
            this.fatherDataGridViewTextBoxColumn.HeaderText = "Father";
            this.fatherDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fatherDataGridViewTextBoxColumn.Name = "fatherDataGridViewTextBoxColumn";
            this.fatherDataGridViewTextBoxColumn.ReadOnly = true;
            this.fatherDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // telphoneDataGridViewTextBoxColumn
            // 
            this.telphoneDataGridViewTextBoxColumn.DataPropertyName = "Telphone";
            this.telphoneDataGridViewTextBoxColumn.HeaderText = "Telphone";
            this.telphoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telphoneDataGridViewTextBoxColumn.Name = "telphoneDataGridViewTextBoxColumn";
            this.telphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telphoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn.Width = 150;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdayDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // ColumnPersonPassword
            // 
            this.ColumnPersonPassword.DataPropertyName = "Password";
            this.ColumnPersonPassword.HeaderText = "Password";
            this.ColumnPersonPassword.MinimumWidth = 8;
            this.ColumnPersonPassword.Name = "ColumnPersonPassword";
            this.ColumnPersonPassword.ReadOnly = true;
            this.ColumnPersonPassword.Visible = false;
            this.ColumnPersonPassword.Width = 150;
            // 
            // ColumnPersonModifiedDate
            // 
            this.ColumnPersonModifiedDate.DataPropertyName = "ModifiedDate";
            this.ColumnPersonModifiedDate.HeaderText = "修改日期";
            this.ColumnPersonModifiedDate.MinimumWidth = 8;
            this.ColumnPersonModifiedDate.Name = "ColumnPersonModifiedDate";
            this.ColumnPersonModifiedDate.ReadOnly = true;
            this.ColumnPersonModifiedDate.Width = 150;
            // 
            // ColumnPersonCreationDate
            // 
            this.ColumnPersonCreationDate.DataPropertyName = "CreationDate";
            this.ColumnPersonCreationDate.HeaderText = "创建时期";
            this.ColumnPersonCreationDate.MinimumWidth = 8;
            this.ColumnPersonCreationDate.Name = "ColumnPersonCreationDate";
            this.ColumnPersonCreationDate.ReadOnly = true;
            this.ColumnPersonCreationDate.Width = 150;
            // 
            // ColumnPersonEnabled
            // 
            this.ColumnPersonEnabled.DataPropertyName = "Enabled";
            this.ColumnPersonEnabled.HeaderText = "是否激活";
            this.ColumnPersonEnabled.MinimumWidth = 8;
            this.ColumnPersonEnabled.Name = "ColumnPersonEnabled";
            this.ColumnPersonEnabled.ReadOnly = true;
            this.ColumnPersonEnabled.Width = 150;
            // 
            // ColumnPersonUserlevel
            // 
            this.ColumnPersonUserlevel.DataPropertyName = "Userlevel";
            this.ColumnPersonUserlevel.HeaderText = "用户级别";
            this.ColumnPersonUserlevel.MinimumWidth = 8;
            this.ColumnPersonUserlevel.Name = "ColumnPersonUserlevel";
            this.ColumnPersonUserlevel.ReadOnly = true;
            this.ColumnPersonUserlevel.Width = 150;
            // 
            // ColumnPersonRegDate
            // 
            this.ColumnPersonRegDate.DataPropertyName = "RegDate";
            this.ColumnPersonRegDate.HeaderText = "注册时间";
            this.ColumnPersonRegDate.MinimumWidth = 8;
            this.ColumnPersonRegDate.Name = "ColumnPersonRegDate";
            this.ColumnPersonRegDate.ReadOnly = true;
            this.ColumnPersonRegDate.Width = 150;
            // 
            // ColumnPersonMother
            // 
            this.ColumnPersonMother.DataPropertyName = "Mother";
            this.ColumnPersonMother.HeaderText = "母亲";
            this.ColumnPersonMother.MinimumWidth = 8;
            this.ColumnPersonMother.Name = "ColumnPersonMother";
            this.ColumnPersonMother.ReadOnly = true;
            this.ColumnPersonMother.Width = 150;
            // 
            // ColumnPersonFather
            // 
            this.ColumnPersonFather.DataPropertyName = "Father";
            this.ColumnPersonFather.HeaderText = "父亲";
            this.ColumnPersonFather.MinimumWidth = 8;
            this.ColumnPersonFather.Name = "ColumnPersonFather";
            this.ColumnPersonFather.ReadOnly = true;
            this.ColumnPersonFather.Width = 150;
            // 
            // ColumnPersonAddress
            // 
            this.ColumnPersonAddress.DataPropertyName = "Address";
            this.ColumnPersonAddress.HeaderText = "地址";
            this.ColumnPersonAddress.MinimumWidth = 8;
            this.ColumnPersonAddress.Name = "ColumnPersonAddress";
            this.ColumnPersonAddress.ReadOnly = true;
            this.ColumnPersonAddress.Width = 150;
            // 
            // ColumnPersonTelphone
            // 
            this.ColumnPersonTelphone.DataPropertyName = "Telphone";
            this.ColumnPersonTelphone.HeaderText = "电话";
            this.ColumnPersonTelphone.MinimumWidth = 8;
            this.ColumnPersonTelphone.Name = "ColumnPersonTelphone";
            this.ColumnPersonTelphone.ReadOnly = true;
            this.ColumnPersonTelphone.Width = 150;
            // 
            // ColumnPersonBirthday
            // 
            this.ColumnPersonBirthday.DataPropertyName = "Birthday";
            this.ColumnPersonBirthday.HeaderText = "生日";
            this.ColumnPersonBirthday.MinimumWidth = 8;
            this.ColumnPersonBirthday.Name = "ColumnPersonBirthday";
            this.ColumnPersonBirthday.ReadOnly = true;
            this.ColumnPersonBirthday.Width = 150;
            // 
            // ColumnPersonSexName
            // 
            this.ColumnPersonSexName.DataPropertyName = "Sex";
            this.ColumnPersonSexName.HeaderText = "Sex";
            this.ColumnPersonSexName.MinimumWidth = 8;
            this.ColumnPersonSexName.Name = "ColumnPersonSexName";
            this.ColumnPersonSexName.ReadOnly = true;
            this.ColumnPersonSexName.Visible = false;
            this.ColumnPersonSexName.Width = 150;
            // 
            // ColumnPersonName
            // 
            this.ColumnPersonName.DataPropertyName = "Name";
            this.ColumnPersonName.HeaderText = "姓名";
            this.ColumnPersonName.MinimumWidth = 8;
            this.ColumnPersonName.Name = "ColumnPersonName";
            this.ColumnPersonName.ReadOnly = true;
            this.ColumnPersonName.Width = 150;
            // 
            // ColumnPersonID
            // 
            this.ColumnPersonID.DataPropertyName = "  ID";
            this.ColumnPersonID.HeaderText = "编号";
            this.ColumnPersonID.MinimumWidth = 8;
            this.ColumnPersonID.Name = "ColumnPersonID";
            this.ColumnPersonID.ReadOnly = true;
            this.ColumnPersonID.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "  ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SubjectName";
            this.dataGridViewTextBoxColumn2.HeaderText = "科目名称";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CreationDate";
            this.dataGridViewTextBoxColumn13.HeaderText = "创建时期";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ModifiedDate";
            this.dataGridViewTextBoxColumn14.HeaderText = "修改日期";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "CreatorID";
            this.dataGridViewTextBoxColumn17.HeaderText = "CreatorID";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.DataPropertyName = "CreatorName";
            this.ColumnSubject.HeaderText = "创建者";
            this.ColumnSubject.MinimumWidth = 8;
            this.ColumnSubject.Name = "ColumnSubject";
            this.ColumnSubject.ReadOnly = true;
            this.ColumnSubject.Width = 150;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 538);
            this.Controls.Add(this.skinTabControlMain);
            this.Name = "FormMain";
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.skinTabControlMain.ResumeLayout(false);
            this.skinTabPagePerson.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTMSDataSet)).EndInit();
            this.skinTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl skinTabControlMain;
        private CCWin.SkinControl.SkinTabPage skinTabPagePerson;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private CCWin.SkinControl.SkinTabPage skinTabPage4;
        private CCWin.SkinControl.SkinTabPage skinTabPage3;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dataGridViewPerson;
        private STMSDataSet sTMSDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private STMSDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonSexName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonTelphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonFather;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonMother;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonRegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonUserlevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonCreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonPassword2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonCreatorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
    }
}