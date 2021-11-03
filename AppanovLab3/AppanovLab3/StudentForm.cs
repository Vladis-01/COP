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
    public partial class StudentForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly StudentLogic logic;
        private readonly DirectionLogic Dlogic;
        private int? id;
        private string photo;

        public StudentForm(StudentLogic logic, DirectionLogic Dlogic)
        {
            InitializeComponent();
            this.logic = logic;
            this.Dlogic = Dlogic;
            universityTextBoxEmail.sample = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        }

        private void CreateStudentForm_Load(object sender, EventArgs e)
        {
            List<DirectionViewModel> list = Dlogic.Read(null);
            var listStr = new List<String>();
            foreach (var name in list)
            {
                listStr.Add(name.Name);
            }

            universityComboBoxDirection.Fill(listStr);

            if (id.HasValue)
            {
                try
                {
                    var view = logic.Read(new StudentBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                        photo = view.Image;
                        universityTextBoxEmail.value = view.Email;
                        universityComboBoxDirection.item = view.Direction;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Введите имя", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(photo))
            {
                MessageBox.Show("Введите ссылку", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(universityTextBoxEmail.value))
            {
                MessageBox.Show("Введите почту", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(universityComboBoxDirection.item))
            {
                MessageBox.Show("Выберите специальность", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                logic.CreateOrUpdate(new StudentBindingModel
                {
                    Id = id,
                    Name = textBoxName.Text,
                    Image = photo,
                    Email = universityTextBoxEmail.value,
                    Direction = universityComboBoxDirection.item
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = logic.Read(new StudentBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        if (textBoxName.Text != view.Name || photo != view.Image || universityTextBoxEmail.Text != view.Email || universityComboBoxDirection.item != view.Direction)
                        {
                            if (MessageBox.Show("Остались не сохраненные данные", "Предупреждение",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }          
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog { Filter = "PNG|*.PNG" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    photo = dialog.FileName;
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
        }
    }
}