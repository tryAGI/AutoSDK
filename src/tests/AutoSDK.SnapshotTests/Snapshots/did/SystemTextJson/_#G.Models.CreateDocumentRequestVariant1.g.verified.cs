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
        [global::System.Text.Json.Serialization.JsonPropertyName("documentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateDocumentRequestVariant1DocumentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateDocumentRequestVariant1DocumentType DocumentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentRequestVariant1" /> class.
        /// </summary>
        /// <param name="documentType">
        /// File format of the file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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