using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Controle.Loja
{
    public partial class FrmCadastroProdutos : Form
    {

        string[] aCodigoProdutos = new string[100];
        string[] aNomeProdutos = new string[100];
        decimal[] aPrecoVenda = new decimal[100];
        string[] aLocalizacao = new string[100];
        string[] aFornecedor = new string[100];
        DateTime[] aDataUltimaCompra = new DateTime[100];
        decimal[] aValorUltimaCompra = new decimal[100];
        bool bTeveErro;
        string modo;

        public FrmCadastroProdutos()
        {
            InitializeComponent();
        }

        private void HabilitaMenu()
        {
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void DesabilitaMenu()
        {
            btnAdicionar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void HabilitaCampos()
        {
            txtCodigoProduto.Enabled = true;
            txtNomeProduto.Enabled = true;
            txtPrecoVenda.Enabled = true;
            txtLocalizacao.Enabled = true;
            txtFornecedor.Enabled = true;
            dtpDataUltimaCompra.Enabled = true;
            txtValorUltimaCompra.Enabled = true;

            txtCodigoProduto.Focus();
        }
        private void DesabilitaCampos()
        {
            txtCodigoProduto.Enabled = false;
            txtNomeProduto.Enabled = false;
            txtPrecoVenda.Enabled = false;
            txtLocalizacao.Enabled = false;
            txtFornecedor.Enabled = false;
            dtpDataUltimaCompra.Enabled = false;
            txtValorUltimaCompra.Enabled = false;
        }
        private void AtualizaCampos()
        {
            int linhadgv = dgvLocalidadorProdutos.CurrentRow.Index + 1;

            txtCodigoProduto.Text = aCodigoProdutos[linhadgv].Trim();
            txtNomeProduto.Text = aNomeProdutos[linhadgv].Trim();
            txtPrecoVenda.Text = Convert.ToString(aPrecoVenda[linhadgv]);
            txtLocalizacao.Text = aLocalizacao[linhadgv].Trim();
            txtFornecedor.Text = aFornecedor[linhadgv].Trim();
            dtpDataUltimaCompra.Value = aDataUltimaCompra[linhadgv];
            txtValorUltimaCompra.Text = Convert.ToString(aValorUltimaCompra[linhadgv]);
        }
        private void AtualizaGrid()
        {
            dgvLocalidadorProdutos.Rows.Clear();

            for (int c = 1; c < aCodigoProdutos.Length - 1; c++)
            {
                if (aCodigoProdutos[c] != null)
                {
                    dgvLocalidadorProdutos.Rows.Add(aCodigoProdutos[c], aNomeProdutos[c], aFornecedor[c]);
                }
            }
        }
        private void LimparCampos()
        {
            txtCodigoProduto.Text = "";
            txtNomeProduto.Text = "";
            txtPrecoVenda.Text = "";
            txtLocalizacao.Text = "";
            txtFornecedor.Text = "";
            dtpDataUltimaCompra.Value = System.DateTime.Now;
            txtValorUltimaCompra.Text = "";
        }
        private void CriticaCampos()
        {

            //=============================== Verifica se o valor de venda é menor do que o de compra
            if (Convert.ToDecimal(txtPrecoVenda.Text) < Convert.ToDecimal(txtValorUltimaCompra.Text))
            {
                MessageBox.Show("Valor de venda não pode ser menor que o Valor de Compra!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bTeveErro = true;
            }

            //================================ Verifica se a Localização doi digitada corretamente
            txtLocalizacao.Text = txtLocalizacao.Text.ToUpper();
            if (!txtLocalizacao.Text.Contains("S") || !txtLocalizacao.Text.Contains("A") || !txtLocalizacao.Text.Contains("P"))
            {
                MessageBox.Show("Localização incompleta! - Redigite com os Padrões S,A,P", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bTeveErro = true;
            }
        }

        private void GravaArquivoSequencial()
        {
            StreamWriter Gravador = new StreamWriter("Produtos.txt");

            for (int DadosArray = 1; DadosArray < aCodigoProdutos.Length; DadosArray++)
            {
                if (aCodigoProdutos[DadosArray] != null)
                {
                    string LinhaDados = "";

                    LinhaDados += aCodigoProdutos[DadosArray];
                    LinhaDados += aNomeProdutos[DadosArray];
                    LinhaDados += string.Format("              {0}", Convert.ToString(aPrecoVenda[DadosArray])).Substring(Convert.ToString(aPrecoVenda[DadosArray]).Length, 14);
                    LinhaDados += aLocalizacao[DadosArray];
                    LinhaDados += aFornecedor[DadosArray];
                    LinhaDados += Convert.ToString(aDataUltimaCompra[DadosArray]).Substring(0, 10);
                    LinhaDados += string.Format("              {0}", Convert.ToString(aValorUltimaCompra[DadosArray])).Substring(Convert.ToString(aValorUltimaCompra[DadosArray]).Length, 14);

                    Gravador.WriteLine(LinhaDados);
                }
            }

            Gravador.Close();
        }

        private void FrmCadastroProdutos_Load(object sender, EventArgs e)
        {
            StreamReader vleitor = new StreamReader("Produtos.txt");

            int i = 1;

            while (!vleitor.EndOfStream)
            {
                string registro = vleitor.ReadLine();

                aCodigoProdutos[i] = registro.Substring(0, 10);
                aNomeProdutos[i] = registro.Substring(10, 20);
                aPrecoVenda[i] = Convert.ToDecimal(registro.Substring(30, 14));
                aLocalizacao[i] = registro.Substring(44, 10);
                aFornecedor[i] = registro.Substring(54, 15);
                aDataUltimaCompra[i] = Convert.ToDateTime(registro.Substring(69, 10));
                aValorUltimaCompra[i] = Convert.ToDecimal(registro.Substring(79, 14));

                dgvLocalidadorProdutos.Rows.Add(aCodigoProdutos[i], aNomeProdutos[i], aFornecedor[i]);

                i++;
            }
            vleitor.Close();

            DesabilitaCampos();
            HabilitaMenu();

            //inicializa variavel modo
            modo = "";

            lblStatusExecucao.Text = "Pronto";
        }

        private void dgvLocalidadorProdutos_SelectionChanged(object sender, EventArgs e)
        {
            AtualizaCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
            modo = "A";
            lblStatusExecucao.Text = "MODO DE ATUALIZAÇÃO";
            DesabilitaMenu();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaCampos();
            AtualizaCampos();
            modo = "";
            lblStatusExecucao.Text = "Pronto";
            HabilitaMenu();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            bTeveErro = false;
            CriticaCampos();
            if (bTeveErro)
            {
                return;
            }

            //==========================Inicia ALTERAÇÃO
            if (modo == "A")
            {
                int linhadgv = dgvLocalidadorProdutos.CurrentRow.Index + 1;

                aCodigoProdutos[linhadgv] = string.Format("{0}          ", txtCodigoProduto.Text).Substring(0, 10);
                aNomeProdutos[linhadgv] = string.Format("{0}                    ", txtNomeProduto.Text).Substring(0, 20);
                aPrecoVenda[linhadgv] = Convert.ToDecimal(txtPrecoVenda.Text);
                aLocalizacao[linhadgv] = string.Format("{0}          ", txtLocalizacao.Text).Substring(0, 10);
                aFornecedor[linhadgv] = string.Format("{0}               ", txtFornecedor.Text).Substring(0, 15);
                aDataUltimaCompra[linhadgv] = dtpDataUltimaCompra.Value;
                aValorUltimaCompra[linhadgv] = Convert.ToDecimal(txtValorUltimaCompra.Text);

                modo = "";
                lblStatusExecucao.Text = "Dados Alterados com Sucesso";
                MessageBox.Show("Dados Alterados com Sucesso!", "Gravação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DesabilitaCampos();
                AtualizaGrid();
                AtualizaCampos();

                lblStatusExecucao.Text = "Pronto";
            }

            //==========================Inicia INCLUSÃO
            if (modo == "I")
            {
                int linhadgv = dgvLocalidadorProdutos.Rows.Count + 1;

                aCodigoProdutos[linhadgv] = string.Format("{0}          ", txtCodigoProduto.Text).Substring(0, 10);
                aNomeProdutos[linhadgv] = string.Format("{0}                    ", txtNomeProduto.Text).Substring(0, 20);
                aPrecoVenda[linhadgv] = Convert.ToDecimal(txtPrecoVenda.Text);
                aLocalizacao[linhadgv] = string.Format("{0}          ", txtLocalizacao.Text).Substring(0, 10);
                aFornecedor[linhadgv] = string.Format("{0}               ", txtFornecedor.Text).Substring(0, 15);
                aDataUltimaCompra[linhadgv] = dtpDataUltimaCompra.Value;
                aValorUltimaCompra[linhadgv] = Convert.ToDecimal(txtValorUltimaCompra.Text);

                modo = "";
                lblStatusExecucao.Text = "Dados Incluidos com Sucesso";
                MessageBox.Show("Dados Incluidos com Sucesso!", "Gravação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DesabilitaCampos();
                AtualizaGrid();
                dgvLocalidadorProdutos[0, linhadgv - 1].Selected = true;
                AtualizaCampos();

                lblStatusExecucao.Text = "Pronto";
            }

            //==========================Inicia EXCLUSÃO
            if (modo == "E")
            {
                int linhadgv = dgvLocalidadorProdutos.CurrentRow.Index + 1;

                for (int c = 1; c <= aCodigoProdutos.Length - 2; c++)
                {
                    if (linhadgv <= c)
                    {
                        aCodigoProdutos[c] = aCodigoProdutos[c + 1];
                        aNomeProdutos[c] = aNomeProdutos[c + 1];
                        aPrecoVenda[c] = aPrecoVenda[c + 1];
                        aLocalizacao[c] = aLocalizacao[c + 1];
                        aFornecedor[c] = aFornecedor[c + 1];
                        aDataUltimaCompra[c] = aDataUltimaCompra[c + 1];
                        aValorUltimaCompra[c] = aValorUltimaCompra[c + 1];
                    }
                }

                modo = "";
                lblStatusExecucao.Text = "Dados Excluidos com Sucesso";
                MessageBox.Show("Dados Excluidos com Sucesso!", "Gravação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizaGrid();
                AtualizaCampos();

                lblStatusExecucao.Text = "Pronto";
            }
            HabilitaMenu();
            GravaArquivoSequencial();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
            modo = "I";
            lblStatusExecucao.Text = "MODO DE INCLUSÃO";
            LimparCampos();
            DesabilitaMenu();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            modo = "E";
            MessageBox.Show(string.Format("Para Confirmar a Exclusão de:{0} Clique em [GRAVAR] ou Clique em [CANCELAR]", txtNomeProduto), "MODP DE EXCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblStatusExecucao.Text = "MODP DE EXCLUSÃO";
            DesabilitaMenu();
        }

        private void FrmCadastroProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            GravaArquivoSequencial();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            for (int c = 1; c <= aCodigoProdutos.Length - 1; c++)
            {
                if (aCodigoProdutos[c] == null)
                {
                    MessageBox.Show("Item digitado impossivel de ser Localizado","Nenhum Item Localizado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                if (txtPesquisar.Text == aCodigoProdutos[c].Trim() ||  aNomeProdutos[c].Trim().ToUpper().Contains(txtPesquisar.Text.ToUpper()))
                {
                    dgvLocalidadorProdutos[0, c - 1].Selected = true;
                    AtualizaCampos();
                    return;

                    //txtCodigoProduto.Text = aCodigoProdutos[c].Trim();
                    //txtNomeProduto.Text = aNomeProdutos[c].Trim();
                    //txtPrecoVenda.Text = Convert.ToString(aPrecoVenda[c]);
                    //txtLocalizacao.Text = aLocalizacao[c].Trim();
                    //txtFornecedor.Text = aFornecedor[c].Trim();
                    //dtpDataUltimaCompra.Value = aDataUltimaCompra[c];
                    //txtValorUltimaCompra.Text = Convert.ToString(aValorUltimaCompra[c]);
                    //return;
                }
            }
        }
    }
}
