//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.662.0
namespace KS.Fiks.Arkiv.Models.V1.Arkivstruktur.Minimum
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.662.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("journalpostMinimum", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivstruktur/minimu" +
        "m/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JournalpostMedSaksmappeMinimum))]
    public partial class JournalpostMinimum : RegistreringMinimum
    {
        
        /// <summary>
        /// <para>M013</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("journalaar")]
        public int Journalaar { get; set; }
        
        /// <summary>
        /// <para>M014</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("journalsekvensnummer")]
        public int Journalsekvensnummer { get; set; }
        
        /// <summary>
        /// <para>M015</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("journalpostnummer")]
        public int Journalpostnummer { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("journalposttype")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.Journalposttype Journalposttype { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("journalstatus")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.Journalstatus Journalstatus { get; set; }
        
        /// <summary>
        /// <para>M101</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("journaldato", DataType="date")]
        public System.DateTime Journaldato { get; set; }
        
        /// <summary>
        /// <para>M103</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("dokumentetsDato", DataType="date")]
        public System.DateTime DokumentetsDatoValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool DokumentetsDatoValueSpecified { get; set; }
        
        /// <summary>
        /// <para>M103</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> DokumentetsDato
        {
            get
            {
                if (this.DokumentetsDatoValueSpecified)
                {
                    return this.DokumentetsDatoValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DokumentetsDatoValue = value.GetValueOrDefault();
                this.DokumentetsDatoValueSpecified = value.HasValue;
            }
        }
    }
}
