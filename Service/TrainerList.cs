using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainerTraineeCRUD.Model;

namespace TrainerTraineeCRUD.Service
{
    public class TrainerList
    {
        public static List<Trainer> trainerList = new List<Trainer>();
        public void AddTrainer(Trainer trainer)
        {
            trainerList.Add(trainer);
        }

        public IEnumerable<Trainer> ShowTrainerList()
        {
            return trainerList.ToList();
        }
        public Trainer ShowTrainerListbyId(int id)
        {
            if (trainerList.Count == 0)
            {
                return null;
            }

            return trainerList[trainerList.FindIndex(Trainer => Trainer.EmployeeId == id)];

        }
        public void UpdateTrainerListbyId(int id, Trainer trainer)
        {
            if (trainerList.Count == 0)
            {
                return;
            }

            trainerList[trainerList.FindIndex(Trainer => Trainer.EmployeeId == id)] = trainer;

        }

        public void RemoveTrainerListbyId(int id)
        {
            if (trainerList.Count == 0)
            {
                return;
            }

            trainerList.RemoveAt(trainerList.FindIndex(Trainer => Trainer.EmployeeId == id));

        }
    }
}
