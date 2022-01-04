using System;

namespace DataImporter.Membership.BusinessObjects
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ApplicationUserId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}