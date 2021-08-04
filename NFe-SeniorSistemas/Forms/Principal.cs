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
            tbEmitente.TabPages[1].Text = "Emitente";
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
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.StackTrace + Environment.NewLine + erro.Message);
            }
        }

        private void MontaTelas(nfeProc nota)
        {
            txtEmitNome.Text = FormataString(nota.NFe.infNFe.emit.xNome);
            txtEmitNomeF.Text = FormataString(nota.NFe.infNFe.emit.xFant);
            txtEmitCNPJ.Text = Convert.ToString(nota.NFe.infNFe.emit.CNPJ);
            txtEmitTel.Text = Convert.ToString(nota.NFe.infNFe.emit.enderEmit.xFone);

            using (var correios = new WsCorreios.AtendeClienteClient())
            {
                try
                {
                    var enderecoEmitente = correios.consultaCEP('0' + Convert.ToString(nota.NFe.infNFe.emit.enderEmit.CEP));

                    txtEmitEnd.Text = FormataString(enderecoEmitente.end);
                    txtEmitBairro.Text = FormataString(enderecoEmitente.bairro);
                    txtEmitCEP.Text = FormataString(enderecoEmitente.cep);
                    txtEmitMun.Text = FormataString(enderecoEmitente.cidade);
                    txtEmitUF.Text = enderecoEmitente.uf;
                    txtEmitPais.Text = Convert.ToString(nota.NFe.infNFe.emit.enderEmit.cPais);
                    txtEmitIE.Text = Convert.ToString(nota.NFe.infNFe.emit.IE);

                    var enderecoDestinatario = correios.consultaCEP(Convert.ToString(nota.NFe.infNFe.dest.enderDest.CEP).Trim());
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace + Environment.NewLine + e.Message);
                }
            }

            txtEmitIETrib.Text = Convert.ToString(nota.NFe.infNFe.emit.IEST);
            txtEmitMunOcorrFGICMS.Text = Convert.ToString(nota.NFe.infNFe.emit.enderEmit.cMun);
            txtEmitCdRegTrib.Text = Convert.ToString(nota.NFe.infNFe.emit.CRT);
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
