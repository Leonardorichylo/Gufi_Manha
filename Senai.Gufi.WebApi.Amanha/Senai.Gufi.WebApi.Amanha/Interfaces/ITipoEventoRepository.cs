using Senai.Gufi.WebApi.Amanha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Amanha.Interfaces
{
    interface ITipoEventoRepository
    {
        List<TipoEvento> Listar();

        void Cadastrar(TipoEvento novoTIpoEvento);

        void Atualizar(int id, TipoEvento tipoEventoAtualizado);

        void Deletar(int id);

        TipoEvento BuscarPorId(int id);
    }
}
