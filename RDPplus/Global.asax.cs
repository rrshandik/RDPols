﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace RDPplus
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Default route
            routes.MapPageRoute("DefaultRoute", "", "~/Pages/Login/Login.aspx");

            // Route to Home.aspx without specifying full path
            routes.MapPageRoute("HomeRoute", "homepage", "~/Pages/Home/Home.aspx");
            routes.MapPageRoute("LoginRoute", "adminLogin", "~/Pages/Login/Login.aspx");

            //Employee Data
            routes.MapPageRoute("EmployeeDataRoute", "employee-data", "~/Pages/Employee-data/employee-data.aspx");
            routes.MapPageRoute("EmployeeEditRoute", "employee-edit", "~/Pages/Employee-data/employee-edit/employee-edit.aspx");

            //RDP
            routes.MapPageRoute("RDP-menu", "menu-rdp", "~/Pages/Menu-rdp/menu-rdp.aspx");
            routes.MapPageRoute("RDP-data", "data-rdp", "~/Pages/Menu-rdp/data-rdp/data-rdp.aspx");
            routes.MapPageRoute("RDP-edit", "edit-rdp", "~/Pages/Menu-rdp/data-rdp/edit-data-rdp/edit-rdp.aspx");
            routes.MapPageRoute("RDP-tersedia", "tersedia-rdp", "~/Pages/Menu-rdp/tersedia-rdp/tersedia-rdp.aspx");
            routes.MapPageRoute("RDP-lelang", "lelang-rdp", "~/Pages/Menu-rdp/lelang-rdp/lelang-rdp.aspx");
            routes.MapPageRoute("RDP-detail", "detail-rdp", "~/Pages/Menu-rdp/detail-rdp/detail-rdp.aspx");
            routes.MapPageRoute("RDP-penyerahan", "penyerahan-rdp", "~/Pages/Menu-rdp/penyerahan-kunci-rdp/penyerahan-kunci.aspx");
            routes.MapPageRoute("RDP-penunjukkan", "penunjukkan-rdp", "~/Pages/Menu-rdp/penunjukkan-rdp/penunjukkan-rdp.aspx");
            routes.MapPageRoute("RDP-kunci", "kunci-rdp", "~/Pages/Menu-rdp/data-kunci/data-kunci.aspx");

            //Laporan Pemilik RDP
            routes.MapPageRoute("laporan-rdp", "laporan-rdp", "~/Pages/Laporan-pemilik/laporan-pemilik.aspx");


            //AM
            //rdp
            routes.MapPageRoute("AM-RDP-menu", "am-menu-rdp", "~/Pages/AM/AM-menu-rdp/am-menu-rdp.aspx");
            routes.MapPageRoute("AM-RDP-data", "am-data-rdp", "~/Pages/AM/AM-menu-rdp/am-data-rdp/am-data-rdp.aspx");




            // Add more routes
        }
        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}