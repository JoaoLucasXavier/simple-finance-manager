using System;
using System.Collections.Generic;
using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces.ISystemUser
{
    public interface ISystemUser : IGeneric<SystemUser>
    {
        IList<SystemUser> ListSystemUsers(Guid SystemId);
        void RemoveUsers(List<SystemUser> users);
        SystemUser GetUserByEmail(string userEmail);
    }
}
