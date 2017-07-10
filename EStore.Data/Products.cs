namespace EStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            CartLines = new HashSet<CartLines>();
            OrderDetails = new HashSet<OrderDetails>();
            Options = new HashSet<Options>();
        }

        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal LgPrice { get; set; }

        [Required]
        public string Category { get; set; }

        public byte[] ImageData { get; set; }

        public string ImageMimeType { get; set; }

        public int AvailableOptionsWithProduct { get; set; }

        public int ReservedOptionsWithProduct { get; set; }

        [Required]
        public string Barcode { get; set; }

        public int? Taxed_TaxId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartLines> CartLines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public virtual TaxTables TaxTables { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Options> Options { get; set; }
    }
}
