using DevSkill.Data;
using System;

namespace DataImporter.Membership.Entities
{
    public class ExcelFieldData : IEntity<int>
    {
        public int Id { get; set; }
        public int ExcelDataId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public ExcelData ExcelData { get; set; }
    }
}