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
    [System.Xml.Serialization.XmlTypeAttribute("saksmappe", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivstruktur/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("saksmappe", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivstruktur/v1")]
    public partial class Saksmappe : Mappe
    {
        
        /// <summary>
        /// <para>M011</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("saksaar")]
        public int Saksaar { get; set; }
        
        /// <summary>
        /// <para>M012</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("sakssekvensnummer")]
        public int Sakssekvensnummer { get; set; }
        
        /// <summary>
        /// <para>M100</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("saksdato", DataType="date")]
        public System.DateTime Saksdato { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("administrativEnhet")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.AdministrativEnhet AdministrativEnhet { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("saksansvarlig")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.Saksansvarlig Saksansvarlig { get; set; }
        
        /// <summary>
        /// <para>M308</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("journalenhet")]
        public string Journalenhet { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("saksstatus")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.Saksstatus Saksstatus { get; set; }
        
        /// <summary>
        /// <para>M106</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("utlaantDato", DataType="date")]
        public System.DateTime UtlaantDatoValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool UtlaantDatoValueSpecified { get; set; }
        
        /// <summary>
        /// <para>M106</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> UtlaantDato
        {
            get
            {
                if (this.UtlaantDatoValueSpecified)
                {
                    return this.UtlaantDatoValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UtlaantDatoValue = value.GetValueOrDefault();
                this.UtlaantDatoValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>M309</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("utlaantTil")]
        public string UtlaantTil { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Presedens> _presedens;
        
        [System.Xml.Serialization.XmlElementAttribute("presedens")]
        public System.Collections.ObjectModel.Collection<Presedens> Presedens
        {
            get
            {
                return this._presedens;
            }
            private set
            {
                this._presedens = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PresedensSpecified
        {
            get
            {
                return (this.Presedens.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public Saksmappe()
        {
            this._presedens = new System.Collections.ObjectModel.Collection<Presedens>();
        }
    }
}
