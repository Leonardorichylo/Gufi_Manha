using Senai.Gufi.WebApi.Amanha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Amanha.Interfaces
{
    interface IEventoRepository
    {
        List<Evento> Listar();

        void Cadastrar(Evento novoEvento);

        void Atualizar(int id, Evento EventoAtualizado);

        void Deletar(int id);

        Evento BuscarPorId(int id);
    }
}
