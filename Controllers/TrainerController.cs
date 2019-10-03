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
    public class TrainerController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Trainer> Get()
        {
            TrainerList trainerList = new TrainerList();
            return trainerList.ShowTrainerList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Trainer Get(int id)
        {
            TrainerList trainerList = new TrainerList();
            return trainerList.ShowTrainerListbyId(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Trainer trainer)
        {
            TrainerList trainerList = new TrainerList();
            trainerList.AddTrainer(trainer);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Trainer trainer)
        {
            TrainerList trainerList = new TrainerList();
            trainerList.UpdateTrainerListbyId(id, trainer);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            TrainerList trainerList = new TrainerList();
            trainerList.RemoveTrainerListbyId(id);

        }
    }
}