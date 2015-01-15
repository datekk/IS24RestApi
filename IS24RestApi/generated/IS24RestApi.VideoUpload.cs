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
namespace IS24RestApi.VideoUpload
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para xml:lang="de-DE">Informationen, die zum Hochladen einer Video-Datei erforderlich
    ///                sind. Das Hochladen erfolgt auf API-Client-Seite.
    ///            </para>
    /// <para xml:lang="en">Information needed for uploading of a video file. Uploading the
    ///                video file is done by API-clients.
    ///            </para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5493.32546")]
    [System.Xml.Serialization.XmlTypeAttribute("VideoUploadTicket", Namespace="http://rest.immobilienscout24.de/schema/videoupload/1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("videoUploadTicket", Namespace="http://rest.immobilienscout24.de/schema/videoupload/1.0")]
    public partial class VideoUploadTicket
    {
        
        /// <summary>
        /// <para xml:lang="de-DE">An diese URL sendet der API-Client einen
        ///                        Mutlipart-POST-Request mit der Video-Datei und einem Authentication-Token.
        ///                        Ein Part ist "videofile" mit der Video-Datei, der andere "auth", der
        ///                        Authentication-Token.
        ///                    </para>
        /// <para xml:lang="en">The API-client sends a multi-part-POST request
        ///                        to this URL with the video file and an authentication-token. One part is
        ///                        "videofile" with the video file, the other is "auth", the authentication-token. 
        ///                    </para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("uploadUrl", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="anyURI")]
        public string UploadUrl { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("validUntil", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime ValidUntil { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Diese Id dient als Referenz des noch hochzuladenden Videos
        ///                        und muss nach dem Hochladen (durch den API-Client) beim Anlegen des Attachments übergeben
        ///                        werden.
        ///                    </para>
        /// <para xml:lang="en">This Id is used as a reference to the yet-to-be-uploaded
        ///                        video. After uploading (done by the API-client) it must be provided when creating an
        ///                        attachment.
        ///                    </para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("videoId", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string VideoId { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Beim Hochladen wird der Part mit dem Namen "auth"
        ///                        mit dem Wert dieses Elements befüllt. Nur zeitweilig gültig, siehe "validUntil".
        ///                    </para>
        /// <para xml:lang="en">When uploading the part named "auth" has to be filled
        ///                        with the value of this element. Only temporarily valid, see "validUntil".
        ///                    </para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("auth", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Auth { get; set; }
    }
}
