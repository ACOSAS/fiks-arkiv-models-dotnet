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
    [System.Xml.Serialization.XmlTypeAttribute("klassifikasjonOppdateringer", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmeldingoppdater" +
        "ing/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KlassifikasjonOppdateringer
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<KlassifikasjonOppdatering> _oppdatering;
        
        [System.Xml.Serialization.XmlElementAttribute("oppdatering")]
        public System.Collections.ObjectModel.Collection<KlassifikasjonOppdatering> Oppdatering
        {
            get
            {
                return this._oppdatering;
            }
            private set
            {
                this._oppdatering = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OppdateringSpecified
        {
            get
            {
                return (this.Oppdatering.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public KlassifikasjonOppdateringer()
        {
            this._oppdatering = new System.Collections.ObjectModel.Collection<KlassifikasjonOppdatering>();
            this._slett = new System.Collections.ObjectModel.Collection<KlassifikasjonSlett>();
            this._ny = new System.Collections.ObjectModel.Collection<KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding.Klassifikasjon>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<KlassifikasjonSlett> _slett;
        
        [System.Xml.Serialization.XmlElementAttribute("slett")]
        public System.Collections.ObjectModel.Collection<KlassifikasjonSlett> Slett
        {
            get
            {
                return this._slett;
            }
            private set
            {
                this._slett = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SlettSpecified
        {
            get
            {
                return (this.Slett.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding.Klassifikasjon> _ny;
        
        [System.Xml.Serialization.XmlElementAttribute("ny")]
        public System.Collections.ObjectModel.Collection<KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding.Klassifikasjon> Ny
        {
            get
            {
                return this._ny;
            }
            private set
            {
                this._ny = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NySpecified
        {
            get
            {
                return (this.Ny.Count != 0);
            }
        }
    }
}
