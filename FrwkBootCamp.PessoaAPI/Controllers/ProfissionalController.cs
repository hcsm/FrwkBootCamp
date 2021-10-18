using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FrameBook.Business.DTO.DTO;
using FrameBook.Business.Interfaces;
using AutoMapper;

namespace FrameBook.ProfissionalAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProfissionalController : ControllerBase
    {
        private readonly IBusinessServiceGestaoProfissional _businessServiceGestaoProfissional;
        IMapper _mapper;

        public ProfissionalController(IBusinessServiceGestaoProfissional businessServiceGestaoProfissional,
            IMapper mapper)
        {
            _businessServiceGestaoProfissional = businessServiceGestaoProfissional;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_businessServiceGestaoProfissional.GetAll());
        }

        // GET api/values/5
        [HttpGet("{email}")]
        public ActionResult<string> Get(string email)
        {
            var profissional = _businessServiceGestaoProfissional.GetByEmail(email, null);
            var profissionalDTO = _mapper.Map<ProfissionalDTO>(profissional);
            return Ok(profissionalDTO);
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