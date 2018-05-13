using Projeto_IPC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto_IPC.Controllers
{

    [Authorize(Roles = "Utilizador")]
    public class TesteController : Controller
    {
        private static readonly Stopwatch SW = new Stopwatch();

        static int IDPaciente;
        DataClassesDBIPCDataContext DB = new DataClassesDBIPCDataContext();        

        public ActionResult ReComecar(int id)
        {
            Teste x = DB.Testes.Single(y => y.id_teste == id);

            IDPaciente = x.id_paciente;


            //No caso de pausa no teste CSI
            if (x.TesteCSI1 == null)
                return RedirectToAction("CSI");

            if (x.TesteCSI2 == null)
                return RedirectToAction("TesteCSI2");

            if (x.TesteCSI3 == null)
                return RedirectToAction("TesteCSI3");

            if (x.TesteCSI4 == null)
                return RedirectToAction("TesteCSI4");

            if (x.TesteCSI5 == null)
                return RedirectToAction("TesteCSI5");

            if (x.TesteCSI6 == null)
                return RedirectToAction("TesteCSI6");

            if (x.TesteCSI7 == null)
                return RedirectToAction("TesteCSI7");

            if (x.TesteCSI8 == null)
                return RedirectToAction("TesteCSI8");

            if (x.TesteCSI9 == null)
                return RedirectToAction("TesteCSI9");

            if (x.TesteCSI10 == null)
                return RedirectToAction("TesteCSI10");

            if (x.TesteCSI11 == null)
                return RedirectToAction("TesteCSI11");

            if (x.TesteCSI12 == null)
                return RedirectToAction("TesteCSI12");

            if (x.TesteCSI13 == null)
                return RedirectToAction("TesteCSI13");

            if (x.TesteCSI14 == null)
                return RedirectToAction("TesteCSI14");

            //No caso de pausa no teste CFI
            if (x.TesteCFI1 == null)
                return RedirectToAction("CFI");

            if (x.TesteCFI2 == null)
                return RedirectToAction("TesteCFI2");

            if (x.TesteCFI3 == null)
                return RedirectToAction("TesteCFI3");

            if (x.TesteCFI4 == null)
                return RedirectToAction("TesteCFI4");

            if (x.TesteCFI5 == null)
                return RedirectToAction("TesteCFI5");

            if (x.TesteCFI6 == null)
                return RedirectToAction("TesteCFI6");

            if (x.TesteCFI7 == null)
                return RedirectToAction("TesteCFI7");

            if (x.TesteCFI8 == null)
                return RedirectToAction("TesteCFI8");

            if (x.TesteCFI9 == null)
                return RedirectToAction("TesteCFI9");

            if (x.TesteCFI10 == null)
                return RedirectToAction("TesteCFI10");

            if (x.TesteCFI11 == null)
                return RedirectToAction("TesteCFI11");

            if (x.TesteCFI12 == null)
                return RedirectToAction("TesteCFI12");

            if (x.TesteCFI13 == null)
                return RedirectToAction("TesteCFI13");

            if (x.TesteCFI14 == null)
                return RedirectToAction("TesteCFI14");

            //No caso de pausa no teste SSI
            if (x.TesteSSI1 == null)
                return RedirectToAction("SSI");

            if (x.TesteSSI2 == null)
                return RedirectToAction("TesteSSI2");

            if (x.TesteSSI3 == null)
                return RedirectToAction("TesteSSI3");

            if (x.TesteSSI4 == null)
                return RedirectToAction("TesteSSI4");

            if (x.TesteSSI5 == null)
                return RedirectToAction("TesteSSI5");

            if (x.TesteSSI6 == null)
                return RedirectToAction("TesteSSI6");

            if (x.TesteSSI7 == null)
                return RedirectToAction("TesteSSI7");

            if (x.TesteSSI8 == null)
                return RedirectToAction("TesteSSI8");

            if (x.TesteSSI9 == null)
                return RedirectToAction("TesteSSI9");

            if (x.TesteSSI10 == null)
                return RedirectToAction("TesteSSI10");

            if (x.TesteSSI11 == null)
                return RedirectToAction("TesteSSI11");

            if (x.TesteSSI12 == null)
                return RedirectToAction("TesteSSI12");

            if (x.TesteSSI13 == null)
                return RedirectToAction("TesteSSI13");

            if (x.TesteSSI14 == null)
                return RedirectToAction("TesteSSI14");

            //No caso de pausa no teste SFI
            if (x.TesteSFI1 == null)
                return RedirectToAction("SFI");

            if (x.TesteSFI2 == null)
                return RedirectToAction("TesteSFI2");

            if (x.TesteSFI3 == null)
                return RedirectToAction("TesteSFI3");

            if (x.TesteSFI4 == null)
                return RedirectToAction("TesteSFI4");

            if (x.TesteSFI5 == null)
                return RedirectToAction("TesteSFI5");

            if (x.TesteSFI6 == null)
                return RedirectToAction("TesteSFI6");

            if (x.TesteSFI7 == null)
                return RedirectToAction("TesteSFI7");

            if (x.TesteSFI8 == null)
                return RedirectToAction("TesteSFI8");

            if (x.TesteSFI9 == null)
                return RedirectToAction("TesteSFI9");

            if (x.TesteSFI10 == null)
                return RedirectToAction("TesteSFI10");

            if (x.TesteSFI11 == null)
                return RedirectToAction("TesteSFI11");

            if (x.TesteSFI12 == null)
                return RedirectToAction("TesteSFI12");

            if (x.TesteSFI13 == null)
                return RedirectToAction("TesteSFI13");

            if (x.TesteSFI14 == null)
                return RedirectToAction("TesteSFI14");

            if (x.TesteSFI15 == null)
                return RedirectToAction("TesteSFI15");

            if (x.TesteSFI6 == null)
                return RedirectToAction("TesteSFI16");

            if (x.TesteSFI17 == null)
                return RedirectToAction("TesteSFI17");

            if (x.TesteSFI18 == null)
                return RedirectToAction("TesteSFI18");

            if (x.TesteSFI19 == null)
                return RedirectToAction("TesteSFI19");

            if (x.TesteSFI20 == null)
                return RedirectToAction("TesteSFI20");

            if (x.TesteSFI21 == null)
                return RedirectToAction("TesteSFI21");

            if (x.TesteSFI22 == null)
                return RedirectToAction("TesteSFI22");

            if (x.TesteSFI23 == null)
                return RedirectToAction("TesteSFI23");

            if (x.TesteSFI24 == null)
                return RedirectToAction("TesteSFI24");

            //No caso de pausa no teste AS
            if (x.TesteAS1 == null)
                return RedirectToAction("AS");

            if (x.TesteAS2 == null)
                return RedirectToAction("TesteAS2");

            if (x.TesteAS3 == null)
                return RedirectToAction("TesteAS3");

            if (x.TesteAS4 == null)
                return RedirectToAction("TesteAS4");

            if (x.TesteAS5 == null)
                return RedirectToAction("TesteAS5");

            if (x.TesteAS6 == null)
                return RedirectToAction("TesteAS6");

            if (x.TesteAS7 == null)
                return RedirectToAction("TesteAS7");

            if (x.TesteAS8 == null)
                return RedirectToAction("TesteAS8");

            if (x.TesteAS9 == null)
                return RedirectToAction("TesteAS9");

            if (x.TesteAS10 == null)
                return RedirectToAction("TesteAS10");

            if (x.TesteAS11 == null)
                return RedirectToAction("TesteAS11");

            if (x.TesteAS12 == null)
                return RedirectToAction("TesteAS12");

            if (x.TesteAS13 == null)
                return RedirectToAction("TesteAS13");

            if (x.TesteAS14 == null)
                return RedirectToAction("TesteAS14");

            //No caso de pausa no teste AF
            if (x.TesteAF1 == null)
                return RedirectToAction("AF");

            if (x.TesteAF2 == null)
                return RedirectToAction("TesteAF2");

            if (x.TesteAF3 == null)
                return RedirectToAction("TesteAF3");

            if (x.TesteAF4 == null)
                return RedirectToAction("TesteAF4");

            if (x.TesteAF5 == null)
                return RedirectToAction("TesteAF5");

            if (x.TesteAF6 == null)
                return RedirectToAction("TesteAF6");

            if (x.TesteAF7 == null)
                return RedirectToAction("TesteAF7");

            if (x.TesteAF8 == null)
                return RedirectToAction("TesteAF8");

            if (x.TesteAF9 == null)
                return RedirectToAction("TesteAF9");

            if (x.TesteAF10 == null)
                return RedirectToAction("TesteAF10");

            if (x.TesteAF11 == null)
                return RedirectToAction("TesteAF11");

            if (x.TesteAF12 == null)
                return RedirectToAction("TesteAF12");

            if (x.TesteAF13 == null)
                return RedirectToAction("TesteAF13");

            if (x.TesteAF14 == null)
                return RedirectToAction("TesteAF14");

            //Caso de erro volta para a mesma view
            return RedirectToAction("ProvasPausadas");

        }

        public ActionResult ComecoTeste(int id)
        {
            IDPaciente = id;

            Teste novo = new Teste();

            novo.id_paciente = IDPaciente;
            novo.dataCriacao = DateTime.Now;

            novo.id_user = GetCurrentUserId();

            DB.Testes.InsertOnSubmit(novo);
            DB.SubmitChanges();

            return View();
        }

        public ActionResult Detalhes(int id)
        {
            if (DB.Testes.Where(x => x.id_teste == id).Count() > 0)
                return View(DB.Testes.Single(x => x.id_teste == id));
            else
                return new HttpNotFoundResult();
        }

        [HttpGet]
        public ActionResult CSI()
        {            
            return View();
        }

        [HttpGet]
        public ActionResult ExemploCSI1()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult ExemploCSI1(FormCollection dados)
        {
            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if(nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {                             

                if (dados["val1"] != null && dados["val3"] != null)
                    return RedirectToAction("ExemploCSI2");
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }

            
        }

        [HttpGet]
        public ActionResult ExemploCSI2()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult ExemploCSI2(FormCollection dados)
        {
            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {

                if (dados["val1"] != null && dados["val4"] != null)
                    return RedirectToAction("TesteCSI1");
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult TesteCSI1()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCSI1(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val3"] != null)
                {
                    editar.TesteCSI1 = true;
                }
                else
                {
                    editar.TesteCSI1 = false;
                }
                
                editar.TempoCSI1 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();
                editar.TempoCSI1 = SW.ElapsedMilliseconds;
                          
                return RedirectToAction("TesteCSI2");
            }

            return RedirectToAction("TesteCSI1");
        }

        [HttpGet]
        public ActionResult TesteCSI2()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCSI2(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {                
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val3"] != null && dados["val4"] != null)
                {
                    editar.TesteCSI2 = true;
                }
                else
                {
                    editar.TesteCSI2 = false;
                }

                editar.TempoCSI2 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCSI3");
            }

            return RedirectToAction("TesteCSI2");
        }

        [HttpGet]
        public ActionResult TesteCSI3()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCSI3(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val4"] != null)
                {
                    editar.TesteCSI3 = true;
                }
                else
                {
                    editar.TesteCSI3 = false;
                }

                editar.TempoCSI3 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCSI4");
            }

            return RedirectToAction("TesteCSI3");
        }

        [HttpGet]
        public ActionResult TesteCSI4()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCSI4(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val2"] != null && dados["val4"] != null)
                {
                    editar.TesteCSI4 = true;
                }
                else
                {
                    editar.TesteCSI4 = false;
                }

                editar.TempoCSI4 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCSI5");
            }

            return RedirectToAction("TesteCSI4");
        }

        [HttpGet]
        public ActionResult TesteCSI5()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCSI5(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val2"] != null)
                {
                    editar.TesteCSI5 = true;
                }
                else
                {
                    editar.TesteCSI5 = false;
                }

                editar.TempoCSI5 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCSI6");
            }

            return RedirectToAction("TesteCSI5");
        }

        [HttpGet]
        public ActionResult TesteCSI6()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCSI6(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val2"] != null && dados["val4"] != null)
                {
                    editar.TesteCSI6 = true;
                }
                else
                {
                    editar.TesteCSI6 = false;
                }

                editar.TempoCSI6 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCSI7");
            }

            return RedirectToAction("TesteCSI6");
        }

        [HttpGet]
        public ActionResult TesteCSI7()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCSI7(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val4"] != null)
                {
                    editar.TesteCSI7 = true;
                }
                else
                {
                    editar.TesteCSI7 = false;
                }

                editar.TempoCSI7 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCSI8");
            }

            return RedirectToAction("TesteCSI7");
        }

        [HttpGet]
        public ActionResult TesteCSI8()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCSI8(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val2"] != null && dados["val3"] != null)
                {
                    editar.TesteCSI8 = true;
                }
                else
                {
                    editar.TesteCSI8 = false;
                }

                editar.TempoCSI8 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCSI9");
            }

            return RedirectToAction("TesteCSI8");
        }

        [HttpGet]
        public ActionResult TesteCSI9()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCSI9(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val3"] != null && dados["val4"] != null)
                {
                    editar.TesteCSI9 = true;
                }
                else
                {
                    editar.TesteCSI9 = false;
                }

                editar.TempoCSI9 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCSI10");
            }

            return RedirectToAction("TesteCSI9");
        }

        [HttpGet]
        public ActionResult TesteCSI10()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCSI10(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val2"] != null && dados["val4"] != null)
                {
                    editar.TesteCSI10 = true;
                }
                else
                {
                    editar.TesteCSI10 = false;
                }

                editar.TempoCSI10 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCSI11");
            }

            return RedirectToAction("TesteCSI10");
        }

        [HttpGet]
        public ActionResult TesteCSI11()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCSI11(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val4"] != null)
                {
                    editar.TesteCSI11 = true;
                }
                else
                {
                    editar.TesteCSI11 = false;
                }

                editar.TempoCSI11 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCSI12");
            }

            return RedirectToAction("TesteCSI11");
        }

        [HttpGet]
        public ActionResult TesteCSI12()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCSI12(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val2"] != null)
                {
                    editar.TesteCSI12 = true;
                }
                else
                {
                    editar.TesteCSI12 = false;
                }

                editar.TempoCSI12 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCSI13");
            }

            return RedirectToAction("TesteCSI12");
        }

        [HttpGet]
        public ActionResult TesteCSI13()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCSI13(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val3"] != null)
                {
                    editar.TesteCSI13 = true;
                }
                else
                {
                    editar.TesteCSI13 = false;
                }

                editar.TempoCSI13 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCSI14");
            }

            return RedirectToAction("TesteCSI13");
        }

        [HttpGet]
        public ActionResult TesteCSI14()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCSI14(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val2"] != null && dados["val3"] != null)
                {
                    editar.TesteCSI14 = true;
                }
                else
                {
                    editar.TesteCSI14 = false;
                }

                editar.TempoCSI14 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("CFI");
            }

            return RedirectToAction("TesteCSI14");
        }

        [HttpGet]
        public ActionResult CFI()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ExemploCFI1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExemploCFI1(FormCollection dados)
        {
            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {

                if (dados["val2"] != null && dados["val3"] != null)
                    return RedirectToAction("ExemploCFI2");
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }


        }

        [HttpGet]
        public ActionResult ExemploCFI2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExemploCFI2(FormCollection dados)
        {
            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {

                if (dados["val1"] != null && dados["val3"] != null)
                    return RedirectToAction("TesteCFI1");
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult TesteCFI1()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCFI1(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val3"] != null)
                {
                    editar.TesteCFI1 = true;
                }
                else
                {
                    editar.TesteCFI1 = false;
                }

                editar.TempoCFI1 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCFI2");
            }

            return RedirectToAction("TesteCFI1");
        }

        [HttpGet]
        public ActionResult TesteCFI2()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCFI2(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val2"] != null && dados["val3"] != null)
                {
                    editar.TesteCFI2 = true;
                }
                else
                {
                    editar.TesteCFI2 = false;
                }

                editar.TempoCFI2 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCFI3");
            }

            return RedirectToAction("TesteCFI2");
        }

        [HttpGet]
        public ActionResult TesteCFI3()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCFI3(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val2"] != null)
                {
                    editar.TesteCFI3 = true;
                }
                else
                {
                    editar.TesteCFI3 = false;
                }

                editar.TempoCFI3 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCFI4");
            }

            return RedirectToAction("TesteCFI3");
        }

        [HttpGet]
        public ActionResult TesteCFI4()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCFI4(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val4"] != null)
                {
                    editar.TesteCFI4 = true;
                }
                else
                {
                    editar.TesteCFI4 = false;
                }

                editar.TempoCFI4 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCFI5");
            }

            return RedirectToAction("TesteCFI4");
        }

        [HttpGet]
        public ActionResult TesteCFI5()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCFI5(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val2"] != null && dados["val4"] != null)
                {
                    editar.TesteCFI5 = true;
                }
                else
                {
                    editar.TesteCFI5 = false;
                }

                editar.TempoCFI5 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCFI6");
            }

            return RedirectToAction("TesteCFI5");
        }

        [HttpGet]
        public ActionResult TesteCFI6()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCFI6(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val3"] != null && dados["val4"] != null)
                {
                    editar.TesteCFI6 = true;
                }
                else
                {
                    editar.TesteCFI6 = false;
                }

                editar.TempoCFI6 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCFI7");
            }

            return RedirectToAction("TesteCFI6");
        }

        [HttpGet]
        public ActionResult TesteCFI7()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCFI7(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val2"] != null && dados["val3"] != null)
                {
                    editar.TesteCFI7 = true;
                }
                else
                {
                    editar.TesteCFI7 = false;
                }

                editar.TempoCFI7 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCFI8");
            }

            return RedirectToAction("TesteCFI7");
        }

        [HttpGet]
        public ActionResult TesteCFI8()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCFI8(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val4"] != null)
                {
                    editar.TesteCFI8 = true;
                }
                else
                {
                    editar.TesteCFI8 = false;
                }

                editar.TempoCFI8 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCFI9");
            }

            return RedirectToAction("TesteCFI8");
        }

        [HttpGet]
        public ActionResult TesteCFI9()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCFI9(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val2"] != null && dados["val4"] != null)
                {
                    editar.TesteCFI9 = true;
                }
                else
                {
                    editar.TesteCFI9 = false;
                }

                editar.TempoCFI9 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCFI10");
            }

            return RedirectToAction("TesteCFI9");
        }

        [HttpGet]
        public ActionResult TesteCFI10()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCFI10(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val2"] != null)
                {
                    editar.TesteCFI10 = true;
                }
                else
                {
                    editar.TesteCFI10 = false;
                }

                editar.TempoCFI10 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCFI11");
            }

            return RedirectToAction("TesteCFI10");
        }

        [HttpGet]
        public ActionResult TesteCFI11()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCFI11(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val2"] != null && dados["val4"] != null)
                {
                    editar.TesteCFI11 = true;
                }
                else
                {
                    editar.TesteCFI11 = false;
                }

                editar.TempoCFI11 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCFI12");
            }

            return RedirectToAction("TesteCFI11");
        }

        [HttpGet]
        public ActionResult TesteCFI12()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCFI12(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val4"] != null)
                {
                    editar.TesteCFI12 = true;
                }
                else
                {
                    editar.TesteCFI12 = false;
                }

                editar.TempoCFI12 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCFI13");
            }

            return RedirectToAction("TesteCFI12");
        }

        [HttpGet]
        public ActionResult TesteCFI13()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCFI13(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val2"] != null)
                {
                    editar.TesteCFI13 = true;
                }
                else
                {
                    editar.TesteCFI13 = false;
                }

                editar.TempoCFI13 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("TesteCFI14");
            }

            return RedirectToAction("TesteCFI13");
        }

        [HttpGet]
        public ActionResult TesteCFI14()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteCFI14(FormCollection dados)
        {
            SW.Stop();

            int nselecionadas = 0;
            if (dados["val1"] != null)
                nselecionadas++;
            if (dados["val2"] != null)
                nselecionadas++;
            if (dados["val3"] != null)
                nselecionadas++;
            if (dados["val4"] != null)
                nselecionadas++;

            if (nselecionadas == 0)
            {
                ModelState.AddModelError("Resposta", "Tem de selecionar 2 opções.");
                TempData["MsgErro"] = "Tem de selecionar 2 opções.";
            }

            if (nselecionadas == 1)
            {
                ModelState.AddModelError("Resposta", "Só foi selecionada uma opção.");
                TempData["MsgErro"] = "Só foi selecionada uma opção.";
            }

            if (nselecionadas > 2)
            {
                ModelState.AddModelError("Resposta", "Foram selecionadas mais de duas opções.");
                TempData["MsgErro"] = "Foram selecionadas mais de duas opções.";
            }

            if (ModelState.IsValid)
            {
                Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

                if (dados["val1"] != null && dados["val3"] != null)
                {
                    editar.TesteCFI14 = true;
                }
                else
                {
                    editar.TesteCFI14 = false;
                }

                editar.TempoCFI14 = SW.ElapsedMilliseconds; SW.Reset();
                DB.SubmitChanges();

                return RedirectToAction("SSI");
            }

            return RedirectToAction("TesteCFI14");
        }

        [HttpGet]
        public ActionResult SSI()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ExemploSSI1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExemploSSI1(FormCollection dados)
        {
            if(dados["AcertouSSI"] != null)
                return RedirectToAction("ExemploSSI2");
            else
                return View();

        }

        [HttpGet]
        public ActionResult ExemploSSI2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExemploSSI2(FormCollection dados)
        {
            if (dados["AcertouSSI"] != null)
                return RedirectToAction("TesteSSI1");
            else
                return View();

        }

        [HttpGet]
        public ActionResult TesteSSI1()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSSI1(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSSI1 = true;
            else
                editar.TesteSSI1 = false;

            editar.TempoSSI1 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSSI2");            

        }

        [HttpGet]
        public ActionResult TesteSSI2()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSSI2(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSSI2 = true;
            else
                editar.TesteSSI2 = false;

            editar.TempoSSI2 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSSI3");

        }

        [HttpGet]
        public ActionResult TesteSSI3()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSSI3(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSSI3 = true;
            else
                editar.TesteSSI3 = false;

            editar.TempoSSI3 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSSI4");

        }

        [HttpGet]
        public ActionResult TesteSSI4()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSSI4(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSSI4 = true;
            else
                editar.TesteSSI4 = false;

            editar.TempoSSI4 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSSI5");

        }

        [HttpGet]
        public ActionResult TesteSSI5()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSSI5(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSSI5 = true;
            else
                editar.TesteSSI5 = false;

            editar.TempoSSI5 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSSI6");

        }

        [HttpGet]
        public ActionResult TesteSSI6()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSSI6(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSSI6 = true;
            else
                editar.TesteSSI6 = false;

            editar.TempoSSI6 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSSI7");

        }

        [HttpGet]
        public ActionResult TesteSSI7()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSSI7(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSSI7 = true;
            else
                editar.TesteSSI7 = false;

            editar.TempoSSI7 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSSI8");

        }

        [HttpGet]
        public ActionResult TesteSSI8()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSSI8(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSSI8 = true;
            else
                editar.TesteSSI8 = false;

            editar.TempoSSI8 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSSI9");

        }

        [HttpGet]
        public ActionResult TesteSSI9()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSSI9(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSSI9 = true;
            else
                editar.TesteSSI9 = false;

            editar.TempoSSI9 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSSI10");

        }

        [HttpGet]
        public ActionResult TesteSSI10()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSSI10(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSSI10 = true;
            else
                editar.TesteSSI10 = false;

            editar.TempoSSI10 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSSI11");

        }

        [HttpGet]
        public ActionResult TesteSSI11()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSSI11(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSSI11 = true;
            else
                editar.TesteSSI11 = false;

            editar.TempoSSI11 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSSI12");

        }

        [HttpGet]
        public ActionResult TesteSSI12()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSSI12(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSSI12 = true;
            else
                editar.TesteSSI12 = false;

            editar.TempoSSI12 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSSI13");

        }

        [HttpGet]
        public ActionResult TesteSSI13()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSSI13(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSSI13 = true;
            else
                editar.TesteSSI13 = false;

            editar.TempoSSI13 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSSI14");

        }

        [HttpGet]
        public ActionResult TesteSSI14()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSSI14(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSSI14 = true;
            else
                editar.TesteSSI14 = false;

            editar.TempoSSI14 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("SFI");

        }

        [HttpGet]
        public ActionResult SFI()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ExemploSFI1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExemploSFI1(FormCollection dados)
        {
            if (dados["AcertouSSI"] != null)
                return RedirectToAction("ExemploSFI2");
            else
                return View();

        }

        [HttpGet]
        public ActionResult ExemploSFI2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExemploSFI2(FormCollection dados)
        {
            if (dados["AcertouSSI"] != null)
                return RedirectToAction("TesteSFI1");
            else
                return View();

        }

        [HttpGet]
        public ActionResult TesteSFI1()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI1(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI1 = true;
            else
                editar.TesteSFI1 = false;

            editar.TempoSFI1 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI2");

        }

        [HttpGet]
        public ActionResult TesteSFI2()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI2(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI2 = true;
            else
                editar.TesteSFI2 = false;

            editar.TempoSFI2 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI3");

        }

        [HttpGet]
        public ActionResult TesteSFI3()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI3(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI3 = true;
            else
                editar.TesteSFI3 = false;

            editar.TempoSFI3 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI4");

        }

        [HttpGet]
        public ActionResult TesteSFI4()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI4(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI4 = true;
            else
                editar.TesteSFI4 = false;

            editar.TempoSFI4 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI5");

        }

        [HttpGet]
        public ActionResult TesteSFI5()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI5(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI5 = true;
            else
                editar.TesteSFI5 = false;

            editar.TempoSFI5 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI6");

        }

        [HttpGet]
        public ActionResult TesteSFI6()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI6(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI6 = true;
            else
                editar.TesteSFI6 = false;

            editar.TempoSFI6 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI7");

        }

        [HttpGet]
        public ActionResult TesteSFI7()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI7(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI7 = true;
            else
                editar.TesteSFI7 = false;

            editar.TempoSFI7 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI8");

        }

        [HttpGet]
        public ActionResult TesteSFI8()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI8(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI8 = true;
            else
                editar.TesteSFI8 = false;

            editar.TempoSFI8 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI9");

        }

        [HttpGet]
        public ActionResult TesteSFI9()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI9(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI9 = true;
            else
                editar.TesteSFI9 = false;

            editar.TempoSFI9 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI10");

        }

        [HttpGet]
        public ActionResult TesteSFI10()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI10(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI10 = true;
            else
                editar.TesteSFI10 = false;

            editar.TempoSFI10 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI11");

        }

        [HttpGet]
        public ActionResult TesteSFI11()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI11(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI11 = true;
            else
                editar.TesteSFI11 = false;

            editar.TempoSFI11 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI12");

        }

        [HttpGet]
        public ActionResult TesteSFI12()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI12(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI12 = true;
            else
                editar.TesteSFI12 = false;

            editar.TempoSFI12 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI13");

        }

        [HttpGet]
        public ActionResult TesteSFI13()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI13(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI13 = true;
            else
                editar.TesteSFI13 = false;

            editar.TempoSFI13 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI14");

        }

        [HttpGet]
        public ActionResult TesteSFI14()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI14(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI14 = true;
            else
                editar.TesteSFI14 = false;

            editar.TempoSFI14 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI15");

        }

        [HttpGet]
        public ActionResult TesteSFI15()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI15(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI15 = true;
            else
                editar.TesteSFI15 = false;

            editar.TempoSFI15 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI16");

        }

        [HttpGet]
        public ActionResult TesteSFI16()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI16(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI16 = true;
            else
                editar.TesteSFI16 = false;

            editar.TempoSFI16 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI17");

        }

        [HttpGet]
        public ActionResult TesteSFI17()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI17(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI17 = true;
            else
                editar.TesteSFI17 = false;

            editar.TempoSFI17 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI18");

        }

        [HttpGet]
        public ActionResult TesteSFI18()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI18(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI18 = true;
            else
                editar.TesteSFI18 = false;

            editar.TempoSFI18 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI19");

        }

        [HttpGet]
        public ActionResult TesteSFI19()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI19(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI19 = true;
            else
                editar.TesteSFI19 = false;

            editar.TempoSFI19 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI20");

        }

        [HttpGet]
        public ActionResult TesteSFI20()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI20(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI20 = true;
            else
                editar.TesteSFI20 = false;

            editar.TempoSFI20 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI21");

        }

        [HttpGet]
        public ActionResult TesteSFI21()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI21(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI21 = true;
            else
                editar.TesteSFI21 = false;

            editar.TempoSFI21 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI22");

        }

        [HttpGet]
        public ActionResult TesteSFI22()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI22(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI22 = true;
            else
                editar.TesteSFI22 = false;

            editar.TempoSFI22 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI23");

        }

        [HttpGet]
        public ActionResult TesteSFI23()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI23(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI23 = true;
            else
                editar.TesteSFI23 = false;

            editar.TempoSFI23 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteSFI24");

        }

        [HttpGet]
        public ActionResult TesteSFI24()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteSFI24(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteSFI24 = true;
            else
                editar.TesteSFI24 = false;

            editar.TempoSFI24 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("AS");

        }

        [HttpGet]
        public ActionResult AS()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ExemploAS1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExemploAS1(FormCollection dados)
        {
            if (dados["AcertouSSI"] != null)
                return RedirectToAction("ExemploAS2");
            else
                return View();

        }

        [HttpGet]
        public ActionResult ExemploAS2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExemploAS2(FormCollection dados)
        {
            if (dados["AcertouSSI"] != null)
                return RedirectToAction("TesteAS1");
            else
                return View();

        }

        [HttpGet]
        public ActionResult TesteAS1()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAS1(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAS1 = true;
            else
                editar.TesteAS1 = false;

            editar.TempoAS1 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAS2");

        }

        [HttpGet]
        public ActionResult TesteAS2()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAS2(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAS2 = true;
            else
                editar.TesteAS2 = false;

            editar.TempoAS2 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAS3");

        }

        [HttpGet]
        public ActionResult TesteAS3()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAS3(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAS3 = true;
            else
                editar.TesteAS3 = false;

            editar.TempoAS3 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAS4");

        }

        [HttpGet]
        public ActionResult TesteAS4()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAS4(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAS4 = true;
            else
                editar.TesteAS4 = false;

            editar.TempoAS4 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAS5");

        }

        [HttpGet]
        public ActionResult TesteAS5()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAS5(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAS5 = true;
            else
                editar.TesteAS5 = false;

            editar.TempoAS5 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAS6");

        }

        [HttpGet]
        public ActionResult TesteAS6()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAS6(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAS6 = true;
            else
                editar.TesteAS6 = false;

            editar.TempoAS6 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAS7");

        }

        [HttpGet]
        public ActionResult TesteAS7()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAS7(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAS7 = true;
            else
                editar.TesteAS7 = false;

            editar.TempoAS7 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAS8");

        }

        [HttpGet]
        public ActionResult TesteAS8()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAS8(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAS8 = true;
            else
                editar.TesteAS8 = false;

            editar.TempoAS8 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAS9");

        }

        [HttpGet]
        public ActionResult TesteAS9()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAS9(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAS9 = true;
            else
                editar.TesteAS9 = false;

            editar.TempoAS9= SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAS10");

        }

        [HttpGet]
        public ActionResult TesteAS10()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAS10(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAS10 = true;
            else
                editar.TesteAS10 = false;

            editar.TempoAS10 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAS11");

        }

        [HttpGet]
        public ActionResult TesteAS11()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAS11(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAS11 = true;
            else
                editar.TesteAS11 = false;

            editar.TempoAS11 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAS12");

        }

        [HttpGet]
        public ActionResult TesteAS12()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAS12(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAS12 = true;
            else
                editar.TesteAS12 = false;

            editar.TempoAS12 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAS13");

        }

        [HttpGet]
        public ActionResult TesteAS13()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAS13(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAS13 = true;
            else
                editar.TesteAS13 = false;

            editar.TempoAS13 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAS14");

        }

        [HttpGet]
        public ActionResult TesteAS14()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAS14(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAS14 = true;
            else
                editar.TesteAS14 = false;

            editar.TempoAS14 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("AF");

        }

        [HttpGet]
        public ActionResult AF()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ExemploAF1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExemploAF1(FormCollection dados)
        {
            if (dados["AcertouSSI"] != null)
                return RedirectToAction("ExemploAF2");
            else
                return View();

        }

        [HttpGet]
        public ActionResult ExemploAF2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExemploAF2(FormCollection dados)
        {
            if (dados["AcertouSSI"] != null)
                return RedirectToAction("TesteAF1");
            else
                return View();

        }

        [HttpGet]
        public ActionResult TesteAF1()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAF1(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAF1 = true;
            else
                editar.TesteAF1 = false;

            editar.TempoAF1 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAF2");

        }

        [HttpGet]
        public ActionResult TesteAF2()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAF2(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAF2 = true;
            else
                editar.TesteAF2 = false;

            editar.TempoAF2 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAF3");

        }

        [HttpGet]
        public ActionResult TesteAF3()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAF3(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAF3 = true;
            else
                editar.TesteAF3 = false;

            editar.TempoAF3 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAF4");

        }

        [HttpGet]
        public ActionResult TesteAF4()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAF4(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAF4 = true;
            else
                editar.TesteAF4 = false;

            editar.TempoAF4 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAF5");

        }

        [HttpGet]
        public ActionResult TesteAF5()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAF5(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAF5 = true;
            else
                editar.TesteAF5 = false;

            editar.TempoAF5 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAF6");

        }

        [HttpGet]
        public ActionResult TesteAF6()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAF6(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAF6 = true;
            else
                editar.TesteAF6 = false;

            editar.TempoAF6 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAF7");

        }

        [HttpGet]
        public ActionResult TesteAF7()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAF7(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAF7 = true;
            else
                editar.TesteAF7 = false;

            editar.TempoAF7 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAF8");

        }

        [HttpGet]
        public ActionResult TesteAF8()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAF8(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAF8 = true;
            else
                editar.TesteAF8 = false;

            editar.TempoAF8 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAF9");

        }

        [HttpGet]
        public ActionResult TesteAF9()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAF9(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAF9 = true;
            else
                editar.TesteAF9 = false;

            editar.TempoAF9 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAF10");

        }

        [HttpGet]
        public ActionResult TesteAF10()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAF10(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAF10 = true;
            else
                editar.TesteAF10 = false;

            editar.TempoAF10 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAF11");

        }

        [HttpGet]
        public ActionResult TesteAF11()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAF11(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAF11 = true;
            else
                editar.TesteAF11 = false;

            editar.TempoAF11 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAF12");

        }

        [HttpGet]
        public ActionResult TesteAF12()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAF12(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAF12 = true;
            else
                editar.TesteAF12 = false;

            editar.TempoAF12 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAF13");

        }

        [HttpGet]
        public ActionResult TesteAF13()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAF13(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAF13 = true;
            else
                editar.TesteAF13 = false;

            editar.TempoAF13 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("TesteAF14");

        }

        [HttpGet]
        public ActionResult TesteAF14()
        {
            SW.Start();
            return View();
        }

        [HttpPost]
        public ActionResult TesteAF14(FormCollection dados)
        {
            SW.Stop();

            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            if (dados["AcertouSSI"] != null)
                editar.TesteAF14 = true;
            else
                editar.TesteAF14 = false;

            editar.TempoAF14 = SW.ElapsedMilliseconds; SW.Reset();
            DB.SubmitChanges();

            return RedirectToAction("Fim");

        }

        [HttpGet]
        public ActionResult Fim()
        {
            Teste editar = DB.Testes.Single(x => x.id_paciente == IDPaciente);

            editar.dataAcabado = DateTime.Now;

            editar.TempoTotal = editar.TempoSSI1 + editar.TempoSSI2 + editar.TempoSSI3 + editar.TempoSSI4 + editar.TempoSSI5 + editar.TempoSSI6 + editar.TempoSSI7 + editar.TempoSSI8 + editar.TempoSSI9 + editar.TempoSSI10 + editar.TempoSSI11 + editar.TempoSSI12 + editar.TempoSSI13 + editar.TempoSSI14 + editar.TempoSFI1 + editar.TempoSFI2 + editar.TempoSFI3 + editar.TempoSFI4 + editar.TempoSFI5 + editar.TempoSFI6 + editar.TempoSFI7 + editar.TempoSFI8 + editar.TempoSFI9 + editar.TempoSFI10 + editar.TempoSFI11 + editar.TempoSFI12 + editar.TempoSFI13 + editar.TempoSFI14 + editar.TempoSFI15 + editar.TempoSFI16 + editar.TempoSFI17 + editar.TempoSFI18 + editar.TempoSFI19 + editar.TempoSFI20 + editar.TempoSFI21 + editar.TempoSFI22 + editar.TempoSFI23 + editar.TempoSFI24 + editar.TempoCSI1 + editar.TempoCSI2 + editar.TempoCSI3 + editar.TempoCSI4 + editar.TempoCSI5 + editar.TempoCSI6 + editar.TempoCSI7 + editar.TempoCSI8 + editar.TempoCSI9 + editar.TempoCSI10 + editar.TempoCSI11 + editar.TempoCSI12 + editar.TempoCSI13 + editar.TempoCSI14 + editar.TempoCFI1 + editar.TempoCFI2 + editar.TempoCFI3 + editar.TempoCFI4 + editar.TempoCFI5 + editar.TempoCFI6 + editar.TempoCFI7 + editar.TempoCFI8 + editar.TempoCFI9 + editar.TempoCFI10 + editar.TempoCFI11 + editar.TempoCFI12 + editar.TempoCFI13 + editar.TempoCFI14 + editar.TempoAS1 + editar.TempoAS2 + editar.TempoAS3 + editar.TempoAS4 + editar.TempoAS5 + editar.TempoAS6 + editar.TempoAS7 + editar.TempoAS8 + editar.TempoAS9 + editar.TempoAS10 + editar.TempoAS11 + editar.TempoAS12 + editar.TempoAS13 + editar.TempoAS14 + editar.TempoAF1 + editar.TempoAF2 + editar.TempoAF3 + editar.TempoAF4 + editar.TempoAF5 + editar.TempoAF6 + editar.TempoAF7 + editar.TempoAF8 + editar.TempoAF9 + editar.TempoAF10 + editar.TempoAF11 + editar.TempoAF12 + editar.TempoAF13 + editar.TempoAF14;

            DB.SubmitChanges();

            return RedirectToAction("ProvasRealizadas");
        }

        [HttpGet]
        public ActionResult ProvasRealizadas()
        {
            List<TesteParaListar> ListaTestes = new List<TesteParaListar>();

            ListaTestes = CarregarProvas(ListaTestes);

            return View(ListaTestes);
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

        //Carregar todos os teste do Tecnico com certos parametros
        public List<TesteParaListar> CarregarProvas(List<TesteParaListar> CarregarEstaLista)
        {
            foreach(Teste Te in DB.Testes.Where(x=>x.id_user == GetCurrentUserId()))
            {
                
                
                if(Te.dataAcabado != null)
                {
                    TesteParaListar Aux = new TesteParaListar();

                    //Pontos para o teste CSI
                    if (Te.TesteCSI1 == true)
                        Aux.CSIPontos++;

                    if (Te.TesteCSI2 == true)
                        Aux.CSIPontos++;

                    if (Te.TesteCSI3 == true)
                        Aux.CSIPontos++;

                    if (Te.TesteCSI4 == true)
                        Aux.CSIPontos++;

                    if (Te.TesteCSI5 == true)
                        Aux.CSIPontos++;

                    if (Te.TesteCSI6 == true)
                        Aux.CSIPontos++;

                    if (Te.TesteCSI7 == true)
                        Aux.CSIPontos++;

                    if (Te.TesteCSI8 == true)
                        Aux.CSIPontos++;

                    if (Te.TesteCSI9 == true)
                        Aux.CSIPontos++;

                    if (Te.TesteCSI10 == true)
                        Aux.CSIPontos++;

                    if (Te.TesteCSI11 == true)
                        Aux.CSIPontos++;

                    if (Te.TesteCSI12 == true)
                        Aux.CSIPontos++;

                    if (Te.TesteCSI13 == true)
                        Aux.CSIPontos++;

                    if (Te.TesteCSI14 == true)
                        Aux.CSIPontos++;


                    //Pontos para o teste CFI
                    if (Te.TesteCFI1 == true)
                        Aux.CFIPontos++;

                    if (Te.TesteCFI2 == true)
                        Aux.CFIPontos++;

                    if (Te.TesteCFI3 == true)
                        Aux.CFIPontos++;

                    if (Te.TesteCFI4 == true)
                        Aux.CFIPontos++;

                    if (Te.TesteCFI5 == true)
                        Aux.CFIPontos++;

                    if (Te.TesteCFI6 == true)
                        Aux.CFIPontos++;

                    if (Te.TesteCFI7 == true)
                        Aux.CFIPontos++;

                    if (Te.TesteCFI8 == true)
                        Aux.CFIPontos++;

                    if (Te.TesteCFI9 == true)
                        Aux.CFIPontos++;

                    if (Te.TesteCFI10 == true)
                        Aux.CFIPontos++;

                    if (Te.TesteCFI11 == true)
                        Aux.CFIPontos++;

                    if (Te.TesteCFI12 == true)
                        Aux.CFIPontos++;

                    if (Te.TesteCFI13 == true)
                        Aux.CFIPontos++;

                    if (Te.TesteCFI14 == true)
                        Aux.CFIPontos++;


                    //Pontos para o teste SSI
                    if (Te.TesteSSI1 == true)
                        Aux.SSIPontos++;

                    if (Te.TesteSSI2 == true)
                        Aux.SSIPontos++;

                    if (Te.TesteSSI3 == true)
                        Aux.SSIPontos++;

                    if (Te.TesteSSI4 == true)
                        Aux.SSIPontos++;

                    if (Te.TesteSSI5 == true)
                        Aux.SSIPontos++;

                    if (Te.TesteSSI6 == true)
                        Aux.SSIPontos++;

                    if (Te.TesteSSI7 == true)
                        Aux.SSIPontos++;

                    if (Te.TesteSSI8 == true)
                        Aux.SSIPontos++;

                    if (Te.TesteSSI9 == true)
                        Aux.SSIPontos++;

                    if (Te.TesteSSI10 == true)
                        Aux.SSIPontos++;

                    if (Te.TesteSSI11 == true)
                        Aux.SSIPontos++;

                    if (Te.TesteSSI12 == true)
                        Aux.SSIPontos++;

                    if (Te.TesteSSI13 == true)
                        Aux.SSIPontos++;

                    if (Te.TesteSSI14 == true)
                        Aux.SSIPontos++;


                    //Pontos para o teste SFI
                    if (Te.TesteSFI1 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI2 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI3 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI4 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI5 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI6 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI7 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI8 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI9 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI10 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI11 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI12 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI13 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI14 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI15 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI16 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI17 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI18 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI19 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI20 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI21 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI22 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI23 == true)
                        Aux.SFIPontos++;

                    if (Te.TesteSFI24 == true)
                        Aux.SFIPontos++;

                    //Pontos para o teste AS
                    if (Te.TesteAS1 == true)
                        Aux.ASPontos++;

                    if (Te.TesteAS2 == true)
                        Aux.ASPontos++;

                    if (Te.TesteAS3 == true)
                        Aux.ASPontos++;

                    if (Te.TesteAS4 == true)
                        Aux.ASPontos++;

                    if (Te.TesteAS5 == true)
                        Aux.ASPontos++;

                    if (Te.TesteAS6 == true)
                        Aux.ASPontos++;

                    if (Te.TesteAS7 == true)
                        Aux.ASPontos++;

                    if (Te.TesteAS8 == true)
                        Aux.ASPontos++;

                    if (Te.TesteAS9 == true)
                        Aux.ASPontos++;

                    if (Te.TesteAS10 == true)
                        Aux.ASPontos++;

                    if (Te.TesteAS11 == true)
                        Aux.ASPontos++;

                    if (Te.TesteAS12 == true)
                        Aux.ASPontos++;

                    if (Te.TesteAS13 == true)
                        Aux.ASPontos++;

                    if (Te.TesteAS14 == true)
                        Aux.ASPontos++;

                    //Pontos para o teste AF
                    if (Te.TesteAF1 == true)
                        Aux.AFPontos++;

                    if (Te.TesteAF2 == true)
                        Aux.AFPontos++;

                    if (Te.TesteAF3 == true)
                        Aux.AFPontos++;

                    if (Te.TesteAF4 == true)
                        Aux.AFPontos++;

                    if (Te.TesteAF5 == true)
                        Aux.AFPontos++;

                    if (Te.TesteAF6 == true)
                        Aux.AFPontos++;

                    if (Te.TesteAF7 == true)
                        Aux.AFPontos++;

                    if (Te.TesteAF8 == true)
                        Aux.AFPontos++;

                    if (Te.TesteAF9 == true)
                        Aux.AFPontos++;

                    if (Te.TesteAF10 == true)
                        Aux.AFPontos++;

                    if (Te.TesteAF11 == true)
                        Aux.AFPontos++;

                    if (Te.TesteAF12 == true)
                        Aux.AFPontos++;

                    if (Te.TesteAF13 == true)
                        Aux.AFPontos++;

                    if (Te.TesteAF14 == true)
                        Aux.AFPontos++;


                    //Total de Pontos
                    Aux.Total = Aux.CSIPontos + Aux.CFIPontos + Aux.SSIPontos + Aux.SFIPontos + Aux.ASPontos + Aux.AFPontos;

                    //Nome do Paciente
                    Paciente w = DB.Pacientes.Single(x => x.id_paciente == Te.id_paciente);

                    Aux.NomePaciente = w.nome;
                    Aux.Id = Te.id_teste;

                    //Duraçao 
                    if (Te.TempoTotal != null)
                    {
                        float min = (float)(Te.TempoTotal / 1000) / 60;

                        float seg = (float)(min - Math.Truncate(min));

                        string auxSeg = Math.Round(seg, 2).ToString();
                        string[] parts = auxSeg.Split(',');

                        int auxS = Convert.ToInt16(parts[1]);

                        if (auxS >= 60)
                        {
                            min = min + 1;
                            parts[1] = (auxS - 60).ToString();
                        }


                        Aux.TotalTempo = Math.Truncate(min).ToString() + " min " + parts[1] + " seg";
                    }

                    CarregarEstaLista.Add(Aux);
                }              
               
            }

            return CarregarEstaLista;
        }

        [HttpGet]
        public ActionResult ProvasPausadas()
        {
            List<TestesEmPausa> TestesEmPausa = new List<TestesEmPausa>();

            TestesEmPausa = CarregarProvasPausadas(TestesEmPausa);

            return View(TestesEmPausa);
        }

        //Carregar todos os teste do Tecnico em pausa
        public List<TestesEmPausa> CarregarProvasPausadas(List<TestesEmPausa> CarregarEstaLista)
        {
            foreach (Teste Te in DB.Testes.Where(x => x.id_user == GetCurrentUserId()))
            {
                if (Te.dataAcabado == null)
                {
                    TestesEmPausa Aux = new TestesEmPausa();
                    Aux.IdTeste = Te.id_teste;
                    Aux.DataComeco = Te.dataCriacao;

                    //Nome do Paciente e do Tutor
                    Paciente w = DB.Pacientes.Single(x => x.id_paciente == Te.id_paciente);

                    Aux.NomePaciente = w.nome;
                    Aux.NomeTutor = w.nomeTutor;

                    CarregarEstaLista.Add(Aux);

                }

            }

            return CarregarEstaLista;
        }

    }
}