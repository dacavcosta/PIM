using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ControleFrotas.Domain.Model
{
    public class Colaborador : BaseEntity
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Rg { get; set; }
        public int CPF { get; set; }
        public int Telefone { get; set; }
        public CNH CNH { get; set; }
        public int Categoria { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/YYYY}")]
        public DateTime Vencimento { get; set; }
        public List<Reserva> Reservas { get; set; }
        public List<Uso> Usos { get; set; }
    }
}