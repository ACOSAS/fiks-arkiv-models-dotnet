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
    [System.Xml.Serialization.XmlTypeAttribute("matrikkelnummerOppdateringer", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmeldingoppdater" +
        "ing/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MatrikkelnummerOppdateringer
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding.Matrikkelnummer> _ny;
        
        [System.Xml.Serialization.XmlElementAttribute("ny")]
        public System.Collections.ObjectModel.Collection<KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding.Matrikkelnummer> Ny
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
        
        /// <summary>
        /// </summary>
        public MatrikkelnummerOppdateringer()
        {
            this._ny = new System.Collections.ObjectModel.Collection<KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding.Matrikkelnummer>();
            this._slett = new System.Collections.ObjectModel.Collection<MatrikkelnummerSlett>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<MatrikkelnummerSlett> _slett;
        
        [System.Xml.Serialization.XmlElementAttribute("slett")]
        public System.Collections.ObjectModel.Collection<MatrikkelnummerSlett> Slett
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
    }
}
