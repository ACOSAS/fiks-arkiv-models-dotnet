//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.662.0
namespace KS.Fiks.Arkiv.Models.V1.Arkivstruktur
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.662.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("gradering", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivstruktur/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("gradering", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivstruktur/v1")]
    public partial class Gradering
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("grad")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.Grad Grad { get; set; }
        
        /// <summary>
        /// <para>M624</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("graderingsdato", DataType="dateTime")]
        public System.DateTime Graderingsdato { get; set; }
        
        /// <summary>
        /// <para>M625</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("gradertAv")]
        public string GradertAv { get; set; }
        
        /// <summary>
        /// <para>M626</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("nedgraderingsdato", DataType="dateTime")]
        public System.DateTime NedgraderingsdatoValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool NedgraderingsdatoValueSpecified { get; set; }
        
        /// <summary>
        /// <para>M626</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> Nedgraderingsdato
        {
            get
            {
                if (this.NedgraderingsdatoValueSpecified)
                {
                    return this.NedgraderingsdatoValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NedgraderingsdatoValue = value.GetValueOrDefault();
                this.NedgraderingsdatoValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>M627</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("nedgradertAv")]
        public string NedgradertAv { get; set; }
    }
}
