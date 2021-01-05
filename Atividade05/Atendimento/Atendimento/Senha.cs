using System;
using System.Collections.Generic;
using System.Text;

namespace Atendimento
{
    class Senha
    {
        private int id;
        private DateTime dtGerac, hrGerac, dtAtend, hrAtend;

        public Senha(int id)
        {
            this.id = id;
            dataGerac = DateTime.Now;
            horaGerac = DateTime.Now;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DataGerac
        {
            get { return dtGerac; }
            set { dtGerac = value; }
        }

        public DateTime HoraGerac
        {
            get { return hrGerac; }
            set { hrGerac = value; }
        }

        public DateTime DataAtend
        {
            get { return dtAtend; }
            set { dtAtend = value; }
        }

        public DateTime HoraAtend
        {
            get { return hrAtend; }
            set { hrAtend = value; }
        }


        public string dadosParciais()
        {
            return Id + " - " + DataGerac;
        }

        public string dadosCompletos()
        {
            return Id + " - " + DataGerac + " - " + DataAtend;
        }
    }
}
