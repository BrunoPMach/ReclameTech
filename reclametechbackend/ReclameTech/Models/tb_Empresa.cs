//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReclameTech.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Empresa()
        {
            this.tb_Reclamacao = new HashSet<tb_Reclamacao>();
        }
    
        public int Id_empresa { get; set; }
        public string enderecoPJ { get; set; }
        public string senhaPJ { get; set; }
        public string emailPJ { get; set; }
        public string cnpj { get; set; }
        public string telefonePJ { get; set; }
        public string nomeUsuario { get; set; }
        public Nullable<int> fk_areaEmpresa { get; set; }
    
        public virtual tb_AreaEmpresa tb_AreaEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Reclamacao> tb_Reclamacao { get; set; }
    }
}
