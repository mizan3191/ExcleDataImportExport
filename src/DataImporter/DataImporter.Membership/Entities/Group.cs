using DevSkill.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataImporter.Membership.Entities
{
    public class Group : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ApplicationUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public List<ImportHistory> ImportHistories { get; set; }
        public List<ExportHistory> ExportHistories { get; set; }
        public List<ExcelData> ExcelDatas { get; set; }
        public List<HeaderValue> Headers { get; set; }
    }
}