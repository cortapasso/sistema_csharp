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
    public partial class web_aluno : System.Web.UI.Page
    {
        alunoDTO dtoaluno = new alunoDTO();
        alunoBLL bllaluno = new alunoBLL();
        responsavelBLL bllresponsavel = new responsavelBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack == false)
            {
                carregarCombo();
            }
        }

        protected void bt_gravar_Click(object sender, EventArgs e)
        {
            dtoaluno.Nome_aluno = tx_nome.Text;
            dtoaluno.Cep = tx_cep.Text;
            dtoaluno.Logradouro = tx_logradouro.Text;
            dtoaluno.Numero = tx_numero.Text;
            dtoaluno.Complemento = tx_complemento.Text;
            dtoaluno.Bairro = tx_bairro.Text;
            dtoaluno.Cidade = tx_cidade.Text;
            dtoaluno.Estado = tx_estado.Text;
            dtoaluno.Rg = tx_rg.Text;
            dtoaluno.Cpf = tx_cpf.Text;
            dtoaluno.Tel_residencial = tx_telefone.Text;
            dtoaluno.Tel_celular = tx_celular.Text;
            dtoaluno.Data_nascimento = DateTime.Parse(tx_dt_nascimento.Text);
            dtoaluno.Responsavel_id = int.Parse(ddl_responsavel.SelectedValue);
            dtoaluno.Email = tx_email.Text;
            dtoaluno.Situacao = bool.Parse(ddl_situacao.SelectedValue);
            bllaluno.inserir(dtoaluno);
            limpar();

        }

        public void limpar()
        {
            tx_nome.Text = "";
            tx_cep.Text = "";
            tx_logradouro.Text = "";
            tx_numero.Text = "";
            tx_complemento.Text = "";
            tx_bairro.Text = "";
            tx_cidade.Text = "";
            tx_estado.Text = "";
            tx_rg.Text = "";
            tx_cpf.Text = "";
            tx_telefone.Text = "";
            tx_celular.Text = "";
            tx_dt_nascimento.Text = "";
            ddl_responsavel.SelectedIndex = 1;
            tx_email.Text = "";
            ddl_situacao.SelectedIndex = 1;
        }

        public void carregarCombo()
        {
            ddl_responsavel.DataSource = bllresponsavel.carregarresponsavel();
            ddl_responsavel.DataTextField = "nome_responsavel";
            ddl_responsavel.DataValueField = "id_responsavel";
            ddl_responsavel.DataBind();
        }
    }
}