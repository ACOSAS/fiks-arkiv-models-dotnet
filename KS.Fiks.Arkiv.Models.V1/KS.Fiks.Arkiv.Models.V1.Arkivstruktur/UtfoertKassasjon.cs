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
    [System.Xml.Serialization.XmlTypeAttribute("utfoertKassasjon", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivstruktur/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UtfoertKassasjon
    {
        
        /// <summary>
        /// <para>M630</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("kassertDato", DataType="dateTime")]
        public System.DateTime KassertDato { get; set; }
        
        /// <summary>
        /// <para>M631</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("kassertAv")]
        public string KassertAv { get; set; }
    }
}
