﻿using System.Web;
using System.Web.Mvc;

namespace _2.OdeToFood4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
