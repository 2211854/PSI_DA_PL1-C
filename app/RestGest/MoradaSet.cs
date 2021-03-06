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
    
    public partial class MoradaSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MoradaSet()
        {
            this.PessoaSet = new HashSet<PessoaSet>();
            this.RestauranteSet = new HashSet<RestauranteSet>();
        }
    
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string CodPostal { get; set; }
        public string Pais { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoaSet> PessoaSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestauranteSet> RestauranteSet { get; set; }

        public override string ToString(){
            return this.Rua+", "+this.CodPostal+" "+this.Cidade+" ("+this.Pais+")";
        }
    }
}
