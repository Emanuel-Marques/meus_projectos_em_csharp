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
    public partial class Frm_GestaoUsuarios : Form
    {
        string id;
        public Frm_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            string sql = String.Format(@"
                                            SELECT
                                                    tbu.N_IDUSUARIO as 'Id',
                                                    tbu.T_USERNAME as 'Username',
                                                    tbu.T_SENHA as 'Senha',
                                                    tbu.N_NIVEL as 'Nível',
                                              CASE
                                                  WHEN tbu.T_STATUS = 'A' THEN 'Activa'
                                                  WHEN tbu.T_STATUS = 'B' THEN 'Bloqueado' 
                                                  WHEN tbu.T_STATUS = 'I' THEN 'Inativo' 
                                              END as 'Status',
                                                    tbf.T_NOMEFUNCIONARIO as 'Nome do Funcionário'
                                            FROM 
                                                    tb_usuarios as 'tbu'
                                            INNER JOIN
                                                    tb_funcionario as 'tbf' on tbf.N_IDFUNCIONARIO = tbu.N_IDFUNCIONARIO
            ");
            Dgv_usuarios.DataSource = Banco.dql(sql);
            Dgv_usuarios.Columns[0].Width = 20;
            Dgv_usuarios.Columns[1].Width = 180;
            Dgv_usuarios.Columns[2].Width = 100;
            Dgv_usuarios.Columns[3].Width = 50;
            Dgv_usuarios.Columns[4].Width = 100;
            Dgv_usuarios.Columns[5].Width = 300;

            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A","Activo");
            st.Add("B","Bloqueado");
            st.Add("I","Inativo");

            Cb_status.Items.Clear();
            Cb_status.DataSource = new BindingSource(st,null);
            Cb_status.DisplayMember = "Value";
            Cb_status.ValueMember = "Key";

            sql = String.Format(@"
                                    SELECT 
                                            *
                                    FROM
                                            tb_funcionario
            ");
            Cb_funcionarios.DataSource = Banco.dql(sql);
            Cb_funcionarios.DisplayMember = "T_NOMEFUNCIONARIO";
            Cb_funcionarios.ValueMember = "N_IDFUNCIONARIO";
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            Frm_CadUsuario frm_CadUsuario = new Frm_CadUsuario();
            frm_CadUsuario.Show();
            this.Close();
        }

        private void Dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView) sender;

            if (dgv.SelectedRows.Count > 0)
            {
                _ = new DataTable();

                id = dgv.SelectedRows[0].Cells[0].Value.ToString();

                string sql = String.Format(@"
                                              SELECT 
                                                        *
                                              FROM
                                                        tb_usuarios
                                              WHERE
                                                        N_IDUSUARIO = {0}
                ",id);
                DataTable dt = Banco.dql(sql);
                Txt_id.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                Txt_username.Text = dt.Rows[0].Field<string>("T_USERNAME");
                Txt_senha.Text = dt.Rows[0].Field<string>("T_SENHA");
                Nud_nivel.Value = dt.Rows[0].Field<Int64>("N_NIVEL");
                Cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                Cb_funcionarios.SelectedValue = dt.Rows[0].Field<Int64>("N_IDFUNCIONARIO");

            }
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            string query = String.Format(@"
                            SELECT 
                                    *
                            FROM
                                    tb_usuarios
                            WHERE
                                    N_IDFUNCIONARIO = {0}
            ",Cb_funcionarios.SelectedValue);
            DataTable VerificaFuncionario = new DataTable();
            VerificaFuncionario= Banco.dql(query);
            if (VerificaFuncionario.Rows.Count > 0)
            {
                string nome = Dgv_usuarios.SelectedRows[0].Cells[5].Value.ToString();
                MessageBox.Show("Passou: "+nome);
                if (Cb_funcionarios.Text.ToString() != nome)
                {
                    MessageBox.Show("Este funcionário já possuí conta associada!");
                    return;
                }
              
            }
            String sql = String.Format(@"
                                            UPDATE 
                                                    tb_usuarios
                                            SET
                                                    T_USERNAME = '{0}',
                                                    T_SENHA = '{1}',
                                                    N_NIVEL = {2},
                                                    T_STATUS = '{3}',
                                                    N_IDFUNCIONARIO = {4}
                                            WHERE
                                                    N_IDUSUARIO = {5}
            ",Txt_username.Text,Txt_senha.Text,Nud_nivel.Value,Cb_status.SelectedValue,Cb_funcionarios.SelectedValue,Txt_id.Text);

            Banco.dml(sql);
            MessageBox.Show("Dados actualizados.");

            string sqlActualizar = String.Format(@"
                                            SELECT
                                                    tbu.N_IDUSUARIO as 'Id',
                                                    tbu.T_USERNAME as 'Username',
                                                    tbu.T_SENHA as 'Senha',
                                                    tbu.N_NIVEL as 'Nível',
                                              CASE
                                                  WHEN tbu.T_STATUS = 'A' THEN 'Activa'
                                                  WHEN tbu.T_STATUS = 'B' THEN 'Bloqueado' 
                                                  WHEN tbu.T_STATUS = 'I' THEN 'Inativo' 
                                              END as 'Status',
                                                    tbf.T_NOMEFUNCIONARIO as 'Nome do Funcionário'
                                            FROM 
                                                    tb_usuarios as 'tbu'
                                            INNER JOIN
                                                    tb_funcionario as 'tbf' on tbf.N_IDFUNCIONARIO = tbu.N_IDFUNCIONARIO
            ");
            Dgv_usuarios.DataSource = Banco.dql(sqlActualizar);
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir usuário ?","Confirmar",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = String.Format(@"
                                        DELETE FROM
                                                    tb_usuarios
                                        WHERE
                                                     N_IDUSUARIO = {0}
                ",Txt_id.Text);
                Banco.dml(sql);
                Dgv_usuarios.Rows.Remove(Dgv_usuarios.CurrentRow);
            }
        }
    }
}
