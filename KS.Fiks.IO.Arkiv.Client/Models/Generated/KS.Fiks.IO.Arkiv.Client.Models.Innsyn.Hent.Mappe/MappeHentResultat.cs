//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.629.0
namespace KS.Fiks.IO.Arkiv.Client.Models.Innsyn.Hent.Mappe
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.629.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("mappeHentResultat", Namespace="http://www.arkivverket.no/standarder/noark5/mappe/hent/resultat/v2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("mappeHentResultat", Namespace="http://www.arkivverket.no/standarder/noark5/mappe/hent/resultat/v2")]
    public partial class MappeHentResultat
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("mappe")]
        public KS.Fiks.IO.Arkiv.Client.Models.Arkivering.Arkivmelding.Mappe Mappe { get; set; }
    }
}
