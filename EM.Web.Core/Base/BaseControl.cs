﻿using Demo.HIS.MVC.CommonSupport.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EM.Web.Core.Base
{
    [AuthorizeFilterAttribute]
    public class BaseController:Controller
    {
        public int UserId { get; set; }


    }
}
