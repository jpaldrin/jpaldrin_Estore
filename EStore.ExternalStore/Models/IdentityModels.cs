using IdentitySample.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentitySample.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }


        #region Add items to User model
        //0 
        public string FirstName { get; set; }
        //1
        public string LastName { get; set; }
        //2
        //public string Address { get; set; }
        ////3
        //public string City { get; set; }
        ////4
        //public string State { get; set; }
        ////5
        //[Display(Name = "Postal Code")]
        //public string PostalCode { get; set; }
        //6
        public string Telephone { get; set; }

        // Concatenate the address info for display in tables and such:
        public string DisplayAddress
        {
            get
            {
                string dspFirstName =
                    string.IsNullOrWhiteSpace(this.FirstName) ? "" : this.FirstName;
                string dspLastName =
                    string.IsNullOrWhiteSpace(this.LastName) ? "" : this.LastName;
                //string dspAddress =
                //    string.IsNullOrWhiteSpace(this.Address) ? "" : this.Address;
                //string dspCity =
                //    string.IsNullOrWhiteSpace(this.City) ? "" : this.City;
                //string dspState =
                //    string.IsNullOrWhiteSpace(this.State) ? "" : this.State;
                //string dspPostalCode =
                //    string.IsNullOrWhiteSpace(this.PostalCode) ? "" : this.PostalCode;
                string dspTelephone =
                    string.IsNullOrWhiteSpace(this.Telephone) ? "" : this.Telephone;


                return string
                    .Format("{0} {1} {2}", dspFirstName, dspLastName, dspTelephone);
            }
        }
        #endregion
    }

    // IdentityRole represents an actual Role entity in our application and in the database, 
    // while IdentityUserRole represents the relationship between a User and a Role.
    // Derived from Identity Role : IdentityRole
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string name) : base(name) { }
        public string Description { get; set; }
    }
    // MinotStoreApplicationResetDbContext MinotStoreDbContextReset
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("EStoreIdentity")
        {
        }
        public DbSet<UserProfile> UserProfiles { get; set; }

        [Table("UserProfile")]
        public class UserProfile
        {
            [Key]
            [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
            public int UserId { get; set; }
            public string UserName { get; set; }
        }

        static ApplicationDbContext()
        {
            Database.SetInitializer<ApplicationDbContext>(new ApplicationDbInitializer());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}