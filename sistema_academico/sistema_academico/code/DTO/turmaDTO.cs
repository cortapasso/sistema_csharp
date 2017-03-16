using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class turmaDTO
    {
        private int id_curso;

        public int Id_curso
        {
            get { return id_curso; }
            set { id_curso = value; }
        }
        private string sigla_turma;

        public string Sigla_turma
        {
            get { return sigla_turma; }
            set { sigla_turma = value; }
        }
        private string periodo;

        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }
        private int modulo;

        public int Modulo
        {
            get { return modulo; }
            set { modulo = value; }
        }
    }
}