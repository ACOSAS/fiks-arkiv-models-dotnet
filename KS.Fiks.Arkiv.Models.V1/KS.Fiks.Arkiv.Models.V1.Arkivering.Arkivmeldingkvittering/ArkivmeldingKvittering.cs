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
    [System.Xml.Serialization.XmlTypeAttribute("arkivmeldingKvittering", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmeldingkvitteri" +
        "ng/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("arkivmeldingKvittering", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmeldingkvitteri" +
        "ng/v1")]
    public partial class ArkivmeldingKvittering
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("system")]
        public string System { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("meldingId")]
        public string MeldingId { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("tidspunkt", DataType="dateTime")]
        public System.DateTime Tidspunkt { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<MappeKvittering> _mappeKvittering;
        
        [System.Xml.Serialization.XmlElementAttribute("mappeKvittering")]
        public System.Collections.ObjectModel.Collection<MappeKvittering> MappeKvittering
        {
            get
            {
                return this._mappeKvittering;
            }
            private set
            {
                this._mappeKvittering = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MappeKvitteringSpecified
        {
            get
            {
                return (this.MappeKvittering.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public ArkivmeldingKvittering()
        {
            this._mappeKvittering = new System.Collections.ObjectModel.Collection<MappeKvittering>();
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
