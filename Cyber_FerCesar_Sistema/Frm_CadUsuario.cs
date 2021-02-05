using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyber_FerCesar_Sistema
{
    public partial class Frm_CadUsuario : Form
    {
        public Frm_CadUsuario()
        {
            InitializeComponent();
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            Cb_nome.Enabled = true;
            Cb_nivel.Enabled = true;
            Cb_status.Enabled = true;
            Txt_senha.Enabled = true;
            Txt_senha2.Enabled = true;
            Txt_username.Enabled = true;
            Btn_novo.Enabled = false;
            Btn_salvar.Enabled = true;

            Txt_username.Focus();

        }

        private void Frm_CadUsuario_Load(object sender, EventArgs e)
        {
            /*string query = String.Format(@"
                    SELECT 
                        tbu.N_IDUSUARIO,
                        tbu.T_USERNAME,
                        tbu.T_SENHA,
                        tbu.N_NIVEL,
                        tbu.T_STATUS,
                        tbf.T_NOMEFUNCIONARIO
                    FROM
                        tb_usuarios as tbu
                    INNER JOIN
                    tb_funcionario as tbf on tbf.N_IDFUNCIONARIO = tbu.N_IDFUNCIONARIO
            
            ");*/
            string query = String.Format(@"
                            SELECT 
                                  N_IDFUNCIONARIO,
                                  T_NOMEFUNCIONARIO
                            FROM
                                  tb_funcionario
            ");

            Cb_nome.Items.Clear();
            Cb_nome.DataSource = Banco.dql(query);
            Cb_nome.DisplayMember = "T_NOMEFUNCIONARIO";
            Cb_nome.ValueMember = "N_IDFUNCIONARIO";


        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {

            Cb_nome.Enabled = true;
            Cb_nivel.Enabled = true;
            Cb_status.Enabled = true;
            Txt_senha.Enabled = true;
            Txt_senha2.Enabled = true;
            Txt_username.Enabled = true;
            Btn_novo.Enabled = false;
            Btn_salvar.Enabled = true;
        }
    }
}
