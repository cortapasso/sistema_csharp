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
    public partial class web_turma : System.Web.UI.Page
    {
        turmaBLL bllTurma = new turmaBLL();
        turmaDTO dtoTurma = new turmaDTO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack == false)
            {
                carregarturma();
            }

        }

        protected void btn_gravarturma_Click(object sender, EventArgs e)
        {
            dtoTurma.Sigla_turma = tx_turma.Text;
            dtoTurma.Periodo = tx_periodo.Text;
            dtoTurma.Modulo = int.Parse(ddl_modulo.SelectedValue);
            bllTurma.inserir(dtoTurma);
            limpar();

        }

        public void limpar()
        {
            tx_turma.Text = "";
            tx_periodo.Text = "";
            ddl_modulo.SelectedIndex = 1;
        }

        public void carregarturma()
        {
            ddl_modulo.DataSource = bllTurma.carregarmodulo();
            ddl_modulo.DataTextField = "modulo";
            ddl_modulo.DataValueField = "id_turma";
            ddl_modulo.DataBind();
        }
    }
}