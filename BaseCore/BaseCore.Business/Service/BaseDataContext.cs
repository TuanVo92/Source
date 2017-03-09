using BaseCore.Common.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCore.Business.Service
{
    public class BaseDataContext : BaseDao
    {
        private static string dbConnString = ConfigHelper.GetConnString("db.config");
        private static string dbUser = ConfigHelper.GetString("db.username");
        private static string dbPass = ConfigHelper.GetString("db.password");

        public BaseDataContext()
            : base(dbConnString, dbUser, dbPass)
        {

        }

        public BaseDataContext(string pDbConnString, string pDbUser, string pDbPass)
            : base(pDbConnString, pDbUser, pDbPass)
        {

        }

        //TODO...
    }
}
