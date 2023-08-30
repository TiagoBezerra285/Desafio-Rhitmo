using Desafio_Rhitmo.Dto;
using Desafio_Rhitmo.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio_Rhitmo.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CadastroCartao : ControllerBase
    {

        private ICadastroCartaoRepository _repository;

        public CadastroCartao(ICadastroCartaoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<CadastroCartaoDto>>> FindAll()
        
        {
            var cadastros = await _repository.FindAll();
            return Ok(cadastros);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<CadastroCartaoDto>> FindById(long id)
        {
            var cadastro = await _repository.FindById(id);
            if (cadastro.Id <= 0) return NotFound();
            return Ok(cadastro);
        }

        [HttpPost]
        public async Task<ActionResult<CadastroCartaoDto>> Post(CadastroCartaoDto dto)
        {
            if (dto == null) return BadRequest();
            var cadastro = await _repository.Create(dto);
            return Ok(cadastro);
        }

        [HttpPut]
        public async Task<ActionResult<CadastroCartaoDto>> Update(CadastroCartaoDto dto)
        {
            if (dto == null) return BadRequest();
            var cadastro = await _repository.Update(dto);
            return Ok(cadastro);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CadastroCartaoDto>> Delete(long id)
        {
            var status = await _repository.Delete(id);

            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}
