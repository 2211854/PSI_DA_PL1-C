//------------------------------------------------------------------------------
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
    
    public partial class ItemMenuSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemMenuSet()
        {
            this.PedidoSet = new HashSet<PedidoSet>();
            this.RestauranteSet = new HashSet<RestauranteSet>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fotografia { get; set; }
        public string Ingredientes { get; set; }
        public decimal Preco { get; set; }
        public bool Ativo { get; set; }
        public int IdCategoria { get; set; }
    
        public virtual CategoriaSet CategoriaSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoSet> PedidoSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestauranteSet> RestauranteSet { get; set; }

        public override string ToString(){
            return this.Nome+"  "+this.Preco;
        }
    }
}
