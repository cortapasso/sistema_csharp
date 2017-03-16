using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class responsavelDTO
    {
        private int id_responsavel;

        public int Id_responsavel
        {
            get { return id_responsavel; }
            set { id_responsavel = value; }
        }
        private string nome_responsavel;

        public string Nome_responsavel
        {
            get { return nome_responsavel; }
            set { nome_responsavel = value; }
        }
        private string tel_residencial;

        public string Tel_residencial
        {
            get { return tel_residencial; }
            set { tel_residencial = value; }
        }
        private string tel_celular;

        public string Tel_celular
        {
            get { return tel_celular; }
            set { tel_celular = value; }
        }
        private string tel_opcional;

        public string Tel_opcional
        {
            get { return tel_opcional; }
            set { tel_opcional = value; }
        }
        private string nome_opcional;

        public string Nome_opcional
        {
            get { return nome_opcional; }
            set { nome_opcional = value; }
        }

    }
}