using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1Appanov.Components;

namespace Lab1Appanov
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			List<string> list = new List<string>();
			list.Add("Резгей");
			list.Add("Шовкань");
			selectionControl1.FillList(list);
			selectionControl1.value = "5";

			inputControl1.FirstDate = DateTime.Now.AddDays(-2);
			inputControl1.LastDate = DateTime.Now.AddDays(2);

			inputControl1.value = DateTime.Now;


			List<Worker> listHuman = new List<Worker>();
			listHuman.Add(new Worker("Финансовый", "Начальник", "Коростелева"));
			listHuman.Add(new Worker("Финансовый", "Бухгалтер", "Шовкань"));
			listHuman.Add(new Worker("Продажи", "Менеджер", "Шовкань"));
			listHuman.Add(new Worker("Продажи", "Менеджер", "Гильман"));

			listHuman.Add(new Worker("Продажи", "Грузчик", "Антонов"));
			listHuman.Add(new Worker("Развитие", "Начальник", "Буткеев"));
			listHuman.Add(new Worker("Продажи", "Менеджер", "Филиппов"));
			
			
			

			Queue<string> queue = new Queue<string>();
			queue.Enqueue("Department");
			queue.Enqueue("Position");			
			queue.Enqueue("Name");
			
			outputControl1.FillHierarchy<Worker>(queue);
			outputControl1.FillTree<Worker>(listHuman);
		}

        private void button1_Click(object sender, EventArgs e)
        {
			//textBox1.Text = outputControl1.SelectedNodeIndex.ToString();
			//	outputControl1.SelectedNodeIndex = 3;


			//	Worker worker = new Worker("", "", "");
			//	worker = outputControl1.GetSelectedEntry<Worker>();
			//	textBox1.Text = worker.Name + worker.Position + worker.Department;

			textBox1.Text = selectionControl1.value;
		}
    }
}
