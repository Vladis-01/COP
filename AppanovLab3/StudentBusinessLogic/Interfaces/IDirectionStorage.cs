using StudentBusinessLogic.BusinessLogics;
using StudentBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBusinessLogic.Interfaces
{
    public interface IDirectionStorage
    {
        List<DirectionViewModel> GetFullList();
        List<DirectionViewModel> GetFilteredList(DirectionBindingModel model);
        DirectionViewModel GetElement(DirectionBindingModel model);
        void Insert(DirectionBindingModel model);
        void Update(DirectionBindingModel model);
        void Delete(DirectionBindingModel model);
    }
}
