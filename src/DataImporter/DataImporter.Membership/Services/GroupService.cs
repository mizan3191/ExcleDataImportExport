using DataImporter.Membership.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataImporter.Membership.Services
{
    public class GroupService : IGroupService
    {
        private readonly IMembershipUnitOfWork _unitOfWork;
        public GroupService(IMembershipUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}