using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.Models.Services
{
    public interface IAppUserService
    {
        public IEnumerable<AppUser> GetAllAppUsers();
        public AppUser GetAppUser(int id);
        public AppUser AddAppUser(AppUser appUser);
        public AppUser DeleteAppUser(int id);
        public AppUser UpdateAppUser(AppUser appUserChanges);

    }
}
