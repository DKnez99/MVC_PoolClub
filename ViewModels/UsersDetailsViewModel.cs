using PoolClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.ViewModels
{
    public class UsersDetailsViewModel
    {
        public AppUser AppUser { get; set; }
        public IList<string> Roles { get; set; }
    }
}
