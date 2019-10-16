using System;

namespace ControleFrotas.Domain.Enums
{
    [Flags]
    public enum EnumTipoVeiculo
    {
        Carga = 1,
        Passeio = 2,
        Utilitario = 3,
        Passageiros = 4
    }
}
