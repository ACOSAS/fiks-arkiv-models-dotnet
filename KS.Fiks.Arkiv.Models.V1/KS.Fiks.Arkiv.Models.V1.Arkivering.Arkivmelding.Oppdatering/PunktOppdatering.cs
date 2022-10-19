//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.662.0
namespace KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding.Oppdatering
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.662.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("punktOppdatering", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmeldingoppdater" +
        "ing/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PunktOppdatering
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("systemID")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.SystemID SystemID { get; set; }
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("koordinatsystem")]
        public string Koordinatsystem { get; set; }
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("x")]
        public double XValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool XValueSpecified { get; set; }
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> X
        {
            get
            {
                if (this.XValueSpecified)
                {
                    return this.XValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.XValue = value.GetValueOrDefault();
                this.XValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("y")]
        public double YValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool YValueSpecified { get; set; }
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> Y
        {
            get
            {
                if (this.YValueSpecified)
                {
                    return this.YValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.YValue = value.GetValueOrDefault();
                this.YValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("z")]
        public double ZValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ZValueSpecified { get; set; }
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> Z
        {
            get
            {
                if (this.ZValueSpecified)
                {
                    return this.ZValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ZValue = value.GetValueOrDefault();
                this.ZValueSpecified = value.HasValue;
            }
        }
    }
}
