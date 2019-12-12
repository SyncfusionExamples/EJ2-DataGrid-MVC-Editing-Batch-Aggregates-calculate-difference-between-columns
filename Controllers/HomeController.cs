#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using EssentialJS2MvcApplication1.Models;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace EssentialJS2MvcApplication1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
}
}