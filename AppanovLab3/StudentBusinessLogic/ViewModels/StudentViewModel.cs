using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBusinessLogic.ViewModels
{
    public class StudentViewModel
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public string Direction { get; set; }

        public string Email { get; set; }

        public string Image { get; set; }
    }
}
