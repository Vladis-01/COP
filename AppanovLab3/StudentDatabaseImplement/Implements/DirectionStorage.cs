using StudentBusinessLogic.BusinessLogics;
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
    public class DirectionStorage: IDirectionStorage
    {
        public List<DirectionViewModel> GetFullList()
        {
            using (var context = new DataBaseContext())
            {
                return context.Directions
                .Select(CreateModel).ToList();
            }
        }

        public List<DirectionViewModel> GetFilteredList(DirectionBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                return context.Directions
                    .Where(rec => rec.Id == model.Id)
                    .Select(CreateModel).ToList();
            }
        }

        public DirectionViewModel GetElement(DirectionBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                var direction = context.Directions
                .FirstOrDefault(rec => rec.Id == model.Id || rec.Name == model.Name);
                return direction != null ?
                CreateModel(direction) : null;
            }
        }

        public void Insert(DirectionBindingModel model)
        {
            using (var context = new DataBaseContext())
            {
                context.Directions.Add(CreateModel(model, new Direction()));
                context.SaveChanges();
            }
        }

        public void Update(DirectionBindingModel model)
        {
            using (var context = new DataBaseContext())
            {
                var element = context.Directions.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Направление не найдено");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(DirectionBindingModel model)
        {
            using (var context = new DataBaseContext())
            {
                Direction element = context.Directions.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Directions.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Направление не найдено");
                }
            }
        }

        private Direction CreateModel(DirectionBindingModel model, Direction direction)
        {
            direction.Name = model.Name;
            return direction;
        }

        private DirectionViewModel CreateModel(Direction direction)
        {
            return new DirectionViewModel
            {
                Id = direction.Id,
                Name = direction.Name,
            };
        }
    }
}
