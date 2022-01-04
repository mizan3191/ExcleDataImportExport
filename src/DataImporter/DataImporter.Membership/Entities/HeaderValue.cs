using DevSkill.Data;

namespace DataImporter.Membership.Entities
{
    public class HeaderValue : IEntity<int>
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public int HeaderPosition { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}