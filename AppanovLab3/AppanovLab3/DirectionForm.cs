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
    public partial class DirectionForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly DirectionLogic Dlogic;
        private int? id;
        List<DirectionViewModel> list;

        public DirectionForm(DirectionLogic Dlogic)
        {
            InitializeComponent();
            this.Dlogic = Dlogic;
            
        }

        private void CreateDirectionForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                list = Dlogic.Read(null);
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void DirectionForm_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("sss");
            if (e.KeyData == Keys.Insert)
            {
                MessageBox.Show("ddd");
                dataGridView1.Rows.Add();
                
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Insert && (dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value != null || dataGridView1.Rows.Count == 0))
            {
                list.Add(new DirectionViewModel());
                dataGridView1.DataSource = new List<DirectionViewModel>(list);
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
                return;
            }
            if (e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Вы действительно хотите удалить?", "Предупреждение",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Dlogic.Delete(new DirectionBindingModel() { Id = (int)dataGridView1.CurrentRow.Cells[0].Value });
                    list = Dlogic.Read(null);
                    dataGridView1.DataSource = new List<DirectionViewModel>(list);
                }
                
            }
        }

        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).CurrentCell.EditedFormattedValue == "")
            {

                if (dataGridView1.CurrentRow.Cells[0].Value != null)
                {
                    var listDBM = Dlogic.Read(new DirectionBindingModel() { Id = (int)dataGridView1.CurrentRow.Cells[0].Value });
                    dataGridView1.CurrentRow.Cells[1].Value = ((DirectionViewModel)listDBM[0]).Name;

                }

            }
            else
            {
                if(dataGridView1.CurrentRow.Cells[0].Value != null)
                {
                    int id;
                    if (dataGridView1.CurrentRow.Cells[0].Value == null)
                    {
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].EditedFormattedValue);
                    }
                    else
                    {
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    }
                    Dlogic.CreateOrUpdate(new DirectionBindingModel()
                    {
                        Id = Convert.ToInt32(id),
                        Name = (string)dataGridView1.CurrentRow.Cells[1].EditedFormattedValue
                    });
                }
                else
                {
                    Dlogic.CreateOrUpdate(new DirectionBindingModel()
                    {
                        Name = (string)dataGridView1.CurrentRow.Cells[1].EditedFormattedValue
                    });
                }
                
            }
        }
    }
}
