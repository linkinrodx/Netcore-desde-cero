using System;
using System.Collections.Generic;

namespace netcore_desde_cero.Model
{
    public partial class Pagina
    {
        public int PaginaId { get; set; }
        public int EchaduraPaisId { get; set; }
        public int MarcaId { get; set; }
        public int NroPagina { get; set; }
        public int TipoPaginaId { get; set; }
        public bool EsDoble { get; set; }
        public bool EsPar { get; set; }
        public int PlantillaId { get; set; }
        public string Comentario { get; set; }
        public bool Eliminado { get; set; }
        public int UsuarioIdCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaCreacionUtc { get; set; }
        public int? UsuarioIdModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaModificacionUtc { get; set; }
    }
}