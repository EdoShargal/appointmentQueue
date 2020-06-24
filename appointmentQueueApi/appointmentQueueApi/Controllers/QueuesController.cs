using appointmentQueueApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace appointmentQueueApi.Controllers
{
    public class QueuesController : ApiController
    {
        QueuesDB db = new QueuesDB();

        // GET: api/Queues
        public List<Queue> Get()
        {
            return db.Queues.ToList<Queue>();
        }

        // GET: api/Queues/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Queues
        public Queue Post([FromBody] Queue queue)
        {
            db.Queues.Add(queue);
            db.SaveChanges();

            return queue; 
        }

        //// PUT: api/Queues/5
        //public Queue Put([FromUri]int id, [FromBody]Queue value)
        //{
        //    var queue = db.Queues.Where(q => q.Number == id).FirstOrDefault<Queue>();
        //    queue.Status = value.Status;

        //    db.SaveChanges();
        //    return queue;
        //}

        public Queue Put([FromUri]int id, [FromBody]int status)
        {
            var queue = db.Queues.Where(q => q.Number == id).FirstOrDefault<Queue>();
            queue.Status = status;

            db.SaveChanges();
            return queue;
        }

        // DELETE: api/Queues/5
        public void Delete(int id)
        {
        }
    }
}
