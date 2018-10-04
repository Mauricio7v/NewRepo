using app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace app.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(app.Models.Usuario userModel)
        {
            using (LoginEntities db = new LoginEntities())
            {
                var userDetailsN = db.Usuario.Where(x => x.nombreus == userModel.nombreus && x.pass == userModel.pass).FirstOrDefault();
                if (userDetailsN == null)
                {
                    userModel.LoginErrorMessage = "Nombre de usuario o contraseña incorrectos.";
                    return View("Index", userModel);
                }
                else
                {
                    Session["usuarioId"] = userDetailsN.usuarioId;
                    Session["nombreus"] = userDetailsN.nombreus;
                    return RedirectToAction("Index", "Home");
                }




            }
        }

        public ActionResult LogOut()
        {
            int userId = (int)Session["usuarioId"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}
