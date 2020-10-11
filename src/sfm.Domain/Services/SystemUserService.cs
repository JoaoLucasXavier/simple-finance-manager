using sfm.Domain.Interfaces.ISystemUser;
using sfm.Entities.Entities;

namespace sfm.Domain.Services
{
    public class SystemUserService : ISystemUserService
    {
        private readonly ISystemUser _iSystemUser;

        public SystemUserService(ISystemUser iSystemUser)
        {
            _iSystemUser = iSystemUser;
        }

        public void RegisterUserInTheSystem(SystemUser systemUser)
        {
            _iSystemUser.Add(systemUser);
        }
    }
}
