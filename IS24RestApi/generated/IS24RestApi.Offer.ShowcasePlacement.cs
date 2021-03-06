//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.214.0.
namespace IS24RestApi.Offer.ShowcasePlacement
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para xml:lang="de-DE">Schaufensterplatzierung</para>
    /// <para xml:lang="de-DE">Showcaseplacement</para>
    /// <para xml:lang="en">showcase placement.</para>
    /// <para xml:lang="en">showcase placement</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.214.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Showcaseplacement", Namespace="http://rest.immobilienscout24.de/schema/offer/showcaseplacement/1.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("showcaseplacement", Namespace="http://rest.immobilienscout24.de/schema/offer/showcaseplacement/1.0")]
    public partial class Showcaseplacement
    {
        
        /// <summary>
        /// <para xml:lang="de-DE">Schaufensterplatzierung-Ergebnis</para>
        /// <para xml:lang="en">result code of the operation</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("messageCode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MessageCode { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Schaufensterplatzierung-Ergebnis Nachricht</para>
        /// <para xml:lang="en">message result of the operation</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("message", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Message { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Leistung gebucht von/bis</para>
        /// <para xml:lang="en">the period in which a service is active/available</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("servicePeriod", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IS24RestApi.Common.DateRange ServicePeriod { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">kunden referenznummer der immobilie (nur Ausgabe)</para>
        /// <para xml:lang="en">external id of real estate OUTPUT ONLY</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("externalId", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExternalId { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Id des Immobilienobjektes.</para>
        /// <para xml:lang="en">Id of realestate.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("realestateid", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Realestateid { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Rabattkode</para>
        /// <para xml:lang="en">voucher number.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("voucher", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Voucher { get; set; }
    }
    
    /// <summary>
    /// <para xml:lang="de-DE">Liste von Schaufensterplatzierungen</para>
    /// <para xml:lang="de-DE">Liste von Showcaseplacements</para>
    /// <para xml:lang="en">List of Showcaseplacements</para>
    /// <para xml:lang="en">Liste of showcase placements</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.214.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Showcaseplacements", Namespace="http://rest.immobilienscout24.de/schema/offer/showcaseplacement/1.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("showcaseplacements", Namespace="http://rest.immobilienscout24.de/schema/offer/showcaseplacement/1.0")]
    public partial class Showcaseplacements
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Showcaseplacement> _showcaseplacement;
        
        /// <summary>
        /// <para xml:lang="de-DE">ein Anhang</para>
        /// <para xml:lang="en">an attachment</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("showcaseplacement", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<Showcaseplacement> Showcaseplacement
        {
            get
            {
                return this._showcaseplacement;
            }
            private set
            {
                this._showcaseplacement = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Showcaseplacement-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Showcaseplacement collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShowcaseplacementSpecified
        {
            get
            {
                return (this.Showcaseplacement.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Showcaseplacements" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Showcaseplacements" /> class.</para>
        /// </summary>
        public Showcaseplacements()
        {
            this._showcaseplacement = new System.Collections.ObjectModel.Collection<Showcaseplacement>();
        }
        
        /// <summary>
        /// <para xml:lang="de-DE">Link zum Element.</para>
        /// <para xml:lang="en">Link to the entity entry.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("href", Namespace="http://www.w3.org/1999/xlink")]
        public string Href { get; set; }
    }
}
