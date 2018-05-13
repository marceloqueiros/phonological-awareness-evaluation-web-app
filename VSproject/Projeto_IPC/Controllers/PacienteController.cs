using Projeto_IPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto_IPC.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente      
        DataClassesDBIPCDataContext DB = new DataClassesDBIPCDataContext();

        [HttpGet]
        public ActionResult NovoPaciente()
        {
            return View();
        }

        public ActionResult ListaPacientes()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NovoPaciente(FormCollection Dados)
        {
            if (Dados["nome"] == null || Dados["nome"] == "")
                ModelState.AddModelError("nome", "Nome inválido");

            if (Dados["nomeTutor"] == null || Dados["nomeTutor"] == "")
                ModelState.AddModelError("nomeTutor", "Nome do Tutor inválido");

            if (Dados["telefone"] == null || Dados["telefone"] == "")
                ModelState.AddModelError("telefone", "Telefone inválido");

            if (Dados["email"] == null || Dados["email"] == "")
                ModelState.AddModelError("email", "Email inválido");

            try
            {

                if (Convert.ToDateTime(Dados["datanascimento"]) > DateTime.Now)
                    ModelState.AddModelError("datanascimento", "A data tem de ser inferior à data atual.");
            }
            catch
            {
                ModelState.AddModelError("datanascimento", "Tem de inserir uma Data!");
            }

            if (ModelState.IsValid)
            {
                Paciente NovoP = new Paciente();

                NovoP.id_user = GetCurrentUserId();
                NovoP.nome = Dados["nome"];
                NovoP.nomeTutor = Dados["nomeTutor"];
                NovoP.telefone = Dados["telefone"];
                NovoP.email = Dados["email"];
                NovoP.data_de_nascimento = Convert.ToDateTime(Dados["datanascimento"]);

                DB.Pacientes.InsertOnSubmit(NovoP);
                DB.SubmitChanges();

                return RedirectToAction("ComecoTeste", "Teste", new { id = NovoP.id_paciente });
            }
            else
            {
                return View();
            }
            
        }

        //Username do user
        public string GetCurrentUserName()
        {
            if (System.Web.HttpContext.Current != null &&
                System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                return HttpContext.User.Identity.Name;
            }
            else
            {
                return null;
            }
        }

        //Id do user
        public int GetCurrentUserId()
        {
            if (System.Web.HttpContext.Current != null &&
                System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                Utilizador userNow = DB.Utilizadors.Single(x => x.username == GetCurrentUserName());
                return userNow.id_user;
            }
            else
            {
                return 0;
            }
        }

    }
}