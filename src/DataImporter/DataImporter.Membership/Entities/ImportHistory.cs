using DevSkill.Data;
using System;

namespace DataImporter.Membership.Entities
{
    public class ImportHistory : IEntity<int>
    {
        public int Id { get; set; }
        public Guid ApplicationUserId { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime ImportDate { get; set; }
        public string Status { get; set; }
        public Group Group { get; set; }
    }
}