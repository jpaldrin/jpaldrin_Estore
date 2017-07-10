namespace EStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        [Key]
        public int OrderId { get; set; }

        public string UserName { get; set; }

        [Required]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required]
        [StringLength(70)]
        public string StreetAddress { get; set; }

        [Required]
        [StringLength(40)]
        public string CityName { get; set; }

        [Required]
        [StringLength(40)]
        public string State { get; set; }

        [StringLength(10)]
        public string Zip { get; set; }

        [Required]
        [StringLength(24)]
        public string Phone { get; set; }

        public string Email { get; set; }

        public decimal OptionsTotal { get; set; }

        public decimal ProductsTotal { get; set; }

        public decimal Tax { get; set; }

        public decimal GrandTotal { get; set; }

        public DateTime OrderDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
