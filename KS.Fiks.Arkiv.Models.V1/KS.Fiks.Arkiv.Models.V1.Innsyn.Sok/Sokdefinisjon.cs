//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.662.0
namespace KS.Fiks.Arkiv.Models.V1.Innsyn.Sok
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.662.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("sokdefinisjon", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/sok/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DokumentbeskrivelseSokdefinisjon))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JournalpostMedSaksmappeSokdefinisjon))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JournalpostSokdefinisjon))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MappeSokdefinisjon))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegistreringSokdefinisjon))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SaksmappeSokdefinisjon))]
    public abstract partial class Sokdefinisjon
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private KS.Fiks.Arkiv.Models.V1.Arkivstruktur.Responstype _responstype = KS.Fiks.Arkiv.Models.V1.Arkivstruktur.Responstype.Minimum;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("responstype")]
        public KS.Fiks.Arkiv.Models.V1.Arkivstruktur.Responstype Responstype
        {
            get
            {
                return this._responstype;
            }
            set
            {
                this._responstype = value;
            }
        }
    }
}
