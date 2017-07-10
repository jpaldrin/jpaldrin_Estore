namespace EStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DailySpecials
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public string SalesPrice { get; set; }
    }
}
