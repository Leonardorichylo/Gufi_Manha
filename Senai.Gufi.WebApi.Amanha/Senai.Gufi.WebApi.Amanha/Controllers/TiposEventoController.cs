﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Gufi.WebApi.Amanha.Domains;
using Senai.Gufi.WebApi.Amanha.Interfaces;
using Senai.Gufi.WebApi.Amanha.Repositories;

namespace Senai.Gufi.WebApi.Amanha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposEventoController : ControllerBase
    {
        private ITipoEventoRepository _tipoEventoRepository { get; set; }

        public TiposEventoController()
        {
            _tipoEventoRepository = new TipoEventoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tipoEventoRepository.Listar());
        }


        [HttpGet("{id}")]
        public IActionResult  GetById(int id)
        {
            return Ok(_tipoEventoRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(TipoEvento novoTipoEvento)
        {
            _tipoEventoRepository.Cadastrar(novoTipoEvento);
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put (int id, TipoEvento tipoEventoAtualizado)
        {
            try
            {
            _tipoEventoRepository.Atualizar(id, tipoEventoAtualizado);
            return StatusCode(201);

            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _tipoEventoRepository.Deletar(id);

            return StatusCode(204);
        }


    }
}