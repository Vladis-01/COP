using StudentBusinessLogic.BindingModels;
using StudentBusinessLogic.Interfaces;
using StudentBusinessLogic.ViewModels;
using StudentDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseImplement.Implements
{
    public class StudentStorage: IStudentStorage
    {
        public List<StudentViewModel> GetFullList()
        {
            using (var context = new DataBaseContext())
            {
                return context.Students
                .Select(CreateModel).ToList();
            }
        }

        public List<StudentViewModel> GetFilteredList(StudentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                return context.Students
                    .Where(rec => rec.Id == model.Id)
                    .Select(CreateModel).ToList();
            }
        }

        public StudentViewModel GetElement(StudentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                var student = context.Students
                .FirstOrDefault(rec => rec.Id == model.Id || rec.Name == model.Name);
                return student != null ?
                CreateModel(student) : null;
            }
        }

        public void Insert(StudentBindingModel model)
        {
            using (var context = new DataBaseContext())
            {
                context.Students.Add(CreateModel(model, new Student()));
                context.SaveChanges();
            }
        }

        public void Update(StudentBindingModel model)
        {
            using (var context = new DataBaseContext())
            {
                var element = context.Students.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Студент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(StudentBindingModel model)
        {
            using (var context = new DataBaseContext())
            {
                Student element = context.Students.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Students.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Студент не найден");
                }
            }
        }

        private Student CreateModel(StudentBindingModel model, Student student)
        {
            student.Name = model.Name;
            student.Image = model.Image;
            student.Direction = model.Direction;
            student.Email = model.Email;
            return student;
        }

        private StudentViewModel CreateModel(Student student)
        {
            return new StudentViewModel
            {
                Id = student.Id,
                Name = student.Name,
                Direction = student.Direction,
                Image = student.Image,
                Email = student.Email
            };
        }
    }
}
