﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace BaiTapLon.Models
{
    public class Encrytion
    {
        public string PasswordEncrytion(string pass)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "MD5");
        }

    }
}