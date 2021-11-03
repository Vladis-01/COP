using StudentBusinessLogic.Interfaces;
using StudentBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBusinessLogic.BusinessLogics
{
    public class DirectionLogic
    {
        private readonly IDirectionStorage _directionStorage;
        public DirectionLogic(IDirectionStorage directionStorage)
        {
            _directionStorage = directionStorage;
        }
        public List<DirectionViewModel> Read(DirectionBindingModel model)
        {
            if (model == null)
            {
                return _directionStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<DirectionViewModel> { _directionStorage.GetElement(model) };
            }
            return _directionStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(DirectionBindingModel model)
        {
            var element = _directionStorage.GetElement(new DirectionBindingModel
            {
                Name = model.Name
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Такое направление уже существует");
            }
            if (model.Id.HasValue)
            {
                _directionStorage.Update(model);
            }
            else
            {
                _directionStorage.Insert(model);
            }
        }
        public void Delete(DirectionBindingModel model)

        {
            var element = _directionStorage.GetElement(new DirectionBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Направление не найдено");
            }
            _directionStorage.Delete(model);
        }

    }
}
