namespace EStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CartLines
    {
        [Key]
        public int RecordId { get; set; }

        public int ProductId { get; set; }

        public string CartId { get; set; }

        public DateTime DateCreated { get; set; }

        public int Count { get; set; }

        public decimal Tax { get; set; }

        public string ProductName { get; set; }

        public decimal AddPriceOption { get; set; }

        public decimal TotalWithOptions { get; set; }

        public decimal GrandTotal { get; set; }

        public int CountSelectedOptions { get; set; }

        public string ReturnSelectedItems { get; set; }

        public virtual Products Products { get; set; }
    }
}
