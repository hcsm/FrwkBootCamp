using FrwkBootCamp.Business.DTO.DTO;
using FrwkBootCamp.Pessoa.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FrwkBootCamp.PessoaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {

        private readonly IBusinessServiceGestaoPessoa _businessServiceGestaoPessoa;

        public PessoaController(IBusinessServiceGestaoPessoa businessServiceGestaoPessoa)
        {
            _businessServiceGestaoPessoa = businessServiceGestaoPessoa;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_businessServiceGestaoPessoa.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_businessServiceGestaoPessoa.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] PessoaDTO pessoaDTO)
        {
            if (pessoaDTO == null)
                return NotFound();

            _businessServiceGestaoPessoa.Add(pessoaDTO);
            return Ok("Pessoa Cadastrado com sucesso!");
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] PessoaDTO pessoaDTO)
        {
            if (pessoaDTO == null)
                return NotFound();

            _businessServiceGestaoPessoa.Update(pessoaDTO);
            return Ok("Pessoa Atualizado com sucesso!");
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] PessoaDTO pessoaDTO)
        {
            if (pessoaDTO == null)
                return NotFound();

            _businessServiceGestaoPessoa.Remove(pessoaDTO);
            return Ok("Pessoa Removido com sucesso!");
        }
    }
}