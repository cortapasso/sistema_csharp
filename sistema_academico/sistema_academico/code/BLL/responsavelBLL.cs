using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class responsavelBLL
    {
        AcessoBancoDados bd = new AcessoBancoDados();

        public void inseir(responsavelDTO dto)
        {
            bd.Conectar();
            string comando = "INSERT INTO tb_responsavel(nome_responsavel," +
                "tel_residencial, tel_celular, tel_opcional, nome_opcional)"+
                " VALUES ('"+dto.Nome_responsavel+"','"+dto.Tel_residencial+"','"+dto.Tel_celular+"','"+dto.Tel_opcional+"','"+dto.Nome_opcional+"')";
            bd.ExecutarComandoSQL(comando);
        }

        public DataTable carregarresponsavel()
        {
           bd.Conectar();
            DataTable data = new DataTable();
            data = bd.RetDataTable("SELECT * FROM tb_responsavel" +
                "order by id_responsavel desc");
            return data;
        }
    }
}