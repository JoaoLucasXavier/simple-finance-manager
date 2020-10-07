using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces
{
    public interface ISystemUserService
    {
        void RegisterUserInTheSystem(SystemUser systemUser);
    }
}
