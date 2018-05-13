using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;

namespace Projeto_IPC.Models
{
    public static class Funcionalidades
    {
        //Enviar Email
        public static bool SendEmail(string email, string subjectaux, string bodyaux)
        {
            try
            {
                MailMessage TheEMAIL = new MailMessage("teamphosys@gmail.com", email, subjectaux, bodyaux);
                NetworkCredential netCred = new NetworkCredential("teamphosys@gmail.com", "IPC2017LEI");
                SmtpClient smtpobj = new SmtpClient("smtp.gmail.com", 587);
                smtpobj.EnableSsl = true;
                smtpobj.Credentials = netCred;
                smtpobj.Send(TheEMAIL);

                return true;
            }
            catch
            {
                return false;
            }
        }

        //Gerar uma palavra aleatória para ativação
        public static string GenerateToken()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //Calcular Hash
        public static string CalculateMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString());
            }

            return sb.ToString();
        }

        //Verificar se está ativo
        public static string IsActive(this HtmlHelper html, string control, string action)
        {
            var routeData = html.ViewContext.RouteData;

            var routeAction = (string)routeData.Values["action"];
            var routeControl = (string)routeData.Values["controller"];

            // both must match
            var returnActive = control == routeControl &&
                               action == routeAction;

            return returnActive ? "active" : "";
        }

        public static string IsActiveAdmin(this HtmlHelper html,
                                string control,
                                string action)
        {
            var routeData = html.ViewContext.ParentActionViewContext.RouteData;

            var routeAction = (string)routeData.Values["action"];
            var routeControl = (string)routeData.Values["controller"];

            // both must match
            var returnActive = control.ToUpper() == routeControl.ToUpper() &&
                               action.ToUpper() == routeAction.ToUpper();

            return returnActive ? "active" : "";
        }
    }
}