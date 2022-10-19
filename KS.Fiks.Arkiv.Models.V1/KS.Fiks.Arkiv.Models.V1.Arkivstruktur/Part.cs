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
    [System.Xml.Serialization.XmlTypeAttribute("part", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivstruktur/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("part", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivstruktur/v1")]
    public partial class Part
    {
        
        /// <summary>
        /// <para>M010</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("partID")]
        public string PartID { get; set; }
        
        /// <summary>
        /// <para>M302</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("partNavn")]
        public string PartNavn { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("partRolle")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.PartRolle PartRolle { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _postadresse;
        
        /// <summary>
        /// <para>M406</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("postadresse")]
        public System.Collections.ObjectModel.Collection<string> Postadresse
        {
            get
            {
                return this._postadresse;
            }
            private set
            {
                this._postadresse = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PostadresseSpecified
        {
            get
            {
                return (this.Postadresse.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public Part()
        {
            this._postadresse = new System.Collections.ObjectModel.Collection<string>();
            this._telefonnummer = new System.Collections.ObjectModel.Collection<string>();
        }
        
        /// <summary>
        /// <para>M407</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("postnummer")]
        public string Postnummer { get; set; }
        
        /// <summary>
        /// <para>M408</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("poststed")]
        public string Poststed { get; set; }
        
        /// <summary>
        /// <para>M409</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("land")]
        public string Land { get; set; }
        
        /// <summary>
        /// <para>M410</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("epostadresse")]
        public string Epostadresse { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _telefonnummer;
        
        /// <summary>
        /// <para>M411</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("telefonnummer")]
        public System.Collections.ObjectModel.Collection<string> Telefonnummer
        {
            get
            {
                return this._telefonnummer;
            }
            private set
            {
                this._telefonnummer = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TelefonnummerSpecified
        {
            get
            {
                return (this.Telefonnummer.Count != 0);
            }
        }
        
        /// <summary>
        /// <para>M412</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("kontaktperson")]
        public string Kontaktperson { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("virksomhetsspesifikkeMetadata")]
        public object VirksomhetsspesifikkeMetadata { get; set; }
    }
}
