﻿using System.Web;
using System.Web.Mvc;

namespace S1P04_Practical_04
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
