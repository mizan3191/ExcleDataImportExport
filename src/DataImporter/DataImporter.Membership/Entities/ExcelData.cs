using DevSkill.Data;
using System.Collections.Generic;

namespace DataImporter.Membership.Entities
{
    public class ExcelData : IEntity<int>
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public List<ExcelFieldData> ExcelFieldDatas { get; set; }
    }
}