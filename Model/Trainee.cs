using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainerTraineeCRUD.Model;

namespace TrainerTraineeCRUD.Model
{
    public class Trainee : Employee
    {
        public string TraineeBatch { get; set; }
    }
}
