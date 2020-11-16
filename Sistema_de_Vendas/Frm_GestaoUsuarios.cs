using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas
{
    public partial class Frm_GestaoUsuarios : Form
    {
        string idSelecionado = "";
        public Frm_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void Frm_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            string queryUsuarios = String.Format(@"
                    SELECT 
                         tbu.N_IDUSUARIO as 'Id',
                         tbu.T_USERNAME as 'Username',
                         tbu.T_SENHA as 'Senha',
                         tbu.N_NIVEL as 'Nível',
                         tbf.T_NOMEFUNCIONARIO as 'Nome do Funcionário'
                    FROM
                        tb_usuarios as tbu
                    INNER JOIN 
                        tb_funcionarios as tbf on tbf.N_IDFUNCIONARIO = tbu.N_IDFUNCIONARIO
                    ORDER BY 
                        tbf.T_NOMEFUNCIONARIO
            ");
            string queryFuncionarios = String.Format(@"
                    SELECT 
                         tbu.N_IDUSUARIO,
                         tbu.T_USERNAME,
                         tbu.T_SENHA,
                         tbu.N_NIVEL,
                         tbf.T_NOMEFUNCIONARIO,
                         tbf.N_IDFUNCIONARIO
                    FROM
                        tb_usuarios as tbu
                    INNER JOIN 
                        tb_funcionarios as tbf on tbf.N_IDFUNCIONARIO = tbu.N_IDFUNCIONARIO
                    ORDER BY 
                        tbf.T_NOMEFUNCIONARIO
            ");
            DataTable dt = new DataTable();
            dt = Banco.dql(queryFuncionarios);
            Dictionary<int, string> funcionario = new Dictionary<int, string>();
         
            for (int i=0;i<dt.Rows.Count;i++)
            {
                funcionario.Add(int.Parse(dt.Rows[i].Field<Int64>("N_IDFUNCIONARIO").ToString()), dt.Rows[i].Field<string>("T_NOMEFUNCIONARIO"));
               
            }
            
            cb_funcionario.DataSource = new BindingSource(funcionario,null);
            cb_funcionario.DisplayMember = "Value";
            cb_funcionario.ValueMember = "Key";

            dgv_usuarios.DataSource = Banco.dql(queryUsuarios);
            dgv_usuarios.Columns[0].Width = 30;
            dgv_usuarios.Columns[2].Width = 70;
            dgv_usuarios.Columns[1].Width = 70;
            dgv_usuarios.Columns[3].Width = 40;
            dgv_usuarios.Columns[4].Width = 140;

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinha = dgv.SelectedRows.Count;

            if (contlinha > 0)
            {
                DataTable dt = new DataTable();
                idSelecionado = dgv.SelectedRows[0].Cells[0].Value.ToString();

                string querySelecionado = String.Format(@"
                            SELECT 
                                tbu.N_IDUSUARIO,
                                tbu.T_USERNAME,
                                tbu.T_SENHA,
                                tbu.N_NIVEL,
                                tbf.T_NOMEFUNCIONARIO,
                                tbf.N_IDFUNCIONARIO
                            FROM
                                tb_usuarios as 'tbu'
                            INNER JOIN
                                tb_funcionarios as 'tbf' on tbf.N_IDFUNCIONARIO = tbu.N_IDFUNCIONARIO
                            WHERE
                                N_IDUSUARIO = {0}
                            
                ",idSelecionado);

                dt = Banco.dql(querySelecionado);

                txt_id.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                txt_username.Text = dt.Rows[0].Field<string>("T_USERNAME");
                txt_senha.Text = dt.Rows[0].Field<string>("T_SENHA");
                cb_nivel.Text =dt.Rows[0].Field<Int64>("N_NIVEL").ToString();

                Dictionary<int, string> funcionario = new Dictionary<int, string>();
                funcionario.Add(int.Parse(dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString()), dt.Rows[0].Field<string>("T_NOMEFUNCIONARIO"));
                cb_funcionario.DataSource = new BindingSource(funcionario,null);
                cb_funcionario.ValueMember = "Key";
                cb_funcionario.DisplayMember = "Value";
      
                


                
                
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Frm_CadUsuarios frm_CadUsuarios = new Frm_CadUsuarios();
            frm_CadUsuarios.ShowDialog();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            string queryAtualizar = String.Format(@"
                            UPDATE
                                tb_usuarios
                            SET
                                T_USERNAME = '{0}',
                                T_SENHA = '{1}',
                                N_NIVEL = {2}
                            WHERE
                                N_IDUSUARIO = {3}
            ", txt_username.Text, txt_senha.Text, int.Parse(cb_nivel.Text.ToString()), txt_id.Text);
            Banco.dml(queryAtualizar);

            string queryUsuarios = String.Format(@"
                    SELECT 
                         tbu.N_IDUSUARIO as 'Id',
                         tbu.T_USERNAME as 'Username',
                         tbu.T_SENHA as 'Senha',
                         tbu.N_NIVEL as 'Nível',
                         tbf.T_NOMEFUNCIONARIO as 'Nome do Funcionário'
                    FROM
                        tb_usuarios as tbu
                    INNER JOIN 
                        tb_funcionarios as tbf on tbf.N_IDFUNCIONARIO = tbu.N_IDFUNCIONARIO
                    ORDER BY 
                        tbf.T_NOMEFUNCIONARIO
            ");
            dgv_usuarios.DataSource = Banco.dql(queryUsuarios);
            MessageBox.Show("Dados Atualizados!");

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir usuário ?","Excluir?",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string queryExcluir = String.Format(@"
                            DELETE FROM
                                    tb_usuarios
                            WHERE
                                    N_IDUSUARIO = {0}
                ",txt_id.Text);
                dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
                Banco.dml(queryExcluir);
                MessageBox.Show("Usuário excluido!");
            }
        }
    }
}
