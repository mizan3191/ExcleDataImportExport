using DataImporter.Membership.Contexts;
using DataImporter.Membership.Entities;
using DevSkill.Data;
using System;

namespace DataImporter.Membership.Repositories
{
    public class GroupRepository : Repository<Group, Guid, MembershipDbContext>, IGroupRepository
    {
        public GroupRepository(IMembershipDbContext dbContext)
            : base((MembershipDbContext)dbContext)
        {
        }
    }
}