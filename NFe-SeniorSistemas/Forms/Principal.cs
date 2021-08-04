using NFe_SeniorSistemas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace NFe_SeniorSistemas.Forms
{
    public partial class Principal : Form
    {
        private OpenFileDialog oFD = new OpenFileDialog();
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (oFD.ShowDialog() == DialogResult.OK)
                {
                    txtXML.Text = oFD.FileName;

                    XmlSerializer xml = new XmlSerializer(typeof(nfeProc));
                    TextReader txtReader = new StreamReader(oFD.FileName);

                    XmlTextReader xmlReader = new XmlTextReader(txtReader);
                    xmlReader.Read();

                    nfeProc nota = (nfeProc)xml.Deserialize(xmlReader);

                    MontaTelas(nota);
                    MontaTelasDestinatario(nota);
                    MontaTelasProdutos(nota);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.StackTrace + Environment.NewLine + erro.Message);
            }
        }

        private void MontaTelasProdutos(nfeProc nota)
        {
            foreach (var produto in nota.NFe.infNFe.det)
            {
                lstProdutos.Items.Add(new ListViewItem(new[] { produto.nItem.ToString(), produto.prod.xProd.ToString(), produto.prod.qCom.ToString(), produto.prod.vUnCom.ToString(), produto.prod.vProd.ToString() }));
            }
        }

        private void MontaTelas(nfeProc nota)
        {
            txtEmitNome.Text = FormataString(nota.NFe.infNFe.emit.xNome);
            txtEmitNomeF.Text = FormataString(nota.NFe.infNFe.emit.xFant);
            txtEmitCNPJ.Text = FormataCNPJ(nota.NFe.infNFe.emit.CNPJ);
            txtEmitTel.Text = Convert.ToString(nota.NFe.infNFe.emit.enderEmit.xFone);

            using (var correios = new WsCorreios.AtendeClienteClient())
            {
                var enderecoEmitente = correios.consultaCEP('0' + Convert.ToString(nota.NFe.infNFe.emit.enderEmit.CEP));

                txtEmitEnd.Text = FormataString(enderecoEmitente.end);
                txtEmitBairro.Text = FormataString(enderecoEmitente.bairro);
                txtEmitCEP.Text = FormataString(enderecoEmitente.cep);
                txtEmitMun.Text = FormataString(enderecoEmitente.cidade);
                txtEmitUF.Text = enderecoEmitente.uf;
                txtEmitPais.Text = FormataPais(nota.NFe.infNFe.emit.enderEmit.cPais);
                txtEmitIE.Text = Convert.ToString(nota.NFe.infNFe.emit.IE);
            }

            txtEmitIETrib.Text = Convert.ToString(nota.NFe.infNFe.emit.IEST);
            txtEmitMunOcorrFGICMS.Text = Convert.ToString(nota.NFe.infNFe.emit.enderEmit.cMun);
            txtEmitCdRegTrib.Text = Convert.ToString(nota.NFe.infNFe.emit.CRT);
        }

        private void MontaTelasDestinatario(nfeProc nota)
        {
            txtDestNome.Text = FormataString(nota.NFe.infNFe.dest.xNome);
            txtDestCPF.Text = FormataCPF(nota.NFe.infNFe.dest.CPF);
            txtDestEmail.Text = nota.NFe.infNFe.dest.xEmail;
            txtDestTel.Text = Convert.ToString(nota.NFe.infNFe.dest.enderDest.fone);
            txtDestIndIE.Text = FormataIEDest(nota.NFe.infNFe.dest.indIEDest);
            using (var correios = new WsCorreios.AtendeClienteClient())
            {
                var enderecoDestinatario = correios.consultaCEP(Convert.ToString(nota.NFe.infNFe.dest.enderDest.CEP));

                txtDestEnd.Text = FormataString(enderecoDestinatario.end);
                txtDestBairro.Text = FormataString(enderecoDestinatario.bairro);
                txtDestCEp.Text = FormataString(enderecoDestinatario.cep);
                txtDestNumero.Text = Convert.ToString(nota.NFe.infNFe.dest.enderDest.nro);
                txtDestMun.Text = FormataString(enderecoDestinatario.cidade);
                txtDestUF.Text = enderecoDestinatario.uf;
                txtDestPais.Text = FormataPais(nota.NFe.infNFe.dest.enderDest.cPais);
                txtDestComplemento.Text = nota.NFe.infNFe.dest.enderDest.xCpl;
            }
        }

        private string FormataCPF(ulong cPF)
        {
            return Convert.ToUInt64(cPF).ToString(@"000\.000\.000\-00");
        }

        private string FormataCNPJ(ulong CNPJ)
        {
            return Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
        }

        private string FormataIEDest(byte indIEDest)
        {
            if (indIEDest == 9)
            {
                return "09 - Não Contribuinte, que pode ou não possuir Inscrição Estadual no Cadastro de Contribuintes do ICMS";
            }
            else
            {
                return "";
            }
        }

        private string FormataPais(ushort cPais)
        {
            if (cPais == 1058)
            {
                return "1058 - Brasil";
            }
            else
            {
                return "Não Informado";
            }
        }

        private string FormataString(string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }

        private void tbEmit_Click(object sender, EventArgs e)
        {

        }
    }
}
