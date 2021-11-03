using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBusinessLogic.BindingModels
{
    public class StudentBindingModel
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Direction { get; set; }

        public string Email { get; set; }
    }
}
