/+/------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestGest
{
    using System;
    using System.Collections.Generic;
    
    public partial class PagamentoSet
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public int IdMetodoPagamento { get; set; }
        public int IdPedido { get; set; }
    
        public virtual MetodoPagamentoSet MetodoPagamentoSet { get; set; }
        public virtual PedidoSet PedidoSet { get; set; }

        public override string ToString(){
            return "["+this.IdPedido+"]"+this.MetodoPagamentoSet.ToString() +" : "+this.Valor+"€";
        }
    }
}
