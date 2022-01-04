using Microsoft.AspNetCore.Identity;
using System;

namespace DataImporter.Membership.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FullName { get; set; }
    }
}