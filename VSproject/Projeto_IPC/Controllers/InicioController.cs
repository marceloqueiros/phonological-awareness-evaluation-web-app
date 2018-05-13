using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto_IPC.Models;
using System.Web.Security;

namespace Projeto_IPC.Controllers
{
    [AllowAnonymous]
    public class InicioController : Controller
    {
        DataClassesDBIPCDataContext DB = new DataClassesDBIPCDataContext();
        

        [AllowAnonymous]
        public ActionResult Registo()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            if(DB.Utilizadors.Where(x => x.email == HttpContext.User.Identity.Name).Count() > 0)
            {
                return RedirectToAction("ProvasRealizadas", "Teste");
            }

            return View();
        }

        [AllowAnonymous]
        public ActionResult AtivarConta()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult RecuperarPassword()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Registo(FormCollection Dados)
        {
            if (DB.Utilizadors.Where(x => x.email == HttpContext.User.Identity.Name).Count() > 0)
            {
                return RedirectToAction("ProvasRealizadas", "Teste");
            }
            if (Dados["UserName"] == null || Dados["UserName"] == "")
                ModelState.AddModelError("UserName", "Tem de introduzir um Username!");

            if (Dados["NomeCompleto"] == null || Dados["NomeCompleto"] == "")
                ModelState.AddModelError("NomeCompleto", "Tem de introduzir um Nome!");

            if (Dados["Email"] == null || Dados["Email"] == "")
                ModelState.AddModelError("Email", "Tem de introduzir um Email!");

            if (Dados["Password1"] == null || Dados["Password1"] == "")
                ModelState.AddModelError("Password1", "Tem de introduzir uma Password!");

            if (Dados["Password2"] == null || Dados["Password2"] == "" || Dados["Password2"] != Dados["Password1"])
                ModelState.AddModelError("Password2", "Tem de introduzir novamente a Password!");

            if (Dados["Telefone"] == null || Dados["Telefone"] == "")
                ModelState.AddModelError("Telefone", "Tem de introduzir um Telefone!");            

            try
            {

                if (Convert.ToDateTime(Dados["datadenascimento"]) > DateTime.Now)
                    ModelState.AddModelError("datadenascimento", "A data tem de ser inferior à data atual.");
            }
            catch
            {
                ModelState.AddModelError("datadenascimento", "Tem de inserir uma Data.");
            }

            if (Dados["Telefone"] == null || Dados["Telefone"] == "")
                ModelState.AddModelError("Localidade", "Tem de introduzir uma Localidade!");

            if (Dados["Telefone"] == null || Dados["Telefone"] == "")
                ModelState.AddModelError("Morada", "Tem de introduzir uma Morada!");

            if (Dados["Telefone"] == null || Dados["Telefone"] == "")
                ModelState.AddModelError("CodPostal", "Tem de introduzir um Código Postal!");

            if (Dados["CheckBoxConcordar"] == null)
                ModelState.AddModelError("CheckBoxConcordar", "Tem de concordar com os termos!");

            if (ModelState.IsValid)
            {
                //Criar Novo Registo
                Utilizador NovoUser = new Utilizador();

                NovoUser.username = Dados["UserName"];
                NovoUser.nome = Dados["NomeCompleto"];
                NovoUser.email = Dados["Email"];
                NovoUser.palavra_chave = Funcionalidades.CalculateMD5Hash(Dados["password1"] + "IPC");
                NovoUser.tefelone = Dados["Telefone"];
                NovoUser.dataNascimento = Convert.ToDateTime(Dados["datadenascimento"]);
                NovoUser.morada = Dados["Morada"];
                NovoUser.localidade = Dados["Localidade"];
                NovoUser.codigoPostal = Dados["CodPostal"];
                NovoUser.RoleName = "Utilizador";
                NovoUser.token = Funcionalidades.GenerateToken();
                NovoUser.isActive = true;
                NovoUser.dataCriacao = DateTime.Now;

                DB.Utilizadors.InsertOnSubmit(NovoUser);
                DB.SubmitChanges();

                Funcionalidades.SendEmail(Dados["Email"], NovoUser.username + " REGISTO EM PHOSYS", "Pode ativar a sua conta com a chave: " + NovoUser.token);

                return RedirectToAction("AtivarConta");
            }
            else
            {
                TempData["MsgError_CriarConta"] = "Erro ao criar um novo registo, verifique os dados!";
                return View();
            }

            
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult AtivarConta(FormCollection Dados)
        {
            //Por Token = null

            if (Dados["UserName"] == null || Dados["UserName"] == "")
                ModelState.AddModelError("UserName","É necessário um Username!");

            if (Dados["Codigo"] == null || Dados["Codigo"] == "")
                ModelState.AddModelError("Codigo", "É necessário um Codigo!");

            if (ModelState.IsValid)
            {
                if (DB.Utilizadors.Any(x => x.username == Dados["UserName"]))
                {
                    Utilizador NaoAtivo = DB.Utilizadors.Single(x => x.username == Dados["UserName"]);
                    if (NaoAtivo.token == Dados["Codigo"] && NaoAtivo != null)
                    {
                        NaoAtivo.token = null;
                        DB.SubmitChanges();
                        FormsAuthentication.SetAuthCookie(Dados["UserName"], false);
                        return RedirectToAction("ProvasRealizadas","Teste");
                    }
                    else
                    {
                        ViewBag.Erro = 1;
                        TempData["MsgError_AtivarConta"] = "Erro ao Ativar o novo registo, verifique os dados!";
                        return View();
                    }
                }
                else
                {
                    ViewBag.Erro = 1;
                    TempData["MsgError_AtivarConta"] = "Erro ao Ativar o novo registo, verifique os dados!";
                    return View();
                }
            }
            else
            {
                TempData["MsgError_AtivarConta"] = "Erro ao Ativar o novo registo, verifique os dados!";
                return View();
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection Dados)
        {
            if (Dados["UserName"] == null || Dados["UserName"] == "")
                ModelState.AddModelError("UserName", "Username inválido");

            if (Dados["Pass"] == null || Dados["Pass"] == "")
                ModelState.AddModelError("Pass", "Password inválida");

            if (ModelState.IsValid)
            {
                string Pass = Funcionalidades.CalculateMD5Hash(Dados["Pass"] + "IPC");

                if (!DB.Utilizadors.Any(x => x.username == Dados["UserName"] && x.palavra_chave == Pass))
                {
                    TempData["MsgErro"] = "Credênciais inválidas.";
                    return View();
                }
                else
                {
                    Utilizador user = DB.Utilizadors.Single(x => x.username == Dados["UserName"]);
                  
                    if (user.token != null)
                    {
                        return RedirectToAction("AtivarConta");
                    }
                    else
                    {
                        user.ultimoLogin = DateTime.Now;
                        DB.SubmitChanges();
                        
                        if(Dados["RememberMe"] != null)
                        {
                            FormsAuthentication.SetAuthCookie(Dados["UserName"], true);
                        }
                        else
                        {
                            FormsAuthentication.SetAuthCookie(Dados["UserName"], false);
                        }

                        return RedirectToAction("ProvasRealizadas", "Teste");

                    }


                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public PartialViewResult _Header()
        {
            return PartialView("_Header", DB.Utilizadors.Single(x => x.username == HttpContext.User.Identity.Name));
        }
    }
}