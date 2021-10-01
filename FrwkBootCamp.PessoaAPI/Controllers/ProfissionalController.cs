using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FrameBook.Business.DTO.DTO;
using FrameBook.Business.Interfaces;

namespace FrameBook.ProfissionalAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProfissionalController : ControllerBase
    {

        private readonly IBusinessServiceGestaoProfissional _businessServiceGestaoProfissional;

        public ProfissionalController(IBusinessServiceGestaoProfissional businessServiceGestaoProfissional)
        {
            _businessServiceGestaoProfissional = businessServiceGestaoProfissional;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_businessServiceGestaoProfissional.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_businessServiceGestaoProfissional.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ProfissionalDTO profissionalDTO)
        {
            if (profissionalDTO == null)
                return NotFound();

            _businessServiceGestaoProfissional.Add(profissionalDTO);
            return Ok("Profissional cadastrado com sucesso!");
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ProfissionalDTO profissionalDTO)
        {
            if (profissionalDTO == null)
                return NotFound();

            _businessServiceGestaoProfissional.Update(profissionalDTO);
            return Ok("Profissional atualizado com sucesso!");
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ProfissionalDTO profissionalDTO)
        {
            if (profissionalDTO == null)
                return NotFound();

            _businessServiceGestaoProfissional.Remove(profissionalDTO);
            return Ok("Profissional removido com sucesso!");
        }
    }
}