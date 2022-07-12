using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillyGym.Domain.Enum
{
    public enum Roles
    {

    }

    public static class Constants
    {
        public static readonly string Boss = Guid.NewGuid().ToString();
        public static readonly string AdministratorReception = Guid.NewGuid().ToString();
        public static readonly string AdministratorGYM = Guid.NewGuid().ToString();
        public static readonly string Cleaner = Guid.NewGuid().ToString();

        public static readonly string BossUser = Guid.NewGuid().ToString();
        public static readonly string CleanerUser = Guid.NewGuid().ToString();
    }
}
