using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;

namespace sistema_academico
{
    public partial class web_responsavel : System.Web.UI.Page
    {

        responsavelBLL bllResponsavel = new responsavelBLL();
        responsavelDTO dtoResponsavel = new responsavelDTO();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void limpar()
        {
            tx_nome_resp.Text = "";
            tx_nome_opcional.Text = "";
            tx_tel_opcional.Text = "";
            tx_tel_resp.Text = "";
            tx_cel_resp.Text = "";
        }

        protected void btn_gravar_resp_Click(object sender, EventArgs e)
        {
            dtoResponsavel.Nome_responsavel = tx_nome_resp.Text;
            dtoResponsavel.Tel_residencial = tx_tel_resp.Text;
            dtoResponsavel.Tel_celular = tx_cel_resp.Text;
            dtoResponsavel.Tel_opcional = tx_tel_opcional.Text;
            dtoResponsavel.Nome_opcional = tx_nome_opcional.Text;
            bllResponsavel.inseir(dtoResponsavel);
            limpar();
            Response.Redirect("web_aluno.aspx");
        }

    }
}