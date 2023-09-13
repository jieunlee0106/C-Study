namespace StudentsManagementSystem
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.create_student_bnt = new System.Windows.Forms.Button();
            this.read_student_bnt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.create_grade = new System.Windows.Forms.ComboBox();
            this.create_sex = new System.Windows.Forms.GroupBox();
            this.male_bnt = new System.Windows.Forms.RadioButton();
            this.female_bnt = new System.Windows.Forms.RadioButton();
            this.create_rrn = new System.Windows.Forms.MaskedTextBox();
            this.create_name = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.select_name = new System.Windows.Forms.TextBox();
            this.select_grade = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.update_student_bnt = new System.Windows.Forms.Button();
            this.delete_student_bnt = new System.Windows.Forms.Button();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registration_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.create_sex.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grade,
            this.name,
            this.sex,
            this.registration_number,
            this.student_id});
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(575, 452);
            this.dataGridView1.TabIndex = 0;
            // 
            // create_student_bnt
            // 
            this.create_student_bnt.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.create_student_bnt.Location = new System.Drawing.Point(13, 224);
            this.create_student_bnt.Name = "create_student_bnt";
            this.create_student_bnt.Size = new System.Drawing.Size(137, 23);
            this.create_student_bnt.TabIndex = 1;
            this.create_student_bnt.Text = "학생 등록";
            this.create_student_bnt.UseVisualStyleBackColor = true;
            this.create_student_bnt.Click += new System.EventHandler(this.create_student_bnt_Click);
            // 
            // read_student_bnt
            // 
            this.read_student_bnt.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.read_student_bnt.Location = new System.Drawing.Point(13, 88);
            this.read_student_bnt.Name = "read_student_bnt";
            this.read_student_bnt.Size = new System.Drawing.Size(137, 24);
            this.read_student_bnt.TabIndex = 2;
            this.read_student_bnt.Text = "학생 조회";
            this.read_student_bnt.UseVisualStyleBackColor = true;
            this.read_student_bnt.Click += new System.EventHandler(this.read_student_bnt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.create_grade);
            this.panel1.Controls.Add(this.create_sex);
            this.panel1.Controls.Add(this.create_rrn);
            this.panel1.Controls.Add(this.create_name);
            this.panel1.Controls.Add(this.create_student_bnt);
            this.panel1.Location = new System.Drawing.Point(593, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 261);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "신규 학생 등록";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "학년:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "학번:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "이름: ";
            // 
            // create_grade
            // 
            this.create_grade.FormattingEnabled = true;
            this.create_grade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.create_grade.Location = new System.Drawing.Point(14, 141);
            this.create_grade.Name = "create_grade";
            this.create_grade.Size = new System.Drawing.Size(136, 20);
            this.create_grade.TabIndex = 7;
            // 
            // create_sex
            // 
            this.create_sex.Controls.Add(this.male_bnt);
            this.create_sex.Controls.Add(this.female_bnt);
            this.create_sex.Location = new System.Drawing.Point(13, 167);
            this.create_sex.Name = "create_sex";
            this.create_sex.Size = new System.Drawing.Size(137, 42);
            this.create_sex.TabIndex = 9;
            this.create_sex.TabStop = false;
            this.create_sex.Text = "성별";
            // 
            // male_bnt
            // 
            this.male_bnt.AutoSize = true;
            this.male_bnt.Location = new System.Drawing.Point(31, 20);
            this.male_bnt.Name = "male_bnt";
            this.male_bnt.Size = new System.Drawing.Size(35, 16);
            this.male_bnt.TabIndex = 7;
            this.male_bnt.TabStop = true;
            this.male_bnt.Text = "남";
            this.male_bnt.UseVisualStyleBackColor = true;
            // 
            // female_bnt
            // 
            this.female_bnt.AutoSize = true;
            this.female_bnt.Location = new System.Drawing.Point(81, 20);
            this.female_bnt.Name = "female_bnt";
            this.female_bnt.Size = new System.Drawing.Size(35, 16);
            this.female_bnt.TabIndex = 8;
            this.female_bnt.TabStop = true;
            this.female_bnt.Text = "여";
            this.female_bnt.UseVisualStyleBackColor = true;
            // 
            // create_rrn
            // 
            this.create_rrn.Location = new System.Drawing.Point(14, 102);
            this.create_rrn.Mask = "99999";
            this.create_rrn.Name = "create_rrn";
            this.create_rrn.Size = new System.Drawing.Size(136, 21);
            this.create_rrn.TabIndex = 3;
            this.create_rrn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.create_rrn.ValidatingType = typeof(int);
            // 
            // create_name
            // 
            this.create_name.Location = new System.Drawing.Point(14, 63);
            this.create_name.Name = "create_name";
            this.create_name.Size = new System.Drawing.Size(136, 21);
            this.create_name.TabIndex = 2;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("굴림", 18F);
            this.title.Location = new System.Drawing.Point(19, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(114, 24);
            this.title.TabIndex = 4;
            this.title.Text = "학생 관리";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.select_name);
            this.panel2.Controls.Add(this.select_grade);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.read_student_bnt);
            this.panel2.Location = new System.Drawing.Point(593, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 125);
            this.panel2.TabIndex = 5;
            // 
            // select_name
            // 
            this.select_name.Location = new System.Drawing.Point(44, 61);
            this.select_name.Name = "select_name";
            this.select_name.Size = new System.Drawing.Size(106, 21);
            this.select_name.TabIndex = 9;
            this.select_name.TextChanged += new System.EventHandler(this.select_name_TextChanged);
            // 
            // select_grade
            // 
            this.select_grade.FormattingEnabled = true;
            this.select_grade.Items.AddRange(new object[] {
            "전체",
            "1",
            "2",
            "3",
            "4"});
            this.select_grade.Location = new System.Drawing.Point(44, 35);
            this.select_grade.Name = "select_grade";
            this.select_grade.Size = new System.Drawing.Size(106, 20);
            this.select_grade.TabIndex = 8;
            this.select_grade.SelectedIndexChanged += new System.EventHandler(this.select_grade_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(11, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "학생 검색";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "학년:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "이름:";
            // 
            // update_student_bnt
            // 
            this.update_student_bnt.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.update_student_bnt.Location = new System.Drawing.Point(608, 447);
            this.update_student_bnt.Name = "update_student_bnt";
            this.update_student_bnt.Size = new System.Drawing.Size(135, 23);
            this.update_student_bnt.TabIndex = 3;
            this.update_student_bnt.Text = "학생 정보 수정";
            this.update_student_bnt.UseVisualStyleBackColor = true;
            this.update_student_bnt.Click += new System.EventHandler(this.update_student_bnt_Click);
            // 
            // delete_student_bnt
            // 
            this.delete_student_bnt.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.delete_student_bnt.Location = new System.Drawing.Point(608, 476);
            this.delete_student_bnt.Name = "delete_student_bnt";
            this.delete_student_bnt.Size = new System.Drawing.Size(135, 25);
            this.delete_student_bnt.TabIndex = 6;
            this.delete_student_bnt.Text = "선택 학생 삭제";
            this.delete_student_bnt.UseVisualStyleBackColor = true;
            this.delete_student_bnt.Click += new System.EventHandler(this.delete_student_bnt_Click);
            // 
            // grade
            // 
            this.grade.HeaderText = "학년";
            this.grade.Name = "grade";
            // 
            // name
            // 
            this.name.HeaderText = "이름";
            this.name.Name = "name";
            // 
            // sex
            // 
            this.sex.HeaderText = "성별";
            this.sex.Name = "sex";
            // 
            // registration_number
            // 
            this.registration_number.HeaderText = "학번";
            this.registration_number.Name = "registration_number";
            // 
            // student_id
            // 
            this.student_id.HeaderText = "student_id";
            this.student_id.Name = "student_id";
            this.student_id.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 536);
            this.Controls.Add(this.delete_student_bnt);
            this.Controls.Add(this.update_student_bnt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.create_sex.ResumeLayout(false);
            this.create_sex.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button create_student_bnt;
        private System.Windows.Forms.Button read_student_bnt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button update_student_bnt;
        private System.Windows.Forms.GroupBox create_sex;
        private System.Windows.Forms.RadioButton male_bnt;
        private System.Windows.Forms.RadioButton female_bnt;
        private System.Windows.Forms.MaskedTextBox create_rrn;
        private System.Windows.Forms.TextBox create_name;
        private System.Windows.Forms.ComboBox create_grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox select_name;
        private System.Windows.Forms.ComboBox select_grade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button delete_student_bnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn registration_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
    }
}

