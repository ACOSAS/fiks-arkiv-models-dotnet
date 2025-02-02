//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.662.0
namespace KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.662.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("arkivmelding", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmelding/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("arkivmelding", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmelding/v1")]
    public partial class Arkivmelding
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
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("antallFiler")]
        public int AntallFiler { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Mappe> _mappe;
        
        [System.Xml.Serialization.XmlElementAttribute("mappe")]
        public System.Collections.ObjectModel.Collection<Mappe> Mappe
        {
            get
            {
                return this._mappe;
            }
            private set
            {
                this._mappe = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MappeSpecified
        {
            get
            {
                return (this.Mappe.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public Arkivmelding()
        {
            this._mappe = new System.Collections.ObjectModel.Collection<Mappe>();
            this._registrering = new System.Collections.ObjectModel.Collection<Registrering>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Registrering> _registrering;
        
        [System.Xml.Serialization.XmlElementAttribute("registrering")]
        public System.Collections.ObjectModel.Collection<Registrering> Registrering
        {
            get
            {
                return this._registrering;
            }
            private set
            {
                this._registrering = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegistreringSpecified
        {
            get
            {
                return (this.Registrering.Count != 0);
            }
        }
    }
}
