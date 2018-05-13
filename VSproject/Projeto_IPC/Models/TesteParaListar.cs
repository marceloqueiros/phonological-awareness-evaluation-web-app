using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_IPC.Models
{
    public class TesteParaListar
    {
        private string nomePaciente;
        private int idTeste;
        private int cSIPontos = 0;
        private int cFIPontos = 0;
        private int sSIPontos = 0;
        private int sFIPontos = 0;
        private int aSPontos = 0;
        private int aFPontos = 0;
        private int total = 0;
        private string totalTempo;

        public TesteParaListar()
        {

        }

        public string NomePaciente
        {
            get { return nomePaciente; }
            set { nomePaciente = value; }
        }

        public int Id
        {
            get { return idTeste; }
            set { idTeste = value; }
        }

        public int CSIPontos
        {
            get { return cSIPontos; }
            set { cSIPontos = value; }
        }

        public int CFIPontos
        {
            get { return cFIPontos; }
            set { cFIPontos = value; }
        }

        public int SSIPontos
        {
            get { return sSIPontos; }
            set { sSIPontos = value; }
        }

        public int SFIPontos
        {
            get { return sFIPontos; }
            set { sFIPontos = value; }
        }

        public int ASPontos
        {
            get { return aSPontos; }
            set { aSPontos = value; }
        }

        public int AFPontos
        {
            get { return aFPontos; }
            set { aFPontos = value; }
        }

        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        public string TotalTempo
        {
            get
            {
                return totalTempo;
            }

            set
            {
                totalTempo = value;
            }
        }
    }
}