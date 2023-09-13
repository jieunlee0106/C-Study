using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.X500;

namespace StudentsManagementSystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            // 학생 정보 추가 시 - 초기 성별 값(default = 남성)
            male_bnt.Checked = true;

            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        #region "Values"
        private MySqlConnection connection;
        private string connectionString = "Server=15.165.89.250;Port=3306;Database=students;Uid=root;Pwd=jieun;charset=utf8";
        // 학생 정보 조회
        private int selectedGrade = 0;
        private string selectedName;
        // 학생 정보 등록
        private string input_name;
        private string input_rrn;
        private int input_grade;
        private string input_sex;
        // 학생 정보 수정
        private int update_grade;
        private string update_rrn;
        #endregion

        #region "DataBase Connection"
        // 데이터 베이스 연결 초기화
        private void DataBaseConnection()
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("데이터베이스 연결 실패: " + ex.Message);
            }
        }
        #endregion

        #region "bnt_click"

        // 조회 버튼 클릭

        private void read_student_bnt_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }


        // 추가 버튼 클릭
        private void create_student_bnt_Click(object sender, EventArgs e)
        {
            AddStudents();
        }

        // 삭제 버튼 클릭
        private void delete_student_bnt_Click(object sender, EventArgs e)
        {
            DeleteStudent();
        }

        // 수정 버튼 클릭
        private void update_student_bnt_Click(object sender, EventArgs e)
        {
            UpdateStudentInfo();

        }


        #endregion

        #region "bnt_click_event and exception"

        // 조회 - 버튼 클릭
        private void LoadStudents()
        {
            try
            {
                DataBaseConnection();
                MySqlCommand cmd = new MySqlCommand("searchStudent", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                // 매개변수 추가
                cmd.Parameters.AddWithValue("@p_name", selectedName);
                cmd.Parameters.AddWithValue("@p_grade", selectedGrade);

                MySqlDataReader dr = cmd.ExecuteReader();

                // 데이터 그리드 내용 초기화
                dataGridView1.Rows.Clear();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["grade"], dr["name"], dr["sex"], dr["registration_number"], dr["student_id"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("데이터를 불러오는 중 오류 발생: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // 조회 - 학년 검색
        public void select_grade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isGradeInt()) {
                selectedGrade = Convert.ToInt32(select_grade.SelectedItem);
                LoadStudents();
            }
            else
            {
                selectedGrade = 0;
                LoadStudents();
            }
        }

        // 조회 - 전체 학년 검색 여부
        private bool isGradeInt()
        {
            try
            {
                Convert.ToInt32(select_grade.SelectedItem);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // 조회 - 이름 검색
        public void select_name_TextChanged(object sender, EventArgs e)
        {
            selectedName = Convert.ToString(select_name.Text);
            LoadStudents();
        }



        // 추가 - 버튼 클릭
        private void AddStudents()
        {

            if (isInputName() && isInputGrade() && isInputRegistrationNumber())
            {
                input_sex = isInputSex();
                input_name = create_name.Text;
                input_rrn = create_rrn.Text;
                input_grade = create_grade.SelectedIndex + 1;

                try
                {
                    DataBaseConnection();
                    string query = $"INSERT INTO students (name, sex, registration_number, grade) VALUES ('{input_name}', '{input_sex}', '{input_rrn}', {input_grade})";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("학생 등록이 완료되었습니다.");
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("학생 등록에 실패했습니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    ClearForm();
                }

            }
        }

        // 추가 - 학번 유효성 검사
        private bool isInputRegistrationNumber()
        {
            if (string.IsNullOrWhiteSpace(create_rrn.Text))
            {
                MessageBox.Show("학번을 입력하세요.");
                return false;
            }

            if (!int.TryParse(create_rrn.Text, out int rrn) || create_rrn.Text.Length != 5)
            {
                MessageBox.Show("학번은 5자리 숫자여야 합니다.");
                return false;
            }

            return true;
        }

        // 추가 - 학년 유효성 검사
        private bool isInputGrade()
        {
            if (create_grade.SelectedIndex == -1)
            {
                MessageBox.Show("학년을 선택하세요.");
                return false;
            }

            return true;
        }

        // 추가 - 성별 선택
        private string isInputSex()
        {
            if (male_bnt.Checked)
            {
                return "남자";
            }
            return "여자";
        }

        // 추가 - 이름 유효성 검사
        private bool isInputName()
        {
            if (string.IsNullOrWhiteSpace(create_name.Text))
            {
                MessageBox.Show("이름을 입력하세요.");
                return false;
            }

            return true;
        }

        // 입력 폼 초기화
        private void ClearForm()
        {
            create_name.Text = "";
            create_rrn.Text = "";
            create_grade.SelectedIndex = -1; // 학년 기본값 설정
            male_bnt.Checked = true; // 남성을 기본값으로 설정
        }


        // 수정 - 버튼 클릭
        private void UpdateStudentInfo()
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            // student_id 열에서 학생의 고유 식별자 가져오기
            int student_id = Convert.ToInt32(selectedRow.Cells["student_id"].Value);


            // 수정된 데이터 가져오rl
            string updatedName = selectedRow.Cells["name"].Value.ToString();
            string updatedRrn = selectedRow.Cells["registration_number"].Value.ToString();



            if (isUpdateGrade(selectedRowIndex) && isUpdateRrn(selectedRowIndex))
            {
                // 데이터베이스에 수정 쿼리 실행
                try
                {
                    DataBaseConnection();
                    string updateQuery = $"UPDATE students SET name = '{updatedName}', registration_number = '{updatedRrn}', grade = {update_grade} WHERE student_id = '{student_id}'";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("학생 정보가 성공적으로 수정되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("학생 정보 수정에 실패했습니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // 수정 - 학번 수정 유효성 검사
        private bool isUpdateRrn(int selectedRowIndex)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            string updatedRrn = selectedRow.Cells["registration_number"].Value.ToString();

            if (int.TryParse(updatedRrn, out int update_rrn) && updatedRrn.Length == 5)
            {
                // update_rrn은 숫자이며 5자리인 경우에만 업데이트
                update_rrn = int.Parse(updatedRrn);
                MessageBox.Show($"{update_rrn}");
                return true;
            }
            MessageBox.Show("5자리의 숫자로만 입력해주세요.");
            return false;

        }

        // 수정 - 학년 수정 유효성 검사
        private bool isUpdateGrade(int selectedRowIndex)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            string updatedGradeStr = selectedRow.Cells["grade"].Value.ToString();
            if (updatedGradeStr == "1" || updatedGradeStr == "2" || updatedGradeStr == "3" || updatedGradeStr == "4")
            {
                update_grade = Convert.ToInt32(updatedGradeStr);
                return true;
            }
            else
            {
                MessageBox.Show("학년은 1에서 4사이의 정수로만 입력해주세요.");
                return false;
            }
        }


        // 삭제 - 버튼 클릭
        private void DeleteStudent()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    // student_id 열에서 학생의 고유 식별자 가져오기
                    int studentId = Convert.ToInt32(row.Cells["student_id"].Value);

                    // 학생의 is_enrollment 값을 false로 업데이트하는 쿼리 실행
                    string updateQuery = $"UPDATE students SET is_enrollment = false WHERE student_id = {studentId}";

                    try
                    {
                        DataBaseConnection();
                        MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // 업데이트가 성공하면 DataGridView에서 행 삭제
                            dataGridView1.Rows.Remove(row);
                        }
                        else
                        {
                            MessageBox.Show("업데이트에 실패했습니다.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("오류 발생: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("선택된 행이 없습니다.");
            }
        }


        #endregion

    }


}