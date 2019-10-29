using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public partial class Echadura
    {
        public int EchaduraId { get; set; }
        public int AnioId { get; set; }
        public int CampaniaId { get; set; }
        public string Descripcion { get; set; }
        public int NroPaginas { get; set; }
        public bool Eliminado { get; set; }
        public int UsuarioIdCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaCreacionUtc { get; set; }
        public int? UsuarioIdModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaModificacionUtc { get; set; }
    }
}