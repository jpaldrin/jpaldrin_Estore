using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Data
{
    public class SEOModels
    {
        public int Id { get; set; }
        public string Canonical { get; set; }
        public string BodyClass { get; set; }
        public string Title { get; set; }
        public string Icon32 { get; set; }
        public string Icon192 { get; set; }
        public string AppleIcon128 { get; set; }
        public string MetaPropertyType { get; set; }
        public string MetaPropertyTitle { get; set; }
        public string MetaPropertyDescription { get; set; }
        public string MetaPropertyURL { get; set; }
        public string MetaPropertySiteName { get; set; }
        public string MetaPropertyImage { get; set; }
        public string MetaPropertyLocale { get; set; }
        public string MetaPropertyTwitterImage { get; set; }
        public string MetaPropertyTwitterCard { get; set; }
    }
}
