using DevSkill.Data;
using System;

namespace DataImporter.Membership.Entities
{
    public class ExportHistory : IEntity<int>
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public Guid ApplicationUserId { get; set; }
        public string GroupName { get; set; }
        public DateTime ExportDate { get; set; }
        public string Statuse { get; set; }
        public Group Group { get; set; }
    }
}