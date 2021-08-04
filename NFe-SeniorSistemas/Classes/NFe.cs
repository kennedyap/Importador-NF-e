using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe_SeniorSistemas.Classes
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class nfeProc
    {

        private nfeProcNFe nFeField;

        private nfeProcProtNFe protNFeField;

        private string[] textField;

        private decimal versaoField;

        /// <remarks/>
        public nfeProcNFe NFe
        {
            get
            {
                return this.nFeField;
            }
            set
            {
                this.nFeField = value;
            }
        }

        /// <remarks/>
        public nfeProcProtNFe protNFe
        {
            get
            {
                return this.protNFeField;
            }
            set
            {
                this.protNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFe
    {

        private nfeProcNFeInfNFe infNFeField;

        private Signature signatureField;

        private string[] textField;

        /// <remarks/>
        public nfeProcNFeInfNFe infNFe
        {
            get
            {
                return this.infNFeField;
            }
            set
            {
                this.infNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Signature Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFe
    {

        private nfeProcNFeInfNFeIde ideField;

        private nfeProcNFeInfNFeEmit emitField;

        private nfeProcNFeInfNFeDest destField;

        private nfeProcNFeInfNFeDet[] detField;

        private nfeProcNFeInfNFeTotal totalField;

        private nfeProcNFeInfNFeTransp transpField;

        private nfeProcNFeInfNFePag pagField;

        private nfeProcNFeInfNFeInfAdic infAdicField;

        private object compraField;

        private nfeProcNFeInfNFeInfRespTec infRespTecField;

        private string[] textField;

        private decimal versaoField;

        private string idField;

        /// <remarks/>
        public nfeProcNFeInfNFeIde ide
        {
            get
            {
                return this.ideField;
            }
            set
            {
                this.ideField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeEmit emit
        {
            get
            {
                return this.emitField;
            }
            set
            {
                this.emitField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeDest dest
        {
            get
            {
                return this.destField;
            }
            set
            {
                this.destField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("det")]
        public nfeProcNFeInfNFeDet[] det
        {
            get
            {
                return this.detField;
            }
            set
            {
                this.detField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeTotal total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeTransp transp
        {
            get
            {
                return this.transpField;
            }
            set
            {
                this.transpField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFePag pag
        {
            get
            {
                return this.pagField;
            }
            set
            {
                this.pagField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeInfAdic infAdic
        {
            get
            {
                return this.infAdicField;
            }
            set
            {
                this.infAdicField = value;
            }
        }

        /// <remarks/>
        public object compra
        {
            get
            {
                return this.compraField;
            }
            set
            {
                this.compraField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeInfRespTec infRespTec
        {
            get
            {
                return this.infRespTecField;
            }
            set
            {
                this.infRespTecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeIde
    {

        private byte cUFField;

        private uint cNFField;

        private string natOpField;

        private byte modField;

        private byte serieField;

        private uint nNFField;

        private System.DateTime dhEmiField;

        private byte tpNFField;

        private byte idDestField;

        private uint cMunFGField;

        private byte tpImpField;

        private byte tpEmisField;

        private byte cDVField;

        private byte tpAmbField;

        private byte finNFeField;

        private byte indFinalField;

        private byte indPresField;

        private byte procEmiField;

        private decimal verProcField;

        /// <remarks/>
        public byte cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public uint cNF
        {
            get
            {
                return this.cNFField;
            }
            set
            {
                this.cNFField = value;
            }
        }

        /// <remarks/>
        public string natOp
        {
            get
            {
                return this.natOpField;
            }
            set
            {
                this.natOpField = value;
            }
        }

        /// <remarks/>
        public byte mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        /// <remarks/>
        public byte serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        /// <remarks/>
        public uint nNF
        {
            get
            {
                return this.nNFField;
            }
            set
            {
                this.nNFField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dhEmi
        {
            get
            {
                return this.dhEmiField;
            }
            set
            {
                this.dhEmiField = value;
            }
        }

        /// <remarks/>
        public byte tpNF
        {
            get
            {
                return this.tpNFField;
            }
            set
            {
                this.tpNFField = value;
            }
        }

        /// <remarks/>
        public byte idDest
        {
            get
            {
                return this.idDestField;
            }
            set
            {
                this.idDestField = value;
            }
        }

        /// <remarks/>
        public uint cMunFG
        {
            get
            {
                return this.cMunFGField;
            }
            set
            {
                this.cMunFGField = value;
            }
        }

        /// <remarks/>
        public byte tpImp
        {
            get
            {
                return this.tpImpField;
            }
            set
            {
                this.tpImpField = value;
            }
        }

        /// <remarks/>
        public byte tpEmis
        {
            get
            {
                return this.tpEmisField;
            }
            set
            {
                this.tpEmisField = value;
            }
        }

        /// <remarks/>
        public byte cDV
        {
            get
            {
                return this.cDVField;
            }
            set
            {
                this.cDVField = value;
            }
        }

        /// <remarks/>
        public byte tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public byte finNFe
        {
            get
            {
                return this.finNFeField;
            }
            set
            {
                this.finNFeField = value;
            }
        }

        /// <remarks/>
        public byte indFinal
        {
            get
            {
                return this.indFinalField;
            }
            set
            {
                this.indFinalField = value;
            }
        }

        /// <remarks/>
        public byte indPres
        {
            get
            {
                return this.indPresField;
            }
            set
            {
                this.indPresField = value;
            }
        }

        /// <remarks/>
        public byte procEmi
        {
            get
            {
                return this.procEmiField;
            }
            set
            {
                this.procEmiField = value;
            }
        }

        /// <remarks/>
        public decimal verProc
        {
            get
            {
                return this.verProcField;
            }
            set
            {
                this.verProcField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeEmit
    {

        private ulong cNPJField;

        private string xNomeField;

        private string xFantField;

        private nfeProcNFeInfNFeEmitEnderEmit enderEmitField;

        private ulong ieField;

        private uint iESTField;

        private byte cRTField;

        private string[] textField;

        /// <remarks/>
        public ulong CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        /// <remarks/>
        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        /// <remarks/>
        public string xFant
        {
            get
            {
                return this.xFantField;
            }
            set
            {
                this.xFantField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeEmitEnderEmit enderEmit
        {
            get
            {
                return this.enderEmitField;
            }
            set
            {
                this.enderEmitField = value;
            }
        }

        /// <remarks/>
        public ulong IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        /// <remarks/>
        public uint IEST
        {
            get
            {
                return this.iESTField;
            }
            set
            {
                this.iESTField = value;
            }
        }

        /// <remarks/>
        public byte CRT
        {
            get
            {
                return this.cRTField;
            }
            set
            {
                this.cRTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeEmitEnderEmit
    {

        private string xLgrField;

        private ushort nroField;

        private string xBairroField;

        private uint cMunField;

        private string xMunField;

        private string ufField;

        private uint cEPField;

        private ushort cPaisField;

        private string xPaisField;

        private string xFoneField;

        /// <remarks/>
        public string xLgr
        {
            get
            {
                return this.xLgrField;
            }
            set
            {
                this.xLgrField = value;
            }
        }

        /// <remarks/>
        public ushort nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }

        /// <remarks/>
        public string xBairro
        {
            get
            {
                return this.xBairroField;
            }
            set
            {
                this.xBairroField = value;
            }
        }

        /// <remarks/>
        public uint cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        /// <remarks/>
        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        /// <remarks/>
        public string UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        public uint CEP
        {
            get
            {
                return this.cEPField;
            }
            set
            {
                this.cEPField = value;
            }
        }

        /// <remarks/>
        public ushort cPais
        {
            get
            {
                return this.cPaisField;
            }
            set
            {
                this.cPaisField = value;
            }
        }

        /// <remarks/>
        public string xPais
        {
            get
            {
                return this.xPaisField;
            }
            set
            {
                this.xPaisField = value;
            }
        }

        public string xFone
        {
            get
            {
                return this.xFoneField;
            }
            set
            {
                this.xFoneField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDest
    {

        private ulong cPFField;

        private string xNomeField;

        private nfeProcNFeInfNFeDestEnderDest enderDestField;

        private byte indIEDestField;

        private string[] textField;

        private string xEmailField;

        /// <remarks/>
        public ulong CPF
        {
            get
            {
                return this.cPFField;
            }
            set
            {
                this.cPFField = value;
            }
        }

        public string xEmail
        {
            get
            {
                return this.xEmailField;
            }
            set
            {
                this.xEmailField = value;
            }
        }

        /// <remarks/>
        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeDestEnderDest enderDest
        {
            get
            {
                return this.enderDestField;
            }
            set
            {
                this.enderDestField = value;
            }
        }

        /// <remarks/>
        public byte indIEDest
        {
            get
            {
                return this.indIEDestField;
            }
            set
            {
                this.indIEDestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDestEnderDest
    {

        private string xLgrField;

        private byte nroField;

        private string xCplField;

        private string xBairroField;

        private uint cMunField;

        private string xMunField;

        private string ufField;

        private uint cEPField;

        private ushort cPaisField;

        private ulong foneField;

        /// <remarks/>
        public string xLgr
        {
            get
            {
                return this.xLgrField;
            }
            set
            {
                this.xLgrField = value;
            }
        }

        /// <remarks/>
        public byte nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }

        /// <remarks/>
        public string xCpl
        {
            get
            {
                return this.xCplField;
            }
            set
            {
                this.xCplField = value;
            }
        }

        /// <remarks/>
        public string xBairro
        {
            get
            {
                return this.xBairroField;
            }
            set
            {
                this.xBairroField = value;
            }
        }

        /// <remarks/>
        public uint cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        /// <remarks/>
        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        /// <remarks/>
        public string UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        public uint CEP
        {
            get
            {
                return this.cEPField;
            }
            set
            {
                this.cEPField = value;
            }
        }

        /// <remarks/>
        public ushort cPais
        {
            get
            {
                return this.cPaisField;
            }
            set
            {
                this.cPaisField = value;
            }
        }

        /// <remarks/>
        public ulong fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDet
    {

        private nfeProcNFeInfNFeDetProd prodField;

        private nfeProcNFeInfNFeDetImposto impostoField;

        private string infAdProdField;

        private string[] textField;

        private byte nItemField;

        /// <remarks/>
        public nfeProcNFeInfNFeDetProd prod
        {
            get
            {
                return this.prodField;
            }
            set
            {
                this.prodField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeDetImposto imposto
        {
            get
            {
                return this.impostoField;
            }
            set
            {
                this.impostoField = value;
            }
        }

        /// <remarks/>
        public string infAdProd
        {
            get
            {
                return this.infAdProdField;
            }
            set
            {
                this.infAdProdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte nItem
        {
            get
            {
                return this.nItemField;
            }
            set
            {
                this.nItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDetProd
    {

        private string cProdField;

        private ulong cEANField;

        private string xProdField;

        private uint nCMField;

        private uint cESTField;

        private ushort cFOPField;

        private string uComField;

        private byte qComField;

        private decimal vUnComField;

        private decimal vProdField;

        private ulong cEANTribField;

        private string uTribField;

        private byte qTribField;

        private decimal vUnTribField;

        private byte indTotField;

        private ulong xPedField;

        /// <remarks/>
        public string cProd
        {
            get
            {
                return this.cProdField;
            }
            set
            {
                this.cProdField = value;
            }
        }

        /// <remarks/>
        public ulong cEAN
        {
            get
            {
                return this.cEANField;
            }
            set
            {
                this.cEANField = value;
            }
        }

        /// <remarks/>
        public string xProd
        {
            get
            {
                return this.xProdField;
            }
            set
            {
                this.xProdField = value;
            }
        }

        /// <remarks/>
        public uint NCM
        {
            get
            {
                return this.nCMField;
            }
            set
            {
                this.nCMField = value;
            }
        }

        /// <remarks/>
        public uint CEST
        {
            get
            {
                return this.cESTField;
            }
            set
            {
                this.cESTField = value;
            }
        }

        /// <remarks/>
        public ushort CFOP
        {
            get
            {
                return this.cFOPField;
            }
            set
            {
                this.cFOPField = value;
            }
        }

        /// <remarks/>
        public string uCom
        {
            get
            {
                return this.uComField;
            }
            set
            {
                this.uComField = value;
            }
        }

        /// <remarks/>
        public byte qCom
        {
            get
            {
                return this.qComField;
            }
            set
            {
                this.qComField = value;
            }
        }

        /// <remarks/>
        public decimal vUnCom
        {
            get
            {
                return this.vUnComField;
            }
            set
            {
                this.vUnComField = value;
            }
        }

        /// <remarks/>
        public decimal vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        /// <remarks/>
        public ulong cEANTrib
        {
            get
            {
                return this.cEANTribField;
            }
            set
            {
                this.cEANTribField = value;
            }
        }

        /// <remarks/>
        public string uTrib
        {
            get
            {
                return this.uTribField;
            }
            set
            {
                this.uTribField = value;
            }
        }

        /// <remarks/>
        public byte qTrib
        {
            get
            {
                return this.qTribField;
            }
            set
            {
                this.qTribField = value;
            }
        }

        /// <remarks/>
        public decimal vUnTrib
        {
            get
            {
                return this.vUnTribField;
            }
            set
            {
                this.vUnTribField = value;
            }
        }

        /// <remarks/>
        public byte indTot
        {
            get
            {
                return this.indTotField;
            }
            set
            {
                this.indTotField = value;
            }
        }

        /// <remarks/>
        public ulong xPed
        {
            get
            {
                return this.xPedField;
            }
            set
            {
                this.xPedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDetImposto
    {

        private decimal vTotTribField;

        private nfeProcNFeInfNFeDetImpostoICMS iCMSField;

        private nfeProcNFeInfNFeDetImpostoIPI iPIField;

        private nfeProcNFeInfNFeDetImpostoPIS pISField;

        private nfeProcNFeInfNFeDetImpostoCOFINS cOFINSField;

        private nfeProcNFeInfNFeDetImpostoICMSUFDest iCMSUFDestField;

        private string[] textField;

        /// <remarks/>
        public decimal vTotTrib
        {
            get
            {
                return this.vTotTribField;
            }
            set
            {
                this.vTotTribField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeDetImpostoICMS ICMS
        {
            get
            {
                return this.iCMSField;
            }
            set
            {
                this.iCMSField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeDetImpostoIPI IPI
        {
            get
            {
                return this.iPIField;
            }
            set
            {
                this.iPIField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeDetImpostoPIS PIS
        {
            get
            {
                return this.pISField;
            }
            set
            {
                this.pISField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeDetImpostoCOFINS COFINS
        {
            get
            {
                return this.cOFINSField;
            }
            set
            {
                this.cOFINSField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeDetImpostoICMSUFDest ICMSUFDest
        {
            get
            {
                return this.iCMSUFDestField;
            }
            set
            {
                this.iCMSUFDestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDetImpostoICMS
    {

        private nfeProcNFeInfNFeDetImpostoICMSICMS00 iCMS00Field;

        private string[] textField;

        /// <remarks/>
        public nfeProcNFeInfNFeDetImpostoICMSICMS00 ICMS00
        {
            get
            {
                return this.iCMS00Field;
            }
            set
            {
                this.iCMS00Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDetImpostoICMSICMS00
    {

        private byte origField;

        private byte cSTField;

        private byte modBCField;

        private decimal vBCField;

        private decimal pICMSField;

        private decimal vICMSField;

        /// <remarks/>
        public byte orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public byte CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public byte modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        /// <remarks/>
        public decimal vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public decimal pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public decimal vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDetImpostoIPI
    {

        private ushort cEnqField;

        private nfeProcNFeInfNFeDetImpostoIPIIPINT iPINTField;

        private string[] textField;

        /// <remarks/>
        public ushort cEnq
        {
            get
            {
                return this.cEnqField;
            }
            set
            {
                this.cEnqField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeDetImpostoIPIIPINT IPINT
        {
            get
            {
                return this.iPINTField;
            }
            set
            {
                this.iPINTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDetImpostoIPIIPINT
    {

        private byte cSTField;

        /// <remarks/>
        public byte CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDetImpostoPIS
    {

        private nfeProcNFeInfNFeDetImpostoPISPISAliq pISAliqField;

        private nfeProcNFeInfNFeDetImpostoPISPISNT pISNTField;

        private string[] textField;

        /// <remarks/>
        public nfeProcNFeInfNFeDetImpostoPISPISAliq PISAliq
        {
            get
            {
                return this.pISAliqField;
            }
            set
            {
                this.pISAliqField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeDetImpostoPISPISNT PISNT
        {
            get
            {
                return this.pISNTField;
            }
            set
            {
                this.pISNTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDetImpostoPISPISAliq
    {

        private byte cSTField;

        private decimal vBCField;

        private decimal pPISField;

        private decimal vPISField;

        /// <remarks/>
        public byte CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public decimal vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public decimal pPIS
        {
            get
            {
                return this.pPISField;
            }
            set
            {
                this.pPISField = value;
            }
        }

        /// <remarks/>
        public decimal vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDetImpostoPISPISNT
    {

        private byte cSTField;

        /// <remarks/>
        public byte CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDetImpostoCOFINS
    {

        private nfeProcNFeInfNFeDetImpostoCOFINSCOFINSAliq cOFINSAliqField;

        private nfeProcNFeInfNFeDetImpostoCOFINSCOFINSNT cOFINSNTField;

        private string[] textField;

        /// <remarks/>
        public nfeProcNFeInfNFeDetImpostoCOFINSCOFINSAliq COFINSAliq
        {
            get
            {
                return this.cOFINSAliqField;
            }
            set
            {
                this.cOFINSAliqField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeDetImpostoCOFINSCOFINSNT COFINSNT
        {
            get
            {
                return this.cOFINSNTField;
            }
            set
            {
                this.cOFINSNTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDetImpostoCOFINSCOFINSAliq
    {

        private byte cSTField;

        private decimal vBCField;

        private decimal pCOFINSField;

        private decimal vCOFINSField;

        /// <remarks/>
        public byte CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public decimal vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public decimal pCOFINS
        {
            get
            {
                return this.pCOFINSField;
            }
            set
            {
                this.pCOFINSField = value;
            }
        }

        /// <remarks/>
        public decimal vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDetImpostoCOFINSCOFINSNT
    {

        private byte cSTField;

        /// <remarks/>
        public byte CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeDetImpostoICMSUFDest
    {

        private decimal vBCUFDestField;

        private decimal vBCFCPUFDestField;

        private decimal pFCPUFDestField;

        private decimal pICMSUFDestField;

        private decimal pICMSInterField;

        private decimal pICMSInterPartField;

        private decimal vFCPUFDestField;

        private decimal vICMSUFDestField;

        private decimal vICMSUFRemetField;

        /// <remarks/>
        public decimal vBCUFDest
        {
            get
            {
                return this.vBCUFDestField;
            }
            set
            {
                this.vBCUFDestField = value;
            }
        }

        /// <remarks/>
        public decimal vBCFCPUFDest
        {
            get
            {
                return this.vBCFCPUFDestField;
            }
            set
            {
                this.vBCFCPUFDestField = value;
            }
        }

        /// <remarks/>
        public decimal pFCPUFDest
        {
            get
            {
                return this.pFCPUFDestField;
            }
            set
            {
                this.pFCPUFDestField = value;
            }
        }

        /// <remarks/>
        public decimal pICMSUFDest
        {
            get
            {
                return this.pICMSUFDestField;
            }
            set
            {
                this.pICMSUFDestField = value;
            }
        }

        /// <remarks/>
        public decimal pICMSInter
        {
            get
            {
                return this.pICMSInterField;
            }
            set
            {
                this.pICMSInterField = value;
            }
        }

        /// <remarks/>
        public decimal pICMSInterPart
        {
            get
            {
                return this.pICMSInterPartField;
            }
            set
            {
                this.pICMSInterPartField = value;
            }
        }

        /// <remarks/>
        public decimal vFCPUFDest
        {
            get
            {
                return this.vFCPUFDestField;
            }
            set
            {
                this.vFCPUFDestField = value;
            }
        }

        /// <remarks/>
        public decimal vICMSUFDest
        {
            get
            {
                return this.vICMSUFDestField;
            }
            set
            {
                this.vICMSUFDestField = value;
            }
        }

        /// <remarks/>
        public decimal vICMSUFRemet
        {
            get
            {
                return this.vICMSUFRemetField;
            }
            set
            {
                this.vICMSUFRemetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeTotal
    {

        private nfeProcNFeInfNFeTotalICMSTot iCMSTotField;

        private string[] textField;

        /// <remarks/>
        public nfeProcNFeInfNFeTotalICMSTot ICMSTot
        {
            get
            {
                return this.iCMSTotField;
            }
            set
            {
                this.iCMSTotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeTotalICMSTot
    {

        private decimal vBCField;

        private decimal vICMSField;

        private decimal vICMSDesonField;

        private decimal vFCPUFDestField;

        private decimal vICMSUFDestField;

        private decimal vICMSUFRemetField;

        private decimal vFCPField;

        private decimal vBCSTField;

        private decimal vSTField;

        private decimal vFCPSTField;

        private decimal vFCPSTRetField;

        private decimal vProdField;

        private decimal vFreteField;

        private decimal vSegField;

        private decimal vDescField;

        private decimal vIIField;

        private decimal vIPIField;

        private decimal vIPIDevolField;

        private decimal vPISField;

        private decimal vCOFINSField;

        private decimal vOutroField;

        private decimal vNFField;

        private decimal vTotTribField;

        /// <remarks/>
        public decimal vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public decimal vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <remarks/>
        public decimal vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        /// <remarks/>
        public decimal vFCPUFDest
        {
            get
            {
                return this.vFCPUFDestField;
            }
            set
            {
                this.vFCPUFDestField = value;
            }
        }

        /// <remarks/>
        public decimal vICMSUFDest
        {
            get
            {
                return this.vICMSUFDestField;
            }
            set
            {
                this.vICMSUFDestField = value;
            }
        }

        /// <remarks/>
        public decimal vICMSUFRemet
        {
            get
            {
                return this.vICMSUFRemetField;
            }
            set
            {
                this.vICMSUFRemetField = value;
            }
        }

        /// <remarks/>
        public decimal vFCP
        {
            get
            {
                return this.vFCPField;
            }
            set
            {
                this.vFCPField = value;
            }
        }

        /// <remarks/>
        public decimal vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        /// <remarks/>
        public decimal vST
        {
            get
            {
                return this.vSTField;
            }
            set
            {
                this.vSTField = value;
            }
        }

        /// <remarks/>
        public decimal vFCPST
        {
            get
            {
                return this.vFCPSTField;
            }
            set
            {
                this.vFCPSTField = value;
            }
        }

        /// <remarks/>
        public decimal vFCPSTRet
        {
            get
            {
                return this.vFCPSTRetField;
            }
            set
            {
                this.vFCPSTRetField = value;
            }
        }

        /// <remarks/>
        public decimal vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        /// <remarks/>
        public decimal vFrete
        {
            get
            {
                return this.vFreteField;
            }
            set
            {
                this.vFreteField = value;
            }
        }

        /// <remarks/>
        public decimal vSeg
        {
            get
            {
                return this.vSegField;
            }
            set
            {
                this.vSegField = value;
            }
        }

        /// <remarks/>
        public decimal vDesc
        {
            get
            {
                return this.vDescField;
            }
            set
            {
                this.vDescField = value;
            }
        }

        /// <remarks/>
        public decimal vII
        {
            get
            {
                return this.vIIField;
            }
            set
            {
                this.vIIField = value;
            }
        }

        /// <remarks/>
        public decimal vIPI
        {
            get
            {
                return this.vIPIField;
            }
            set
            {
                this.vIPIField = value;
            }
        }

        /// <remarks/>
        public decimal vIPIDevol
        {
            get
            {
                return this.vIPIDevolField;
            }
            set
            {
                this.vIPIDevolField = value;
            }
        }

        /// <remarks/>
        public decimal vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

        /// <remarks/>
        public decimal vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

        /// <remarks/>
        public decimal vOutro
        {
            get
            {
                return this.vOutroField;
            }
            set
            {
                this.vOutroField = value;
            }
        }

        /// <remarks/>
        public decimal vNF
        {
            get
            {
                return this.vNFField;
            }
            set
            {
                this.vNFField = value;
            }
        }

        /// <remarks/>
        public decimal vTotTrib
        {
            get
            {
                return this.vTotTribField;
            }
            set
            {
                this.vTotTribField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeTransp
    {

        private byte modFreteField;

        private object transportaField;

        /// <remarks/>
        public byte modFrete
        {
            get
            {
                return this.modFreteField;
            }
            set
            {
                this.modFreteField = value;
            }
        }

        /// <remarks/>
        public object transporta
        {
            get
            {
                return this.transportaField;
            }
            set
            {
                this.transportaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFePag
    {

        private nfeProcNFeInfNFePagDetPag detPagField;

        private string[] textField;

        /// <remarks/>
        public nfeProcNFeInfNFePagDetPag detPag
        {
            get
            {
                return this.detPagField;
            }
            set
            {
                this.detPagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFePagDetPag
    {

        private byte indPagField;

        private byte tPagField;

        private decimal vPagField;

        /// <remarks/>
        public byte indPag
        {
            get
            {
                return this.indPagField;
            }
            set
            {
                this.indPagField = value;
            }
        }

        /// <remarks/>
        public byte tPag
        {
            get
            {
                return this.tPagField;
            }
            set
            {
                this.tPagField = value;
            }
        }

        /// <remarks/>
        public decimal vPag
        {
            get
            {
                return this.vPagField;
            }
            set
            {
                this.vPagField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeInfAdic
    {

        private string infAdFiscoField;

        private string infCplField;

        private nfeProcNFeInfNFeInfAdicObsCont obsContField;

        private string[] textField;

        /// <remarks/>
        public string infAdFisco
        {
            get
            {
                return this.infAdFiscoField;
            }
            set
            {
                this.infAdFiscoField = value;
            }
        }

        /// <remarks/>
        public string infCpl
        {
            get
            {
                return this.infCplField;
            }
            set
            {
                this.infCplField = value;
            }
        }

        /// <remarks/>
        public nfeProcNFeInfNFeInfAdicObsCont obsCont
        {
            get
            {
                return this.obsContField;
            }
            set
            {
                this.obsContField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeInfAdicObsCont
    {

        private byte xTextoField;

        private string xCampoField;

        /// <remarks/>
        public byte xTexto
        {
            get
            {
                return this.xTextoField;
            }
            set
            {
                this.xTextoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampo
        {
            get
            {
                return this.xCampoField;
            }
            set
            {
                this.xCampoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcNFeInfNFeInfRespTec
    {

        private ulong cNPJField;

        private string xContatoField;

        private string emailField;

        private ulong foneField;

        /// <remarks/>
        public ulong CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        /// <remarks/>
        public string xContato
        {
            get
            {
                return this.xContatoField;
            }
            set
            {
                this.xContatoField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public ulong fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class Signature
    {

        private SignatureSignedInfo signedInfoField;

        private string signatureValueField;

        private SignatureKeyInfo keyInfoField;

        private string[] textField;

        /// <remarks/>
        public SignatureSignedInfo SignedInfo
        {
            get
            {
                return this.signedInfoField;
            }
            set
            {
                this.signedInfoField = value;
            }
        }

        /// <remarks/>
        public string SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        /// <remarks/>
        public SignatureKeyInfo KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfo
    {

        private SignatureSignedInfoCanonicalizationMethod canonicalizationMethodField;

        private SignatureSignedInfoSignatureMethod signatureMethodField;

        private SignatureSignedInfoReference referenceField;

        private string[] textField;

        /// <remarks/>
        public SignatureSignedInfoCanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        public SignatureSignedInfoSignatureMethod SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        /// <remarks/>
        public SignatureSignedInfoReference Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoCanonicalizationMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoSignatureMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReference
    {

        private SignatureSignedInfoReferenceTransform[] transformsField;

        private SignatureSignedInfoReferenceDigestMethod digestMethodField;

        private string digestValueField;

        private string[] textField;

        private string uRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public SignatureSignedInfoReferenceTransform[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        public SignatureSignedInfoReferenceDigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        public string DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReferenceTransform
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReferenceDigestMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureKeyInfo
    {

        private SignatureKeyInfoX509Data x509DataField;

        private string[] textField;

        /// <remarks/>
        public SignatureKeyInfoX509Data X509Data
        {
            get
            {
                return this.x509DataField;
            }
            set
            {
                this.x509DataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureKeyInfoX509Data
    {

        private string x509CertificateField;

        /// <remarks/>
        public string X509Certificate
        {
            get
            {
                return this.x509CertificateField;
            }
            set
            {
                this.x509CertificateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcProtNFe
    {

        private nfeProcProtNFeInfProt infProtField;

        private string[] textField;

        private decimal versaoField;

        /// <remarks/>
        public nfeProcProtNFeInfProt infProt
        {
            get
            {
                return this.infProtField;
            }
            set
            {
                this.infProtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class nfeProcProtNFeInfProt
    {

        private byte tpAmbField;

        private string verAplicField;

        private string chNFeField;

        private System.DateTime dhRecbtoField;

        private ulong nProtField;

        private string digValField;

        private byte cStatField;

        private string xMotivoField;

        /// <remarks/>
        public byte tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        /// <remarks/>
        public ulong nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        /// <remarks/>
        public string digVal
        {
            get
            {
                return this.digValField;
            }
            set
            {
                this.digValField = value;
            }
        }

        /// <remarks/>
        public byte cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }
    }


}
