//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalarioPersonaPermanente
    {
        public int idSalarioPersonaPermanente { get; set; }
        public string DocumentoPersona { get; set; }
        public decimal Valor { get; set; }
        public Nullable<int> idRegistroPago { get; set; }
    
        public virtual Persona Persona { get; set; }
        public virtual RegistroPago RegistroPago { get; set; }
    }
}
