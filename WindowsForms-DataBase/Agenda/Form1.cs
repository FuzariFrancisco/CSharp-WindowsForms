using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Agenda
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection();
        String connect = @"Provider=Microsoft.ACE.OLEDB.12.0;
                Data Source=C:\Users\francisco.hsfsouza\Documents\teste.accdb";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != String.Empty && txtTelefone.Text != String.Empty)
            { 
            operacao_banco("INSERT INTO tabela1(nome,telefone) VALUES('" + txtNome.Text + "' , '" + txtTelefone.Text + "')");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            operacao_banco("DELETE FROM tabela1 WHERE nome = ('" + txtNome + "')");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            operacao_banco("UPDATE tabela1 SET nome = ('" + txtNovoNome.Text + "') WHERE nome = ('" + txtNome.Text + "')");
            operacao_banco("UPDATE tabela1 SET telefone = ('" + txtNovoTelefone.Text + "') WHERE telefone = ('" + txtTelefone.Text + "')");
        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {                                 
                conn.ConnectionString = connect;
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM tabela1 WHERE nome Like('"+txtNome.Text+ "%')ORDER BY nome ASC");
                
                cmd.Connection = conn;

                conn.Open();
                OleDbDataReader aReader = cmd.ExecuteReader();
                txtInformacoes.Text = "Os Valores Retornados da Tabela São: ";
                while (aReader.Read())
                {
                    txtInformacoes.Text += Environment.NewLine + aReader.GetString(0) + " " + aReader.GetInt32(1);
                }
                conn.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Dado Não Apagado, Erro: " + Erro.ToString(), "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        void operacao_banco(String op)
        {            
                try
                {
                    conn.ConnectionString = connect;
                    OleDbCommand cmd = new OleDbCommand(op);
                    cmd.Connection = conn;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dado Cadastrado Com Sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Dado Não Cadastrado, Erro: " + Erro.ToString(), "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }                                                                                                                       
        }
    }
}
