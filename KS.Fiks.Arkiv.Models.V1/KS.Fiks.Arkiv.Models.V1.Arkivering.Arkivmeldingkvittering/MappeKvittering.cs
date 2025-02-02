//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.662.0
namespace KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmeldingkvittering
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.662.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("mappeKvittering", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmeldingkvitteri" +
        "ng/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SaksmappeKvittering))]
    public partial class MappeKvittering
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("systemID")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.SystemID SystemID { get; set; }
        
        /// <summary>
        /// <para>M003</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("mappeID")]
        public string MappeID { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("referanseForeldermappe")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.ReferanseTilMappe ReferanseForeldermappe { get; set; }
        
        /// <summary>
        /// <para>M600</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("opprettetDato", DataType="dateTime")]
        public System.DateTime OpprettetDatoValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool OpprettetDatoValueSpecified { get; set; }
        
        /// <summary>
        /// <para>M600</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> OpprettetDato
        {
            get
            {
                if (this.OpprettetDatoValueSpecified)
                {
                    return this.OpprettetDatoValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OpprettetDatoValue = value.GetValueOrDefault();
                this.OpprettetDatoValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>M601</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
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
        
        [System.Xml.Serialization.XmlElementAttribute("referanseEksternNoekkel")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.EksternNoekkel ReferanseEksternNoekkel { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<MappeKvittering> _mappeKvitteringProperty;
        
        [System.Xml.Serialization.XmlElementAttribute("mappeKvittering")]
        public System.Collections.ObjectModel.Collection<MappeKvittering> MappeKvitteringProperty
        {
            get
            {
                return this._mappeKvitteringProperty;
            }
            private set
            {
                this._mappeKvitteringProperty = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MappeKvitteringPropertySpecified
        {
            get
            {
                return (this.MappeKvitteringProperty.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public MappeKvittering()
        {
            this._mappeKvitteringProperty = new System.Collections.ObjectModel.Collection<MappeKvittering>();
            this._registreringKvittering = new System.Collections.ObjectModel.Collection<RegistreringKvittering>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<RegistreringKvittering> _registreringKvittering;
        
        [System.Xml.Serialization.XmlElementAttribute("registreringKvittering")]
        public System.Collections.ObjectModel.Collection<RegistreringKvittering> RegistreringKvittering
        {
            get
            {
                return this._registreringKvittering;
            }
            private set
            {
                this._registreringKvittering = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegistreringKvitteringSpecified
        {
            get
            {
                return (this.RegistreringKvittering.Count != 0);
            }
        }
    }
}
