using Microsoft.AspNetCore.Mvc;

using TaskBook_WebBlazor.Entity;
using TaskBook_WebBlazor.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskBook_WebBlazor.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskAPIController : ControllerBase
    {
        // GET: api/<TaskAPI>
        [HttpGet]
        public IEnumerable<Task_Book> Get()
        {
            return SingleTBVM.Instance._Task_Books;
        }

        // GET api/<TaskAPI>/5
        [HttpGet("{id}")]
        public Task_Book? Get(int id)
        {
            return SingleTBVM.Instance._Task_Books?.FirstOrDefault(x => x.ID == id);
        }

        // POST api/<TaskAPI>
        [HttpPost]
        public void Post([FromBody] Task_Book value)
        {
            SingleTBVM.Instance?.Create_Task(value);
        }

        // PUT api/<TaskAPI>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Task_Book value)
        {
        }

        // DELETE api/<TaskAPI>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            var f = SingleTBVM.Instance._Task_Books?.FirstOrDefault(x => x.ID == id);

            _ = SingleTBVM.Instance.Delete_Task(f);
        }
    }
}
