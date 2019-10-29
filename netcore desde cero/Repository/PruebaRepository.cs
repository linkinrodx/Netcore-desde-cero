using netcore_desde_cero.Context;
using netcore_desde_cero.Interface;
using netcore_desde_cero.Model;
using netcore_desde_cero.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_desde_cero.Repository
{
    public class PruebaRepository : IPruebaRepository
    {
        private readonly AtomoContext atomoContext;

        public PruebaRepository(AtomoContext atomoContext)
        {
            this.atomoContext = atomoContext;
        }

        public List<EchaduraResult> GetPrueba()
        {
            var hola = atomoContext.Echadura.Where(o => o.EchaduraId == 1).ToList();

            var prueba = (from x in atomoContext.Echadura
                          where x.EchaduraId == 1
                          select new EchaduraResult() {
                              EchaduraId = x.EchaduraId,
                              AnioId = x.AnioId,
                              CampaniaId = x.CampaniaId,
                              Descripcion = x.Descripcion,
                              NroPaginas = x.NroPaginas
                          }).ToList();

            return prueba;
        }
    }
}
