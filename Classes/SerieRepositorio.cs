using System;
using System.Collections.Generic;
using Series.Interfaces;


namespace Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> _listaSerie = new List<Serie>();
        public void Atualize(int id, Serie entidade)
        {
            _listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            // _listaSerie.RemoveAt(id); //se eu fizer isso, os índices vão mudar, não queremos
            _listaSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            _listaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return _listaSerie;
        }

        public int ProximoId()
        {
            return _listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return _listaSerie[id];
        }
    }
}