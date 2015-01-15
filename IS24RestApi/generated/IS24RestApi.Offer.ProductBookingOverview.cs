//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 0.5.5493.32546.
namespace IS24RestApi.Offer.ProductBookingOverview
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para>Overview of bookings which are necessary for the product recommondation</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5493.32546")]
    [System.Xml.Serialization.XmlTypeAttribute("productBookingOverview", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("productBookingOverview", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0")]
    public partial class ProductBookingOverview
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("productBooking", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0")]
        public System.Collections.ObjectModel.Collection<ProductBooking> ProductBooking { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ProductBooking-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ProductBooking collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductBookingSpecified
        {
            get
            {
                return (this.ProductBooking.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ProductBookingOverview" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ProductBookingOverview" /> class.</para>
        /// </summary>
        public ProductBookingOverview()
        {
            this.ProductBooking = new System.Collections.ObjectModel.Collection<ProductBooking>();
        }
    }
    
    /// <summary>
    /// <para>Booking with name, price and number of bookings</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5493.32546")]
    [System.Xml.Serialization.XmlTypeAttribute("productBooking", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ProductBooking
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("name", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0", DataType="string")]
        public string Name { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("numberOfBookings", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0", DataType="long")]
        public long NumberOfBookings { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("price", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0", DataType="decimal")]
        public decimal Price { get; set; }
    }
}
