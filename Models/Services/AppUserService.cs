using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.Models.Services
{
    public class AppUserService : IAppUserService
    {
        private readonly PoolClubDbContext context;

        public AppUserService(PoolClubDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<AppUser> GetAllAppUsers()
        {
            return context.AppUsers;
        }
        public AppUser GetAppUser(string id)
        {
            return context.AppUsers.Find(id);
        }
        public AppUser AddAppUser(AppUser appUser)
        {
            try
            {
                context.AppUsers.Add(appUser);
                context.SaveChanges();
                return appUser;
            }
            catch
            {
                return null;
            }
        }
        public AppUser DeleteAppUser(string id)
        {
            AppUser appUser = context.AppUsers.Find(id);
            if (appUser != null)
            {
                context.AppUsers.Remove(appUser);
                context.SaveChanges();
            }
            return appUser;
        }
        public AppUser UpdateAppUser(AppUser appUserChanges)
        {
            var appUser=context.AppUsers.Attach(appUserChanges);
            appUser.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return appUserChanges;
        }
    }
}
