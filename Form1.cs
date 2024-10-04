using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using b5.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace b5
{
    public partial class Form1 : Form
    {
        Studentdbcontent dbstudent = new Studentdbcontent();
        public Form1()
        {
            InitializeComponent();
        }


        public void FillDataCBB(List<faculty> listFaculty)
        {
            cbbkhoa.DataSource = listFaculty;
            cbbkhoa.DisplayMember = "facultyname";
            cbbkhoa.ValueMember = "facltyid";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<student> listStudent = dbstudent.students.ToList();
            List<faculty> listFaculty = dbstudent.faculties.ToList();

            FillDataCBB(listFaculty);
            FillDataDGV(listStudent);
        }

        private void FillDataDGV(List<student> listStudent)
        {
            dgvdssv.Rows.Clear();
            foreach (var students in listStudent)
            {
                int RowNew = dgvdssv.Rows.Add(students);
                dgvdssv.Rows[RowNew].Cells[0].Value = students.studentid;
                dgvdssv.Rows[RowNew].Cells[1].Value = students.fullname;
                dgvdssv.Rows[RowNew].Cells[2].Value = students.faculty?.facultyname;
                dgvdssv.Rows[RowNew].Cells[3].Value = students.averagescore;



            }
        }

        private int CheckID(string idnewsv)
        {
            int length = dgvdssv.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvdssv.Rows[i].Cells[0].Value != null)
                    if (dgvdssv.Rows[i].Cells[0].Value.ToString() == idnewsv)
                        return i;
            }
            return -1;
        }

        private bool CheckDataInput()
        {
            if (txtmssv.Text == "" || txthoten.Text == "" || txtdtb.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtmssv.TextLength < 10 || txtmssv.TextLength > 10)
            {
                MessageBox.Show("Mã số sinh viên chưa nhập đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                float kq = 0;
                bool KetQua = float.TryParse(txtdtb.Text, out kq);
                if (!KetQua)
                {
                    MessageBox.Show("Điểm trung binh sinh viên chưa nhập đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (CheckID(txtmssv.Text) == -1)
                {

                    student newstudent = new student();
                    newstudent.studentid = txtmssv.Text;
                    newstudent.fullname = txthoten.Text;
                    newstudent.facltyid = Convert.ToInt32(cbbkhoa.SelectedValue.ToString());
                    newstudent.averagescore = Convert.ToDouble(txtdtb.Text);

                    dbstudent.students.AddOrUpdate(newstudent);
                    dbstudent.SaveChanges();

                    loadDGV();
                    loadForm();
                    MessageBox.Show($"Thêm sinh viên {newstudent.fullname} vào danh sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show($"Sinh viên có mã {txtmssv.Text} đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void loadForm()
        {
            txtmssv.Clear();
            txthoten.Clear();
            txtdtb.Clear();

        }

        private void loadDGV()
        {
            List<student> newliststudent = dbstudent.students.ToList();
            FillDataDGV(newliststudent);
        }



        private void btnrepair_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                student update = dbstudent.students.FirstOrDefault(p => p.studentid == txtmssv.Text);
                if (update != null)
                {

                    update.fullname = txthoten.Text;
                    update.facltyid = Convert.ToInt32(cbbkhoa.SelectedValue.ToString());
                    update.averagescore = Convert.ToDouble(txtdtb.Text);


                    dbstudent.students.AddOrUpdate(update);
                    dbstudent.SaveChanges();


                    loadDGV();
                    loadForm();

                    MessageBox.Show($"Sửa thông tin sinh viên {update.fullname} thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void dgvdssv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = dgvdssv.Rows[e.RowIndex];
                txtmssv.Text = Row.Cells[0].Value.ToString();
                txthoten.Text = Row.Cells[1].Value.ToString();
                cbbkhoa.Text = Row.Cells[2].Value.ToString();
                txtdtb.Text = Row.Cells[3].Value.ToString();
            }


        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
            else
                return;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            student delete = dbstudent.students.FirstOrDefault(p => p.studentid == txtmssv.Text);
            if (delete != null)
            {
                DialogResult result = MessageBox.Show($"Bạn có đồng ý xóa sinh viên {delete.fullname}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dbstudent.students.Remove(delete);
                    dbstudent.SaveChanges();
                    loadForm();
                    loadDGV();
                    MessageBox.Show($"Xóa sinh viên {delete.fullname} thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    return;
                }
            }
        }
    }
    }





