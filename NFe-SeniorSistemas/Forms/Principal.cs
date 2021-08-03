using NFe_SeniorSistemas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.StackTrace + Environment.NewLine + erro.Message);
            }
        }
    }
}
