﻿using Bang.DataAccess;
using Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bang.Business
{
    public class AdminSysManager
    {
        public static LoginInfoModel VerifyUserLogin(string userName, string password)
        {
            return AdminSysDataAccess.VerifyUserLogin(userName, password);
        }
    }
}
