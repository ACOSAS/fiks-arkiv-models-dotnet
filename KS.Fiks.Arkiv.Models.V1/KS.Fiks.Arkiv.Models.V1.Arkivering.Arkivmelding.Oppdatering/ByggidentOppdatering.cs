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
    [System.Xml.Serialization.XmlTypeAttribute("byggidentOppdatering", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmeldingoppdater" +
        "ing/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ByggidentOppdatering
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("systemID")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.SystemID SystemID { get; set; }
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("bygningsnummer")]
        public int BygningsnummerValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool BygningsnummerValueSpecified { get; set; }
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> Bygningsnummer
        {
            get
            {
                if (this.BygningsnummerValueSpecified)
                {
                    return this.BygningsnummerValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BygningsnummerValue = value.GetValueOrDefault();
                this.BygningsnummerValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("endringsloepenummer")]
        public int EndringsloepenummerValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool EndringsloepenummerValueSpecified { get; set; }
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> Endringsloepenummer
        {
            get
            {
                if (this.EndringsloepenummerValueSpecified)
                {
                    return this.EndringsloepenummerValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EndringsloepenummerValue = value.GetValueOrDefault();
                this.EndringsloepenummerValueSpecified = value.HasValue;
            }
        }
    }
}
