using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class alunoBLL
    {
        AcessoBancoDados bd = new AcessoBancoDados();

        //metodo para inserir
        public void inserir(alunoDTO dto)
        {
            bd.Conectar();
            string comando = "INSERT INTO tb_aluno" +
                "(nome_aluno,cep,logradouro,numero,complemento," +
                "bairro,cidade,estado,rg,cpf,tel_residencial,tel_celular" +
                "data_nascimento,responsavel_id,email,situacao) VALUES ('" + dto.Nome_aluno +
                "','" + dto.Cep + "','" + dto.Logradouro + "','" + dto.Numero + "','" + dto.Complemento + "','" + dto.Bairro +
                "','" + dto.Cidade + "','" + dto.Estado + "','" + dto.Rg + "','" + dto.Cpf + "','" + dto.Tel_residencial + "','" +
                dto.Tel_celular + "','" + dto.Data_nascimento + "'," + dto.Responsavel_id + ",'" + dto.Email + "','" + dto.Situacao + "')";
            bd.ExecutarComandoSQL(comando);
        }
    }
}