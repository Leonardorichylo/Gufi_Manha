﻿using Senai.Gufi.WebApi.Amanha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Amanha.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> Listar();

        void Cadastrar(TipoUsuario novoTipoUsuario);

        void Atualizar(int id, TipoUsuario tipoUsuarioAtualizado);

        void Deletar(int id);

        TipoUsuario BuscarPorId(int id);
    }
}
