using Senai.Gufi.WebApi.Amanha.Domains;
using Senai.Gufi.WebApi.Amanha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Amanha.Repositories
{
    public class TipoEventoRepository : ITipoEventoRepository
    {
        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, TipoEvento tipoEventoAtualizado)
        {
            TipoEvento tipoEventoBuscado = ctx.TipoEvento.Find(id);

            tipoEventoBuscado.TituloTipoEvento = tipoEventoAtualizado.TituloTipoEvento;

            ctx.TipoEvento.Update(tipoEventoBuscado);

            ctx.SaveChanges();
        }

        public TipoEvento BuscarPorId(int id)
        {
            return ctx.TipoEvento.FirstOrDefault(te => te.IdTipoEvento == id);
        }

        public void Cadastrar(TipoEvento novoTIpoEvento)
        {
            ctx.TipoEvento.Add(novoTIpoEvento);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.TipoEvento.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<TipoEvento> Listar()
        {
            return ctx.TipoEvento.ToList();
        }
    }
}
