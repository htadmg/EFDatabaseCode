namespace EFDatabaseCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produto")]
    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            PedidoProduto = new HashSet<PedidoProduto>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        public double? Valor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoProduto> PedidoProduto { get; set; }
    }
}
