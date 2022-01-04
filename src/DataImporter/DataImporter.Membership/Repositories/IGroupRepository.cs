using DataImporter.Membership.Contexts;
using DataImporter.Membership.Entities;
using DevSkill.Data;
using System;

namespace DataImporter.Membership.Repositories
{
    public interface IGroupRepository : IRepository<Group, Guid, MembershipDbContext>
    {
    }
}