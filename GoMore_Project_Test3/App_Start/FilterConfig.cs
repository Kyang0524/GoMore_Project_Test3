﻿using System.Web;
using System.Web.Mvc;

namespace GoMore_Project_Test3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
