//HintName: G.Models.CreateDocumentRequestVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDocumentRequestVariant1
    {
        /// <summary>
        /// File format of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentType", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateDocumentRequestVariant1DocumentTypeJsonConverter))]
        public global::G.CreateDocumentRequestVariant1DocumentType DocumentType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentRequestVariant1" /> class.
        /// </summary>
        /// <param name="documentType">
        /// File format of the file
        /// </param>
        public CreateDocumentRequestVariant1(
            global::G.CreateDocumentRequestVariant1DocumentType documentType)
        {
            this.DocumentType = documentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentRequestVariant1" /> class.
        /// </summary>
        public CreateDocumentRequestVariant1()
        {
        }
    }
}