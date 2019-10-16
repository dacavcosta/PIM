using ControleFrotas.Domain.Enums;
using System;

namespace ControleFrotas.Domain.Model
{
    public class CNH : BaseEntity
    {
        public int Numero { get; set; }
        public int Registro { get; set; }
        public EnumCategoriaCNH Categoria { get; set; }
        public DateTime Validade { get; set; }
        public int ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }
    }
}