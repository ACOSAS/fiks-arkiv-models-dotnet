//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.662.0
namespace KS.Fiks.Arkiv.Models.V1.Feilmelding
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.662.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("feilmeldingBase", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/feil/feilmelding/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Ikkefunnet))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(KS.Fiks.Arkiv.Models.V1.Feilmelding.Serverfeil))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(KS.Fiks.Arkiv.Models.V1.Feilmelding.Ugyldigforespoersel))]
    public partial class FeilmeldingBase
    {
        
        /// <summary>
        /// <para>M001-a</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("feilId")]
        public string FeilId { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("feilmelding")]
        public string Feilmelding { get; set; }
        
        /// <summary>
        /// <para>M001-a</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}")]
        [System.Xml.Serialization.XmlElementAttribute("korrelasjonsid")]
        public string Korrelasjonsid { get; set; }
    }
}
