using DataImporter.Membership.Contexts;
using DataImporter.Membership.Repositories;
using DevSkill.Data;

namespace DataImporter.Membership.UnitOfWorks
{
    public class MembershipUnitOfWork : UnitOfWork, IMembershipUnitOfWork
    {
        public IGroupRepository GroupRepository { get; private set; }

        public MembershipUnitOfWork(IMembershipDbContext dbContext, 
            IGroupRepository group)
             : base((MembershipDbContext)dbContext)
        {
            GroupRepository = group;
        }
    }
}