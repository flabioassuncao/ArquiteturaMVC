﻿using FA.ArquiteturaMVC.CrossCutting.MVCFilters;
using System.Web.Mvc;

namespace FA.ArquiteturaMVC.UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalErrorHandler());
        }
    }
}
