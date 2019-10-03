using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainerTraineeCRUD.Model;
using TrainerTraineeCRUD.Service;

namespace TrainerTraineeCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineeController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Trainee> Get()
        {
            TraineeList traineeList = new TraineeList();
            return traineeList.ShowTraineeList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Trainee Get(int id)
        {
            TraineeList traineeList = new TraineeList();
            return traineeList.ShowTraineeListbyId(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Trainee trainee)
        {
            TraineeList traineeList = new TraineeList();
            traineeList.AddTrainee(trainee);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Trainee trainee)
        {
            TraineeList traineeList = new TraineeList();
            traineeList.UpdateTraineeListbyId(id , trainee);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            TraineeList traineeList = new TraineeList();
            traineeList.RemoveTraineeListbyId(id);

        }
    }
}