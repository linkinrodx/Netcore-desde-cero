using netcore_desde_cero.Model;
using netcore_desde_cero.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_desde_cero.Interface
{
    public interface IPruebaRepository
    {
        List<EchaduraResult> GetPrueba();
    }
}
