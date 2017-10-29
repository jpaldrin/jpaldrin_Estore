using EStore.Data;
using EStore.ExternalStore.Models;
using IdentitySample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EStore.ExternalStore.Templates
{
     
    public static partial class TemplateRepository
    {
        public static TemplateThemeIndex GetTemplateThemeIndex(string landingIndexPage)
        {
            TemplateThemeIndex setup = null;

            switch (landingIndexPage)
            {
                case "EStoreIndex":
                    return (GetEstoreIndex());
                default:
                    return setup;
            }
        }
        //Landing Page for Each Store in Que
        public static TemplateThemeIndex GetEstoreIndex()
        {
            EStoreContext db = new EStoreContext();
            //ApplicationDbContext app_Db = new ApplicationDbContext();

            TemplateThemeIndex setup = new TemplateThemeIndex();

            var Title = db.SEOModels.Where(x => x.Id == x.Id);

            setup.Title = Title.ToString();

            return setup;
        }
    }
}