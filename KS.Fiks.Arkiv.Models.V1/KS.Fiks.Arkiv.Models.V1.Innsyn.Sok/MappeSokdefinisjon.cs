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
    [System.Xml.Serialization.XmlTypeAttribute("mappeSokdefinisjon", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/sok/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MappeSokdefinisjon : Sokdefinisjon
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<MappeInkluder> _inkluder;
        
        [System.Xml.Serialization.XmlElementAttribute("inkluder")]
        public System.Collections.ObjectModel.Collection<MappeInkluder> Inkluder
        {
            get
            {
                return this._inkluder;
            }
            private set
            {
                this._inkluder = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InkluderSpecified
        {
            get
            {
                return (this.Inkluder.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public MappeSokdefinisjon()
        {
            this._inkluder = new System.Collections.ObjectModel.Collection<MappeInkluder>();
            this._parametere = new System.Collections.ObjectModel.Collection<MappeParameter>();
            this._sortering = new System.Collections.ObjectModel.Collection<MappeSortering>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<MappeParameter> _parametere;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("parametere")]
        public System.Collections.ObjectModel.Collection<MappeParameter> Parametere
        {
            get
            {
                return this._parametere;
            }
            private set
            {
                this._parametere = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<MappeSortering> _sortering;
        
        [System.Xml.Serialization.XmlElementAttribute("sortering")]
        public System.Collections.ObjectModel.Collection<MappeSortering> Sortering
        {
            get
            {
                return this._sortering;
            }
            private set
            {
                this._sortering = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SorteringSpecified
        {
            get
            {
                return (this.Sortering.Count != 0);
            }
        }
    }
}
