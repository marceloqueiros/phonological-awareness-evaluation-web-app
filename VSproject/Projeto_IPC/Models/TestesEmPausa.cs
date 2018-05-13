using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_IPC.Models
{
    public class TestesEmPausa
    {
        private string nomePaciente;
        private string nomeTutor;
        private DateTime dataComeco;
        private int idTeste;

        public string NomePaciente
        {
            get
            {
                return nomePaciente;
            }

            set
            {
                nomePaciente = value;
            }
        }

        public string NomeTutor
        {
            get
            {
                return nomeTutor;
            }

            set
            {
                nomeTutor = value;
            }
        }

        public DateTime DataComeco
        {
            get
            {
                return dataComeco;
            }

            set
            {
                dataComeco = value;
            }
        }

        public int IdTeste
        {
            get
            {
                return idTeste;
            }

            set
            {
                idTeste = value;
            }
        }
    }
}