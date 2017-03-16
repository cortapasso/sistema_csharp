using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class turmaBLL
    {
        AcessoBancoDados bd = new AcessoBancoDados();

        public void inserir(turmaDTO dto)
        {
            bd.Conectar();
            string comando = "INSERT INTO tb_turma(sigla_turma, periodo, modulo)"+
                "VALUES ('" + dto.Sigla_turma + "','" + dto.Periodo + "','" + dto.Modulo + "')";
            bd.ExecutarComandoSQL(comando);
        }

        public DataTable carregarmodulo()
        {
            bd.Conectar();
            DataTable data = new DataTable();
            data = bd.RetDataTable("SELECT * FROM tb_turma" +
                "order by id_turma desc");
            return data;
        }
    }
}