using DevSkill.Data;
using System;

namespace DataImporter.Membership.Entities
{
    public class ColumnName : IEntity<int>
    {
        public int Id { get; set; }
        public string AddColmn { get; set; }
    }
}