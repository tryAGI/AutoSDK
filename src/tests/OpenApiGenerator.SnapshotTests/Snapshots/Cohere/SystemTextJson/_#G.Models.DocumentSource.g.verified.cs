//HintName: G.Models.DocumentSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A document source object containing the unique identifier of the document and the document itself.
    /// </summary>
    public sealed partial class DocumentSource
    {
        /// <summary>
        /// The unique identifier of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::G.DocumentSourceDocument? Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}