using Lab2Appanov.Components;
using Laboratory2;
using Laboratory2.HelperModels;
using NotVisualComponents;
using StudentBusinessLogic.BindingModels;
using StudentBusinessLogic.BusinessLogics;
using StudentBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace AppanovLab3
{
    public partial class Form1 : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly StudentLogic studentLogic;
        private readonly DirectionLogic directionLogic;

        public Form1(StudentLogic studentLogic, DirectionLogic directionLogic)
        {
            InitializeComponent();
            this.studentLogic = studentLogic;
            this.directionLogic = directionLogic;

            List<DataGridViewColumn> dataGridViewColumns = new List<DataGridViewColumn>();

            DataGridViewColumn dataGridViewColumn = new DataGridViewColumn();
            dataGridViewColumn.HeaderText = "Id";
            dataGridViewColumn.DataPropertyName = "Id";
            dataGridViewColumn.Visible = false;
            dataGridViewColumns.Add(dataGridViewColumn);

            dataGridViewColumn = new DataGridViewColumn();
            dataGridViewColumn.HeaderText = "Имя";
            dataGridViewColumn.DataPropertyName = "Name";
            dataGridViewColumns.Add(dataGridViewColumn);

            dataGridViewColumn = new DataGridViewColumn();
            dataGridViewColumn.HeaderText = "Фото";
            dataGridViewColumn.DataPropertyName = "Image";
            dataGridViewColumn.Visible = false;
            dataGridViewColumns.Add(dataGridViewColumn);

            dataGridViewColumn = new DataGridViewColumn();
            dataGridViewColumn.HeaderText = "Почта";
            dataGridViewColumn.DataPropertyName = "Email";
            dataGridViewColumns.Add(dataGridViewColumn);

            dataGridViewColumn = new DataGridViewColumn();
            dataGridViewColumn.HeaderText = "Направление";
            dataGridViewColumn.DataPropertyName = "Direction";
            dataGridViewColumns.Add(dataGridViewColumn);

            component31.ConfigureViewbox(dataGridViewColumns);

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var studentList = studentLogic.Read(null);
                if (studentList != null)
                {
                    component31.FillDataGrid<StudentViewModel>(studentList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateStudent();
        }

        private void CreateStudent()
        {
            var form = Container.Resolve<StudentForm>();
            form.ShowDialog();
            LoadData();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent();
        }

        private void DeleteStudent()
        {
            if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    studentLogic.Delete(component31.GetSelectedObject<StudentBindingModel>());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                LoadData();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStudent();
        }

        private void EditStudent()
        {
            var form = Container.Resolve<StudentForm>();
            form.Id = (int)component31.GetSelectedObject<StudentBindingModel>().Id;
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void направленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<DirectionForm>();
            form.ShowDialog();
        }

        private void component31_KeyDown(object sender, KeyEventArgs e)
        {
            if (((Control.ModifierKeys & Keys.Control) == Keys.Control)
        && e.KeyValue == 'A')
            {
                CreateStudent();
            }
            if (e.KeyCode == Keys.U&&e.Control)
            {
                EditStudent();
            }
            if (e.KeyCode == Keys.D&&e.Control)
            {
                DeleteStudent();
            }
            if (e.KeyCode == Keys.T && e.Control)
            {
                StudentWord();
            }
            if (e.KeyCode == Keys.S && e.Control)
            {
                StudentExcel();
            }
            if (e.KeyCode == Keys.C && e.Control)
            {
                StudentPDF();
            }
        }

        private void StudentWord()
        {
            UniversityWordTable universityWordTable = new UniversityWordTable();
            List<int[]> consolidatedСolumns = new List<int[]> { new int[] { 0, 1 } };
            Dictionary<string, int> columncolumnNamesAndSize = new Dictionary<string, int> { { "Name", 2000 }, { "Email", 4000 }, { "Direction", 3000 } };
            List<string> titles = new List<string> { "Личные данные", "Имя", "Почта", "Направление" };

            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    universityWordTable.CreateDoc(dialog.FileName, "Отчет по студентам в таблице", studentLogic.Read(null), consolidatedСolumns, columncolumnNamesAndSize, titles);
                }
            }
        }

        private void вордСтудентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentWord();
        }

        private void StudentExcel()
        {
            ComponentImageExcel componentImageExcel = new ComponentImageExcel();
            List<string> imageList = new List<string>();
            foreach (var list in studentLogic.Read(null))
            {
                
                imageList.Add(list.Image);
            }
            using (var dialog = new SaveFileDialog { Filter = "xls|*.xls" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    componentImageExcel.CreateFile(dialog.FileName, "Фотографии студентов", imageList.ToArray());
                }
            }
        }

        private void эксельФотографииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentExcel();
        }

        private void пДФСтудентыИНаправленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentPDF();
        }

        private void StudentPDF()
        {
            float[] countStudent = new float[1];
            var listStudent = studentLogic.Read(null);
            var listDirection = directionLogic.Read(null);
            Dictionary<string, float[]> dict = new Dictionary<string, float[]>();

            foreach (var direction in listDirection)
            {
                dict.Add(direction.Name, new float[] { 0 });
            }

            foreach (var student in listStudent)
            {
                if (dict.ContainsKey(student.Direction)){
                    dict[student.Direction][0]++;
                }
                else
                {
                    dict.Add(student.Direction, new float[] { 1 });
                }
            }


            GistogramComponent gistogramComponent = new GistogramComponent();
            using (var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    gistogramComponent.SaveGistogram(dialog.FileName, "Студенты и направления", "Кол-во студентов по направлениям", LocationLegend.TopLeft, new GistogramInfo() { Data = dict });
                }
            }
        }
    }
}
