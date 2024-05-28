using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WS02._1.Servico;
using WS02._1.Servico.Modelo;

namespace WS02._1
{
    public partial class FrmBuscaCEP : Form
    {
        public FrmBuscaCEP()
        {
            InitializeComponent();
            btnCEP.Click += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Trim();
            if (isValidCep(cep))
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);
                    if (end != null)
                    {
                        lblLocalidade.Text = end.localidade;
                        
                        lblUF.Text = end.uf;
                        lblLogradouro.Text = end.logradouro;
                        lblBairro.Text = end.bairro;
                        txtCEP.Text = "";
                        
                    }
                    else
                    {
                        MessageBox.Show("CEP não encontrado", "Erro", MessageBoxButtons.OK);
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK);
                }
            }
        }

        private bool isValidCep(string cep)
        {
            bool valido = true;
            if (cep.Length != 8)
            {
                MessageBox.Show("CEP Inválido! O CEP tem apenas 8 números", "Erro",MessageBoxButtons.OK);
                valido = false;
            }
            int novoCEP = 0;
            if(!int.TryParse(cep, out novoCEP))
            {
                MessageBox.Show("CEP contém apenas números", "Erro", MessageBoxButtons.OK);
                valido = false;
            }
            return valido;
        }
    }
}
