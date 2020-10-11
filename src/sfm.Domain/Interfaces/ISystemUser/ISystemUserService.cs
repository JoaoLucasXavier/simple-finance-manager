using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces.ISystemUser
{
    public interface ISystemUserService
    {
        void RegisterUserInTheSystem(SystemUser systemUser);
    }
}
