namespace EStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Options
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Options()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        public int OptionID { get; set; }

        [Required]
        public string OptionsCategory { get; set; }

        [Required]
        public string OptionName { get; set; }

        public decimal OptionPrice { get; set; }

        public decimal LgOptionPrice { get; set; }

        public byte[] ImageData { get; set; }

        public string ImageMimeType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
