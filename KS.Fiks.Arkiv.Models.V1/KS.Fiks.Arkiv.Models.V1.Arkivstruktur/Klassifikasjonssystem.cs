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
    [System.Xml.Serialization.XmlTypeAttribute("klassifikasjonssystem", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivstruktur/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("klassifikasjonssystem", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivstruktur/v1")]
    public partial class Klassifikasjonssystem
    {
        
        /// <summary>
        /// <para>M00...</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("klassifikasjonssystemID")]
        public string KlassifikasjonssystemID { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("klassifikasjonstype")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.Klassifikasjonstype Klassifikasjonstype { get; set; }
        
        /// <summary>
        /// <para>M020</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("tittel")]
        public string Tittel { get; set; }
        
        /// <summary>
        /// <para>M021</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("beskrivelse")]
        public string Beskrivelse { get; set; }
        
        /// <summary>
        /// <para>M600</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("opprettetDato", DataType="dateTime")]
        public System.DateTime OpprettetDato { get; set; }
        
        /// <summary>
        /// <para>M601</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("opprettetAv")]
        public string OpprettetAv { get; set; }
        
        /// <summary>
        /// <para>M602</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("avsluttetDato", DataType="dateTime")]
        public System.DateTime AvsluttetDatoValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool AvsluttetDatoValueSpecified { get; set; }
        
        /// <summary>
        /// <para>M602</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> AvsluttetDato
        {
            get
            {
                if (this.AvsluttetDatoValueSpecified)
                {
                    return this.AvsluttetDatoValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AvsluttetDatoValue = value.GetValueOrDefault();
                this.AvsluttetDatoValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>M603</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("avsluttetAv")]
        public string AvsluttetAv { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Klasse> _klasse;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("klasse")]
        public System.Collections.ObjectModel.Collection<Klasse> Klasse
        {
            get
            {
                return this._klasse;
            }
            private set
            {
                this._klasse = value;
            }
        }
        
        /// <summary>
        /// </summary>
        public Klassifikasjonssystem()
        {
            this._klasse = new System.Collections.ObjectModel.Collection<Klasse>();
        }
    }
}
