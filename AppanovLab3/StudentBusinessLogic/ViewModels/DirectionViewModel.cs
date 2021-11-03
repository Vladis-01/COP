using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBusinessLogic.ViewModels
{
    public class DirectionViewModel
    {
        public int? Id { get; set; }

        [DisplayName("Название направления")]
        public string Name { get; set; }
    }
}
