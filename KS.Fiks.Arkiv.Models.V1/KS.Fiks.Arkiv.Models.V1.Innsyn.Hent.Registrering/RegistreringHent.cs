//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.662.0
namespace KS.Fiks.Arkiv.Models.V1.Innsyn.Hent.Registrering
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.662.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("registreringHent", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/registrering/hent/v1" +
        "")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("registreringHent", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/registrering/hent/v1" +
        "")]
    public partial class RegistreringHent
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("referanseTilRegistrering")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.ReferanseTilRegistrering ReferanseTilRegistrering { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("inkluder")]
        public Inkluder InkluderValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool InkluderValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<Inkluder> Inkluder
        {
            get
            {
                if (this.InkluderValueSpecified)
                {
                    return this.InkluderValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InkluderValue = value.GetValueOrDefault();
                this.InkluderValueSpecified = value.HasValue;
            }
        }
    }
}
