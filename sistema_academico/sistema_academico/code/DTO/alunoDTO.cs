using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class alunoDTO
    {
        private int id_aluno;

        public int Id_aluno
        {
            get { return id_aluno; }
            set { id_aluno = value; }
        }
        private string nome_aluno;

        public string Nome_aluno
        {
            get { return nome_aluno; }
            set { nome_aluno = value; }
        }
        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        private string logradouro;

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }
        private string numero;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string complemento;

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        private string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
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
        private DateTime data_nascimento;

        public DateTime Data_nascimento
        {
            get { return data_nascimento; }
            set { data_nascimento = value; }
        }
        private int responsavel_id;

        public int Responsavel_id
        {
            get { return responsavel_id; }
            set { responsavel_id = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private bool situacao;

        public bool Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

    }
}