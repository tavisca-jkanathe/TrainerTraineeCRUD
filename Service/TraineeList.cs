using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainerTraineeCRUD.Model;

namespace TrainerTraineeCRUD.Service
{
    public class TraineeList
    {
        public static List<Trainee> traineeList = new List<Trainee>();

        public void AddTrainee(Trainee trainee)
        {
          traineeList.Add(trainee);
        }
      
        public  IEnumerable<Trainee> ShowTraineeList()
        {
            return traineeList.ToList();
        }
        public Trainee ShowTraineeListbyId(int id)
        {
            if(traineeList.Count == 0)
            {
                return null;
            }

            return traineeList[traineeList.FindIndex(Trainee => Trainee.EmployeeId == id)];
            
        }
        public void UpdateTraineeListbyId(int id, Trainee trainee)
        {
            if (traineeList.Count == 0)
            {
                return;
            }

            traineeList[traineeList.FindIndex(Trainee => Trainee.EmployeeId == id)] =trainee;

        }

        public void RemoveTraineeListbyId(int id)
        {
            if (traineeList.Count == 0)
            {
                return ;
            }

            traineeList.RemoveAt(traineeList.FindIndex(Trainee => Trainee.EmployeeId == id));

        }
    }
}
