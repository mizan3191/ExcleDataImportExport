using DataImporter.Membership.Repositories;
using DevSkill.Data;

namespace DataImporter.Membership.UnitOfWorks
{
    public interface IMembershipUnitOfWork : IUnitOfWork
    {
        IGroupRepository GroupRepository { get; }
    }
}