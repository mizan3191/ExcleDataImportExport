using System;

namespace DataImporter.Membership.BusinessObjects
{
    public class ExportHistory
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public Guid ApplicationUserId { get; set; }
        public string Name { get; set; }
        public DateTime ExportDate { get; set; }
        public string Statuse { get; set; }
    }
}