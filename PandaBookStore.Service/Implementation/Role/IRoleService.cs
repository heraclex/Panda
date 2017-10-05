using PandaBookStore.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service
{
    public interface IRoleService : IService
    {
        RoleModel InsertRole(RoleModel model);

        RoleModel UpdateRole(RoleModel model);

        void DeleteRole(RoleModel model);
        
        IList<RoleModel> GetAllRoles();

        RoleModel GetRoleById(int id);
    }
}
