//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.662.0
namespace KS.Fiks.Arkiv.Models.V1.Metadatakatalog
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.662.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("saksJournalpostnummer", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/metadatakatalog/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SaksJournalpostnummer : Saksnummer
    {
        
        /// <summary>
        /// <para>M015</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("journalpostnummer")]
        public int Journalpostnummer { get; set; }
    }
}
